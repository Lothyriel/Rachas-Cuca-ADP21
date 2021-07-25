using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos_Arabicos;

namespace TestesNumeroArabico
{
    [TestClass]
    public class TestesNumeroArabico
    {
        NumeroArabico na = new NumeroArabico();

        [TestMethod]
        public void DeveRetornarI()
        {
            Assert.AreEqual("I", na.paraRomano(1));
        }
        [TestMethod]
        public void DeveRetornarII()
        {
            Assert.AreEqual("II", na.paraRomano(2));
        }
        [TestMethod]
        public void DeveRetornarIII()
        {
            Assert.AreEqual("III", na.paraRomano(3));
        }
        [TestMethod]
        public void DeveRetornarIV()
        {
            Assert.AreEqual("IV", na.paraRomano(4));
        }
        [TestMethod]
        public void DeveRetornarV()
        {
            Assert.AreEqual("V", na.paraRomano(5));
        }
        [TestMethod]
        public void DeveRetornarVIII()
        {
            Assert.AreEqual("VIII", na.paraRomano(8));
        }
        [TestMethod]
        public void DeveRetornarIX()
        {
            Assert.AreEqual("IX", na.paraRomano(9));
        }
        [TestMethod]
        public void DeveRetornarX()
        {
            Assert.AreEqual("X", na.paraRomano(10));
        }
        [TestMethod]
        public void DeveRetornarXX()
        {
            Assert.AreEqual("XX", na.paraRomano(20));
        }
        [TestMethod]
        public void DeveRetornarXL()
        {
            Assert.AreEqual("XL", na.paraRomano(40));
        }
        [TestMethod]
        public void DeveRetornarL()
        {
            Assert.AreEqual("L", na.paraRomano(50));
        }
        [TestMethod]
        public void DeveRetornarC()
        {
            Assert.AreEqual("C", na.paraRomano(100));
        }
        [TestMethod]
        public void DeveRetornarCL()
        {
            Assert.AreEqual("CL", na.paraRomano(150));
        }
        [TestMethod]
        public void DeveRetornarDXII()
        {
            Assert.AreEqual("DXII", na.paraRomano(512));
        }
        [TestMethod]
        public void DeveRetornarCCCXC()
        {
            Assert.AreEqual("CCCXC", na.paraRomano(390));
        }
        [TestMethod]
        public void DeveRetornarMDXII()
        {
            Assert.AreEqual("MDXII", na.paraRomano(1512));
        }
        [TestMethod]
        public void DeveRetornarMMXII()
        {
            Assert.AreEqual("MMXII", na.paraRomano(2012));
        }
        [TestMethod]
        public void DeveRetornarMMMXII()
        {
            Assert.AreEqual("MMMXII", na.paraRomano(3012));
        }
        [TestMethod]
        public void DeveRetornarĪV̄D()
        {
            Assert.AreEqual("ĪV̄D", na.paraRomano(4500));
        }
        [TestMethod]
        public void DeveRetornarV̄D()
        {
            Assert.AreEqual("V̄D", na.paraRomano(5500));
        }
        [TestMethod]
        public void DeveRetornarV̄CM()
        {
            Assert.AreEqual("V̄CM", na.paraRomano(5900));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪD()
        {
            Assert.AreEqual("V̄ĪD", na.paraRomano(6500));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪĪCD()
        {
            Assert.AreEqual("V̄ĪĪCD", na.paraRomano(7400));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪĪĪD()
        {
            Assert.AreEqual("V̄ĪĪĪD", na.paraRomano(8500));
        }
        [TestMethod]
        public void DeveRetornarĪX̄DXC()
        {
            Assert.AreEqual("ĪX̄DXC", na.paraRomano(9590));
        }
        [TestMethod]
        public void DeveRetornarX̄D()
        {
            Assert.AreEqual("X̄D", na.paraRomano(10500));
        }
        [TestMethod]
        public void DeveRetornarĪX̄DCCLXXXVI()
        {
            Assert.AreEqual("ĪX̄DCCLXXXVI", na.paraRomano(9786));
        }
    }
}