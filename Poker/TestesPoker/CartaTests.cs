using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Poker;

namespace TestesPoker
{
    [TestClass]
    public class CartaTests
    {
        [TestMethod]
        public void carta5Copas()
        {
            var c = Carta.getCarta("5H");
            c.numero.Should().Be(Numero.N5);
            c.naipe.Should().Be(Naipe.H);
        }
        [TestMethod]
        public void cartaReiOuro()
        {
            var c = Carta.getCarta("KD");
            c.numero.Should().Be(Numero.NK);
            c.naipe.Should().Be(Naipe.D);
        }
        [TestMethod]
        public void carta10Paus()
        {
            var c = Carta.getCarta("TC");
            c.numero.Should().Be(Numero.NT);
            c.naipe.Should().Be(Naipe.C);
        }
        [TestMethod]
        public void cartaAsEspadas()
        {
            var c = Carta.getCarta("AS");
            c.numero.Should().Be(Numero.NA);
            c.naipe.Should().Be(Naipe.S);
        }
    }
}
