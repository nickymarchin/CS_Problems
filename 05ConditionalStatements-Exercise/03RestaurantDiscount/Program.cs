using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double pricePerPerson = 0;
            string hallName = "";


            if (groupSize <= 50)
            {
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = (3000 - (3000 * 0.05)) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = (3250 - (3250 * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = (3500 - (3500 * 0.15)) / groupSize;
                        break;
                }

                hallName = "Small Hall";
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = (5500 - (5500 * 0.05)) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = (5750 - (5750 * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = (6000 - (6000 * 0.15)) / groupSize;
                        break;
                }

                hallName = "Terrace";
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = (8000 - (8000 * 0.05)) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = (8250 - (8250 * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = (8500 - (8500 * 0.15)) / groupSize;
                        break;
                }

                hallName = "Great Hall";
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
