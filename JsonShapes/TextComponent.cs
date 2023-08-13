namespace SteveSharp.JsonShapes
{
    public class TextComponent
    {
        public string? text { get; set; }
        public string? color { get; set; }
        public bool italic { get; set; }
        public bool bold { get; set; }
        public bool underlined { get; set; }
        public bool obfuscated { get; set; }
        public bool strikethrough { get; set; }
        public string? insertion { get; set; }
        public clickEvent? clickEvent { get; set; }
        public TextComponent[]? extra { get; set; }
    }
    public class clickEvent
    {
        public string? action { get; set; }
        public string? value { get; set; }
    }
}
