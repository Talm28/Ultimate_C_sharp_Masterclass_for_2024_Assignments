using StarWarsPlanetsStats.Data;
using StarWarsPlanetsStats.DTOs;

namespace StarWarsPlanetsStats.IO
{
    public interface IUserInteraction
    {
        void ShowMessage(string message);
        string? GetMessage();
        void CloseProgram();
        void ShowPalnetTable(IEnumerable<Planet> planets);
    }

    public class ConsoleUserInteraction : IUserInteraction
    {
        private int _printPadding;

        public ConsoleUserInteraction( int printPedding)
        {
            _printPadding = printPedding;
        }

        public string? GetMessage()
        {
            return Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void CloseProgram()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

        public void ShowPalnetTable(IEnumerable<Planet> planets)
        {
            // Print properties
            var planetProperties = typeof(Planet).GetProperties();
            var planetPropertiesNames = planetProperties
                                        .Select(property => property.Name)
                                        .Select(property => property.PadRight(_printPadding))
                                        .ToList();
            Console.WriteLine(string.Join("|", planetPropertiesNames));
            // Print saperator
            Console.WriteLine(new string('-', planetPropertiesNames.Count() * _printPadding));
            //Print planets
            foreach(Planet planet in planets)
            {
                foreach( var property in planetProperties)
                {
                    var propertyValue = property.GetValue(planet);
                    string propertyValueString = propertyValue != null ? propertyValue.ToString() : "";
                    Console.Write(propertyValueString.PadRight(_printPadding) + '|');
                }
                Console.WriteLine();
            }
        }
    }
}