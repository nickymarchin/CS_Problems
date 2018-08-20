using System;

namespace _01SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = employeeOne + employeeTwo + employeeThree;

            int hours = 0;
            int count = 0;

            while (studentsCount > 0)
            {
                studentsCount -= studentsPerHour;

                hours++;
                count++;

                if (count == 3 && studentsCount != 0)
                {
                    hours += 1;
                    count = 0;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
