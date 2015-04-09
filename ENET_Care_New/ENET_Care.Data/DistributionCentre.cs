
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class DistributionCentre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public DistributionCentre(int Id, string Name, string Address, string PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        

    }
}
