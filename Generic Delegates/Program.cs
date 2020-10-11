using System;
using System.Collections.Generic;

namespace Generic_Delegates
{
    public delegate T DisplayInfo<T>(T value);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayInfo);
            Console.WriteLine(myNumber(56));

            DisplayInfo<string> myWord = new DisplayInfo<string>(DisplayInfo);
            Console.WriteLine(myWord("Bird"));

            DisplayInfo<DateTime> myDate = new DisplayInfo<DateTime>(DisplayInfo);
            Console.WriteLine(myDate(new DateTime(2018,4,17)));
        }

        public static T DisplayInfo<T>(T value)
        {
            Console.WriteLine("We are accessing variable of type " + value.GetType().Name);
            return value;
        }

    }
}
