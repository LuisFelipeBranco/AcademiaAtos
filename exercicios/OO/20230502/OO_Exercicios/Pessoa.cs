using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicios
{
    internal class Pessoa
    {
        int idade;
        string nome;
        public Pessoa(string ? nome, int idade)
        {
            this.idade = idade;
            this.nome = nome;
        }

        public void exibir() {
            Console.WriteLine("________________________");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Idade: {this.idade}");
            Console.WriteLine("________________________");
        }

    }
}
