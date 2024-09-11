using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class StonecuttingRecipe : Recipe {
    new public class RecipeResult : Recipe.RecipeResult {
        [JsonPropertyName("count")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Count { get; set; }
    }

    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:stonecutting";
}