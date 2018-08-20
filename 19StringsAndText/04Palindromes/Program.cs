using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); // da ne vliza prazen string

            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                bool isPalindrome = IsPalindrome(word);

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            var sorted = palindromes.Distinct().OrderBy(x => x);

            Console.WriteLine(string.Join(", ", sorted));

        }

        static bool IsPalindrome(string word)
        {
            string reversed = new string(word.Reverse().ToArray());

            return String.Equals(reversed, word);
        }
    }
}
