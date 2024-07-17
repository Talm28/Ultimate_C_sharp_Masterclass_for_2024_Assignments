using CoockieCoockbook.FileThing;

namespace CoockieCoockbook.Coockbook
{
    public class Coockbook
    {
        private List<Ingredient> _recipe;
        private IRecipesFile _recipeFile;
        private readonly IPrinter _printer;
        private readonly IUserInteraction _userInteraction;

        public Coockbook(IRecipesFile recipesFile, IPrinter printer, IUserInteraction userInteraction)
        {
            _recipe = new List<Ingredient>();
            _recipeFile = recipesFile;
            _printer = printer;
            _userInteraction = userInteraction;
        }

        public void Start()
        {
            _recipeFile.Read();
            _printer.ShowMassage("Create a new cookie recipe! Available ingredients are:");
            _printer.ShowIngredients();
            _recipe = _userInteraction.GetRecipe();
            if(_recipe.Count > 0)
                Console.WriteLine("Recipe added:");
            _printer.ShowRecipe(_recipe);
            _recipeFile.Write(_recipe);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}