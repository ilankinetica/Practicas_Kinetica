using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OsheroveStringCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        StringCalculator service = new StringCalculator();

        [TestMethod]
        public void StringVacio()
        {
            Assert.AreEqual(0, service.Add(""));
        }

        [TestMethod]
        public void StringUnNumero()
        {
            Assert.AreEqual(1, service.Add("1"));
            Assert.AreEqual(4, service.Add("4"));
            Assert.AreEqual(8, service.Add("8"));
            Assert.AreEqual(3, service.Add("3"));
            Assert.AreEqual(0, service.Add("0"));
        }

        [TestMethod]
        public void StringDosNumeros()
        {
            Assert.AreEqual(4, service.Add("1,3"));
            Assert.AreEqual(9, service.Add("4,5"));
            Assert.AreEqual(10, service.Add("8,2"));
            Assert.AreEqual(12, service.Add("3,9"));
            Assert.AreEqual(4, service.Add("0,4"));
        }

        [TestMethod]
        public void StringMuchosNUmeros()
        {
            Assert.AreEqual(22, service.Add("3,5,4,1,9"));
            Assert.AreEqual(36, service.Add("6,1,3,9,5,1,3,8"));
            Assert.AreEqual(37, service.Add("2,5,9,0,0,0,1,1,5,7,5,2"));
            Assert.AreEqual(47, service.Add("4,5,1,9,9,9,8,2"));
        }

        [TestMethod]
        public void SplitConNewLine()
        {
            Assert.AreEqual(4, service.Add("1\n3"));
            Assert.AreEqual(9, service.Add("4\n5"));
            Assert.AreEqual(10, service.Add("8\n2"));
            Assert.AreEqual(12, service.Add("3\n9"));
            Assert.AreEqual(4, service.Add("0\n4"));
            Assert.AreEqual(22, service.Add("3,5\n4,1\n9"));
            Assert.AreEqual(36, service.Add("6,1\n3,9\n5\n1,3,8"));
            Assert.AreEqual(37, service.Add("2,5\n9\n0,0,0,1\n1\n5\n7,5\n2"));
            Assert.AreEqual(47, service.Add("4,5,1,9,9\n9\n8,2"));
        }

        [TestMethod]
        public void CambioDeDelimiter()
        {
            Assert.AreEqual(4, service.Add("//x1x3"));
            Assert.AreEqual(9, service.Add("//r4r5"));
            Assert.AreEqual(10, service.Add("//+8+2"));
            Assert.AreEqual(22, service.Add("//s3s5\n4,1\n9"));
            Assert.AreEqual(36, service.Add("//{6,1\n3,9{5{1,3,8"));
            Assert.AreEqual(37, service.Add("//#2,5\n9\n0#0,0#1\n1\n5#7,5\n2"));
            Assert.AreEqual(47, service.Add("//%4,5,1%9,9\n9\n8,2"));
        }

        [TestMethod]
        public void ConNegativos()
        {
            try
            {
                service.Add("-1");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Numeros negativos: -1 - ", ex.Message);
            }
            
            try
            {
                service.Add("//%4,5,1%-9,9\n9\n-8,2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Numeros negativos: -9 - -8 - ", ex.Message);
            }

            try
            {
                service.Add("-1,-1,-1,-1");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Numeros negativos: -1 - -1 - -1 - -1 - ", ex.Message);
            }
        }

        [TestMethod]
        public void ConMayoresAMil()
        {
            Assert.AreEqual(17, service.Add("3,2000\n4,1\n9"));
            Assert.AreEqual(26, service.Add("6,1\n3,81732840\n5\n39840911,3,8"));
            Assert.AreEqual(1, service.Add("//x1x2602"));
            Assert.AreEqual(0, service.Add("//r38281401r1001"));
        }

        [TestMethod]
        public void ConDelimiterLargo()
        {
            Assert.AreEqual(17, service.Add("//[caca]3caca2000\n4,1\n9"));
            Assert.AreEqual(26, service.Add("//[avion]6,1\n3,81732840avion5\n39840911,3avion8"));
            Assert.AreEqual(1, service.Add("//[#$%]1#$%2602"));
            Assert.AreEqual(0, service.Add("//[con espacio]38281401con espacio1001"));
        }

        [TestMethod]
        public void MasDeUnDelimiterLargo()
        {
            Assert.AreEqual(17, service.Add("//[caca][ola]3caca2000\n4ola1\n9"));
            Assert.AreEqual(26, service.Add("//[avion][auto]6,1\n3,81732840avion5auto39840911auto3avion8"));
            Assert.AreEqual(1, service.Add("//[#$%][pedro]1#$%2602pedro2000"));
            Assert.AreEqual(0, service.Add("//[con espacio][sinespacio]3828sinespacio1401con espacio1001"));
        }
    }
}
