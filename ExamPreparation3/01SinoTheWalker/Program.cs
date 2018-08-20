using System;
using System.Linq;

namespace _01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timePerSteps = int.Parse(Console.ReadLine()) % 86400;

            int walkingTime = steps * timePerSteps;

            tokens[2] += walkingTime;

            for (int i = tokens.Length - 1; i > 0; i--)
            {
                if (tokens[i] >= 60)
                {
                    tokens[i] -= 60;
                    tokens[i - 1] += 1;
                    i++;
                }

                if (tokens[0] > 23)
                {
                    tokens[0] = 0;
                }
            }

            Console.WriteLine($"Time Arrival: {tokens[0]:d2}:{tokens[1]:d2}:{tokens[2]:d2}");

        }
    }
}
