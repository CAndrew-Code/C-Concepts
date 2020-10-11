using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace NameValue_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            NameValueCollection cities = new NameValueCollection();

            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Germany", "Hamburg");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");

            foreach (string item in cities)
            {
                Console.Write(item + ": " );
                Console.WriteLine(cities[item]);
            }

            cities.Set("Italy", "Venice");

            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            Console.WriteLine(cities.HasKeys());

            

        }
    }
}
