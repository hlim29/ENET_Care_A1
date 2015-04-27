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
    public class PackageDatbaseTest
    {


        [TestMethod]
        public void PackageDatabaseTest_InsertTable_TableAdded()
        {
            Package package = new Package();
            package.BarCode = 123455;
            package.Medication = PackageLogic.GetMedicationList().Last.Value;
            package.ExpiryDate = new DateTime(2017, 10, 10);
            package.Quantity = 100;

            PackageDAO packageDAO = new PackageDAO();
            packageDAO.insertPackage(package);

          //  int lastId = new PackageTableAdapter().GetData().Count;
         //   Assert.AreEqual(package.ExpiryDate, new PackageTableAdapter().GetData().FindByPackageId(lastId).ExpiryDate, "Expiry Date are not the same!");
         //   Assert.AreEqual(package.Quantity, new PackageTableAdapter().GetData().FindByPackageId(lastId).Quantity, "Quantity are not the same!");
        }
        [TestMethod]
        public void PackageDatabaseTest_GetPackageByBarcode_CorrectPackageAdded()
        {
            Package package = new Package();
            package.BarCode = 123456;
            package.Medication = PackageLogic.GetMedicationList().Last.Value;
            package.ExpiryDate = new DateTime(2017, 10, 10);
            package.Quantity = 100;

            PackageDAO packageDAO = new PackageDAO();
            packageDAO.insertPackage(package);

            Assert.AreEqual(package.ExpiryDate, new Package().GetPackageByBarcode(package.BarCode).BarCode);
        }
        [TestMethod]
        public void PackageDatabaseTest_RegisterPackage_PackageAdded()
        {
            Package package = new Package();
            package.BarCode = 123457;
            package.Medication = PackageLogic.GetMedicationList().Last.Value;
            package.ExpiryDate = new DateTime(2017, 10, 10);
            package.Quantity = 100;

            Package pkg = new Package();
            pkg.RegisterPackage(package);

            Assert.AreEqual(package.ExpiryDate, new PackageTableAdapter().GetData().FindByPackageId(lastId).ExpiryDate, "Expiry Date are not the same!");
            Assert.AreEqual(package.Quantity, new PackageTableAdapter().GetData().FindByPackageId(lastId).Quantity, "Quantity are not the same!");
        }

    }
}