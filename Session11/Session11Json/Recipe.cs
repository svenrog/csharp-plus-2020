using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Session11Json
{
    class Recipe
    {
        //[JsonProperty("id")]
        public string Id { get; set; }

        //[JsonProperty("name")]
        public string Name { get; set; }
        
        //[JsonProperty("time")]
        public TimeSpan TimeToCook { get; set; }

        //[JsonProperty("added")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime RecipeAddedDate { get; set; }
    }
}
