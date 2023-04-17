namespace Vetor04
{//4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, cont;
            int[] vetora = new int[x];
            int[] vetorb = new int[x];
            int[] vetorResultado = new int[x];

            for (cont = 0; cont < x; cont++)
            {
                Console.WriteLine($"Informe um valor A para a posição: {cont}");
                vetora[cont] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Informe um valor B para a posição: {cont}");
                vetorb[cont] = int.Parse(Console.ReadLine());

                vetorResultado[cont] = vetora[cont] * vetorb[cont];

            }
            Console.Clear();
            for (cont = 0; cont < vetorResultado.Length; cont++)
            {
                Console.WriteLine($"O valor {vetora[cont]} + {vetorb[cont]} e igual á: {vetorResultado[cont]}");
            }
        }
    }
}