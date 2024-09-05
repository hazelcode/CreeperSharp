namespace SteveSharp.Core
{
    public static class XYZ
    {
        public static string[] Set(string X, string Y, string Z)
        {
            return new string[] { X, Y, Z };
        }
        public static string[] Rel(string X, string Y, string Z) {
            return Set("~"+X, "~"+Y, "~"+Z);
        }
    }
}
