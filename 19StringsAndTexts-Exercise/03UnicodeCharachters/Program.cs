 using System;
using System.Text;

namespace _03UnicodeCharachters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var symbol in input)
            {
               sb.Append("\\u" + ((int) symbol).ToString("x4"));
            }

            Console.WriteLine(sb);
        }
    }
}
