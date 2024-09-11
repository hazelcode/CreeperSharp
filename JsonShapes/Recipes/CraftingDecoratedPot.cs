using System.Text.Json.Serialization;

public class CraftingDecoratedPot : CraftingSpecial {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:crafting_decorated_pot";
}