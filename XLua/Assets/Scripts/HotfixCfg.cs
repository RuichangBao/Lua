using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using XLua;

public static class HotfixCfg
{
    //能热修复的类
    [Hotfix]
    public static List<Type> by_field = new List<Type>()
    {
        typeof(Test),
    };
}