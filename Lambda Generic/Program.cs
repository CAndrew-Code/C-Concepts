using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(5); list.Add(8); list.Add(10);
            list.Add(6); list.Add(7); list.Add(9);

            var oddlist = list.Where(n => n % 2 != 0).ToList();
            var evenlist = list.Where(n => n % 2 == 0).ToList();
        }
    }
}
