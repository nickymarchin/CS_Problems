using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                //string check = email.Reverse(); STAVA string check = new string(email.Reverse().Take(2).ToArray());

                if (!email.EndsWith(".us") && !email.EndsWith(".uk"))
                {
                    info.Add(name, email);
                }
            }

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
