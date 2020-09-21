using Newtonsoft.Json.Linq;
using System;

namespace Session09Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject recipeData = RecipeScraper.GetRecipeData("https://www.koket.se/rostad-tomatsoppa");
        }
    }
}
