using System;
using System.Linq;

namespace _06MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int digit = 0;
            int max = 1;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentIndex = input[i];
                int longest = 0;

                for (int j = i; j < input.Length; j++)
                {
                    if (currentIndex == input[j])
                    {
                        longest++;

                        if (max < longest)
                        {
                            max = longest;
                            digit = currentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
 
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(digit + " ");
            }

            Console.WriteLine();
        }
    }
}
