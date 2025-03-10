using AngularWithASP.Server.Data.Models;
using System.Runtime.CompilerServices;

namespace AngularWithASP.Server.Data
{
    public static class Data
    {
        public static List<Recipe> Recipes { get; } = [
            new()
            {
                Id = 1,
                Title = "Gumbo",
                Description = "A cajun stew inspired by Louisiana and Georgia",
                Details = "This is an original family gumbo recipe written down by Mia Maxie Bieniemy. The recipe comes from " +
                          "her family: Maxie (Dad, LA) and Ponder (Mom, GA)",
                Category = "Cajun stew",
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
                    "1.  Make a Roux. Equal parts vegetable oil and flour. I use about 4 cups each for a large pot. Stir in a medium (almost high) heat. I like a black cast iron skillet and a wooden spoon. Stay at the stove and stir non-stop for about 45 minutes. It should look like chocolate when ready. Add in 3-4 tablespoons filé powder once done (sassafras leaves). Set aside to cool until manageable. It gets very hot and smoky (prepare vent or fan or open window)",
                    "2.  Sauté a skillet full of onions, bell pepper and celery coarsely chopped (medium dice). I use olive oil and top with 1-2 tbsp butter for flavor. Season to taste with salt, pepper and garlic powder. I also addin in red pepper flakes for a kick (optional).  2-3 onions/2-3 green peppers/8-16 celery stalks",
                    "3.  Cut up kielbasa (or smoked sausage and set aside). I use a minimum of 5-10 lbs.",
                    "4.  Prep chicken wings(wingettes)/drummettes to be added in. Season liberally. I try to match the kielbasa amount chose ~5-10 lbs. Set aside",
                    "5.  Prep Seafood.",
                    "    a.  I like large, peeled and deveined shrimp: again match kielbasa for amount 5-10 lbs. If you will also use lump crab meat or claw meat you can use 2 ½ - 5 lbs of shrimp and then 2 ½ -5 lbs crab.  Set aside. (optional: 6-8 crab legs for extra indulgence and/or garnish)",
                    "    b.  In a separate pot, prepare your seasoned water or chicken broth by adding in Zatarain’s Crab Boil. Use 1 large seasoning packet per gallon of water. Follow directions on the box. Boil packet in water long enough to release all of the goodness into your seasoned water or chicken broth. I also like to use 1 large bay leaf per ½ gallon or so of liquid",
                    "6.  Combine steps 1 through 4 in a gigantic pot. Cover with seasoned water or chicken broth (garlic powder/salt/pepper)."+
                    "    Bring to a boil. Only after it boils will you be able to determine how thick the roux will make the gumbo. Some people like it almost like gravy. Others like it a bit thinner.  Add more broth until you reach your desired consistency",
                    "7.  Boil items 1-4 for at least an hour or 1 ½. Start to adjust seasonings as you taste. (medium simmer is good)",
                    "8.  Your last step is to add in the seafood that you’ve chosen in step 5A. I like to season it with lots of garlic powder/parsley/black pepper and Old Bay Seasoning for the saltiness",
                    "9.  Bring all items to a simmer and let them marry for at least 15-30 minutes. Finish by garnishing with parsley and hot sauce. Server over rice and hope you enjoy!"

                    ]
            },
            new()
            {
                Id = 2,
                Title = "Steak Fajitas",
                Description = "Quick and easy fajitas as a main course",
                Details = "These are originally made with beef, but you can use chicken or shrimp instead."+
                          "Aside from protein, are made with peppers, onions and tortillas.",
                Category = "Stir fry",
                Ingredients = [
                    "2 pounds skirt, flank, sirloin or hanger steak sliced into 1/2 inch strips",
                    "1 red pepper deseeded and sliced into thin strips",
                    "1 bell pepper deseeded and sliced into thin strips",
                    "1 medium onion peeled and sliced into thin strips (optional - some can't eat onions)",
                    "3 tbsp olive oil",
                    "1 tbsp lime juice",
                    "1/2 tsp chili powder",
                    "1 tsp ground cumin",
                    "pinch cayenne pepper (optional - some don't like heat",
                    "1/2 tsp salt",
                    "1/2 tsp ground black pepper",
                    "2 tsp minced garlic",
                    "6-8 warm tortillas",
                    "2 sealable food-safe bags"
                    ],
                Instructions = [
                    "1. Place the meat into a sealable bag. Place the peppers and onion in a separate sealable bag. "+
                    "Put the olive oil, lime juice, chili powder, cumin, cayenne pepper, salt, black pepper and garlic "+
                    "in a jar with a screw top or tight fitting lid. Shake until well mixed.  Pour 1/3 of the marinade "+
                    "over the meat, 1/3 over the vegetables, and leave the remaining in the jar for use when cooking. " +
                    "Seal the bags and refrigerate for at least an hour (you can leave in overnight if desired",
                    "2. Heat a large skillet over medium-high heat. Pour the vegetables into the skill and cook until "+
                    "just tender crisp, approximately 5 minutes.  Remove from the skillet and put on a plate.",
                    "3. Place the meat into the same skillet.  When it is cooked throughout, add the vegetables and "+
                    "the remaining marinade back to the skillet.  Remove from heat.",
                    "4. Serve with the warm tortillas and any desired garnishes (e.g., cilantro)"
                    ]
            },
            new()
            {
                Id=3,
                Title = "Dry cure for Bacon",
                Description = "Dry cure for bacon used prior to smoking",
                Details = "This cure is applied to pork belly before somking. It makes 660g of cure " +
                          "though you can make more, just keep the ratios correct. In this situation, weight ratios " +
                          "are more important than volume.",
                Category = "Cure",
                Ingredients = [
                    "400g Kosher salt",
                    "200g granulated sugar",
                    "60g curing salt (Prague Powder #1)"
                    ],
                Instructions = [
                    "Mix the ingredients well.",
                    "Place in an airtight container to prevent moisture getting in."
                    ]
            },
            new()
            {
                Id = 4,
                Title = "Homemade Bacon",
                Description = "Basic homemade bacon without extra ingredients",
                Details = "You can make bacon from (unsliced) cured pork belly and a smoker. Steps include how much "+
                          "cure to use based on weight making it flexible.",
                Category = "smoked food",
                Ingredients = [
                    "Whole pork belly (weight can vary)",
                    "Dry cure for bacon",
                    "Large, sealable food-safe bag (2 gallon works great for 9ish lbs of belly)"
                    ],
                Instructions = [
                    "1. Weigh the pork belly, using grams as the measurement",
                    "2. Calcuate how much cure is needed as 2.5% of the weight of the meat.  E.g., 9lb (4082.33 grams) "+
                    "of pork belly, use 102.06 grams of the dry cure.",
                    "3. Coat the pork belly fully with the cure",
                    "4. Place the belly in a food-save bag. If your bag isn't big enough, you can cut it into smaller pieces",
                    "5. Remove excess air, but do not vacuum seal",
                    "6. Place in refrigerator for at least a week, turning it over ever 1-2 days. Liquid will form, this is normal.",
                    "7. Remove from bag, patting it dry gently",
                    "8. Smoke at 200 degrees Fahrenheit until the meat reaches an internal temperature of 150F",
                    "9. Allow to cool  Wrap tightly in plastic wrap and place in the refrigerator for 24 hours",
                    "10. Slice to prefer thickness, and cook.  It is edible after reaching 150F internal, but not necessarily " +
                    "pleasing to eat."
                    ]
            }
        ];
    }
}