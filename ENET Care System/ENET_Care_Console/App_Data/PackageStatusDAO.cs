using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ENET_Care.Data.App_Data
{
    public class PackageStatusDAO
    {
        ConnectionDB conn = new ConnectionDB();
        public void insertPackageStatus(PackageStatus packageStatus)
        {
            SqlConnection objConn = conn.openConnection();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT into PackageStatus () ";
            conn.closeConnection(objConn);

        }
        public PackageStatus selectPackageStatus(String codeBar)
        {
            SqlConnection objConn = conn.openConnection();
            //insert code
            PackageStatus packageStatus = new PackageStatus();

            return packageStatus;
        }
    }

    
}
