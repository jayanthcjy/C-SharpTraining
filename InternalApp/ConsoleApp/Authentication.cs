using BusinessLayer;
using BusinessModels;
namespace ConsoleApp
{
    public class Authentication
    {
        /// <summary>
        /// Taking login inputs from user
        /// </summary>
        public void Login()
        {
            BALAuthentication businness = new BALAuthentication();

            Console.WriteLine(Literals.enterLoginDetailsMsg);
            Console.WriteLine(Literals.enterMailMsg);
            User userObj = new User();

            userObj.Mail  = Console.ReadLine();
            Console.WriteLine(Literals.enterPasswordMsg);
            userObj.Password = Console.ReadLine();
            int response = businness.Login(userObj);

            switch (response)
            {
                case 1:
                    Console.WriteLine(Literals.userNotExistMsg);
                    break;
                case 2:
                    Console.WriteLine(Literals.loginSuccessfullyMsg);
                    break;
                case 3:
                    Console.WriteLine(Literals.enterCorrectPasswordMsg);
                    break;
            }
        }

        /// <summary>
        /// Taking inputs from user for sign up
        /// </summary>
        public void Register()
        {
            BALAuthentication businness = new BALAuthentication();

            Console.WriteLine("For creating the account enter the following details");
            Console.WriteLine("Enter the Name");
            User userObj = new User();

            bool valid = false;
            while (true)
            {
                userObj.Name = Console.ReadLine();
                BALValidation validate = new BALValidation();

                valid = validate.IsValidName(userObj.Name);
                if (valid)
                {
                    break;
                }
            }

            Console.WriteLine(Literals.enterMailMsg);
            userObj.Mail = Console.ReadLine();
            Console.WriteLine(Literals.enterPasswordMsg);
            valid = false;
            string newPassword;
            while (true)
            {
                newPassword = Console.ReadLine();
                BALValidation validate = new BALValidation();

                valid = validate.IsValidPassword(newPassword);
                if (valid == true)
                {
                    break;
                }
            }

            if (businness.Register(userObj))
            {
                Console.WriteLine(Literals.registedSuccessfullyMsg);
            }
            else
            {
                Console.WriteLine(Literals.userExistMsg);
            }

        }

    }
}
