using ENET_Care.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENET_Care_New.Pages
{
    public partial class ValueInTransit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = PackageStatusLogic.GetInTransitPackages();
            StockGridView.DataSource = ds.Tables[0];
            StockGridView.DataBind();
           // CentreNameLabel.Text = CentreLogic.GetCentreNameById(int.Parse(id));
        }
    }
}