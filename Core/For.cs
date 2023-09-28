namespace SteveSharp.Core;

public static class For
{
    public static string Loop(int from, int to, string create, string replaces = ""){
        string commands = "";
        for(int i = from; i <= to; i++){
            commands += create.Replace(replaces, i.ToString()) + '\n';
        }
        return commands;
    }
}