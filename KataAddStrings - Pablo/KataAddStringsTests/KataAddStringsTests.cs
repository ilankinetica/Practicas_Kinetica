using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataAddStrings;


namespace KataAddStringsTests
{
    [TestClass]
    public class KataAddStringsTests
    {
        [TestMethod]
        public void SumarStringVacio()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("");

            var resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarUnNumero()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("1");

            var resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarDosNumeros()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("1,2");

            var resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarTresNumeros()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("1,2,3");

            var resultadoEsperado = 6;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarCuatroNumeros()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("1,2,3,4");

            var resultadoEsperado = 10;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarCincoNumeros()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("1,2,3,4,5");

            var resultadoEsperado = 15;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarConOtroDelimitador()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("//?1?2?3");

            var resultadoEsperado = 6;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarConOtroDelimitadorOtra()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("//#1#2#3#4");

            var resultadoEsperado = 10;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarConOtroDelimitadorConNegativo()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("//?-1?2?3?4");

            var resultadoEsperado = 8;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SumarConOtroDelimitadorConDosNegativos()
        {
            Calculadora calc = new Calculadora();

            var resultado = calc.Add("//?-1?2?3?-4");

            var resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
