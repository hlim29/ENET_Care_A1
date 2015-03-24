using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care_Console;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class AgentTest
    {
        Agent _agent;

        [TestInitialize]
        public void Setup()
        {
            _agent = new Agent();
        }
        [TestMethod]
        public void RegisterPackage_InsertDataBase_PackageAdded()
        {
            try
            {
                _agent.RegisterPackage();
            }
            catch
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void SendPackage_PackageBarcode_PackageStatusChanged()
        {
            int barcode = 123456;
            var dummyPackage = new Moq.Mock<Package>();
            var dummyPackageStatus = new Moq.Mock<PackageStatus>();
            dummyPackage.SetupProperty(package => package.barCode, barcode);
            Package packageObject = dummyPackage.Object;
            dummyPackageStatus.SetupProperty(packageStatus => packageStatus.package, packageObject);
            //need to be changed later as the PackageStatus comes under Package
            
            PackageStatus packageStatusObject = dummyPackageStatus.Object;
            _agent.SendPackage(barcode);
            Assert.Equals("onTransit", packageStatusObject.status);
        }

        public void ReceivePackage_PackageBarcode_PackageStatusChanged()
        {
            int barcode = 123456;
            var dummyPackage = new Moq.Mock<Package>();
            var dummyPackageStatus = new Moq.Mock<PackageStatus>();
            dummyPackage.SetupProperty(package => package.barCode, barcode);
            Package packageObject = dummyPackage.Object;
            dummyPackageStatus.SetupProperty(packageStatus => packageStatus.package, packageObject);
            //need to be changed later as the PackageStatus comes under Package
            
            PackageStatus packageStatusObject = dummyPackageStatus.Object;
            _agent.ReceivePackage(123456);
            Assert.Equals("inStock", packageStatusObject.status);
            Assert.Equals(_agent.distributionCentre, packageStatusObject.centreSource);
        }
    }
}
