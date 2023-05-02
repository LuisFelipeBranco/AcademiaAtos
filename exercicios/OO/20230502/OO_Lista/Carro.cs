using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 •1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.
•Esses valores devem ser solicitados ao usuário, por linha de execução.
 */
namespace OO_01
{
    internal class Carro
    {
        public int anofabricacao;
        public string modelo, marca;

        public void exibe() {
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Ano de fabricação: " + this.anofabricacao);
            Console.WriteLine("___________________________________________________");
        }

    }
}
