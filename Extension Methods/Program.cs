using System;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
        }
    }

    static class CustomExtention
    {
        public static bool IsGreater (this int value, int number )
        {
            return value > number;
        }


    }

}
