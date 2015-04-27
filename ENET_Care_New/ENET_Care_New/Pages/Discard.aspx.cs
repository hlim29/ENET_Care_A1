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

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();
            UserLogic.GetUserById(userId);
            PackageStatusLogic.DiscardPackageStatus(UserLogic.GetCentreID(), int.Parse(BarCode.Text));
        }
    }
}