using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreeperSharp.Core
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
        public string Set(string selector, Score score, int count)
        {
            return $"scoreboard players set {selector} {score.id} {count}";
        }
        public string Add(string selector, int count)
        {
            return $"scoreboard players add {selector} {this.id} {count}";
        }
        public string Remove(string selector, int count)
        {
            return $"scoreboard players remove {selector} {this.id} {count}";
        }
    }
}
