using System;
/*
6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. 
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int codA, qtdA, codB, qtdB;
            double valorA, valorB, ipiA, ipiB, mediaA, mediaB;
            
            Console.Clear();//Limpa a console;
            
            Console.WriteLine("Informe o código do parafuso A:");
            codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do parafuso A:");
            qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário do parafuso A:");
            valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor percentual da IPI do parafuso A:");
            ipiA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código do parafuso B:");
            codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do parafuso B:");
            qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário do parafuso B:");
            valorB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor percentual da IPI do parafuso B:");
            ipiB = double.Parse(Console.ReadLine());
            
            mediaA = (valorA * ipiA/100) + valorA;
            mediaB = (valorB * ipiB/100) + valorB;

            Console.WriteLine("O novo preço unitário do parafusoA é: " + mediaA.ToString("F2"));
            Console.WriteLine("O novo preço unitário do parafusoB é: " + mediaB.ToString("F2"));
            
        }
    }
}