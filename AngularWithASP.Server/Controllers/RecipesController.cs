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
        [HttpPut]
        public IActionResult UpdateRecipe()
    }
}