using StarWarsPlanetsStats.IO;
using StarWarsPlanetsStats.PlanetApp;
using StarWarsPlanetsStats.DTOs;

string baseAddress = "https://swapi.dev/api/";
string requestUri = "planets";

IUserInteraction consoleUserInteraction = new ConsoleUserInteraction(20);
IApiDataReader planetApiDataReader = new ApiDataReader(baseAddress, requestUri);

PlanetApp planetApp = new PlanetApp(consoleUserInteraction, planetApiDataReader);
try
{
    await planetApp.Run();
}
catch (Exception ex)
{
    consoleUserInteraction.ShowMessage("An error occured.");
    consoleUserInteraction.ShowMessage($"Exception: {ex.Message}");
}

