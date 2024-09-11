using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class CraftingShaped : CraftingSpecial {
    public class RecipeResult : Recipe.RecipeResult {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    [JsonPropertyName("type")]
    new public string Type {  get; set; } = "minecraft:crafting_shaped";

    [JsonPropertyName("group")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Group { get; set; }

    [JsonPropertyName("pattern")]
    public string[]? Pattern { get; set; }

    [JsonPropertyName("key")]
    public Dictionary<string, Recipe.RecipeIngredient>? Key { get; set; }
    
    [JsonPropertyName("result")]
    public RecipeResult? Result { get; set; }

    [JsonPropertyName("show_notification")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ShowNotification { get; set; }
}