﻿using ENET_Care.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Data
{
    public class PackageStatus
    {
        public int Id { get; set; }
        public Package Package { get; set; }

        public StatusEnum Status { get; set; }
        public enum StatusEnum
        {
            InTransit, InStock, Lost, Received, Distributed, Discard
        };
        public Staff Staff { get; set; }
        public DistributionCentre CentreSource { get; set; }
        public DistributionCentre CentreDestination { get; set; }

        public void RegisterArrival(int packageId, int centreId, string staffId)
        {
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().RegisterArrival(packageId, centreId, (int)StatusEnum.InStock, staffId);
            }
        }

        public void ReceivePackage(int packageId, string staffId)
        {
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().ReceivePackage((int)StatusEnum.Received, staffId, packageId);

            }
        }

        public void DistributePackage(int packageId, string staffId)
        {
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().ReceivePackage((int)StatusEnum.Distributed, staffId, packageId);

            }
        }


        public int CountPackageById(int id)
        {
            using (new DAO().OpenConnection())
            {
                object count = new PackageStatusTableAdapter().CountPackagesStatus(id);
                if (count == null)
                    return 0;
                else
                    return (int)(new PackageStatusTableAdapter().CountPackagesStatus(id));
            }
        }

        public void SendPackage(int source, int destination, string staffId, int packageId)
        {
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().SendPackage(source, destination, (int)StatusEnum.InTransit, staffId, packageId);
            }
        }

        public List<Package> GetPackagesInStock()
        {
            List<Package> result = new List<Package>();
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().GetData();

                DataSet.PackageStatusDataTable packageStatus = new PackageStatusTableAdapter().GetPackagesByStatus((int)StatusEnum.InStock);
                foreach (DataSet.PackageStatusRow row in packageStatus)
                {


                    foreach (DataSet.PackageRow packageRow in new PackageTableAdapter().GetDataByPackageId(row.PackageID))
                    {
                        Package package = new Package();
                        package.BarCode = packageRow.PackageId;
                        package.ExpiryDate = packageRow.ExpiryDate;
                        package.Medication = Package.GetMedication(packageRow.PackageStandardTypeId);
                        result.Add(package);
                    }
                }

            }
            return result;
        }

        public void SetPackageByBarCode(int barcode)
        {

            using (new DAO().OpenConnection())
            {

                DataSet.PackageStatusDataTable packagesStatus = new PackageStatusTableAdapter().GetPackageStatusByBarcode(barcode);
                foreach (DataSet.PackageStatusRow row in packagesStatus)
                {
                    this.Status = (StatusEnum)row.Status;

                }

            }
        }

        public void UpdatePackageStatusByBarcodeAndCentreId(int status, string staffId, int centreId, int barcode)
        {
            int result = -1;
            using (new DAO().OpenConnection())
            {
                result = (int)new PackageStatusTableAdapter().UpdateStatusByBarcodeAndDestCentre(status, staffId, centreId, barcode);
            }
        }

        public List<Package> GetAllPackagesByStatus(int status)
        {
            List<Package> result = new List<Package>();
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().GetData();

                DataSet.PackageStatusDataTable packageStatus = new PackageStatusTableAdapter().GetAllDataByStatus(status);
                foreach (DataSet.PackageStatusRow row in packageStatus)
                {


                    foreach (DataSet.PackageRow packageRow in new PackageTableAdapter().GetDataByPackageId(row.PackageID))
                    {
                        Package package = new Package();
                        package.BarCode = packageRow.PackageId;
                        package.ExpiryDate = packageRow.ExpiryDate;
                        MedicationStandardType medication = new MedicationStandardType();
                        medication.SetMedicationById(packageRow.PackageStandardTypeId);
                        package.Medication = medication;
                        result.Add(package);
                    }
                }

            }
            return result;
        }


        public int GetInStockPackageValueTotal()
        {
            using (new DAO().OpenConnection())
            {
                return (int)(new PackageStatusTableAdapter().SumOfAllPackagesInStock((int)StatusEnum.InStock));
            }
        }

        public System.Data.DataSet GetLostPackages()
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.EnforceConstraints = false;
            using (new DAO().OpenConnection())
            {
                ds.Tables.Add(new PackageStatusTableAdapter().GetPackagesByStatus((int)StatusEnum.Lost));
                //System.Diagnostics.wr
                //System.Diagnostics.Debug.WriteLine((int)StatusEnum.Lost);
                return ds;
            }
           
        }

        public System.Data.DataSet GetInTransitPackages()
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            //ds.EnforceConstraints = false;
            using (new DAO().OpenConnection())
            {
                ds.Tables.Add(new PackageStatusTableAdapter().GetPackagesByStatus((int)StatusEnum.InTransit));
                return ds;
            }
        }
    }
}
