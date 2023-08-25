using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Ado.NetAssignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Jayanth"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            //connection.Open();

            
           // SqlCommand cmd = new SqlCommand(, connection);
            SqlDataAdapter adapter = new SqlDataAdapter("select UserId,Password from PersonDetails", connection);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            
            foreach(DataRow read in ds.Tables[0].Rows)
            {
                string encriptPass = Encript(read["Password"].ToString());

                if (read["UserId"].ToString() == txtUserId.Text && encriptPass == txtPass.Text)
                {
                    Response.Redirect("WelcomePage.aspx");
                    
                }

            }

                

              Response.Write("<script>alert('Wrong UserId or Password');</script>");
            


            
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
        protected static string Encript(string pass)
        {
            int key = 10;

            string encriptPass = "";

            foreach (char c in pass)
            {
                encriptPass += Convert.ToChar(Convert.ToInt32(c) ^ key);
            }
            return encriptPass;
        }
        private void Clear()
        {
            txtUserId.Text = "";
            txtPass.Text = string.Empty;
        }
    }
}