using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using ENET_Care.Data.DataSetTableAdapters;

namespace ENET_Care.Data
{
    public class DAO
    {
        public SqlConnection OpenConnection()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_New\App_Data"));
            string sConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection objConn = new SqlConnection(sConnectionString);
           // objConn.Open();
            return objConn;
        }

        public List<DistributionCentre> GetAllCentres()
        {
            List<DistributionCentre> result = new List<DistributionCentre>();

            SqlConnection connection = new DAO().OpenConnection();
            DataSet.DistCentreDataTable distCentres = new DistCentreTableAdapter().GetData();
            foreach (DataSet.DistCentreRow row in distCentres)
            {
                DistributionCentre tempCentre = new DistributionCentre(row.CentreID, row.CentreName, row.CentreAddress, row.PhoneNumber);
                result.Add(tempCentre);
            }
            connection.Close();
            return result;
        }

        public void AddDistributionCentre(DistributionCentre dc)
        {
            using (new DAO().OpenConnection())
            {
                new DistCentreTableAdapter().NewCentre(dc.Name, dc.Address, dc.PhoneNumber);
            }
        }
    }
}
