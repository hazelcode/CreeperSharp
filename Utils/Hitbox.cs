using SteveSharp;
using SteveSharp.Core;
using SteveSharp.JsonShapes;

/*
NOT FOR NOW
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
            Function f = new Function(FileOrganizer.GetFunctionPath(function));
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
}*/