using System.Runtime.Serialization.Formatters;
//Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.
//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
//Escreva um algoritmo para calcular o fatorial de um número.
namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite o numero a exibir a tabuada: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"O numero é: {num} x {i}: {num*i}");

            }

        }
    }
} 