using System;

namespace _09RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;

                int currentIndex = i;

                while (currentIndex > 0)
                {
                    sum += currentIndex % 10;
                    currentIndex = currentIndex / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
