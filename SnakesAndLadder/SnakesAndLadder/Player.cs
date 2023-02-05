namespace SnakesAndLadder
{
    public class Player
    {
        public string name;
        public int number;
        public int position;
        public int number_of_dies;
        public bool got_ladder;

        public Player(string name, int number, int position, int number_of_dies, bool got_ladder)
        {
            this.position = position;
            this.number_of_dies = number_of_dies;
            this.name = name;
            this.got_ladder = got_ladder;
            this.number = number;
        }
    }
}
