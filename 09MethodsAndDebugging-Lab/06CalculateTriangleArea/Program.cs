using System;

namespace _06CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);

            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
