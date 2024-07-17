namespace CoockieCoockbook.Coockbook
{
    public interface IUserInteraction
    {
        public List<Ingredient> GetRecipe();

        public Ingredient getIngredientByUser();
    }

    public class ConsoleUserInteraction : IUserInteraction
    {
        private readonly IPrinter _printer;

        public ConsoleUserInteraction(IPrinter printer)
        {
            _printer = printer;
        }

        public List<Ingredient> GetRecipe()
        {
            List<Ingredient> recipe = new List<Ingredient>();
            Ingredient ingredient;
            do
            {
                _printer.ShowMassage("Selecting ingredients for a new recipe");
                ingredient = getIngredientByUser();
                if(ingredient.Id != -1)
                    recipe.Add(ingredient);
            }while(ingredient.Id != -1);
            return recipe;
        }

        public Ingredient getIngredientByUser()
        {
            int index = 0;
            bool isParsable;
            do
            {
                string? userInput = Console.ReadLine();
                isParsable = int.TryParse(userInput, out index);
                if(isParsable)
                {
                    Ingredient ingredient = IngredientController.GetIngredientById(index);  
                    if(ingredient.Id == -1)
                        continue;                     
                    return ingredient;
                }
            }while(isParsable);
            
            return new Ingredient(-1, "error", "error");
        }
    }
}