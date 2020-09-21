using System;

namespace exressionbody
{
    class Program
    {
        static void Main(string[] args)
        {
            AddingNumbers(2, 3);
            SayHi();
            
        }

        public static void SayHi() => Console.WriteLine("What up, Kid?");

        public static int AddingNumbers(int x, int y) => x + y;

    }
}
