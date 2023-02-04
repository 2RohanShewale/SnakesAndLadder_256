﻿using System;

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
                Console.WriteLine($"\nYou are at position : {player_One.position}");
                Console.WriteLine("Press any key to roll"); Console.ReadKey();
                int roll = rand.Next(1, 7);
                Console.WriteLine($"\nYou have Rolled {roll}");
                Game game = new Game();
                player_One.position = game.AfterRoll(roll, player_One.position);
            }

            Console.ReadKey();
        }
    }
}
