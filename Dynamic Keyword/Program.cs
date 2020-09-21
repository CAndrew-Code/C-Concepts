using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = 0;
            Console.WriteLine("The Value is " + value);
            Console.WriteLine("The Type is of type " + value.GetType().Name);
            Console.WriteLine();

            value = "The Umbrella Academy";
            Console.WriteLine("The Value is " + value);
            Console.WriteLine("The Type is of type " + value.GetType().Name);
            Console.WriteLine();

            value = new Animals();
            value.Name = "Dog";
            Console.WriteLine("The Value is " + value.Name);
            Console.WriteLine("The Type is of type " + value.GetType().Name);



        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
