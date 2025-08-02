using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020009DF RID: 2527
public class RenderToTexture : MonoBehaviour
{

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06008604 RID: 34308 RVA: 0x002BBBC8 File Offset: 0x002B9DC8
	protected Vector3 Offset
	{
		get
		{
			if (this.m_Offset == Vector3.zero)
			{
				RenderToTexture.s_offset.x = RenderToTexture.s_offset.x - 300f;
				if (RenderToTexture.s_offset.x < -90000f)
				{
					RenderToTexture.s_offset.x = -4000f;
					RenderToTexture.s_offset.y = RenderToTexture.s_offset.y - 300f;
					if (RenderToTexture.s_offset.y < -90000f)
					{
						RenderToTexture.s_offset.y = -4000f;
						RenderToTexture.s_offset.z = RenderToTexture.s_offset.z - 300f;
						if (RenderToTexture.s_offset.z < -90000f)
						{
							RenderToTexture.s_offset.z = -4000f;
						}
					}
				}
				this.m_Offset = RenderToTexture.s_offset;
			}
			return this.m_Offset;
		}
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x06008605 RID: 34309 RVA: 0x002BBC94 File Offset: 0x002B9E94
	protected Material AlphaBlendMaterial
	{
		get
		{
			if (this.m_AlphaBlendMaterial == null)
			{
				if (this.m_AlphaBlendShader == null)
				{
					this.m_AlphaBlendShader = ShaderUtils.FindShader(ALPHA_BLEND_SHADER_NAME);//"Hidden/R2TColorAlphaCombine");
					if (!this.m_AlphaBlendShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TColorAlphaCombine");
					}
				}
				this.m_AlphaBlendMaterial = new Material(this.m_AlphaBlendShader);
				////SceneUtils.SetHideFlags(this.m_AlphaBlendMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaBlendMaterial;
		}
	}

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x06008606 RID: 34310 RVA: 0x002BBD08 File Offset: 0x002B9F08
	protected Material AlphaBlendAddMaterial
	{
		get
		{
			if (this.m_AlphaBlendAddMaterial == null)
			{
				if (this.m_AlphaBlendAddShader == null)
				{
					this.m_AlphaBlendAddShader = ShaderUtils.FindShader(ALPHA_BLEND_ADD_SHADER_NAME);//"Hidden/R2TColorAlphaCombineAdd");
					if (!this.m_AlphaBlendAddShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TColorAlphaCombineAdd");
					}
				}
				this.m_AlphaBlendAddMaterial = new Material(this.m_AlphaBlendAddShader);
				////SceneUtils.SetHideFlags(this.m_AlphaBlendAddMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaBlendAddMaterial;
		}
	}

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06008607 RID: 34311 RVA: 0x002BBD7C File Offset: 0x002B9F7C
	protected Material AdditiveMaterial
	{
		get
		{
			if (this.m_AdditiveMaterial == null)
			{
				if (this.m_AdditiveShader == null)
				{
					this.m_AdditiveShader = ShaderUtils.FindShader(ADDITIVE_SHADER_NAME);//"Hidden/R2TAdditive");
					if (!this.m_AdditiveShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TAdditive");
					}
				}
				this.m_AdditiveMaterial = new Material(this.m_AdditiveShader);
				////SceneUtils.SetHideFlags(this.m_AdditiveMaterial, HideFlags.DontSave);
			}
			return this.m_AdditiveMaterial;
		}
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06008608 RID: 34312 RVA: 0x002BBDF0 File Offset: 0x002B9FF0
	protected Material BloomMaterial
	{
		get
		{
			if (this.m_BloomMaterial == null)
			{
				if (this.m_BloomShader == null)
				{
					this.m_BloomShader = ShaderUtils.FindShader(BLOOM_SHADER_NAME);//"Hidden/R2TBloom");
					if (!this.m_BloomShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TBloom");
					}
				}
				this.m_BloomMaterial = new Material(this.m_BloomShader);
				////SceneUtils.SetHideFlags(this.m_BloomMaterial, HideFlags.DontSave);
			}
			return this.m_BloomMaterial;
		}
	}

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x06008609 RID: 34313 RVA: 0x002BBE64 File Offset: 0x002BA064
	protected Material BloomMaterialAlpha
	{
		get
		{
			if (this.m_BloomMaterialAlpha == null)
			{
				if (this.m_BloomShaderAlpha == null)
				{
					this.m_BloomShaderAlpha = ShaderUtils.FindShader(BLOOM_ALPHA_SHADER_NAME);//"Hidden/R2TBloomAlpha");
					if (!this.m_BloomShaderAlpha)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TBloomAlpha");
					}
				}
				this.m_BloomMaterialAlpha = new Material(this.m_BloomShaderAlpha);
				////SceneUtils.SetHideFlags(this.m_BloomMaterialAlpha, HideFlags.DontSave);
			}
			return this.m_BloomMaterialAlpha;
		}
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x0600860A RID: 34314 RVA: 0x002BBED8 File Offset: 0x002BA0D8
	protected Material BlurMaterial
	{
		get
		{
			if (this.m_BlurMaterial == null)
			{
				if (this.m_BlurShader == null)
				{
					this.m_BlurShader = ShaderUtils.FindShader(BLUR_SHADER_NAME);//"Hidden/R2TBlur");
					if (!this.m_BlurShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TBlur");
					}
				}
				this.m_BlurMaterial = new Material(this.m_BlurShader);
				////SceneUtils.SetHideFlags(this.m_BlurMaterial, HideFlags.DontSave);
			}
			return this.m_BlurMaterial;
		}
	}

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x0600860B RID: 34315 RVA: 0x002BBF4C File Offset: 0x002BA14C
	protected Material AlphaBlurMaterial
	{
		get
		{
			if (this.m_AlphaBlurMaterial == null)
			{
				if (this.m_AlphaBlurShader == null)
				{
					this.m_AlphaBlurShader = ShaderUtils.FindShader(BLUR_ALPHA_SHADER_NAME);//"Hidden/R2TAlphaBlur");
					if (!this.m_AlphaBlurShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TAlphaBlur");
					}
				}
				this.m_AlphaBlurMaterial = new Material(this.m_AlphaBlurShader);
				////SceneUtils.SetHideFlags(this.m_AlphaBlurMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaBlurMaterial;
		}
	}

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x0600860C RID: 34316 RVA: 0x002BBFC0 File Offset: 0x002BA1C0
	protected Material TransparentMaterial
	{
		get
		{
			if (this.m_TransparentMaterial == null)
			{
				if (this.m_TransparentShader == null)
				{
					this.m_TransparentShader = ShaderUtils.FindShader(TRANSPARENT_SHADER_NAME);//"Hidden/R2TTransparent");
					if (!this.m_TransparentShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TTransparent");
					}
				}
				this.m_TransparentMaterial = new Material(this.m_TransparentShader);
				////SceneUtils.SetHideFlags(this.m_TransparentMaterial, HideFlags.DontSave);
			}
			return this.m_TransparentMaterial;
		}
	}

	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x0600860D RID: 34317 RVA: 0x002BC034 File Offset: 0x002BA234
	protected Material AlphaClipMaterial
	{
		get
		{
			if (this.m_AlphaClipMaterial == null)
			{
				if (this.m_AlphaClipShader == null)
				{
					this.m_AlphaClipShader = ShaderUtils.FindShader(ALPHA_CLIP_SHADER_NAME);//"Hidden/R2TAlphaClip");
					if (!this.m_AlphaClipShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TAlphaClip");
					}
				}
				this.m_AlphaClipMaterial = new Material(this.m_AlphaClipShader);
				////SceneUtils.SetHideFlags(this.m_AlphaClipMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaClipMaterial;
		}
	}

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x0600860E RID: 34318 RVA: 0x002BC0A8 File Offset: 0x002BA2A8
	protected Material AlphaClipBloomMaterial
	{
		get
		{
			if (this.m_AlphaClipBloomMaterial == null)
			{
				if (this.m_AlphaClipBloomShader == null)
				{
					this.m_AlphaClipBloomShader = ShaderUtils.FindShader(ALPHA_CLIP_BLOOM_SHADER_NAME);//"Hidden/R2TAlphaClipBloom");
					if (!this.m_AlphaClipBloomShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TAlphaClipBloom");
					}
				}
				this.m_AlphaClipBloomMaterial = new Material(this.m_AlphaClipBloomShader);
				////SceneUtils.SetHideFlags(this.m_AlphaClipBloomMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaClipBloomMaterial;
		}
	}

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x0600860F RID: 34319 RVA: 0x002BC11C File Offset: 0x002BA31C
	protected Material AlphaClipGradientMaterial
	{
		get
		{
			if (this.m_AlphaClipGradientMaterial == null)
			{
				if (this.m_AlphaClipGradientShader == null)
				{
					this.m_AlphaClipGradientShader = ShaderUtils.FindShader(ALPHA_CLIP_GRADIENT_SHADER_NAME);//"Hidden/R2TAlphaClipGradient");
					if (!this.m_AlphaClipGradientShader)
					{
						Debug.LogError("Failed to load RenderToTexture Shader: Hidden/R2TAlphaClipGradient");
					}
				}
				this.m_AlphaClipGradientMaterial = new Material(this.m_AlphaClipGradientShader);
				//SceneUtils.SetHideFlags(this.m_AlphaClipGradientMaterial, HideFlags.DontSave);
			}
			return this.m_AlphaClipGradientMaterial;
		}
	}

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06008611 RID: 34321 RVA: 0x002BC199 File Offset: 0x002BA399
	// (set) Token: 0x06008610 RID: 34320 RVA: 0x002BC190 File Offset: 0x002BA390
	public bool DontRefreshOnFocus { get; set; }

	// Token: 0x06008612 RID: 34322 RVA: 0x002BC1A4 File Offset: 0x002BA3A4
	private void Awake()
	{
		
		this.m_AlphaFillShader = ShaderUtils.FindShader(ALPHA_FILL_SHADER_NAME);//"Custom/AlphaFillOpaque");
		if (!this.m_AlphaFillShader)
		{
			Debug.LogError("Failed to load RenderToTexture Shader: Custom/AlphaFillOpaque");
		}
		this.m_OffscreenPos = this.Offset;
		if (this.m_Material != null)
		{
			this.m_Material = UnityEngine.Object.Instantiate<Material>(this.m_Material);
		}
		
	}

	// Token: 0x06008613 RID: 34323 RVA: 0x002BC203 File Offset: 0x002BA403
	private void Start()
	{
		if (this.m_RenderOnStart)
		{
			this.m_isDirty = true;
		}
		this.Init();
	}

	// Token: 0x06008614 RID: 34324 RVA: 0x002BC21C File Offset: 0x002BA41C
	private void Update()
	{
		if (!this.m_renderEnabled)
		{
			return;
		}
		if (this.m_RenderTexture && !this.m_RenderTexture.IsCreated())
		{
			//Log.Graphics.Print("RenderToTexture Texture lost. Render Called", Array.Empty<object>());
			this.m_isDirty = true;
			this.RenderTex();
			return;
		}
		if (this.m_LateUpdate)
		{
			return;
		}
		if (this.m_HideRenderObject && this.m_ObjectToRender)
		{
			this.PositionHiddenObjectsAndCameras();
		}
		if (this.m_RealtimeRender || this.m_isDirty)
		{
			this.RenderTex();
		}
	}

	// Token: 0x06008615 RID: 34325 RVA: 0x002BC2A8 File Offset: 0x002BA4A8
	private void LateUpdate()
	{
		if (!this.m_renderEnabled)
		{
			return;
		}
		if (this.m_LateUpdate)
		{
			if (this.m_HideRenderObject && this.m_ObjectToRender)
			{
				this.PositionHiddenObjectsAndCameras();
			}
			if (this.m_RealtimeRender || this.m_isDirty)
			{
				this.RenderTex();
				return;
			}
		}
		else
		{
			if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClipBloom || this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.Bloom)
			{
				//this.RenderBloom();
				return;
			}
			if (this.m_BloomPlaneGameObject)
			{
				UnityEngine.Object.DestroyImmediate(this.m_BloomPlaneGameObject);
			}
		}
	}

	// Token: 0x06008616 RID: 34326 RVA: 0x002BC329 File Offset: 0x002BA529
	private void OnApplicationFocus(bool state)
	{
		if (this.DontRefreshOnFocus)
		{
			return;
		}
		if (this.m_RenderTexture && state)
		{
			this.m_isDirty = true;
			this.RenderTex();
		}
	}

	// Token: 0x06008617 RID: 34327 RVA: 0x002BC350 File Offset: 0x002BA550
	private void OnDrawGizmos()
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.m_FarClip < 0f)
		{
			this.m_FarClip = 0f;
		}
		if (this.m_NearClip > 0f)
		{
			this.m_NearClip = 0f;
		}
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Vector3 a = new Vector3(0f, -this.m_NearClip * 0.5f, 0f);
		Gizmos.color = new Color(0.1f, 0.5f, 0.7f, 0.8f);
		Gizmos.DrawWireCube(a + this.m_PositionOffset, new Vector3(this.m_Width, -this.m_NearClip, this.m_Height));
		Gizmos.color = new Color(0.2f, 0.2f, 0.9f, 0.8f);
		Gizmos.DrawWireCube(new Vector3(0f, -this.m_FarClip * 0.5f, 0f) + this.m_PositionOffset, new Vector3(this.m_Width, -this.m_FarClip, this.m_Height));
		Gizmos.color = new Color(0.8f, 0.8f, 1f, 1f);
		Gizmos.DrawWireCube(this.m_PositionOffset, new Vector3(this.m_Width, 0f, this.m_Height));
		Gizmos.matrix = Matrix4x4.identity;
	}

	// Token: 0x06008618 RID: 34328 RVA: 0x002BC4B4 File Offset: 0x002BA6B4
	private void OnDisable()
	{
		
		this.RestoreAfterRender();
		if (this.m_ObjectToRender)
		{
			if (this.m_ObjectToRenderOrgParent != null)
			{
				//this.m_ObjectToRender.transform.parent = this.m_ObjectToRenderOrgParent;
			}
			this.m_ObjectToRender.transform.localPosition = this.m_ObjectToRenderOrgPosition;
		}
		if (this.m_PlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_PlaneGameObject);
		}
		if (this.m_BloomPlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_BloomPlaneGameObject);
		}
		if (this.m_BloomCapturePlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_BloomCapturePlaneGameObject);
		}
		if (this.m_BloomCaptureCameraGO)
		{
			UnityEngine.Object.Destroy(this.m_BloomCaptureCameraGO);
		}
		this.ReleaseTexture();
		if (this.m_Camera)
		{
			this.m_Camera.enabled = false;
		}
		if (this.m_AlphaCamera)
		{
			this.m_AlphaCamera.enabled = false;
		}
		this.m_init = false;
		this.m_isDirty = true;
	
	}

	// Token: 0x06008619 RID: 34329 RVA: 0x002BC5B4 File Offset: 0x002BA7B4
	private void OnDestroy()
	{
		this.CleanUp();
	}

	// Token: 0x0600861A RID: 34330 RVA: 0x002BC5BC File Offset: 0x002BA7BC
	private void OnEnable()
	{
		if (this.m_RenderOnEnable)
		{
			this.RenderTex();
		}
	}

	// Token: 0x0600861B RID: 34331 RVA: 0x002BC5CC File Offset: 0x002BA7CC
	public RenderTexture Render()
	{
		this.m_isDirty = true;
		return this.m_RenderTexture;
	}

	// Token: 0x0600861C RID: 34332 RVA: 0x002BC5DB File Offset: 0x002BA7DB
	public RenderTexture RenderNow()
	{
		this.RenderTex();
		return this.m_RenderTexture;
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x002BC5E9 File Offset: 0x002BA7E9
	public void ForceTextureRebuild()
	{
		if (!base.enabled)
		{
			return;
		}
		this.ReleaseTexture();
		this.m_isDirty = true;
		this.RenderTex();
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x002BC607 File Offset: 0x002BA807
	public void Show()
	{
		this.Show(false);
	}

	// Token: 0x0600861F RID: 34335 RVA: 0x002BC610 File Offset: 0x002BA810
	public void Show(bool render)
	{
		this.m_renderEnabled = true;
		if (this.m_RenderToObject)
		{
			this.m_RenderToObject.GetComponent<Renderer>().enabled = true;
		}
		else if (this.m_PlaneGameObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = true;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = true;
			}
		}
		if (render)
		{
			this.Render();
		}
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x002BC68C File Offset: 0x002BA88C
	public void Hide()
	{
		this.m_renderEnabled = false;
		if (this.m_RenderToObject)
		{
			this.m_RenderToObject.GetComponent<Renderer>().enabled = false;
			return;
		}
		if (this.m_PlaneGameObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = false;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = false;
			}
		}
	}

	// Token: 0x06008621 RID: 34337 RVA: 0x002BC6FB File Offset: 0x002BA8FB
	public void SetDirty()
	{
		this.m_init = false;
		this.m_isDirty = true;
	}

	// Token: 0x06008622 RID: 34338 RVA: 0x002BC70C File Offset: 0x002BA90C
	public Material GetRenderMaterial()
	{
		if (this.m_RenderToObject)
		{
			return this.m_RenderToObject.GetComponent<Renderer>().material;
		}
		if (this.m_PlaneGameObject)
		{
			return this.m_PlaneGameObject.GetComponent<Renderer>().material;
		}
		return this.m_Material;
	}

	// Token: 0x06008623 RID: 34339 RVA: 0x002BC75B File Offset: 0x002BA95B
	public GameObject GetRenderToObject()
	{
		if (this.m_RenderToObject)
		{
			return this.m_RenderToObject;
		}
		return this.m_PlaneGameObject;
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x002BC777 File Offset: 0x002BA977
	public RenderTexture GetRenderTexture()
	{
		return this.m_RenderTexture;
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x002BC77F File Offset: 0x002BA97F
	public Vector3 GetOffscreenPosition()
	{
		return this.m_OffscreenPos;
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x002BC787 File Offset: 0x002BA987
	public Vector3 GetOffscreenPositionOffset()
	{
		return this.m_OffscreenPos - base.transform.position;
	}

	// Token: 0x06008627 RID: 34343 RVA: 0x002BC7A0 File Offset: 0x002BA9A0
	private void Init()
	{
		if (this.m_init)
		{
			return;
		}
		if (this.m_RealtimeTranslation)
		{
			this.m_OffscreenGameObject = new GameObject();
			this.m_OffscreenGameObject.name = string.Format("R2TOffsetRenderRoot_{0}", base.name);
			this.m_OffscreenGameObject.transform.rotation=Quaternion.Euler(Vector3.zero);
			this.m_OffscreenGameObject.transform.position = base.transform.position;
		}
		if (this.m_ObjectToRender)
		{
			if (!this.m_ObjectToRenderOrgPositionStored)
			{
				this.m_ObjectToRenderOrgParent = this.m_ObjectToRender.transform.parent;
				this.m_ObjectToRenderOrgPosition = this.m_ObjectToRender.transform.localPosition;
				this.m_ObjectToRenderOrgPositionStored = true;
			}
			if (this.m_HideRenderObject)
			{
				if (this.m_RealtimeTranslation)
				{
					this.m_ObjectToRender.transform.parent = this.m_OffscreenGameObject.transform;
					this.m_ObjectToRender.transform.rotation =  Quaternion.Euler(Vector3.zero);
					if (this.m_AlphaObjectToRender)
					{
						this.m_AlphaObjectToRender.transform.parent = this.m_OffscreenGameObject.transform;
					}
				}
				if (this.m_RenderToObject)
				{
					this.m_OriginalRenderPosition = this.m_RenderToObject.transform.position;
				}
				else
				{
					this.m_OriginalRenderPosition = base.transform.position;
				}
				if (this.m_ObjectToRender && this.m_ObjectToRenderOffset == Vector3.zero)
				{
					this.m_ObjectToRenderOffset = base.transform.position - this.m_ObjectToRender.transform.position;
				}
				if (this.m_AlphaObjectToRender && this.m_AlphaObjectToRenderOffset == Vector3.zero)
				{
					this.m_AlphaObjectToRenderOffset = base.transform.position - this.m_AlphaObjectToRender.transform.position;
				}
			}
		}
		else if (!this.m_ObjectToRenderOrgPositionStored)
		{
			this.m_ObjectToRenderOrgPosition = base.transform.localPosition;
			if (this.m_OffscreenGameObject != null)
			{
				this.m_OffscreenGameObject.transform.position = base.transform.position;
			}
			this.m_ObjectToRenderOrgPositionStored = true;
		}
		if (this.m_HideRenderObject)
		{
			if (this.m_RealtimeTranslation)
			{
				if (this.m_OffscreenGameObject != null)
				{
					this.m_OffscreenGameObject.transform.position = this.m_OffscreenPos;
				}
			}
			else if (this.m_ObjectToRender)
			{
				this.m_ObjectToRender.transform.position = this.m_OffscreenPos;
			}
			else
			{
				base.transform.position = this.m_OffscreenPos;
			}
		}
		if (this.m_ObjectToRender == null)
		{
			this.m_ObjectToRender = base.gameObject;
		}
		this.CalcWorldWidthHeightScale();
		this.CreateTexture();
		this.CreateCamera();
		if (this.m_OpaqueObjectAlphaFill || this.m_RenderMeshAsAlpha || this.m_AlphaObjectToRender != null)
		{
			this.CreateAlphaCamera();
		}
		if (!this.m_RenderToObject && this.m_CreateRenderPlane)
		{
			this.CreateRenderPlane();
		}
		if (this.m_RenderToObject)
		{
			this.m_RenderToObject.GetComponent<Renderer>().material.renderQueue = this.m_RenderQueueOffset + this.m_RenderQueue;
		}
		this.SetupMaterial();
		this.m_init = true;
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x002BCAC4 File Offset: 0x002BACC4
	private void RenderTex()
	{
		if (!this.m_renderEnabled)
		{
			return;
		}
		this.Init();
		if (!this.m_init)
		{
			return;
		}
		if (this.m_Camera == null)
		{
			return;
		}
		this.SetupForRender();
		if (this.m_RenderMaterial != this.m_PreviousRenderMaterial || this.m_RenderQueue != this.m_previousRenderQueue)
		{
			this.SetupMaterial();
		}
		if (this.m_HideRenderObject && this.m_ObjectToRender)
		{
			this.PositionHiddenObjectsAndCameras();
		}
		if (this.m_OpaqueObjectAlphaFill || this.m_RenderMeshAsAlpha || this.m_AlphaObjectToRender != null)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(this.m_RenderTexture.width, this.m_RenderTexture.height, this.m_RenderTexture.depth, this.m_RenderTexture.format);
			this.m_Camera.targetTexture = temporary;
			this.CameraRender();
			RenderTexture temporary2 = RenderTexture.GetTemporary(this.m_RenderTexture.width, this.m_RenderTexture.height, this.m_RenderTexture.depth, RenderTextureFormat.Default);
			this.m_AlphaCamera.targetTexture = temporary2;
			this.AlphaCameraRender();
			if (this.m_OpaqueObjectAlphaFill)
			{
				this.AlphaBlendAddMaterial.SetTexture("_AlphaTex", temporary2);
			}
			else
			{
				this.AlphaBlendMaterial.SetTexture("_AlphaTex", temporary2);
			}
			if (this.m_BlurAmount > 0f)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(this.m_RenderTexture.width, this.m_RenderTexture.height, this.m_RenderTexture.depth, this.m_RenderTexture.format);
				if (this.m_OpaqueObjectAlphaFill)
				{
					Graphics.Blit(temporary, temporary3, this.AlphaBlendAddMaterial);
				}
				else
				{
					Graphics.Blit(temporary, temporary3, this.AlphaBlendMaterial);
				}
				this.CameraRender();
				Material sampleMat = this.BlurMaterial;
				if (this.m_BlurAlphaOnly)
				{
					sampleMat = this.AlphaBlurMaterial;
				}
				this.m_RenderTexture.DiscardContents();
				this.Sample(temporary3, this.m_RenderTexture, sampleMat, this.m_BlurAmount);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				this.m_RenderTexture.DiscardContents();
				if (this.m_OpaqueObjectAlphaFill)
				{
					Graphics.Blit(temporary, this.m_RenderTexture, this.AlphaBlendAddMaterial);
				}
				else
				{
					Graphics.Blit(temporary, this.m_RenderTexture, this.AlphaBlendMaterial);
				}
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
		}
		else if (this.m_BlurAmount > 0f)
		{
			RenderTexture temporary4 = RenderTexture.GetTemporary(this.m_RenderTexture.width, this.m_RenderTexture.height, this.m_RenderTexture.depth, this.m_RenderTexture.format);
			this.m_Camera.targetTexture = temporary4;
			this.CameraRender();
			Material sampleMat2 = this.BlurMaterial;
			if (this.m_BlurAlphaOnly)
			{
				sampleMat2 = this.m_AlphaBlurMaterial;
			}
			this.m_RenderTexture.DiscardContents();
			this.Sample(temporary4, this.m_RenderTexture, sampleMat2, this.m_BlurAmount);
			RenderTexture.ReleaseTemporary(temporary4);
		}
		else
		{
			this.m_Camera.targetTexture = this.m_RenderTexture;
			this.CameraRender();
		}
		if (this.m_RenderToObject)
		{
			Renderer renderer = this.m_RenderToObject.GetComponent<Renderer>();
			if (renderer == null)
			{
				renderer = this.m_RenderToObject.GetComponentInChildren<Renderer>();
			}
			if (this.m_ShaderTextureName != string.Empty)
			{
				renderer.material.SetTexture(this.m_ShaderTextureName, this.m_RenderTexture);
			}
			else
			{
				renderer.material.mainTexture = this.m_RenderTexture;
			}
		}
		else if (this.m_PlaneGameObject)
		{
			if (this.m_ShaderTextureName != string.Empty)
			{
				this.m_PlaneGameObject.GetComponent<Renderer>().material.SetTexture(this.m_ShaderTextureName, this.m_RenderTexture);
			}
			else
			{
				this.m_PlaneGameObject.GetComponent<Renderer>().material.mainTexture = this.m_RenderTexture;
			}
		}
		if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClip || this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClipBloom)
		{
			GameObject gameObject = this.m_PlaneGameObject;
			if (this.m_RenderToObject)
			{
				gameObject = this.m_RenderToObject;
			}
			Material material = gameObject.GetComponent<Renderer>().material;
			material.SetFloat("_Cutoff", this.m_AlphaClip);
			material.SetFloat("_Intensity", this.m_AlphaClipIntensity);
			material.SetFloat("_AlphaIntensity", this.m_AlphaClipAlphaIntensity);
			if (this.m_AlphaClipRenderStyle == RenderToTexture.AlphaClipShader.ColorGradient)
			{
				material.SetTexture("_GradientTex", this.m_AlphaClipGradientMap);
			}
		}
		if (!this.m_RealtimeRender)
		{
			this.RestoreAfterRender();
		}
		this.m_isDirty = false;
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x002BCF1C File Offset: 0x002BB11C
	private void RenderBloom()
	{
		if (this.m_BloomIntensity == 0f)
		{
			if (this.m_BloomPlaneGameObject)
			{
				UnityEngine.Object.DestroyImmediate(this.m_BloomPlaneGameObject);
			}
			return;
		}
		if (this.m_BloomIntensity == 0f)
		{
			if (this.m_BloomPlaneGameObject)
			{
				UnityEngine.Object.DestroyImmediate(this.m_BloomPlaneGameObject);
			}
			return;
		}
		int num = (int)((float)this.m_RenderTexture.width * Mathf.Clamp01(this.m_BloomResolutionRatio));
		int num2 = (int)((float)this.m_RenderTexture.height * Mathf.Clamp01(this.m_BloomResolutionRatio));
		RenderTexture renderTexture = this.m_RenderTexture;
		if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClipBloom)
		{
			if (!this.m_BloomPlaneGameObject)
			{
				this.CreateBloomPlane();
			}
			if (!this.m_BloomRenderTexture)
			{
				this.m_BloomRenderTexture = RenderTextureTracker.Get().CreateNewTexture(num, num2, 32, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
			}
		}
		if (!this.m_BloomRenderBuffer1)
		{
			this.m_BloomRenderBuffer1 = RenderTextureTracker.Get().CreateNewTexture(num, num2, 32, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		}
		if (!this.m_BloomRenderBuffer2)
		{
			this.m_BloomRenderBuffer2 = RenderTextureTracker.Get().CreateNewTexture(num, num2, 32, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		}
		Material material = this.BloomMaterial;
		if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClipBloom)
		{
			material = this.AlphaClipBloomMaterial;
			renderTexture = this.m_BloomRenderTexture;
			if (!this.m_BloomCaptureCameraGO)
			{
				this.CreateBloomCaptureCamera();
			}
			this.m_BloomCaptureCamera.targetTexture = this.m_BloomRenderTexture;
			material.SetFloat("_Cutoff", this.m_AlphaClip);
			material.SetFloat("_Intensity", this.m_AlphaClipIntensity);
			material.SetFloat("_AlphaIntensity", this.m_AlphaClipAlphaIntensity);
			this.m_BloomCaptureCamera.Render();
		}
		if (this.m_BloomRenderType == RenderToTexture.BloomRenderType.Alpha)
		{
			material = this.BloomMaterialAlpha;
			material.SetFloat("_AlphaIntensity", this.m_BloomAlphaIntensity);
		}
		float num3 = 1f / (float)num;
		float num4 = 1f / (float)num2;
		material.SetFloat("_Threshold", this.m_BloomThreshold);
		material.SetFloat("_Intensity", this.m_BloomIntensity / (1f - this.m_BloomThreshold));
		material.SetVector("_OffsetA", new Vector4(1.5f * num3, 1.5f * num4, -1.5f * num3, 1.5f * num4));
		material.SetVector("_OffsetB", new Vector4(-1.5f * num3, -1.5f * num4, 1.5f * num3, -1.5f * num4));
		this.m_BloomRenderBuffer2.DiscardContents();
		Graphics.Blit(renderTexture, this.m_BloomRenderBuffer2, material, 1);
		num3 *= 4f * this.m_BloomBlur;
		num4 *= 4f * this.m_BloomBlur;
		material.SetVector("_OffsetA", new Vector4(1.5f * num3, 0f, -1.5f * num3, 0f));
		material.SetVector("_OffsetB", new Vector4(0.5f * num3, 0f, -0.5f * num3, 0f));
		this.m_BloomRenderBuffer1.DiscardContents();
		Graphics.Blit(this.m_BloomRenderBuffer2, this.m_BloomRenderBuffer1, material, 2);
		material.SetVector("_OffsetA", new Vector4(0f, 1.5f * num4, 0f, -1.5f * num4));
		material.SetVector("_OffsetB", new Vector4(0f, 0.5f * num4, 0f, -0.5f * num4));
		renderTexture.DiscardContents();
		Graphics.Blit(this.m_BloomRenderBuffer1, renderTexture, material, 2);
		if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.AlphaClipBloom)
		{
			this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.color = this.m_BloomColor;
			this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.mainTexture = renderTexture;
			if (this.m_PlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.renderQueue = this.m_PlaneGameObject.GetComponent<Renderer>().material.renderQueue + 1;
				return;
			}
		}
		else
		{
			if (this.m_RenderToObject)
			{
				this.m_RenderToObject.GetComponent<Renderer>().material.color = this.m_BloomColor;
				this.m_RenderToObject.GetComponent<Renderer>().material.mainTexture = renderTexture;
				return;
			}
			this.m_PlaneGameObject.GetComponent<Renderer>().material.color = this.m_BloomColor;
			this.m_PlaneGameObject.GetComponent<Renderer>().material.mainTexture = renderTexture;
		}
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x002BD378 File Offset: 0x002BB578
	private void SetupForRender()
	{
		this.CalcWorldWidthHeightScale();
		if (!this.m_RenderTexture)
		{
			this.CreateTexture();
		}
		if (!this.m_HideRenderObject)
		{
			return;
		}
		if (this.m_PlaneGameObject)
		{
			this.m_PlaneGameObject.transform.localPosition = this.m_PositionOffset;
			this.m_PlaneGameObject.layer = base.gameObject.layer;
		}
		if (this.m_Camera != null)
		{
			this.m_Camera.backgroundColor = this.m_ClearColor;
		}
	}

	// Token: 0x0600862B RID: 34347 RVA: 0x002BD400 File Offset: 0x002BB600
	private void SetupMaterial()
	{
		GameObject gameObject = this.m_PlaneGameObject;
		if (this.m_RenderToObject)
		{
			gameObject = this.m_RenderToObject;
			if (this.m_RenderMaterial == RenderToTexture.RenderToTextureMaterial.Custom)
			{
				return;
			}
		}
		if (gameObject == null)
		{
			return;
		}
		switch (this.m_RenderMaterial)
		{
		case RenderToTexture.RenderToTextureMaterial.Transparent:
			gameObject.GetComponent<Renderer>().material = this.TransparentMaterial;
			break;
		case RenderToTexture.RenderToTextureMaterial.Additive:
			gameObject.GetComponent<Renderer>().material = this.AdditiveMaterial;
			break;
		case RenderToTexture.RenderToTextureMaterial.Bloom:
			if (this.m_BloomBlend == RenderToTexture.BloomBlendType.Additive)
			{
				gameObject.GetComponent<Renderer>().material = this.AdditiveMaterial;
			}
			else if (this.m_BloomBlend == RenderToTexture.BloomBlendType.Transparent)
			{
				gameObject.GetComponent<Renderer>().material = this.TransparentMaterial;
			}
			break;
		case RenderToTexture.RenderToTextureMaterial.AlphaClip:
		{
			Material material;
			if (this.m_AlphaClipRenderStyle == RenderToTexture.AlphaClipShader.Standard)
			{
				material = this.AlphaClipMaterial;
			}
			else
			{
				material = this.AlphaClipGradientMaterial;
			}
			gameObject.GetComponent<Renderer>().material = material;
			material.SetFloat("_Cutoff", this.m_AlphaClip);
			material.SetFloat("_Intensity", this.m_AlphaClipIntensity);
			material.SetFloat("_AlphaIntensity", this.m_AlphaClipAlphaIntensity);
			if (this.m_AlphaClipRenderStyle == RenderToTexture.AlphaClipShader.ColorGradient)
			{
				material.SetTexture("_GradientTex", this.m_AlphaClipGradientMap);
			}
			break;
		}
		case RenderToTexture.RenderToTextureMaterial.AlphaClipBloom:
		{
			Material material2;
			if (this.m_AlphaClipRenderStyle == RenderToTexture.AlphaClipShader.Standard)
			{
				material2 = this.AlphaClipMaterial;
			}
			else
			{
				material2 = this.AlphaClipGradientMaterial;
			}
			gameObject.GetComponent<Renderer>().material = material2;
			material2.SetFloat("_Cutoff", this.m_AlphaClip);
			material2.SetFloat("_Intensity", this.m_AlphaClipIntensity);
			material2.SetFloat("_AlphaIntensity", this.m_AlphaClipAlphaIntensity);
			if (this.m_AlphaClipRenderStyle == RenderToTexture.AlphaClipShader.ColorGradient)
			{
				material2.SetTexture("_GradientTex", this.m_AlphaClipGradientMap);
			}
			break;
		}
		default:
			if (this.m_Material != null)
			{
				gameObject.GetComponent<Renderer>().material = this.m_Material;
			}
			break;
		}
		if (gameObject.GetComponent<Renderer>().material != null)
		{
			gameObject.GetComponent<Renderer>().material.color *= this.m_TintColor;
		}
		if (this.m_BloomIntensity > 0f && this.m_BloomPlaneGameObject)
		{
			this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.color = this.m_BloomColor;
		}
		gameObject.GetComponent<Renderer>().sortingOrder = this.m_RenderQueue;
		gameObject.GetComponent<Renderer>().material.renderQueue = this.m_RenderQueueOffset + this.m_RenderQueue;
		if (this.m_BloomPlaneGameObject)
		{
			this.m_BloomPlaneGameObject.GetComponent<Renderer>().sortingOrder = this.m_RenderQueue + 1;
			this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.renderQueue = this.m_RenderQueueOffset + this.m_RenderQueue + 1;
		}
		this.m_PreviousRenderMaterial = this.m_RenderMaterial;
		this.m_previousRenderQueue = this.m_RenderQueue;
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x002BD6CC File Offset: 0x002BB8CC
	private void PositionHiddenObjectsAndCameras()
	{
		Vector3 b = Vector3.zero;
		if (this.m_RenderToObject)
		{
			b = this.m_RenderToObject.transform.position - this.m_OriginalRenderPosition;
		}
		else
		{
			b = base.transform.position - this.m_OriginalRenderPosition;
		}
		if (this.m_RealtimeTranslation)
		{
			this.m_OffscreenGameObject.transform.position = this.m_OffscreenPos/2f + b/2f;
			this.m_OffscreenGameObject.transform.rotation = Quaternion.Euler(Vector3.zero);//base.transform.rotation;//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
			if (this.m_AlphaObjectToRender)
			{
				this.m_AlphaObjectToRender.transform.position = this.m_OffscreenPos/2f - this.ALPHA_OBJECT_OFFSET/2f - this.m_AlphaObjectToRenderOffset/2f + b/2f;
				this.m_AlphaObjectToRender.transform.rotation =  base.transform.rotation;//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
				return;
			}
		}
		else
		{
			if (this.m_ObjectToRender)
			{
				this.m_ObjectToRender.transform.rotation = Quaternion.identity;
				this.m_ObjectToRender.transform.position = this.m_OffscreenPos/2f - this.m_ObjectToRenderOffset/2f + this.m_PositionOffset/2f;
				this.m_ObjectToRender.transform.rotation =  Quaternion.Euler(Vector3.zero);//base.transform.rotation;//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
			}
			if (this.m_AlphaObjectToRender)
			{
				this.m_AlphaObjectToRender.transform.position = this.m_OffscreenPos/2f - this.ALPHA_OBJECT_OFFSET/2f;
				this.m_AlphaObjectToRender.transform.rotation =  base.transform.rotation;//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
			}
			if (this.m_CameraGO == null)
			{
				return;
			}
			this.m_CameraGO.transform.rotation = Quaternion.identity;
			if (this.m_ObjectToRender)
			{
				this.m_CameraGO.transform.position = this.m_ObjectToRender.transform.position/2f + this.m_CameraOffset/2f;
			}
			else
			{
				this.m_CameraGO.transform.position = this.m_OffscreenPos/2f + this.m_PositionOffset/2f + this.m_CameraOffset/2f;
			}
			this.m_CameraGO.transform.rotation =  base.transform.rotation;//Quaternion.Euler(Vector3.zero);//this.m_ObjectToRender.transform.rotation;
			this.m_CameraGO.transform.Rotate(90f, 0f, 0f);
		}
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x002BD93C File Offset: 0x002BBB3C
	private void RestoreAfterRender()
	{
		if (this.m_HideRenderObject)
		{
			return;
		}
		if (this.m_ObjectToRender)
		{
			if (this.m_ObjectToRenderOrgParent != null)
			{
				this.m_ObjectToRender.transform.parent = this.m_ObjectToRenderOrgParent;
			}
			this.m_ObjectToRender.transform.localPosition = this.m_ObjectToRenderOrgPosition;
			return;
		}
		base.transform.localPosition = this.m_ObjectToRenderOrgPosition;
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x002BD9AC File Offset: 0x002BBBAC
	private void CreateTexture()
	{
		if (this.m_RenderTexture != null)
		{
			return;
		}
		Vector2 vector = this.CalcTextureSize();
		//GraphicsManager graphicsManager = GraphicsManager.Get();
		//if (graphicsManager != null)
		//{
		//	if (graphicsManager.RenderQualityLevel == GraphicsQuality.Low)
		//	{
		//		vector *= 0.75f;
		//	}
		//	else if (graphicsManager.RenderQualityLevel == GraphicsQuality.Medium)
		//	{
				vector *= 1f;
		//	}
		//	else if (graphicsManager.RenderQualityLevel == GraphicsQuality.High)
		//	{
		//		vector *= 1.5f;
		//	}
		//}
		this.m_RenderTexture = RenderTextureTracker.Get().CreateNewTexture((int)vector.x, (int)vector.y, 32, this.m_RenderTextureFormat, RenderTextureReadWrite.Default);
		this.m_RenderTexture.Create();
		if (this.m_RenderMeshAsAlpha)
		{
			this.m_AlphaRenderTexture = RenderTextureTracker.Get().CreateNewTexture((int)vector.x, (int)vector.y, 32, this.m_RenderTextureFormat, RenderTextureReadWrite.Default);
			this.m_AlphaRenderTexture.Create();
		}
		if (this.m_Camera)
		{
			this.m_Camera.targetTexture = this.m_RenderTexture;
		}
		if (this.m_AlphaCamera)
		{
			this.m_AlphaCamera.targetTexture = this.m_AlphaRenderTexture;
		}
	}

	// Token: 0x0600862F RID: 34351 RVA: 0x002BDAC4 File Offset: 0x002BBCC4
	private void ReleaseTexture()
	{
		if (RenderTexture.active == this.m_RenderTexture)
		{
			RenderTexture.active = null;
		}
		if (RenderTexture.active == this.m_AlphaRenderTexture)
		{
			RenderTexture.active = null;
		}
		if (RenderTexture.active == this.m_BloomRenderTexture)
		{
			RenderTexture.active = null;
		}
		if (this.m_RenderTexture != null)
		{
			if (this.m_Camera)
			{
				this.m_Camera.targetTexture = null;
			}
			RenderTextureTracker.Get().DestroyRenderTexture(this.m_RenderTexture);
			this.m_RenderTexture = null;
		}
		if (this.m_AlphaRenderTexture != null)
		{
			if (this.m_AlphaCamera)
			{
				this.m_AlphaCamera.targetTexture = null;
			}
			RenderTextureTracker.Get().DestroyRenderTexture(this.m_AlphaRenderTexture);
			this.m_AlphaRenderTexture = null;
		}
		if (this.m_BloomRenderTexture != null)
		{
			RenderTextureTracker.Get().DestroyRenderTexture(this.m_BloomRenderTexture);
			this.m_BloomRenderTexture = null;
		}
		if (this.m_BloomRenderBuffer1 != null)
		{
			RenderTextureTracker.Get().DestroyRenderTexture(this.m_BloomRenderBuffer1);
			this.m_BloomRenderBuffer1 = null;
		}
		if (this.m_BloomRenderBuffer2 != null)
		{
			RenderTextureTracker.Get().DestroyRenderTexture(this.m_BloomRenderBuffer2);
			this.m_BloomRenderBuffer2 = null;
		}
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x002BDC04 File Offset: 0x002BBE04
	private void CreateCamera()
	{
		if (this.m_Camera != null)
		{
			return;
		}
		this.m_CameraGO = new GameObject();
		this.m_Camera = this.m_CameraGO.AddComponent<Camera>();
		this.m_CameraGO.name = base.name + "_R2TRenderCamera";
		this.m_CameraGO.AddComponent<RenderToTextureCamera>();
		this.m_Camera.orthographic = true;
		if (this.m_HideRenderObject)
		{
			if (this.m_RealtimeTranslation)
			{
				this.m_OffscreenGameObject.transform.position = base.transform.position;
				this.m_CameraGO.transform.parent = this.m_OffscreenGameObject.transform;
				this.m_CameraGO.transform.localPosition = Vector3.zero + this.m_PositionOffset/2f + this.m_CameraOffset/2f;
				this.m_CameraGO.transform.rotation = Quaternion.Euler(Vector3.zero);//base.transform.rotation;//Quaternion.Euler(Vector3.zero);//Quaternion.Euler(base.transform.rotation.eulerAngles/2f);//base.transform.rotation;
				this.m_OffscreenGameObject.transform.position = this.m_OffscreenPos/2f;
			}
			else
			{
				this.m_CameraGO.transform.parent = null;
				this.m_CameraGO.transform.position = this.m_OffscreenPos/2f + this.m_PositionOffset/2f + this.m_CameraOffset/2f;
				this.m_CameraGO.transform.rotation = Quaternion.Euler(Vector3.zero);//base.transform.rotation;//Quaternion.Euler(Vector3.zero);//Quaternion.Euler(base.transform.rotation.eulerAngles/2f);//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
			}
		}
		else
		{
			this.m_CameraGO.transform.parent = base.transform;
			this.m_CameraGO.transform.position = base.transform.position/2f + this.m_PositionOffset/2f + this.m_CameraOffset/2f;
			this.m_CameraGO.transform.rotation = Quaternion.Euler(Vector3.zero);//base.transform.rotation;//Quaternion.Euler(Vector3.zero);//Quaternion.Euler(base.transform.rotation.eulerAngles/2f);//Quaternion.Euler(Vector3.zero);//base.transform.rotation;
		}
		this.m_CameraGO.transform.Rotate(90f, 0f, 0f);
		if (this.m_FarClip < 0f)
		{
			this.m_FarClip = 0f;
		}
		if (this.m_NearClip > 0f)
		{
			this.m_NearClip = 0f;
		}
		this.m_Camera.nearClipPlane = this.m_NearClip * this.m_WorldScale.y;
		this.m_Camera.farClipPlane = this.m_FarClip * this.m_WorldScale.y;
		Camera main = Camera.main;
		if (main != null)
		{
			this.m_Camera.depth = main.depth - 2f;
		}
		this.m_Camera.clearFlags = CameraClearFlags.Color;
		this.m_Camera.backgroundColor = this.m_ClearColor;
		this.m_Camera.depthTextureMode = DepthTextureMode.None;
		this.m_Camera.renderingPath = RenderingPath.Forward;
		this.m_Camera.cullingMask = this.m_LayerMask;
		this.m_Camera.allowHDR = false;
		this.m_Camera.targetTexture = this.m_RenderTexture;
		this.m_Camera.enabled = false;
	}

	// Token: 0x06008631 RID: 34353 RVA: 0x002BDEFC File Offset: 0x002BC0FC
	private float OrthoSize()
	{
		if (this.m_OverrideCameraSize > 0f)
		{
			return this.m_OverrideCameraSize;
		}
		float result;
		if (this.m_WorldWidth > this.m_WorldHeight)
		{
			result = Mathf.Min(this.m_WorldWidth * 0.5f, this.m_WorldHeight * 0.5f);
		}
		else
		{
			result = this.m_WorldHeight * 0.5f;
		}
		return result;
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x002BDF60 File Offset: 0x002BC160
	private void CameraRender()
	{
		this.m_Camera.orthographicSize = this.OrthoSize();
		this.m_Camera.farClipPlane = this.m_FarClip * this.m_WorldScale.z;
		this.m_Camera.nearClipPlane = this.m_NearClip * this.m_WorldScale.z;
		if (this.m_PlaneGameObject && !this.m_HideRenderObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = false;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if (this.m_ReplacmentShader)
		{
			this.m_Camera.RenderWithShader(this.m_ReplacmentShader, this.m_ReplacmentTag);
		}
		else
		{
			this.m_Camera.Render();
		}
		if (this.m_PlaneGameObject && !this.m_HideRenderObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = true;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = true;
			}
		}
	}

	// Token: 0x06008633 RID: 34355 RVA: 0x002BE074 File Offset: 0x002BC274
	private void CreateAlphaCamera()
	{
		if (this.m_AlphaCamera != null)
		{
			return;
		}
		this.m_AlphaCameraGO = new GameObject();
		this.m_AlphaCamera = this.m_AlphaCameraGO.AddComponent<Camera>();
		this.m_AlphaCameraGO.name = base.name + "_R2TAlphaRenderCamera";
		this.m_AlphaCamera.CopyFrom(this.m_Camera);
		this.m_AlphaCamera.enabled = false;
		this.m_AlphaCamera.backgroundColor = Color.clear;
		this.m_AlphaCamera.allowHDR = false;
		this.m_AlphaCameraGO.transform.parent = this.m_CameraGO.transform;
		if (this.m_AlphaObjectToRender)
		{
			this.m_AlphaCameraGO.transform.position = this.m_CameraGO.transform.position - this.ALPHA_OBJECT_OFFSET;
		}
		else
		{
			this.m_AlphaCameraGO.transform.position = this.m_CameraGO.transform.position;
		}
		this.m_AlphaCameraGO.transform.localRotation = Quaternion.identity;
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x002BE18C File Offset: 0x002BC38C
	private void AlphaCameraRender()
	{
		this.m_AlphaCamera.orthographicSize = this.OrthoSize();
		this.m_AlphaCamera.farClipPlane = this.m_FarClip * this.m_WorldScale.z;
		this.m_AlphaCamera.nearClipPlane = this.m_NearClip * this.m_WorldScale.z;
		if (this.m_PlaneGameObject && !this.m_HideRenderObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = false;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = false;
			}
		}
		if (this.m_OpaqueObjectAlphaFill)
		{
			this.m_AlphaCamera.RenderWithShader(this.m_AlphaFillShader, "RenderType");
		}
		else if (this.m_AlphaObjectToRender == null)
		{
			string text = this.m_AlphaReplacementTag;
			if (text == string.Empty)
			{
				text = this.m_ReplacmentTag;
			}
			this.m_AlphaCamera.RenderWithShader(this.m_AlphaFillShader, text);
		}
		else
		{
			this.m_AlphaCamera.Render();
		}
		if (this.m_PlaneGameObject && !this.m_HideRenderObject)
		{
			this.m_PlaneGameObject.GetComponent<Renderer>().enabled = true;
			if (this.m_BloomPlaneGameObject)
			{
				this.m_BloomPlaneGameObject.GetComponent<Renderer>().enabled = true;
			}
		}
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x002BE2D4 File Offset: 0x002BC4D4
	private void CreateBloomCaptureCamera()
	{
		if (this.m_BloomCaptureCamera != null)
		{
			return;
		}
		this.m_BloomCaptureCameraGO = new GameObject();
		this.m_BloomCaptureCamera = this.m_BloomCaptureCameraGO.AddComponent<Camera>();
		this.m_BloomCaptureCameraGO.name = base.name + "_R2TBloomRenderCamera";
		this.m_BloomCaptureCamera.CopyFrom(this.m_Camera);
		this.m_BloomCaptureCamera.enabled = false;
		this.m_BloomCaptureCamera.depth = this.m_Camera.depth + 1f;
		this.m_BloomCaptureCameraGO.transform.parent = this.m_Camera.transform;
		this.m_BloomCaptureCameraGO.transform.localPosition = Vector3.zero;
		this.m_BloomCaptureCameraGO.transform.localRotation = Quaternion.identity;
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x002BE3A8 File Offset: 0x002BC5A8
	private Vector2 CalcTextureSize()
	{
		Vector2 result = new Vector2((float)this.m_Resolution, (float)this.m_Resolution);
		if (this.m_WorldWidth > this.m_WorldHeight)
		{
			result.x = (float)this.m_Resolution;
			result.y = (float)this.m_Resolution * (this.m_WorldHeight / this.m_WorldWidth);
		}
		else
		{
			result.x = (float)this.m_Resolution * (this.m_WorldWidth / this.m_WorldHeight);
			result.y = (float)this.m_Resolution;
		}
		return result;
	}

	// Token: 0x06008637 RID: 34359 RVA: 0x002BE430 File Offset: 0x002BC630
	private void CreateRenderPlane()
	{
		if (this.m_PlaneGameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(this.m_PlaneGameObject);
		}
		this.m_PlaneGameObject = this.CreateMeshPlane(string.Format("{0}_RenderPlane", base.name), this.m_Material);
		//SceneUtils.SetHideFlags(this.m_PlaneGameObject, HideFlags.DontSave);
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x002BE488 File Offset: 0x002BC688
	private void CreateBloomPlane()
	{
		if (this.m_BloomPlaneGameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(this.m_BloomPlaneGameObject);
		}
		Material material = this.AdditiveMaterial;
		if (this.m_BloomBlend == RenderToTexture.BloomBlendType.Transparent)
		{
			material = this.TransparentMaterial;
		}
		this.m_BloomPlaneGameObject = this.CreateMeshPlane(string.Format("{0}_BloomRenderPlane", base.name), material);
		this.m_BloomPlaneGameObject.transform.parent = this.m_PlaneGameObject.transform;
		this.m_BloomPlaneGameObject.transform.localPosition = new Vector3(0f, 0.15f, 0f);
		this.m_BloomPlaneGameObject.transform.localRotation = Quaternion.identity;
		this.m_BloomPlaneGameObject.transform.localScale = Vector3.one;
		this.m_BloomPlaneGameObject.GetComponent<Renderer>().material.color = this.m_BloomColor;
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x002BE568 File Offset: 0x002BC768
	private void CreateBloomCapturePlane()
	{
		if (this.m_BloomCapturePlaneGameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(this.m_BloomCapturePlaneGameObject);
		}
		Material material = this.AdditiveMaterial;
		if (this.m_BloomBlend == RenderToTexture.BloomBlendType.Transparent)
		{
			material = this.TransparentMaterial;
		}
		this.m_BloomCapturePlaneGameObject = this.CreateMeshPlane(string.Format("{0}_BloomCaptureRenderPlane", base.name), material);
		this.m_BloomCapturePlaneGameObject.transform.parent = this.m_BloomCaptureCameraGO.transform;
		this.m_BloomCapturePlaneGameObject.transform.localPosition = Vector3.zero;
		this.m_BloomCapturePlaneGameObject.transform.localRotation = Quaternion.identity;
		this.m_BloomCapturePlaneGameObject.transform.Rotate(-90f, 0f, 0f);
		this.m_BloomCapturePlaneGameObject.transform.localScale = this.m_WorldScale;
		if (this.m_Material)
		{
			this.m_BloomCapturePlaneGameObject.GetComponent<Renderer>().material = this.m_PlaneGameObject.GetComponent<Renderer>().material;
		}
		if (this.m_RenderTexture)
		{
			this.m_BloomCapturePlaneGameObject.GetComponent<Renderer>().material.mainTexture = this.m_RenderTexture;
		}
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x002BE694 File Offset: 0x002BC894
	private GameObject CreateMeshPlane(string name, Material material)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = name;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = this.m_PositionOffset;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		float num = this.m_Width * 0.5f;
		float num2 = this.m_Height * 0.5f;
		mesh.vertices = new Vector3[]
		{
			new Vector3(-num, 0f, -num2),
			new Vector3(num, 0f, -num2),
			new Vector3(-num, 0f, num2),
			new Vector3(num, 0f, num2)
		};
		mesh.uv = this.PLANE_UVS;
		mesh.normals = this.PLANE_NORMALS;
		mesh.triangles = this.PLANE_TRIANGLES;
		(gameObject.GetComponent<MeshFilter>().mesh = mesh).RecalculateBounds();
		if (material)
		{
			gameObject.GetComponent<Renderer>().material = material;
		}
		gameObject.GetComponent<Renderer>().sortingOrder = this.m_RenderQueue;
		gameObject.GetComponent<Renderer>().material.renderQueue = this.m_RenderQueueOffset + this.m_RenderQueue;
		this.m_previousRenderQueue = this.m_RenderQueue;
		return gameObject;
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x002BE804 File Offset: 0x002BCA04
	private void Sample(RenderTexture source, RenderTexture dest, Material sampleMat, float offset)
	{
		Graphics.BlitMultiTap(source, dest, sampleMat, new Vector2[]
		{
			new Vector2(-offset, -offset),
			new Vector2(-offset, offset),
			new Vector2(offset, offset),
			new Vector2(offset, -offset)
		});
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x002BE864 File Offset: 0x002BCA64
	private void CalcWorldWidthHeightScale()
	{
		Quaternion rotation = base.transform.rotation;
		Vector3 localScale = base.transform.localScale;
		Transform parent = base.transform.parent;
		base.transform.rotation = Quaternion.identity;
		bool flag = false;
		if (base.transform.lossyScale.magnitude == 0f)
		{
			base.transform.parent = null;
			base.transform.localScale = Vector3.one;
			flag = true;
		}
		if (this.m_UniformWorldScale)
		{
			float num = Mathf.Max(new float[]
			{
				base.transform.lossyScale.x,
				base.transform.lossyScale.y,
				base.transform.lossyScale.z
			});
			this.m_WorldScale = new Vector3(num, num, num);
		}
		else
		{
			this.m_WorldScale = base.transform.lossyScale;
		}
		this.m_WorldWidth = this.m_Width * this.m_WorldScale.x;
		this.m_WorldHeight = this.m_Height * this.m_WorldScale.y;
		if (flag)
		{
			base.transform.parent = parent;
			base.transform.localScale = localScale;
		}
		base.transform.rotation = rotation;
		if (this.m_WorldWidth == 0f || this.m_WorldHeight == 0f)
		{
			Debug.LogError(string.Format(" \"{0}\": RenderToTexture has a world scale of zero. \nm_WorldWidth: {1},   m_WorldHeight: {2}", this.m_WorldWidth, this.m_WorldHeight));
		}
	}

	// Token: 0x0600863D RID: 34365 RVA: 0x002BE9E8 File Offset: 0x002BCBE8
	private void CleanUp()
	{
		this.ReleaseTexture();
		if (this.m_CameraGO)
		{
			UnityEngine.Object.Destroy(this.m_CameraGO);
		}
		if (this.m_AlphaCameraGO)
		{
			UnityEngine.Object.Destroy(this.m_AlphaCameraGO);
		}
		if (this.m_PlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_PlaneGameObject);
		}
		if (this.m_BloomPlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_BloomPlaneGameObject);
		}
		if (this.m_BloomCaptureCameraGO)
		{
			UnityEngine.Object.Destroy(this.m_BloomCaptureCameraGO);
		}
		if (this.m_BloomCapturePlaneGameObject)
		{
			UnityEngine.Object.Destroy(this.m_BloomCapturePlaneGameObject);
		}
		if (this.m_OffscreenGameObject)
		{
			UnityEngine.Object.Destroy(this.m_OffscreenGameObject);
		}
		if (this.m_BlurMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_BlurMaterial);
		}
		if (this.m_AlphaBlurMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaBlurMaterial);
		}
		if (this.m_AlphaBlendMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaBlendMaterial);
		}
		if (this.m_AlphaBlendAddMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaBlendAddMaterial);
		}
		if (this.m_AdditiveMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AdditiveMaterial);
		}
		if (this.m_BloomMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_BloomMaterial);
		}
		if (this.m_BloomMaterialAlpha)
		{
			RenderUtils.SafeRemoveMaterial(this.m_BloomMaterialAlpha);
		}
		if (this.m_TransparentMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_TransparentMaterial);
		}
		if (this.m_AlphaClipMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaClipMaterial);
		}
		if (this.m_AlphaClipBloomMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaClipBloomMaterial);
		}
		if (this.m_AlphaClipGradientMaterial)
		{
			RenderUtils.SafeRemoveMaterial(this.m_AlphaClipGradientMaterial);
		}
		if (this.m_Material)
		{
			RenderUtils.SafeRemoveMaterial(this.m_Material);
		}
		if (this.m_ObjectToRender != null)
		{
			if (this.m_ObjectToRenderOrgParent != null)
			{
				//this.m_ObjectToRender.transform.parent = this.m_ObjectToRenderOrgParent;
			}
			this.m_ObjectToRender.transform.localPosition = this.m_ObjectToRenderOrgPosition;
		}
		this.m_init = false;
		this.m_isDirty = true;
	}


	// Token: 0x04006BBA RID: 27578
	private const string BLUR_SHADER_NAME = "Shader Graphs/R2TBlur";//"Hidden/R2TBlur";

	// Token: 0x04006BBB RID: 27579
	private const string BLUR_ALPHA_SHADER_NAME = "Shader Graphs/R2TAlphaBlur";//"Hidden/R2TAlphaBlur";

	// Token: 0x04006BBC RID: 27580
	private const string ALPHA_BLEND_SHADER_NAME = "Shader Graphs/R2TColorAlphaCombine";//"Hidden/R2TColorAlphaCombine";

	// Token: 0x04006BBD RID: 27581
	private const string ALPHA_BLEND_ADD_SHADER_NAME = "Shader Graphs/R2TColorAlphaCombineAdd";//"Hidden/R2TColorAlphaCombineAdd";

	// Token: 0x04006BBE RID: 27582
	private const string ALPHA_FILL_SHADER_NAME = "Shader Graphs/AlphaFillOpaque";//"Custom/AlphaFillOpaque";

	// Token: 0x04006BBF RID: 27583
	private const string BLOOM_SHADER_NAME = "Shader Graphs/R2TBloom";//"Hidden/R2TBloom";

	// Token: 0x04006BC0 RID: 27584
	private const string BLOOM_ALPHA_SHADER_NAME = "Shader Graphs/R2TBloomAlpha";//"Hidden/R2TBloomAlpha";

	// Token: 0x04006BC1 RID: 27585
	private const string ADDITIVE_SHADER_NAME = "Shader Graphs/R2TAdditive";//"Hidden/R2TAdditive";

	// Token: 0x04006BC2 RID: 27586
	private const string TRANSPARENT_SHADER_NAME = "Shader Graphs/R2TTransparent";//"Hidden/R2TTransparent";

	// Token: 0x04006BC3 RID: 27587
	private const string ALPHA_CLIP_SHADER_NAME = "Shader Graphs/R2TAlphaClip";//"Hidden/R2TAlphaClip";

	// Token: 0x04006BC4 RID: 27588
	private const string ALPHA_CLIP_BLOOM_SHADER_NAME = "Shader Graphs/R2TAlphaClipBloom";//"Hidden/R2TAlphaClipBloom";

	// Token: 0x04006BC5 RID: 27589
	private const string ALPHA_CLIP_GRADIENT_SHADER_NAME = "Shader Graphs/R2TAlphaClipGradient";//"Hidden/R2TAlphaClipGradient";

	// Token: 0x04006BC6 RID: 27590
	private const RenderTextureFormat ALPHA_TEXTURE_FORMAT = RenderTextureFormat.Default;

	// Token: 0x04006BC7 RID: 27591
	private const float OFFSET_DISTANCE = 300f;

	// Token: 0x04006BC8 RID: 27592
	private const float MIN_OFFSET_DISTANCE = -4000f;

	// Token: 0x04006BC9 RID: 27593
	private const float MAX_OFFSET_DISTANCE = -90000f;

	// Token: 0x04006BCA RID: 27594
	private readonly Vector3 ALPHA_OBJECT_OFFSET = new Vector3(0f, 1000f, 0f);

	// Token: 0x04006BCB RID: 27595
	private const float RENDER_SIZE_QUALITY_LOW = 0.75f;

	// Token: 0x04006BCC RID: 27596
	private const float RENDER_SIZE_QUALITY_MEDIUM = 1f;

	// Token: 0x04006BCD RID: 27597
	private const float RENDER_SIZE_QUALITY_HIGH = 1.5f;

	// Token: 0x04006BCE RID: 27598
	private readonly Vector2[] PLANE_UVS = new Vector2[]
	{
		new Vector2(0f, 0f),
		new Vector2(1f, 0f),
		new Vector2(0f, 1f),
		new Vector2(1f, 1f)
	};

	// Token: 0x04006BCF RID: 27599
	private readonly Vector3[] PLANE_NORMALS = new Vector3[]
	{
		Vector3.up,
		Vector3.up,
		Vector3.up,
		Vector3.up
	};

	// Token: 0x04006BD0 RID: 27600
	private readonly int[] PLANE_TRIANGLES = new int[]
	{
		3,
		1,
		2,
		2,
		1,
		0
	};

	// Token: 0x04006BD1 RID: 27601
	public GameObject m_ObjectToRender;

	// Token: 0x04006BD2 RID: 27602
	public GameObject m_AlphaObjectToRender;

	// Token: 0x04006BD3 RID: 27603
	public bool m_HideRenderObject = true;

	// Token: 0x04006BD4 RID: 27604
	public bool m_RealtimeRender;

	// Token: 0x04006BD5 RID: 27605
	public bool m_RealtimeTranslation;

	// Token: 0x04006BD6 RID: 27606
	public bool m_RenderMeshAsAlpha;

	// Token: 0x04006BD7 RID: 27607
	public bool m_OpaqueObjectAlphaFill;

	// Token: 0x04006BD8 RID: 27608
	public RenderToTexture.RenderToTextureMaterial m_RenderMaterial;

	// Token: 0x04006BD9 RID: 27609
	public Material m_Material;

	// Token: 0x04006BDA RID: 27610
	public bool m_CreateRenderPlane = true;

	// Token: 0x04006BDB RID: 27611
	public GameObject m_RenderToObject;

	// Token: 0x04006BDC RID: 27612
	public string m_ShaderTextureName = string.Empty;

	// Token: 0x04006BDD RID: 27613
	public int m_Resolution = 128;

	// Token: 0x04006BDE RID: 27614
	public float m_Width = 1f;

	// Token: 0x04006BDF RID: 27615
	public float m_Height = 1f;

	// Token: 0x04006BE0 RID: 27616
	public float m_NearClip = -0.1f;

	// Token: 0x04006BE1 RID: 27617
	public float m_FarClip = 0.5f;

	// Token: 0x04006BE2 RID: 27618
	public float m_BloomIntensity;

	// Token: 0x04006BE3 RID: 27619
	public float m_BloomThreshold = 0.7f;

	// Token: 0x04006BE4 RID: 27620
	public float m_BloomBlur = 0.3f;

	// Token: 0x04006BE5 RID: 27621
	public float m_BloomResolutionRatio = 0.5f;

	// Token: 0x04006BE6 RID: 27622
	public RenderToTexture.BloomRenderType m_BloomRenderType;

	// Token: 0x04006BE7 RID: 27623
	public float m_BloomAlphaIntensity = 1f;

	// Token: 0x04006BE8 RID: 27624
	public RenderToTexture.BloomBlendType m_BloomBlend;

	// Token: 0x04006BE9 RID: 27625
	public Color m_BloomColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);

	// Token: 0x04006BEA RID: 27626
	public RenderToTexture.AlphaClipShader m_AlphaClipRenderStyle;

	// Token: 0x04006BEB RID: 27627
	public float m_AlphaClip = 15f;

	// Token: 0x04006BEC RID: 27628
	public float m_AlphaClipIntensity = 1.5f;

	// Token: 0x04006BED RID: 27629
	public float m_AlphaClipAlphaIntensity = 1f;

	// Token: 0x04006BEE RID: 27630
	public Texture2D m_AlphaClipGradientMap;

	// Token: 0x04006BEF RID: 27631
	public float m_BlurAmount;

	// Token: 0x04006BF0 RID: 27632
	public bool m_BlurAlphaOnly;

	// Token: 0x04006BF1 RID: 27633
	public Color m_TintColor = Color.white;

	// Token: 0x04006BF2 RID: 27634
	public int m_RenderQueueOffset = 3000;

	// Token: 0x04006BF3 RID: 27635
	public int m_RenderQueue;

	// Token: 0x04006BF4 RID: 27636
	public Color m_ClearColor = Color.clear;

	// Token: 0x04006BF5 RID: 27637
	public Shader m_ReplacmentShader;

	// Token: 0x04006BF6 RID: 27638
	public string m_ReplacmentTag;

	// Token: 0x04006BF7 RID: 27639
	public string m_AlphaReplacementTag;

	// Token: 0x04006BF8 RID: 27640
	public RenderTextureFormat m_RenderTextureFormat = RenderTextureFormat.Default;

	// Token: 0x04006BF9 RID: 27641
	public Vector3 m_PositionOffset = Vector3.zero;

	// Token: 0x04006BFA RID: 27642
	public Vector3 m_CameraOffset = Vector3.zero;

	// Token: 0x04006BFB RID: 27643
	public LayerMask m_LayerMask = -1;

	// Token: 0x04006BFC RID: 27644
	public bool m_UniformWorldScale;

	// Token: 0x04006BFD RID: 27645
	public float m_OverrideCameraSize;

	// Token: 0x04006BFE RID: 27646
	public bool m_LateUpdate;

	// Token: 0x04006BFF RID: 27647
	public bool m_RenderOnStart = true;

	// Token: 0x04006C00 RID: 27648
	public bool m_RenderOnEnable = true;

	// Token: 0x04006C01 RID: 27649
	private bool m_renderEnabled = true;

	// Token: 0x04006C02 RID: 27650
	private bool m_init;

	// Token: 0x04006C03 RID: 27651
	private float m_WorldWidth;

	// Token: 0x04006C04 RID: 27652
	private float m_WorldHeight;

	// Token: 0x04006C05 RID: 27653
	private Vector3 m_WorldScale;

	// Token: 0x04006C06 RID: 27654
	private GameObject m_OffscreenGameObject;

	// Token: 0x04006C07 RID: 27655
	private GameObject m_CameraGO;

	// Token: 0x04006C08 RID: 27656
	private Camera m_Camera;

	// Token: 0x04006C09 RID: 27657
	private GameObject m_AlphaCameraGO;

	// Token: 0x04006C0A RID: 27658
	private Camera m_AlphaCamera;

	// Token: 0x04006C0B RID: 27659
	private GameObject m_BloomCaptureCameraGO;

	// Token: 0x04006C0C RID: 27660
	private Camera m_BloomCaptureCamera;

	// Token: 0x04006C0D RID: 27661
	private RenderTexture m_RenderTexture;

	// Token: 0x04006C0E RID: 27662
	private RenderTexture m_AlphaRenderTexture;

	// Token: 0x04006C0F RID: 27663
	private RenderTexture m_BloomRenderTexture;

	// Token: 0x04006C10 RID: 27664
	private RenderTexture m_BloomRenderBuffer1;

	// Token: 0x04006C11 RID: 27665
	private RenderTexture m_BloomRenderBuffer2;

	// Token: 0x04006C12 RID: 27666
	private GameObject m_PlaneGameObject;

	// Token: 0x04006C13 RID: 27667
	private GameObject m_BloomPlaneGameObject;

	// Token: 0x04006C14 RID: 27668
	private GameObject m_BloomCapturePlaneGameObject;

	// Token: 0x04006C15 RID: 27669
	private bool m_ObjectToRenderOrgPositionStored;

	// Token: 0x04006C16 RID: 27670
	private Transform m_ObjectToRenderOrgParent;

	// Token: 0x04006C17 RID: 27671
	private Vector3 m_ObjectToRenderOrgPosition = Vector3.zero;

	// Token: 0x04006C18 RID: 27672
	private Vector3 m_OriginalRenderPosition = Vector3.zero;

	// Token: 0x04006C19 RID: 27673
	private bool m_isDirty;

	// Token: 0x04006C1A RID: 27674
	private Shader m_AlphaFillShader;

	// Token: 0x04006C1B RID: 27675
	private Vector3 m_OffscreenPos;

	// Token: 0x04006C1C RID: 27676
	private Vector3 m_ObjectToRenderOffset = Vector3.zero;

	// Token: 0x04006C1D RID: 27677
	private Vector3 m_AlphaObjectToRenderOffset = Vector3.zero;

	// Token: 0x04006C1E RID: 27678
	private RenderToTexture.RenderToTextureMaterial m_PreviousRenderMaterial;

	// Token: 0x04006C1F RID: 27679
	private int m_previousRenderQueue;

	// Token: 0x04006C20 RID: 27680
	private List<Renderer> m_OpaqueObjectAlphaFillTransparent;

	// Token: 0x04006C21 RID: 27681
	private List<UberText> m_OpaqueObjectAlphaFillUberText;

	// Token: 0x04006C22 RID: 27682
	private Vector3 m_Offset = Vector3.zero;

	// Token: 0x04006C23 RID: 27683
	private static Vector3 s_offset = new Vector3(-4000f, -4000f, -4000f);

	// Token: 0x04006C24 RID: 27684
	private Shader m_AlphaBlendShader;

	// Token: 0x04006C25 RID: 27685
	private Material m_AlphaBlendMaterial;

	// Token: 0x04006C26 RID: 27686
	private Shader m_AlphaBlendAddShader;

	// Token: 0x04006C27 RID: 27687
	private Material m_AlphaBlendAddMaterial;

	// Token: 0x04006C28 RID: 27688
	private Shader m_AdditiveShader;

	// Token: 0x04006C29 RID: 27689
	private Material m_AdditiveMaterial;

	// Token: 0x04006C2A RID: 27690
	private Shader m_BloomShader;

	// Token: 0x04006C2B RID: 27691
	private Material m_BloomMaterial;

	// Token: 0x04006C2C RID: 27692
	private Shader m_BloomShaderAlpha;

	// Token: 0x04006C2D RID: 27693
	private Material m_BloomMaterialAlpha;

	// Token: 0x04006C2E RID: 27694
	private Shader m_BlurShader;

	// Token: 0x04006C2F RID: 27695
	private Material m_BlurMaterial;

	// Token: 0x04006C30 RID: 27696
	private Shader m_AlphaBlurShader;

	// Token: 0x04006C31 RID: 27697
	private Material m_AlphaBlurMaterial;

	// Token: 0x04006C32 RID: 27698
	private Shader m_TransparentShader;

	// Token: 0x04006C33 RID: 27699
	private Material m_TransparentMaterial;

	// Token: 0x04006C34 RID: 27700
	private Shader m_AlphaClipShader;

	// Token: 0x04006C35 RID: 27701
	private Material m_AlphaClipMaterial;

	// Token: 0x04006C36 RID: 27702
	private Shader m_AlphaClipBloomShader;

	// Token: 0x04006C37 RID: 27703
	private Material m_AlphaClipBloomMaterial;

	// Token: 0x04006C38 RID: 27704
	private Shader m_AlphaClipGradientShader;

	// Token: 0x04006C39 RID: 27705
	private Material m_AlphaClipGradientMaterial;

	// Token: 0x02002331 RID: 9009
	public enum RenderToTextureMaterial
	{
		// Token: 0x0400D732 RID: 55090
		Custom,
		// Token: 0x0400D733 RID: 55091
		Transparent,
		// Token: 0x0400D734 RID: 55092
		Additive,
		// Token: 0x0400D735 RID: 55093
		Bloom,
		// Token: 0x0400D736 RID: 55094
		AlphaClip,
		// Token: 0x0400D737 RID: 55095
		AlphaClipBloom
	}

	// Token: 0x02002332 RID: 9010
	public enum AlphaClipShader
	{
		// Token: 0x0400D739 RID: 55097
		Standard,
		// Token: 0x0400D73A RID: 55098
		ColorGradient
	}

	// Token: 0x02002333 RID: 9011
	public enum BloomRenderType
	{
		// Token: 0x0400D73C RID: 55100
		Color,
		// Token: 0x0400D73D RID: 55101
		Alpha
	}

	// Token: 0x02002334 RID: 9012
	public enum BloomBlendType
	{
		// Token: 0x0400D73F RID: 55103
		Additive,
		// Token: 0x0400D740 RID: 55104
		Transparent
	}
}
