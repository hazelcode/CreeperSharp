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
        public string Out(string selector, TextComponent[] text)
        {
            string command = "tellraw " + selector + " " + JsonSerializer.Serialize(text);
            return command;
        }
    }
}
