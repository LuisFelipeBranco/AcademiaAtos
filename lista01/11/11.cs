using System;
/*
11) Escreva um algoritmo para ler o número de eleitores de um município, 
o número de votos brancos, nulos e válidos. 
Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int votos, votosBrancos, votosNulos;
            double percent, percentBranco, percentNulos;
            
            Console.Clear();
            
            Console.WriteLine($"Informe a quantidade de votos do municipio: ");
            votos = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de votos brancos do municipio: ");
            votosBrancos = int.Parse(Console.ReadLine());
            
            if(votosBrancos > votos){
                Console.WriteLine($"Votos brancos não pode ser maior que votos");
                return;
            }

            Console.WriteLine($"Informe a quantidade de votos nulos do municipio: ");
            votosNulos = int.Parse(Console.ReadLine());

            if(votosNulos > votos){
                Console.WriteLine($"Votos nulos não pode ser maior que votos");
                return;
            }
            
            percentBranco = ((votosBrancos*100)/votos);
            percentNulos = ((votosNulos*100)/votos);
            percent = 100 - (percentBranco + percentNulos);
            
            Console.Clear();
            
            Console.WriteLine($"Percentual de votos válidos: {percent}% com {votos} votos");
            Console.WriteLine($"Percentual de votos brancos: {percentBranco}% com {votosBrancos} votos");
            Console.WriteLine($"Percentual de votos nulos: {percentNulos}% com {votosNulos} votos");
            
        }
    }
}