using BLLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string MailId=txtEmailid.Text.Trim();
            string NewPassword=txtNewPass.Text.Trim();
            string ConfrimPassword=txtConfirmPassword.Text.Trim();
            if(NewPassword==ConfrimPassword)
            {
                BALClass obj = new BALClass();
                obj.ForgotPassword(MailId, NewPassword);
                Response.Redirect("WelcomePage.aspx");
            }
            else {

                Response.Write("<script>alert('New Password and Confrim Password are not same');</script>");

            }



            //Response.Redirect("WelcomePage.aspx");

        }
    }
}