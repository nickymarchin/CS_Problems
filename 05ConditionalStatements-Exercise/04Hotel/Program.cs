using System;

namespace _04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nights = decimal.Parse(Console.ReadLine());
            decimal pricePerNightStudio = 0m;
            decimal pricePerNightDouble = 0m;
            decimal pricePerNightSuite = 0m;

            switch (month)
            {
                case "May":
                case "October":
                    pricePerNightStudio = 50m;
                    pricePerNightDouble = 65m;
                    pricePerNightSuite = 75m;
                    break;
                case "June":
                case "September":
                    pricePerNightStudio = 60m;
                    pricePerNightDouble = 72m;
                    pricePerNightSuite = 82m;
                    break;
                case "July":
                case "August":
                case "December":
                    pricePerNightStudio = 68m;
                    pricePerNightDouble = 77m;
                    pricePerNightSuite = 89m;
                    break;
            }

            decimal studioStay = pricePerNightStudio * nights;
            decimal doubleStay = pricePerNightDouble * nights;
            decimal suiteStay = pricePerNightSuite * nights;

            if (nights > 7 && (month == "May" || month == "October"))
            {
                studioStay = studioStay - (studioStay * 0.05m);
                if (month == "October")
                {
                    pricePerNightStudio = 50m * 0.95m;
                    studioStay = pricePerNightStudio * (nights - 1);
                }
            }

            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doubleStay = doubleStay - (doubleStay * 0.1m);
            }

            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suiteStay = suiteStay - (suiteStay * 0.15m);
            }

            else if (nights > 7 && (month == "September"))
            {
                studioStay = studioStay - pricePerNightStudio;
            }

            Console.WriteLine($"Studio: {studioStay:f2} lv.");
            Console.WriteLine($"Double: {doubleStay:f2} lv.");
            Console.WriteLine($"Suite: {suiteStay:f2} lv.");

        }


    }
}

