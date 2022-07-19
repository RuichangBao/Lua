using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaManager : Single<LuaManager>
{
    private LuaEnv luaEnv;
    public LuaManager()
    {
    }
    public override void OnInit()
    {
        base.OnInit();
        luaEnv = new LuaEnv();
        //luaEnv.DoString("print('hello Lua')");
        //luaEnv.DoString("require 'TestInit'");

        luaEnv.AddLoader(FuncCustomLoader);
        luaEnv.DoString("require'Init'");
    }

    public void DoString()
    {
        //luaEnv.AddLoader(FuncCustomLoader);
        string aaa = "require('Hotfix')";
        luaEnv.DoString(aaa);
        luaEnv.DoString("require 'Utils.LuaGlobal'");
    }

    private byte[] FuncCustomLoader(ref string filepath)
    {
        //Debug.LogError("加载自定义load：" + filepath);
        filepath = filepath.Replace(".", "/");
        byte[] data = FileIO.ReadLuaFile(filepath);
        return data;
    }

    public void ClickTest()
    {
        LuaGlobal p = luaEnv.Global.Get<LuaGlobal>("LuaGlobal");
        Debug.LogError(p.a);
        int a = luaEnv.Global.Get<int>("a");
        Debug.LogError(a);
    }

    class LuaGlobal
    {
        public int a;
        public Test test;
    }

}