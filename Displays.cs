internal static class Displays
{
    internal static void ExtendedFrom(string path, string origin)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write(" EXT/F ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($" Extended {path} from {origin}");
        Console.ResetColor();
    }
    internal static void NewFunction(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("  NEW  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Created {path}");
        Console.ResetColor();
    }
    internal static void ExtendedFunction(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write("  EXT  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($" Extended {path}");
        Console.ResetColor();
    }
    internal static void SteveSharpDisplay(string name)
    {
        Console.Title = "SteveSharp Log";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n</>   S t e v e S h a r p   L o g   </>\n\nProject: {name}\n\n");
        Console.ResetColor();
    }
}