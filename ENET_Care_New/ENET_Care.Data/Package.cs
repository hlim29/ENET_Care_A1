using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ENET_Care.Data
{
    public class Package
    {
        public int BarCode { get; set; }
        public MedicationStandardType Medication { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }

        public Package GetPackageByBarcode(int BarCode)
        {
            //SqlConnection dbConnection = new DAO().OpenConnection();
            return null;
        }
    }
}
