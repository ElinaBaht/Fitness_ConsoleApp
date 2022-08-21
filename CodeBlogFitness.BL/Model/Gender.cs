using System;


namespace Fitness.BL.Model

    ///
    /// Gender
    //
{
    public class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name">Name of gender</param>
        /// <exception cref="ArgumentNullException"></exception>

        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }

            Name = name;

        
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
