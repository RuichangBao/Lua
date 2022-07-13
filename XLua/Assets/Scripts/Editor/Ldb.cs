using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Ldb
{
    [MenuItem("Ldb/热更新")]
    static void HotFix()
    {
        Debug.LogError("热更新");
        //LuaManager.Instance.DoString("Test = require('UI.Test')");
        LuaManager.Instance.DoString();
    }
}