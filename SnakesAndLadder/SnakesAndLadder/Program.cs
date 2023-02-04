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

            Console.WriteLine($"You are at position : {player_One.position}");

            Console.ReadKey();
        }
    }
}
