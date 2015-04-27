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
                Dictionary<int, string> data = CentreLogic.GetAllCentres();
                CentreDropDownList.DataSource = data;
                CentreDropDownList.DataTextField = "Value";
                CentreDropDownList.DataValueField = "Key";
                CentreDropDownList.DataBind();
               // CentreDropDownList.SelectedValue = UserLogic.GetCentreName();
            }
            //if (!IsPostBack)
            //{
            //    Dictionary<int, string> data = PackageLogic.GetMedicationTypes();
            //    PackageTypeDropDown.DataSource = data;
            //    PackageTypeDropDown.DataTextField = "Value";
            //    PackageTypeDropDown.DataValueField = "Key";
            //    PackageTypeDropDown.DataBind();

            //   // Dictionary<int, string> data = 
            //}
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            //string userId = User.Identity.GetUserId();
            //PackageStatusLogic.RegisterArrival(result, UserLogic.GetDistributionCentre(userId), userId);
            int currentCentre = int.Parse(CentreDropDownList.SelectedValue);
            Response.Redirect("DistCentreReportIndividual.aspx?id=" + currentCentre);
        }
    }
}