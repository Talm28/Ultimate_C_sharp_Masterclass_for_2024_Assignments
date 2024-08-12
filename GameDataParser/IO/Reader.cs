using System.Text.Json;
using GameDataParser.Logging;
using GameDataParser.Model;

namespace GameDataParser.IO
{
    public interface IReader
    {
        public List<Game>? Read(string fileName, Logger log);
    }

    public class JsonReader : IReader
    {
        private IPrinter _printer;

        public JsonReader(IPrinter printer)
        {
            _printer = printer;
        }

        public List<Game>? Read(string fileName, Logger log)
        {
            string fileContent = File.ReadAllText(fileName);
            List<Game>? games = new List<Game>();
            try
            {
                games = JsonSerializer.Deserialize<List<Game>>(fileContent);
            }
            catch (Exception ex)
            {
                _printer.ShowError($"JSON in the {fileName} was not in a valid format. JSON body:");
                _printer.ShowError(fileContent);
                _printer.ShowMassage("Sorry! The application has experienced an unexpected error and will have to be closed.");
                throw ex;
            }
            return games;
        }
    }
}
