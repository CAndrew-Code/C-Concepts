using System;

namespace Lambda_Expressions
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply multiplynumber = delegate (int n) { { return n * 3; } };
            Multiply multiplynumber = n => n * 3;
            Console.WriteLine(multiplynumber(50));

            //DisplayMessage Message = delegate { Console.WriteLine("Your wife is the boss"); };
            DisplayMessage Message = () => Console.WriteLine("This is boss");
            Message();
            
        }
    }
}
