using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrent_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1 started\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Thread 1 added " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread 1 Complete.\n");
            });

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2 started\n");
                for (int i = 15; i <= 25; i++)
                {
                    Console.WriteLine("Thread 2 added " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread 2 Complete.\n");
            });

            Thread t3 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                Console.WriteLine("Thread 3 Started\n");
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thread 3 Complete\n");
            });

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
