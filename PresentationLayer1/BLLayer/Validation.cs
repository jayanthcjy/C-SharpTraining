namespace Validation
{
    public class ValidationClass
    {
        /// <summary>
        /// Checking that the name should not cotain the numerics
        /// </summary>        
        public bool IsValidName(string name)
        {
           
           
                foreach (char c in name)
                {
                    if ((c >= '0' && c <= '9') )
                    {
                    Console.WriteLine("Enter name should contain only aplhabets");

                    return false;
                    }
                   
                }
            return true;

        }

        /// <summary>
        /// Checking wether the password length is grater than or equa to 8
        /// </summary>        
        public bool IsValidPassword(string password) {
            if (password.Length < 8)
            {
                Console.WriteLine("The password should be of minimum length 8");
                return false;
            }
            return true;
        }

    }
}