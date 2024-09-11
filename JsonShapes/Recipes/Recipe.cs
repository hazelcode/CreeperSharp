using System.Text.Json.Serialization;

public class Recipe {
    
    public class RecipeIngredient {
        [JsonPropertyName("item")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Item { get; set; }

        [JsonPropertyName("tag")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemTag { get; set; }
    }
    public class RecipeResult {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("components")]
        public Dictionary<string, dynamic>? Components { get; set; }
    }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("category")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Category { get; set; }

    [JsonPropertyName("group")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Group { get; set; }

    [JsonPropertyName("ingredient")]
    public dynamic? Ingredient { get; set; }

    [JsonPropertyName("result")]
    public RecipeResult? Result { get; set; }
}