using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ENET_Care.Data.App_Data
{
    public class ConnectionDB
    {
        public SqlConnection openConnection()
        {
            string sConnectionString = Properties.Settings.Default.DatabaseConnectionString;
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
