namespace _03
{//3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(1, 10); //gera um número aleatório entre 1 e 10
                }
            }

            Console.WriteLine("Matriz desenhada:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{matriz[i,0]} - {matriz[i, 1]} - {matriz[i, 2]} - {matriz[i, 3]}");
            }

            for (int i = 0; i < 4; i++)//imprimir elementos da diagonal principal
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) {
                        Console.WriteLine($"{matriz[i, j].ToString().PadLeft(i*4)}");
                    }
                }
            }

        }
    }
}