namespace _13
{//13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.
 //O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5,  contador2 = 0, contador4 = 0, contador8 = 0;
            int[] vet = new int[x];
            double opc = 0;

            while (opc == 0) {
                for (int a = 0; a < vet.Length; a++){
                    Console.WriteLine($"Preencha o indice {a} do vetor: ");
                    vet[a] = int.Parse(Console.ReadLine());
                }
                for (int b = 0; b < vet.Length; b++) {
                    if (vet[b] == 2){ contador2++; }
                    else if (vet[b] == 4) { contador4++; }
                    else if (vet[b] == 8) { contador8++; }
                }
                Console.WriteLine($"Contador de 2: {contador2}");
                Console.WriteLine($"Contador de 4: {contador4}");
                Console.WriteLine($"Contador de 8: {contador8}");
                Console.WriteLine("Deseja executar o programa novamente?(0->Sim, -1->Não)");
                opc = Double.Parse(Console.ReadLine());
                
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
