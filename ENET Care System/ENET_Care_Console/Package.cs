using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class Package
    {
        public int barCode { get; set; }
        public MedicationStandardType medication { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int quantity { get; set; }

    }
}
