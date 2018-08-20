using System;

namespace _02MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = "";

            while (input != "Visual Studio crash")
            {
                text += input + " ";
                input = Console.ReadLine();
            }

            string[] arr = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "32656" && arr[i + 1] == "19759" && arr[i+2] == "32763")
                {
                    int length = int.Parse(arr[i + 4]);
                    string word = "";

                    for (int j = 0; j < length; j++)
                    {
                        word += (char)int.Parse(arr[i + 6 + j]); //coool
                    }

                    Console.WriteLine(word);

                    word = ""; //!!!!!!!!!!!!!!!!!!
                }
            }
        }
    }
}
