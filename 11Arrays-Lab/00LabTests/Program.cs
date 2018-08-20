using System;
using System.Linq;

namespace _00LabTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 20    30

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Console.WriteLine(String.Join(", ", numbers));

        }
    }
}
