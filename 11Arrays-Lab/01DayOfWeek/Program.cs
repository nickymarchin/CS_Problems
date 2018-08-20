using System;

namespace _01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            //if (day <= 7 && day >= 1)
            //{
            //    Console.WriteLine(days[day-1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Day!");
            //}

            try
            {
                Console.WriteLine(days[day - 1]);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
