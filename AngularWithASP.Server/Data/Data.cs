using AngularWithASP.Server.Data.Models;

namespace AngularWithASP.Server.Data
{
    public static class Data
    {
        public static List<Recipe> Recipes { get; } = [
            new()
            {
                Id = 1,
                Title = "Gumbo",
                Description = "A cajun stew inspired by Louisiana and Mississippi",
                Ingredients = [
                    "Vegetable Oil",
                    "Flour",
                    "filé powder (sassafras leaves)",
                    "onions",
                    "bell pepper",
                    "celery",
                    "olive oil",
                    "butter",
                    "salt, pepper, garlic powder, red pepper flakes",
                    "kielbasa or andouille or smoked sausage",
                    "Chicken wingettes/drumettes",
                    "Large, peeled, deveined shrimp (optional, lump crab meat)",
                    "Zatarain’s crab boil",
                    "Water or chicken broth (step 5b)",
                    "Parsley",
                    "Old Bay Seasoning"
                    ],
                Instructions = [

                    ],

            }
        ];
    }
}