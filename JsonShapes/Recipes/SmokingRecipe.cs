using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class SmokingRecipe : BlastingRecipe {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:smoking";
}