using System;
using System.Linq;

namespace _00Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcde";

            string b = new string(a.Reverse().Take(2).ToArray());

            Console.WriteLine(b);
        }
    }
}
