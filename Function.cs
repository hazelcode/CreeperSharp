namespace SteveSharp
{
    public class Function
    {
        static string Path = "";
        public Function(string path, string contents = "")
        {
            Path = path;
            if (!File.Exists(path))
            {
                FileOrganizer.CreateFullDirectory(path, true);
                Displays.NewFunction(path);
            } else
            {
                Displays.ExtendedFunction(path);
            }
            Thread.Sleep(10);
            File.WriteAllText(path, contents);
            Thread.Sleep(10);
        }
        public void PrependCommands(string[] commands)
        {
            string content = File.ReadAllText(Path);
            foreach(string command in commands)
            {
                content = content + command.TrimEnd() + "\n";
            }
            content = content.TrimEnd();
            File.WriteAllText(Path, content);
        }
        public bool WriteAllCommands(string[] commands)
        {
            try
            {
                string content = "";
                foreach (string command in commands)
                {
                    content = content + command.TrimEnd() + "\n";
                }
                content = content.TrimEnd();
                // File.WriteAllText(this.path, content);
                using(var sw = new StreamWriter(Path)) {
                    sw.WriteLine(content);
                    sw.Close();
                }
                return true;
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static void WriteAllFunctions(Function[] functions){
            try {
                foreach(Function f in functions){
                    f.WriteAllCommands(new string[] { f.GetAllCommands(FileOrganizer.GetFunctionPath(Path)) });
                }
            } catch(IOException e) {
                Console.WriteLine(e);
            }
        }
        public string Return(int i)
        {
            return "return " + i;
        }
        public string Call(string function)
        {
            return "function " + function;
        }
        public string GetAllCommands(string function)
        {
            Thread.Sleep(10);
            return File.ReadAllText(FileOrganizer.GetFunctionPath(function));
        }
        public string Extend(string function, string[] commands, bool createFunction = false)
        {
            try
            {
                Thread.Sleep(10);
                string path = FileOrganizer.GetFunctionPath(function);
                string origin = Path;
                if(createFunction == false)
                {
                    Function ExtendedFunction = new Function(FileOrganizer.GetFunctionPath(function), GetAllCommands(function) + "\n## Extended from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                } else
                {
                    Function ExtendedFunction = new Function(FileOrganizer.GetFunctionPath(function), "## Created from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                }
                Displays.ExtendedFrom(path, origin);
                Thread.Sleep(10);
                return "function " + function;
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
