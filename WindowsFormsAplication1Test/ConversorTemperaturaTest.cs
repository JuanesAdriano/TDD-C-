using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;

namespace WindowsFormsAplication1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDoubleCelsiusFahrenheit()

        {
            double a = 0;
            double expect = 1.8 * a + 32;
            //ConversorTemperatura target = new ConversorTemperatura();
            double actual = ConversorTemperatura.converteCelsiusParaFahrenheit(a);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestDoubleFahrenheitCelsius()
        {
            double a = 0;
            double expected = (5 / 9) * (a - 322);
            //double Math.Round(expected);
            double actual = ConversorTemperatura.converteFahrenheitParaCelsius(a);
            Assert.AreEqual(expected, actual); 

        }
    }
}
