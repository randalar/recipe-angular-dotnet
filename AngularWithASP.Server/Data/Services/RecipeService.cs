using AngularWithASP.Server.Data.Models;
using AngularWithASP.Server.Data.Services;

namespace AngularWithASP.Server.Data.Services
{
    public class RecipeService : IRecipeService

    {
        public void AddRecipe(Recipe newRecipe)
        {
            Data.Recipes.Add(newRecipe);
        }

        public void DeleteRecipe(int id)
        {
            var recipe = Data.Recipes.FirstOrDefault(n => n.Id == id);
            if (recipe != null)
            {
                Data.Recipes.Remove(recipe);
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            // this format replaces return Data.Recipes.ToList() in C# 12.
            return [.. Data.Recipes];
        }

        public Recipe GetRecipeById(int id)
        {
            return Data.Recipes.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateRecipe(int id, Recipe newRecipe)
        {
            var oldRecipe = Data.Recipes.FirstOrDefault(n => n.Id == id);
            
            if (oldRecipe != null)
            {
                oldRecipe.Title = newRecipe.Title;
                oldRecipe.Category = newRecipe.Category;
                oldRecipe.Description = newRecipe.Description;
                oldRecipe.Details = newRecipe.Details;
                oldRecipe.Ingredients = newRecipe.Ingredients;
                oldRecipe.Instructions = newRecipe.Instructions;

            }

        }
    }
}
