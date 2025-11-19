using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------ DAY TYPE CHECK ------------------
            Console.Write("Enter a day (e.g., Sunday): ");
            string inputDay = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            // Weekend if Friday or Saturday
            if (inputDay == "friday" || inputDay == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");
            Console.WriteLine();

            // ------------------ BOOK RECORD ------------------
            // Create first book object
            Book book1 = new Book("C# Basics", "Samir Bhandari", 499.99);

            // Create second book using 'with' expression
            Book book2 = book1 with { Title = "Advanced C#", Price = 699.99 };

            // Print first object
            Console.WriteLine("First Book:");
            Console.WriteLine(book1);
            Console.WriteLine();

            // Deconstruct second object
            var (title, author, price) = book2;

            Console.WriteLine("Second Book (Deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
