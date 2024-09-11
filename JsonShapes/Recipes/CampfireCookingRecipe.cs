using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class CampfireCookingRecipe : Recipe {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:campfire_cooking";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("experience")]
    public double Experience { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("cookingtime")]
    public int CookingTime { get; set; }
}