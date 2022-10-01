using ConsoleApp.Controller;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FitnessApp!");

            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            var userController = new UserController(name);

            if(userController.IsNewUser)
            {
                Console.WriteLine("Enter your gender: ");
                var gender = Console.ReadLine(); 
                var weight = ParseDouble("weight");
                var height = ParseDouble("height");
                var birthDay = ParseDateTime();

                userController.SetNewUserData(gender, birthDay, weight, height);
            }
            Console.WriteLine(userController.CurrentUser);
        }
        private static DateTime ParseDateTime()
        {
            DateTime birthDay;
            while (true)
            {
                Console.WriteLine("Enter your birthday (dd.nn.yyyy):");
                if (DateTime.TryParse(Console.ReadLine(), out birthDay))
                {
                    return birthDay;
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
            }
        }
        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.WriteLine($"Enter your  {name}:");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Invalid {name} format.");
                }
            }
        }
    }
}
