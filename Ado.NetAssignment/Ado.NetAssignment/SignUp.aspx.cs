using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;

namespace Ado.NetAssignment
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {

           string encriptPass=Encript(txtPass.Text);
            
            string connectionString = ConfigurationManager.ConnectionStrings["Jayanth"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO PersonDetails VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmailid.Text + "','" + txtUserId.Text + "','" + encriptPass + "')";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
                Response.Redirect("WelcomePage.aspx");
            }

            connection.Close();
        }
        
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

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
    }
}