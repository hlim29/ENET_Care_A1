﻿using ENET_Care.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
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
            InTransit, InStock, Lost
        };
        public Staff Staff { get; set; }
        public DistributionCentre CentreSource { get; set; }
        public DistributionCentre CentreDestination { get; set; }

        public void RegisterArrival(int packageId, int centreId,string staffId)
        {
            using (new DAO().OpenConnection())
            {
                new PackageStatusTableAdapter().RegisterArrival(packageId,centreId,(int)StatusEnum.InStock,staffId);
            }
        }
    }
}