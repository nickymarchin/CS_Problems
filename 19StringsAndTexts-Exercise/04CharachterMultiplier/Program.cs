using System;

namespace _04CharachterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];

            int result = CharachterMultiplier(str1, str2);

            Console.WriteLine(result);
        }

        static int CharachterMultiplier(string str1, string str2)
        {
            int sum = 0;

            int minLength = Math.Min(str1.Length, str2.Length);
            int maxLength = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += (str1[i] * str2[i]);
            }

            // a aaaa
            if (str1.Length != str2.Length)
            {
                string longer = str1.Length > str2.Length ? str1 : str2;

                for (int i = minLength; i < longer.Length; i++)
                {
                    sum += longer[i];
                }
            }

            return sum;
        }
    }
}
