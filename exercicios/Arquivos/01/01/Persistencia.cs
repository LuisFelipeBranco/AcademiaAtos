using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Persistencia
    {
        public void lerArquivo(string nomeArquivo)
        {
            int contador = 0;
            List<string> datas = new List<string>();
            List<string> obs = new List<string>();
            string[] dados;
            string linha;

            try {
                
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                
                while (!leitor.EndOfStream) {

                    //Console.WriteLine(leitor.ReadLine());
                    linha = leitor.ReadLine();//le a linha
                    dados = linha.Split(' ');//divide a linha 
                    
                    datas.Add(dados[0]);
                    obs.Add(dados[1]);

                    contador++;
                }
                Console.WriteLine($"Contador de linhas: {contador}");

            } 
            catch {
                Console.WriteLine("Problemas na leitura do arquivo!!");
            }

        }
    }
}
