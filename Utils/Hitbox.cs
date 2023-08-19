using SteveSharp;
using SteveSharp.Core;

namespace SteveSharp.Utils
{
    public class Hitbox
    {
        public float width = 1.0f;
        public float height = 1.0f;
        public string workspace;
        public string id;
        public string[] XYZ;
        public string[] onAttack;
        public string[] onRightClick;
        public Hitbox(string workspace, string id)
        {
            this.workspace = workspace;
            this.id = id;
            XYZ = new string[3] { "~", "~", "~" };
            onAttack = new string[] { "title @s actionbar {\"text\": \"\"}" };
            onRightClick = new string[] { "title @s actionbar {\"text\": \"\"}" };
        }
        public string Summon(string function)
        {
            FileOrganizer FO = new FileOrganizer();
            Function f = new Function(FO.GetFunctionPath(function));
            Execute Execute = new Execute();
            Entity Entity = new Entity();
            return f.Extend(
                    $"{workspace}:hitbox/" + this.id.ToLower() + "/summon",
                    new string[]
                    {
                        Entity.Summon("interaction",new[]{ "~", "~", "~" },
                        "{Tags:[\"" + workspace + "." + this.id + "\"],width:" + this.width + ",height:" + this.height + "}"),
                        Execute.Write(
                            Execute.Asat(Entity.Self("type=interaction,tag=" + workspace + "." + this.id)) +
                            "on attacker ",
                            onAttack
                        ),
                        Execute.Write(
                            Execute.Asat(Entity.Self("type=interaction,tag=" + workspace + "." + this.id)) +
                            "on trigger ",
                            onRightClick
                        ),
                        Entity.Kill("@e[type=interaction,tag=" + workspace + "." + this.id + "]")
                    }, true
                );
        }
    }
}