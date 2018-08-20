using System;
using System.Collections.Generic;

namespace _00Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();

            a.Add("2");
            a.Add("3");

            a.Insert(a.IndexOf("3") + 1, "4");

            Console.WriteLine(a[2]);
        }
    }
}
