using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first student object
            Student s1 = new Student();
            s1.name = "Samir";
            s1.age = 21;
            s1.faculty = "Computing";

            // Creating second student object
            Student s2 = new Student();
            s2.name = "Bikash";
            s2.age = 22;
            s2.faculty = "Business";

            // Display Student 1 details
            Console.WriteLine("---- Student 1 ----");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Faculty: " + s1.faculty);

            // Display Student 2 details
            Console.WriteLine("\n---- Student 2 ----");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Faculty: " + s2.faculty);

            // Display static field
            Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);

            Console.ReadLine();
        }
    }
}
