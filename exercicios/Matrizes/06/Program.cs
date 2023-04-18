namespace _06
{/*
  6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
Random random = new Random();
int randomNumber = random.Next(0, 100);
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int linha = 2, coluna = 3, maior = 0;
            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 100); //gera um número aleatório entre 1 e 10
                }
            }
            
            Console.WriteLine("Matriz desenhada:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz[i, 0]} - {matriz[i, 1]} - {matriz[i, 2]}");
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > maior) { 
                        maior = matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"O maior elemento da matriz é: {maior}");
        }
    }
}