using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeral_and_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 10)
                                      select value;

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            double avg = result.Average();
            Console.WriteLine(avg);

            List<int> list = result.ToList();
            int[] array = result.ToArray();

            //list.Add(11); list.Add(13); list.Add(14);

            result = list.AsEnumerable();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
