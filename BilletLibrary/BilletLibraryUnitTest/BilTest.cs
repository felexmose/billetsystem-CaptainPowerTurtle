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
            decimal pris = bil.SetPrice();
            //assert
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        public void K�ret�jTypeTest()
        {
            //arrange
            var bil = new Bil();
            //act
            string k�ret�j = bil.SetK�ret�j();
            //assert
            Assert.AreEqual("Bil", k�ret�j);
        }
    }
}
