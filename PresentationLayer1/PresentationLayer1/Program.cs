using BLLayer;
using PresentationLayer1;

/// <summary>
/// Starting of the application program with presentation layer
/// </summary>
public class PresentationClass
{
    public static void Main()
    {  
        //while loop with true for continuos running of application
        while (true)
        {
            Console.WriteLine("For login enter 1\nFor Sign Up enter 2\nFor exiting the application 3");
            string userInput = Console.ReadLine();

            if (userInput == "1") 
            {
                LoginInputs login=new LoginInputs();
                login.Inputs();
            }

            else if (userInput == "2")
            {
                SignUpInputs signUp=new SignUpInputs();
                signUp.Inputs();

             }

            else if (userInput == "3")
            {
                Console.WriteLine("Thank you the application has close");
                break;
            }

            else
            {
                Console.WriteLine("Please enter valid option");

            }
        }

    }
}