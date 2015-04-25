using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENET_Care.Business;

namespace ENET_Care_New.Pages
{
    public partial class DistributionCentreStockReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<int, string> data = PackageLogic.GetMedicationTypes();
                PackageTypeDropDown.DataSource = data;
                PackageTypeDropDown.DataTextField = "Value";
                PackageTypeDropDown.DataValueField = "Key";
                PackageTypeDropDown.DataBind();

               // Dictionary<int, string> data = 
            }
        }
    }
}