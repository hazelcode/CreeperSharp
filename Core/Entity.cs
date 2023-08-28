namespace SteveSharp.Core
{
    public static class Entity
    {
        public static string Self(string match = "") { if (match == "") return "@s"; else return "@s[" + match + "]"; }
        public static string Everyone(string match = "") { if (match == "") return "@a"; else return "@a[" + match + "]"; }
        public static string Random(string match = "") { if (match == "") return "@r"; else return "@r[" + match + "]"; }
        public static string Closest(string match = "") { if (match == "") return "@p"; else return "@p[" + match + "]"; }
        public static string AllEntities(string match = "") { if (match == "") return "@e"; else return "@e[" + match + "]"; }
        public static string Teleport(string selector, string to)
        {
            return $"tp {selector} {to}";
        }
        public static string Summon(string entity, string[] pos, string nbt = "{}")
        {
            return $"summon {entity} {pos[0]} {pos[1]} {pos[2]} {nbt}";
        }
        public static string AddTag(string selector, string tag)
        {
            return $"tag {selector} add {tag}";
        }
        public static string RemoveTag(string selector, string tag)
        {
            return $"tag {selector} remove {tag}";
        }
        public static string Kill(string selector)
        {
            return $"kill {selector}";
        }
    }
}
