using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp
{
    public class Project
    {
        private readonly Function _load;
        private readonly Function _main;
        private readonly List<Function> _functions;
        public Project(string name, string description, string id, int pack_format, Function load, Function main, List<Function> functions)
        {
            // Display fresh SteveSharp Display
            Displays.SteveSharpDisplay(name);
            _load = load;
            _main = main;
            _functions = functions;
            string loadPath = FileOrganizer.GetFunctionPath(_load.Name);
            string mainPath = FileOrganizer.GetFunctionPath(_main.Name);
            Directory.CreateDirectory(name);
            Environment.CurrentDirectory = name;
            FileOrganizer.CreateFullDirectory($"data/{id}/functions");
            FileOrganizer.CreateFullDirectory($"data/minecraft/tags/functions");
            var metadata = new PackMetadata
            {
                pack = new Pack
                {
                    description = description,
                    pack_format = pack_format
                }
            };
            File.WriteAllText("pack.mcmeta", JsonSerializer.Serialize(metadata));
            File.WriteAllText($"data/minecraft/tags/functions/load.json",
                JsonSerializer.Serialize(new Tag
                {
                    values = new string[] { _load.Name }
                }, new JsonSerializerOptions { WriteIndented = true })
            );
            File.WriteAllText($"data/minecraft/tags/functions/tick.json",
                JsonSerializer.Serialize(new Tag
                {
                    values = new string[] { _main.Name }
                }, new JsonSerializerOptions { WriteIndented = true })
            );
            Displays.ProjectCreated();
            File.WriteAllLines(loadPath, _load.Body);
            Displays.WrittenFunction(_load.Name);
            File.WriteAllLines(mainPath, _main.Body);
            Displays.WrittenFunction(_main.Name);

            if (_functions.Count > 0)
            {
                foreach (var function in functions)
                {
                    if (!File.Exists(FileOrganizer.GetFunctionPath(function.Name)))
                    {
                        Displays.NewFunction(function.Name);
                    }
                    else
                    {
                        Displays.WrittenFunction(function.Name);
                    }
                    File.WriteAllLines(FileOrganizer.GetFunctionPath(function.Name), function.Body);
                }
            }
        }
    }
}
