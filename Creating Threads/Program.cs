using System;
using System.Threading;

namespace Creating_Threads
{
    class Program
    {
        static Thread mythread;
        static Thread secondThread;
        static void Main(string[] args)
        {
            mythread = new Thread(new ThreadStart(SayHiEnglish));

            mythread.Start();

            secondThread = new Thread(new ThreadStart(SayHiSpanish));

            secondThread.Start();
        }

        public static void SayHiEnglish()
        {
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(1000);
                //if(i==15)
                //{
                //    Console.WriteLine("Condition met");
                //    mythread.Abort();
                //}
                secondThread.Join();

                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(new TimeSpan(0,0,1));
                Console.WriteLine(i + " Hola...");
            }
        }
    }
}
