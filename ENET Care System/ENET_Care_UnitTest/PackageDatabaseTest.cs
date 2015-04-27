using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.IO;
using System.Data;
using ENET_Care.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace ENET_Care.Tests
{
    [TestClass]
    public class PackageDatabaseTest
    {
        [AssemblyInitialize]
        public static void SetupDataDirectory(TestContext context)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_New\App_Data"));
        }
        [TestMethod]
        public void PackageDatabaseTest_InsertPackage_PackageTotalAdded()
        {
            Package package = new Package();
            //PackageDAO.insertPackage(package);
        }
    }
}
