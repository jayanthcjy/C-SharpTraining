using System;
using DALLayer;

namespace BLLayer
{
    public class BALClass
    {

        
        DALClass obj = new DALClass();

        public void ForgotPassword(string EmailId,string NewPassword)
        {
            string query = "UPDATE PersonDetails SET Password='" + NewPassword + "' WHERE MailId='" + EmailId + "' ";
            obj.ChangePasWord(query);
        }
        public void AddData(string FirstName, string LastName, string MailId, string UserId, string Password)
        {
            string Q = "INSERT INTO PersonDetails VALUES('" + FirstName + "','" + LastName + "','" + MailId + "''" + UserId + "','" + Password + "')";
            obj.SaveData(Q);

        }
        public bool CheckSignUpDetails(string MailId,string Password)
        {

            if (obj.IsValidUser(MailId,Password).Tables[0].Rows.Count == 0)
                return true;

            return false;
        }
    }
        public class User
        {
            private string _Mailid ;
            private string _Password;



            public string MailId { get => _Mailid; set => _Mailid = value; }
            public string Password { get => _Password; set => _Password = value; }
            DALClass ob = new DALClass();



            
            public bool getUser()
            {
                if (ob.IsValidUser(MailId, Password).Tables[0].Rows.Count == 0)
                    return false;
                return true;
            }
        }
    }