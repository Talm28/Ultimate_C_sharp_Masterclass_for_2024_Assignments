using GameDataParser.IO;
using GameDataParser.Logging;
using GameDataParser.Model;

namespace GameDataParser.GameApp
{
    public class App
    {
        private IPrinter _printer;
        private IUserInteraction _userInteraction;
        private IReader _reader;
        private Logger _log;

        public App(IPrinter printer, IUserInteraction userInteraction, IReader reader)
        {
            _printer = printer;
            _userInteraction = userInteraction;
            _reader = reader;

            _log = new Logger();
        }

        public void Run()
        {
            try
            {
                _printer.ShowMassage("Enter the name of the file you want to read:");
                string fileName = _userInteraction.GetFileName();
                List<Game>? games = _reader.Read(fileName, _log);
                _printer.ShowGames(games);
                _printer.CloseProgram();
            }
            catch(Exception ex)
            {
                _log.Message(ex);
                _printer.CloseProgram();
            }      
        }
    }
}
