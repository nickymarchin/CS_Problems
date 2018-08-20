using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex starRegex = new Regex(@"[SsTtAaRr]");

            Regex messageRegex = new Regex(@"[^@\-:!>]*@(?<name>[A-Za-z]+)[^@\-:!>]*:(\d+)[^@\-:!>]*!(?<type>A|D)!->(\d+)[^@\-:!>]*");

            List<string> attacked = new List<string>();
            List<string> destoyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                MatchCollection starMatches = starRegex.Matches(line);

                int step = starMatches.Count;

                StringBuilder decMessage = new StringBuilder();

                for (int j = 0; j < line.Length; j++)
                {
                    char current = (char)(line[j] - step);
                    decMessage.Append(current);
                }

                if (messageRegex.IsMatch(decMessage.ToString()))
                {
                    Match match = messageRegex.Match(decMessage.ToString());
                    string type = match.Groups["type"].Value;
                    string name = match.Groups["name"].Value;

                    if (type == "D")
                    {
                        destoyed.Add(name);
                    }
                    else if (type == "A")
                    {
                        attacked.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (string planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destoyed.Count}");
            foreach (string planet in destoyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
