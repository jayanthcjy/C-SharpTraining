using System;
using DALayer;

namespace BLLayer
{
    public class UserDetails
    {
        public void FetchData()
        {
            Console.WriteLine("Enter the following details");
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

        }
        public void InsertData()
        {
            Console.WriteLine("For creating the account enter the following details");
            Console.WriteLine("Enter the Name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter the mail");
            string newEmail = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string newPassword = Console.ReadLine();

        }


    }
}