using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENET_Care.Data;

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

        public static Dictionary<int, string> GetMedicationTypes()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (MedicationStandardType medication in new Package().RetrieveAllPackageTypes())
            {
                result.Add(medication.Id, medication.Description);
            }
            return result;
        }

        public static DateTime GetExpiryDate(int barcode)
        {
            MedicationStandardType medication = new Package().GetMedication(barcode);
            DateTime result = DateTime.Now;
            result = result.AddDays(medication.ShelfLife);
            return result;
        }

    }
}
