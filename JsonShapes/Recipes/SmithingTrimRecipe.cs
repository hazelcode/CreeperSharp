using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes.Recipes;

public class SmithingTrimRecipe : CraftingSpecial {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:smithing_trim";

    [JsonPropertyName("template")]
    public Recipe.RecipeIngredient? Template { get; set; }

    [JsonPropertyName("base")]
    public Recipe.RecipeIngredient? Base { get; set; }

    [JsonPropertyName("addition")]
    public Recipe.RecipeIngredient? Addition { get; set; }
}