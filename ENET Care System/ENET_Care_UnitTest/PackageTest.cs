using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Data;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class PackageTest
    {
        Package _package;

        /**
         * ASSUMPTION: Constructor Package(Medication, ExpiryDate)
         * */
        [TestInitialize]
        public void Setup()
        {
            //NOTE: Uncomment when method ready to be tested

            //Package _package = new Package(createMockMedication(), new DateTime(17, 12, 12));
        }
        /**
         * A package should always have a package status.
         * Checking if the PackageStatus has been created or not in PackageRegistration.
         * NOTE: getPackageStatus() should search its own packageID in the collections
         * */
        [TestMethod]
        public void getPackageStatus_packageObject_Status()
        {
            //NOTE: Uncomment when method ready to be tested.

            //PackageStatus status = _package.getPackageStatus();
            //Assert.Equals("inStock", status.Status);
        }

        /**
         * Addition method to create a mock object
         * */
        private MedicationStandardType createMockMedication()
        {
            var dummyMedication = new Moq.Mock<MedicationStandardType>();
            dummyMedication.SetupProperty(medication => medication.Quantity, 100)
                .SetupProperty(medication => medication.Description, "Medication Pills")
                .SetupProperty(medication => medication.Cost, 30.00)
                .SetupProperty(medication => medication.IsTempSensitive, false)
                .SetupProperty(medication => medication.ShelfLife, "12/12/17");
            return dummyMedication.Object;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /**
         * Here below is a dummy testing, will be finalised soon
         * */
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
