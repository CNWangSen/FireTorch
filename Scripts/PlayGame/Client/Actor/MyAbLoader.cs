using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Audio;
using Newtonsoft.Json;
using Blizzard.T5.AssetManager;
using System;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker;

public class MyAbLoader:MonoBehaviour
{
	public static MyAbLoader Instance=null;
	public void Start()
	{
		Instance=this;
	}
	public void SetHSMat(GameObject obj, string cardID)
	{

	}
}