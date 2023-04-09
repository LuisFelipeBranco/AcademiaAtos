using System;
//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("Digite o primeiro numero: ");
             x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
             y = double.Parse(Console.ReadLine());
            
            z = (x + y)/2;

            Console.WriteLine("A media dos 2 numeros é: " + z);
            
        }
    }
}