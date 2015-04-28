using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENET_Care.Data.DataSetTableAdapters;

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
            Package result = new Package();

            using (new DAO().OpenConnection())
            {
                DataSet.PackageDataTable packageData = new PackageTableAdapter().GetDataByPackageId(BarCode);
                result.BarCode = int.Parse(packageData.Rows[0]["PackageId"].ToString());
                result.ExpiryDate = DateTime.Parse(packageData.Rows[0]["ExpiryDate"].ToString());
                //result.Quantity = int.Parse(packageData.Rows[0]["Quantity"].ToString());
                //new PackageTableAdapter().GetDataByPackageId(BarCode);
                //new DistCentreTableAdapter().NewCentre(dc.Name, dc.Address, dc.PhoneNumber);
            }
            return result;
        }


        public void RegisterPackage(Package package)
        {
            int result = -1;
            using (new DAO().OpenConnection())
            {
                result = (int)new PackageTableAdapter().RegisterPackage(package.Medication.Id, package.ExpiryDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        public int RegisterPackage(DateTime expiryDate, string medicationId)
        {
            int result = -1;
            using (new DAO().OpenConnection())
            {
                result = (int)new PackageTableAdapter().RegisterPackage(int.Parse(medicationId), expiryDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            return result;
        }

        public void DeletePackage(int id)
        {

            using (new DAO().OpenConnection())
            {
                new PackageTableAdapter().DeletePackageById(id);
            }
        }

        public List<Package> RetrieveAllPackages()
        {
            List<Package> result = new List<Package>();
            using (new DAO().OpenConnection())
            {
                new PackageTableAdapter().GetData();

                DataSet.PackageDataTable packages = new PackageTableAdapter().GetData();
                foreach (DataSet.PackageRow row in packages)
                {
                    Package package = new Package();
                    package.BarCode = row.PackageId;
                    package.ExpiryDate = row.ExpiryDate;
                    package.Medication = GetMedication(row.PackageStandardTypeId);
                    result.Add(package);
                }

            }
            return result;
        }

        public MedicationStandardType GetMedication(int id)
        {
            MedicationStandardType result = new MedicationStandardType();
            using (new DAO().OpenConnection())
            {
                DataSet.PackageStandardTypeDataTable medications = new PackageStandardTypeTableAdapter().GetPackageStandardTypeById(id);
                foreach (DataSet.PackageStandardTypeRow row in medications)
                {
                    result.Id = row.Id;
                    result.IsTempSensitive = row.IsTempSensitive;
                    result.Description = row.Description;
                    result.Quantity = row.Quantity;
                    result.ShelfLife = row.ShelfLife;
                    result.Cost = row.Cost;
                }

            }
            return result;
        }

        public List<MedicationStandardType> RetrieveAllPackageTypes()
        {
            List<MedicationStandardType> result = new List<MedicationStandardType>();
            using (new DAO().OpenConnection())
            {
                DataSet.PackageStandardTypeDataTable medications = new PackageStandardTypeTableAdapter().GetData();
                foreach (DataSet.PackageStandardTypeRow row in medications)
                {
                    MedicationStandardType medication = new MedicationStandardType();
                    medication.Id = row.Id;
                    medication.IsTempSensitive = row.IsTempSensitive;
                    medication.Description = row.Description;
                    medication.Quantity = row.Quantity;
                    medication.ShelfLife = row.ShelfLife;
                    medication.Cost = row.Cost;
                    result.Add(medication);
                }
            }
            return result;
        }

        //returning an id itself because of this is the only Private Key.
        //Package table do not have barcode as properties
        public List<int> GetAllPackageByDistCentre(int centreId, int Status)
        {
            List<int> result = new List<int>();
            using (new DAO().OpenConnection())
            {
                DataSet.PackageStatusDataTable packageStatus = new PackageStatusTableAdapter().GetData();
                foreach (DataSet.PackageStatusRow row in packageStatus)
                {
                    if(row.SourceCentreID == centreId && row.Status == Status) // 1 is StatusEnum.InStock
                    {
                        result.Add(row.PackageID);
                    }
                }
            }
            return result;
        }
        public System.Data.DataSet GetPackagesByDistCentre(int centreId)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds.EnforceConstraints = false;
            using (new DAO().OpenConnection())
            {
                //try
                //{
               // new PackageStatusTableAdapter().FillPackageDataTable(ds, centreId);
              //ENET_Care.Data.DataSet.PackageStatusDataTable dataTable =  new PackageStatusTableAdapter().GetPackageDist(centreId);
                   //return new PackageTableAdapter().GetStockByDistId(centreId);
              //return dataTable;
                ds.Tables.Add( new PackageTableAdapter().GetPackagesByDestId(centreId));
                return ds;
            }
        }




    }
}
