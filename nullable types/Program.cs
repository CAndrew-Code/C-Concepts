using System;

namespace nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? myTime = null;
            Console.WriteLine(myTime);

            int? number = null;
            Console.WriteLine(number);

            int numberTwo = (int)number;
            numberTwo = 8;

            Console.WriteLine(number ?? numberTwo);
        }
    }
}
