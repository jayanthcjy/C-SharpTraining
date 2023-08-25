using BusinessModels;
using DataLayer;

namespace BusinessLayer
{
    public class BALAuthentication
    {
        /// <summary>
        /// Taking login details from user and sending to the data class 
        /// whether the user exist or not , incorreect password
        /// </summary>            
        public int Login(User userDetails)
        {            
            DALAuthentication dataObject = new DALAuthentication();
            int response = dataObject.FetchData(userDetails);
            return response;
        }

        /// <summary>
        /// Checking whter the user is alredy present or not 
        /// and if the user is not present with given mail then he can create the account
        /// </summary>
        public bool Register(User userDetails)
        {                       
            DALAuthentication dataObject = new DALAuthentication();

            if (IsUserExist(userDetails.Mail) == false)
            {
                dataObject.SaveData(userDetails);
                return true;
            }
            return false;

        }

        /// <summary>
        /// This method return bool type that whether user is present or not in database
        /// </summary>
        public bool IsUserExist(string email)
        {
            for (int i = 0; i < DataSource.storage.Count; i++)
            {
                if (DataSource.storage[i][1] == email)
                {
                    return true;
                }
            }
            return false;
        }

    }
}