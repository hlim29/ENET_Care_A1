using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENET_Care.Business;

namespace ENET_Care_New.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
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
            }
        }

        protected void CalendarExpiry_SelectionChanged(object sender, EventArgs e)
        {
            txtBoxExpiry.Text = CalendarExpiry.SelectedDate.ToShortDateString();
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            PackageLogic.Result result = PackageLogic.ValidateInput(CalendarExpiry.SelectedDate, txtBoxExpiry.Text);
            System.Diagnostics.Debug.WriteLine(result.ToString());
        }

        protected void PackageTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime expiry = PackageLogic.GetExpiryDate(int.Parse(PackageTypeDropDown.SelectedValue));
            txtBoxExpiry.Text = expiry.ToShortDateString();
            //System.Diagnostics.Debug.WriteLine(PackageTypeDropDown.SelectedValue);
        }








        
    }
}