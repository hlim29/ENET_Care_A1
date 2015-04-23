using ENET_Care.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void changeEmail(string newEmail)
        {
            Email = newEmail;
        }
        public bool updatePassword(string userId, string password)
        {
            return true;
        }

        public void CommitToDatabase()
        {
            //dummy code - update db
        }

        public void RetrieveFromDatabase()
        {
           SqlConnection dbConnection =  new DAO().OpenConnection();
           dbConnection.Open();
           dbConnection.Close();
        }

        public int GetCentreId(string userId)
        {
            DataSet.AspNetUsersDataTable users = new AspNetUsersTableAdapter().GetDataByUserId(userId);
            //DataSet.PackageStandardTypeDataTable medications = new PackageStandardTypeTableAdapter().GetData();
            foreach (DataSet.AspNetUsersRow row in users)
            {
                return row.CentreId;
            }
            return -1;
        }
    }
}
