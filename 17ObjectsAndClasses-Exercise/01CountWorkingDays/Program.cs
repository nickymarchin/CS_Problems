using System;
using System.Globalization;

namespace _01CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            
            DateTime startDate = DateTime.ParseExact(input1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(input2, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] nonWorkingDays = new DateTime[]
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            int countWorkDays = 0;


            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (!(i.DayOfWeek == DayOfWeek.Saturday) && !(i.DayOfWeek == DayOfWeek.Sunday) )
                {
                    countWorkDays++;
                    foreach (var item in nonWorkingDays)
                    {
                        if ((i.Day == item.Day) && (i.Month == item.Month))
                        {
                            countWorkDays--;
                        }
                    }
                }
            }

            Console.WriteLine(countWorkDays);

        }  
    }
}
