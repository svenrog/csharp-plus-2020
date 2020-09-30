using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Session11Json
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enklaste sättet att läsa json från fil
            string jsonText = File.ReadAllText("Template.json");

            JToken json = JsonConvert.DeserializeObject<JToken>(jsonText);

            // Skriva json
            Recipe recipe = new Recipe
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Kåldolmar",
                RecipeAddedDate = DateTime.UtcNow,
                TimeToCook = TimeSpan.FromMinutes(30)
            };

            // Serialisera data som JSON, ni behöver skicka med Formatting.Indented för att texten skall indenteras.
            jsonText = JsonConvert.SerializeObject(recipe, Formatting.Indented);

            File.WriteAllText("Recipe.json", jsonText);


            // Läsa JSON med serializer
            JsonSerializer serializer = new JsonSerializer();

            using (Stream stream = new FileStream("Recipe.json", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    using (JsonTextReader textReader = new JsonTextReader(reader))
                    {
                        Recipe deserializedRecipe = serializer.Deserialize<Recipe>(textReader);
                    }
                }
            }
        }
    }
}
