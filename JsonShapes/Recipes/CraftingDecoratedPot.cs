using System.Text.Json.Serialization;

public class CraftingDecoratedPot : CraftingSpecial {
    new public string Type { get; set; } = "minecraft:crafting_decorated_pot";
}