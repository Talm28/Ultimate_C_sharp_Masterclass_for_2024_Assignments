using CookieCookbook.DataAccess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Separator = ",";

    public RecipesRepository(
        IStringsRepository stringsRepository,
        IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        List<string> recipesFromFile = _stringsRepository.Read(filePath);
        return recipesFromFile
            .Select(recipeFromFile => RecipeFromString(recipeFromFile))
            .ToList();
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var ingredient = recipeFromFile.Split(Separator)
            .Select(textualId => _ingredientsRegister.GetById(int.Parse(textualId)));
        return new Recipe(ingredient);
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        _stringsRepository.Write(filePath, allRecipes
            .Select(recipe => string.Join(Separator, recipe.Ingredients
                .Select(ingredient => ingredient.Id))).ToList());
    }
}
