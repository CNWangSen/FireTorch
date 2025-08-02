using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020009F6 RID: 2550
public class ShaderPreCompiler : MonoBehaviour
{
	// Token: 0x060086F2 RID: 34546 RVA: 0x002C3A18 File Offset: 0x002C1C18
	private void Start()
	{
		//if (GraphicsManager.Get().isVeryLowQualityDevice())
		//{
		//	Debug.Log("ShaderPreCompiler: Disabled, very low quality mode");
		//	return;
		//}
		//if (GraphicsManager.Get().RenderQualityLevel != GraphicsQuality.Low)
		//{
			base.StartCoroutine(this.WarmupShaders(this.m_StartupCompileShaders));
		//}
		//SceneMgr.Get().RegisterScenePreUnloadEvent(new SceneMgr.ScenePreUnloadCallback(this.WarmupSceneChangeShader));
		this.AddShader(this.m_GoldenUberShader.name, this.m_GoldenUberShader);
		foreach (Shader shader in this.m_StartupCompileShaders)
		{
			if (!(shader == null))
			{
				this.AddShader(shader.name, shader);
			}
		}
		foreach (Shader shader2 in this.m_SceneChangeCompileShaders)
		{
			if (!(shader2 == null))
			{
				this.AddShader(shader2.name, shader2);
			}
		}
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x002C3AE8 File Offset: 0x002C1CE8
	public static Shader GetShader(string shaderName)
	{
		Shader shader;
		if (ShaderPreCompiler.s_shaderCache.TryGetValue(shaderName, out shader))
		{
			return shader;
		}
		shader = Shader.Find(shaderName);
		if (shader != null)
		{
			ShaderPreCompiler.s_shaderCache.Add(shaderName, shader);
		}
		return shader;
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x002C3B23 File Offset: 0x002C1D23
	private void AddShader(string shaderName, Shader shader)
	{
		if (ShaderPreCompiler.s_shaderCache.ContainsKey(shaderName))
		{
			return;
		}
		ShaderPreCompiler.s_shaderCache.Add(shaderName, shader);
	}

	// Token: 0x060086F5 RID: 34549 RVA: 0x002C3B40 File Offset: 0x002C1D40
	private void WarmupSceneChangeShader(SceneMgr.Mode prevMode, PegasusScene prevScene, object userData)
	{
		//if ((SceneMgr.Get().GetMode() == SceneMgr.Mode.GAMEPLAY || SceneMgr.Get().GetMode() == SceneMgr.Mode.COLLECTIONMANAGER || SceneMgr.Get().IsInTavernBrawlMode()) && Network.ShouldBeConnectedToAurora())
		//{
			base.StartCoroutine(this.WarmupGoldenUberShader());
			this.PremiumShadersCompiled = true;
		//}
		if (prevMode != SceneMgr.Mode.HUB)
		{
			return;
		}
		if (this.SceneChangeShadersCompiled)
		{
			return;
		}
		this.SceneChangeShadersCompiled = true;
		//if (GraphicsManager.Get().RenderQualityLevel != GraphicsQuality.Low)
		//{
			base.StartCoroutine(this.WarmupShaders(this.m_SceneChangeCompileShaders));
		//}
		if (this.SceneChangeShadersCompiled && this.PremiumShadersCompiled)
		{
			//SceneMgr.Get().UnregisterScenePreUnloadEvent(new SceneMgr.ScenePreUnloadCallback(this.WarmupSceneChangeShader));
		}
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x002C3BE9 File Offset: 0x002C1DE9
	private IEnumerator WarmupGoldenUberShader()
	{
		float totalTime = 0f;
		foreach (string kw in this.GOLDEN_UBER_KEYWORDS1)
		{
			foreach (string text in this.GOLDEN_UBER_KEYWORDS2)
			{
				ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
				shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant
				{
					shader = this.m_GoldenUberShader,
					keywords = new string[]
					{
						kw,
						text
					}
				});
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				shaderVariantCollection.WarmUp();
				float realtimeSinceStartup2 = Time.realtimeSinceStartup;
				totalTime += realtimeSinceStartup2 - realtimeSinceStartup;
				//Log.Graphics.Print(string.Format("Golden Uber Shader Compile: {0} Keywords: {1}, {2} ({3}s)", new object[]
				//{
				//	this.m_GoldenUberShader.name,
				//	kw,
				//	text,
				//	realtimeSinceStartup2 - realtimeSinceStartup
				//}), Array.Empty<object>());
				yield return null;
			}
			string[] array2 = null;
			//kw = null;
		}
		string[] array = null;
		//Log.Graphics.Print("Profiling Shader Warmup: " + totalTime, Array.Empty<object>());
		yield break;
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x002C3BF8 File Offset: 0x002C1DF8
	private IEnumerator WarmupShaders(Shader[] shaders)
	{
		float totalTime = 0f;
		foreach (Shader shader in shaders)
		{
			if (!(shader == null))
			{
				ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
				shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant
				{
					shader = shader
				});
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				shaderVariantCollection.WarmUp();
				float realtimeSinceStartup2 = Time.realtimeSinceStartup;
				totalTime += realtimeSinceStartup2 - realtimeSinceStartup;
				//Log.Graphics.Print(string.Format("Shader Compile: {0} ({1}s)", shader.name, realtimeSinceStartup2 - realtimeSinceStartup), Array.Empty<object>());
				yield return null;
			}
		}
		Shader[] array = null;
		yield break;
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x002C3C08 File Offset: 0x002C1E08
	private GameObject CreateMesh(string name)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = name;
		gameObject.transform.parent = base.gameObject.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		mesh.vertices = this.MESH_VERTS;
		mesh.uv = this.MESH_UVS;
		mesh.normals = this.MESH_NORMALS;
		mesh.tangents = this.MESH_TANGENTS;
		mesh.triangles = this.MESH_TRIANGLES;
		gameObject.GetComponent<MeshFilter>().mesh = mesh;
		return gameObject;
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x002C3CC3 File Offset: 0x002C1EC3
	private Material CreateMaterial(string name, Shader shader)
	{
		return new Material(shader)
		{
			name = name
		};
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x002C3CD4 File Offset: 0x002C1ED4
	public ShaderPreCompiler()
	{
		int[] array = new int[3];
		array[0] = 2;
		array[1] = 1;
		this.MESH_TRIANGLES = array;
		//base..ctor();
	}

	// Token: 0x04006D12 RID: 27922
	private readonly string[] GOLDEN_UBER_KEYWORDS1 = new string[]
	{
		"FX3_ADDBLEND",
		"FX3_ALPHABLEND"
	};

	// Token: 0x04006D13 RID: 27923
	private readonly string[] GOLDEN_UBER_KEYWORDS2 = new string[]
	{
		"LAYER3",
		"FX3_FLOWMAP",
		"LAYER4"
	};

	// Token: 0x04006D14 RID: 27924
	private readonly Vector3[] MESH_VERTS = new Vector3[]
	{
		Vector3.zero,
		Vector3.zero,
		Vector3.zero
	};

	// Token: 0x04006D15 RID: 27925
	private readonly Vector2[] MESH_UVS = new Vector2[]
	{
		new Vector2(0f, 0f),
		new Vector2(1f, 0f),
		new Vector2(0f, 1f)
	};

	// Token: 0x04006D16 RID: 27926
	private readonly Vector3[] MESH_NORMALS = new Vector3[]
	{
		Vector3.up,
		Vector3.up,
		Vector3.up
	};

	// Token: 0x04006D17 RID: 27927
	private readonly Vector4[] MESH_TANGENTS = new Vector4[]
	{
		new Vector4(1f, 0f, 0f, 0f),
		new Vector4(1f, 0f, 0f, 0f),
		new Vector4(1f, 0f, 0f, 0f)
	};

	// Token: 0x04006D18 RID: 27928
	private readonly int[] MESH_TRIANGLES;

	// Token: 0x04006D19 RID: 27929
	public Shader m_GoldenUberShader;

	// Token: 0x04006D1A RID: 27930
	public Shader[] m_StartupCompileShaders;

	// Token: 0x04006D1B RID: 27931
	public Shader[] m_SceneChangeCompileShaders;

	// Token: 0x04006D1C RID: 27932
	protected static Dictionary<string, Shader> s_shaderCache = new Dictionary<string, Shader>();

	// Token: 0x04006D1D RID: 27933
	private bool SceneChangeShadersCompiled;

	// Token: 0x04006D1E RID: 27934
	private bool PremiumShadersCompiled;
}
