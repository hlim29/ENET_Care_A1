using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class PackageStatus
    {
        public int id { get; set; }
        public Package package { get; set; }
        public string status { get; set; }
        public Staff staff { get; set; }
        public DistributionCentre centreSource { get; set; }
        public DistributionCentre centreDestination { get; set; }
    }
}
