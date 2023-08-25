namespace Validation
{
    public class ValidationClass
    {
        public bool ValidName(string name)
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
        public bool ValidPassword(string Password) {
            if (Password.Length < 8)
            {
                Console.WriteLine("The password should be of minimum length 8");
                return false;
            }
            return true;
        }

    }
}