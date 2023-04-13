using Microsoft.VisualBasic;

namespace Vetor06
{/*
  6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
    a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
    b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, cont = 0;
            int[] vetor = new int[x];
            int[] vetorContrario = new int[x];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + i + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int z = (vetor.Length)-1; z >= 0; z--)
            {
                vetorContrario[cont] = vetor[z];
                cont++;
            }

            for (int y = 0; y<vetor.Length; y++) {
                Console.WriteLine($"A valor do indice {y} no vetor normal, foi: {vetor[y]}");
                Console.WriteLine($"A valor do indice {y} no vetor contrario, foi: {vetorContrario[y]}");
            }

        }
    }
}