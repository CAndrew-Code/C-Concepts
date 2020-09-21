using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cancel_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTS = new CancellationTokenSource();
            CancellationToken token = cancellationTS.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task has been cancelled");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                Console.WriteLine("Task is complete...");
            });
            task.Start();

            //Thread.Sleep(2000);

            //cancellationTS.Cancel();

            cancellationTS.CancelAfter(1750);

            Console.ReadLine();
        }
    }
}
