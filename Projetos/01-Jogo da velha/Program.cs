using System.Xml;

namespace _01_Jogo_da_velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, opc = 0;
            char[,] campo = new char[3, 3];
            bool vez = true;//Controla quem esta na vez de jogar;
            
            iniciarTabuleiro(campo);
            mostrar(campo);

            while (opc == 0) { 
                vez = jogador(vez, campo);
                cont++;
                if (cont >= 4) {
                    vencedor(campo);
                    //vencedor;
                    //empate;
                }//a partir da 3 vez, já pode ter um vencedor;
            }
        }

        public static void vencedor(char [,] campo) {//checar possibilidades de vitoria;
            int i, j;
            for (i = 0; i<campo.GetLength(0); i++) {
                for (j = 0; j < campo.GetLength(1); j++)
                {
                    
                }
            }

        }

        public static void mostrar(char[,] campo)
        {
            Console.Clear();

            for (int i = 0; i < campo.GetLength(0); i++){
                Console.WriteLine($"{campo[i, 0]} - {campo[i, 1]} - {campo[i, 2]}");
                if (i != 2){
                    Console.WriteLine("---------");
                }
            }

        }

        public static bool jogador(bool player, char[,] campo) {
            int linha, coluna;
            char mark;
            
            if (player == true) { Console.WriteLine("Player 1"); mark = 'X'; }
            else { Console.WriteLine("Player 2"); mark = 'O'; }

            Console.WriteLine("Informe as coordenadas que deseja jogar: ");
            Console.WriteLine("Linha: ");
            linha = int.Parse(Console.ReadLine());
            while (linha > 3 || linha == 0)
            {
                Console.WriteLine("Linha digitada não pode ser maior que 3 ou igual a 0, digite novamente uma coordenada: ");
                linha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Coluna: ");
            coluna = int.Parse(Console.ReadLine());
            if (coluna > 3 || linha == 0)
            {
                Console.WriteLine("Coluna digitada não pode ser maior que 3 ou igual a 0, digite novamente uma coordenada: ");
                coluna = int.Parse(Console.ReadLine());
            }
            campo[(linha-1), (coluna-1)] = mark;
            if (player == true) 
            {
                player = false; 
            }
            else {
                player = true; 
            }
            mostrar(campo);
            return player;
        }

        public static void iniciarTabuleiro(char[,] campo) {
            for (int i = 0; i < campo.GetLength(0); i++)
            {
                for (int j = 0; j < campo.GetLength(1); j++)
                {
                    campo[i, j] = ' ';
                }
            }
        }

    }
}