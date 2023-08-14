using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp.Core
{
    public class Text
    {
        public TextComponent New(string text, string? color = null, bool italic = false, bool bold = false, bool underlined = false, bool obfuscated = false, bool strikethrough = false, string? insertion = null, string? clickEventAction = null, string? clickEventValue = null)
        {
            TextComponent textComponent = new TextComponent
            {
                text = text,
                color = color,
                italic = italic,
                bold = bold,
                underlined = underlined,
                obfuscated = obfuscated,
                strikethrough = strikethrough,
                insertion = insertion,
                clickEvent = new clickEvent
                {
                    action = clickEventAction,
                    value = clickEventValue
                }
            };
            return textComponent;
        }
    }
}
