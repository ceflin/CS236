using System;
using System.Collections.Generic;

namespace SOLID
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var items = new List<int> { 1, 2, 3 };
            var ints = new int[] { 1, 2, 3 };

            PerformListActionExample.DoAction(items);

            PerformListActionExample.DoAction(items, Console.WriteLine);

            PerformListActionExample.DoAction(ints);

            PerformListActionExample.DoAction(ints, Console.WriteLine);

        }
    }
}