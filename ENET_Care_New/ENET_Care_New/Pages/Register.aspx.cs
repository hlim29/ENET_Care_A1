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








        
    }
}