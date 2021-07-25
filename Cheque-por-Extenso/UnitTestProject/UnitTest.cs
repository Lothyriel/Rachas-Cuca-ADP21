using Cheque_por_Extenso;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste
{
    [TestClass]
    public class Teste
    {
        Cheque cheque = new Cheque();

        [TestMethod]
        public void DeveRetornar1Centavo()
        {
            Assert.AreEqual("um centavo", cheque.chequePorExtenso(0.01m));
        }
        [TestMethod]
        public void DeveRetornar10Centavos()
        {
            Assert.AreEqual("dez centavos", cheque.chequePorExtenso(0.10m));
        }
        [TestMethod]
        public void DeveRetornar15Centavos()
        {
            Assert.AreEqual("quinze centavos", cheque.chequePorExtenso(0.15m));
        }
        [TestMethod]
        public void DeveRetornar99Centavos()
        {
            Assert.AreEqual("noventa e nove centavos", cheque.chequePorExtenso(0.99m));
        }
        [TestMethod]
        public void DeveRetornar1Real()
        {
            Assert.AreEqual("um real", cheque.chequePorExtenso(1));
        }
        [TestMethod]
        public void DeveRetornar1RealE16Centavos()
        {
            Assert.AreEqual("um real e dezesseis centavos", cheque.chequePorExtenso(1.16m));
        }
        [TestMethod]
        public void DeveRetornar1RealE30Centavos()
        {
            Assert.AreEqual("um real e trinta centavos", cheque.chequePorExtenso(1.30m));
        }
        [TestMethod]
        public void DeveRetornar7ReaisE85Centavos()
        {
            Assert.AreEqual("sete reais e oitenta e cinco centavos", cheque.chequePorExtenso(7.85m));
        }
        [TestMethod]
        public void DeveRetornar13Reais()
        {
            Assert.AreEqual("treze reais", cheque.chequePorExtenso(13));
        }
        [TestMethod]
        public void DeveRetornar20ReaisE50Centavos()
        {
            Assert.AreEqual("vinte reais e cinquenta centavos", cheque.chequePorExtenso(20.50m));
        }
        [TestMethod]
        public void DeveRetornar100Reais()
        {
            Assert.AreEqual("cem reais", cheque.chequePorExtenso(100));
        }
        [TestMethod]
        public void DeveRetornar103Reais()
        {
            Assert.AreEqual("cento e três reais", cheque.chequePorExtenso(103));
        }
        [TestMethod]
        public void DeveRetornar500Reais()
        {
            Assert.AreEqual("quinhentos reais", cheque.chequePorExtenso(500));
        }
        [TestMethod]
        public void DeveRetornar1000Reais()
        {
            Assert.AreEqual("um mil reais", cheque.chequePorExtenso(1000));
        }
        [TestMethod]
        public void DeveRetornar1526Reais45Centavos()
        {
            Assert.AreEqual("um mil quinhentos e vinte e seis reais e quarenta e cinco centavos", cheque.chequePorExtenso(1526.45m));
        }
        [TestMethod]
        public void DeveRetornar1000Reais45Centavos()
        {
            Assert.AreEqual("um mil reais e quarenta e cinco centavos", cheque.chequePorExtenso(1000.45m));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoDeReais()
        {
            Assert.AreEqual("um milhão de reais", cheque.chequePorExtenso(1000000));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoE1DeReais()
        {
            Assert.AreEqual("um milhão e um real", cheque.chequePorExtenso(1000001));
        }
        [TestMethod]
        public void DeveRetornar1Milhao137Mil147Reais()
        {
            Assert.AreEqual("um milhão cento e trinta e sete mil cento e quarenta e sete reais", cheque.chequePorExtenso(1137147));
        }
        [TestMethod]
        public void DeveRetornar1Milhao1147Reais()
        {
            Assert.AreEqual("um milhão um mil cento e quarenta e sete reais", cheque.chequePorExtenso(1001147));
        }
        [TestMethod]
        public void DeveRetornar1Milhao410Mil957ReaisE13Centavos()
        {
            Assert.AreEqual("um milhão quatrocentos e dez mil novecentos e cinquenta e sete reais e treze centavos", cheque.chequePorExtenso(1410957.13m));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoE47Reais()
        {
            Assert.AreEqual("um milhão e quarenta e sete reais", cheque.chequePorExtenso(1000047));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoDeReaisE147Centavos()
        {
            Assert.AreEqual("um milhão de reais e quarenta e sete centavos", cheque.chequePorExtenso(1000000.47m));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoDeReais()
        {
            Assert.AreEqual("um bilhão de reais", cheque.chequePorExtenso(1000000000));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoDeReaisE1Centavo()
        {
            Assert.AreEqual("um bilhão de reais e um centavo", cheque.chequePorExtenso(1000000000.01m));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE1DeReais()
        {
            Assert.AreEqual("um bilhão e um real", cheque.chequePorExtenso(1000000001));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE100DeReais()
        {
            Assert.AreEqual("um bilhão e cem reais", cheque.chequePorExtenso(1000000100));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE100DeReaisE67Centavos()
        {
            Assert.AreEqual("um bilhão e cem reais e sessenta e sete centavos", cheque.chequePorExtenso(1000000100.67m));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeReais()
        {
            Assert.AreEqual("um trilhão de reais", cheque.chequePorExtenso(1000000000000));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeReaisE50Centavos()
        {
            Assert.AreEqual("um trilhão de reais e cinquenta centavos", cheque.chequePorExtenso(1000000000000.50m));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeE147ReaisE12Centavos()
        {
            Assert.AreEqual("um trilhão e cento e quarenta e sete reais e doze centavos", cheque.chequePorExtenso(1000000000147.12m));
        }
        [TestMethod]
        public void DeveRetornar1QuadrilhaoDeReais()
        {
            Assert.AreEqual("um quadrilhão de reais", cheque.chequePorExtenso(1000000000000000));
        }
        [TestMethod]
        public void DeveRetornar300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(1400300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(5001400300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar13Sextilhoes5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("treze sextilhões cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(13005001400300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar22Septilhões13Sextilhoes5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("vinte e dois septilhões treze sextilhões cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos", cheque.chequePorExtenso(022013005001400300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornarValorMaximo()
        {
            Assert.AreEqual("novecentos e noventa e nove septilhões novecentos e noventa e nove sextilhões novecentos e noventa e nove quintilhões novecentos e noventa e nove quadrilhões novecentos e noventa e nove trilhões novecentos e noventa e nove bilhões novecentos e noventa e nove milhões novecentos e noventa e nove mil novecentos e noventa e nove reais", cheque.chequePorExtenso(999999999999999999999999999m));
        }
        [TestMethod]
        public void DeveRetornarValorInvalido()
        {
            Assert.AreEqual("Valor não suportado", cheque.chequePorExtenso(2000002221351400300015010517.39m));
        }
    }
}
