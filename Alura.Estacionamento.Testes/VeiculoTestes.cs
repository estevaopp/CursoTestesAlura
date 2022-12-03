using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact(DisplayName = "Testa Aceleração do Veiculo")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoTipo()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            //Act
            //Assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
            veiculo.Tipo = TipoVeiculo.Motocicleta;
            Assert.Equal(TipoVeiculo.Motocicleta, veiculo.Tipo);
        }

        [Fact(DisplayName = "Testa Nome da Placa do Veiculo",Skip = "Teste ainda não implementado. Ignorar")]
        public void ValidaPlacaVeiculo()
        {

        }
    }
}
