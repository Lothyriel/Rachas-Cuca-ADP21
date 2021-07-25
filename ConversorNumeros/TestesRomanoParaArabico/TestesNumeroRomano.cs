using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos_Arabicos;

namespace TestesNumeroRomano
{
    [TestClass]
    public class TestesNumeroRomano
    {
        NumeroRomano nr = new NumeroRomano();

        [TestMethod]
        public void deveRetornar4()
        {
            nr.numeroRomano = "IV";
            Assert.AreEqual(4, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar16()
        {
            nr.numeroRomano = "XVI";
            Assert.AreEqual(16, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar878()
        {
            nr.numeroRomano = "DCCCLXXVIII";
            Assert.AreEqual(878, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar900()
        {
            nr.numeroRomano = "CM";
            Assert.AreEqual(900, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar944()
        {
            nr.numeroRomano = "CMXLIV";
            Assert.AreEqual(944, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar1555()
        {
            nr.numeroRomano = "MDLV";
            Assert.AreEqual(1555, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar3000()
        {
            nr.numeroRomano = "MMM";
            Assert.AreEqual(3000, nr.paraArabico());
        }
        [TestMethod]
        public void deveRetornar4000()
        {
            nr.numeroRomano = "ĪV̄";
            Assert.AreEqual(4000, nr.paraArabico());
        }
    }
}
