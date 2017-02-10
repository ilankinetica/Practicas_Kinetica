using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Romanos.Test
{
    [TestClass]
    public class RomanoADecimal
    {
        [TestMethod]
        public void ConvertirRomanoADecimal()
        {
            Assert.AreEqual(1, "I".RomanoAdDecimal());
            Assert.AreEqual(23, "XXIII".RomanoAdDecimal());
            Assert.AreEqual(87, "LXXXVII".RomanoAdDecimal());
            Assert.AreEqual(153, "CLIII".RomanoAdDecimal());
            Assert.AreEqual(249, "CCXLIX".RomanoAdDecimal());
            Assert.AreEqual(601, "DCI".RomanoAdDecimal());
            Assert.AreEqual(767, "DCCLXVII".RomanoAdDecimal());
            Assert.AreEqual(1098, "MXCVIII".RomanoAdDecimal());
            Assert.AreEqual(1137, "MCXXXVII".RomanoAdDecimal());
            Assert.AreEqual(1500, "MD".RomanoAdDecimal());
            Assert.AreEqual(1799, "MDCCXCIX".RomanoAdDecimal());
            Assert.AreEqual(2673, "MMDCLXXIII".RomanoAdDecimal());
            Assert.AreEqual(2801, "MMDCCCI".RomanoAdDecimal());
            Assert.AreEqual(3421, "MMMCDXXI".RomanoAdDecimal());
            Assert.AreEqual(3872, "MMMDCCCLXXII".RomanoAdDecimal());
        }

        [TestMethod]
        public void NoRomanos()
        {
            Assert.AreEqual(0, "hol".RomanoAdDecimal());
            Assert.AreEqual(0, "CCCC".RomanoAdDecimal());
            Assert.AreEqual(0, "MCMCMCMC".RomanoAdDecimal());
            Assert.AreEqual(0, "IIVICXDL".RomanoAdDecimal());
            Assert.AreEqual(0, "MMMDCCCLXXXVIIIV".RomanoAdDecimal());
            Assert.AreEqual(0, "DM".RomanoAdDecimal());
            Assert.AreEqual(0, "MMMM".RomanoAdDecimal());
        }
    }
}
