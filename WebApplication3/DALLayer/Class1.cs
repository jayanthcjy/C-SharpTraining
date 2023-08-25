
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace DALLayer
{
    public class DALClass
    {
        string cs = ConfigurationManager.ConnectionStrings["Jayanth"].ConnectionString;

        public void SaveData(string query)
        {
            SqlConnection con=new SqlConnection(cs);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd =new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet IsValidUser(String EmailId, String Password)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from PersonDetails where MailId='" + EmailId + "' and Password='" + Password + "'", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            return ds;
        }
        public void ChangePasWord(string query)
        {

            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
    
}