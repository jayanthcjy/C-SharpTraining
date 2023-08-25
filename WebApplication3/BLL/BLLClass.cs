using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using DAL;

namespace BLL
{
    public class BLLClass
    {
        public int InsertNewUser(string U_FullName, string U_Name, string U_Email, string U_Contact, string U_Password, string U_City, string U_Area_Code, int UR_id, DateTime U_CreateDate)
        {
            return new DAL_NewUserEntrys().InsertNewUser(U_FullName, U_Name, U_Email, U_Contact, U_Password, U_City, U_Area_Code, UR_id, U_CreateDate);
        }
    }
}