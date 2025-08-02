using System;
using UnityEngine;

// Token: 0x020008D5 RID: 2261
public class SoundPlayClipArgs
{
	// Token: 0x0400631A RID: 25370
	public AudioSource m_templateSource;

	// Token: 0x0400631B RID: 25371
	public SoundDef m_def;

	// Token: 0x0400631C RID: 25372
	public AudioClip m_forcedAudioClip;

	// Token: 0x0400631D RID: 25373
	public float? m_volume;

	// Token: 0x0400631E RID: 25374
	public float? m_pitch;

	// Token: 0x0400631F RID: 25375
	public float? m_spatialBlend;

	// Token: 0x04006320 RID: 25376
	public SoundCategory? m_category;

	// Token: 0x04006321 RID: 25377
	public GameObject m_parentObject;
}
