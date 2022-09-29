using System;


namespace ConsoleApp.Model
{
    /// <summary>
    /// User.
    /// </summary>

    [Serializable]
    public class User
    {
        #region Properties
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender.
        /// </summary>

        public Gender Gender { get; }

        /// <summary>
        /// BirthDate.
        /// </summary>

        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight.
        /// </summary>

        public double Weight { get; set; }

        /// <summary>
        /// Height.
        /// </summary>

        public double Height { get; set; }

        public double Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        #endregion

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="gender">Gender.</param>
        /// <param name="birthDate">BirthDate.</param>
        /// <param name="weight">Weight.</param>
        /// <param name="height">Height.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User( string name,
                    Gender gender,
                    DateTime birthDate,
                    double weight,
                    double height)
        {
            #region Сondition check
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name of user can not be empty or null", nameof(name));    
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Gender can not be null", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Impossible date of birth", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Impossible weight", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("Impossible height", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name of user can not be empty or null", nameof(name));
            }
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
