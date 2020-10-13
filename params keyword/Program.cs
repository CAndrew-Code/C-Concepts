using System;

namespace params_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations(5, 20);

        }

        public static void MathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number;
                }
                return result;
            }

            Console.WriteLine("Multiply = " + MultiNumbers());
            int MultiNumbers()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
        }

    }
}
