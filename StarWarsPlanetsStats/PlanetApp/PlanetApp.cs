using StarWarsPlanetsStats.IO;
using StarWarsPlanetsStats.Data;
using StarWarsPlanetsStats.DTOs;
using Microsoft.VisualBasic;

namespace StarWarsPlanetsStats.PlanetApp
{
    public class PlanetApp
    {
        private IUserInteraction _userInteraction;
        private IApiDataReader _apiDataReader;
        private Dictionary<string, Func<Planet, long?>> _propertyNameToSelectorMapping = 
            new Dictionary<string, Func<Planet, long?>>
            {
                {"diameter", planet => planet.Diameter},
                {"surface_water", planet => planet.SurfaceWater},
                {"population", planet => planet.Population}
            };

        public PlanetApp(IUserInteraction userInteraction, IApiDataReader apiDataReader)
        {
            _userInteraction = userInteraction;
            _apiDataReader = apiDataReader;
        }

        public async Task Run()
        {
            // Read api data
            Root? dataRootStracture = null;
            try
            {
                dataRootStracture =  await _apiDataReader.Read();
            }
            catch(HttpRequestException ex)
            {
                _userInteraction.ShowMessage("API request was unseccssesful :(");
                _userInteraction.ShowMessage("Aborting program...");
                System.Environment.Exit(1);
            }
            List<Planet> planets = GetPlanets(dataRootStracture).ToList();
            
            // Write api data
            _userInteraction.ShowPalnetTable(planets);
            // Print message
            _userInteraction.ShowMessage("The statistics of which property would you like to see?");
            foreach(string property in _propertyNameToSelectorMapping.Keys)
                _userInteraction.ShowMessage(property);
            // Get answer
            string? result = _userInteraction.GetMessage();
            // Input check
            if(!_propertyNameToSelectorMapping.Keys.Contains(result))
            {
                _userInteraction.ShowMessage("Invalid choice");
                System.Environment.Exit(1);
            }
            // Get min and max values
            Func<Planet,long?> getProperty = _propertyNameToSelectorMapping[result];
            var minResults = PlanetDataManipulator.GetMinInProperty(planets, result, getProperty);
            var maxResults = PlanetDataManipulator.GetMaxInProperty(planets, result, getProperty);
            
            _userInteraction.ShowMessage($"Max {result} is {maxResults.Item2} (planet: {maxResults.Item1})");
            _userInteraction.ShowMessage($"Min {result} is {minResults.Item2} (planet: {minResults.Item1})");

            _userInteraction.CloseProgram();
        }

        private IEnumerable<Planet> GetPlanets(Root root)
        {
            List<Planet> planets = new List<Planet>();
            foreach(var result in root.results)
            {
                planets.Add(new Planet(result.name, int.Parse(result.diameter), result.surface_water != "unknown" ? int.Parse(result.surface_water) : null, result.population != "unknown" ? long.Parse(result.population) : null));
            }
            return planets;
        }
    }
}