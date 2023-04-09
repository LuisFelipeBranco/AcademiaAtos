using System;
/*
12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
Média do consumo = Total quilometragem/ quantidade de combustível gasto
Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double kmInicial, kmFinal, precoGas = 6.90, qtdGas, grana;
            Console.Clear();

            Console.WriteLine($"Informe a kilometragem no inicio do dia: ");
            kmInicial = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a kilometragem no final do dia: ");
            kmFinal = double.Parse(Console.ReadLine());
            
            if(kmFinal < kmInicial){
                Console.WriteLine($"KmFinal tem que ser maior que o kmInicial.");
                return;
            }

            Console.WriteLine($"Informe a qtd de litros de combustivel gasto: ");
            qtdGas = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe quanto foi recebido em R$: ");
            grana = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Total de quilometragem: {kmFinal-kmInicial}");
            Console.WriteLine($"Media de consumo do dia: {(kmFinal-kmInicial)/qtdGas}");
            Console.WriteLine($"Lucro do dia: R${grana-(qtdGas*precoGas)}");

        }
    }
}
