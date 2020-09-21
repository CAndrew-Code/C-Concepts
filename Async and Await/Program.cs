using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = Interruption();

            addNumbers(2, 4);

            Console.ReadLine();
            
        }

        public static async Task Interruption()
        {
            Console.WriteLine("This is the method starting...");
            Console.WriteLine("Now we are going to have the await begin...\n");
            await Task.Run(() =>
            {
                Console.WriteLine("The await is interrupting... How long will this take?\n");
                Thread.Sleep(4000);
                Console.WriteLine("This Long...");
            });
            Console.WriteLine("The task interrupted but now i get to keep going.\n");
        }

        public static void addNumbers (int first, int second)
        {
            Console.WriteLine("Look I'm adding...");
            Console.WriteLine("The sum...\n " + first + second);

        }
    }
}
