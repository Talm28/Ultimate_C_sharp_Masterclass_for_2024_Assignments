using System.Runtime.InteropServices;
using System.Text.Json;
using CoockieCoockbook.Coockbook;
using CoockieCoockbook.FileThing;

const string FileName = "recipes";
const FileFormat fileFormat = FileFormat.Json;

ConsolePrinter printer = new ConsolePrinter();
ConsoleUserInteraction userInteraction = new ConsoleUserInteraction(printer);
FileGenerator fileGenerator = new FileGenerator(FileName, fileFormat);
IRecipesFile recipesFile = fileFormat == FileFormat.Text ?
    new RecipeTextFile(fileGenerator.Generate(), printer) :
    new RecipeJsonFile(fileGenerator.Generate(), printer);

Coockbook coockbook = new Coockbook(recipesFile, printer, userInteraction);
coockbook.Start();

public enum FileFormat
{
    Json,
    Text
}

