using System;
using System.Text.RegularExpressions;

namespace _04WinnigTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10);

                    string jackpotPattern = @"\${20}|\@{20}|\#{20}|\^{20}";
                    string matchPattern = @"(\${6,})|(\@{6,})|(\#{6,})|(\^{6,})";

                    if (Regex.IsMatch(ticket, jackpotPattern))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                    }
                    else if (Regex.IsMatch(leftHalf, matchPattern) && Regex.IsMatch(rightHalf, matchPattern)
                        && Regex.Match(leftHalf, matchPattern).Groups[1].Value[0] == Regex.Match(rightHalf, matchPattern).Groups[1].Value[0])
                    {
                        char print = Regex.Match(leftHalf, matchPattern).Groups[1].Value[0];

                        int length = Regex.Match(rightHalf, matchPattern).Groups[1].Value.Length;

                        Console.WriteLine($"ticket \"{ticket}\" - {length}{print}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
