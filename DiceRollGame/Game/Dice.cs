namespace DiceRollGame.Game
{
    public class Dice
    {
        public readonly int number;
        private Random _rnd;

        public Dice(int sides)
        {
            _rnd = new Random();
            number = _rnd.Next(1, sides + 1);
        }
    }
}