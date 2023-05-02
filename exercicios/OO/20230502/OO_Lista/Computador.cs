using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 •Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço.
Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.
Já, os valores do segundo objeto, deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados.
 */
namespace OO_01
{
    internal class Computador
    {
        public string marca, modelo;
        public double preco;
        public int tipo;

        public Computador( string? marca, string? modelo, double preco, int tipo)
        {
            this.marca = marca;
            this.preco = preco;
            this.tipo = tipo;
            this.modelo = modelo;
        }

        public Computador()
        {
            
        }

        public void exibe() {
            Console.WriteLine("   ");
            Console.WriteLine($"{this.marca}");
            Console.WriteLine($"{this.modelo}");
            Console.WriteLine($"{this.preco}");
            Console.WriteLine($"{this.tipo}");
            Console.WriteLine("__________________________________");
        }

    }
}
