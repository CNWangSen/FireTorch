using System;
using System.Collections.Generic;

//using Blizzard.T5.MaterialService.Extensions;
using UnityEngine;

// Token: 0x020028AB RID: 10411
[ExecuteAlways]
public class UberShaderController : MonoBehaviour
{
	// Token: 0x17003028 RID: 12328
	// (get) Token: 0x060135FB RID: 79355 RVA: 0x005A5EDA File Offset: 0x005A40DA
	// (set) Token: 0x060135FC RID: 79356 RVA: 0x005A5EE2 File Offset: 0x005A40E2
	public UberShaderAnimation UberShaderAnimation
	{
		get
		{
			return this.m_UberShaderAnimation;
		}
		set
		{
			if (this.m_UberShaderAnimation != null)
			{
				UnityEngine.Object.Destroy(this.m_UberShaderAnimation);
			}
			this.m_UberShaderAnimation = value;
			this.UpdateShaderIDs();
		}
	}

	// Token: 0x17003029 RID: 12329
	// (get) Token: 0x060135FD RID: 79357 RVA: 0x005A5F0A File Offset: 0x005A410A
	public DateTime? LastSaveTime
	{
		get
		{
			return this.m_lastSaveTime;
		}
	}

	// Token: 0x060135FE RID: 79358 RVA: 0x005A5F12 File Offset: 0x005A4112
	public static bool GetAutoSaveEnabled()
	{
		return UberShaderController.s_autoSave;
	}

	// Token: 0x060135FF RID: 79359 RVA: 0x005A5F19 File Offset: 0x005A4119
	public static float GetAutoSaveInterval()
	{
		return UberShaderController.s_autoSaveInterval;
	}

	// Token: 0x06013600 RID: 79360 RVA: 0x005A5F20 File Offset: 0x005A4120
	private void Awake()
	{
		if (this.m_UberShaderAnimation == null)
		{
			this.m_UberShaderAnimation = ScriptableObject.CreateInstance<UberShaderAnimation>();
		}
		this.m_firstFrame = true;
		this.m_randomOffset = UnityEngine.Random.Range(0f, 100f);
		this.m_time += this.m_randomOffset;
		this.m_renderer = base.GetComponent<Renderer>();
	}

	// Token: 0x06013601 RID: 79361 RVA: 0x005A5F81 File Offset: 0x005A4181
	private void OnEnable()
	{
		this.LoadUberShaderAnimation();
	}

	// Token: 0x06013602 RID: 79362 RVA: 0x005A5F89 File Offset: 0x005A4189
	private void Update()
	{
		this.UpdateAnimation();
	}

	// Token: 0x06013603 RID: 79363 RVA: 0x005A5F91 File Offset: 0x005A4191
	[ContextMenu("Reload Animation File")]
	private void LoadUberShaderAnimation()
	{
		this.m_firstFrame = true;
		if (this.m_UberShaderAnimation == null)
		{
			this.m_UberShaderAnimation = ScriptableObject.CreateInstance<UberShaderAnimation>();
		}
		this.UpdateShaderIDs();
	}

	// Token: 0x06013604 RID: 79364 RVA: 0x005A5FB9 File Offset: 0x005A41B9
	private void UpdateTime()
	{
		this.m_deltaTime = Time.deltaTime;
		this.m_time += this.m_deltaTime;
		if (this.m_time > this.m_maxTime)
		{
			this.m_time = 0.0001f;
		}
	}

	// Token: 0x06013605 RID: 79365 RVA: 0x005A5FF4 File Offset: 0x005A41F4
	private void UpdateEditorTime()
	{
		float num = Time.realtimeSinceStartup + this.m_randomOffset;
		this.m_deltaTime = num - this.m_lastTime;
		this.m_lastTime = num;
		this.m_time += this.m_deltaTime;
		if (this.m_time > this.m_maxTime)
		{
			this.m_time = 0.0001f;
		}
	}

	// Token: 0x06013606 RID: 79366 RVA: 0x005A6050 File Offset: 0x005A4250
	private void UpdateAnimation()
	{
		this.UpdateTime();
		if (this.m_renderer == null)
		{
			return;
		}
		this.m_sharedAnimationMaterials.Clear();
		this.m_renderer.GetSharedMaterials(this.m_sharedAnimationMaterials);

		if (this.m_sharedAnimationMaterials.Count < 1)
		{
			return;
		}
		if (this.m_UberShaderAnimation == null || this.m_UberShaderAnimation.animations == null)
		{
			return;
		}

		for (int i = 0; i < this.m_UberShaderAnimation.animations.Count; i++)
		{
			UberShaderAnimation.UberAnimation uberAnimation = this.m_UberShaderAnimation.animations[i];
			int nameID = this.m_UberShaderAnimation.materialPropertyIDs[i];
			int num = (this.m_MaterialIndex >= 0 && this.m_MaterialIndex < this.m_sharedAnimationMaterials.Count) ? this.m_MaterialIndex : uberAnimation.materialIndex;
			Material material = (num >= 0 && num < this.m_sharedAnimationMaterials.Count) ? this.m_sharedAnimationMaterials[num] : null;
			if (!(material == null))
			{
				if (uberAnimation.propertyType == UberShaderAnimation.PropertyType.Color)
				{
					UberShaderAnimation.UberAnimationElement uberAnimationElement = uberAnimation.animationElement[0];
					if (uberAnimationElement == null)
					{
						goto IL_3C7;
					}
					UberShaderAnimation.UberAnimationColor colorAnimation = uberAnimationElement.colorAnimation;
					if (colorAnimation != null && !colorAnimation.enabled)
					{
						goto IL_3C7;
					}
				}
				if (material.HasProperty(nameID))
				{
					Vector4 vector = Vector4.zero;
					if (uberAnimation.propertyType == UberShaderAnimation.PropertyType.Vector)
					{
						vector = material.GetVector(nameID);
					}
					else if (uberAnimation.propertyType == UberShaderAnimation.PropertyType.Float)
					{
						vector[0] = material.GetFloat(nameID);
					}
					Vector4 vector2 = vector;
					for (int j = 0; j < uberAnimation.animationElement.Count; j++)
					{
						UberShaderAnimation.UberAnimationElement uberAnimationElement2 = uberAnimation.animationElement[j];
						UberShaderAnimation.UberAnimationCurve animationCurve = uberAnimationElement2.animationCurve;
						UberShaderAnimation.UberAnimationRandom randomAnimation = uberAnimationElement2.randomAnimation;
						int element = uberAnimationElement2.element;
						float num2 = 0f;
						if (!uberAnimationElement2.incrementingValue)
						{
							switch (element)
							{
							case 0:
								num2 = vector.x;
								break;
							case 1:
								num2 = vector.y;
								break;
							case 2:
								num2 = vector.z;
								break;
							case 3:
								num2 = vector.w;
								break;
							}
						}
						if (animationCurve.animationCurve != null && animationCurve.enabled)
						{
							num2 = (animationCurve.animationCurve.Evaluate(this.m_time * animationCurve.speed) + animationCurve.offset) * animationCurve.scale;
						}
						if (randomAnimation != null && randomAnimation.enabled)
						{
							if (animationCurve.animationCurve == null || !animationCurve.enabled)
							{
								num2 = 0f;
							}
							float num3 = 1f;
							if (randomAnimation.intensityCurve != null)
							{
								num3 = randomAnimation.intensityCurve.Evaluate(this.m_time * randomAnimation.intensitySpeed);
							}
							num2 += Mathf.Lerp(randomAnimation.minValue, randomAnimation.maxValue, (UberMath.SimplexNoise(this.m_time * randomAnimation.speed + randomAnimation.seed, 0.5f) + 1f) * 0.5f * num3) * randomAnimation.scale;
						}
						if (uberAnimationElement2.incrementingValue)
						{
							if (this.m_firstFrame)
							{
								uberAnimationElement2.incrementingLastValue = 0f;
							}
							if (uberAnimationElement2.incrementingLastValue > this.m_maxTime)
							{
								uberAnimationElement2.incrementingLastValue = 0.0001f;
							}
							float num4 = num2 + uberAnimationElement2.incrementingSpeed;
							float num5 = this.m_deltaTime * num4;
							float num6 = uberAnimationElement2.incrementingLastValue + num5;
							num2 = num6;
							uberAnimationElement2.incrementingLastValue = num6;
						}
						switch (element)
						{
						case 0:
							vector2.x = num2;
							break;
						case 1:
							vector2.y = num2;
							break;
						case 2:
							vector2.z = num2;
							break;
						case 3:
							vector2.w = num2;
							break;
						}
					}
					if (uberAnimation.propertyType == UberShaderAnimation.PropertyType.Color)
					{
						Color value = uberAnimation.animationElement[0].colorAnimation.gradient.Evaluate(vector2.x);
						material.SetColor(nameID, value);
					}
					else
					{
						material.SetVector(nameID, vector2);
					}
				}
			}
			IL_3C7:;
		}
		this.m_firstFrame = false;
	}

	// Token: 0x06013607 RID: 79367 RVA: 0x005A6448 File Offset: 0x005A4648
	private void UpdateShaderIDs()
	{
		if (this.m_renderer == null)
		{
			return;
		}
		List<Material> sharedMaterials = new List<Material>();
		this.m_renderer.GetSharedMaterials(sharedMaterials);
		if (sharedMaterials == null || sharedMaterials.Count < 1)
		{
			return;
		}
		if (this.m_UberShaderAnimation == null || this.m_UberShaderAnimation.animations == null)
		{
			return;
		}
		this.m_UberShaderAnimation.materialPropertyIDs = new List<int>(this.m_UberShaderAnimation.animations.Count);
		for (int i = 0; i < this.m_UberShaderAnimation.animations.Count; i++)
		{
			int item = Shader.PropertyToID(this.m_UberShaderAnimation.animations[i].materialPropertyName);
			this.UberShaderAnimation.materialPropertyIDs.Add(item);
		}
	}

	// Token: 0x04010A50 RID: 68176
	private const int GUI_PROPERTY_LABEL_WIDTH = 130;

	// Token: 0x04010A51 RID: 68177
	[SerializeField]
	private UberShaderAnimation m_UberShaderAnimation;

	// Token: 0x04010A52 RID: 68178
	public int m_MaterialIndex = -1;

	// Token: 0x04010A53 RID: 68179
	private bool m_firstFrame;

	// Token: 0x04010A54 RID: 68180
	private float m_time;

	// Token: 0x04010A55 RID: 68181
	private float m_deltaTime;

	// Token: 0x04010A56 RID: 68182
	private Renderer m_renderer;

	// Token: 0x04010A57 RID: 68183
	private float m_lastTime;

	// Token: 0x04010A58 RID: 68184
	private float m_randomOffset;

	// Token: 0x04010A59 RID: 68185
	private string m_copyBuffer;

	// Token: 0x04010A5A RID: 68186
	private UberShaderAnimation.PropertyType m_copyBufferType;

	// Token: 0x04010A5B RID: 68187
	private string m_copyBufferLayer;

	// Token: 0x04010A5C RID: 68188
	private int m_copyBufferLayerCount;

	// Token: 0x04010A5D RID: 68189
	private DateTime? m_lastSaveTime;

	// Token: 0x04010A5E RID: 68190
	private float m_maxTime = 65535f;

	// Token: 0x04010A5F RID: 68191
	private List<Material> m_sharedAnimationMaterials = new List<Material>();

	// Token: 0x04010A60 RID: 68192
	private static bool s_autoSave = false;

	// Token: 0x04010A61 RID: 68193
	private static float s_autoSaveInterval = 30f;
}
