namespace Vetor03
{//3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, cont, maior = 0;
            int[] vetor = new int[x];

            for (cont = 0; cont < vetor.Length; cont++) {
                Console.WriteLine($"Digite o numero da posição {cont+1}: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            for (cont = 0; cont < vetor.Length; cont++) {
                if (vetor[cont] <= maior) { 
                    maior = vetor[cont]; 
                }
            }

            for (cont = 0; cont < vetor.Length; cont++) {//numero divisivel por 1 ou por ele mesmo;
                
            }

        }
    }
}