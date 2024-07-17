using System.Text.Json;
using CoockieCoockbook.Coockbook;

namespace CoockieCoockbook.FileThing
{
    public interface IRecipesFile
    {
        public void Read();
        public void Write(List<Ingredient> recipe);

    }
    public class RecipeTextFile : IRecipesFile
    {
        private string _fileName;
        private FileFormat _fileFormat;
        private readonly IPrinter _printer;

        public RecipeTextFile(string fileName, IPrinter printer)
        {
            _fileName = fileName;
            _printer = printer;
        }

        public void Read()
        {
            if(!File.Exists(_fileName))
                return;
            
            List<string>? linesFromtext;
            var fileContent = File.ReadAllText(_fileName);
            linesFromtext = fileContent.Split(Environment.NewLine).ToList();
            if(linesFromtext == null)
                return;
            
            _printer.ShowMassage("Existing recipes are:");
            _printer.ShowMassage("");
            int i = 1;
            foreach(var line in linesFromtext)
            {
                _printer.ShowMassage($"***** {i} *****");
                List<Ingredient> recipe = TypeConvertor.convertStringToRecipe(line);
                _printer.ShowRecipe(recipe);
                _printer.ShowMassage("");
                i++;
            }
        }

        public void Write(List<Ingredient> recipe)
        {
            if(recipe.Count == 0)
                return;

            if(!File.Exists(_fileName))
                File.AppendAllText(_fileName, TypeConvertor.convertRecipeToString(recipe));
            else
                File.AppendAllText(_fileName, Environment.NewLine + TypeConvertor.convertRecipeToString(recipe));
        }   
    }

    public class RecipeJsonFile : IRecipesFile
    {
        private string _fileName;
        private FileFormat _fileFormat;
        private readonly IPrinter _printer;

        public RecipeJsonFile(string fileName, IPrinter printer)
        {
            _fileName = fileName;
            _printer = printer;
        }

        public void Read()
        {
            if(!File.Exists(_fileName))
                return;
            
            List<string>? linesFromtext;
            linesFromtext = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(_fileName));

            if(linesFromtext == null)
                return;
            
            _printer.ShowMassage("Existing recipes are:");
            _printer.ShowMassage("");
            int i = 1;
            foreach(var line in linesFromtext)
            {
                _printer.ShowMassage($"***** {i} *****");
                List<Ingredient> recipe = TypeConvertor.convertStringToRecipe(line);
                _printer.ShowRecipe(recipe);
                _printer.ShowMassage("");
                i++;
            }
        }
        
        public void Write(List<Ingredient> recipe)
        {
            if(recipe.Count == 0)
                return;

            List<string>? fileContent;
            if(File.Exists(_fileName))
            {
                fileContent = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(_fileName));
            }
            else
                fileContent = new List<string>();
            if(fileContent == null)
                return;
            fileContent.Add(TypeConvertor.convertRecipeToString(recipe));
            File.WriteAllText(_fileName, JsonSerializer.Serialize(fileContent));
        }   
    }
}