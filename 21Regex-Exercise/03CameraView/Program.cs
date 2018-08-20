using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int skipElements = int.Parse(tokens[0]);
            int takeElements = int.Parse(tokens[1]);

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=\|<)[\w]+[\W]?[^\|<][\w]+");

            var matches = regex.Matches(input);

            List<string> results = new List<string>();

            foreach (var match in matches)
            {
                string result = new string(match.ToString().Skip(skipElements).Take(takeElements).ToArray());
                results.Add(result);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
