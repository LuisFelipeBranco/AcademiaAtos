using System;
/*
3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.
*/
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
            Console.WriteLine("Os valores digitados fora: x=" + x + ", e y=" + y);

            z = x;
            x = y;
            y = z;

            Console.WriteLine("Os valores agora são: x=" + x + ", e y=" + y);
            
        }
    }
}