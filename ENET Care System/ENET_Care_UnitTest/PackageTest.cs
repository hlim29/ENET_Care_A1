using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Data;

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
        public void RegisterPackage_CheckFieldBarCode_FieldBarCodeFilled()
        {
            Assert.IsNotNull(_package.BarCode);
        }

        [TestMethod]
        public void RegisterPackage_CheckFieldExpiryDate_FieldExpiryDateFilled()
        {
            Assert.IsNotNull(_package.ExpiryDate);
        }
        [TestMethod]
        public void RegisterPackage_CheckFieldMedicationType_FieldMedicationTypeFilled()
        {
            Assert.IsNotNull(_package.Medication);
        }
        [TestMethod]
        public void RegisterPackage_CheckFieldQuantity_FieldQuantityFilled()
        {
            Assert.IsNotNull(_package.Quantity);
        }
    }
}
