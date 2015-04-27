using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENET_Care.Data.DataSetTableAdapters;

namespace ENET_Care.Data
{
    public class MedicationStandardType
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsTempSensitive { get; set; }
        public int ShelfLife { get; set; }

        public void SetMedicationById(int medicationId)
        {
            using (new DAO().OpenConnection())
            {
                DataSet.PackageStandardTypeDataTable medication = new PackageStandardTypeTableAdapter().GetPackageStandardTypeById(medicationId);
                foreach (DataSet.PackageStandardTypeRow row in medication)
                {
                    this.Id = row.Id;
                    this.Description = row.Description;
                    this.Quantity = row.Quantity;
                    this.ShelfLife = row.ShelfLife;
                    this.IsTempSensitive = row.IsTempSensitive;
                    this.Cost = row.Cost;

                }
            }
        }

    }
}
