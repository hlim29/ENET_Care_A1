using ENET_Care.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Business
{
    public class PackageStatusLogic
    {
        public enum StatusEnum
        {
            InTransit, InStock, Lost, Received, Distributed, Discard
        };
        public static void RegisterArrival(int packageId, int centreId,string staffId)
        {
            new PackageStatus().RegisterArrival(packageId, centreId, staffId);
        }

        public static void ReceivePackage(int packageId, string staffId)
        {

            new PackageStatus().ReceivePackage(packageId,  staffId);
        }

        public static void DistributePackage(int packageId, string staffId)
        {

            new PackageStatus().DistributePackage(packageId, staffId);
        }

        public static bool HasStatus(int packageId)
        {
            return (new PackageStatus().CountPackageById(packageId) == 1);
        }

        public static void SendPackage(int source, int destination, string staffId, int packageId)
        {
            new PackageStatus().SendPackage(source, destination, staffId, packageId);
        }

        //Auto-Generated Method
        public static PackageStatus getPackageStatusById(int packageId)
        {
            throw new NotImplementedException();
        }

        public static void DiscardPackageStatus(int centreId, int barcode, string staffId)
        {
            new PackageStatus().UpdatePackageStatusByBarcodeAndCentreId((int)StatusEnum.Discard, staffId,centreId, barcode);
         
        }

        public static bool IsPackageInStock(int barcode)
        {
            PackageStatus pS = new PackageStatus();
            pS.SetPackageByBarCode(barcode);
            if ((int)pS.Status == (int)StatusEnum.InStock || (int)pS.Status == (int)StatusEnum.Received)
            {
                return true;
            }
            return false;
        }

        public static Dictionary<int, string> GetAllPackgesLost()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (Package packages in new PackageStatus().GetAllPackagesByStatus((int)StatusEnum.Lost))
            {
                result.Add(packages.BarCode, packages.BarCode+" - "+packages.Medication.Description);
            }
            return result;
        }

        public static System.Data.DataSet GetAllLostPackages()
        {
            return new PackageStatus().GetLostPackages();
        }

        public static System.Data.DataSet GetInTransitPackages()
        {
            return new PackageStatus().GetInTransitPackages();
        }

    }
}
