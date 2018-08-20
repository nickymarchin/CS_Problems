using System;

namespace _06PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            
            return isPrime;
        }
    }
}
