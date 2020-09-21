using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            People.SayHi();
        }
    }

    class People
    {
        [Obsolete("This method will no longer be used as of 2/3/2020", true)]
        public static void SayHi()
        {
            Console.WriteLine("Hi");

        }

        public static void SayHello()
        {

        }
    }
}
