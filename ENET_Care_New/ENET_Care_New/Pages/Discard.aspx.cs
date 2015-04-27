using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENET_Care.Business;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ENET_Care_New.Pages
{
    public partial class Discard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();
            UserLogic.GetUserById(userId);
            if (PackageStatusLogic.IsPackageInStock(int.Parse(BarCode.Text)))
            {
                PackageStatusLogic.DiscardPackageStatus(UserLogic.GetCentreID(), int.Parse(BarCode.Text),userId);
                Message.Text = "Package discarded successfully.";

            }
            else
            {
                Message.Text = "Package couldn't be discarded. It is either out of stock or doesn't exist.";
                //message package does not exist or is not in stock
            }
        }
    }
}