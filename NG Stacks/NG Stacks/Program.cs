using System;
using System.Collections;
using System.Collections.Concurrent;


namespace NG_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("Yontz");
            stack.Push("Christina");
            stack.Push("Kim");
            stack.Push("Remi");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine(stack.Pop());



        }
    }
}
