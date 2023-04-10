Exercicio 05:
using System.Runtime.Serialization.Formatters;
//Escreva um algoritmo para calcular o fatorial de um número.
namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int x, fatorial = 1;
            Console.WriteLine("Digite um numero para calcular o fatorial: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine($"O fatorial do numero: {x} é: {fatorial}");
        }
    }

}
