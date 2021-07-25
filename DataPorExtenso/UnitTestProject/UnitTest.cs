using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data_PorExtenso;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        Data p = new Data(new DateTime(2021, 05, 27));

        [TestMethod]
        public void DeveRetornar1segundo()
        {
            Assert.AreEqual("um segundo atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 23, 59, 59)));
        }
        [TestMethod]
        public void DeveRetornar22segundos()
        {
            Assert.AreEqual("vinte e dois segundos atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 23, 59, 38)));
        }
        [TestMethod]
        public void DeveRetornar1Minuto()
        {
            Assert.AreEqual("um minuto atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 23, 59, 0)));
        }
        [TestMethod]
        public void DeveRetornar1Hora()
        {
            Assert.AreEqual("uma hora atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 23, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar22Horas()
        {
            Assert.AreEqual("vinte e duas horas atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 2, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar1Dia()
        {
            Assert.AreEqual("um dia atrás", p.periodoPorExtenso(new DateTime(2021, 05, 26, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar1Mes()
        {
            Assert.AreEqual("um mês atrás", p.periodoPorExtenso(new DateTime(2021, 04, 27, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar1Ano()
        {
            Assert.AreEqual("um ano atrás", p.periodoPorExtenso(new DateTime(2020, 05, 27, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar10Anos()
        {
            Assert.AreEqual("dez anos atrás", p.periodoPorExtenso(new DateTime(2011, 05, 30, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar15Anos1Mes5Dias()
        {
            Assert.AreEqual("quinze anos um mês cinco dias atrás", p.periodoPorExtenso(new DateTime(2006, 04, 26, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar20Anos1Mes5Dias()
        {
            Assert.AreEqual("vinte anos um mês cinco dias atrás", p.periodoPorExtenso(new DateTime(2001, 04, 27, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar98Anos5Meses3Semanas()
        {
            Assert.AreEqual("noventa e oito anos cinco meses três semanas atrás", p.periodoPorExtenso(new DateTime(1923, 1, 1, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar97Anos5Meses3Semanas6Dias()
        {
            Assert.AreEqual("noventa e sete anos cinco meses três semanas seis dias atrás", p.periodoPorExtenso(new DateTime(1923, 12, 26, 0, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar97Anos5Meses3Semanas6Dias3Horas()
        {
            Assert.AreEqual("noventa e sete anos cinco meses três semanas seis dias três horas atrás", p.periodoPorExtenso(new DateTime(1923, 12, 25, 21, 0, 0)));
        }
        [TestMethod]
        public void DeveRetornar97Anos5Meses3Semanas6Dias3Horas20Minutos()
        {
            Assert.AreEqual("noventa e sete anos cinco meses três semanas seis dias três horas vinte minutos atrás", p.periodoPorExtenso(new DateTime(1923, 12, 25, 20, 40, 0)));
        }
        [TestMethod]
        public void DeveRetornar97Anos5Meses3Semanas6Dias3Horas20Minutos30Segundos()
        {
            Assert.AreEqual("noventa e sete anos cinco meses três semanas seis dias três horas vinte minutos trinta segundos atrás", p.periodoPorExtenso(new DateTime(1923, 12, 25, 20, 39, 30)));
        }
        [TestMethod]
        public void DeveRetornarInvalida()
        {
            Assert.AreEqual("Período muito grande, data não suportada", p.periodoPorExtenso(new DateTime(1922, 12, 31, 23, 59, 59)));
        }
    }
}
