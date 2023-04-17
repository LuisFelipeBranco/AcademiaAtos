namespace _07
{/*
  7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e 
    escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] vetorA = new int[x];

            for (int i = 0; i < vetorA.Length; i++) {
                Console.WriteLine($"Informe um numero para a posição {i} do vetor");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int z = 0; z < vetorA.Length; z++) {
                if (vetorA[z]%2 == 0) {
                    Console.WriteLine($"O numero {vetorA[z]} é PAR!");
                }
            }

            for (int y = 0; y < vetorA.Length; y++) {
                if (vetorA[y]%2 != 0)
                {
                    Console.WriteLine($"O numero {vetorA[y]} é IMPAR!");
                }
            }

        }
    }
}