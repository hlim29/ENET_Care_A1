using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ENET_Care.Data.App_Data
{
    public class ConnectionDB
    {
        public SqlConnection openConnection()
        {
            string sConnectionString = "Data Source=(LocalDB)\v11.0;Initial Catalog=C:\\USERS\\USER\\SOURCE\\REPOS\\ENET-CARE-SYSTEM2\\ENET CARE SYSTEM\\ENET_CARE_CONSOLE\\APP_DATA\\DATABASE.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            return objConn;
        }

        public void closeConnection(SqlConnection objConn)
        {
            objConn.Close();
        }
    }
}
