using System;


namespace ConsoleApp.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }
        public double Callories { get; }
        public double Proteins { get;  }
        public double Carbohydrates { get; }
        public double Fats { get; }
        public double Calories { get; }
       
        public Food(string name) : this(name, 0, 0, 0, 0) { }
        public Food(string name, double callories, double proteins, double fats, double carbohydrates)
        {
            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
