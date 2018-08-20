using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "Play!")
            {
                string[] commands = input.Split().ToArray();

                string command = commands[0];
                string game = commands[1];

                if (command == "Install")
                {
                    if (games.Contains(game) == false)
                    {
                        games.Add(game);
                    }
                }
                else if (command == "Uninstall")
                {
                    games.Remove(game);
                }
                else if (command == "Update")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    string[] tokens = game.Split("-");

                    int index = games.IndexOf(tokens[0]);

                    if (games.Contains(tokens[0]))
                    {
                        games.Insert(index + 1, string.Join(":", tokens)); //zapomni .Insert(index, string);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", games));

        }
    }
}
