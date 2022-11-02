using ConsoleApp.Controller;
using ConsoleApp.Model;
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
            var eatingController = new EatingController(userController.CurrentUser);

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
            Console.WriteLine("What do you want?");
            Console.WriteLine("E - enter eating");
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.E)
            {
                var foods = EnterEating();
                eatingController.Add(foods.Food, foods.Weight);

                foreach(var item in eatingController.Eating.Foods)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value}");
                }
            }
        }
        private static (Food Food, double Weight) EnterEating()
        {
            Console.WriteLine("Enter name of product:");
            var food = Console.ReadLine();

            var calories = ParseDouble("Calories");
            var prots = ParseDouble("Proteins");
            var fats = ParseDouble("Fats");
            var carbs = ParseDouble("Carbohydrate");

            var weight = ParseDouble("weight of food");
            var product = new Food(food, calories, prots, fats, carbs);

            return (Food: product, Weight: weight);
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
