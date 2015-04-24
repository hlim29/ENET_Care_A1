using ENET_Care.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace ENET_Care_New.Pages
{
    public partial class Send : System.Web.UI.Page
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
            }
            labelInvalidBarcode.Visible = false;
        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
             int barcode = int.Parse(txtBarcode.Text);
            int destination = int.Parse(CentreDropDownList.SelectedValue);
            if (PackageStatusLogic.HasStatus(barcode))
            {
                string userId = User.Identity.GetUserId();
                PackageStatusLogic.ReceivePackage(barcode, userId);
                PackageStatusLogic.SendPackage(UserLogic.GetDistributionCentre(userId),destination,userId,barcode);
            }
            else
            {
                labelInvalidBarcode.Visible = true;
                txtBarcode.Text = "";
            }

            
        }
    }
}