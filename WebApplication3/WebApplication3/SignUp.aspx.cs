using System;
using System.Web.UI;
using BLLayer;

namespace WebApplication3
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string FirstName=txtFirstName.Text.Trim();
                string LastName = txtLastName.Text.Trim();

                string EmailId = txtEmailid.Text.Trim();

                string UserId = txtUserId.Text.Trim();
                string Password = txtPass.Text.Trim();
                BALClass obj=new BALClass();
                if (obj.CheckSignUpDetails(EmailId,Password)) {

                    obj.AddData(FirstName, LastName, EmailId, UserId, Password);
                    Response.Write("<script>alert('Registrtion has sucessfully Done');</script>");
                    Response.Redirect("WelcomePage.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Account with given mail is already exist');</script>");

                }

            }
            
            Clear();

        }
        private void Clear()
        {
            txtFirstName.Text = string.Empty; 
            txtLastName.Text=string.Empty;
            txtEmailid.Text=string.Empty; 
            txtUserId.Text=string.Empty;
            txtPass.Text=string.Empty;
        }
    }
}