using Microsoft.VisualBasic;
using System.Security.Principal;
/*
 1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.
Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um método Apresentar na classe  Aluno que imprime o nome, a idade e amatrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.
 */
namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario = WindowsIdentity.GetCurrent().Name;
            Pessoa p = new Pessoa();

            p.Idade = 30;
            p.Nome = "Luis Felipe de Oliveira Branco";
            //Console.WriteLine($"Usuario: {nomeUsuario}");
            Console.WriteLine($"Inclusão -> {nomeUsuario} -> {DateTime.Now}");
            Console.ReadLine();
        }
    }
}