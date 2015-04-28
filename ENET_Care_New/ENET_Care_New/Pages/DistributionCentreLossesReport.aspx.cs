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
    public partial class DistributionCentreLossesReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();// = GetDataset(query);
                ds = PackageStatusLogic.GetAllLostPackages();
                StockGridView.DataSource = ds.Tables[0];
                StockGridView.DataBind();
            }
           
            // BarcodeLabel.Text = id;
            // Generate_Barcode();
        }
    }
}