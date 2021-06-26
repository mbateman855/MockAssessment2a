using System;
using System.Collections.Generic;

namespace MockAssessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters = new string[4] { "Han Solo", "Chewbacca", "Yoda", "Luke Skywalker" };            
            Console.WriteLine(Challenge.AddStarWarsCharacters(characters));

            Console.WriteLine();

            Dictionary<string, int> jedis = new Dictionary<string, int>();
            jedis.Add("person1", 4);
            jedis.Add("person2", 8);
            jedis.Add("person3", 6);
            jedis.Add("person4", 9);
            jedis.Add("person5", 5);
            Console.WriteLine(Challenge.DeathStarCombat(jedis));

            //I absolutely googled planet names because there's no way i can remember more than like two
            //I didn't look up jedis though because I would just go down a rabbit hole trying to figure out who is more powerful

            Console.WriteLine();

            string[] planets = new string[6] { "Tatooine", "Mustafar", "Hoth", "Naboo", "Dathomir", "Coruscant" };
            var convertedPlanets = Challenge.ConvertPlanets(planets);
            foreach (var planet in convertedPlanets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine();

            List<int> droids = new List<int> { 365, 268, 449, 260, 100, 233, 642, 767 };           
            Console.WriteLine(Challenge.AverageDroids(droids));

            //I had thought droids had model numbers with combinations of letters and numbers only so i just made up test numbers

            Console.WriteLine();

            //I know this won't be graded on star wars accuracy but i tried where i could

            string vader1 = "5";
            string vader2 = "nope";
            Console.WriteLine(Challenge.TryToCatchDarthVader(vader1));
            Console.WriteLine(Challenge.TryToCatchDarthVader(vader2));
        }
    }
}
