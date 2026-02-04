using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFullStackCicclo.Classes
{
    internal class Carteira
    {
        public string Nome { get; }
        public string Senha { get; }
        public decimal Saldo { get; set; }
        public string Historico { get; set; }

        // adiconado para controle de exibição do histórico
        public bool ExisteHistorico = false;

        public Carteira()
        {
        }

        public Carteira(string nome, string senha, decimal saldo)
        {
            Nome = nome;
            Senha = senha;
            Saldo = saldo;
            Historico = string.Empty;
        }
        public Carteira(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
            Saldo = 50m;
            Historico = string.Empty;
        }

        public string ExibirSaldo()
        {
            return $"${Saldo:C2}";
        }

        public bool RealizarPagamento(string operacao, decimal valorPagamento)
        {
            string historico = string.Empty;
            if (valorPagamento <= Saldo)
            {
                Saldo = Saldo - valorPagamento;
                Historico += $"{DateTime.Now}: {operacao} - {valorPagamento:C2}\n";
                ExisteHistorico = true;
                return true;
            }
            else
            {
                //throw new Exception("Saldo insuficiente para realizar o pagamento.");
                return false;
            }
        } 

        public string ExibirHistorico()
        {            
            return Historico;
        }
    }


}
