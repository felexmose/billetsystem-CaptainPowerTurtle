using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryUnitTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilBilletPrisTest()
        {
            //arrange
            var bil = new Bil();
            //act
            decimal pris = bil.Pris();
            //assert
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        public void BilBilletPrisTest_MedDato()
        {
            //arrange
            var bil = new Bil("AB12345", DateTime.Now);
            //act
            decimal pris = bil.Pris();
            //assert
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        public void K�ret�jTypeTest()
        {
            //arrange
            var bil = new Bil("AB12345", DateTime.Now);
            //act
            string k�ret�j = bil.Type();
            //assert
            Assert.AreEqual("Bil", k�ret�j);
        }
        [TestMethod]
        public void BilRabatTest_True()
        {
            //arrange
            var bil = new Bil();
            //act
            decimal rabat = bil.RabatPris(true);
            //assert
            Assert.AreEqual(rabat, 228M);
        }
        public void BilRabatTest_False()
        {
            //arrange
            var bil = new Bil();
            //act
            decimal rabat = bil.RabatPris(false);
            //assert
            Assert.AreEqual(rabat, 240M);
        }
    }
}
