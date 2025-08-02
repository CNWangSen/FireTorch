using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020028A3 RID: 10403
[Serializable]
public class UberShaderAnimation : ScriptableObject
{
	// Token: 0x04010A2C RID: 68140
	[SerializeField]
	public List<UberShaderAnimation.UberAnimation> animations = new List<UberShaderAnimation.UberAnimation>();

	// Token: 0x04010A2D RID: 68141
	public List<int> materialPropertyIDs = new List<int>();

	// Token: 0x04010A2E RID: 68142
	public int version = 1;

	// Token: 0x020028A4 RID: 10404
	public enum PropertyType
	{
		// Token: 0x04010A30 RID: 68144
		Color,
		// Token: 0x04010A31 RID: 68145
		Vector,
		// Token: 0x04010A32 RID: 68146
		Float
	}

	// Token: 0x020028A5 RID: 10405
	[Serializable]
	public class UberAnimation
	{
		// Token: 0x04010A33 RID: 68147
		public string materialPropertyName;

		// Token: 0x04010A34 RID: 68148
		public UberShaderAnimation.PropertyType propertyType;

		// Token: 0x04010A35 RID: 68149
		public int materialIndex;

		// Token: 0x04010A36 RID: 68150
		public List<UberShaderAnimation.UberAnimationElement> animationElement = new List<UberShaderAnimation.UberAnimationElement>();
	}

	// Token: 0x020028A6 RID: 10406
	[Serializable]
	public class UberAnimationElement
	{
		// Token: 0x04010A37 RID: 68151
		public int element;

		// Token: 0x04010A38 RID: 68152
		public bool incrementingValue;

		// Token: 0x04010A39 RID: 68153
		public int incrementingElement;

		// Token: 0x04010A3A RID: 68154
		public float incrementingLastValue;

		// Token: 0x04010A3B RID: 68155
		public float incrementingSpeed;

		// Token: 0x04010A3C RID: 68156
		public UberShaderAnimation.UberAnimationCurve animationCurve;

		// Token: 0x04010A3D RID: 68157
		public UberShaderAnimation.UberAnimationRandom randomAnimation;

		// Token: 0x04010A3E RID: 68158
		public UberShaderAnimation.UberAnimationColor colorAnimation;
	}

	// Token: 0x020028A7 RID: 10407
	[Serializable]
	public class UberAnimationCurve
	{
		// Token: 0x04010A3F RID: 68159
		public bool enabled;

		// Token: 0x04010A40 RID: 68160
		public AnimationCurve animationCurve;

		// Token: 0x04010A41 RID: 68161
		public float speed = 1f;

		// Token: 0x04010A42 RID: 68162
		public float scale = 1f;

		// Token: 0x04010A43 RID: 68163
		public float offset;
	}

	// Token: 0x020028A8 RID: 10408
	[Serializable]
	public class UberAnimationRandom
	{
		// Token: 0x04010A44 RID: 68164
		public bool enabled;

		// Token: 0x04010A45 RID: 68165
		public AnimationCurve intensityCurve;

		// Token: 0x04010A46 RID: 68166
		public float intensitySpeed = 1f;

		// Token: 0x04010A47 RID: 68167
		public float seed;

		// Token: 0x04010A48 RID: 68168
		public float minValue = -1f;

		// Token: 0x04010A49 RID: 68169
		public float maxValue = 1f;

		// Token: 0x04010A4A RID: 68170
		public float speed = 1f;

		// Token: 0x04010A4B RID: 68171
		public float scale = 1f;
	}

	// Token: 0x020028A9 RID: 10409
	[Serializable]
	public class UberAnimationColor
	{
		// Token: 0x04010A4C RID: 68172
		public bool enabled;

		// Token: 0x04010A4D RID: 68173
		public Color color = Color.white;

		// Token: 0x04010A4E RID: 68174
		public Gradient gradient = new Gradient();
	}
}
