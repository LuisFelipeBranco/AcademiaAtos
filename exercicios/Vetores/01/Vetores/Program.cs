namespace Vetores
{   //Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, par = 0, impar = 0;
            int[] vetor = new int[x];



            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + i + ":");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }
                else {
                    impar++;
                }
            }

            Console.WriteLine($"A quantidade de numeros pares é: {par} e de numeros impares é: {impar}");
        }
    }
}