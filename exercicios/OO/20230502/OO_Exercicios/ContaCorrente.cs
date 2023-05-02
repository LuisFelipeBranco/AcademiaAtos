using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicios
{
    internal class ContaCorrente
    {
        public double saldo;

        public ContaCorrente()
        {
            
        }

        public void sacar(double valor) {
            if (valor > this.saldo) { 
                Console.WriteLine("Não tem saldo suficiente, faça um deposito"); 
            }
            else { 
                this.saldo -= valor; 
            }
        }
        public void depositar(double valor) {
            this.saldo += valor;
        }

        public void definirSaldoInicial(double saldo) {
            this.saldo = saldo;
        }

        public void verSaldo() {
            Console.WriteLine($"Saldo atual da conta: {this.saldo}");
        }

    }
}
