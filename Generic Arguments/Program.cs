using System;
using System.Collections.Generic;

namespace Generic_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo("Branch");
            DisplayInfo(2);
            DisplayInfo(8.7);
            DisplayInfo(DateTime.Now);

            var character = (6, "Rayden", 220);
            DisplayInfo(character);
        }

        public static void DisplayInfo<T>(T name)
        {
            Console.WriteLine(name);
        }
    }
}
