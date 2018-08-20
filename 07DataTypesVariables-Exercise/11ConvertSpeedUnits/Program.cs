using System;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double totalSeconds = seconds + minutes * 60 + hours * 3600;
            double metersPerSecond = meters / totalSeconds;
            Console.WriteLine(Math.Round(metersPerSecond, 6));

            double totalHours = totalSeconds / 3600;
            double metersPerHour = (meters/1000) / totalHours;
            Console.WriteLine(Math.Round(metersPerHour, 6));

            double miles = meters / 1609;
            double milesPerHour = miles / totalHours;
            Console.WriteLine(Math.Round(milesPerHour, 6));
        }
    }
}
