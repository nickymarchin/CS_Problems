using System;

namespace _02MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNumber = MaxNumber(MaxNumber(num1, num2), num3);
            Console.WriteLine(maxNumber);
        }

        static int MaxNumber(int number1, int number2)
        {
            if (number1 >= number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }

        }
    }
}
