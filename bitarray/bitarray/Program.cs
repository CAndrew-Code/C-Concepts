using System;
using System.Collections;

namespace bitarray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray myarray = new BitArray(4);

            myarray.Set(0, false);
            myarray.Set(1, false);
            myarray.Set(2, false);
            myarray.Set(3, true);


            bool[] boolarray = new bool[4];
            boolarray[0] = false;
            boolarray[1] = false;
            boolarray[2] = true;
            boolarray[3] = true;

            BitArray array2 = new BitArray(boolarray);

            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");

            BitArray result = new BitArray(4);
            result = myarray.Not();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
