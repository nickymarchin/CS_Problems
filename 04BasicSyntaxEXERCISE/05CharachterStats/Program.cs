using System;

namespace _05CharachterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currHealth), new string('.', maxHealth-currHealth));
            Console.WriteLine("Energy: |{0}{1}|",new string('|', currEnergy), new string('.', maxEnergy-currEnergy));
            
        }
    }
}
