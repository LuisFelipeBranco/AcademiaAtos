using System;
/*
5) Escreva um programa em C#  para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double consumo, distancia, consumoMedio;
            
            Console.WriteLine("Digite a distancia percorrida (em km): ");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o volume do combustivel percorrido (em l): ");
            consumo = double.Parse(Console.ReadLine());
            
            consumoMedio = distancia/consumo;
            
            Console.WriteLine("O consumo médio da viagem foi: " + consumoMedio.ToString("F2") + "km/l");
            
        }
    }
}