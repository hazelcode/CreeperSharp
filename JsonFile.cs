namespace SteveSharp;

public class JsonFile {
    public string Path { get; set; }
    public object Object { get; set; }
    public JsonFile(string path, object obj) {
        Path = path;
        Object = obj;
    }
}