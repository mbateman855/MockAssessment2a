using System;
using System.Collections.Generic;

namespace MockAssessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters = new string[4] { "Han", "Chewy", "Yoda", "Luke" };            
            Console.WriteLine(Challenge.AddStarWarsCharacters(characters));

            Console.WriteLine();

            Dictionary<string, int> jedis = new Dictionary<string, int>();
            jedis.Add("person1", 4);
            jedis.Add("person2", 8);
            jedis.Add("person3", 6);
            jedis.Add("person4", 9);
            jedis.Add("person5", 5);
            Console.WriteLine(Challenge.DeathStarCombat(jedis));

            Console.WriteLine();

            string[] planets = new string[6] { "planet1", "planet2", "planet3", "planet4", "planet5", "planet6" };
            var convertedPlanets = Challenge.ConvertPlanets(planets);
            foreach (var planet in convertedPlanets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine();

            List<int> droids = new List<int> { 365, 268, 449, 260, 100, 233, 642, 767 };           
            Console.WriteLine(Challenge.AverageDroids(droids));

            Console.WriteLine();

            string vader1 = "5";
            string vader2 = "nope";
            Console.WriteLine(Challenge.TryToCatchDarthVader(vader1));
            Console.WriteLine(Challenge.TryToCatchDarthVader(vader2));
        }
    }
}
