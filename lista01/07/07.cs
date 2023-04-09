using System;
/*
7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matricula, totalVendas;
            double percentual, salario, novoSalario;
            
            Console.Clear();
            
            Console.WriteLine($"Informe a matricula do vendedor: ");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o salario do vendedor: ");
            salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Informe o total de vendas do vendedor: ");
            totalVendas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o percentual de aumento para o vendedor: ");
            percentual = double.Parse(Console.ReadLine());

            novoSalario = ((percentual/100)*totalVendas) + salario;

            Console.WriteLine($"O salario final do vendedor: {matricula} é: {novoSalario}");
            
        }
    }
}