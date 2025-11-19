namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object
            Calculator calc = new Calculator();

            // Calling PrintWelcome()
            calc.PrintWelcome();

            // Calling Add()
            int sum = calc.Add(10, 5);
            Console.WriteLine("Addition Result: " + sum);

            // Calling Multiply() with two parameters
            int product1 = calc.Multiply(10, 5);
            Console.WriteLine("Multiplication (10 * 5): " + product1);

            // Calling Multiply() with one parameter (optional parameter used)
            int product2 = calc.Multiply(10);
            Console.WriteLine("Multiplication (10 * default 1): " + product2);

            Console.ReadLine();
        }
    }
}
