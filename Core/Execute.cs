namespace SteveSharp.Core
{
    public class Execute
    {
        const string[] defaults = null;
        public string Write(string execute, string[] commands = defaults)
        {
            string allCommands = "";
            foreach (string command in commands)
            {
                allCommands += "execute " + execute + "run " + command + "\n";
            }
            return allCommands;
        }
        public string As(string selector, string addition = "")
        {
            return "as " + selector + " " + addition;
        }
        public string At(string selector, string addition = "")
        {
            return "at " + selector + " " + addition;
        }
        public string Asat(string selector, string addition = "")
        {
            return "as " + selector + " at @s " + addition;
        }
        public string Unless(string arguments, string addition = "")
        {
            return "unless " + arguments + " " + addition;
        }
        public string If(string arguments, string addition = "")
        {
            return "if " + arguments + " " + addition;
        }
        public string Summon(string entity, string[] pos, string addition = "")
        {
            return "summon " + entity + " " + pos[0] + " " + pos[1] + " " + pos[2] + " " + addition;
        }
        public string Store(string where, string at, string arguments, string addition = "")
        {
            return "store " + where + " " + at + " " + arguments + " " + addition;
        }
        public string StoreScore(string where, Score score, string selector = "", string addition = "")
        {
            if (selector == "")
            {
                return "store " + where + " score " + "#" + score.id + " " + score.id + " " + addition;
            }
            else
            {
                return "store " + where + " score " + selector + " " + score.id + " " + addition;
            }
        }
    }
}
