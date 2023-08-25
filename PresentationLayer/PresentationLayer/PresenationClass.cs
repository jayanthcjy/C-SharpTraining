using System;
using System.Linq.Expressions;
using BLLayer;


namespace PresentationLayer
{
    public class Presentation
    {
        public static void Main()
        {
            Console.WriteLine("For login enter 1\nFor Sign Up enter 2");
            string userInput = Console.ReadLine();

            UserDetails user = new UserDetails();
            switch (userInput)
            {
                case "1":

                    user.FetchData();

                    break;
                case "2":
                    user.InsertData();
                    break;
                default:
                    Console.WriteLine("Please enter valid input");
                    break;
            }




        }

    }

}
