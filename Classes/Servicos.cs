using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFullStackCicclo.Classes
{
    internal class Servicos
    {
        public string Nome { get; }
        public decimal Preco { get; }

        public Servicos(string nome, decimal preco) 
        { 
            Nome = nome;
            Preco = preco;
        }

        // Criado antes de usar Copilot
        //public string Lavagem = "Lavagem";
        //public decimal LavagemPreco = 18.90m;
        //public string  Secagem = "Secagem";
        //public decimal SecagemPreco = 20.90m;

        //public Servicos()
        //{
        //}
    }   
}
