using System;

namespace SnakesAndLadder
{
    public class Game
    {
        public int Roll(Player player)
        {
            Random rand = new Random();
            Console.WriteLine("Press any key to roll");
            Console.ReadKey();
            player.number_of_dies++;
            int roll = rand.Next(1, 7);
            Console.WriteLine($"\nYou have Rolled \"{roll}\"");
            return roll;
        }
        public int AfterRoll(int roll, int position, out bool got_Ladder)
        {
            got_Ladder = false;
            Console.WriteLine("Options: 1.NoPlay 2.Ladder 3.Snake");
            Console.WriteLine($"Press key to continue"); Console.ReadKey();
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1: position = Ladder(roll, position); got_Ladder = true; break;
                case 2: position = Snake(roll, position); break;
                case 3: NoPlay(); break;
            }
            return position;
        }
        public int Ladder(int roll, int position)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You got ladder. You get to play again");
            Console.ResetColor();
            if ((roll + position) > 100)
            {
                Console.WriteLine("\nYou went over 100. You can't use ladder"); return position;
            }
            return roll + position;
        }
        public int Snake(int roll, int position)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You got Snake");
            Console.ResetColor();
            return position - roll;
        }
        public void NoPlay()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("NO Play");
            Console.ResetColor();
        }

        public Player ChangePlayer(Player player, Player player_one, Player player_two)
        {
            if (!player.got_ladder)
            {
                if (player.number == 1)
                    return player_two;
                else
                    return player_one;
            }
            return player;
        }
    }
}
