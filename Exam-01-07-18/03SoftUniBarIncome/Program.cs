using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^$|%.]*<(?<product>[\w]+)>[^$|%.]*\|(?<count>[\d]+)\|[^$|%.\d]*(?<price>[\d]+.[\d]*)(?=\$)";

            string line = Console.ReadLine();

            Regex regex = new Regex(pattern);

            List<double> results = new List<double>();

            while (line != "end of shift")
            {

                Match match = regex.Match(line);
                if (match.Success)
                {
                    double count = double.Parse(match.Groups["count"].ToString());

                    double price = double.Parse(match.Groups["price"].ToString());

                    double result = count * price;

                    results.Add(result);

                    Console.WriteLine($"{match.Groups["name"]}: {match.Groups["product"]} - {result:f2}");
                }
                             
                line = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {results.Sum():f2}");
        }
    }
}
