namespace DiceRollGame.Game
{
    public class NumberValidator
    {
        public void Validate(int input, int answer)
        {
            if(input == answer)
            {
                Console.WriteLine("You win");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Wrong number");
        }
    }
}