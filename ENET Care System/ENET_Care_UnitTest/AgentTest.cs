using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Business;
using ENET_Care.Data;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class AgentTest
    {
        Agent _agent;

        [TestInitialize]
        public void Setup()
        {
            DistributionCentre dc = new DistributionCentre();
            dc.Id = 1;
            _agent = new Agent();
            _agent.FirstName = "Andrea";
            _agent.LastName = "Sa";
            _agent.Role = "Doctor";

        }

        /**
         * Registering new package and assigning to current Distribution Centre
         * Checking if the package got the barcode or not.
         * Checking if the PackageStatus for the new package has been created.
         * 
         * ASSUMPTION: Agent.RegisterPackage return a package object.
         * */
        [TestMethod]
        public void RegisterPackage_PackageDetails_BarcodeExist()
        {
            //NOTE: Uncomment when method already updated

            //Package newPackage = createMockPackage();
            //newPackage.Medication = createMockMedication();
            //_agent.RegisterPackage(newPackage);
            //Assert.AreNotEqual(null, newPackage.BarCode);
            //Assert.AreNotEquals(null, newPackage.getPackageStatus());
        }
        /**
         * A package should always have a package status.
         * Checking if the PackageStatus has been created or not in PackageRegistration.
         * NOTE: getPackageStatus() should search packageID in the collections
         * */
        [TestMethod]
        public void getPackageStatus_packageId_InStock()
        {
            //NOTE: Uncomment when method ready to be tested.

            //Package newPackage = createMockPackage();
            //newPackage.Medication = createMockMedication();
            //_agent.RegisterPackage(newPackage);
            //PackageStatus status = _agent.getPackageStatus(packageObject.BarCode);
            //Assert.Equals("inStock", status.Status);
        }
        /**
         * Send Package method
         * Creating Mock Object for Package and Package Status
         * Updating Package Status 'Status' and 'Centre Destination' property
         * */
        [TestMethod]
        public void SendPackage_PackageBarcode_PackageStatusChanged()
        {
            //NOTE: Uncomment when method ready to be tested

            DistributionCentre destination = new Moq.Mock<DistributionCentre>().Object;
            Package packageObject = createMockPackage();
            //PackageStatus packageStatusObject = _agent.getPackageStatus(packageObject.BarCode);
            //_agent.SendPackage(barcode, destination); //Uncomment when method already updated
            //Assert.Equals("onTransit", packageStatusObject.Status);
            //Assert.Equals(destination, packageStatusObject.CentreDestination);
        }

        /**
         * Receiving package
         * Change the Package Status when received to "InStock"
         * Confirming that centre source is changed
         * ASSUMPTION : Current package location written in packageSource
         * */
        [TestMethod]
        public void ReceivePackage_PackageBarcode_PackageStatusChanged()
        {
            //NOTE: Uncomment when method ready to be tested

            Package packageObject = createMockPackage();
            //PackageStatus packageStatusObject = _agent.getPackageStatus(packageObject.BarCode);
            _agent.ReceivePackage(packageObject.BarCode);
            //Assert.Equals("inStock", packageStatusObject.Status);
            //Assert.Equals(_agent.DistributionCentre, packageStatusObject.CentreSource);
        }
        /**
         * Discarding Package
         * Change the Status property in PackageStatus becomes True
         * ASSUMPTION: Removing and Discarding only change the status become "Inactive" (Status becomes isDeleted)
         *             Do not really delete in the database.
         * */
        [TestMethod]
        public void DiscardPackage_PackageBarcode_PackageNotShown()
        {
            //NOTE: Uncomment when code ready to be tested

            Package dummyPackage = createMockPackage();
            //_agent.RegisterPackage(createMockMedication(), dummyPackage.ExpiryDate);
            //_agent.DiscardPackage(dummyPackage.BarCode);
            //PackageStatus status = _agent.getPackageStatus(dummyPackage.BarCode);
            //Assert.Equals("discarded", status.Status);
        }

        /**
         * Removing lost package
         * Need a collection of scanned barcode than delete the package that is not scanned
         * 
         * Explanation:
         *      Get all barcodes existed in the database
         *      Register a new package (the new package barcode will not be in the collection)
         *      Call RemoveLostPackageMethod
         *      The new package should be marked as lost.
         *      
         * NOTE: Audit only happen in its own Medical Centre, will not change package from other Medical Centre
         * */
        [TestMethod]
        public void RemoveLostPackage_BarcodeCollection_StatusChanged()
        {
            //NOTE: Uncomment when method ready to be tested

            //retrieving all barcodes exist in the database
            int[] barcodes = new int[5] { 1111111, 22222222, 33333333, 44444444, 5555555 }; //updated later
            Package dummyPackage = createMockPackage();
            //_agent.RegisterPackage(createMockMedication(), dummyPackage.ExpiryDate);
            //_agent.RemoveLostPackage(barcodes);
            //Assert.Equals("lost", _agent.getPackageStatus(dummyPackage.BarCode).Status);
        }
        /**
         * Addition method to create a mock object
         * */
        private Package createMockPackage()
        {
            var dummyPackage = new Moq.Mock<Package>();
            dummyPackage.SetupProperty(package => package.BarCode, 123456)
                .SetupProperty(package => package.ExpiryDate, new DateTime(17, 12, 12));
            return dummyPackage.Object;
        }
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
    }
}
