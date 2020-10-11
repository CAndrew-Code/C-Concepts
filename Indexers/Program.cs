using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();

            animal[0] = "Lion";
            animal[1] = "Tiger";
            animal[2] = "Bear";

            Console.WriteLine(animal[1]);
        }
    }

    class Animals
    {
        private string[] name = new string [100];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }

    }
}
