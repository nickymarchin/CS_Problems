using System;

namespace _02ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                double price = quantity * 0.70;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                double price = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                double price = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else
            {
                double price = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
        }
    }
}
