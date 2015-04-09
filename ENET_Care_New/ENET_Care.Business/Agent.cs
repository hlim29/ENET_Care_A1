using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENET_Care.Data;

namespace ENET_Care.Business
{
    public class Agent : Staff
    {
        public Agent()
        {
            //dummy constructor

        }

        public void RegisterPackage(Package pkg)
        {
            PackageStatus pkgStatus = new PackageStatus();
            PackageDAO pkgDao = new PackageDAO();
            PackageStatusDAO pkgStatusDao = new PackageStatusDAO();

            pkgStatus.Status = "InStock";
            pkgStatus.CentreSource = this.DistributionCentre;
            pkgStatus.CentreDestination = null;

            pkgDao.insertPackage(pkg);
            pkgStatusDao.insertPackageStatus(pkgStatus);
        }

        public void SendPackage(int packageBarcode)
        {

        }

        public void ReceivePackage(int packageBarcode)
        {

        }

        public void ViewStocktaking()
        {

        }

        public void DiscardPackage()
        {

        }

        public void RemoveLostPackage()
        {

        }

        public PackageStatus GetPackageStatus(string barCode)
        {
            PackageStatus packageStatus = new PackageStatus();

            return packageStatus;
        }
    }
}
