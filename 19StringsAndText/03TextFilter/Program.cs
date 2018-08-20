using System;
using System.Text;

namespace _03TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder builder = new StringBuilder();



            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
