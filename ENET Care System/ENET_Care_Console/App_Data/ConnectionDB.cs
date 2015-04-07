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
            string sConnectionString = "Initial Catalog = Database.mdf;" + "Data Source = (localDB);" + "Integrated Security = SSPI";
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
