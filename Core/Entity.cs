namespace SteveSharp.Core
{
    public class Entity
    {
        public string Self(string match = "") { return "@s[" + match + "]"; }
        public string Everyone(string match = "") { return "@a[" + match + "]"; }
        public string Random(string match = "") { return "@r[" + match + "]"; }
        public string Closest(string match = "") { return "@p[" + match + "]"; }
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
