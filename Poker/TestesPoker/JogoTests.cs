using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Poker;
using System.Collections.Generic;

namespace TestesPoker
{
    [TestClass]
    public class JogoTestes
    {
        [TestMethod]
        public void straightFlush_FullHouse_J1Ganha()
        {
            Jogador jogador = new Jogador("6D 7D 8D 9D TD");
            Jogador jogador2 = new Jogador("5D 5D 7D 7D 7D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void umPar_Trinca_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 5C 6S 7S KD");
            Jogador jogador2 = new Jogador("7H 7C 7S 9S TD");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void umPar_RoyalFlush_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 5C 6S 7S KD");
            Jogador jogador2 = new Jogador("AD KD QD JD TD");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void empataCartaAlta_J1Ganha()
        {
            Jogador jogador = new Jogador("6D 4C AC QD TH");
            Jogador jogador2 = new Jogador("TC 7C JS AD 4S");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void empataCartaAlta_J1Ganha1()
        {
            Jogador jogador = new Jogador("4D 7H 3D QC AC");
            Jogador jogador2 = new Jogador("8D JS AH 3S 4S");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void empataCartaAlta_J2Ganha()
        {
            Jogador jogador = new Jogador("QH AC 5S 9C 3C");
            Jogador jogador2 = new Jogador("9H AS 2C KH 5C");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void duasTrincas_J1Ganha()
        {
            Jogador jogador = new Jogador("5H 5C 5S 6S 7D");
            Jogador jogador2 = new Jogador("4D 4D 4S 8D 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void duasTrincas_J2Ganha()
        {
            Jogador jogador = new Jogador("4D 4D 4S 8D 9D");
            Jogador jogador2 = new Jogador("5H 5C 5S 6S 7D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void empataTrincas_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 5C 5S 6S 7D");
            Jogador jogador2 = new Jogador("5D 5D 5S 8D 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void empataTrincas_J2Ganha2()
        {
            Jogador jogador = new Jogador("5H 5C 5S 3S 6D");
            Jogador jogador2 = new Jogador("5D 5D 5S 7D 2D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void fiveHigh_straight_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 4C 3S 2S AD");
            Jogador jogador2 = new Jogador("6D 5D 4S 3D 2D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void fiveHigh_straightFlush_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 4H 3H 2H AH");
            Jogador jogador2 = new Jogador("6D 5D 4D 3D 2D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void aceHigh_straight_J1Ganha()
        {
            Jogador jogador = new Jogador("KH QC JS TS AD");
            Jogador jogador2 = new Jogador("KD QD JS TD 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void flushAceHigh_straightFlush_J1Ganha()
        {
            Jogador jogador = new Jogador("KS QS JS TS AS");
            Jogador jogador2 = new Jogador("KC QC JC TC 9C");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void empataRoyalFlush()
        {
            Jogador jogador = new Jogador("TH JH QH KH AH");
            Jogador jogador2 = new Jogador("TD JD QD KD AD");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void variosJogadores_J4Ganha()
        {
            Jogador jogador = new Jogador("2D 6D 4S 4D 9D");
            Jogador jogador2 = new Jogador("5H 5C 5S 6S 7D");
            Jogador jogador3 = new Jogador("6D 6D 6S 6D 9D");
            Jogador jogador4 = new Jogador("AS KS QS JS TS");
            Jogador jogador5 = new Jogador("8D 8H 3S 3D 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2, jogador3, jogador4, jogador5 });

            jogo.ganhadores().Should().Contain(jogador4);
        }
        [TestMethod]
        public void variosJogadores_mpate()
        {
            Jogador jogador = new Jogador("2D 6D 4S 4D 9D");
            Jogador jogador2 = new Jogador("5H 5C 5S 6S 7D");
            Jogador jogador3 = new Jogador("AS KS QS JS TS");
            Jogador jogador4 = new Jogador("AS KS QS JS TS");
            Jogador jogador5 = new Jogador("8D 8H 3S 3D 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2, jogador3, jogador4, jogador5 });

            jogo.ganhadores().Should().Contain(jogador3);
            jogo.ganhadores().Should().Contain(jogador4);
        }
        [TestMethod]
        public void empataFlushs()
        {
            Jogador jogador = new Jogador("5D 6D 7D 8D TD");
            Jogador jogador2 = new Jogador("5S 6S 7S 8S TS");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void exemplo1DoisUmPar_J2Ganha()
        {
            Jogador jogador = new Jogador("5H 5C 6S 7S KD");
            Jogador jogador2 = new Jogador("2C 3S 8S 8D TD");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void exemplo2DuasCartaAlta_J1Ganha()
        {
            Jogador jogador = new Jogador("5D 8C 9S JS AC");
            Jogador jogador2 = new Jogador("2C 5C 7D 8S QH");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void exemplo3Trinca_Flush_J2Ganha()
        {
            Jogador jogador = new Jogador("2D 9C AS AH AC");
            Jogador jogador2 = new Jogador("3D 6D 7D TD QD");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador2);
        }
        [TestMethod]
        public void exemplo4DoisUmPar_J1Ganha()
        {
            Jogador jogador = new Jogador("4D 6S 9H QH QC");
            Jogador jogador2 = new Jogador("3D 6D 7H QD QS");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
        [TestMethod]
        public void exemplo5DoisFullHouse_J1Ganha()
        {
            Jogador jogador = new Jogador("2H 2D 4C 4D 4S");
            Jogador jogador2 = new Jogador("3C 3D 3S 9S 9D");
            Jogo jogo = new Jogo(new List<Jogador>() { jogador, jogador2 });

            jogo.ganhadores().Should().Contain(jogador);
        }
    }
}
