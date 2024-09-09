using System.Text.Json;
using SteveSharp.Generic;
using SteveSharp.JsonShapes;

namespace SteveSharp;

public class Bossbar
{
    public string? Id { get; set; }
    public enum GetField
    {
        Max,
        Players,
        Value,
        Visible
    }
    public enum Style
    {
        Notched6,
        Notched10,
        Notched12,
        Notched20
    }
    public static string Add(string id, TextComponent text) => $"bossbar add {id} {JsonSerializer.Serialize(text)}";
    public static string Add(string id, TextComponent[] text) => $"bossbar add {id} {JsonSerializer.Serialize(text)}";
    public static string Get(string id, GetField field)
    {
        Dictionary<GetField, string> fieldStr = new() {
            {GetField.Max, "max"},
            {GetField.Players, "players"},
            {GetField.Value, "value"},
            {GetField.Visible, "visible"}
        };
        return $"bossbar get {id} {fieldStr[field]}";
    }
    public static string Get(string id, string field) => $"bossbar get {id} {field}";
    public static string List() => "bossbar list";
    public static string Remove(string id) => $"bossbar remove {id}";
    public static string SetColor(string id, Color color) => $"bossbar set {id} color {ColorHandler.Get(color)}";
    public static string SetColor(string id, string color) => $"bossbar set {id} color {color}";
    public static string SetMax(string id, int max) => $"bossbar set {id} max {max}";
    public static string SetName(string id, TextComponent name) => $"bossbar set {id} name {JsonSerializer.Serialize(name)}";
    public static string SetName(string id, TextComponent[] name) => $"bossbar set {id} name {JsonSerializer.Serialize(name)}";
    public static string SetPlayers(string id, string targets) => $"bossbar set {id} players {targets}";
    public static string SetStyle(string id, Style style)
    {
        Dictionary<Style, string> styleStr = new() {
            {Style.Notched6, "notched_6"},
            {Style.Notched10, "notched_10"},
            {Style.Notched12, "notched_12"},
            {Style.Notched20, "notched_20"}
        };
        return $"bossbar set {id} style {styleStr[style]}";
    }
    public static string SetStyle(string id, string style) => $"bossbar set {id} style {style}";
    public static string SetValue(string id, int value) => $"bossbar set {id} value {value}";
    public static string SetVisible(string id, bool visible) => $"bossbar set {id} visible {visible.ToString().ToLower()}";
    public Bossbar(string id)
    {
        Id = id;
    }
    public string Add(TextComponent text) => Add(this.Id!, text);
    public string Add(TextComponent[] text) => Add(this.Id!, text);
    public string Get(GetField field) => Get(this.Id!, field);
    public string Get(string field) => Get(this.Id!, field);
    public string SetColor(Color color) => SetColor(this.Id!, color);
    public string SetColor(string color) => SetColor(this.Id!, color);
    public string SetMax(int max) => SetMax(this.Id!, max);
    public string SetName(TextComponent name) => SetName(this.Id!, name);
    public string SetName(TextComponent[] name) => SetName(this.Id!, name);
    public string SetPlayers(string targets) => SetPlayers(this.Id!, targets);
    public string SetStyle(Style style) => SetStyle(this.Id!, style);
    public string SetStyle(string style) => SetStyle(this.Id!, style);
    public string SetValue(int value) => SetValue(this.Id!, value);
    public string SetVisible(bool visible) => SetVisible(this.Id!, visible);
}