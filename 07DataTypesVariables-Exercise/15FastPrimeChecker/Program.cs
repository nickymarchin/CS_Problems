using System;

namespace _15FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int number = 2; number <= inputNumber; number++)
            {
                bool isPrime = true;

                for (int devider = 2; devider <= Math.Sqrt(number); devider++)
                {
                    if (number % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {isPrime}");
            }
        }
    }
}
