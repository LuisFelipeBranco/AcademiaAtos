using System;
/*
13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. 
Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario, precoCusto;
            int qtdVendida;
            
            Console.Clear();

            Console.WriteLine($"Digite o salario minimo: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o preco de custo da bicicleta: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o numero de bicicletas vendidas: ");
            qtdVendida = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Salario final do vendedor foi: R${(salario*2)+((0.15*precoCusto)*qtdVendida)}");
            
        }
    }
}