namespace _04
{/*
  4) Popule uma matriz 5x5 e informe:
    -Quantos números são pares
    -Quantos números são impares
    -Quantos números são positivos
    -Quantos números são negativos
    -Quantos zeros existem!

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[,] matriz = new double[5, 5];
            int contPar = 0, contImpar = 0, contPost = 0, contNeg = 0, contZero = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 10); //gera um número aleatório entre 1 e 10
                }
            }

            Console.WriteLine("Matriz desenhada:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{matriz[i, 0]} - {matriz[i, 1]} - {matriz[i, 2]} - {matriz[i, 3]}");
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j]%2 == 0) { 
                        contPar++; 
                    }
                    else { 
                        contImpar++; 
                    }

                    if (matriz[i, j] > 0) { 
                        contPost++; 
                    }
                    else if (matriz[i, j] == 0) {
                        contZero++; 
                    }
                    else { 
                        contNeg++; 
                    }
                }
            }

            Console.WriteLine($"Contador numeros positivos: {contPost}");
            Console.WriteLine($"Contador numeros negativos: {contNeg}");
            Console.WriteLine($"Contador numeros pares: {contPar}");
            Console.WriteLine($"Contador numeros impares: {contImpar}");
            Console.WriteLine($"Contador numeros zero: {contZero}");
        }
    }
}
