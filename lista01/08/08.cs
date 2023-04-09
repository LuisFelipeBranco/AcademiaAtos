using System;
//8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
//A fórmula da conversão é F=(9*C+160)/5.
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            double celsius, fahrenheit;
            
            Console.Clear();
            
            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            
            fahrenheit = ((9*celsius)+160)/5;

            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}º" );
            
        }
    }
}