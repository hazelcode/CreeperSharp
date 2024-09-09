namespace SteveSharp.Generic;

internal static class ColorHandler {
    public static string Get(Color color) {
        Dictionary<Color, string> colorStr = new() {
            {Color.Blue, "blue"},
            {Color.Green, "green"},
            {Color.Pink, "pink"},
            {Color.Purple, "purple"},
            {Color.Red, "red"},
            {Color.White, "white"},
            {Color.Yellow, "yellow"}
        };
        return colorStr[color];
    }
}