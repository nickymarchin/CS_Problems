using System;

namespace _09MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int result = 0;

            if (multiplier > 10)
            {
                result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
            }

            for (int i = multiplier; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }

        }
    }
}
