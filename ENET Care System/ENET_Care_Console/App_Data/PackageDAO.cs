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
            //insert code
            conn.closeConnection(objConn);
        }       
    }
}
