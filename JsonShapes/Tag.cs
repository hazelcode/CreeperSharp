using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes
{
    public class Tag
    {
        public string[]? values { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool replace { get; set; }
    }
}
