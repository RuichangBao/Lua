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

    public void DoString(string str)
    {
        luaEnv.AddLoader(FuncCustomLoader);
        luaEnv.DoString(str);
    }

    private byte[] FuncCustomLoader(ref string filepath)
    {
        Debug.LogError("加载自定义load：" + filepath);
        filepath = filepath.Replace(".", "/");
        byte[] data = FileIO.ReadLuaFile(filepath);
        return data;
    }

    public void ClickTest()
    {
        //{
        //    int a = luaEnv.Global.Get<int>("a");
        //    Debug.LogError(a);
        //}
        //LuaGlobal p = luaEnv.Global.Get<LuaGlobal>("LuaGlobal");
        //Debug.LogError(p.Num);
        //Test test = luaEnv.Global.Get<Test>("Test");
        //Debug.LogError(test.sss);
        int a = luaEnv.Global.Get<int>("a");
        Debug.LogError(a);
    }

    class Init
    {
        public int num;
        
    }
    class LuaGlobal
    {
        public string Num;
        public Test test;
    }
    class Test
    {
        public string sss;
    }
}