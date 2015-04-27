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
    public partial class Distribute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelInvalidBarcode.Visible = false;
            txtBarcode.Focus();
        }

        protected void DistributeButton_Click(object sender, EventArgs e)
        {
            int barcode = int.Parse(txtBarcode.Text);
            if (PackageStatusLogic.HasStatus(barcode))
            {
                string userId = User.Identity.GetUserId();
                PackageStatusLogic.DistributePackage(barcode, userId);
            }
            else
            {
                labelInvalidBarcode.Visible = true;
                txtBarcode.Text = "";
            }
        }
    }
}