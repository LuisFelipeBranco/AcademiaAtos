namespace _14
{//14.	Escreva um algoritmo que leia um código numérico inteiro e um vet de 50 posições de números. Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vet na ordem em que foi lido. Se o código for 2, mostre o vet na ordem inversa, do último elemento até o primeiro.

    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int[] vetor = new int[50];
            int tamanhoVetor = 0;

            do
            {
                Console.Write("Digite o código (0 para sair, 1 para mostrar o vetor na ordem original, 2 para mostrar o vetor na ordem inversa): ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    Console.WriteLine("Vetor na ordem original:");
                    for (int i = 0; i < tamanhoVetor; i++)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if (codigo == 2)
                {
                    Console.WriteLine("Vetor na ordem inversa:");
                    for (int i = tamanhoVetor - 1; i >= 0; i--)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if (codigo != 0)
                {
                    Console.Write("Digite um número inteiro para adicionar no vetor: ");
                    int numero = int.Parse(Console.ReadLine());

                    vetor[tamanhoVetor] = numero;
                    tamanhoVetor++;
                }
            } while (codigo != 0);
        }
    }
}