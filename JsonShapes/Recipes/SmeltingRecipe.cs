using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class SmeltingRecipe : BlastingRecipe {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:smelting";
}