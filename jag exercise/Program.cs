using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jag_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < jagTwo.Length; i++)
            {
                Console.WriteLine("This is array " + i);
                for (int j = 0; j < jagTwo[i].Length; j++)
                {
                    Console.WriteLine(jagTwo[i][j]);
                }
            }

        }
    }
}
