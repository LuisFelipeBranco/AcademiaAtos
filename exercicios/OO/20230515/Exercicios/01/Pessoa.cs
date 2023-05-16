using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Pessoa
    {
        private int _idade;
        private string _nome;

        public int Idade { get => _idade; set => _idade = value; }
        public string Nome { get => _nome; set => _nome = value; }

    }
}
