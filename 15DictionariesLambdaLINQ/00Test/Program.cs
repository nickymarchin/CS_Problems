using System;
using System.Collections.Generic;
using System.Linq;

namespace _00Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 5, 5, 4, 6, 7, 8, 1, 3 };

            nums = nums.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
