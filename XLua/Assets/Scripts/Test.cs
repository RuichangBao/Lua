using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(BtnOnClick);
    }
    public void BtnOnClick()
    {
        this.Print1();
        this.Print2();
    }
    public void Print1()
    {
        Debug.Log(">>>>>>>>>>>>>>>> Print1");
    }
    private void Print2()
    {
        Debug.Log(">>>>>>>>>>>>>>>> Print2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
