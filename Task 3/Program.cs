using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDemo demo = new ParameterDemo();

            // --- 1. Using ref ---
            int value = 20;
            demo.Increase(ref value);
            Console.WriteLine("After Increase (ref): " + value);

            // --- 2. Using out ---
            string myFullName;
            demo.GetFullName(out myFullName);
            Console.WriteLine("Full Name (out): " + myFullName);

            // --- 3. Using params ---
            int total = demo.SumAll(5, 10, 15, 20);
            Console.WriteLine("Sum of All Numbers (params): " + total);

            Console.ReadLine();
        }
    }
}
