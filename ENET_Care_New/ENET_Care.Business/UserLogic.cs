using ENET_Care.Data;
//using ENET_Care.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Business
{
    public class UserLogic
    {
        private static User user;
        public static void GetCentreId(string userId)
        {
            //new AspNetUsersTableAdapter().GetCentreIdByUser(userId);
            
        }

        public static void EditName(string id, string name)
        {

        }

        public static int GetDistributionCentre(string userId)
        {
            return new User().GetCentreId(userId);
        }

        public static void GetUserById(string userId)
        {
            user = new User();
            user.SetUserById(userId);
            
        }

        public static string GetPassword()
        {
            return user.Password;
        }

        public static string GetName()
        {
            return user.FirstName;
        }

        public static string GetLastName()
        {
            return user.LastName;
        }

        public static string GetEmailAddress()
        {
            return user.Email;
        }



        /**
         * Auto generated method by test cases
         * */
        public static void EditPassword(string id, string newPassword)
        {
            throw new NotImplementedException();
        }

        public static void EditEmailAddress(string id, string newEmailAddress)
        {
            throw new NotImplementedException();
        }

        public static void EditDistributionCentre(string id, string newDistributionCentre)
        {
            throw new NotImplementedException();
        }
    }
}
