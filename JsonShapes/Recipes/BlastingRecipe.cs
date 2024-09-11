using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class BlastingRecipe : Recipe {
    
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:blasting";
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("experience")]
    public double Experience { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("cookingtime")]
    public int CookingTime { get; set; }
}