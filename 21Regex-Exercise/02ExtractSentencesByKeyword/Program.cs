using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();

            string input = Console.ReadLine();

            string[] sentences = input.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                
            foreach (var sentence in sentences)
            {
                string[] words = Regex.Split(sentence, "[^A-Za-z]");

                if (words.Contains(keyword))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
