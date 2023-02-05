using System;

namespace SnakesAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*_________Sankes And Ladder_________*");
            Console.Write("Enter First 1st Player name: "); string name = Console.ReadLine();
            Console.Write("Enter First 1st Player name: "); string name_ = Console.ReadLine();
            int startPosition = 0;

            Player player_one = new Player(name, 1, startPosition, 0, false);
            Player player_two = new Player(name_, 2, startPosition, 0, false);

            Player player = Play(player_one, player_two);

            Console.WriteLine($"{player.name} Has won the game after {player.number_of_dies} rolls");

            Console.ReadKey();
        }

        static Player Play(Player player_one, Player player_two)
        {
            Player player = player_one;
            while (player_one.position <= 100 && player_two.position <= 100)
            {

                Console.WriteLine($"\n>>>{player.name}'s turn");
                Console.WriteLine($"You are at position : {player.position}. You have rolled die {player.number_of_dies} times");

                Game game = new Game();
                int roll = game.Roll(player);
                player.position = game.AfterRoll(roll, player.position, out player.got_ladder);

                if (player.position < 0)
                {
                    Console.WriteLine("**You went under zero starting Again**");
                    player.position = 0;
                }
                if (player.position == 100)
                    break;

                player = game.ChangePlayer(player, player_one, player_two);

                Console.WriteLine($"\n{player_one.name}'s position: {player_one.position}. {player_two.name}'s postion: {player_two.position}");
            }
            return player;
        }
    }
}
