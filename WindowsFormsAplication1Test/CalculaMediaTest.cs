using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace WindowsFormsAplication1Test
{
    [TestClass]
    public class CalculaMediaTest
    {
        [TestMethod]
        public void TestCalcularMediaDecimal()
        {
           CalculaMedia target = new CalculaMedia();
            target.InserirNotaProva(6);
            target.InserirNotaProva(6);
            target.InserirNotaProva(6);
            target.InserirNotaProva(6);

            target.InserirPonto(8);
            target.InserirPonto(8);
            target.InserirPonto(8);
            target.InserirPonto(8);

            decimal actual = target.CalcularMedia();
            decimal expected = 7;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void TestInserirNotaProva()
        {
            CalculaMedia target = new CalculaMedia();
            target.InserirNotaProva(3);
            target.InserirNotaProva(3);
            target.InserirNotaProva(3);
            target.InserirNotaProva(3);
          

            Assert.AreEqual(4, target.ContadorProvas);
        }

        [TestMethod]

        public void TestInserirPonto()
        {
            CalculaMedia target = new CalculaMedia();
            target.InserirPonto(3);
            target.InserirPonto(3);
            target.InserirPonto(3);
            target.InserirPonto(3);

            
            Assert.AreEqual(4, target.ContadorPontos);
        }


    }
    }

