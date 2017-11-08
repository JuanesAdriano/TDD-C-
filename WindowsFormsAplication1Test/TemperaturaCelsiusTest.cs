using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace WindowsFormsAplication1Test
{
    [TestClass]
    public class TemperaturaCelsiusTest
    {
        [TestMethod]
        public void TesteTemperaturaCelsiusDouble()
        {

            double a = 0;
            double expected = 1.8* a + 32;
            TemperaturaCelsius target = new TemperaturaCelsius(a);
             double actual = target.converteCelsiusParaFahrenheit();
            Assert.AreEqual(expected, actual);



        }
    }
}
