using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            //Adding
            capitals.Add("England", "London");
            capitals.Add("USA", "Washington D.C");
            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("Germany", "Berlin");

            //Displaying
            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //for (int i = 0; i < capitals.Count; i++)
            //{
            //    Console.WriteLine(capitals.Keys.ElementAt(i));
            //}

            Console.WriteLine("-----------");

            capitals["USA"] = "New York";

            Console.WriteLine(capitals["USA"]);

            Console.WriteLine("-----------");

            Console.WriteLine(capitals.Count);

            Console.WriteLine("-----------");

            capitals.TryGetValue("England", out string result);

            Console.WriteLine("-----------");

            capitals.Remove("Canada");

            //capitals.Clear();

            capitals.ContainsKey();

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1, "Colin" },
                {2, "Kim" },
                {3, "Remi" },

            };




        }
    }
}
