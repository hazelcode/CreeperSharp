namespace SteveSharp.Core;

public static class For
{
    public static string Loop(int to, Func<int, List<String>> block, int from = 0) {
        List<List<string>> fullBlock = new();
        for(int i = from; i <= to; i++) {
            fullBlock.Add(block(i));
        }
        List<string> ret = new();
        foreach(var codeBlock in fullBlock) {
            foreach(var command in codeBlock) {
                ret.Add(command);
            }
        }
        return string.Join("\n", ret);
    }
}