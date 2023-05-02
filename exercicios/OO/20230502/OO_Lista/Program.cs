namespace OO_01
{//iniciar classe;
 //Construtores;
 //modificadores de acesso, encapsulamento;
    internal class Program
    {
        static void Main(string[] args)
        {

            Computador comp1 = new Computador();
            Computador comp2 = new Computador("ASUS", "CTR001", 1996.65, 1);//string marca, string modelo, double preco, int tipo

            Console.WriteLine("Digite a marca do computador: ");
            comp1.marca = Console.ReadLine();
            
            Console.WriteLine("Digite o modelo do computador: ");
            comp1.modelo = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do computador: ");
            comp1.preco = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o tipo do computador: ");
            comp1.tipo = int.Parse(Console.ReadLine());

            Console.Clear();

            comp1.exibe();
            comp2.exibe();

            Console.ReadKey();


            /*Console.WriteLine("Olá, estou no primeiro programa OO");
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa: ");
            p.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            p.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"O nome digitado foi: {p.nome}");
            Console.WriteLine($"A idade digitada foi: {p.idade}");
            p.exibeDados();

            Console.ReadKey();

            Pessoa p2 = new Pessoa("Snow", 6);
            p2.exibeDados();*/

            /*Carro c1 = new Carro();
            Carro c2 = new Carro();
            int i ;

            Console.WriteLine($"Informa a marca do carro 1");
            c1.marca = Console.ReadLine();

            Console.WriteLine($"Informa a modelo do carro 1");
            c1.modelo = Console.ReadLine();

            Console.WriteLine($"Informa a ano de fabricação do carro 1");
            c1.anofabricacao = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Informa a marca do carro 2");
            c2.marca = Console.ReadLine();

            Console.WriteLine($"Informa a modelo do carro 2");
            c2.modelo = Console.ReadLine();

            Console.WriteLine($"Informa a ano de fabricação do carro 2");
            c2.anofabricacao = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Carro 1:");
            c1.exibe();
            Console.WriteLine("Carro 2:");
            c2.exibe();
            Console.ReadKey();
            Console.Clear();*/

            /*for (i = 1; i <= 2; i++) {
                Console.WriteLine($"Informa a marca do carro {i}");
                c1.marca = Console.ReadLine();
                
                Console.WriteLine($"Informa a modelo do carro {i}");
                c1.modelo = Console.ReadLine();
                
                Console.WriteLine($"Informa a ano de fabricação do carro {i}");
                c1.anofabricacao = int.Parse(Console.ReadLine());
            }*/

        }
    }
}