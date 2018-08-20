using System;
using System.Linq;

namespace DistanceBEtweenPoints
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = Point.CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
            
        }

        private static Point ReadPoint()
        {
            int[] inputCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            return new Point(inputCoordinates[0], inputCoordinates[1]);
        }
    }
}
