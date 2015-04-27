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
            buttonSend.Enabled = true;
            labelInvalidBarcode.Visible = false;
            LabelDestination.Visible = false;
            LabelSource.Visible = false;
            LabelPackageId.Visible = false;
            HyperLinkAnother.Visible = false;
        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
            int barcode = int.Parse(txtBarcode.Text);
            int destination = int.Parse(CentreDropDownList.SelectedValue);
            if (PackageStatusLogic.HasStatus(barcode))
            {
                string userId = User.Identity.GetUserId();
                PackageStatusLogic.ReceivePackage(barcode, userId);
                PackageStatusLogic.SendPackage(UserLogic.GetDistributionCentre(userId), destination, userId, barcode);

                int currentCentreId = UserLogic.GetDistributionCentre(User.Identity.GetUserId());
                string currentCentreName = CentreLogic.GetCentreNameById(currentCentreId);
                string destCentreName = CentreLogic.GetCentreNameById(destination);

                buttonSend.Enabled = false;

                LabelDestination.Visible = true;
                LabelSource.Visible = true;
                LabelPackageId.Visible = true;
                HyperLinkAnother.Visible = true;

                LabelDestination.Text = "Destination: " + destCentreName;
                LabelSource.Text = "Source: " + currentCentreName;
                LabelPackageId.Text = "Barcode: " + barcode.ToString();

            }
            else
            {
                labelInvalidBarcode.Visible = true;
                txtBarcode.Text = "";
            }


        }
    }
}