using System;

namespace Exercise1Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gosho";
            int age = 5;

            Console.WriteLine("Name: " + name + ", Age: " + (age + 15));
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
            Console.WriteLine($"Name: {name}, Age: {age}");

        }
    }
}
