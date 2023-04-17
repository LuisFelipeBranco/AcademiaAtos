namespace _11
{//11. Escreva um programa que leia valores em um vetor de 5 posições.Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int[] vetor = new int[x];

            for (int a = 0; a < vetor.Length; a++) {
                Console.WriteLine($"Insira o elemento da posição {a} do vetor: ");
                vetor[a] = int.Parse(Console.ReadLine());
            }
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vetor digitado:");
            for (int b = 0; b < vetor.Length; b++) {
                Console.WriteLine($"Vetor[{b}]: {vetor[b]}");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vetor na ordem inversa:");
            for (int c = vetor.Length-1; c>=0 ; c--) {
                Console.WriteLine($"Vetor[{c}]: {vetor[c]}");
            }
        }
    }
}