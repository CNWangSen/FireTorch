using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Audio;
using Newtonsoft.Json;
using System;

public class SVEffectViewer : MonoBehaviour
{

    public GameObject plane;
    public AudioSource audsrc1;
    public AudioSource audsrc2;
    public AudioSource audsrc3;
    public static string absSVdir = "D:\\DocFile\\Unity3dRef\\Assets\\CusCCG_Ex_SV\\";

    void Start()
    {
         LoadCard();
    }
    public void LoadCard()
    {
        AssetBundle b1 = AssetBundle.LoadFromFile(absSVdir+"");
    }
}