using System;
using System.Text;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Pass_Param_to_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(new Action<object>(SayHi), "Kim");
            t1.Start();

            Task t2 = new Task(delegate (object name)
            {
                Console.WriteLine("You are a superstar " + name);
            }, "Kim");
            t2.Start();

            Task t3 = new Task(n => { Console.WriteLine("Goodbye " + n); }, "Kim");
            t3.Start();

            Console.ReadLine();

        }

        public static void SayHi(object name)
        {
            Console.WriteLine("Hello, it is nice to meet you " + name);
        }
    }
}
