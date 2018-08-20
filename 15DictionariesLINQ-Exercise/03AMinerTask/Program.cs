using System;
using System.Collections.Generic;

namespace _03AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else
                {
                    dict.Add(resource, quantity);
                }

                resource = Console.ReadLine();
            }

            foreach (var element in dict)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
