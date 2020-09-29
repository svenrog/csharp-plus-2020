using System;
using System.Collections.Generic;

namespace Session10Classes
{
    class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public TimeSpan TimeToCook { get; set; } = TimeSpan.FromMinutes(30);

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredient[] newIngredients = new Ingredient[Ingredients.Length + 1];

            Array.Copy(Ingredients, newIngredients, Ingredients.Length);

            newIngredients[Ingredients.Length] = ingredient;

            Ingredients = newIngredients;
        }
    }
}