using System;

namespace _03LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (long i = 1; i < n; i++)
            {
                long sum = 0;
                long start = Math.Max(0, i-k);

                for (long j = start; j < i; j++)
                {
                    sum += seq[j];
                }

                seq[i] = sum;
            }

            for (long i = 0; i < n; i++)
            {
                Console.Write(seq[i] + " ");
            }

            Console.WriteLine();
        }
   
    }
}
