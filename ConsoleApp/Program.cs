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

            Console.WriteLine("Enter your gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter your birthDay");
            var birthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDay, weight, height);
            userController.Save();

        }
    }
}
