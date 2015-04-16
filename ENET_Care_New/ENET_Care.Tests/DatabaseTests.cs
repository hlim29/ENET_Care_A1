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
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_New\App_Data"));
        }
        [TestMethod()]
        public void Connection_OpenClose_Succeeds()
        {
            SqlConnection connectionTest = new ENET_Care.Data.DAO().OpenConnection();
            connectionTest.Open();
            connectionTest.Close();
        }

        [TestMethod]
        public void Create_New_DistCentre()
        {
            string centreName = "Sydney";
            string centreAddress = "George St, NSW";
            string phoneNumber = "02 9999 9999";
            SqlConnection connectionTest = new ENET_Care.Data.DAO().OpenConnection();
            //connectionTest.Open();

            string query = "INSERT INTO dbo.DistCentre  "+
                "(CentreName, CentreAddress, PhoneNumber) " +
                   "VALUES (@CentreName, @CentreAddress, @PhoneNumber) ";

            using (connectionTest)
            using (SqlCommand cmd = new SqlCommand(query, connectionTest))
            {
                // define parameters and their values
                cmd.Parameters.Add("@CentreName", SqlDbType.VarChar, 50).Value = centreName;
                cmd.Parameters.Add("@CentreAddress", SqlDbType.VarChar, 50).Value = centreAddress;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 50).Value = phoneNumber;

                // open connection, execute INSERT, close connection
                connectionTest.Open();
                cmd.ExecuteNonQuery();
                connectionTest.Close();
            }
        }

        [TestMethod]
        public void Retrieve_DistributionCentres()
        {
            List<DistributionCentre> centreList = new ENET_Care.Data.DAO().GetAllCentres();
            Assert.IsTrue(centreList.Count > 0);
        }
        
    }
}
