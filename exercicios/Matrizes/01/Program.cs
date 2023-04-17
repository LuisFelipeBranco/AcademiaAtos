namespace _01
{//1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];

            Console.WriteLine("Preencha a primeira coluna da matriz:");

            for (int linha = 0; linha < 5; linha++)
            {
                Console.Write($"Elemento {linha + 1}: ");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
            }

            for (int linha = 0; linha < 5; linha++)
            {
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] * 2;
            }

            Console.Clear();

            Console.WriteLine("Matriz resultante:");
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}