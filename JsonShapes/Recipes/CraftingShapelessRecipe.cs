using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class CraftingShapelessRecipe : CraftingSpecial {
    public class RecipeResult : Recipe.RecipeResult {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:crafting_shapeless";

    [JsonPropertyName("group")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Group { get; set; }
    
    [JsonPropertyName("ingredients")]
    public dynamic[]? Ingredients { get; set; }

    [JsonPropertyName("result")]
    public RecipeResult? Result { get; set; }
}