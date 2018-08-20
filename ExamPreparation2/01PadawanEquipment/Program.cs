using System;

namespace _01PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double saberPrice = (Math.Ceiling(1.1 * studentsCount) * lightsaberPrice);
            double robesPrice = (studentsCount * robePrice);
            double beltsPrice = ((studentsCount - (studentsCount / 6)) *beltPrice);

            double price = saberPrice + robesPrice + beltsPrice;

            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {price - money:f2}lv more.");
            }
        }
    }
}
