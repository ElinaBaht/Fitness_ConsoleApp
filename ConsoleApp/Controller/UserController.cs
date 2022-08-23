using ConsoleApp.Model;
using System;


namespace ConsoleApp.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(string userName, string genderName, DateTime birthDate, double weight, double height)
        {
            User = new User(userName, genderName, birthDate, weight, height);
            
        }

        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            string path = @"D:\fitness\users.txt";
            string UserString = $"name: {User.Name}; gender: {User.Gender}; birthdate:{User.BirthDate}; weight: {User.Weight}; height: {User.Height}";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(UserString);
                Console.WriteLine("Text is added");
            }
        }

        /// <summary>
        /// To get user data
        /// </summary>

        public void Load()
        {

        }
    }
}
