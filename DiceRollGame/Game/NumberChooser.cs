namespace DiceRollGame.Game
{
    public class NumberChoser
    {
        public int Choose()
        {
            int number = 0;
            string? input = ""; // The "?" fix null issue in ReadLine() later.
            do
            {
                Console.WriteLine("Enter number:");
                input = Console.ReadLine();
            }while(input == null || !ValidateNumber(input, out number));
            return number;
        }

        private bool ValidateNumber(string input, out int number)
        {
            bool isValid = int.TryParse(input, out number);
            if(!isValid)
            {
                Console.WriteLine("Incorrect input");
                return false;
            }
            return true;
                
        }
    }
}