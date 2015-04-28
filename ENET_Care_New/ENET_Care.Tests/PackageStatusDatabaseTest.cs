using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ENET_Care.Data;
using ENET_Care.Business;
using System.Collections.Generic;
using System.Diagnostics;
using ENET_Care.Data.DataSetTableAdapters;
namespace ENET_Care.Tests
{
    [TestClass]
    public class PackageStatusDatabaseTest
    {
        [TestMethod]
        public void PackageStatusDatabaseTest_RegisterArrival_SourceDistributionCentreChanged()
        {
            int packageId = 1;
            PackageStatus oldStatus = PackageStatusLogic.getPackageStatusById(packageId);
            string staffId = "StaffId1";
            int centreId = new DistributionCentre().GetAllCentres()[1].Id;
            new PackageStatus().RegisterArrival(packageId, centreId, staffId);

            Assert.Equals(centreId, new PackageStatusTableAdapter().GetData().FindByPackageStatusID(packageId).SourceCentreID);
        }
    }
}
