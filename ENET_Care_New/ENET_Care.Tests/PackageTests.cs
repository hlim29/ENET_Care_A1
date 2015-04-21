using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Business;
using ENET_Care.Data;
using System.Diagnostics;

namespace ENET_Care.Tests
{
    [TestClass]
    public class PackageTests
    {
        [TestMethod]
        public void PackageTest_ExpirationDateTest_Past()
        {
            DateTime pastDate = new DateTime(2000, 01, 01, 00, 00, 00);
            PackageLogic.Result result = PackageLogic.ValidateInput(pastDate);
            Assert.AreEqual(PackageLogic.Result.PastDate, result);
        }

        [TestMethod]
        public void PackageTest_ExpirationDateTest_Future()
        {
            DateTime futureDate = DateTime.ParseExact("10/10/2100", "dd/MM/yyyy", null);
            PackageLogic.Result result = PackageLogic.ValidateInput(futureDate);
            Assert.AreEqual(PackageLogic.Result.Ok, result);
        }

        [TestMethod]
        public void PackageText_RetrieveAllPackages()
        {
            //Debug.WriteLine(new Package().RetrieveAllPackages().Count);
            Assert.AreNotEqual(0,new Package().RetrieveAllPackages().Count);

        }
        /**
         * Checking wether total package is added or not after adding a new package
         * */
        [TestMethod]
        public void PackageTest_AddPackages_PackageCountInreased()
        {
            int packageTotal = new Package().RetrieveAllPackages().Count;
            PackageLogic.AddPackage(new Package());
            Assert.AreEqual(packageTotal+1, new Package().RetrieveAllPackages().Count);
        }
        /**
         * Checking wether registering package successful
         * With successfulcase (Expirydate is in the future)
         * */
        [TestMethod]
        public void PackageTest_RegisterPackage_SuccessCase()
        {
            DateTime futureDate = new DateTime(2100, 10, 10);
            Assert.AreNotEqual(-1, PackageLogic.RegisterPackage(futureDate, "MedicationId"));
        }

        /**
         * Check the expirydate the same as what registered.
         * Register a new package and get the barcode, then recheck it with the GetExpiryDate() method.
         * */
        [TestMethod]
        public void PackageTest_GetExpiryDate()
        {
            DateTime futureDate = new DateTime(2111, 01, 01);
            int barcode = PackageLogic.RegisterPackage(futureDate, "MedicationId");
            Assert.AreEqual(futureDate, PackageLogic.GetExpiryDate(barcode));
        }

    }
}
