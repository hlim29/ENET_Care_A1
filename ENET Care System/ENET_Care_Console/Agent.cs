using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class Agent
    {
        public Agent()
        {
            //dummy constructor
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public int DistributionCentreID { get; set; }
        

        public void CommitToDatabase()
        {
            //dummy code - update db
        }

        public void RetrieveFromDatabase()
        {
            //dummy code - get from db
        }

        public void ChangeEmail(string newEmail)
        {
            Email = newEmail;
        }
        private bool Login() { return true; }

        public bool UpdatePassword(String userId, String password)
        {
            return true;
        }
    }
}
