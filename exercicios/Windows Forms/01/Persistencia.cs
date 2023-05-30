using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Persistencia
    {
        private const string EntradaFile = "C:\\Users\\bpl_\\source\\repos\\AcademiaAtos\\exercicios\\Windows Forms\\01\\LOG\\entrada.dat";
        private const string SaidaFile = "C:\\Users\\bpl_\\source\\repos\\AcademiaAtos\\exercicios\\Windows Forms\\01\\LOG\\saida.dat";

        public static void checarArquivo() {
            if (File.Exists(EntradaFile))
            {
                Console.WriteLine("O arquivo já existe.");
            }

        }

        public static void entradaVeiculo(DateTime entrada, string placa) {
            MessageBox.Show("Entrada de veiculo!!!");
        }
        public static void saidaVeiculo() { }

        public static void atualizarGrid() { }
        public static int veiculoEstacionado() {
            return 0;
        }

    }
}

