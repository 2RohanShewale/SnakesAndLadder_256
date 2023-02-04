using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadder
{
    public class Game
    {
        public int AfterRoll(int roll, int position)
        {
            Console.WriteLine("Options: 1.NoPlay 2.Ladder 3.Snake");
            Console.WriteLine($"Press key to continue"); Console.ReadKey();
            Random random= new Random();
            int option = random.Next(1,4);
            switch (option)
            {
                case 1: position = Ladder(roll,position); break;
                case 2: position = Snake(roll,position); break;
                case 3: NoPlay(); break;
            }
            return position;
        }
        public int Ladder(int roll, int position)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("You got ladder");
            Console.ResetColor();
            if ((roll + position) > 100)
            {
                Console.WriteLine("\nYou went over 100. You can't use ladder"); return position;
            }
            return roll + position;
        }
        public int Snake(int roll, int position)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("You got Snake");
            Console.ResetColor();
            return position - roll;
        }
        public void NoPlay()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("NO Play");
            Console.ResetColor();
        }
    }
}
