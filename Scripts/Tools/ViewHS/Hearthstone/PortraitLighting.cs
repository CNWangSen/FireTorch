using System;
using UnityEngine;

namespace Hearthstone
{
	// Token: 0x02002C97 RID: 11415
	[CreateAssetMenu(fileName = "Portrait Lighting", menuName = "ScriptableObjects/Legendary Heros/Portrait Lighting")]
	public class PortraitLighting : ScriptableObject
	{
		// Token: 0x06014DE7 RID: 85479 RVA: 0x00605AD9 File Offset: 0x00603CD9
		public void OnValidate()
		{
			this.RimLightMaxNormal = Mathf.Max(this.RimLightMinNormal, this.RimLightMaxNormal);
		}

		// Token: 0x0401204C RID: 73804
		[Header("Shadows")]
		public int resolution = 512;

		// Token: 0x0401204D RID: 73805
		public Color ShadowColor;

		// Token: 0x0401204E RID: 73806
		[Range(0.1f, 1f)]
		public float DepthBias = 0.25f;

		// Token: 0x0401204F RID: 73807
		[Range(0.5f, 6f)]
		public float SoftnessFalloff = 3f;

		// Token: 0x04012050 RID: 73808
		[Header("Specular Lighting")]
		public Texture Cubemap;

		// Token: 0x04012051 RID: 73809
		[Range(0f, 1f)]
		public float CubemapRotation = 0.5f;

		// Token: 0x04012052 RID: 73810
		[Header("Rim Lighting")]
		public Color RimLightColor;

		// Token: 0x04012053 RID: 73811
		public Color HairRimLightColor;

		// Token: 0x04012054 RID: 73812
		[Range(0f, 360f)]
		public float RimLightDirection = 45f;

		// Token: 0x04012055 RID: 73813
		[Range(0f, 360f)]
		public float RimLightAngle = 45f;

		// Token: 0x04012056 RID: 73814
		[Range(0f, 1f)]
		public float RimLightAngleSoftness = 0.5f;

		// Token: 0x04012057 RID: 73815
		[Range(0f, 1f)]
		public float RimLightMinNormal = 0.85f;

		// Token: 0x04012058 RID: 73816
		[Range(0f, 1f)]
		public float RimLightMaxNormal = 0.95f;
	}
}
