using System;

namespace _08CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterPoint(x1, x2, y1, y2);
        }

        static void CenterPoint(double x1, double x2, double y1, double y2)
        {
            double firstPointDistance = Math.Abs(x1) + Math.Abs(x2);
            double secondPointDistance = Math.Abs(y1) + Math.Abs(y2);

            if (firstPointDistance < secondPointDistance)
            {
                Console.WriteLine($"({x1}, {x2})");
            }
            else
            {
                Console.WriteLine($"({y1}, {y2})");
            }
        }
    }
}
