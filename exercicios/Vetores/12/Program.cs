namespace _12
{/*
  12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. 
        Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!"
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, procura;
            int[] vetor = new int[x];

            for (int a = 0; a < vetor.Length; a++) {
                Console.WriteLine($"Informe o numero que ocupara a posição {a} do vetor: ");
                vetor[a] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Informe o numero a se procurar no vetor: ");
            procura = int.Parse(Console.ReadLine());

            for (int b = 0; b < vetor.Length; b++) {
                if (vetor[b] == procura) {
                    Console.WriteLine($"Numero {procura} foi encontrado na posição {b} do vetor!");
                    break;
                }
                if (b == (vetor.Length) -1) {
                    Console.WriteLine($"O número fornecido {procura} não existe no vetor!");
                }
            }
        }
    }
}