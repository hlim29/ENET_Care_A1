using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Business;
using ENET_Care.Data;
using System.Diagnostics;

namespace ENET_Care.Tests
{
    [TestClass]
    public class PackageStatusTest
    {
        /**
         * Testing wether the PackageStatus Change for the same id
         * After Sending package
         * */
        [TestMethod]
        public void PackageStatusTest_SendPackage_StatusChanged()
        {
            int packageId = 1;
            PackageStatus oldStatus = PackageStatusLogic.getPackageStatusById(packageId);
            string staffId = "StaffId1";
            int centreIdSource = new DistributionCentre().GetAllCentres()[1].Id;
            int centreIdDestination = new DistributionCentre().GetAllCentres()[2].Id;
            PackageStatusLogic.SendPackage(centreIdSource, centreIdDestination, staffId, packageId);
            Assert.AreNotEqual(oldStatus, PackageStatusLogic.getPackageStatusById(packageId));
        }
        [TestMethod]
        public void PackageStatusTest_ReceivePackage_StaffIdChanged()
        {
            int packageId = 1;
            string staffId = "StaffId1";
            PackageStatusLogic.ReceivePackage(packageId, staffId);
            Assert.Equals(staffId, PackageStatusLogic.getPackageStatusById(packageId).Staff.Id);
        }
        [TestMethod]
        public void PackageStatusTest_RegisterArrival_CentreIdChanged()
        {
            int packageId = 1;
            int centreId = new DistributionCentre().GetAllCentres()[1].Id;
            string staffId = "StaffId1";
            PackageStatusLogic.RegisterArrival(packageId, centreId, staffId);
            //ASSUMPTION: when received. Current place saved in centre source properties.
            Assert.Equals(centreId, PackageStatusLogic.getPackageStatusById(packageId).CentreSource.Id);
        }
        [TestMethod]
        public void PackageStatusTest_DistributePackage_PackageStatusRemoved()
        {
            int packageId = 1;
            string staffId = "StaffId1";
            PackageStatusLogic.DistributePackage(packageId, staffId);
            //ASSUMPTION: when received. Current place saved in centre source properties.
            Assert.Equals(false, PackageStatusLogic.HasStatus(packageId));
        }
    }
}

