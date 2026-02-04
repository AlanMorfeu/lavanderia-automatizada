using DevFullStackCicclo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevFullStackCicclo.Testes
{
    public class CarteiraTestes
    {
        [Fact]
        public void ExibirSaldo_DeveRetornarSaldoFormatado()
        {
            // Arrange
            var carteira = new Carteira("Teste", "1234", 100m);

            // Act
            var saldo = carteira.ExibirSaldo();

            // Assert
            Assert.Equal("$R$100,00", saldo);
        }
        [Fact]
        public void RealizarPagamento_DeveReduzirSaldo_QuandoSaldoSuficiente()
        {
            // Arrange
            var carteira = new Carteira("Teste", "1234", 100m);

            // Act
            carteira.RealizarPagamento("Compra", 50m);

            // Assert
            Assert.Equal(50m, carteira.Saldo);
        }

        [Fact]
        public void RealizarPagamento_NaoDeveReduzirSaldo_QuandoSaldoInsuficiente()
        {
            // Arrange
            var carteira = new Carteira("Teste", "1234", 30m);

            // Act & Assert
            Assert.Throws<System.Exception>(() => carteira.RealizarPagamento("Compra", 50m));
        }
        [Fact]
        public void ExibirHistorico_DeveRetornarHistoricoCorreto()
        {
            // Arrange
            var carteira = new Carteira("Teste", "1234", 100m);
            carteira.RealizarPagamento("Compra", 50m);

            // Act
            var historico = carteira.ExibirHistorico();

            // Assert
            Assert.Contains("Compra", historico);
        }
    }
}
