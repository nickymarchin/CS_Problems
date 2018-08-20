using System;
using System.Text.RegularExpressions;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ivan Ivanov", "Ivan ivanov", "ivan Ivanov", "IVan Ivanov", "Test Testov"};

            string pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];

                Match match = regex.Match(name);

                if (match.Success)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
