namespace SteveSharp
{
    internal class DataCollector
    {
        internal string? projectName { get; set; }
        internal string? projectDesc { get; set; }
        internal int pack_format { get; set; }
        internal Function[]? functions { get; set; }
        public void PrependFunction(string path, string[] contents)
        {
            functions = functions!.Prepend(new Function(path, String.Join("",contents))).ToArray();
        }
    }
}