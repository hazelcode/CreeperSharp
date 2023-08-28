namespace SteveSharp.Core
{
    public class Score
    {
        public int count = 0;
        public string id;
        public string type;
        public string name;
        public Score(string id, string type = "dummy", string name = "", int count = 0)
        {
            this.id = id;
            this.count = count;
            this.type = type;
            this.name = name;
        }
        public string AddObjective()
        {
            return $"scoreboard objectives add {this.id} {this.type} {this.name}";
        }
        public static string AddObjectives(Score[] scores)
        {
            string commands = "";
            foreach(Score score in scores)
            {
                commands += $"scoreboard objectives add {score.id} {score.type} {score.name}\n";
            }
            return commands;
        }
        public string Set(int count, string selector = "")
        {
            if(selector == "")
            {
                return $"scoreboard players set #{this.id} {this.id} {count}";
            } else
            {
                return $"scoreboard players set {selector} {this.id} {count}";
            }
        }
        public string Add(int count, string selector = "")
        {
            if (selector == "")
            {
                return $"scoreboard players add #{this.id} {this.id} {count}";
            }
            else
            {
                return $"scoreboard players add {selector} {this.id} {count}";
            }
        }
        public string Remove(string selector, int count)
        {
            if (selector == "")
            {
                return $"scoreboard players remove #{this.id} {this.id} {count}";
            }
            else
            {
                return $"scoreboard players remove {selector} {this.id} {count}";
            }
        }
        public string Reset(string selector = "")
        {
            if (selector == "")
            {
                return $"scoreboard players reset #{this.id} {this.id}";
            }
            else
            {
                return $"scoreboard players reset {selector} {this.id}";
            }
        }
    }
}
