using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp.Core
{
    public class Chat
    {
        public string Say(string msg)
        {
            return $"say {msg}";
        }
        public string Out(string selector, string msg, string? color = null, bool italic = false, bool bold = false, bool underlined = false, bool obfuscated = false, bool strikethrough = false, string? insertion = null, string? clickEventAction = null, string? clickEventValue = null)
        {
            var textComponent = new TextComponent
            {
                text = msg,
                color = color,
                italic = italic,
                bold = bold,
                underlined = underlined,
                obfuscated = obfuscated,
                strikethrough = strikethrough,
                insertion = insertion,
                clickEvent = new clickEvent { action = clickEventAction, value = clickEventValue }
            };
            
            string command = "tellraw " + selector + " " + JsonSerializer.Serialize(textComponent);
            return command;
        }
    }
}
