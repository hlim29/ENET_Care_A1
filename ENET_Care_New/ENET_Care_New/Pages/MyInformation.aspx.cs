﻿using ENET_Care.Business;
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
                string userId = User.Identity.GetUserId();
                UserLogic.GetUserById(userId);

                Dictionary<int, string> data = CentreLogic.GetAllCentres();
                CentreDropDownList.DataSource = data;
                CentreDropDownList.DataTextField = "Value";
                CentreDropDownList.DataValueField = "Key";
                CentreDropDownList.DataBind();
                //CentreDropDownList.SelectedValue = UserLogic.GetCentreName();
                OldPassword.Text = UserLogic.GetCentreName();

                OldPassword.Enabled = false;
                NewPassword.Enabled = false;
                NewPasswordConfirm.Enabled = false;

                
                // set the informations using for example: UserLogic.GetName;
                FirstName.Text = UserLogic.GetName();
                LastName.Text = UserLogic.GetLastName();
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
                }else
                {
                    if (OldPassword.Enabled == true)
                    {
                        if(OldPassword.Text == UserLogic.GetPassword())
                        {
                            if(NewPassword.Text == NewPasswordConfirm.Text)
                            {
                                UserLogic.SetFirstName(FirstName.Text);
                                UserLogic.SetLastName(LastName.Text);
                                UserLogic.SetEmail(Email.Text);
                                UserLogic.SetPassword(NewPassword.Text);
                            }
                            else
                            {
                                //error message: new password does not match
                            }
                        }
                        else
                        {
                            //error message: old password incorrect
                        }
                    }
                    else
                    {
                        UserLogic.SetFirstName(FirstName.Text);
                        UserLogic.SetLastName(LastName.Text);
                        UserLogic.SetEmail(Email.Text);
                    }
                    
                }
            }
        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            OldPassword.Enabled = true;
            NewPassword.Enabled = true;
            NewPasswordConfirm.Enabled = true;
        }
    }
}