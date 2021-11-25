using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class FileIO
{
    public static string ReadAllText(string path)
    {
        return File.ReadAllText(path);
    }
    public static byte[] ReadFile(string path)
    {
        string str = ReadAllText(path);
        return System.Text.Encoding.UTF8.GetBytes(str);
    }
    public static byte[]ReadLuaFile(string fileName)
    {
        string luaPath = "Assets/Lua/"+ fileName + ".lua";
        string str = ReadAllText(luaPath);
        return System.Text.Encoding.UTF8.GetBytes(str);
    }
}
