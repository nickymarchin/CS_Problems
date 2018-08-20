using System;

namespace _05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (Convert.ToBoolean(input))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
