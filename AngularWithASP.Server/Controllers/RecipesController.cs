using AngularWithASP.Server.Data.Services;
using AngularWithASP.Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularWithASP.Server.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController(IRecipeService service) : Controller
    {
        private readonly IRecipeService _service = service;

        // Create/add new recipe
        [HttpPost("AddRecipe")]
        public IActionResult AddRecipe([FromBody]Recipe recipe)
        {
            _service.AddRecipe(recipe);
            return Ok("Added");
        }

        // Read (get) all recipes
        [HttpGet("[action]")]
        public IActionResult GetRecipes()
        {
            var allRecipes = _service.GetAllRecipes();
            return Ok(allRecipes);
        }

        // Update an existing recipe
        [HttpPut("UpdateRecipe/{id}")]
        public IActionResult UpdateRecipe(int id, [FromBody]Recipe recipe)
        {
            _service.UpdateRecipe(id, recipe);
            return Ok(recipe);
        }

        // Delete a recipe
        [HttpDelete("DeleteRecipe/{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            _service.DeleteRecipe(id);
            return Ok();
        }

        [HttpGet("SingleRecipe/{id}")]
        public IActionResult GetRecipeById(int id)
        {
            var recipe = _service.GetRecipeById(id);
            return Ok(recipe);
        }
    }
}