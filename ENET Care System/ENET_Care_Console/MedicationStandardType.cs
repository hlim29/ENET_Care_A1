﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class MedicationStandardType
    {
        public int id {get; set;}
        public int quantity { get; set; }
        public string description { get; set; }
        public float cost { get; set; }
        public bool isTempSensitive { get; set; }
        public string shelfLife { get; set; }

    }
}
