using System.Runtime.Serialization;

namespace _00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void subtrai(double num1, double num2)
            {
                double resultado = num1 - num2;
                Console.WriteLine("Aqui eu estou na função subtrai");
                Console.WriteLine($"Resultado: {resultado}");
            }
             static void soma(double num1, double num2)
            {
                double resultado;
                resultado = num1 + num2;
                Console.WriteLine(num1 + "+" + num2 + "=" + resultado);
            }
             static void divide(double num1, double num2)
            {
                double resultado = num1 / num2;
                Console.WriteLine("Aqui eu estou na função divide");
                Console.WriteLine($"Resultado: {resultado}");

            }
             static double multiplica(double num1, double num2)
            {
                double resultado;
                resultado = num1 * num2;
                return resultado;
            }
            static void Main(string[] args)
            {
                double n1, n2, res;
                Console.WriteLine("Digite dois numeros: ");
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                soma(n1, n2);
                res = multiplica(n1, n2);
                Console.WriteLine(n1 + "*" + n2 + "=" + res);
                subtrai(n1, n2);
                divide(n1, n2);
            }
        }
    }
}


