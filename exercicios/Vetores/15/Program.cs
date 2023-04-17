namespace _15
{//15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorOriginal = new int[20];
            int[] vetorInvertido = new int[20];

            Console.WriteLine("Digite os elementos do vetor:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetorOriginal[i] = int.Parse(Console.ReadLine());
            }

            // Cópia invertida dos elementos do vetor original para o vetor invertido
            for (int i = 0; i < 20; i++)
            {
                vetorInvertido[19 - i] = vetorOriginal[i];
            }

            Console.WriteLine("Vetor original:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetorOriginal[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vetor invertido:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetorInvertido[i] + " ");
            }
        }
    }
}