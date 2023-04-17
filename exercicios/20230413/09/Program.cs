namespace _09
{//9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos,e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] vetor = new int[x];
            int[] vetorAux = new int[x];

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine($"Informe o valor para a posição {i} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }

            for (int z = 0; z < vetor.Length; z++) {
                Console.WriteLine($"Indice {z}, numero ordenado: {vetor[z]}");
            }
        }
    }
}