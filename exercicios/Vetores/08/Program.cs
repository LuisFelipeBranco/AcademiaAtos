namespace _08
{/*
  8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
a.	lê:         |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
b.	escreve: 	|3|5|6|7|9|10|14|. . .
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double[] vetor = new double [x];

            for (int y = 0; y < vetor.Length; y++) {
                Console.WriteLine($"Informe o numero na posição {y}: ");
                vetor[y] = double.Parse(Console.ReadLine());
            }

            for (int z = 0; z < vetor.Length; z++) {
                if (vetor[z] < 0) {
                    Console.WriteLine($"A posição do numero: {vetor[z]} é: {z}");
                }
            }
        }
    }
}