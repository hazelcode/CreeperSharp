namespace SteveSharp.JsonShapes
{
    public class PackMetadata
    {
        public Pack? pack { get; set; }
    }
    public class Pack
    {
        public string? description { get; set; }
        public int pack_format { get; set; }
    }
}
