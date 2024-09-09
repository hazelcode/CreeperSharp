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
        public static string Schedule(string function, string time, bool append = false, bool replace = false) {
            if(append && !replace) return $"schedule function {function} {time} append";
            else if(!append && replace) return $"schedule function {function} {time} replace";
            else return $"schedule function {function} {time}";
        }
        public string ScheduleSelf(string time, bool append = false, bool replace = false) => Schedule(Name, time, append, replace);
        public static string ClearSchedule(string function) => $"schedule clear {function}";
        public string ClearSchedule() => ClearSchedule(Name);
    }
}
