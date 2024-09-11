namespace SteveSharp.Core;

public static class Recipe {
    public static string Give(string targets, string recipe) => $"recipe give {targets} {recipe}";
    public static string Take(string targets, string recipe) => $"recipe take {targets} {recipe}";
}