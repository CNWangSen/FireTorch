using System;
using UnityEngine;

// Token: 0x02000960 RID: 2400
public static class RenderUtils
{
	// Token: 0x0600805A RID: 32858 RVA: 0x00299BEE File Offset: 0x00297DEE
	public static Material GetMaterial(Component c, int materialIndex)
	{
		return RenderUtils.GetMaterial(c.GetComponent<Renderer>(), materialIndex);
	}

	// Token: 0x0600805B RID: 32859 RVA: 0x00299BFC File Offset: 0x00297DFC
	public static Material GetMaterial(GameObject go, int materialIndex)
	{
		return RenderUtils.GetMaterial(go.GetComponent<Renderer>(), materialIndex);
	}

	// Token: 0x0600805C RID: 32860 RVA: 0x00299C0C File Offset: 0x00297E0C
	public static Material GetMaterial(Renderer renderer, int materialIndex)
	{
		if (materialIndex < 0)
		{
			return null;
		}
		RenderMaterialCleaner.AttachTo(renderer);
		Material[] materials = renderer.materials;
		if (materialIndex >= materials.Length)
		{
			return null;
		}
		Material material = materials[materialIndex];
		material.shaderKeywords = renderer.sharedMaterials[materialIndex].shaderKeywords;
		return material;
	}

	// Token: 0x0600805D RID: 32861 RVA: 0x00299C4A File Offset: 0x00297E4A
	public static Material GetSharedMaterial(Component c, int materialIndex)
	{
		return RenderUtils.GetSharedMaterial(c.GetComponent<Renderer>(), materialIndex);
	}

	// Token: 0x0600805E RID: 32862 RVA: 0x00299C58 File Offset: 0x00297E58
	public static Material GetSharedMaterial(GameObject go, int materialIndex)
	{
		return RenderUtils.GetSharedMaterial(go.GetComponent<Renderer>(), materialIndex);
	}

	// Token: 0x0600805F RID: 32863 RVA: 0x00299C68 File Offset: 0x00297E68
	public static Material GetSharedMaterial(Renderer renderer, int materialIndex)
	{
		if (materialIndex < 0)
		{
			return null;
		}
		Material[] sharedMaterials = renderer.sharedMaterials;
		if (materialIndex >= sharedMaterials.Length)
		{
			return null;
		}
		return sharedMaterials[materialIndex];
	}

	// Token: 0x06008060 RID: 32864 RVA: 0x00299C8D File Offset: 0x00297E8D
	public static void SetMaterial(Component c, int materialIndex, Material material)
	{
		RenderUtils.SetMaterial(c.GetComponent<Renderer>(), materialIndex, material);
	}

	// Token: 0x06008061 RID: 32865 RVA: 0x00299C9C File Offset: 0x00297E9C
	public static void SetMaterial(GameObject go, int materialIndex, Material material)
	{
		RenderUtils.SetMaterial(go.GetComponent<Renderer>(), materialIndex, material);
	}

	// Token: 0x06008062 RID: 32866 RVA: 0x00299CAC File Offset: 0x00297EAC
	public static void SetMaterial(Renderer renderer, int materialIndex, Material material)
	{
		if (materialIndex < 0)
		{
			return;
		}
		if (renderer == null)
		{
			//Error.AddDevFatal("Cannot set material on null renderer!", Array.Empty<object>());
			return;
		}
		if (material == null)
		{
			//Error.AddDevFatal("Cannot set null material on renderer!", Array.Empty<object>());
			return;
		}
		RenderMaterialCleaner.AttachTo(renderer);
		Material[] materials = renderer.materials;
		if (materialIndex >= materials.Length)
		{
			return;
		}
		Material material2 = materials[materialIndex];
		if (material2 != material)
		{
			RenderUtils.SafeRemoveMaterial(material2);
		}
		materials[materialIndex] = material;
		renderer.materials = materials;
		renderer.materials[materialIndex].shaderKeywords = material.shaderKeywords;
	}

	// Token: 0x06008063 RID: 32867 RVA: 0x00299D35 File Offset: 0x00297F35
	public static bool HasSharedMaterialAtIndex(Renderer renderer, int materialIndex)
	{
		return renderer.sharedMaterials.Length > materialIndex;
	}

	// Token: 0x06008064 RID: 32868 RVA: 0x00299D44 File Offset: 0x00297F44
	public static void AddSharedMaterial(Renderer renderer, Material material)
	{
		Material[] sharedMaterials = renderer.sharedMaterials;
		int num = renderer.sharedMaterials.Length;
		Array.Resize<Material>(ref sharedMaterials, num + 1);
		renderer.sharedMaterials = sharedMaterials;
		RenderUtils.SetSharedMaterial(renderer, num, material);
	}

	// Token: 0x06008065 RID: 32869 RVA: 0x00299D7C File Offset: 0x00297F7C
	public static void ReplaceSharedMaterials(Renderer renderer, Material[] materials)
	{
		Material[] sharedMaterials = renderer.sharedMaterials;
		renderer.sharedMaterials = materials;
		Material[] array = sharedMaterials;
		for (int i = 0; i < array.Length; i++)
		{
			RenderUtils.SafeRemoveMaterial(array[i]);
		}
	}

	// Token: 0x06008066 RID: 32870 RVA: 0x00299DAD File Offset: 0x00297FAD
	public static void SetSharedMaterial(Component c, int materialIndex, Material material)
	{
		RenderUtils.SetSharedMaterial(c.GetComponent<Renderer>(), materialIndex, material);
	}

	// Token: 0x06008067 RID: 32871 RVA: 0x00299DBC File Offset: 0x00297FBC
	public static void SetSharedMaterial(GameObject go, int materialIndex, Material material)
	{
		RenderUtils.SetSharedMaterial(go.GetComponent<Renderer>(), materialIndex, material);
	}

	// Token: 0x06008068 RID: 32872 RVA: 0x00299DCC File Offset: 0x00297FCC
	public static void SetSharedMaterial(Renderer renderer, int materialIndex, Material material)
	{
		if (material == null)
		{
			return;
		}
		if (materialIndex < 0)
		{
			return;
		}
		Material[] sharedMaterials = renderer.sharedMaterials;
		if (materialIndex >= sharedMaterials.Length)
		{
			return;
		}
		sharedMaterials[materialIndex] = material;
		sharedMaterials[materialIndex].shaderKeywords = material.shaderKeywords;
		renderer.sharedMaterials = sharedMaterials;
	}

	// Token: 0x06008069 RID: 32873 RVA: 0x00299E0F File Offset: 0x0029800F
	public static void SetAlpha(Component c, float alpha)
	{
		RenderUtils.SetAlpha(c.gameObject, alpha, false);
	}

	// Token: 0x0600806A RID: 32874 RVA: 0x00299E1E File Offset: 0x0029801E
	public static void SetAlpha(Component c, float alpha, bool includeInactive)
	{
		RenderUtils.SetAlpha(c.gameObject, alpha, includeInactive);
	}

	// Token: 0x0600806B RID: 32875 RVA: 0x00299E2D File Offset: 0x0029802D
	public static void SetAlpha(GameObject go, float alpha)
	{
		RenderUtils.SetAlpha(go, alpha, false);
	}

	// Token: 0x0600806C RID: 32876 RVA: 0x00299E38 File Offset: 0x00298038
	public static void SetAlpha(GameObject go, float alpha, bool includeInactive)
	{
		foreach (Renderer renderer in go.GetComponentsInChildren<Renderer>(includeInactive))
		{
			RenderMaterialCleaner.AttachTo(renderer);
			foreach (Material material in renderer.materials)
			{
				if (material.HasProperty("_Color"))
				{
					Color color = material.color;
					color.a = alpha;
					material.color = color;
				}
				else if (material.HasProperty("_TintColor"))
				{
					Color color2 = material.GetColor("_TintColor");
					color2.a = alpha;
					material.SetColor("_TintColor", color2);
				}
			}
			if (renderer.GetComponent<Light>() != null)
			{
				Color color3 = renderer.GetComponent<Light>().color;
				color3.a = alpha;
				renderer.GetComponent<Light>().color = color3;
			}
		}
		foreach (UberText uberText in go.GetComponentsInChildren<UberText>(includeInactive))
		{
			//Color textColor = uberText.TextColor;
			//uberText.TextColor = new Color(textColor.r, textColor.g, textColor.b, alpha);
		}
	}

	// Token: 0x0600806D RID: 32877 RVA: 0x00299F5A File Offset: 0x0029815A
	public static float GetMainTextureScaleX(GameObject go)
	{
		return RenderUtils.GetMainTextureScaleX(go.GetComponent<Renderer>());
	}

	// Token: 0x0600806E RID: 32878 RVA: 0x00299F67 File Offset: 0x00298167
	public static float GetMainTextureScaleX(Component c)
	{
		return RenderUtils.GetMainTextureScaleX(c.GetComponent<Renderer>());
	}

	// Token: 0x0600806F RID: 32879 RVA: 0x00299F74 File Offset: 0x00298174
	public static float GetMainTextureScaleX(Renderer r)
	{
		RenderMaterialCleaner.AttachTo(r);
		return r.material.mainTextureScale.x;
	}

	// Token: 0x06008070 RID: 32880 RVA: 0x00299F8C File Offset: 0x0029818C
	public static void SetMainTextureScaleX(Component c, float x)
	{
		RenderUtils.SetMainTextureScaleX(c.GetComponent<Renderer>(), x);
	}

	// Token: 0x06008071 RID: 32881 RVA: 0x00299F9A File Offset: 0x0029819A
	public static void SetMainTextureScaleX(GameObject go, float x)
	{
		RenderUtils.SetMainTextureScaleX(go.GetComponent<Renderer>(), x);
	}

	// Token: 0x06008072 RID: 32882 RVA: 0x00299FA8 File Offset: 0x002981A8
	public static void SetMainTextureScaleX(Renderer r, float x)
	{
		RenderMaterialCleaner.AttachTo(r);
		Vector2 mainTextureScale = r.material.mainTextureScale;
		mainTextureScale.x = x;
		r.material.mainTextureScale = mainTextureScale;
	}

	// Token: 0x06008073 RID: 32883 RVA: 0x00299FDB File Offset: 0x002981DB
	public static float GetMainTextureScaleY(GameObject go)
	{
		return RenderUtils.GetMainTextureScaleY(go.GetComponent<Renderer>());
	}

	// Token: 0x06008074 RID: 32884 RVA: 0x00299FE8 File Offset: 0x002981E8
	public static float GetMainTextureScaleY(Component c)
	{
		return RenderUtils.GetMainTextureScaleY(c.GetComponent<Renderer>());
	}

	// Token: 0x06008075 RID: 32885 RVA: 0x00299FF5 File Offset: 0x002981F5
	public static float GetMainTextureScaleY(Renderer r)
	{
		RenderMaterialCleaner.AttachTo(r);
		return r.material.mainTextureScale.y;
	}

	// Token: 0x06008076 RID: 32886 RVA: 0x0029A00D File Offset: 0x0029820D
	public static void SetMainTextureScaleY(Component c, float y)
	{
		RenderUtils.SetMainTextureScaleY(c.GetComponent<Renderer>(), y);
	}

	// Token: 0x06008077 RID: 32887 RVA: 0x0029A01B File Offset: 0x0029821B
	public static void SetMainTextureScaleY(GameObject go, float y)
	{
		RenderUtils.SetMainTextureScaleY(go.GetComponent<Renderer>(), y);
	}

	// Token: 0x06008078 RID: 32888 RVA: 0x0029A02C File Offset: 0x0029822C
	public static void SetMainTextureScaleY(Renderer r, float y)
	{
		RenderMaterialCleaner.AttachTo(r);
		Vector2 mainTextureScale = r.material.mainTextureScale;
		mainTextureScale.y = y;
		r.material.mainTextureScale = mainTextureScale;
	}

	// Token: 0x06008079 RID: 32889 RVA: 0x0029A05F File Offset: 0x0029825F
	public static float GetMainTextureOffsetX(GameObject go)
	{
		return RenderUtils.GetMainTextureOffsetX(go.GetComponent<Renderer>());
	}

	// Token: 0x0600807A RID: 32890 RVA: 0x0029A06C File Offset: 0x0029826C
	public static float GetMainTextureOffsetX(Component c)
	{
		return RenderUtils.GetMainTextureOffsetX(c.GetComponent<Renderer>());
	}

	// Token: 0x0600807B RID: 32891 RVA: 0x0029A079 File Offset: 0x00298279
	public static float GetMainTextureOffsetX(Renderer r)
	{
		RenderMaterialCleaner.AttachTo(r);
		return r.material.mainTextureOffset.x;
	}

	// Token: 0x0600807C RID: 32892 RVA: 0x0029A091 File Offset: 0x00298291
	public static void SetMainTextureOffsetX(Component c, float x)
	{
		RenderUtils.SetMainTextureOffsetY(c.GetComponent<Renderer>(), x);
	}

	// Token: 0x0600807D RID: 32893 RVA: 0x0029A09F File Offset: 0x0029829F
	public static void SetMainTextureOffsetX(GameObject go, float x)
	{
		RenderUtils.SetMainTextureOffsetY(go.GetComponent<Renderer>(), x);
	}

	// Token: 0x0600807E RID: 32894 RVA: 0x0029A0B0 File Offset: 0x002982B0
	public static void SetMainTextureOffsetX(Renderer r, float x)
	{
		RenderMaterialCleaner.AttachTo(r);
		Vector2 mainTextureOffset = r.material.mainTextureOffset;
		mainTextureOffset.x = x;
		r.material.mainTextureOffset = mainTextureOffset;
	}

	// Token: 0x0600807F RID: 32895 RVA: 0x0029A0E3 File Offset: 0x002982E3
	public static float GetMainTextureOffsetY(GameObject go)
	{
		return RenderUtils.GetMainTextureOffsetY(go.GetComponent<Renderer>());
	}

	// Token: 0x06008080 RID: 32896 RVA: 0x0029A0F0 File Offset: 0x002982F0
	public static float GetMainTextureOffsetY(Component c)
	{
		return RenderUtils.GetMainTextureOffsetY(c.GetComponent<Renderer>());
	}

	// Token: 0x06008081 RID: 32897 RVA: 0x0029A0FD File Offset: 0x002982FD
	public static float GetMainTextureOffsetY(Renderer r)
	{
		RenderMaterialCleaner.AttachTo(r);
		return r.material.mainTextureOffset.y;
	}

	// Token: 0x06008082 RID: 32898 RVA: 0x0029A091 File Offset: 0x00298291
	public static void SetMainTextureOffsetY(Component c, float y)
	{
		RenderUtils.SetMainTextureOffsetY(c.GetComponent<Renderer>(), y);
	}

	// Token: 0x06008083 RID: 32899 RVA: 0x0029A09F File Offset: 0x0029829F
	public static void SetMainTextureOffsetY(GameObject go, float y)
	{
		RenderUtils.SetMainTextureOffsetY(go.GetComponent<Renderer>(), y);
	}

	// Token: 0x06008084 RID: 32900 RVA: 0x0029A118 File Offset: 0x00298318
	public static void SetMainTextureOffsetY(Renderer r, float y)
	{
		RenderMaterialCleaner.AttachTo(r);
		Vector2 mainTextureOffset = r.material.mainTextureOffset;
		mainTextureOffset.y = y;
		r.material.mainTextureOffset = mainTextureOffset;
	}

	// Token: 0x06008085 RID: 32901 RVA: 0x0029A14C File Offset: 0x0029834C
	public static void DestroyCreatedMaterials(Renderer r)
	{
		if (r == null)
		{
			return;
		}
		Material[] materials = r.materials;
		if (materials == null)
		{
			return;
		}
		for (int i = materials.Length - 1; i >= 0; i--)
		{
			Material material = materials[i];
			if (material != null)
			{
				RenderUtils.DestroyMaterial(material);
			}
		}
	}

	// Token: 0x06008086 RID: 32902 RVA: 0x0029A194 File Offset: 0x00298394
	public static void DestroyCreatedMaterials(GameObject go)
	{
		if (go == null)
		{
			return;
		}
		foreach (Renderer renderer in go.GetComponents<Renderer>())
		{
			if (renderer != null)
			{
				RenderUtils.DestroyCreatedMaterials(renderer);
			}
		}
	}

	// Token: 0x06008087 RID: 32903 RVA: 0x0029A1D3 File Offset: 0x002983D3
	public static void SafeRemoveMaterial(Material m)
	{
		if (m != null && m.GetInstanceID() < 0)
		{
			RenderUtils.DestroyMaterial(m);
		}
	}

	// Token: 0x06008088 RID: 32904 RVA: 0x0029A1ED File Offset: 0x002983ED
	private static void DestroyMaterial(Material m)
	{
		UnityEngine.Object.Destroy(m);
	}
}
