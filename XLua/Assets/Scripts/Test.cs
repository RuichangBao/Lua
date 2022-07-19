using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Test : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(BtnOnClick);
    }
    public void BtnOnClick()
    {
        LuaManager.Instance.ClickTest();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
