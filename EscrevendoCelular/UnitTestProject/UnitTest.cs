using Microsoft.VisualStudio.TestTools.UnitTesting;
using Escrevendo_Celular;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        EscrevendoCelular e = new EscrevendoCelular();

        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("2", e.escrevendoCelular("a"));
        }
        [TestMethod]
        public void TestMethodDojo()
        {
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", e.escrevendoCelular("SEMPRE ACESSO O DOJOPUZZLES"));
        }
        [TestMethod]
        public void TestMethodSexo()
        {
            Assert.AreEqual("26_666077773399666", e.escrevendoCelular("amo sexo"));
        }
        [TestMethod]
        public void TestMethodMelDaBracatinga()
        {
            Assert.AreEqual("6335550320227772_222284446642", e.escrevendoCelular("Mel Da Bracatinga"));
        }
        [TestMethod]
        public void DeveRetornar2()
        {
            Assert.AreEqual("2", e.escrevendoCelular("A"));
        }
        [TestMethod]
        public void DeveRetornar3()
        {
            Assert.AreEqual("3", e.escrevendoCelular("D"));
        }
        [TestMethod]
        public void DeveRetornar4()
        {
            Assert.AreEqual("4", e.escrevendoCelular("G"));
        }
        [TestMethod]
        public void DeveRetornar5()
        {
            Assert.AreEqual("5", e.escrevendoCelular("J"));
        }
        [TestMethod]
        public void DeveRetornar6()
        {
            Assert.AreEqual("6", e.escrevendoCelular("M"));
        }
        [TestMethod]
        public void DeveRetornar7()
        {
            Assert.AreEqual("7", e.escrevendoCelular("P"));
        }
        [TestMethod]
        public void DeveRetornar8()
        {
            Assert.AreEqual("8", e.escrevendoCelular("T"));
        }
        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual("9", e.escrevendoCelular("W"));
        }
        [TestMethod]
        public void DeveRetornar0()
        {
            Assert.AreEqual("0", e.escrevendoCelular(" "));
        }
        [TestMethod]
        public void DeveRetornar5_5()
        {
            Assert.AreEqual("5_5", e.escrevendoCelular("JJ"));
        }
        public void DeveRetornar7777_77779()
        {
            Assert.AreEqual("7777_77779_997", e.escrevendoCelular("SSWXP"));
        }
        [TestMethod]
        public void DeveRetornarErro()
        {
            Assert.AreEqual("Frase muito grande!", e.escrevendoCelular("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
        }
    }
}
