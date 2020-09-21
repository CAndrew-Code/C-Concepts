using System;

namespace Events
{
    public delegate void EventDelegate(string name);

    class Program
    {
        public event EventDelegate myEvent;

        public Program()
        {
            myEvent += new EventDelegate(SayHiEnglish);
            myEvent += new EventDelegate(SayHiAribic);
            myEvent += new EventDelegate(SayHiItalian);

        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.myEvent("Kimberly the Kind");
        }
        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public void SayHiAribic(string name)
        {
            Console.WriteLine("Marhaaban " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Caio " + name);
        }
    }
}
