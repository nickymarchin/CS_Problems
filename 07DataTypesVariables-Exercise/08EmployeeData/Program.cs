using System;

namespace _08EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            long id = 8306112507;
            int employeeNum = 27563571;

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", employeeNum);
        }
    }
}
