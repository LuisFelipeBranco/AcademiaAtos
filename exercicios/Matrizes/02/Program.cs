using System.Numerics;

namespace _02
{/*
  2) Solicite ao usuário, preencher uma Matriz 3x3

Informe ao usuário:
*A soma dos elementos de cada linha
	-Ex: Linha 1: 30
	     Linha 2: 17
*A soma dos elementos de cada coluna
	-Ex: Coluna 1: 23
	     Coluna 2: 36
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int cont = 0;
            
            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 3; j++) {

                    Console.WriteLine($"Informe o elemento que preencherá a linha {i+1} coluna {j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Matriz resultante: ");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{matriz[i, 0]} - {matriz[i, 1]} - {matriz[i, 2]}");
            }

            Console.WriteLine("Soma das linhas:");

            for (int i = 0; i < 3; i++) {
                cont = 0;
                for (int j = 0; j<3; j++) {
                    cont += matriz[i, j];
                }
                Console.WriteLine($"Soma da linha {i+1} e igual a: {cont}");
            }
            Console.WriteLine("________________________________________");

            Console.WriteLine("Soma das colunas:");
            for (int i = 0; i<3; i++) {
                cont = 0;
                for (int j = 0; j < 3; j++) {
                    cont += matriz[j,i];
                }
                Console.WriteLine($"Soma da coluna {i} e igual a: {cont}");
            }

        }
    }
}