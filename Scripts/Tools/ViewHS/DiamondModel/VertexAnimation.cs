using System;
//using Blizzard.T5.Core;
using UnityEngine;

// Token: 0x0200290C RID: 10508
[ExecuteAlways]
[RequireComponent(typeof(Renderer))]
public class VertexAnimation : MonoBehaviour
{
	// Token: 0x06013A5A RID: 80474 RVA: 0x005BFAE9 File Offset: 0x005BDCE9
	private void Awake()
	{
		this.m_properties = new MaterialPropertyBlock();
		this.m_renderer = base.GetComponent<Renderer>();
		this.UpdateProperties();
	}

	// Token: 0x06013A5B RID: 80475 RVA: 0x005BFB08 File Offset: 0x005BDD08
	private void OnValidate()
	{
		this.ValidateAnimationData();
		this.UpdateProperties();
	}

	// Token: 0x06013A5C RID: 80476 RVA: 0x005BFB18 File Offset: 0x005BDD18
	private void ValidateAnimationData()
	{
		if (this.AnimationData == null)
		{
			return;
		}
		foreach (VertexAnimation.AnimationClipInfo checkInfo in this.AnimationData)
		{
			this.OriginalFPS = Mathf.Max(this.OriginalFPS, 1);
			this.AnimationSpeed = Mathf.Max(this.AnimationSpeed, 0.01f);
			this.OriginalFrameCount = Mathf.Max(this.OriginalFrameCount, 2);
			checkInfo.frameRange.x = Mathf.Clamp(checkInfo.frameRange.x, 0, this.OriginalFrameCount - 2);
			checkInfo.frameRange.y = Mathf.Clamp(checkInfo.frameRange.y, 1, this.OriginalFrameCount - 1);
			if (checkInfo.frameRange.y <= checkInfo.frameRange.x)
			{
				checkInfo.frameRange.y = checkInfo.frameRange.x + 1;
			}
		}
	}

	// Token: 0x06013A5D RID: 80477 RVA: 0x005BFC00 File Offset: 0x005BDE00
	private void UpdateProperties()
	{
		if (!this.m_renderer)
		{
			return;
		}
		this.m_currentAnimationSpeed = this.AnimationSpeed;
		this.m_renderer.GetPropertyBlock(this.m_properties);
		float animationTime = this.CalculateAnimationTime();
		this.m_properties.SetFloat("_AnimTime", animationTime);
		this.m_properties.SetFloat("_VertCount", (float)this.VertexCount);
		this.m_properties.SetFloat("_FrameCount", (float)this.RecordedFrameCount);
		this.m_properties.SetTexture("_MorphTex", this.AnimationTexture);
		this.m_renderer.SetPropertyBlock(this.m_properties);
	}

	// Token: 0x06013A5E RID: 80478 RVA: 0x005BFCA8 File Offset: 0x005BDEA8
	public void StartAnimation(string animationName)
	{
		if (!this.m_renderer)
		{
			return;
		}
		this.m_renderer.GetPropertyBlock(this.m_properties);
		if (!Mathf.Approximately(this.m_properties.GetFloat("_VertCount"), (float)this.VertexCount))
		{
			this.UpdateProperties();
		}
		this.m_animationIsActive = true;
		this.m_animationName = animationName;
		float animationOffet = Time.timeSinceLevelLoad - this.CalculateStartFrameTime(this.m_animationName);
		this.m_properties.SetFloat("_TimeOffset", animationOffet);
		this.m_renderer.SetPropertyBlock(this.m_properties);
	}

	// Token: 0x06013A5F RID: 80479 RVA: 0x005BFD3C File Offset: 0x005BDF3C
	public void SetAnimationCompletionPercent(string animationName, float completionPercent)
	{
		if (!this.m_renderer)
		{
			this.m_renderer = base.GetComponent<Renderer>();
		}
		if (this.m_properties == null)
		{
			this.m_properties = new MaterialPropertyBlock();
		}
		this.m_renderer.GetPropertyBlock(this.m_properties);
		this.m_animationIsActive = true;
		this.m_animationName = animationName;
		if (!Mathf.Approximately(this.m_properties.GetFloat("_VertCount"), (float)this.VertexCount))
		{
			this.UpdateProperties();
		}
		completionPercent = Mathf.Clamp01(completionPercent);
		float animationLength = this.GetAnimationLength(this.m_animationName);
		float animationOffset = Time.timeSinceLevelLoad - this.CalculateStartFrameTime(this.m_animationName) - completionPercent * animationLength;
		this.m_properties.SetFloat("_TimeOffset", animationOffset);
		this.m_renderer.SetPropertyBlock(this.m_properties);
	}

	// Token: 0x06013A60 RID: 80480 RVA: 0x005BFE06 File Offset: 0x005BE006
	[Obsolete("Use SetCurrentAnimationCompletionPercent().")]
	public void SetAnimationCompletionPercent(float completionPercent)
	{
		this.SetCurrentAnimationCompletionPercent(completionPercent);
	}

	// Token: 0x06013A61 RID: 80481 RVA: 0x005BFE0F File Offset: 0x005BE00F
	public void SetCurrentAnimationCompletionPercent(float completionPercent)
	{
		this.SetAnimationCompletionPercent(this.m_animationName, completionPercent);
	}

	// Token: 0x06013A62 RID: 80482 RVA: 0x005BFE20 File Offset: 0x005BE020
	private void SetAnimationSpeed(float animationSpeed)
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.m_renderer == null)
		{
			//throw new NullReferenceException(string.Format("Attempting to set a null renderer properties. GameObject: {0}, full path: {1}", base.gameObject, base.gameObject.GetFullPath()));
		}
		if (animationSpeed > 0f && animationSpeed != this.m_currentAnimationSpeed)
		{
			try
			{
				this.m_renderer.GetPropertyBlock(this.m_properties);
				this.m_currentAnimationSpeed = animationSpeed;
				this.m_properties.SetFloat("_AnimTime", this.CalculateAnimationTime());
				this.m_renderer.SetPropertyBlock(this.m_properties);
			}
			catch (Exception e)
			{
				//Log.Graphics.Log(LogLevel.Error, string.Format("Could not set animation speed.  GameObject: {0}, full path: {1}, exception:{2}, {3}", new object[]
				//{
				//	base.gameObject,
				//	base.gameObject.GetFullPath(),
				//	e.Message,
				//	e.StackTrace
				//}), Array.Empty<object>());
			}
		}
	}

	// Token: 0x170030B1 RID: 12465
	// (get) Token: 0x06013A63 RID: 80483 RVA: 0x005BFF20 File Offset: 0x005BE120
	public float CurrentAnimationCompletionPercent
	{
		get
		{
			if (!this.m_animationIsActive)
			{
				return 0f;
			}
			if (!this.m_renderer)
			{
				this.m_renderer = base.GetComponent<Renderer>();
			}
			if (this.m_properties == null)
			{
				this.m_properties = new MaterialPropertyBlock();
			}
			this.m_renderer.GetPropertyBlock(this.m_properties);
			if (!Mathf.Approximately(this.m_properties.GetFloat("_VertCount"), (float)this.VertexCount))
			{
				this.UpdateProperties();
			}
			return -(this.m_properties.GetFloat("_TimeOffset") - Time.timeSinceLevelLoad + this.CalculateStartFrameTime(this.m_animationName)) / this.GetAnimationLength(this.m_animationName);
		}
	}

	// Token: 0x06013A64 RID: 80484 RVA: 0x005BFFD0 File Offset: 0x005BE1D0
	public void OverwriteAnimationSpeed(float animationSpeed)
	{
		float completionPercent = 1f;
		if (this.m_animationIsActive)
		{
			completionPercent = this.CurrentAnimationCompletionPercent;
		}
		this.SetAnimationSpeed(animationSpeed);
		if (this.m_animationIsActive)
		{
			this.SetAnimationCompletionPercent(this.m_animationName, completionPercent);
		}
	}

	// Token: 0x06013A65 RID: 80485 RVA: 0x005C000E File Offset: 0x005BE20E
	public void UseDefaultAnimationSpeed()
	{
		this.SetAnimationSpeed(this.AnimationSpeed);
	}

	// Token: 0x06013A66 RID: 80486 RVA: 0x005C001C File Offset: 0x005BE21C
	public float GetAnimationLengthUnscaled(string animationName)
	{
		VertexAnimation.AnimationClipInfo info = this.GetAnimationInfo(animationName);
		if (info != null)
		{
			return (float)(info.frameRange.y - info.frameRange.x) / (float)this.OriginalFPS;
		}
		return 0f;
	}

	// Token: 0x06013A67 RID: 80487 RVA: 0x005C005A File Offset: 0x005BE25A
	public float GetAnimationLength(string animationName)
	{
		return this.GetAnimationLengthUnscaled(animationName) / this.CurrentAnimationSpeed;
	}

	// Token: 0x06013A68 RID: 80488 RVA: 0x005C006C File Offset: 0x005BE26C
	private float CalculateStartFrameTime(string animationName)
	{
		VertexAnimation.AnimationClipInfo info = this.GetAnimationInfo(animationName);
		if (info != null)
		{
			return (float)info.frameRange.x / (float)this.OriginalFPS / this.m_currentAnimationSpeed;
		}
		return 0f;
	}

	// Token: 0x06013A69 RID: 80489 RVA: 0x005C00A8 File Offset: 0x005BE2A8
	private VertexAnimation.AnimationClipInfo GetAnimationInfo(string animationName)
	{
		foreach (VertexAnimation.AnimationClipInfo checkData in this.AnimationData)
		{
			if (checkData.name == animationName)
			{
				return checkData;
			}
		}
		return null;
	}

	// Token: 0x06013A6A RID: 80490 RVA: 0x005C00DF File Offset: 0x005BE2DF
	private float CalculateAnimationTime()
	{
		return (float)this.OriginalFrameCount / (float)this.OriginalFPS / this.m_currentAnimationSpeed;
	}

	// Token: 0x170030B2 RID: 12466
	// (get) Token: 0x06013A6B RID: 80491 RVA: 0x005C00F7 File Offset: 0x005BE2F7
	public float CurrentAnimationSpeed
	{
		get
		{
			return this.m_currentAnimationSpeed;
		}
	}

	// Token: 0x04010DD1 RID: 69073
	private const string ANIMATION_TIME = "_AnimTime";

	// Token: 0x04010DD2 RID: 69074
	private const string VERTEX_COUNT_KEY = "_VertCount";

	// Token: 0x04010DD3 RID: 69075
	private const string FRAME_COUNT_KEY = "_FrameCount";

	// Token: 0x04010DD4 RID: 69076
	private const string ANIMATION_TEXTURE_KEY = "_MorphTex";

	// Token: 0x04010DD5 RID: 69077
	private const string TIME_OFFSET = "_TimeOffset";

	// Token: 0x04010DD6 RID: 69078
	[Tooltip("The animation's default speed. Even if the current speed is modified via Timeline or PlayMaker, this variable will not change.")]
	[Min(0.0001f)]
	public float AnimationSpeed;

	// Token: 0x04010DD7 RID: 69079
	public int VertexCount;

	// Token: 0x04010DD8 RID: 69080
	public int RecordedFrameCount;

	// Token: 0x04010DD9 RID: 69081
	public int OriginalFrameCount;

	// Token: 0x04010DDA RID: 69082
	public int OriginalFPS;

	// Token: 0x04010DDB RID: 69083
	public Texture2D AnimationTexture;

	// Token: 0x04010DDC RID: 69084
	public VertexAnimation.AnimationClipInfo[] AnimationData;

	// Token: 0x04010DDD RID: 69085
	private float m_currentAnimationSpeed;

	// Token: 0x04010DDE RID: 69086
	private MaterialPropertyBlock m_properties;

	// Token: 0x04010DDF RID: 69087
	private Renderer m_renderer;

	// Token: 0x04010DE0 RID: 69088
	private bool m_animationIsActive;

	// Token: 0x04010DE1 RID: 69089
	private string m_animationName = string.Empty;

	// Token: 0x0200290D RID: 10509
	[Serializable]
	public class AnimationClipInfo
	{
		// Token: 0x04010DE2 RID: 69090
		public string name;

		// Token: 0x04010DE3 RID: 69091
		public Vector2Int frameRange;
	}
}
