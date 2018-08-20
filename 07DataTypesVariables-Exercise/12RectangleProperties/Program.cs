using System;

namespace _12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimiter = 2 *( width + height);
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimiter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
