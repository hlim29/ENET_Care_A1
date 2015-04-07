using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ENET_Care.Data.App_Data
{
    public class PackageDAO
    {
        ConnectionDB conn = new ConnectionDB();
        public void insertPackage(Package package)
        {
            SqlConnection objConn =  conn.openConnection();
            
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Package (BarCode, MedicationID, ExpireDate, Quantity) VALUES (" + package.BarCode + "," + package.Medication.Id + "," + package.ExpiryDate + "," + package.Quantity + ")";
            cmd.ExecuteNonQuery();

            conn.closeConnection(objConn);
        }       
    }
}
