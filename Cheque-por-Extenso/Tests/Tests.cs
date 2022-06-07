using ChequeExtenso;
using FluentAssertions;

namespace Teste
{
    [TestFixture]
    public class Teste
    {
        Cheque cheque = new();

        [Test]
        public void DeveRetornar1Centavo()
        {
            cheque.ChequePorExtenso(0.01m).Should().Be("um centavo");
        }
        [Test]
        public void DeveRetornar10Centavos()
        {
            cheque.ChequePorExtenso(0.10m).Should().Be("dez centavos");
        }
        [Test]
        public void DeveRetornar15Centavos()
        {
            cheque.ChequePorExtenso(0.15m).Should().Be("quinze centavos");
        }
        [Test]
        public void DeveRetornar99Centavos()
        {
            cheque.ChequePorExtenso(0.99m).Should().Be("noventa e nove centavos");
        }
        [Test]
        public void DeveRetornar1Real()
        {
            cheque.ChequePorExtenso(1).Should().Be("um real");
        }
        [Test]
        public void DeveRetornar1RealE16Centavos()
        {
            cheque.ChequePorExtenso(1.16m).Should().Be("um real e dezesseis centavos");
        }
        [Test]
        public void DeveRetornar1RealE30Centavos()
        {
            cheque.ChequePorExtenso(1.30m).Should().Be("um real e trinta centavos");
        }
        [Test]
        public void DeveRetornar7ReaisE85Centavos()
        {
            cheque.ChequePorExtenso(7.85m).Should().Be("sete reais e oitenta e cinco centavos");
        }
        [Test]
        public void DeveRetornar13Reais()
        {
            cheque.ChequePorExtenso(13).Should().Be("treze reais");
        }
        [Test]
        public void DeveRetornar20ReaisE50Centavos()
        {
            cheque.ChequePorExtenso(20.50m).Should().Be("vinte reais e cinquenta centavos");
        }
        [Test]
        public void DeveRetornar100Reais()
        {
            cheque.ChequePorExtenso(100).Should().Be("cem reais");
        }
        [Test]
        public void DeveRetornar103Reais()
        {
            cheque.ChequePorExtenso(103).Should().Be("cento e três reais");
        }
        [Test]
        public void DeveRetornar500Reais()
        {
            cheque.ChequePorExtenso(500).Should().Be("quinhentos reais");
        }
        [Test]
        public void DeveRetornar1000Reais()
        {
            cheque.ChequePorExtenso(1000).Should().Be("um mil reais");
        }
        [Test]
        public void DeveRetornar1526Reais45Centavos()
        {
            cheque.ChequePorExtenso(1526.45m).Should().Be("um mil quinhentos e vinte e seis reais e quarenta e cinco centavos");
        }
        [Test]
        public void DeveRetornar1000Reais45Centavos()
        {
            cheque.ChequePorExtenso(1000.45m).Should().Be("um mil reais e quarenta e cinco centavos");
        }
        [Test]
        public void DeveRetornar1MilhaoDeReais()
        {
            cheque.ChequePorExtenso(1000000).Should().Be("um milhão de reais");
        }
        [Test]
        public void DeveRetornar1MilhaoE1DeReais()
        {
            cheque.ChequePorExtenso(1000001).Should().Be("um milhão e um real");
        }
        [Test]
        public void DeveRetornar1Milhao137Mil147Reais()
        {
            cheque.ChequePorExtenso(1137147).Should().Be("um milhão cento e trinta e sete mil cento e quarenta e sete reais");
        }
        [Test]
        public void DeveRetornar1Milhao1147Reais()
        {
            cheque.ChequePorExtenso(1001147).Should().Be("um milhão um mil cento e quarenta e sete reais");
        }
        [Test]
        public void DeveRetornar1Milhao410Mil957ReaisE13Centavos()
        {
            cheque.ChequePorExtenso(1410957.13m).Should().Be("um milhão quatrocentos e dez mil novecentos e cinquenta e sete reais e treze centavos");
        }
        [Test]
        public void DeveRetornar1MilhaoE47Reais()
        {
            cheque.ChequePorExtenso(1000047).Should().Be("um milhão e quarenta e sete reais");
        }
        [Test]
        public void DeveRetornar1MilhaoDeReaisE147Centavos()
        {
            cheque.ChequePorExtenso(1000000.47m).Should().Be("um milhão de reais e quarenta e sete centavos");
        }
        [Test]
        public void DeveRetornar1BilhaoDeReais()
        {
            cheque.ChequePorExtenso(1000000000).Should().Be("um bilhão de reais");
        }
        [Test]
        public void DeveRetornar1BilhaoDeReaisE1Centavo()
        {
            cheque.ChequePorExtenso(1000000000.01m).Should().Be("um bilhão de reais e um centavo");
        }
        [Test]
        public void DeveRetornar1BilhaoE1DeReais()
        {
            cheque.ChequePorExtenso(1000000001).Should().Be("um bilhão e um real");
        }
        [Test]
        public void DeveRetornar1BilhaoE100DeReais()
        {
            cheque.ChequePorExtenso(1000000100).Should().Be("um bilhão e cem reais");
        }
        [Test]
        public void DeveRetornar1BilhaoE100DeReaisE67Centavos()
        {
            cheque.ChequePorExtenso(1000000100.67m).Should().Be("um bilhão e cem reais e sessenta e sete centavos");
        }
        [Test]
        public void DeveRetornar1TrilhaoDeReais()
        {
            cheque.ChequePorExtenso(1000000000000).Should().Be("um trilhão de reais");
        }
        [Test]
        public void DeveRetornar1TrilhaoDeReaisE50Centavos()
        {
            cheque.ChequePorExtenso(1000000000000.50m).Should().Be("um trilhão de reais e cinquenta centavos");
        }
        [Test]
        public void DeveRetornar1TrilhaoDeE147ReaisE12Centavos()
        {
            cheque.ChequePorExtenso(1000000000147.12m).Should().Be("um trilhão e cento e quarenta e sete reais e doze centavos");
        }
        [Test]
        public void DeveRetornar1QuadrilhaoDeReais()
        {
            cheque.ChequePorExtenso(1000000000000000).Should().Be("um quadrilhão de reais");
        }
        [Test]
        public void DeveRetornar300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(300015010517.39m).Should().Be("trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornar400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(300015010517.39m).Should().Be("trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornar1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(1400300015010517.39m).Should().Be("um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornar5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(5001400300015010517.39m).Should().Be("cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornar13Sextilhoes5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(13005001400300015010517.39m).Should().Be("treze sextilhões cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornar22Septilhões13Sextilhoes5Quintilhoes1Quadrilhao400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            cheque.ChequePorExtenso(022013005001400300015010517.39m).Should().Be("vinte e dois septilhões treze sextilhões cinco quintilhões um quadrilhão quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos");
        }
        [Test]
        public void DeveRetornarValorMaximo()
        {
            cheque.ChequePorExtenso(999999999999999999999999999m).Should().Be("novecentos e noventa e nove septilhões novecentos e noventa e nove sextilhões novecentos e noventa e nove quintilhões novecentos e noventa e nove quadrilhões novecentos e noventa e nove trilhões novecentos e noventa e nove bilhões novecentos e noventa e nove milhões novecentos e noventa e nove mil novecentos e noventa e nove reais");
        }
        [Test]
        public void DeveRetornarValorInvalido()
        {
            cheque.ChequePorExtenso(2000002221351400300015010517.39m).Should().Be("Valor não suportado");
        }
    }
}
