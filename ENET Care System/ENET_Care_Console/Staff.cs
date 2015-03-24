using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class Staff
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DistributionCentre distributionCentre { get; set; }

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

        public void changeEmail(string newEmail)
        {
            email = newEmail;
        }
        public bool updatePassword(string userId, string password)
        {
            return true;
        }
        public bool login(string email, string password)
        {
            return true;
        }
    }

}
