using System;
using System.Collections.Generic;
using System.Linq;

namespace _05HandsOfCards2
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersAndCards = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "JOKER")
                {
                    break;
                }

                string[] tokens = line.Split(": ");
                string player = tokens[0];
                List<string> cards = tokens[1].Split(", ").ToList();

                if (!playersAndCards.ContainsKey(player))
                {
                    playersAndCards.Add(player, new List<string>());
                    playersAndCards[player] = cards;
                }
                else
                {
                    playersAndCards[player].AddRange(cards);
                }

                playersAndCards[player] = playersAndCards[player].Distinct().ToList();
            }
        }

        static int Power(Dictionary<string, List<string>> dict, string player)
        {
            var hand = dict[player];

            Dictionary<string, int> power =
                new Dictionary<string, int>() { { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 } };

            Dictionary<string, int> type =
                new Dictionary<string, int>() { { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 } };

            int sum = 0;

            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].Length == 3)
                {
                    sum += 10 * type[hand[i].TakeLast(1).ToString()];
                }
                else if (type.ContainsKey(hand[i]))
                {
                    int res = 0;
                    bool p = int.TryParse(hand[0][1].ToString(), out res);
                    sum += int.Parse(hand[i][0].ToString()) * res;
                }
            }
        }
    }
}
