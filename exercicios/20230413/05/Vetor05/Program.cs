namespace Vetor05
{//5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
    internal class Program
    {
        static void Main(string[] args)
        {
            int menor = 0, x = 3;
            int[] vetor = new int[x];
            int[] resultado = new int[2];

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine("Informe um valor para a posição " + i + ":");
                vetor[i] = int.Parse(Console.ReadLine());
                if (i == 0) {
                    menor = vetor[i];
                    resultado[0] = menor;
                    resultado[1] = i;
                }
                else {
                    if (vetor[i] < menor) {
                        menor = vetor[i];
                        resultado[0] = menor;
                        resultado[1] = i;
                    }
                }
            }

            Console.WriteLine($"O menor valor é: {resultado[0]} e se encontra na posição: {resultado[1]}");
        }
    }
}