using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ENET_Care.Data
{
    public class DAO
    {
        public SqlConnection OpenConnection()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_New\App_Data"));
            string sConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection objConn = new SqlConnection(sConnectionString);
           // objConn.Open();
            return objConn;
        }
    }
}
