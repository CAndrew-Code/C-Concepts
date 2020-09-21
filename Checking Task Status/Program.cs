using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace Checking_Task_Status
{
    class Program
    {
        static Timer time;

        static Task task1;
        static void Main(string[] args)
        {
            task1 = new Task(() =>
            {
                for (int i = 1; i <= 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task1.Start();
            time = new Timer();
            time.Elapsed += CheckTheTask;
            time.Interval = 100;
            time.Enabled = true;
            
            Console.ReadLine();
        }

        private static void CheckTheTask(object sender, ElapsedEventArgs e)
        {
            if (task1.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running...");
            }
            else if (task1.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete.");
                time.Enabled = false;
            }
        }
    }
}
