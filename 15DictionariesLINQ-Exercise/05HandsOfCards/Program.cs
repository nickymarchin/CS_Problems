using System;
using System.Collections.Generic;

namespace _05HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            char[] delimiters = {' ', ':', ',' };
            
            string[] input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "JOKER")
            {

            }
        }
    }
}
