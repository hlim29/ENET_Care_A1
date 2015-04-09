using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class PackageDAO
    {
        private DAO conn = new DAO();
        public void insertPackage(Package package)
        {
            SqlConnection objConn = conn.OpenConnection();
            objConn.Open();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Package (BarCode, MedicationID, ExpiryDate, Quantity) VALUES ("
                                + package.BarCode + ","
                                + package.Medication.Id + ", '"
                                + package.ExpiryDate + "',"
                                + package.Quantity + ")";
            System.Console.WriteLine(cmd.CommandText);
            cmd.Connection = objConn;
            cmd.ExecuteNonQuery();

            objConn.Close();
        }
    }
}
