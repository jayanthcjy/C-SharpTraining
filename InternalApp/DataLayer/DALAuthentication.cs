using BusinessModels;

namespace DataLayer
{
    public class DALAuthentication
    {
        /// <summary>
        /// Saving the new user data in the database
        /// </summary>
        public void SaveData(User user)
        {
            DataSource.storage.Add(new List<string> { user.Name, user.Mail, user.Password });
        }

        /// <summary>
        /// Checking the user details for login
        /// </summary>
        public int FetchData(User user)
        {
            if (DataSource.storage.Count > 0)
            {
                for (int i = 0; i < DataSource.storage.Count; i++)
                {
                    if (!DataSource.storage[i].Contains(user.Mail))
                    {
                        return 1;
                    }
                    else if (DataSource.storage[i][1] == (user.Mail) && DataSource.storage[i][2] == (user.Password))
                    {
                        return 2;
                    }
                    else if (DataSource.storage[i][1] == user.Mail && !(DataSource.storage[i][2] == user.Password))
                    {
                        return 3;
                    }
                }
            }
            return 1;
        }
    }
}