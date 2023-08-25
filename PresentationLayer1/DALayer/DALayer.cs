namespace DALayer
    
{
    /// <summary>
    /// In this class we add data and search operations to the data List
    /// </summary>
    public class DALayerClass
    {

        public static List<List<string>> storage= new List<List<string>>();

        /// <summary>
        /// Saving the new user data in the database
        /// </summary>
        public void SaveData(string name,string email,string password)
        {

            storage.Add(new List<string> { name,email,password});

        }

       
        /// <summary>
        /// Checking the user details for login
        /// </summary>
        public int FetchData(string email,string password)
        {
            if (storage.Count > 0)
            {

                for (int i = 0; i < storage.Count; i++)
                {
                    if (!storage[i].Contains(email))
                    {
                        return 1;

                    }
                    else if (storage[i][1]==(email) && storage[i][2]==(password))
                    {
                        return 2;

                    }
                    else if (storage[i].Contains(email) && !storage[i].Contains(password))
                    {
                        return 3;


                    }

                }
            }
            return 1;

        }

    }
}