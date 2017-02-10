using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Romanos.Test
{
    [TestClass]
    public class DecimalARomano
    {
        [TestMethod]
        public void Cero()
        {
            Assert.AreEqual("I", 1.DecimalARomanos());
            Assert.AreEqual("II", 2.DecimalARomanos());
            Assert.AreEqual("III", 3.DecimalARomanos());
            Assert.AreEqual("IV", 4.DecimalARomanos());
            Assert.AreEqual("V", 5.DecimalARomanos());
            Assert.AreEqual("VI", 6.DecimalARomanos());
            Assert.AreEqual("VII", 7.DecimalARomanos());
            Assert.AreEqual("VIII", 8.DecimalARomanos());
            Assert.AreEqual("IX", 9.DecimalARomanos());
            Assert.AreEqual("X", 10.DecimalARomanos());
        }

        [TestMethod]
        public void Diez()
        {
            Assert.AreEqual("XI", 11.DecimalARomanos());
            Assert.AreEqual("XII", 12.DecimalARomanos());
            Assert.AreEqual("XIII", 13.DecimalARomanos());
            Assert.AreEqual("XIV", 14.DecimalARomanos());
            Assert.AreEqual("XV", 15.DecimalARomanos());
            Assert.AreEqual("XVI", 16.DecimalARomanos());
            Assert.AreEqual("XVII", 17.DecimalARomanos());
            Assert.AreEqual("XVIII", 18.DecimalARomanos());
            Assert.AreEqual("XIX", 19.DecimalARomanos());
            Assert.AreEqual("XX", 20.DecimalARomanos());
        }

        [TestMethod]
        public void Veinte()
        {
            Assert.AreEqual("XXI", 21.DecimalARomanos());
            Assert.AreEqual("XXII", 22.DecimalARomanos());
            Assert.AreEqual("XXIII", 23.DecimalARomanos());
            Assert.AreEqual("XXIV", 24.DecimalARomanos());
            Assert.AreEqual("XXV", 25.DecimalARomanos());
            Assert.AreEqual("XXVI", 26.DecimalARomanos());
            Assert.AreEqual("XXVII", 27.DecimalARomanos());
            Assert.AreEqual("XXVIII", 28.DecimalARomanos());
            Assert.AreEqual("XXIX", 29.DecimalARomanos());
            Assert.AreEqual("XXX", 30.DecimalARomanos());
        }

        [TestMethod]
        public void Treinta()
        {
            Assert.AreEqual("XXXI", 31.DecimalARomanos());
            Assert.AreEqual("XXXII", 32.DecimalARomanos());
            Assert.AreEqual("XXXIII", 33.DecimalARomanos());
            Assert.AreEqual("XXXIV", 34.DecimalARomanos());
            Assert.AreEqual("XXXV", 35.DecimalARomanos());
            Assert.AreEqual("XXXVI", 36.DecimalARomanos());
            Assert.AreEqual("XXXVII", 37.DecimalARomanos());
            Assert.AreEqual("XXXVIII", 38.DecimalARomanos());
            Assert.AreEqual("XXXIX", 39.DecimalARomanos());
            Assert.AreEqual("XL", 40.DecimalARomanos());
        }

        [TestMethod]
        public void Cuarenta()
        {
            Assert.AreEqual("XLI", 41.DecimalARomanos());
            Assert.AreEqual("XLII", 42.DecimalARomanos());
            Assert.AreEqual("XLIII", 43.DecimalARomanos());
            Assert.AreEqual("XLIV", 44.DecimalARomanos());
            Assert.AreEqual("XLV", 45.DecimalARomanos());
            Assert.AreEqual("XLVI", 46.DecimalARomanos());
            Assert.AreEqual("XLVII", 47.DecimalARomanos());
            Assert.AreEqual("XLVIII", 48.DecimalARomanos());
            Assert.AreEqual("XLIX", 49.DecimalARomanos());
            Assert.AreEqual("L", 50.DecimalARomanos());
        }

        [TestMethod]
        public void Cincuenta()
        {
            Assert.AreEqual("LI", 51.DecimalARomanos());
            Assert.AreEqual("LII", 52.DecimalARomanos());
            Assert.AreEqual("LIII", 53.DecimalARomanos());
            Assert.AreEqual("LIV", 54.DecimalARomanos());
            Assert.AreEqual("LV", 55.DecimalARomanos());
            Assert.AreEqual("LVI", 56.DecimalARomanos());
            Assert.AreEqual("LVII", 57.DecimalARomanos());
            Assert.AreEqual("LVIII", 58.DecimalARomanos());
            Assert.AreEqual("LIX", 59.DecimalARomanos());
            Assert.AreEqual("LX", 60.DecimalARomanos());
        }

        [TestMethod]
        public void Sesenta()
        {
            Assert.AreEqual("LXI", 61.DecimalARomanos());
            Assert.AreEqual("LXII",62.DecimalARomanos());
            Assert.AreEqual("LXIII",63.DecimalARomanos());
            Assert.AreEqual("LXIV",64.DecimalARomanos());
            Assert.AreEqual("LXV",65.DecimalARomanos());
            Assert.AreEqual("LXVI",66.DecimalARomanos());
            Assert.AreEqual("LXVII",67.DecimalARomanos());
            Assert.AreEqual("LXVIII",68.DecimalARomanos());
            Assert.AreEqual("LXIX",69.DecimalARomanos());
            Assert.AreEqual("LXX", 70.DecimalARomanos());
        }

        [TestMethod]
        public void Setenta()
        {
            Assert.AreEqual("LXXI", 71.DecimalARomanos());
            Assert.AreEqual("LXXII", 72.DecimalARomanos());
            Assert.AreEqual("LXXIII", 73.DecimalARomanos());
            Assert.AreEqual("LXXIV", 74.DecimalARomanos());
            Assert.AreEqual("LXXV", 75.DecimalARomanos());
            Assert.AreEqual("LXXVI", 76.DecimalARomanos());
            Assert.AreEqual("LXXVII", 77.DecimalARomanos());
            Assert.AreEqual("LXXVIII", 78.DecimalARomanos());
            Assert.AreEqual("LXXIX", 79.DecimalARomanos());
            Assert.AreEqual("LXXX", 80.DecimalARomanos());
        }

        [TestMethod]
        public void Ochenta()
        {
            Assert.AreEqual("LXXXI", 81.DecimalARomanos());
            Assert.AreEqual("LXXXII", 82.DecimalARomanos());
            Assert.AreEqual("LXXXIII", 83.DecimalARomanos());
            Assert.AreEqual("LXXXIV", 84.DecimalARomanos());
            Assert.AreEqual("LXXXV", 85.DecimalARomanos());
            Assert.AreEqual("LXXXVI", 86.DecimalARomanos());
            Assert.AreEqual("LXXXVII", 87.DecimalARomanos());
            Assert.AreEqual("LXXXVIII", 88.DecimalARomanos());
            Assert.AreEqual("LXXXIX", 89.DecimalARomanos());
            Assert.AreEqual("XC", 90.DecimalARomanos());
        }

        [TestMethod]
        public void Noventa()
        {
            Assert.AreEqual("XCI", 91.DecimalARomanos());
            Assert.AreEqual("XCII", 92.DecimalARomanos());
            Assert.AreEqual("XCIII", 93.DecimalARomanos());
            Assert.AreEqual("XCIV", 94.DecimalARomanos());
            Assert.AreEqual("XCV", 95.DecimalARomanos());
            Assert.AreEqual("XCVI", 96.DecimalARomanos());
            Assert.AreEqual("XCVII", 97.DecimalARomanos());
            Assert.AreEqual("XCVIII", 98.DecimalARomanos());
            Assert.AreEqual("XCIX", 99.DecimalARomanos());
            Assert.AreEqual("C", 100.DecimalARomanos());
        }

        [TestMethod]
        public void Cien()
        {
            Assert.AreEqual("CI", 101.DecimalARomanos());
            Assert.AreEqual("CII", 102.DecimalARomanos());
            Assert.AreEqual("CIII", 103.DecimalARomanos());
            Assert.AreEqual("CIV", 104.DecimalARomanos());
            Assert.AreEqual("CV", 105.DecimalARomanos());
            Assert.AreEqual("CVI", 106.DecimalARomanos());
            Assert.AreEqual("CVII", 107.DecimalARomanos());
            Assert.AreEqual("CVIII", 108.DecimalARomanos());
            Assert.AreEqual("CIX", 109.DecimalARomanos());
            Assert.AreEqual("CX", 110.DecimalARomanos());
        }

        [TestMethod]
        public void CientoCuarenta()
        {
            Assert.AreEqual("CXLI", 141.DecimalARomanos());
            Assert.AreEqual("CXLII", 142.DecimalARomanos());
            Assert.AreEqual("CXLIII", 143.DecimalARomanos());
            Assert.AreEqual("CXLIV", 144.DecimalARomanos());
            Assert.AreEqual("CXLV", 145.DecimalARomanos());
            Assert.AreEqual("CXLVI", 146.DecimalARomanos());
            Assert.AreEqual("CXLVII", 147.DecimalARomanos());
            Assert.AreEqual("CXLVIII", 148.DecimalARomanos());
            Assert.AreEqual("CXLIX", 149.DecimalARomanos());
            Assert.AreEqual("CL", 150.DecimalARomanos());
        }

        [TestMethod]
        public void CuatrocientosOchenta()
        {
            Assert.AreEqual("CDLXXXI", 481.DecimalARomanos());
            Assert.AreEqual("CDLXXXII", 482.DecimalARomanos());
            Assert.AreEqual("CDLXXXIII", 483.DecimalARomanos());
            Assert.AreEqual("CDLXXXIV", 484.DecimalARomanos());
            Assert.AreEqual("CDLXXXV", 485.DecimalARomanos());
            Assert.AreEqual("CDLXXXVI", 486.DecimalARomanos());
            Assert.AreEqual("CDLXXXVII", 487.DecimalARomanos());
            Assert.AreEqual("CDLXXXVIII", 488.DecimalARomanos());
            Assert.AreEqual("CDLXXXIX", 489.DecimalARomanos());
            Assert.AreEqual("CDXC", 490.DecimalARomanos());
        }

        [TestMethod]
        public void MilDocientosTreinta()
        {
            Assert.AreEqual("MCCXXXI", 1231.DecimalARomanos());
            Assert.AreEqual("MCCXXXII", 1232.DecimalARomanos());
            Assert.AreEqual("MCCXXXIII", 1233.DecimalARomanos());
            Assert.AreEqual("MCCXXXIV", 1234.DecimalARomanos());
            Assert.AreEqual("MCCXXXV", 1235.DecimalARomanos());
            Assert.AreEqual("MCCXXXVI", 1236.DecimalARomanos());
            Assert.AreEqual("MCCXXXVII", 1237.DecimalARomanos());
            Assert.AreEqual("MCCXXXVIII", 1238.DecimalARomanos());
            Assert.AreEqual("MCCXXXIX", 1239.DecimalARomanos());
            Assert.AreEqual("MCCXL", 1240.DecimalARomanos());
        }

        [TestMethod]
        public void MilNovecientosOchenta()
        {
            Assert.AreEqual("MCMLXXXI", 1981.DecimalARomanos());
            Assert.AreEqual("MCMLXXXII", 1982.DecimalARomanos());
            Assert.AreEqual("MCMLXXXIII", 1983.DecimalARomanos());
            Assert.AreEqual("MCMLXXXIV", 1984.DecimalARomanos());
            Assert.AreEqual("MCMLXXXV", 1985.DecimalARomanos());
            Assert.AreEqual("MCMLXXXVI", 1986.DecimalARomanos());
            Assert.AreEqual("MCMLXXXVII", 1987.DecimalARomanos());
            Assert.AreEqual("MCMLXXXVIII", 1988.DecimalARomanos());
            Assert.AreEqual("MCMLXXXIX", 1989.DecimalARomanos());
            Assert.AreEqual("MCMXC", 1990.DecimalARomanos());
        }

        [TestMethod]
        public void DosmilSeisientos()
        {
            Assert.AreEqual("MMDCI", 2601.DecimalARomanos());
            Assert.AreEqual("MMDCII", 2602.DecimalARomanos());
            Assert.AreEqual("MMDCIII", 2603.DecimalARomanos());
            Assert.AreEqual("MMDCIV", 2604.DecimalARomanos());
            Assert.AreEqual("MMDCV", 2605.DecimalARomanos());
            Assert.AreEqual("MMDCVI", 2606.DecimalARomanos());
            Assert.AreEqual("MMDCVII", 2607.DecimalARomanos());
            Assert.AreEqual("MMDCVIII", 2608.DecimalARomanos());
            Assert.AreEqual("MMDCIX", 2609.DecimalARomanos());
            Assert.AreEqual("MMDCX", 2610.DecimalARomanos());
        }

        [TestMethod]
        public void TresmilDocientosCuarenta()
        {
            Assert.AreEqual("MMMCCXLI", 3241.DecimalARomanos());
            Assert.AreEqual("MMMCCXLII", 3242.DecimalARomanos());
            Assert.AreEqual("MMMCCXLIII", 3243.DecimalARomanos());
            Assert.AreEqual("MMMCCXLIV", 3244.DecimalARomanos());
            Assert.AreEqual("MMMCCXLV", 3245.DecimalARomanos());
            Assert.AreEqual("MMMCCXLVI", 3246.DecimalARomanos());
            Assert.AreEqual("MMMCCXLVII", 3247.DecimalARomanos());
            Assert.AreEqual("MMMCCXLVIII", 3248.DecimalARomanos());
            Assert.AreEqual("MMMCCXLIX", 3249.DecimalARomanos());
            Assert.AreEqual("MMMCCL", 3250.DecimalARomanos());
        }

        [TestMethod]
        public void TresmilNovecietnosNoventa()
        {
            Assert.AreEqual("MMMCMXCI", 3991.DecimalARomanos());
            Assert.AreEqual("MMMCMXCII", 3992.DecimalARomanos());
            Assert.AreEqual("MMMCMXCIII", 3993.DecimalARomanos());
            Assert.AreEqual("MMMCMXCIV", 3994.DecimalARomanos());
            Assert.AreEqual("MMMCMXCV", 3995.DecimalARomanos());
            Assert.AreEqual("MMMCMXCVI", 3996.DecimalARomanos());
            Assert.AreEqual("MMMCMXCVII", 3997.DecimalARomanos());
            Assert.AreEqual("MMMCMXCVIII", 3998.DecimalARomanos());
            Assert.AreEqual("MMMCMXCIX", 3999.DecimalARomanos());
            Assert.AreEqual(null, 4000.DecimalARomanos());
        }
    }
}
