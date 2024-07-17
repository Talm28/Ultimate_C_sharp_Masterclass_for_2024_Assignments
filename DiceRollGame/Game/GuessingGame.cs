namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private const int TrialsNumber = 3;
        private Dice _dice;
        private NumberChoser _numberChoser;
        private NumberValidator _numberValidator;

        public GuessingGame()
        {
            _dice = new Dice(6);
            _numberChoser = new NumberChoser();
            _numberValidator = new NumberValidator();
        }

        public void PlayGame()
        {
            Console.WriteLine($"Dice rolled. Guess what number it shows in {TrialsNumber} tries.");
            for(int i=0 ; i<TrialsNumber ; i++)
            {
                int inputNumber = _numberChoser.Choose();
                _numberValidator.Validate(inputNumber, _dice.number);
            }
            Console.WriteLine("You lose");
        }
    }
}