using System;

namespace Delegate_Multicast
{
    public delegate void SayHiDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(HiInEnglish);
            sayHi += new SayHiDelegate(HiInHawiian);
            sayHi += new SayHiDelegate(HiInGerman);
            sayHi += new SayHiDelegate(HiInItalian);

            sayHi();
        }

        public static void HiInEnglish()
        {
            Console.WriteLine("Hello");
        }

        public static void HiInHawiian()
        {
            Console.WriteLine("Aloha");
        }

        public static void HiInGerman()
        {
            Console.WriteLine("Gutten Tag");
        }

        public static void HiInItalian()
        {
            Console.WriteLine("Ciao");
        }
    }
}
