using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class SmithingTransformRecipe : SmithingTrimRecipe {
    public class RecipeResult : Recipe.RecipeResult {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:smithing_transform";

    [JsonPropertyName("result")]
    public RecipeResult? Result { get; set; }
}