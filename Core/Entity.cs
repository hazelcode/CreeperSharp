namespace SteveSharp.Core
{
    public class Entity
    {
        public string Self(string match = "") { if (match == "") return "@s"; else return "@s[" + match + "]"; }
        public string Everyone(string match = "") { if (match == "") return "@a"; else return "@a[" + match + "]"; }
        public string Random(string match = "") { if (match == "") return "@r"; else return "@r[" + match + "]"; }
        public string Closest(string match = "") { if (match == "") return "@p"; else return "@p[" + match + "]"; }
        public string AllEntities(string match = "") { if (match == "") return "@e"; else return "@e[" + match + "]"; }
        public string Teleport(string selector, string to)
        {
            return $"tp {selector} {to}";
        }
        public string Summon(string entity, string[] pos, string nbt = "{}")
        {
            return $"summon {entity} {pos[0]} {pos[1]} {pos[2]} {nbt}";
        }
        public string AddTag(string selector, string tag)
        {
            return $"tag {selector} add {tag}";
        }
        public string RemoveTag(string selector, string tag)
        {
            return $"tag {selector} remove {tag}";
        }
        public string Kill(string selector)
        {
            return $"kill {selector}";
        }
    }
}
