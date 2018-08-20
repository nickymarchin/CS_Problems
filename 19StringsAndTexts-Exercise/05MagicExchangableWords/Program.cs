using System;
using System.Collections.Generic;

namespace _05MagicExchangableWords
{
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();

            string word1 = tokens[0];
            string word2 = tokens[1];

            bool isExchangable;
            if (word1.Length >= word2.Length)
            {
                isExchangable = MapWords(word1, word2);
            }
            else
            {
                isExchangable = MapWords(word2, word1);
            }

            Console.WriteLine(isExchangable.ToString().ToLower());

        }

        static bool MapWords(string word1, string word2)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            for (int i = 0; i < word2.Length; i++)
            {
                char firstWordChar = word1[i];
                char secondWordChar = word2[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    map[firstWordChar] = secondWordChar;
                }
                else if (map[firstWordChar] != secondWordChar)
                {
                    return false;
                }
            }

            for (int i = word2.Length; i < word1.Length; i++)
            {
                char firstWordChar = word1[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
