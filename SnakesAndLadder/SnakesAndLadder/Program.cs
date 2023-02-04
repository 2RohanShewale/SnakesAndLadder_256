using System;

namespace SnakesAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*_________Sankes And Ladder_________*");
            int startPosition = 0;

            Player player_One = new Player(startPosition);
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine($"You are at position : {player_One.position}");
                Console.WriteLine("Press any key to roll"); Console.ReadKey();
                int roll = rand.Next(0, 7);
                Console.WriteLine($"You have Rolled {roll}");
                player_One.position += roll;
                
            }

            Console.ReadKey();
        }
    }
}
