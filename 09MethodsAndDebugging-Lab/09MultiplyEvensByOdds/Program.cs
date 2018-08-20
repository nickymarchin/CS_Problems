using System;

namespace _09MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvensAndOdds(input);
            Console.WriteLine(result);

        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumOfOdds = SumOfOddDigits(n);
            int sumOfEvens = SumOfEvenDigits(n);

            int result = sumOfEvens * sumOfOdds;
            return result;
        }

        private static int SumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }
        
        private static int SumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }
    }
}
