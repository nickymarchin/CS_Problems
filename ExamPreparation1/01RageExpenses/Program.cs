using System;

namespace _01RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrash = lostGames / 2;
            int mouseTrash = lostGames / 3;
            int keyboardTrash = lostGames / 6;
            int displayTrash = keyboardTrash / 2;

            double expenses = headsetPrice * headsetTrash + mousePrice * mouseTrash +
                keyboardPrice * keyboardTrash + displayPrice * displayTrash;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
