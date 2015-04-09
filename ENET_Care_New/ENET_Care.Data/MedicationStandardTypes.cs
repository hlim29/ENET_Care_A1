using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class MedicationStandardType
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public bool IsTempSensitive { get; set; }
        public string ShelfLife { get; set; }
    }
}
