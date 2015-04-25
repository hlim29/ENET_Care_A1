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
    public partial class MyInformation : System.Web.UI.Page
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
                CentreDropDownList.SelectedValue = UserLogic.GetCentre().name;

                OldPassword.Enabled = false;
                NewPassword.Enabled = false;
                NewPasswordConfirm.Enabled = false;

                string userId = User.Identity.GetUserId();
                UserLogic.GetUserById(userId);
                // set the informations using for example: UserLogic.GetName;
                FirstName.Text = UserLogic.GetName();
                LastName.Text = UserLogic.GetLastName();
                //OldPassword.Text = UserLogic.GetPassword();
                Email.Text = UserLogic.GetEmailAddress();
                //UserLogic.GetCentreName();
        
                //test for getName, getLastName and getEmail if works let me know and I'll implement to getDistributionCentre
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(FirstName.Text == null)
                {
                    //error message: first name empty
                }else if(LastName.Text == null)
                {
                    //error message: last name empty
                }else if (Email.Text == null)
                {
                    //error message: email empty
                }else{
                    UserLogic.SetFirstName(FirstName.Text);
                    UserLogic.SetLastName(LastName.Text);
                    UserLogic.SetEmail(Email.Text);
                }
            }
        }
    }
}