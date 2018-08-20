using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var element in phonebook)
                    {
                        Console.WriteLine($"{element.Key} -> {element.Value}");
                    }
                }


                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
