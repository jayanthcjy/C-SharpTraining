using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLayer;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User obj = new User();
           
            obj.MailId = txtEmailid.Text;
            obj.Password = txtPass.Text;



            if (obj.getUser())
            {
                Response.Redirect("WelcomePage.aspx");
            }
            else
            {
                Response.Write("Please enter correct username and password ");
            }

            Clear();

        }
        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");

        }
        protected void BtnForgetPassword_Click(object sender, EventArgs e)
        {

            Response.Redirect("ForgetPassword.aspx");
        }
        private void Clear()
        {
            txtEmailid.Text = "";
            txtPass.Text = string.Empty;
        }
    }
}

