using System;

namespace _02CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = r * r * Math.PI;

            Console.WriteLine($"{area:F12}");
        }
    }
}
