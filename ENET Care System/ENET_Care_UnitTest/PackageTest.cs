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
        public void RegisterPackage_CheckFieldBarCode_FieldBarCodeFilled()
        {
            Assert.IsNotNull(_package.barCode);
        }

        [TestMethod]
        public void RegisterPackage_CheckFieldExpiryDate_FieldExpiryDateFilled()
        {
            Assert.IsNotNull(_package.ExpiryDate);
        }
        [TestMethod]
        public void RegisterPackage_CheckFieldMedicationType_FieldMedicationTypeFilled()
        {
            Assert.IsNotNull(_package.medication);
        }
        [TestMethod]
        public void RegisterPackage_CheckFieldQuantity_FieldQuantityFilled()
        {
            Assert.IsNotNull(_package.quantity);
        }

        //[TestMethod]
        //public void RegisterPackage_GenerateNewBarcode_Numbers()
        //{
        //    double newBarcode = _package.getNewBarcode();
        //    Assert.AreEqual(newBarcode, _package.barCode);
        //}
        //[TestMethod]
        //public void Register_InsertPolioVacination_PolioVacination()
        //{
        //    _package.SelectType("Polio Vaccination");
        //    Assert.AreEqual("Polio Vacination", _package.type);
        //}
        //[TestMethod]
        //public void Register_InsertExpiryDate_ExpiryDate()
        //{
        //    _package.InsertExpiryDate("11/11/17");
        //    Assert.AreEqual("11/11/17", _package.ExpiryDate);
        //}

       
    }
}
