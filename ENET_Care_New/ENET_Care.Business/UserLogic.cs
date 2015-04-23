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

        public static string GetPassword()
        {
            return null;
        }

        public static string GetName()
        {
            return null;
        }

        public static string GetEmailAddress()
        {
            return null;
        }


    }
}
