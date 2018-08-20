using System;

namespace _04DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintHeaderOrFooter(input);

            for (int i = 0; i < input - 2; i++)
            {
                PrintMiddle(input);
            }

            PrintHeaderOrFooter(input);
        }

        static void PrintHeaderOrFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
