using System;

namespace _01HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            HelloName(input);
        }

        static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
