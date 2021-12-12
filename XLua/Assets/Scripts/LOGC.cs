using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOGC 
{
    #region 绿色输出
    public static void LOGCG(string str)
    {
        Debug.Log("<color=#00FF00>" + str + "</color>");
    }
    public static void LOGCG(object str)
    {
        Debug.Log("<color=#00FF00>" + str + "</color>");
    }
    #endregion
    #region 红色输出
    public static void LOGCR(string str)
    {
        Debug.Log("<color=#FF0000>" + str + "</color>");
    }
    public static void LOGCR(object str)
    {
        Debug.Log("<color=#FF0000>" + str + "</color>");
    }
    #endregion
}