using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tipo_Triangulo;

namespace Teste
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void escaleno()
        {
            double x = 1, y = 2, z = 3;
            Triangulo escaleno = classificaTriangulo.classifica(x, y, z);
            Assert.AreEqual("Este é um triângulo escaleno de lados: " + x + ", " + y + ", " + z, escaleno.ToString());
        }
        [TestMethod]
        public void trianguloInvalido()
        {
            double x = 0, y = 0, z = 0;
            var validacao = validaLados.valida(x.ToString(), y.ToString(), z.ToString());
            Assert.AreEqual(validacao, "um dos lados é igual ou menor a 0");
        }
    }
}
