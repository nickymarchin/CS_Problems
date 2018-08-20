using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02SoftuniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] aviableSongs = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, Dictionary<string, int>> output = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "dawn")
            {
                string currentParticipant = input[0];
                string currentSong = input[1];
                string award = input[2];

                if (participants.Contains(currentParticipant) && aviableSongs.Contains(currentSong))
                {
                    if (output.ContainsKey(currentParticipant) == false)
                    {
                        output.Add(currentParticipant, new Dictionary<string, int>());

                        if (output[currentParticipant].ContainsKey(award) == false)
                        {
                            output[currentParticipant].Add(award, 1);
                        }
                    }
                    else
                    {
                        if (output[currentParticipant].ContainsKey(award) == false)
                        {
                            output[currentParticipant].Add(award, 1);
                        }
                    }
                }

                input = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            }

            if (output.Count != 0)
            {
                foreach (var singer in output.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Values.Sum()} awards");

                    foreach (var prize in singer.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"--{prize.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
