using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);

    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber oneParameterDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            oneParameterDelegate(100);

            DisplayInfo delUsingAnonymousMethod = delegate { Console.WriteLine("Hello we are Anonymous!"); };
            delUsingAnonymousMethod();

            DisplayInfoBasedOnNumber anonymousDelWithParameter = delegate (int number) { Console.WriteLine("We are still Anonymous " + number); };
            anonymousDelWithParameter(10);
        }

        public static void GetInformation()
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with one parameter : " + x);
        }
    }
}
