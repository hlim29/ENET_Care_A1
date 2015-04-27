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
    public partial class DistCentreRepostIndividual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();// = GetDataset(query);
                string id = Request.QueryString["id"];
                if (id == null)
                {
                    // PrefixLabel.Text = "Error";
                }
                else
                {
                    ds = PackageLogic.GetPackagesByDistCentre(int.Parse(id));
                    StockGridView.DataSource = ds.Tables[0];
                    StockGridView.DataBind();
                    CentreNameLabel.Text = CentreLogic.GetCentreNameById(int.Parse(id));
                    // BarcodeLabel.Text = id;
                    // Generate_Barcode();
                }
            }
        }

        protected void StockGridView_Highlight(object sender, EventArgs e)
        {

        }
    }
}