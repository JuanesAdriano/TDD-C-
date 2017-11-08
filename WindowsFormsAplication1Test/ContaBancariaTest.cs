using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace WindowsFormsAplication1Test
{
    [TestClass]
    public class ContaBancariaTest
    {
        [TestMethod]
        public void TestStringNomeCorrentista()
        {
            ContaBancaria conta = new ContaBancaria("Juanes", 500.50);
            String actual = conta.NomeCorrentista;
            String expected = "Juanes";
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestDoubleSaldo()
        {
            ContaBancaria conta = new ContaBancaria("Juanes", 500.50);
            Double actual = conta.Saldo;
            Double expected = 500.50;
            Assert.AreEqual(actual, expected);     
        }

        [TestMethod]

        public void TestDebito()
        {
            ContaBancaria conta = new ContaBancaria("Juanes", 500.50);
            conta.Debito(400.00);
            double expected = 500.50 - 400.00;
            Assert.AreEqual(expected, conta.Saldo);

        }

        [TestMethod]

        public void TestCredito()
        {
            ContaBancaria conta = new ContaBancaria("Juanes", 500.50);
            conta.Credito(400.00);
            double expected = 500.50 + 400.00;
            Assert.AreEqual(expected, conta.Saldo);

        }

        [TestMethod]

        public void TestBloqueio()
        {
            ContaBancaria conta = new ContaBancaria("Juanes", 500.50);
            conta.BloquearConta();
            conta.Debito(200.0);
            double expected = 500.50 - 0;
            Assert.AreEqual(expected, conta.Saldo);

        }

    }
}
