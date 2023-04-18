namespace _07
{//7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int linha = 3, coluna = 3;
            double[,] matriz = new double[linha, coluna];
            double[,] matriz2 = new double[linha, coluna];
            double[,] matriz3 = new double[linha, coluna];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 10); //gera um número aleatório entre 1 e 10
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = random.Next(0, 10); //gera um número aleatório entre 1 e 10
                }
            }

            Console.WriteLine("Matriz 1 desenhada: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz[i, 0]} - {matriz[i, 1]} - {matriz[i, 2]}");
            }

            Console.WriteLine("Matriz 2 desenhada: ");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz2[i, 0]} - {matriz2[i, 1]} - {matriz2[i, 2]}");
            }

            Console.WriteLine("Subtração das 2 matrizes: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz3[i, j] = matriz[i,j] - matriz2[i, j];
                }
            }
            
            for (int i = 0; i < matriz3.GetLength(0); i++)
            {
                Console.WriteLine($"{matriz3[i, 0]} - {matriz3[i, 1]} - {matriz3[i, 2]}");
            }
        }
    }
}