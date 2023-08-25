 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLayer;
using PresentationLayer1;

namespace PresentationLayer1
{
    /// <summary>
    /// In this class we take the inputs from user for login
    /// and giving the results according to the user login inputs
    /// </summary>
    public class LoginInputs
    {
        /// <summary>
        /// Taking login inputs from user
        /// </summary>
        public  void Inputs()
        {
            BALayer businnessObject = new BALayer();

            Console.WriteLine("Enter the details for login");
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            int response = businnessObject.Login(email, password);
            switch (response)
            {
                case 1:
                    Console.WriteLine("User does not exist");
                    break;
                case 2:
                    Console.WriteLine("You have Successfully Logined");
                    break;
                case 3:
                    Console.WriteLine("Enter correct password");
                    break;

            }

        }
    }    
        
        
}
