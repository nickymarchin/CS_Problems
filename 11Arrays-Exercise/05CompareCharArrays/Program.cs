using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(x => char.Parse(x)).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(x => char.Parse(x)).ToArray();

            int minLength = Math.Min(arr1.Length, arr2.Length);

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        break;
                    }
                    else 
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        if (arr1[i] == arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                        else if (arr1[i] > arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                            break;
                        }
                    }
                    else if(arr1.Length < arr2.Length)
                    {
                        if (arr1[i] == arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                            break;
                        }
                        else if (arr1[i] > arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                            break;
                        }
                    }

                }
            }

        }
    }
}
