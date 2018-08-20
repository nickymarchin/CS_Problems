using System;

namespace _16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = firstNumber - secondNumber;
            if (Math.Abs(difference) >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else if (Math.Abs(difference) < 0.000001)
            {
                Console.WriteLine("True");
            }
        }
    }
}
