using System;

namespace _02CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int index = input.IndexOf(pattern);
            int count = 0;

            while (index != -1)
            {
                count++;    
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
