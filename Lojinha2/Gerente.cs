using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Gerente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CodigoFuncionario { get; set; }

        public void Vender()
        {
            Console.WriteLine("Este produto foi vendido pelo Gerente, com Sucesso.");
        }

        public Gerente()
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.CodigoFuncionario = CodigoFuncionario;
        }

    }
}
