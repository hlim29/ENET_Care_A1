﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class Package
    {
        public int Id { get; set; }
        public string BarCode { get; set; }
        public MedicationStandardType Medication { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }

    }
}
