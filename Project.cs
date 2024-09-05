using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp
{
    public class Project
    {
        public Dictionary<string, Function> FunctionIndex { get; set; }
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
            FunctionIndex = new Dictionary<string, Function>();
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
            File.WriteAllText("pack.mcmeta", JsonSerializer.Serialize(metadata, new JsonSerializerOptions { WriteIndented = true }));
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
                    FunctionIndex.Add(function.Name, function);
                }
            }
            if (FunctionIndex.Count > 0)
                foreach (var function in FunctionIndex)
                {
                    if (!File.Exists(FileOrganizer.GetFunctionPath(function.Value.Name)))
                    {
                        Displays.NewFunction(function.Value.Name);
                    }
                    else
                    {
                        Displays.WrittenFunction(function.Value.Name);
                    }
                    File.WriteAllLines(FileOrganizer.GetFunctionPath(function.Value.Name), function.Value.Body);
                }
        }
    }
}
