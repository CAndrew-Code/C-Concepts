using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();

            IList<string> yourlist = new List<string>();

            mylist.Add("Carrot");
            mylist.Add("Tomato");
            mylist.Add("Mushroom");
            mylist.Add("Potato");

            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine(mylist[1]);


            mylist[2] = "Cucumber";

            Console.WriteLine(mylist.Count);
            Console.WriteLine("--------------------");
            mylist.Sort();
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }

            mylist.Reverse();

            mylist.Remove("Carrot");

            //mylist.Clear()

            yourlist = mylist.GetRange(0, 2);

            foreach (var item in yourlist)
            {
                Console.WriteLine(item);
            }

        }
    }
}
