using System;

namespace _05TemperatureConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = FahrenheitToCelsius(input);

            Console.WriteLine($"{result:F2}");
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
