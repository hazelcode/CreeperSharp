using SteveSharp;
using SteveSharp.Core;
using SteveSharp.JsonShapes;

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
            Chat Chat = new Chat();
            Entity Entity = new Entity();
            this.workspace = workspace;
            this.id = id;
            XYZ = new string[3] { "~", "~", "~" };
            onAttack = new string[] {
                Chat.Out(
                    Entity.Self(),
                    new TextComponent[]
                    {
                        new TextComponent
                        {
                            text = ""
                        }
                    }
                )
            };
            onRightClick = new string[] {
                Chat.Out(
                    Entity.Self(),
                    new TextComponent[]
                    {
                        new TextComponent
                        {
                            text = ""
                        }
                    }
                )
            };
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
                            Execute.Asat(Entity.AllEntities("type=interaction,tag=" + workspace + "." + this.id)) +
                            "on attacker ",
                            onAttack
                        ),
                        Execute.Write(
                            Execute.Asat(Entity.AllEntities("type=interaction,tag=" + workspace + "." + this.id)) +
                            "on trigger ",
                            onRightClick
                        ),
                        Entity.Kill(Entity.AllEntities("type=interaction,tag=" + workspace + "." + this.id))
                    }, true
                );
        }
    }
}