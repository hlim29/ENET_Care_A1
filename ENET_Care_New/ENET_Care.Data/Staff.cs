using ENET_Care.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class Staff
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DistributionCentre DistributionCentre { get; set; }

        public Staff()
        {

        }

        public void AlterInformation(string firstName, string lastName, string email, string password)
        {
            //set new values
        }

        public void CommitToDatabase()
        {
            //dummy code - update db
        }

        public void RetrieveFromDatabase()
        {
            //dummy code - get from db
        }

        public void GetCentreId(string userId)
        {
            new AspNetUsersTableAdapter().GetCentreIdByUser(userId);
        }
    }
}
