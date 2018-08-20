using System;
using System.Linq;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' };

            string[] input = Console.ReadLine().ToLower().Split(separators);

            var result = input.Where(x => x != "").Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", result));
                
        }
    }
}
