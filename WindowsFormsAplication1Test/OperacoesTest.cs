using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsAplication1Test;
using WindowsFormsApplication1;

namespace WindowsFormsAplication1Test

{
    [TestClass]
    public class OperacoesTest
    {
        [TestMethod]
        public void TestSomaInteiros()
        {
            int a = 10;
            int b = 1;
            int expected = 11;
            int actual = 0;
            Operacoes target = new Operacoes();
             actual = target.soma(a, b);
             Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSubtraiInteiros()
        {
            int a = 30;
            int b = 1;
            int expected = 29;
            int actual = 0;
            Operacoes target = new Operacoes();
            actual = target.subtrai(a, b);
            Assert.AreEqual(expected, actual);

        }
    }
}
