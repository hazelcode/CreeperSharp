namespace SteveSharp
{
    public class Function
    {
        public string Name = "";
        public List<string> Body { get; set; }
        public Function(string name, List<string> body)
        {
            Name = name;
            Body = body;
            Displays.NewFunction(name);
        }
        public static string Return(int i)
        {
            return "return " + i;
        }
        public static string Call(string function)
        {
            return "function " + function;
        }
    }
}
