﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class Banco
    {
        private string stringConexao = "Data Source=192.168.3.247,64001;" +
            "Initial Catalog=DEV; User ID=luis.branco;" +
            "password=yondaime10@;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);//cria o comando
                command.ExecuteNonQuery();//executa o comando

                SqlDataAdapter adapter = new SqlDataAdapter(command);//adapter, que manuseia os dados do comando
                DataTable dt = new DataTable();//Tabela em memória
                adapter.Fill(dt);//preenche o datatable
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }

}
