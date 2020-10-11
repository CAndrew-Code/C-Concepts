using System;
using System.Linq;
using System.Collections.Generic;


namespace method_syntax_of_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<People>();
            var resident = new List<People>
            {
                new People { PersonName = "Kim", PersonAge = 33, AnnualIncome = 55000, StreetName = "Maplewood" },
                new People { PersonName = "Bryan", PersonAge = 34, AnnualIncome = 42000, StreetName = "North Marginal" },
                new People { PersonName = "Rachel", PersonAge = 26, AnnualIncome = 31000, StreetName = "Lake Shore" },
                new People { PersonName = "Chris", PersonAge = 27, AnnualIncome = 47000, StreetName = "Thunderbird" },
                new People { PersonName = "Rebecca", PersonAge = 30, AnnualIncome = 38000, StreetName = "Salida" },
            };

            People.Display(resident);

            Console.WriteLine("-----------------------");

            People.Display(SortPeople(resident));

        }

        public static List<People> SortPeople(List<People> people)
        {
            var list = from res in people
                               orderby res.PersonAge descending
                               select res;
            return list.ToList();
        }

    }

    class People
    {
        private string personName;
        private int personAge;
        private int annualIncome;
        private string streetName;

        public string PersonName { get { return personName; } set { personName = value; } }
        public int PersonAge { get { return personAge; } set {personAge = value; } }
        public int AnnualIncome { get {return annualIncome; } set {annualIncome = value; } }
        public string StreetName { get {return streetName; } set {streetName = value; } }

        public static void  Display (List<People> residents)
        {
            foreach (var resident in residents)
            {
                Console.WriteLine($"{resident.PersonName}, {resident.PersonAge}, {resident.AnnualIncome}, {resident.StreetName}");
                Console.WriteLine("-----------------------------");
            }
        }

    }
}
