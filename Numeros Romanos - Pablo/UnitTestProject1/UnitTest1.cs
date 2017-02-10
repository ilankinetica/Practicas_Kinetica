using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarDosEnteros()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Sumar(1,2);

            var resultadoEsperado = 3;

            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroMayorATresMilGeneraExcepcionFueraDeRango()
        {
            var converter = new EnteroARomano();
            converter.ConvertirEnteroARomano(3001);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroMenorAUnoGeneraExcepcionFueraDeRango()
        {
           var converter = new EnteroARomano();
           converter.ConvertirEnteroARomano(-1); 
        
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroCeroGeneraExcepcionFueraDeRango()
        {
            var converter = new EnteroARomano();
            converter.ConvertirEnteroARomano(0);

        }

        [TestMethod]
        public void NumeroUnoResultadoEsperadoI()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(1);

            Assert.AreEqual(result, "I");

        }

        [TestMethod]
        public void NumeroTresMilResultadoEsperadoMMM()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(3000);

            Assert.AreEqual(result, "MMM");

        }

        [TestMethod]
        public void Numero55ResultadoEsperadoLV()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(55);

            Assert.AreEqual(result, "LV");

        }

        [TestMethod]
        public void NumeroCienResultadoEsperadoC()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(100);

            Assert.AreEqual(result, "C");

        }

        [TestMethod]
        public void Numero500ResultadoEsperadoD()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(500);

            Assert.AreEqual(result, "D");

        }

        [TestMethod]
        public void Numero599ResultadoEsperadoDXCIX()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(599);

            Assert.AreEqual(result, "DXCIX");

        }

        [TestMethod]
        public void Numero2013ResultadoEsperadoMMXIII()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(2013);

            Assert.AreEqual(result, "MMXIII");

        }

        [TestMethod]
        public void Numero2347ResultadoEsperadoMMCCCXLVII()
        {
            var converter = new EnteroARomano();
            var result = converter.ConvertirEnteroARomano(2347);

            Assert.AreEqual(result, "MMCCCXLVII");

        }
    }
}
