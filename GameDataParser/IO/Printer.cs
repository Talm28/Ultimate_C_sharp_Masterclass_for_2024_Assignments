using GameDataParser.GameApp;
using GameDataParser.Model;

namespace GameDataParser.IO
{
    public interface IPrinter
    {
        public void ShowMassage(string message);
        public void ShowError(string error);
        public void ShowGames(List<Game> games);
        public void CloseProgram();
    }

    public class ConsolePrinter : IPrinter
    {
        public void ShowMassage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowError(string error)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = originalColor;
        }

        public void ShowGames(List<Game> games)
        {
            if(games.Count == 0)
            {
                Console.WriteLine("No games are present in the input file.”");
                return;
            }
            foreach(Game game in games)
            {
                Console.WriteLine(game);
            }
        }

        public void CloseProgram()
        {
            ShowMassage("Press any key to close.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}