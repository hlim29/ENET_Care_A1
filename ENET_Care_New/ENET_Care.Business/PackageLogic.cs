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

        public static Result ValidateInput(DateTime expiryDate)
        {
            if (expiryDate < DateTime.Now)
                return Result.PastDate;
            else
                return Result.Ok;
        }

        public static void AddPackage(Package package){
            new Package().RegisterPackage(package);
        }

        public static int RegisterPackage(DateTime expiryDate, string medicationId)
        {
            int result = -1;
            if (ValidateInput(expiryDate) == Result.Ok)
            {
                result = new Package().RegisterPackage(expiryDate, medicationId);
            }
            return result;
            //System.Diagnostics.Debug.WriteLine(ValidateInput(expiryDate, medicationId).ToString());
        }

        //public static Dictionary<int, string> GetMedicationTypes()
        //{
            //Dictionary<int, string> result = new Dictionary<int, string>();
            //foreach (MedicationStandardType medication in new Package().RetrieveAllPackageTypes())
            //{
            //    result.Add(medication.Id, medication.Description);
            //}
            //return result;
        //}

        public static LinkedList<MedicationStandardType> GetMedicationList()
        {
            LinkedList<MedicationStandardType> result = new LinkedList<MedicationStandardType>();
            //foreach (MedicationStandardType medication in new Package().RetrieveAllPackageTypes())
            //{
            //    result.AddLast(medication);
            //}
            return result;
        }

        /// <summary>
        /// Retrieves the default expiry date - the current date plus the expiry date listed on the medication
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public static DateTime GetExpiryDate(int barcode)
        {
            MedicationStandardType medication = new Package().GetMedication(barcode);
            DateTime result = DateTime.Now;
            result = result.AddDays(medication.ShelfLife);
            return result;
        }

        public static Package GetPackageByBarcode(int barcode)
        {
            return new Package().GetPackageByBarcode(barcode);
        }

    }
}
