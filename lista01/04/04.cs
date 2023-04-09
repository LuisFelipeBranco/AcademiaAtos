using System;
/*
4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            int dia, mes, ano;
            string novoAno;

            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine($"Formato AAAADDMM: {ano}/{mes}/{dia}" );
            novoAno = ano.ToString().Substring(2);

            Console.WriteLine($"Formato AADDMM: {novoAno}/{mes}/{dia}" );
            //Console.WriteLine("Formato AADDMM: ");
            
        }
    }
}