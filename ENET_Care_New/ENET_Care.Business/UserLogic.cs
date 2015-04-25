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
        public static DistributionCentre GetCentreId()
        {
            return user.DistributionCentre;
            //new AspNetUsersTableAdapter().GetCentreIdByUser(userId);
            
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

        public static void SetFirstName(string firstName)
        {
            user.FirstName = firstName;
        }

        public static void SetLastName(string lastName)
        {
            user.LastName = lastName;
        }

        public static void SetEmail(string email)
        {
            user.Email = email;
        }

        public static void SetPassword(string password)
        {
            user.Password = password;
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

        public static void EditName(string id, string name)
        {

        }
    }
}
