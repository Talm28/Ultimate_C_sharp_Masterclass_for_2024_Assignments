using CoockieCoockbook.Coockbook;

namespace CoockieCoockbook.FileThing
{
    public static class TypeConvertor
    {
        public static List<Ingredient> convertStringToRecipe(string line)
        {
            List<string> indexesString = line.Split(",").ToList();
            List<int> indexes = new List<int>();
            List<Ingredient> recipe = new List<Ingredient>();
            foreach(string number in indexesString)
                indexes.Add(int.Parse(number));
            foreach(int index in indexes)
                recipe.Add(IngredientController.GetIngredientById(index));
            return recipe;
        }
        public static string convertRecipeToString(List<Ingredient> recipe)
        {
            List<string> idList = new List<string>();
            foreach(Ingredient ingredient in recipe)
            {
                idList.Add(ingredient.Id.ToString());
            }
            return string.Join(",", idList);
        }
    }
}