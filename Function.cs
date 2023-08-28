namespace SteveSharp
{
    public class Function
    {
        string path = "";
        public Function(string path, string contents = "")
        {
            this.path = path;
            if (!File.Exists(path))
            {
                FileOrganizer.CreateFullDirectory(path, true);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("  NEW  ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Created {path}");
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  EXT  ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Extended {path}");
                Console.ResetColor();
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
            Thread.Sleep(10);
            return File.ReadAllText(FileOrganizer.GetFunctionPath(function));
        }
        public string Extend(string function, string[] commands, bool createFunction = false)
        {
            try
            {
                Thread.Sleep(10);
                string path = FileOrganizer.GetFunctionPath(function);
                string origin = this.path;
                if(createFunction == false)
                {
                    Function ExtendedFunction = new Function(FileOrganizer.GetFunctionPath(function), GetAllCommands(function) + "\n## Extended from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                } else
                {
                    Function ExtendedFunction = new Function(FileOrganizer.GetFunctionPath(function), "## Created from " + origin + "\n");
                    ExtendedFunction.PrependCommands(commands);
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" EXT/F ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Extended {path} from {origin}");
                Console.ResetColor();
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
