using BLLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace PresentationLayer1
{
    /// <summary>
    /// In this class we take the inputs from user for sign up
    /// and checking whether the user is giving valid inputs are not
    /// </summary>
    public  class SignUpInputs
    {
            /// <summary>
            /// Taking inputs from user for sign up
            /// </summary>
            public void Inputs()
            {
            BALayer businessObject = new BALayer();

            Console.WriteLine("For creating the account enter the following details");
            Console.WriteLine("Enter the Name");
            bool valid = false;
            string newName;
            while (true)
            {

                newName = Console.ReadLine();
                ValidationClass validate = new ValidationClass();

                valid = validate.IsValidName(newName);
                if (valid == true)
                {
                    break;
                }
            }

            Console.WriteLine("Enter the mail");
            string newEmail = Console.ReadLine();
            Console.WriteLine("Enter the password");
            valid = false;
            string newPassword;
            while (true)
            {

                newPassword = Console.ReadLine();
                ValidationClass validate = new ValidationClass();

                valid = validate.IsValidPassword(newPassword);
                if (valid == true)
                {
                    break;
                }
            }

            if (businessObject.SignUp(newName, newEmail, newPassword))
            {
                Console.WriteLine("Your account has created");
            }
            else
            {
                Console.WriteLine("User already exist");
            }

        }

    }
           
 }

