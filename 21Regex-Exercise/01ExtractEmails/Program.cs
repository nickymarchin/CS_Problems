using System;
using System.Text.RegularExpressions;

namespace _01ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)[A-Za-z]+[._-]?[\w]+@[\w]+[-]?[\w]+[.]?[\w]+[.]+[\w]+"; // wow

            Regex regex = new Regex(pattern);

            MatchCollection emails = regex.Matches(input);  // var

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
