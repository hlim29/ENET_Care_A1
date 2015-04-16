using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENET_Care.Data;
using ENET_Care.Data.DataSetTableAdapters;

namespace ENET_Care.Business
{
    public class PackageLogic
    {
        public enum Result
        {
            Ok, PastDate, NoDate, Default
        };

        public static Result ValidateInput(DateTime expiryDate, string packageName)
        {
            if (expiryDate < DateTime.Now)
                return Result.PastDate;
            else
                return Result.Ok;
        }

        public static void AddPackage(Package package){
            new Package().RegisterPackage(package);
        }

        public static List<Package> GetPackages()
        {
            List<Package> result = new List<Package>();

            /*
            using (new DAO().OpenConnection())
            {
                new PackageTableAdapter().GetData();

                DataSet.PackageDataTable packages = new PackageTableAdapter().GetData();
                foreach (DataSet.PackageRow row in packages)
                {
                    Package package = new Package();
                    package.BarCode = row.PackageId;
                    package.ExpiryDate = row.ExpiryDate;
                    package.Quantity = row.Quantity;
                    package.Medication = 
                }
                //connection.Close();

            }*/
            return result;
        }
    }
}
