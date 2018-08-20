using System;
using System.Linq;

namespace _01LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int leftToRight = 0;
            int rightToLeft = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftToRight += 1;
                }
            }

            for (int i = Math.Min(arr1.Length - 1, arr2.Length - 1); i >= 0; i--)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    rightToLeft += 1;
                }
            }

            if (leftToRight > rightToLeft)
            {
                Console.WriteLine(leftToRight);
            }
            else if (rightToLeft >= leftToRight)
            {
                Console.WriteLine(rightToLeft);
            }
            else
            {
                Console.WriteLine(0);
            }

            //string[] arr1 = Console.ReadLine().Split();
            //string[] arr2 = Console.ReadLine().Split();

            //int rightToLeft = 0;
            //int leftToRight = 0;

            //for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            //{
            //    if (arr2[i] == arr1[i])
            //    {
            //        leftToRight += 1;
            //    }

            //    if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
            //    {
            //        rightToLeft += 1;
            //    }
            //}

            //if (rightToLeft > leftToRight)
            //{
            //    Console.WriteLine(rightToLeft);
            //}
            //else if (leftToRight >= rightToLeft)
            //{
            //    Console.WriteLine(leftToRight);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}
        }
    }
}
