using AngularWithASP.Server.Data.Models;

namespace AngularWithASP.Server.Data.Services
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        void UpdateRecipe(int id, Recipe newRecipe);
        void DeleteRecipe(int id);
        void AddRecipe(Recipe newRecipe);

    }
}