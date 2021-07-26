using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Poker;

namespace TestesPoker
{
    [TestClass]
    public class JogadorTestes
    {
        [TestMethod]
        public void umPar()
        {
            Jogador jogador = new Jogador("5H 5C 6S 7S KD");
            jogador.mao.classificacao.Should().Be(ClassMao.UmPar);
        }
        [TestMethod]
        public void cartaAlta()
        {
            Jogador jogador = new Jogador("5D 8C 9S JS AC");
            jogador.mao.classificacao.Should().Be(ClassMao.CartaAlta);
        }
        [TestMethod]
        public void cartaAlta2()
        {
            Jogador jogador = new Jogador("2C 5C 7D 8S QH");
            jogador.mao.classificacao.Should().Be(ClassMao.CartaAlta);
        }
        [TestMethod]
        public void umPar2()
        {
            Jogador jogador = new Jogador("2C 3S 8S 8D TD");
            jogador.mao.classificacao.Should().Be(ClassMao.UmPar);
        }
        [TestMethod]
        public void umPar3()
        {
            Jogador jogador = new Jogador("4D 6S 9H QH QC");
            jogador.mao.classificacao.Should().Be(ClassMao.UmPar);
        }
        [TestMethod]
        public void umPar4()
        {
            Jogador jogador = new Jogador("3D 6D 7H QD QS");
            jogador.mao.classificacao.Should().Be(ClassMao.UmPar);
        }
        [TestMethod]
        public void doisPares()
        {
            Jogador jogador = new Jogador("3C 3D 4S 4S 9D");
            jogador.mao.classificacao.Should().Be(ClassMao.DoisPares);
        }
        [TestMethod]
        public void trinca()
        {
            Jogador jogador = new Jogador("2D 9C AS AH AC");
            jogador.mao.classificacao.Should().Be(ClassMao.Trinca);
        }
        [TestMethod]
        public void trinca2()
        {
            Jogador jogador = new Jogador("3C 5D 4S 4S 4D");
            jogador.mao.classificacao.Should().Be(ClassMao.Trinca);
        }
        [TestMethod]
        public void straight()
        {
            Jogador jogador = new Jogador("2H 3D 4C 5D 6S");
            jogador.mao.classificacao.Should().Be(ClassMao.Straight);
        }
        [TestMethod]
        public void aceHigh()
        {
            Jogador jogador = new Jogador("AH KC QS JS TD");
            jogador.mao.classificacao.Should().Be(ClassMao.Straight);
        }
        [TestMethod]
        public void fiveHigh()
        {
            Jogador jogador = new Jogador("5H 4C 3S 2S AD");
            jogador.mao.classificacao.Should().Be(ClassMao.Straight);
        }
        [TestMethod]
        public void straight2()
        {
            Jogador jogador = new Jogador("AS KD QH JC TD");
            jogador.mao.classificacao.Should().Be(ClassMao.Straight);
        }
        [TestMethod]
        public void flush()
        {
            Jogador jogador = new Jogador("3D 6D 7D TD QD");
            jogador.mao.classificacao.Should().Be(ClassMao.Flush);
        }
        [TestMethod]
        public void fullHouse()
        {
            Jogador jogador = new Jogador("2H 2D 4C 4D 4S");
            jogador.mao.classificacao.Should().Be(ClassMao.FullHouse);
        }
        [TestMethod]
        public void fullHouse2()
        {
            Jogador jogador = new Jogador("3C 3D 3S 9S 9D");
            jogador.mao.classificacao.Should().Be(ClassMao.FullHouse);
        }
        [TestMethod]
        public void quadra()
        {
            Jogador jogador = new Jogador("AD AD AD AD TD");
            jogador.mao.classificacao.Should().Be(ClassMao.Quadra);
        }
        [TestMethod]
        public void straightFlush()
        {
            Jogador jogador = new Jogador("2D 3D 4D 5D 6D");
            jogador.mao.classificacao.Should().Be(ClassMao.StraightFlush);
        }
        [TestMethod]
        public void royalFlush()
        {
            Jogador jogador = new Jogador("AD KD QD JD TD");
            jogador.mao.classificacao.Should().Be(ClassMao.RoyalFlush);
        }
        [TestMethod]
        public void royalFlushDesordenado()
        {
            Jogador jogador = new Jogador("KD QD JD TD AD");
            jogador.mao.classificacao.Should().Be(ClassMao.RoyalFlush);
        }
    }
}
