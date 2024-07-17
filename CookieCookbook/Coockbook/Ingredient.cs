namespace CoockieCoockbook.Coockbook
{
    public class Ingredient
    {
        public int Id { get; }
        public string Name { get; }
        public string PrepInstruction { get; }

        public Ingredient(int newId, string newName, string newPrep)
        {
            Id = newId;
            Name = newName;
            PrepInstruction = newPrep;
        }

        public override string ToString() => $"{Id}. {Name}";
    }

    public static class IngredientController
    {
        public static List<Ingredient> Ingredients { get; } = new List<Ingredient>(){
            new Ingredient(1, "Wheat flour", "Sieve. Add to other ingredients."),
            new Ingredient(2, "Coconut flour", "Sieve. Add to other ingredients."),
            new Ingredient(3, "Butter", "Melt on low heat. Add to other ingredients."),
            new Ingredient(4, "Chocolate", "Melt in a water bath. Add to other ingredients."),
            new Ingredient(5, "Sugar", "Add to other ingredients."),
            new Ingredient(6, "Cardamom", "Take half a teaspoon. Add to other ingredients."),
            new Ingredient(7, "Cinnamon", "Take half a teaspoon. Add to other ingredients."),
            new Ingredient(8, "Cocoa powder", "Add to other ingredients.")
        };

        public static Ingredient GetIngredientById(int id)
        {
            foreach(Ingredient ingredient in Ingredients)
            {
                if(id == ingredient.Id)
                    return ingredient;
            }
            return new Ingredient(-1, "error", "error");
        }
    }
}