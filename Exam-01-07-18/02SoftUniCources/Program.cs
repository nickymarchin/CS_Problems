using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SoftUniCources
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string line = Console.ReadLine();

            while (line != "course start")
            {
                string[] tokens = line.Split(":").ToArray();

                string command = tokens[0];

                if (command == "Add")
                {
                    if (courses.Contains(tokens[1]) == false)
                    {
                        courses.Add(tokens[1]);
                    }
                }
                else if (command == "Insert")
                {
                    string course = tokens[1];

                    int index = int.Parse(tokens[2]);

                    if (courses.Contains(course) == false)
                    {
                        if (index >= 0 && index <= courses.Count)
                        {
                            courses.Insert(index, course);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    string course = tokens[1];
                    courses.Remove(course);

                    if (courses.Contains($"{course}-Exercise"))
                    {
                        courses.Remove($"{course}-Exercise");

                        if (courses.Contains($"{course}-Exercise"))
                        {
                            courses.Remove($"{course}-Exercise");
                        }
                    }
                }
                else if (command == "Swap")
                {
                    string firstCourse = tokens[1];
                    string secondCourse = tokens[2];

                    if (courses.Contains(firstCourse) && courses.Contains(secondCourse) && firstCourse != secondCourse)
                    {
                        int index1 = courses.IndexOf(firstCourse);
                        int index2 = courses.IndexOf(secondCourse);

                        courses.Remove(firstCourse); ////////// 50 min tuka
                        courses.Insert(index2, firstCourse);

                        courses.Remove(secondCourse);
                        courses.Insert(index1, secondCourse);

                        if (courses.Contains($"{firstCourse}-Exercise"))
                        {
                            courses.Remove($"{firstCourse}-Exercise");
                            courses.Insert(courses.IndexOf(firstCourse) + 1, $"{firstCourse}-Exercise");
                        }

                        if (courses.Contains($"{secondCourse}-Exercise"))
                        {
                            courses.Remove($"{secondCourse}-Exercise");
                            courses.Insert(courses.IndexOf(secondCourse) + 1, $"{secondCourse}-Exercise");
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (courses.Contains(tokens[1]))
                    {
                        if (courses.Contains($"{tokens[1]}-Exercise") == false)
                        {
                            courses.Insert(courses.IndexOf(tokens[1]) + 1, $"{tokens[1]}-Exercise");
                        }
                    }
                    else
                    {
                        courses.Add(tokens[1]);
                        courses.Add($"{tokens[1]}-Exercise");
                    }
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i+1}.{courses[i]}");
            }
        }
    }
}
