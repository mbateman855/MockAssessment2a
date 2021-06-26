using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MockAssessment2a
{
    class Challenge
    {

        public Challenge()
        {
        }
        public static int AddStarWarsCharacters(string[] characters)
        {
            int i = -1;
            int index = -1;
            foreach (string character in characters)
            {
                i++;
                if (character == "Yoda")
                {
                    index = i;
                }
            }
            return index;
        }
        public static string DeathStarCombat(Dictionary<string, int> jedis)
        {
            var strongestAttack = jedis.OrderByDescending(jedis => jedis.Value).First();
            return strongestAttack.Key;
        }
        public static List<string> ConvertPlanets(string[] planets)
        {
            List<string> planestList = new List<string>();
            foreach (string planet in planets)
            {
                planestList.Insert(0, planet);
            }
            return planestList;
        }
        public static int AverageDroids(List<int> droids)
        {
            List<int> evenDroids = new List<int>();
            foreach (int droid in droids)
            {
                if ((droid % 2) == 0)
                {
                    evenDroids.Add(droid);
                }
            }

            int average = 0;
            foreach (int droid in evenDroids)
            {
                average += droid;
            }

            average /= evenDroids.Count;
            return average;
        }
        public static string TryToCatchDarthVader(string input)
        {
            try
            {
                int vaderCheck = int.Parse(input);
                return "Vader was Captured!";
            }
            catch (FormatException)
            {
                return "Vader got away!";
            }
        }
    }
}
