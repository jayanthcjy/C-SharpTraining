using System;
using System.Collections.Generic;
using Interface;

namespace ThreeTierArchitecture
{
    // Presentation Layer
    public class Program:IUserService
    {
        private static readonly IUserService _userService = new UserService();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Application!");

            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Logout");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        LoginUser();
                        break;
                    case "3":
                        LogoutUser();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static void RegisterUser()
        {
            Console.WriteLine("Registration");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool success = _userService.RegisterUser(username, password);

            if (success)
                Console.WriteLine("Registration successful!");
            else
                Console.WriteLine("Registration failed. Please try again.");
        }

        private static void LoginUser()
        {
            Console.WriteLine("Login");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool success = _userService.LoginUser(username, password);

            if (success)
                Console.WriteLine("Login successful!");
            else
                Console.WriteLine("Login failed. Please try again.");
        }



        private static void LogoutUser()
        {
            bool success = _userService.LogoutUser();

            if (success)
                Console.WriteLine("Logout successful!");
            else
                Console.WriteLine("Logout failed. Please try again.");
        }
    }

    // Business Layer
   
    
    }
