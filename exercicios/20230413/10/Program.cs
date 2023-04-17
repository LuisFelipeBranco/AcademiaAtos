namespace _10
{//10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
 //Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] vetor = new int[x];
            int[] vetorB = new int[x];

            for (int y = 0; y < vetor.Length; y++) {
                Console.WriteLine($"Informe o valor para o indice {y} do vetor: ");
                vetor[y] = int.Parse(Console.ReadLine());
            }
            for (int z = 0; z < vetor.Length; z++) {
                if (vetor[z] == 0)
                {
                    vetorB[z] = 2;
                }
                else
                {
                    vetorB[z] = vetor[z];
                }
            }

            for (int a = 0; a < vetor.Length; a++) {
                Console.WriteLine($"Vetor[{a}]: {vetor[a]}");
                Console.WriteLine($"VetorB[{a}]: {vetorB[a]}");
            }
        }
    }
}