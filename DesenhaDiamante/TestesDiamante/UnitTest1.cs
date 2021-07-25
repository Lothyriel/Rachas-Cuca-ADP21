using DiamanteLetras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesDiamante
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void deveRetornarA()
        {
            Assert.AreEqual("A\n", Diamante.ExibirDiamante('A'));
        }
    }
}
