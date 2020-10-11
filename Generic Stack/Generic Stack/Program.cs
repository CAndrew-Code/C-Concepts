using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<DateTime> arrivals = new Queue<DateTime>();

            arrivals.Enqueue(new DateTime(2019, 09, 07));
            arrivals.Enqueue(new DateTime(2018, 04, 17));
            arrivals.Enqueue(new DateTime(2019, 11, 07));

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            var heroCity = new List<KeyValuePair<string, string>>();

            heroCity.Add(new KeyValuePair<string, string>("Superman", "Metropolis"));
            heroCity.Add(new KeyValuePair<string, string>("Spiderman", "New York City"));
            heroCity.Add(new KeyValuePair<string, string>("Flash", "Central City"));
            heroCity.Add(new KeyValuePair<string, string>("Black Panther", "Wakanda"));

            foreach (var item in heroCity)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GetFirstAndLastName().Value);


        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstname = "Colin";
            string lastname = "Andrew";

            return new KeyValuePair<string, string>(firstname, lastname);

        }

    }
}
