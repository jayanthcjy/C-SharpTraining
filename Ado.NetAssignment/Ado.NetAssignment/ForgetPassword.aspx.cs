using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.DynamicData;
using System.Data;

namespace Ado.NetAssignment
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Jayanth"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
                    
            //SqlCommand cmd=new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from PersonDetails", connection);
            SqlCommandBuilder cb=new SqlCommandBuilder(adapter);

            DataSet ds=new DataSet();

            adapter.Fill(ds);

             string encriptPass=Encript(txtNewPass.Text);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["UserId"].ToString() == txtUserId.Text) {
                    row["Password"]= encriptPass;
                    adapter.Update(ds);
                    Response.Redirect("Login.aspx");
                    break;
                }
            }
                                 
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
