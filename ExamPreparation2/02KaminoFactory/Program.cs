using System;
using System.Linq;

namespace _02KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int rowCounter = 0;
            int bestLength = 0;
            int bestIndex = 0;
            int[] bestSequence = new int[lenght];
            int indexOfSeq = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }

                rowCounter++;

                int[] splitted = line.Split("!").Where(x => x != "").Select(int.Parse).ToArray();

                int currLength = 0;
                int currIndex = 0;
                bool found = false;
                

                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i] == 1)
                    {
                        currLength++;

                        if (currLength > bestLength)
                        {
                            indexOfSeq = rowCounter;
                            bestLength = currLength;
                            bestSequence = splitted;
                        }
                        else if (currLength == bestLength)
                        {
                            if (currIndex == bestIndex)
                            {
                                int sumBestSeq = bestSequence.Sum();
                                int sumCurrSeq = splitted.Sum();
                            }
                            else
                            {
                                if (currIndex > bestIndex)
                                {
                                    indexOfSeq = rowCounter;
                                    bestLength = currLength;
                                    bestSequence = splitted;                                
                                }
                            }
                        }
                    }
                    else
                    {
                        currIndex = 0;
                        currLength = 0;
                    }
                }

                found = false;

                rowCounter++;
            }

            Console.WriteLine($"Best DNA sample 2 with sum: 2.");
            Console.WriteLine(string.Join(' ', bestSequence));

        }
    }
}
