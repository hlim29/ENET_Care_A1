using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ENET_Care.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace ENET_Care.Tests
{
    [TestClass]
    public class DatabaseTests
    {

        [AssemblyInitialize]
        public static void SetupDataDirectory(TestContext context)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_New\App_Data\"));
        }

        [TestMethod()]
        public void Connection_OpenClose_Succeeds()
        {
            bool check = false;
            using (var l_oConnection = new ENET_Care.Data.DAO().OpenConnection())
            {
                try
                {
                    l_oConnection.Open();
                    check = true;
                    l_oConnection.Close();

                }
                catch (SqlException)
                {
                    check = false;
                }
            }

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void Retrieve_DistributionCentres()
        {
            List<DistributionCentre> centreList = new ENET_Care.Data.DAO().GetAllCentres();
            Assert.IsTrue(centreList.Count > 0);
        }
        
    }
}
