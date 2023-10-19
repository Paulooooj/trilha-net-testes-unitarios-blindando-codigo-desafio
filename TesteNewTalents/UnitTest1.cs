using NewTalents;
using System;
using Xunit;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        private Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int resultadoEsperado)
        {
            int resultadoCalculadora = _calculadora.Somar(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int num1, int num2, int resultadoEsperado)
        {
            int resultadoCalculadora = _calculadora.Subtrair(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int resultadoEsperado)
        {
            int resultadoCalculadora = _calculadora.Multiplicar(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int num1, int num2, int resultadoEsperado)
        {
            int resultadoCalculadora = _calculadora.Dividir(num1, num2);

            Assert.Equal(resultadoEsperado, resultadoCalculadora);

        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calculadora.Dividir(3, 0));
        }

          [Fact]
        public void TesteHistorico()
        {
            _calculadora.Somar(1, 2);
            _calculadora.Somar(2, 8);
            _calculadora.Somar(3, 7);
            _calculadora.Somar(4, 1);

            var lista = _calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
