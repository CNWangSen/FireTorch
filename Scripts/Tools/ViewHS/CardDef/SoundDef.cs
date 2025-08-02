using System;
using System.Collections.Generic;
using UnityEngine;

public class SoundDef:MonoBehaviour
{
	// Token: 0x06007A68 RID: 31336 RVA: 0x0000258D File Offset: 0x0000078D
	//public void Awake()
	//{
	//}
	// Token: 0x040062CE RID: 25294
	//[CustomEditField(T = EditType.AUDIO_CLIP)]
	public string m_AudioClip;

	// Token: 0x040062CF RID: 25295
	public SoundCategory m_Category = SoundCategory.FX;

	// Token: 0x040062D0 RID: 25296
	public List<RandomAudioClip> m_RandomClips;

	// Token: 0x040062D1 RID: 25297
	public float m_RandomPitchMin = 1f;

	// Token: 0x040062D2 RID: 25298
	public float m_RandomPitchMax = 1f;

	// Token: 0x040062D3 RID: 25299
	public float m_RandomVolumeMin = 1f;

	// Token: 0x040062D4 RID: 25300
	public float m_RandomVolumeMax = 1f;

	// Token: 0x040062D5 RID: 25301
	public bool m_IgnoreDucking;

}