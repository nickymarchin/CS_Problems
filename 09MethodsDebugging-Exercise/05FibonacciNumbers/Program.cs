using System;

namespace _05FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            long result = Fib(input + 1);

            Console.WriteLine(result);
        }

        static long Fib(long number)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = b + temp;
            }

            return a;
        }
    }
}
