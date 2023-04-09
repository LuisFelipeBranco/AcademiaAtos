using System;
/*
09 - Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.
*/
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double entrada, valor, parcelas;
            
            Console.Clear();
            
            Console.WriteLine($"Informe o valor do material: ");
            valor = double.Parse(Console.ReadLine());
            
            if(valor%3 == 0){
                Console.WriteLine("Valores das 3 parcelas é: " + (valor/3));
            }else{
                parcelas = (int)valor/3;
                entrada = (valor%3)+parcelas;
                Console.WriteLine($"Valor de entrada é: R${entrada}");
                Console.WriteLine($"Outras 2 parcelas serão de: R${parcelas}, totalizando R${parcelas*2}");
            }
        }
    }
}