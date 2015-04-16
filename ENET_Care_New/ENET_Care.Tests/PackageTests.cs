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
            PackageLogic.Result result = PackageLogic.ValidateInput(pastDate, "Test package");
            Assert.AreEqual(PackageLogic.Result.PastDate, result);
        }

        [TestMethod]
        public void PackageText_RetrieveAllPackages()
        {
            //Debug.WriteLine(new Package().RetrieveAllPackages().Count);
            Assert.AreNotEqual(0,new Package().RetrieveAllPackages().Count);

        }
    }
}
