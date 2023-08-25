using DALayer;

namespace BLLayer
{
    public class BALayer
    {
        /// <summary>
        /// Taking login details from user and sending to the data class 
        /// whether the user exist or not , incorreect password
        /// </summary>            
        public int Login(string email, string password)
        {
            DALayerClass dataObject = new DALayerClass();
            int response = dataObject.FetchData(email, password);
            return response;
        }

        /// <summary>
        /// Checking whter the user is alredy present or not 
        /// and if the user is not present with given mail then he can create the account
        /// </summary>
        public bool SignUp(string newName, string newEmail, string newPassword)
        {
            DALayerClass dataObject = new DALayerClass();


            if (IsUserExist(newEmail) == false)
            {
                dataObject.SaveData(newName, newEmail, newPassword);
                return true;
            }
            return false;

        }

        /// <summary>
        /// This method return bool type that whether user is present or not in database
        /// </summary>
        public bool IsUserExist(string email)
        {
            for (int i = 0; i < DALayerClass.storage.Count; i++)
            {
                if (DALayerClass.storage[i][1] == email)
                {
                    return true;
                }
            }
            return false;
        }


    }



}