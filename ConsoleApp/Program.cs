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

            Console.WriteLine("Enter your birthdate");
            var birthdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter your weight");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height");
            var height = Convert.ToDouble(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
