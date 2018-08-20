using System;
using System.Collections.Generic;
using System.Linq;

namespace _00Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            var result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input.ElementAt(i) > 0)
                {
                    result.Add(input.ElementAt(i));
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}

