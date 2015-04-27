﻿using ENET_Care.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENET_Care.Business
{
    public class CentreLogic
    {
        public static Dictionary<int, string> GetAllCentres()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (DistributionCentre centre in new DistributionCentre().GetAllCentres())
            {
                result.Add(centre.Id, centre.Name);
            }
            return result;
        }

        public static void GetCentreById(int centreId)
        {
            DistributionCentre centre = new DistributionCentre();
            centre.SetCentreById(centreId);
        }

        public static string GetCentreNameById(int centreId)
        {
            DistributionCentre centre = new DistributionCentre();
            centre.SetCentreById(centreId);
            return centre.Name;
        }

    }
}
