using System;

namespace _04SieveOfErathosten
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool[] array = new bool[n];

            array[0] = false;
            array[1] = false;

            for (int i = 2; i < array.Length; i++)
            {
                array[i] = true;
            }
                                    //5
            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int j = 2; j * i <= n; j++)
                    {
                        array[j * i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
