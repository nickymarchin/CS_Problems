using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01ConvertFromBase2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split();

            int @base = int.Parse(inputTokens[0]);
            string numAsString = inputTokens[1];

            BigInteger sum = 0;
            int pow = 0;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currentChar = numAsString[i];
                int currentNumber = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);

                sum += currentSum;
                pow++;
            }

            Console.WriteLine(sum);


        }
    }
}
