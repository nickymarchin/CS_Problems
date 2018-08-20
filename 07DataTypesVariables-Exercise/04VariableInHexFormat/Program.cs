using System;

namespace _04VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}
