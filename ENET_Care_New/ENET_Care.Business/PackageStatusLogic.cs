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

        public static void DiscardPackageStatus(int centreId, int barcode)
        {
            new PackageStatus().UpdatePackageStatusByBarcodeAndCentreId((int)StatusEnum.Discard,centreId, barcode);
        }


    }
}
