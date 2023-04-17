namespace Vetores02
{//2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
    internal class Program
    {
        static void Main(string[] args)
        {   int x = 5, cont;
            int[] vetora = new int[x];
            int[] vetorb = new int[x];
            int[] vetorResultado = new int[x];

            for (cont = 0; cont < x; cont++) {
                Console.WriteLine($"Informe um valor A para a posição: {cont}");
                vetora[cont] = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Informe um valor B para a posição: {cont}");
                vetorb[cont] = int.Parse(Console.ReadLine());
                
                vetorResultado[cont] = vetora[cont] + vetorb[cont];

            }
            Console.Clear();
            for (cont = 0; cont < vetorResultado.Length; cont++) {
                Console.WriteLine($"O valor {vetora[cont]} + {vetorb[cont]} e igual á: {vetorResultado[cont]}");
            }

        }
    }
}