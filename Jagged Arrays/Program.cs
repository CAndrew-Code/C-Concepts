using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[5] { 0, 1, 2, 3, 4 };
            jagged[1] = new int[2] { 10, 20 };
            jagged[2] = new int[3] { 3, 6, 9 };

            int[][] jagTwo ={
                new int[] {0,1,2},
                new int[]{10,20,30,40}
            };

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
