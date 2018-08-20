using System;
using System.Text.RegularExpressions;

namespace _04Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([A-Z]{2})([\d]+.[\d]+)([\w]+)[?=\|]");

            while (input != "end")
            {
                var match = regex.Match(input);

                Console.WriteLine($"{match.Groups[1]} => {match.Groups[2]:F2} => {match.Groups[3]}");

                input = Console.ReadLine();
            }

            // dictionary<string, KeyValuePair<double, strig>>
        }
    }
}
