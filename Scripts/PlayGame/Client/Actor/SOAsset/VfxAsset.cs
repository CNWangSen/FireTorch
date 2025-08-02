using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "VfxAsset")]

public class VfxAsset : ScriptableObject
{
    public string ScriptName;
    public GameObject InvokePrefab;
    public GameObject LaunchPrefab;
    public GameObject ImpactPrefab;
}

