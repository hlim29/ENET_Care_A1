using ENET_Care.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Business
{
    class PackageStatusLogic
    {
        public static void RegisterArrival(int packageId, int centreId,string staffId)
        {
            new PackageStatus().RegisterArrival(packageId, centreId, staffId);
        }
    }
}
