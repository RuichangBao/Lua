using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	void Awake()
	{
		
	}

	// Use this for initialization
	void Start()
	{
		LuaManager.Instance.GetType();
		LOGC.LOGCG("绿色输出");
	}

	// Update is called once per frame
	void Update()
	{

	}
}