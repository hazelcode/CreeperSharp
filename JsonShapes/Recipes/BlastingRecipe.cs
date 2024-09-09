using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class BlastingRecipe {
    public class RecipeIngredient {
        [JsonPropertyName("item")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Item { get; set; }

        [JsonPropertyName("tag")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemTag { get; set; }
    }
    public class Result {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("components")]
        public Dictionary<string, dynamic>? Components { get; set; }
    }
    
    [JsonPropertyName("type")]
    public string Type { get; set; } = "minecraft:blasting";

    [JsonPropertyName("ingredient")]
    public dynamic? Ingredient { get; set; }

    [JsonPropertyName("result")]
    public Result? RecipeResult { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("experience")]
    public int Experience { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("cookingtime")]
    public int CookingTIme { get; set; }
}