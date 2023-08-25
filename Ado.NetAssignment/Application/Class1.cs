using System.Configuration;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Formats.Asn1;
using Application;

namespace Application
{
    public class Class1
    {

        string connectionString = ConfigurationManager.ConnectionStrings["Jayanth"].ConnectionString;
        public void SaveData(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet IsValidUser(String EmailId, String Password)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from PersonDetails where MailId='" + EmailId + "' and Password='" + Password + "'", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            return ds;
        }
        public void ChangePasWord(string query)
        {

            SqlConnection con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void ForgotPassword(string EmailId, string NewPassword)
        {
            Class1 obj = new Class1();
            string query = "UPDATE PersonDetails SET Password='" + NewPassword + "' WHERE MailId='" + EmailId + "' ";
            obj.ChangePasWord(query);
        }
        public void AddData(string FirstName, string LastName, string MailId, string UserId, string Password)
        {
            Class1 obj = new Class1();

            string Q = "INSERT INTO PersonDetails VALUES('" + FirstName + "','" + LastName + "','" + MailId + "','" + UserId + "','" + Password + "')";
            obj.SaveData(Q);

        }
        public bool CheckSignUpDetails(string MailId, string Password)
        {
            Class1 obj = new Class1();


            if (obj.IsValidUser(MailId, Password).Tables[0].Rows.Count == 0)
                return true;

            return false;
        }
    }
    
    }
public class User
{
    private string _Mailid;
    private string _Password;



    public string MailId { get => _Mailid; set => _Mailid = value; }
    public string Password { get => _Password; set => _Password = value; }
    Class1 ob = new Class1();




    public bool getUser()
    {
        if (ob.IsValidUser(MailId, Password).Tables[0].Rows.Count == 0)
            return false;
        return true;
    }


}