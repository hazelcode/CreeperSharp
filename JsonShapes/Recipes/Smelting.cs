using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class Smelting : Recipe {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:smelting";

    [JsonPropertyName("experience")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public double Experience { get; set; }

    [JsonPropertyName("cookingtime")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int CookingTime { get; set; }
}