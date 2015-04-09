﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ENET_Care.Data
{
    public class PackageStatusDAO
    {
        DAO conn = new DAO();
        public void insertPackageStatus(PackageStatus packageStatus)
        {
            SqlConnection objConn = conn.OpenConnection();

            objConn.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT PackageStatus (PackageId, Status, CentreSource, CentreDestination) VALUES ("
                                + packageStatus.Package.BarCode + ", '"
                                + packageStatus.Status + "',"
                                + packageStatus.CentreSource.Id + ","
                                + packageStatus.CentreDestination.Id + ")";
            cmd.Connection = objConn;
            cmd.ExecuteNonQuery();

            objConn.Close();

        }
        public PackageStatus selectPackageStatus(String codeBar)
        {
            SqlConnection objConn = conn.OpenConnection();
            //insert code
            objConn.Open();
            PackageStatus packageStatus = new PackageStatus();
            objConn.Close();
            return packageStatus;
        }
    }


}