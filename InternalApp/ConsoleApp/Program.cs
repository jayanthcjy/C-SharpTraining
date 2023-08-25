using ConsoleApp;

public class Program
{
    public static void Main()
    {

        Authentication authentication = new Authentication();
        //while loop with true for continuos running of application
        while (true)
        {
            Console.WriteLine("For login enter 1\nFor Sign Up enter 2\nFor exiting the application 3");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                authentication.Login();
            }

            else if (userInput == "2")
            {
                authentication.Register();
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