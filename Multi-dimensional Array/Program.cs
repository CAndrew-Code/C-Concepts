using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] multiArray = new string[3, 2];

            multiArray[0, 0] = "Pop";
            multiArray[0, 1] = "Rap";

            multiArray[1, 0] = "Rock";
            multiArray[1, 1] = "Country";

            multiArray[2, 0] = "Emo";
            multiArray[2, 1] = "Techno";


            int[,] secondArray = new int[4, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4} };
            string[,] names = new string[,] { { "Kim", "Wife" }, { "Colin", "Husband" }, { "Remi", "Daughter" } };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(multiArray[1,0]);


        }
    }
}
