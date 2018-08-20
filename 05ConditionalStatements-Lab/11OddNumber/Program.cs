using System;

namespace _11OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(n));
                    break;
                }

                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
