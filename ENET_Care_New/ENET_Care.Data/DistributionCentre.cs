
using ENET_Care.Data.DataSetTableAdapters;
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

        public DistributionCentre()
        {

        }
        public DistributionCentre(int Id, string Name, string Address, string PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }

        //public List<DistributionCentre> GetAllCentres()
        //{
        //    //List<DistributionCentre> result = new List<DistributionCentre>();
        //    //using (new DAO().OpenConnection())
        //    //{
        //    //    DataSet.DistCentreDataTable centres = new DistCentreTableAdapter().GetData();

        //    //    foreach (DataSet.DistCentreRow row in centres)
        //    //    {
        //    //        DistributionCentre centre = new DistributionCentre(
        //    //            row.CentreID, row.CentreName, row.CentreAddress, row.PhoneNumber
        //    //            );
        //    //        result.Add(centre);
        //    //    }
                
        //    //}
        //    //return result;
        //}

    }
}
