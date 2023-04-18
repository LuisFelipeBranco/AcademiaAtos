using System.Numerics;

namespace _05
{/*
  5) Leia duas matrizes 2x3 de números double. 
    Imprima a soma destas duas matrizes.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int linha = 2, coluna = 3;
            double[,] matriz = new double[linha, coluna];
            double[,] matriz2 = new double[linha, coluna];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 10); //gera um número aleatório entre 1 e 10
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = random.Next(0, 10); //gera um número aleatório entre 1 e 10
                }
            }

            Console.WriteLine("Matriz desenhada:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz[i, 0]} - {matriz[i, 1]} - {matriz[i, 2]}");
            }

            Console.WriteLine("Matriz2 desenhada:");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz2[i, 0]} - {matriz2[i, 1]} - {matriz2[i, 2]}");
            }

            Console.WriteLine("________________________________________________________________");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz[i,0]} - {matriz[i, 1]} - {matriz[i, 2]}");
            }

        }
    }
}