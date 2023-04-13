Exercicio 04:

using System.Runtime.Serialization.Formatters;
//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
//Escreva um algoritmo para calcular o fatorial de um número.
namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int num, elevacao, acumulador = 0;

            Console.WriteLine("Digite o numero base: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero elevação: ");
            elevacao = int.Parse(Console.ReadLine());

            acumulador = 1;

            for (int i = 1; i <= elevacao; i++)
            {
                if (elevacao == 0) {
                    acumulador = 0; break;
                }

                acumulador = acumulador* num;

            }

            Console.WriteLine($"{acumulador}");
        }
    }
} 