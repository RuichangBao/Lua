using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaManager : Single<LuaManager>
{
    private LuaEnv luaEnv;
    public override void Init()
    {
        base.Init();
        luaEnv = new LuaEnv();
        //luaEnv.DoString("print('hello Lua')");

        //luaEnv.DoString("require 'TestInit'");

        luaEnv.AddLoader(FuncCustomLoader);
        //luaEnv.DoString("print('LoadAAA.ccc=', require('Init').ccc)");
        luaEnv.DoString("require'Init'");
    }

    private byte[] FuncCustomLoader(ref string filepath)
    {
        Debug.Log("加载自定义load："+filepath);
        byte[] data = FileIO.ReadLuaFile(filepath);
        return data;
        //Debug.LogError(filepath);
        //string str = "print('hello LuaLoader')";
        //return System.Text.Encoding.UTF8.GetBytes(str);
    }
}