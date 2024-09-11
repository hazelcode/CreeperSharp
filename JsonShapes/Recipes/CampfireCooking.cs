using System.Text.Json.Serialization;

public class CampfireCooking : Recipe {
    [JsonPropertyName("type")]
    new public string Type { get; set; } = "minecraft:campfire_cooking";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("experience")]
    public int Experience { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("cookingtime")]
    public int CookingTime { get; set; }
}