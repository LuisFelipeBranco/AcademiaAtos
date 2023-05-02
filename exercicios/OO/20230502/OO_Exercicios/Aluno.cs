using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicios
{
    internal class Aluno
    {
        string nome, matricula;
        int dataNascimento, anoIngressoFaculdade;

        public Aluno(string ? nome, string ? matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public Aluno(int dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public Aluno(string ? nome, int dataNascimento, int anoIngressoFaculdade)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.anoIngressoFaculdade = anoIngressoFaculdade;
        }

        public void exibir() {
            Console.WriteLine("_____________________");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Matricula: {this.matricula}");
            Console.WriteLine($"Data de nascimento: {this.dataNascimento}");
            Console.WriteLine($"Ano de ingresso a faculdade: {this.anoIngressoFaculdade}");
            Console.WriteLine("_____________________");
        }

    }
}
