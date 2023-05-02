namespace OO_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //03)
            ContaCorrente c1 = new ContaCorrente();
            int opc = 0;
            double valor;
            Console.WriteLine("Definir saldo inicial: ");
            c1.saldo = double.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();
            while ( true )
            {
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver saldo");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Digite sua opção: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("Defina o valor a depositar: ");
                    valor = double.Parse(Console.ReadLine());
                    c1.depositar(valor);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Defina o valor a sacar: ");
                    valor = double.Parse(Console.ReadLine());
                    c1.sacar(valor);
                }
                else if (opc == 3) {
                    Console.WriteLine($"O saldo atual da conta é: {c1.saldo}"); 
                }
                else {
                    break;
                }
                Console.ReadKey();
                Console.Clear();

            }
            

            /*
            //02)
            Aluno a1 = new Aluno("Luis Felipe", "2011107408");
            Aluno a2 = new Aluno(19930220);
            Aluno a3 = new Aluno("Luis Felipe", 19930220, 2011);

            a1.exibir();
            a2.exibir();
            a3.exibir();*/

            /*
            01)
            int opc, idade;
            string nome;
            Console.WriteLine("1-Apenas nome e idade");
            Console.WriteLine("2-Apenas idade");
            Console.WriteLine("Qual construtor gostaria de usar no seu projeto: ");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {

                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Pessoa p = new Pessoa(nome, idade);
                p.exibir();

            }
            else {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                Pessoa p = new Pessoa( "", idade);
                p.exibir();
            }*/


        }
    }
}