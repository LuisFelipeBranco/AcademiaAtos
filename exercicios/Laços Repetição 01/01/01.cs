using System.Runtime.Serialization.Formatters;
//Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado calcular a média de idade de n pessoas.
//Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
//Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.
//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
//Escreva um algoritmo para calcular o fatorial de um número.
namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd, idade, cont = 0;
            Console.WriteLine("Informe a quantidade de pessoas: ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Informe a idade da pessoa {i}: ");
                idade = int.Parse(Console.ReadLine());

                cont = (cont+idade);
            }

            Console.WriteLine($"A media das idades é: {cont/qtd}");

        }
    }
}
