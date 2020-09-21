using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whale = new Animal();
        }
    }
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("A new animal has been created");
        }

        ~Animal()
        {
            Console.WriteLine("Animal object is now being destoried");
        }
    }
}
