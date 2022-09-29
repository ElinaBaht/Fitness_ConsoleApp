using ConsoleApp.Model;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp.Controller
{
    /// <summary>
    /// User controller.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// App user.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Creating a new user controller.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>

        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
            
        }
        /// <summary>
        /// To save user data.
        /// </summary>
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// To get user data.
        /// </summary>
        /// <returns>App user</returns>
        /// <exception cref="FileLoadException"></exception>
        public UserController()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                // TODO: What to do, if the user is not read
                
                
            }
        }

        
    }
}
