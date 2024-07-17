namespace CoockieCoockbook.Coockbook
{
    public interface IPrinter
    {
        public void ShowMassage(string massage);
        public void ShowIngredients();
        public void ShowRecipe(List<Ingredient> recipe);
    }

    public class ConsolePrinter : IPrinter
    {
        public void ShowIngredients()
        {
            foreach(Ingredient ingredient in IngredientController.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        public void ShowMassage(string massage)
        {
            Console.WriteLine(massage);
        }

        public void ShowRecipe(List<Ingredient> recipe)
        {
            if(recipe.Count() == 0)
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
                return;
            }

            foreach(Ingredient ingredient in recipe)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.PrepInstruction}");
            }
        }
    }
}