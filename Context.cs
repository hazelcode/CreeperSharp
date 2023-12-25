namespace SteveSharp;

/// <summary>
/// This is totally convenient because enables the context access to our libraries and we can develop tools easily without asking everywhere the pack id, and more information.
/// You can take this data for your proposals.
/// </summary>
public class Context
{
    public static string? id { get; set; }
    public static string? projectName { get; set; }
    public static string? currentPath { get; set; }
    public static bool? devMode { get; set; }
    public static string? loadFile { get; set; }
    public static string? mainFile { get; set; }
    public static string[]? refsCollection { get; set; }
    public static int packFormat { get; set; }
}