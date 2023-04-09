using System;
//2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x, y, a, b, z;

            Console.WriteLine("Digite o primeiro numero: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero: ");
            b = double.Parse(Console.ReadLine());
            
            z = (x + y + a + b)/4;

            Console.WriteLine("A media dos 4 numeros é: " + z);
        }
    }
}