using AngularWithASP.Server.Data.Models;
using AngularWithASP.Server.Data.Services;

namespace AngularWithASP.Server.Data.Services
{
    public class RecipeService : IRecipeS'ervice

    {
        public void AddRecipe(Recipe newRecipe)
        {
            Data.Recipes.Add(newRecipe);
        }

        public void DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAllRecipes()
        {
            // this format replaces return Data.Recipes.ToList() in C# 12.
            return [.. Data.Recipes];
        }

        public Recipe GetRecipeById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(int id, Recipe newRecipe)
        {
            throw new NotImplementedException();
        }
    }
}
