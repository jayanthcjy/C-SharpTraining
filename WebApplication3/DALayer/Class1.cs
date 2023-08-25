using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace DALayer
{
    public class DAL_NewUserEntrys
    {
        string connString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public int InsertNewUser(string U_FullName, string U_Name, string U_Email, string U_Contact, string U_Password, string U_City, string U_Area_Code, int UR_id, DateTime U_CreateDate)
        {
            var returnData = 0;
          
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_NewUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] perm = new SqlParameter[9];
                    perm[0] = new SqlParameter("@U_FullName", SqlDbType.NVarChar, 50);
                    perm[0].Value = U_FullName;
                    perm[1] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 30);
                    perm[1].Value = U_Name;
                    perm[2] = new SqlParameter("@U_Email", SqlDbType.NVarChar, 50);
                    perm[2].Value = U_Email;
                    perm[3] = new SqlParameter("@U_Contact", SqlDbType.NVarChar, 15);
                    perm[3].Value = U_Contact;
                    perm[4] = new SqlParameter("@U_Password", SqlDbType.NVarChar, 20);
                    perm[4].Value = U_Password;
                    perm[5] = new SqlParameter("@U_City", SqlDbType.NVarChar, 25);
                    perm[5].Value = U_City;
                    perm[6] = new SqlParameter("@U_Area_P_Code", SqlDbType.NVarChar, 10);
                    perm[6].Value = U_Area_Code;
                    perm[7] = new SqlParameter("@UR_id", SqlDbType.Int);
                    perm[7].Value = UR_id;
                    perm[8] = new SqlParameter("@U_CreateDate", SqlDbType.DateTime.ToString());
                    perm[8].Value = U_CreateDate;
                    cmd.Parameters.AddRange(perm);
                    con.Open();
                    returnData = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                }
            }
            return returnData;
        }
    }
}