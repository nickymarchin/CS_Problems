using System;
using System.Collections.Generic;
using System.Linq;

namespace _04SoftuniExamResults
{
    class Program
    {
        public static object Dictinary { get; private set; }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length == 3)
                {
                    string username = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (results.ContainsKey(username))
                    {
                        if (results[username] < points)
                        {
                            results[username] = points;
                        }
                    }

                    if (results.ContainsKey(username) == false)
                    {
                        results.Add(username, points);
                    }


                    if (submissions.ContainsKey(language))
                    {
                        submissions[language] += 1;
                    }

                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 1);
                    }
                    
                }
                else if (tokens.Length == 2)
                {
                    string username = tokens[0];

                    results.Remove(username);
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Results:");

            foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



        }
    }
}
