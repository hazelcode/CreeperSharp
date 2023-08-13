using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp
{
    public class Project
    {
        public Project(string name, string description, string id, int pack_format, string load, string main)
        {
            try
            {
                FileOrganizer FO = new FileOrganizer();

                // Create project directory
                if (!Directory.Exists(name))
                {
                    Directory.CreateDirectory(name);
                }
                Environment.CurrentDirectory = name;

                // Serialize project metadata to JSON and write to the pack.mcmeta file
                var packMetadata = new PackMetadata
                {
                    pack = new pack { description = description, pack_format = pack_format }
                };
                var options = new JsonSerializerOptions { WriteIndented = true };
                string MetadataStructure = JsonSerializer.Serialize(packMetadata, options);
                File.WriteAllText("pack.mcmeta", MetadataStructure);

                // Create directories and project namespace
                if (!File.Exists($"data/{id}/functions/{load}.mcfunction"))
                {
                    Thread.Sleep(10);
                    FO.CreateFullDirectory(FO.GetFunctionPath($"{id}:{load}"), true);
                    Console.WriteLine("Load function created succesfully");
                    Thread.Sleep(10);
                }
                if (!File.Exists($"data/{id}/functions/{main}.mcfunction"))
                {
                    Thread.Sleep(10);
                    FO.CreateFullDirectory(FO.GetFunctionPath($"{id}:{main}"), true);
                    Console.WriteLine("Main function created succesfully");
                    Thread.Sleep(10);
                }
                if (!Directory.Exists($"data/minecraft/tags/functions"))
                {
                    FO.CreateFullDirectory($"data/minecraft/tags/functions");
                }

                // Create tick and load JSON files
                Tags funcTags = new Tags();
                string[] loadTag = { $"{id}:{load}" };
                string[] tickTag = { $"{id}:{main}" };
                funcTags.WriteAllValues(FO.GetJsonPath("minecraft:load","tags/functions"), loadTag);
                funcTags.WriteAllValues(FO.GetJsonPath("minecraft:tick", "tags/functions"), loadTag);
                Console.WriteLine("Project created succesfully!");
            } catch(IOException e)
            {
                Console.WriteLine("Project wasn't created succesfully or completely. Check the errors:\n");
                Console.WriteLine(e.Message);
            }
        }
    }
}
