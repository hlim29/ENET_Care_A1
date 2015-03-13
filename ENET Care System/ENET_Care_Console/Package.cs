using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care_Console
{
    public class Package
    {
        public int barCode;
        public string type;
        public int medicationId;
        public DateTime ExpiryDate;
        public int quantity;
        public void AddPackage()
        {

        }
        public double getNewBarcode()
        {
            return 0;
        }
        public void SelectType(string type)
        {
            this.type = type;
        }
        public void InsertExpiryDate(string expiryDate)
        {
        }
    }
}
