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
        FileStream fileStream = new FileStream(luaPath, FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        return data;
        //return System.Text.Encoding.UTF8.GetBytes(str);
    }
    //public static byte[] ReadLuaFile(string path)
    //{
    //    path = Application.dataPath + "/Lua/" + path + ".lua";
    //    if (!File.Exists(path))
    //    {
    //        Debug.LogError("该文件不存在");
    //        return null;
    //    }
    //    FileStream fileStream = new FileStream(path, FileMode.Open);
    //    byte[] data = new byte[fileStream.Length];
    //    fileStream.Read(data, 0, data.Length);
    //    fileStream.Close();
    //    return data;
    //}
}
