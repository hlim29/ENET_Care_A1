using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data
{
    public class Class1
    {
        public SqlConnection OpenConnection()
        {
            string sConnectionString = Properties.Settings.Default.DatabaseConnectionString;
             SqlConnection objConn = new SqlConnection(sConnectionString);
             objConn.Open();
             return objConn;
        }
    }
}
