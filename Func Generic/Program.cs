using System;
using System.Collections.Generic;


namespace Func_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddTwoNumbers;
            Console.WriteLine(AddTwoNumbers(7, 3));

            Func<int> funcTwo = AddTwoNumbers;
            Console.WriteLine( AddTwoNumbers());
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 2;

            z = x + y;

            return z;
        }
    }
}
