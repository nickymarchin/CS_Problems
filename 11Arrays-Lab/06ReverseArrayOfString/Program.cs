﻿using System;

namespace _06ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            for (int i = elements.Length - 1 ; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
