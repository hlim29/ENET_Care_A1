using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class User
    {
        public int Id { get; set; }
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
        public Staff login(string email, string password)
        {
            return null;
        }

        public void CommitToDatabase()
        {
            //dummy code - update db
        }

        public void RetrieveFromDatabase()
        {
            //dummy code - get from db
        }
    }
}
