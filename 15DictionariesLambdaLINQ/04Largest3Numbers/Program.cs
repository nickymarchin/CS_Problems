using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var orderedList = input.OrderByDescending(x => x);

            var resultList = orderedList.Take(3);

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
