using System;
namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Using default constructor
            Player p1 = new Player();
            Console.WriteLine("Player 1 -> Name: " + p1.playerName + ", Level: " + p1.level + ", Health: " + p1.health);

            // 2. Using parameterized constructor
            Player p2 = new Player("Samir", 5, 100);
            Console.WriteLine("Player 2 -> Name: " + p2.playerName + ", Level: " + p2.level + ", Health: " + p2.health);

            Console.ReadLine();
        }
    }
}
