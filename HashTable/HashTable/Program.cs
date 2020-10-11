using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList mylist = new SortedList();

            mylist.Add(1, "Jan");
            mylist.Add(2, "Feb");
            mylist.Add(4, "April");
            mylist.Add(7, "July");
            mylist.Add(11, "Nov");
            mylist.Add(3, "Mar");
            mylist.Add(5, "May");

            foreach (DictionaryEntry item in mylist)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("---------------------");

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetKey(i) + ": " + mylist.GetByIndex(i));
            }

            Console.WriteLine("---------------------");

            Console.WriteLine(mylist[5].ToString());
            Console.WriteLine(mylist[4].ToString());
            Console.WriteLine("---------------------");


            Console.WriteLine(mylist.Count);
            Console.WriteLine("---------------------");

            mylist.RemoveAt(3);

            foreach (DictionaryEntry item in mylist)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }



        }
    }
}
