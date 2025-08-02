using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "AudAsset")]

public class AudAsset : ScriptableObject
{
    public AudioClip SpawnClip;
    public AudioClip AttackClip;
    public AudioClip DeathClip;
}
