using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp
{
    public static class Tags
    {
        public static bool WriteAllValues(string filePath, string[] values, bool replace = false)
        {
            try
            {
                var tag = new Tag
                {
                    values = values,
                    replace = replace
                };
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(tag, options);
                File.WriteAllText(filePath, jsonString);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
