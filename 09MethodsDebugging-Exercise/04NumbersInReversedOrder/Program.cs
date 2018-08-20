using System;

namespace _04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReversedNumbers(input);
        }

        static void ReversedNumbers(string numberStr)
        {
            string result = "";
            char symbol = '\0';
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                symbol = numberStr[i];
                result += symbol;
            }

            Console.WriteLine(result);
        }
    }
}
