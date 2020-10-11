using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> phonebook = new SortedList<string, int>();

            phonebook.Add("Jenny", 8675309);
            phonebook.Add("Zach", 5524249);
            phonebook.Add("Chris", 8655487);
            phonebook.Add("Melissa", 8722359);

            foreach (var item in phonebook)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("---------------");

            Console.WriteLine(phonebook["Jenny"]);

            phonebook["Jenny"] = 5555565;

            phonebook.TryGetValue("Melissa", out int number);
            Console.WriteLine("---------------");


            phonebook.Remove("Zach");

            foreach (var item in phonebook)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            //phonebook.RemoveAt(2);

            //foreach (var item in phonebook)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(phonebook.ContainsKey("Melissa"));






        }
    }
}
