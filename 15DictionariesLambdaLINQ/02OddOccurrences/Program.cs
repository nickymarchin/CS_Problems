using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word]++;
                }
                else
                {
                    occurrences[word] = 1;
                }
            }

            List<string> resultList = new List<string>();

            foreach (var key in occurrences.Keys)
            {
                if (occurrences[key] % 2 != 0)
                {
                    resultList.Add(key);
                }
            }

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
