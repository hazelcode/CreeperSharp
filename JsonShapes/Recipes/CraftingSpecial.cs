using System.Text.Json.Serialization;

public class CraftingSpecial {
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("category")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Category { get; set; }
}