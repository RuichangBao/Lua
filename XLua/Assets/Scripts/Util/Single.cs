using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单例类
/// </summary>
/// <typeparam name="T"></typeparam>
public class Single<T> where T : class,new()
{
    private static T instance;

    public static T Instance
    {
        get 
        {
            if(instance==null)
            {
                instance = new T();
                (instance as Single<T>).OnInit();
            }
            return instance;
        }
    }
    public virtual void OnInit()
    {

    }

}
