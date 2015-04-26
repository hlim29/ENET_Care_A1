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
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DistributionCentre DistributionCentre { get; set; }
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

        public void SetUserById(string userId) 
        {
            DataSet.AspNetUsersDataTable users = new AspNetUsersTableAdapter().GetDataByUserId(userId);
            //DataSet.PackageStandardTypeDataTable medications = new PackageStandardTypeTableAdapter().GetData();
            foreach (DataSet.AspNetUsersRow row in users)
            {
                this.Email = row.Email;
                this.FirstName = row.FirstName;
                this.LastName = row.LastName;
                this.Id = row.Id;
                DistributionCentre centre = new DistributionCentre();
                centre.SetCentreById(row.CentreId);
                this.DistributionCentre = centre;
            }

        }

        public void UpdateUser()
        {
            int result = -1;
            using (new DAO().OpenConnection())
            {
                //result = (int)new AspNetUsersTableAdapter().UpdateUser(this.Id, this.FirstName, this.LastName, this.Email, this.Password,this.DistributionCentre.Id);
            }
        }
    }
}
