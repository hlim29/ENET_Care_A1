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
               packageData.Rows[0]["Id"] = result.BarCode;
               packageData.Rows[0]["ExpiryDate"] = result.ExpiryDate;
               packageData.Rows[0]["Quantity"] = result.Quantity;
                //new PackageTableAdapter().GetDataByPackageId(BarCode);
                //new DistCentreTableAdapter().NewCentre(dc.Name, dc.Address, dc.PhoneNumber);
            }
            return result;
        }

        public void RegisterPackage(Package package)
        {
            using (new DAO().OpenConnection())
            {
                new PackageTableAdapter().RegisterPackage(package.BarCode,package.Medication.Id,package.ExpiryDate.ToString(),package.Quantity);
            }
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
                    package.Quantity = row.Quantity;
                    package.Medication = RetrieveMedication(row.PackageStandardTypeId);
                    result.Add(package);
                }

            }
            return result;
        }

        public MedicationStandardType RetrieveMedication(int id)
        {
            MedicationStandardType result = new MedicationStandardType();
            using (new DAO().OpenConnection())
            {
                DataSet.PackageStandardTypeDataTable medications = new PackageStandardTypeTableAdapter().GetPackageStandardTypeById(id);

                if (medications.Count == 1)
                {
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
                else
                {
                    throw new Exception("No medication");
                }

            }
            return result;
        }
    }
}
