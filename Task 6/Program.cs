using System;
namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asking user to input marks
            Console.Write("Enter marks: ");
            bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);  // using int.TryParse to validate input

            // asking user to enter total
            Console.Write("Enter total: ");
            bool isTotalValid = int.TryParse(Console.ReadLine(), out int total); // using int.TryParse to validate input

            // checking if both inputs are valid integers
            if (!isMarksValid || !isTotalValid || total == 0) // total cannot be 0
            {
                Console.WriteLine("Invalid input! Required integers and total cannot be 0.");
                return; // exit the program if input is invalid
            }

            // ----------------- BREAKPOINT 1 -----------------
            // Set breakpoint here to check marks and total before calculation

            // calculating percentage (corrected with casting to double)
            double percentage = (double)marks / total * 100;

            // ----------------- BREAKPOINT 2 -----------------
            // Set breakpoint here to check value of percentage after calculation

            // printing the percentage
            Console.WriteLine($"Percentage is {percentage}");

            /* 1. Why is the output incorrect?
             * Ans: The output is incorrect (percentage shows 0) if we do not cast, because integer division is performed 
             *      when calculating percentage (marks / total * 100). Both marks and total are integers, 
             *      so the decimal part is truncated.
             *
             * 2. How can we correct the program?
             * Ans: We can correct the program by casting either marks or total to double, 
             *      so that floating-point division is performed instead of integer division.
             */
        }
    }
}
