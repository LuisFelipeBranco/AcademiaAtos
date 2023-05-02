using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_01
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa()//Construtor 01
        {
            
        }

        public Pessoa(string nome, int idade) //Construtor 02
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void exibeDados() {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
        }

    }
}
