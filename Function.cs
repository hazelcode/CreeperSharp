namespace SteveSharp
{
    public class Function
    {
        string path = "";
        public Function(string path, string contents = "")
        {
            FileOrganizer FO = new FileOrganizer();
            this.path = path;
            if (!File.Exists(path))
            {
                FO.CreateFullDirectory(path, true);
                Console.WriteLine($"Created {path}");
            } else
            {
                Console.WriteLine($"Extended {path}");
            }
            Thread.Sleep(10);
            File.WriteAllText(path, contents);
            Thread.Sleep(10);
        }
        public void PrependCommands(string[] commands)
        {
            string content = File.ReadAllText(this.path);
            foreach(string command in commands)
            {
                content = content + command.TrimEnd() + "\n";
            }
            content = content.TrimEnd();
            File.WriteAllText(this.path, content);
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
                File.WriteAllText(this.path, content);
                return true;
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
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
            FileOrganizer FO = new FileOrganizer();
            Thread.Sleep(10);
            return File.ReadAllText(FO.GetFunctionPath(function));
        }
        public string Extend(string function, string[] commands, bool createFunction = false)
        {
            try
            {
                FileOrganizer FO = new FileOrganizer();
                Thread.Sleep(10);
                string path = FO.GetFunctionPath(function);
                string origin = this.path;
                if(createFunction == false)
                {
                    Function ExtendedFunction = new Function(FO.GetFunctionPath(function), GetAllCommands(function) + "\n## Extended from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                } else
                {
                    Function ExtendedFunction = new Function(FO.GetFunctionPath(function), "## Created from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                }
                Console.WriteLine($"Extended {path} from {origin}");
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
