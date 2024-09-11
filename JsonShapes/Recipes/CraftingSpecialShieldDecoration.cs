using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class CraftingSpecialShieldDecoration : CraftingSpecial {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:crafting_special_shielddecoration";
}