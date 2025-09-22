using System;

namespace Module3Assignment
{
    // animal personality
    public enum Temperament { Relaxed, Spirited, Aggressive, Curious }

    // animal health status
    public enum HealthStatus { Excellent, Good, Fair, Poor }

    public class Animal
    {
        // private readonly so they can only be set once in constructor
        private readonly string Name;
        private readonly string AnimalID;

        // public properties for other info
        public Temperament Personality { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public double WeightPounds { get; set; }
        public HealthStatus Health { get; set; }
        public string Habitat { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }

        // constructor to set everything
        public Animal(string name, string animalID, Temperament personality,
                      int heightFeet, int heightInches, double weightPounds,
                      HealthStatus health, string habitat,
                      DateTime contractStart, DateTime contractEnd)
        {
            Name = name;
            AnimalID = animalID;
            Personality = personality;
            HeightFeet = heightFeet;
            HeightInches = heightInches;
            WeightPounds = weightPounds;
            Health = health;
            Habitat = habitat;
            ContractStart = contractStart;
            ContractEnd = contractEnd;
        }

        // method to print info (using Console.WriteLine to keep it simple)
        public void PrintInfo()
        {
            Console.WriteLine(Name + " (ID: " + AnimalID + ")");
            Console.WriteLine("Temperament: " + Personality);
            Console.WriteLine("Height: " + HeightFeet + " feet " + HeightInches + " inches");
            Console.WriteLine("Weight: " + WeightPounds + " lbs");
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Habitat: " + Habitat);
            Console.WriteLine("Contract: " + ContractStart.ToShortDateString() + " - " + ContractEnd.ToShortDateString());
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // making animals
            var bugatti = new Animal("Bugatti", "CHN-2020-5", Temperament.Relaxed,
                                     5, 0, 199.5, HealthStatus.Excellent, "San Diego Zoo",
                                     new DateTime(2020, 6, 1), new DateTime(2025, 6, 1));

            var braun = new Animal("Braun", "CHN-2019-3", Temperament.Spirited,
                                   3, 2, 15.0, HealthStatus.Good, "North Carolina Zoo",
                                   new DateTime(2019, 4, 15), new DateTime(2022, 4, 15));

            var tucker = new Animal("Tucker", "CHN-2021-2", Temperament.Curious,
                                    4, 3, 176.8, HealthStatus.Fair, "San Francisco Zoo",
                                    new DateTime(2021, 9, 10), new DateTime(2023, 9, 10));

            // printing them
            Console.WriteLine("Panda Loan Registry:");
            Console.WriteLine("----------------");
            bugatti.PrintInfo();
            braun.PrintInfo();
            tucker.PrintInfo();
        }
    }
}
