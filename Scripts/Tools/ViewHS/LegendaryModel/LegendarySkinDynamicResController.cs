using System;
using System.Collections.Generic;
//using Blizzard.T5.MaterialService.Extensions;
using UnityEngine;

// Token: 0x02000B74 RID: 2932
public class LegendarySkinDynamicResController : MonoBehaviour
{
	// Token: 0x17000B34 RID: 2868
	// (get) Token: 0x06005A76 RID: 23158 RVA: 0x001B5A78 File Offset: 0x001B3C78
	// (set) Token: 0x06005A77 RID: 23159 RVA: 0x001B5A80 File Offset: 0x001B3C80
	public LegendarySkin Skin
	{
		get
		{
			return this.m_skin;
		}
		set
		{
			if (this.m_skin != null)
			{
				this.m_skin.RemoveDynamicResController(this);
			}
			this.m_skin = value;
			if (this.m_skin != null && base.isActiveAndEnabled)
			{
				this.m_skin.AddDynamicResController(this);
			}
		}
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x001B5AD0 File Offset: 0x001B3CD0
	public void CacheMaterialProperties(Material material)
	{
		if (material != null)
		{
			this.m_originalScale = material.mainTextureScale;
			this.m_originalOffset = material.mainTextureOffset;
		}
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x001B5AF3 File Offset: 0x001B3CF3
	private void OnEnable()
	{
		if (this.m_skin != null)
		{
			this.m_skin.AddDynamicResController(this);
		}
	}

	// Token: 0x06005A7A RID: 23162 RVA: 0x001B5B0F File Offset: 0x001B3D0F
	private void OnDisable()
	{
		if (this.m_skin != null)
		{
			this.m_skin.RemoveDynamicResController(this);
		}
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x001B5B2C File Offset: 0x001B3D2C
	public LegendarySkinDynamicResController.SizeResult GetSize(IEnumerable<Camera> cameras, out float size)
	{
		if (this.ForceFullResolution)
		{
			size = float.MaxValue;
			return LegendarySkinDynamicResController.SizeResult.MaxSize;
		}
		if (this.Renderer == null)
		{
			size = 0f;
			return LegendarySkinDynamicResController.SizeResult.Invalid;
		}
		float pixelsHigh = 0f;
		LegendarySkinDynamicResController.SizeResult result = LegendarySkinDynamicResController.SizeResult.Invalid;
		int renderLayer = 1 << this.Renderer.gameObject.layer;
		Bounds b = this.Renderer.bounds;
		foreach (Camera camera in cameras)
		{
			if ((camera.cullingMask & renderLayer) != 0 && camera.isActiveAndEnabled)
			{
				Vector3 proj = camera.WorldToScreenPoint(new Vector3(b.min.x, b.min.y, b.min.z));
				Vector2 min = proj;
				Vector2 lhs = min;
				proj = camera.WorldToScreenPoint(new Vector3(b.max.x, b.min.y, b.min.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs2 = Vector2.Max(lhs, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.min.x, b.max.y, b.min.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs3 = Vector2.Max(lhs2, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.max.x, b.max.y, b.min.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs4 = Vector2.Max(lhs3, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.min.x, b.min.y, b.max.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs5 = Vector2.Max(lhs4, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.max.x, b.min.y, b.max.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs6 = Vector2.Max(lhs5, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.min.x, b.max.y, b.max.z));
				min = Vector2.Min(min, proj);
				Vector2 lhs7 = Vector2.Max(lhs6, proj);
				proj = camera.WorldToScreenPoint(new Vector3(b.max.x, b.max.y, b.max.z));
				min = Vector2.Min(min, proj);
				Vector2 vector = Vector2.Max(lhs7, proj) - min;
				float widthPixels = Mathf.Abs(vector.x) / this.m_originalScale.x;
				float heightPixels = Mathf.Abs(vector.y) / this.m_originalScale.y;
				pixelsHigh = Mathf.Max(new float[]
				{
					pixelsHigh,
					widthPixels,
					heightPixels
				});
				result = LegendarySkinDynamicResController.SizeResult.Bounded;
			}
		}
		size = pixelsHigh;
		return result;
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x001B5E84 File Offset: 0x001B4084
	public void UpdateMaterial(float dynamicResolution)
	{
		if (this.Renderer != null)
		{
			Material material = null;//this.Renderer.GetSharedMaterial(this.MaterialIdx);
			if (material != null)
			{
				material.mainTextureScale = this.m_originalScale * dynamicResolution;
				material.mainTextureOffset = this.m_originalOffset * dynamicResolution;
				material.SetVector("_DynamicResolutionScale", new Vector2(dynamicResolution, 1f / dynamicResolution));
			}
		}
	}

	// Token: 0x04003F9A RID: 16282
	private LegendarySkin m_skin;

	// Token: 0x04003F9B RID: 16283
	private Vector2 m_originalScale = new Vector2(1f, 1f);

	// Token: 0x04003F9C RID: 16284
	private Vector2 m_originalOffset = new Vector2(0f, 0f);

	// Token: 0x04003F9D RID: 16285
	[NonSerialized]
	public Renderer Renderer;

	// Token: 0x04003F9E RID: 16286
	[NonSerialized]
	public int MaterialIdx;

	// Token: 0x04003F9F RID: 16287
	[SerializeField]
	public bool ForceFullResolution;

	// Token: 0x02000B75 RID: 2933
	public enum SizeResult
	{
		// Token: 0x04003FA1 RID: 16289
		Invalid,
		// Token: 0x04003FA2 RID: 16290
		Bounded,
		// Token: 0x04003FA3 RID: 16291
		MaxSize
	}
}
