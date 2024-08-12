
using GameDataParser.GameApp;
using GameDataParser.IO;

ConsolePrinter printer = new ConsolePrinter();
userConsoleInteraction userInteraction = new userConsoleInteraction(printer);
JsonReader reder = new JsonReader(printer);

App app = new App(printer, userInteraction, reder);
app.Run();