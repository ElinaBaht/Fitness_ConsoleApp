using System;


namespace ConsoleApp.Model
{
    /// <summary>
    /// Gender.
    /// </summary>

    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name">Name of gender.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender can not be enpty or null",nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
