using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care_Console;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class PackageTest
    {
        Package _package;

        [TestInitialize]
        public void Setup()
        {
            _package = new Package();
        }

        [TestMethod]
        public void RegisterPackage_CkeckFieldBarCode_FieldBarCodeFilled()
        {
            Assert.IsNotNull(_package.barCode);
        }

        [TestMethod]
        public void RegisterPackage_CkeckFieldExpiryDate_FieldExpiryDateFilled()
        {
            Assert.IsNotNull(_package.ExpiryDate);
        }
    }
}
