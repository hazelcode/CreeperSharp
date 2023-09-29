namespace SteveSharp.Core
{
    public static class Entity
    {
        public static string Self(string match = "") { if (match == "") return "@s"; else return "@s[" + match + "]"; }
        public static string Everyone(string match = "") { if (match == "") return "@a"; else return "@a[" + match + "]"; }
        public static string Random(string match = "") { if (match == "") return "@r"; else return "@r[" + match + "]"; }
        public static string Closest(string match = "") { if (match == "") return "@p"; else return "@p[" + match + "]"; }
        public static string AllEntities(string match = "") { if (match == "") return "@e"; else return "@e[" + match + "]"; }
        /// <summary>
        /// This method selects an entity with specific matches, recommended if you want to select an entity with specific matches.
        /// </summary>
        /// <returns></returns>
        public static string Custom(string selector, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null) {
            string match = "";
            match += selector + "[";
            if(limit != null) match += "limit=" + limit + ',';
            if(tags?.Length >= 1){
                foreach(string tag in tags){
                    match += "tag=" + tag + ",";
                }
            }
            if(scores?.Length >= 1){
                match += "scores={";
                foreach(string score in scores){
                    match += score + ',';
                }
                match += "},";
            }
            if(team != null) match += "team=" + team + ',';
            if(type != null && selector != "@a" || selector != "@r" || selector != "@p")
                match += "type=" + type + ',';
            if(distance != null) match += "distance=" + distance + ',';
            if(area != null) match += area + ',';
            if(level != null) match += "level=" + level + ',';
            if(gamemode != null && selector != "@e") match += "gamemode=" + gamemode + ',';
            if(horizontalRotation != null) match += "y_rotation=" + horizontalRotation + ',';
            if(verticalRotation != null) match += "x_rotation=" + verticalRotation + ',';
            if(sort != null) match += "sort=" + sort + ',';
            if (match.EndsWith(',')) match.Remove(match.Length - 1);
            match += ']';
            return match;
        }
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
