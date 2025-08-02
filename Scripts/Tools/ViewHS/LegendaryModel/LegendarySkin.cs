using System;
using System.Collections.Generic;
using Hearthstone;
//using LegendarySkins;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x02000B6F RID: 2927
public class LegendarySkin : MonoBehaviour
{
	// Token: 0x17000B31 RID: 2865
	// (get) Token: 0x06005A5F RID: 23135 RVA: 0x001B46A8 File Offset: 0x001B28A8
	public Texture PortraitTexture
	{
		get
		{
			return this.m_renderTexture;
		}
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x001B46B0 File Offset: 0x001B28B0
	private void Awake()
	{
		if (this.RTTCamera != null && this.CameraBone != null)
		{
			LegendarySkin.CameraBoneUsage boneUsage = this.BoneUsage;
			if (boneUsage != LegendarySkin.CameraBoneUsage.LookAt)
			{
				if (boneUsage == LegendarySkin.CameraBoneUsage.Parent)
				{
					this.RTTCamera.transform.SetParent(this.CameraBone.transform, false);
					this.RTTCamera.transform.localPosition = Vector3.zero;
					this.RTTCamera.transform.localScale = Vector3.one;
				}
			}
			else
			{
				this.RTTCamera.transform.LookAt(this.CameraBone.transform, this.RTTCamera.transform.up);
				this.RTTCamera.transform.SetParent(this.CameraBone.transform, true);
			}
		}
		int textureSize = Mathf.NextPowerOfTwo(this.TextureSize);
		int antiAliasing = 1;
		//if (UniversalInputManager.UsePhoneUI && textureSize > 512)
		//{
		//	textureSize = Mathf.Max(512, textureSize / 2);
		//}
		switch (this.AntiAliasingLevel)
		{
		case LegendarySkin.AntiAliasingSetting.Off:
			antiAliasing = 1;
			break;
		case LegendarySkin.AntiAliasingSetting.Two:
			antiAliasing = 2;
			break;
		case LegendarySkin.AntiAliasingSetting.Four:
			antiAliasing = 4;
			break;
		case LegendarySkin.AntiAliasingSetting.Eight:
			antiAliasing = 8;
			break;
		}
		this.m_animator = base.GetComponentInChildren<Animator>();
		this.m_renderTexture = new RenderTexture(textureSize, textureSize, 24, RenderTextureFormat.ARGB32);
		this.m_renderTexture.antiAliasing = antiAliasing;
		this.m_renderTexture.filterMode = FilterMode.Bilinear;
		this.m_dynamicResolution = textureSize;
		this.m_allRenderers = base.GetComponentsInChildren<Renderer>(true);
		foreach (Renderer renderer in this.m_allRenderers)
		{
			if (renderer is SkinnedMeshRenderer)
			{
				(renderer as SkinnedMeshRenderer).updateWhenOffscreen = true;
			}
			else
			{
				renderer.enabled = false;
			}
		}
		this.RTTCamera.aspect = 1f;
		this.RTTCamera.enabled = false;
		foreach (Camera camera in base.gameObject.GetComponentsInChildren<Camera>())
		{
			if (camera != this.RTTCamera)
			{
				camera.enabled = false;
			}
		}
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x001B48C4 File Offset: 0x001B2AC4
	private void OnEnable()
	{
		if (LegendarySkin.s_freeSlots.Count == 0)
		{
			LegendarySkin.s_freeSlots.Push(LegendarySkin.s_nextFreeSlot++);
		}
		this.m_slot = LegendarySkin.s_freeSlots.Pop();
		base.transform.SetPositionAndRotation(new Vector3(100f * (float)this.m_slot, -200f, -1000f), Quaternion.identity);
		//this.CreateRenderCommands(null);
		this.m_commandBuffersDirty = true;
		RenderPipelineManager.beginFrameRendering += this.OnBeginFrameRendering;
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x001B494F File Offset: 0x001B2B4F
	private void OnDisable()
	{
		LegendarySkin.s_freeSlots.Push(this.m_slot);
		this.m_slot = -1;
		RenderPipelineManager.beginFrameRendering -= this.OnBeginFrameRendering;
	}

	// Token: 0x06005A63 RID: 23139 RVA: 0x001B4979 File Offset: 0x001B2B79
	private void OnDestroy()
	{
		if (this.RTTCamera)
		{
			this.RTTCamera.targetTexture = null;
		}
		if (this.m_renderTexture)
		{
			UnityEngine.Object.Destroy(this.m_renderTexture);
			this.m_renderTexture = null;
		}
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x001B49B4 File Offset: 0x001B2BB4
	private void Update()
	{
		if (this.AnimateFOV && this.CameraBone != null && this.m_animator != null)
		{
			this.RTTCamera.focalLength = this.m_animator.GetFloat(LegendarySkin.s_CameraFocalLengthID);
		}
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x001B4A00 File Offset: 0x001B2C00
	private void LateUpdate()
	{
		if (this.CameraBone != null || this.AnimateFOV)
		{
			this.m_renderersDirty = true;
		}
		if (this.m_renderersDirty)
		{
			this.CreateRenderCommands(null);
			this.m_commandBuffersDirty = true;
			this.m_renderersDirty = false;
		}
		this.UpdateDynamicResolutionAndRender(Camera.allCameras);
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x001B4A52 File Offset: 0x001B2C52
	public void SetSuspendFlag(LegendarySkin.SuspendUpdateReason reason)
	{
		this.m_suspendUpdateReason |= reason;
		if (this.m_suspendUpdateReason != (LegendarySkin.SuspendUpdateReason)0 && this.m_animator != null)
		{
			this.m_animator.enabled = false;
		}
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x001B4A84 File Offset: 0x001B2C84
	public void ClearSuspendFlag(LegendarySkin.SuspendUpdateReason reason)
	{
		this.m_suspendUpdateReason &= ~reason;
		if (this.m_suspendUpdateReason == (LegendarySkin.SuspendUpdateReason)0 && this.m_animator != null)
		{
			this.m_animator.enabled = true;
		}
	}

	// Token: 0x17000B32 RID: 2866
	// (get) Token: 0x06005A68 RID: 23144 RVA: 0x001B4AB7 File Offset: 0x001B2CB7
	public bool CanUpdateRender
	{
		get
		{
			return this.m_suspendUpdateReason == (LegendarySkin.SuspendUpdateReason)0;
		}
	}

	// Token: 0x17000B33 RID: 2867
	// (get) Token: 0x06005A69 RID: 23145 RVA: 0x001B4AC2 File Offset: 0x001B2CC2
	public bool HasObservers
	{
		get
		{
			return this.m_dynamicResolutionControllers.Count > 0 || !LegendarySkin.DynamicResolutionEnabled;
		}
	}

	// Token: 0x06005A6A RID: 23146 RVA: 0x001B4ADC File Offset: 0x001B2CDC
	private void UpdateDynamicResolutionAndRender(Camera[] cameras)
	{
		if (cameras == null || cameras.Length == 0)
		{
			return;
		}
		int maxWidth = this.m_renderTexture.width;
		int previousResolution = this.m_dynamicResolution;
		int targetResolution = 0;
		if (this.HasObservers)
		{
			targetResolution = maxWidth;
			if (LegendarySkin.DynamicResolutionEnabled)
			{
				bool useEstimatedSize = true;
				float estimatedPixelsHigh = 0f;
				using (HashSet<LegendarySkinDynamicResController>.Enumerator enumerator = this.m_dynamicResolutionControllers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						float sizeInPixels;
						switch (enumerator.Current.GetSize(cameras, out sizeInPixels))
						{
						case LegendarySkinDynamicResController.SizeResult.Bounded:
							estimatedPixelsHigh = Mathf.Max(estimatedPixelsHigh, sizeInPixels);
							break;
						case LegendarySkinDynamicResController.SizeResult.MaxSize:
							useEstimatedSize = false;
							break;
						}
					}
				}
				if (useEstimatedSize)
				{
					estimatedPixelsHigh *= LegendarySkin.DynamicResolutionScale;
					targetResolution = Mathf.RoundToInt(Mathf.Min(estimatedPixelsHigh, (float)maxWidth));
				}
			}
		}
		if (targetResolution == 0)
		{
			this.SetSuspendFlag(LegendarySkin.SuspendUpdateReason.DynamicResolution);
		}
		else
		{
			this.ClearSuspendFlag(LegendarySkin.SuspendUpdateReason.DynamicResolution);
		}
		if (this.CanUpdateRender)
		{
			this.m_dynamicResolution = targetResolution;
			if (previousResolution != this.m_dynamicResolution)
			{
				this.m_commandBuffersDirty = true;
			}
			if (this.m_commandBuffersDirty)
			{
				float newViewportFraction = (float)this.m_dynamicResolution / (float)maxWidth;
				if (!Mathf.Approximately(this.m_viewportFraction, newViewportFraction))
				{
					this.m_viewportFraction = newViewportFraction;
					foreach (LegendarySkinDynamicResController legendarySkinDynamicResController in this.m_dynamicResolutionControllers)
					{
						legendarySkinDynamicResController.UpdateMaterial(this.m_viewportFraction);
					}
				}
				this.BuildCommandBuffers(null, 0);
				this.m_commandBuffersDirty = false;
			}
			this.m_renderCommandBuffer = true;
		}
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x001B4C6C File Offset: 0x001B2E6C
	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras)
	{
		if (this.m_renderCommandBuffer)
		{
			this.m_renderCommandBuffer = false;
			Camera.SetupCurrent(this.RTTCamera);
			Graphics.ExecuteCommandBuffer(this.m_forwardCommandBuffer);
		}
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x001B4C93 File Offset: 0x001B2E93
	public void SetDirty()
	{
		this.m_renderersDirty = true;
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x001B4C9C File Offset: 0x001B2E9C
	private void BuildCommandBuffers(RenderTexture renderTextureOverride = null, int shadowTextureOverride = 0)
	{
		this.m_forwardCommandBuffer = new CommandBuffer
		{
			name = "PortraitRender"
		};
		Vector3 shadowFocus = Vector3.zero;
		float shadowRange;
		if (this.ShadowVolume != null)
		{
			shadowFocus = this.ShadowVolume.transform.position;
			shadowRange = this.ShadowVolume.Radius;
		}
		else
		{
			Bounds shadowBounds = default(Bounds);
			foreach (LegendarySkin.RenderCommandWithPass command in this.m_shadowRenderCommands)
			{
				if (shadowBounds.extents.sqrMagnitude > 0f)
				{
					shadowBounds.Encapsulate(command.Command.Renderer.bounds);
				}
				else
				{
					shadowBounds = command.Command.Renderer.bounds;
				}
			}
			shadowFocus = shadowBounds.center;
			shadowRange = shadowBounds.extents.magnitude;
		}
		Vector3 lightDirection = Vector3.forward;
		Vector3 lightColourVector = Vector3.one;
		Matrix4x4 viewMatrix = Matrix4x4.identity;
		if (this.DirectionalLight)
		{
			Color lightColour = this.DirectionalLight.color;
			lightColourVector = new Vector3(lightColour.r, lightColour.g, lightColour.b) * this.DirectionalLight.intensity;
			shadowRange = Mathf.Max(0.1f, Mathf.Abs(shadowRange));
			lightDirection = this.DirectionalLight.transform.forward;
			viewMatrix = Matrix4x4.TRS(shadowFocus, Quaternion.FromToRotation(Vector3.forward, -lightDirection), Vector3.one * shadowRange).inverse;
		}
		Matrix4x4 orthoProjection = Matrix4x4.Ortho(-1f, 1f, -1f, 1f, -1f, 1f);
		Matrix4x4 shadowProjection = GL.GetGPUProjectionMatrix(orthoProjection, true) * viewMatrix;
		bool addShadowToCommandBuffer = this.ShadowPassEnabled && this.m_shadowRenderCommands.Count > 0;
		if (addShadowToCommandBuffer)
		{
			int shadowTextureSize = Mathf.NextPowerOfTwo(this.ShadowTextureSize);
			//if (UniversalInputManager.UsePhoneUI && shadowTextureSize > 512)
			//{
			//	shadowTextureSize = Mathf.Max(512, shadowTextureSize / 2);
			//}
			if (shadowTextureOverride > 0)
			{
				shadowTextureSize = shadowTextureOverride;
			}
			this.m_forwardCommandBuffer.GetTemporaryRT(LegendarySkin.s_ShadowRenderTextureID, shadowTextureSize, shadowTextureSize, 24, FilterMode.Bilinear, RenderTextureFormat.Depth);
			this.m_forwardCommandBuffer.SetRenderTarget(LegendarySkin.s_ShadowRenderTextureID, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.DontCare, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store);
			this.m_forwardCommandBuffer.SetViewport(new Rect(0f, 0f, (float)shadowTextureSize, (float)shadowTextureSize));
			this.m_forwardCommandBuffer.ClearRenderTarget(true, false, Color.clear);
			this.m_forwardCommandBuffer.SetViewProjectionMatrices(viewMatrix, orthoProjection);
			this.m_forwardCommandBuffer.SetGlobalMatrix(LegendarySkin.s_PortraitShadowMatrixID, shadowProjection);
			foreach (LegendarySkin.RenderCommandWithPass command2 in this.m_shadowRenderCommands)
			{
				this.m_forwardCommandBuffer.DrawRenderer(command2.Command.Renderer, command2.Command.Material, command2.Command.MeshIndex, 1);
			}
		}
		RenderTexture renderTexture = renderTextureOverride ?? this.m_renderTexture;
		this.m_forwardCommandBuffer.SetRenderTarget(renderTexture, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.DontCare);
		int viewportSize = (renderTextureOverride == null) ? this.m_dynamicResolution : renderTexture.width;
		this.m_forwardCommandBuffer.SetViewport(new Rect(0f, 0f, (float)viewportSize, (float)viewportSize));
		this.m_forwardCommandBuffer.SetViewProjectionMatrices(this.m_viewMatrix, this.m_projectionMatrix);
		this.m_forwardCommandBuffer.SetGlobalMatrix(LegendarySkin.s_PortraitShadowMatrixID, shadowProjection);
		this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitLightDirectionID, lightDirection);
		this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitLightColourID, lightColourVector);
		this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitCameraPositionID, this.m_cameraPosition);
		if (addShadowToCommandBuffer)
		{
			this.m_forwardCommandBuffer.SetGlobalTexture(LegendarySkin.s_PortraitShadowMapID, LegendarySkin.s_ShadowRenderTextureID);
		}
		else
		{
			this.m_forwardCommandBuffer.SetGlobalTexture(LegendarySkin.s_PortraitShadowMapID, Texture2D.blackTexture);
		}
		this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_SSSLightDirID, lightDirection);
		this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_ViewDirID, this.RTTCamera.transform.forward);
		this.m_forwardCommandBuffer.SetGlobalFloat(LegendarySkin.s_InvResolutionID, (float)renderTexture.width);
		if (this.LightSettings != null)
		{
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitRimLightColorID, this.LightSettings.RimLightColor * this.m_RimLightColorMult);
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitHairRimLightColorID, this.LightSettings.HairRimLightColor * this.m_RimLightColorMult);
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitShadowColorID, this.LightSettings.ShadowColor);
			this.m_forwardCommandBuffer.SetGlobalFloat(LegendarySkin.s_SoftnessID, this.LightSettings.DepthBias / 64f);
			this.m_forwardCommandBuffer.SetGlobalFloat(LegendarySkin.s_SoftnessFalloffID, Mathf.Exp(this.LightSettings.SoftnessFalloff));
			Matrix4x4 rotationMatrix = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, this.LightSettings.CubemapRotation * 360f, 0f), Vector3.one);
			this.m_forwardCommandBuffer.SetGlobalMatrix(LegendarySkin.s_CubemapRotationID, rotationMatrix);
			this.m_forwardCommandBuffer.SetGlobalTexture(LegendarySkin.s_CubemapID, this.LightSettings.Cubemap);
			Vector4 rimLightCone = default(Vector4);
			float rimLightDirection = 0.017453292f * this.LightSettings.RimLightDirection;
			rimLightCone.x = Mathf.Cos(rimLightDirection);
			rimLightCone.y = Mathf.Sin(rimLightDirection);
			float num = 0.017453292f * Mathf.Clamp(this.LightSettings.RimLightAngle, 0f, 360f) * 0.5f;
			float coneMin = Mathf.Cos(num);
			float coneMax = Mathf.Cos(num * (1f - this.LightSettings.RimLightAngleSoftness));
			rimLightCone.z = Mathf.Min(coneMin, coneMax - Mathf.Epsilon);
			rimLightCone.w = coneMax;
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightConeID, rimLightCone);
			Vector3 rimLightConeDirection = new Vector3(rimLightCone.x, rimLightCone.y, 0f);
			rimLightConeDirection = this.RTTCamera.cameraToWorldMatrix * rimLightConeDirection;
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightConeDirectionID, rimLightConeDirection);
			Vector2 rimFalloff = default(Vector2);
			rimFalloff.x = this.LightSettings.RimLightMinNormal - Mathf.Epsilon;
			rimFalloff.y = this.LightSettings.RimLightMaxNormal + Mathf.Epsilon;
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightFalloffID, rimFalloff);
		}
		else
		{
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitRimLightColorID, Color.white);
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitHairRimLightColorID, Color.white);
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_PortraitShadowColorID, Color.black);
			this.m_forwardCommandBuffer.SetGlobalFloat(LegendarySkin.s_SoftnessID, 0.015625f);
			this.m_forwardCommandBuffer.SetGlobalFloat(LegendarySkin.s_SoftnessFalloffID, Mathf.Exp(4f));
			this.m_forwardCommandBuffer.SetGlobalMatrix(LegendarySkin.s_CubemapRotationID, Matrix4x4.identity);
			this.m_forwardCommandBuffer.SetGlobalTexture(LegendarySkin.s_CubemapID, Texture2D.blackTexture);
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightConeID, new Vector4(1f, 0f, -0.1f, 0.1f));
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightConeDirectionID, new Vector4(1f, 0f, 0f, 0f));
			this.m_forwardCommandBuffer.SetGlobalVector(LegendarySkin.s_RimLightFalloffID, new Vector2(0.85f, 0.95f));
		}
		bool applyScissorRect = this.ScissorRegion < 1f - Mathf.Epsilon;
		this.m_forwardCommandBuffer.ClearRenderTarget(true, true, Color.clear);
		if (applyScissorRect)
		{
			this.m_forwardCommandBuffer.EnableScissorRect(new Rect(0f, 0f, (float)viewportSize, (float)viewportSize * this.ScissorRegion));
		}
		foreach (RenderCommand command3 in this.m_forwardRenderCommands)
		{
			this.m_forwardCommandBuffer.DrawRenderer(command3.Renderer, command3.Material, command3.MeshIndex, 0);
		}
		if (applyScissorRect)
		{
			this.m_forwardCommandBuffer.DisableScissorRect();
		}
	}

	// Token: 0x06005A6E RID: 23150 RVA: 0x001B5584 File Offset: 0x001B3784
	private void CreateRenderCommands(ISkinMaterialProcessor materialProcessor = null)
	{
		this.m_projectionMatrix = this.RTTCamera.projectionMatrix;
		this.m_viewMatrix = this.RTTCamera.worldToCameraMatrix;
		this.m_cameraPosition = this.RTTCamera.transform.position;
		this.m_shadowRenderCommands = new List<LegendarySkin.RenderCommandWithPass>();
		this.m_forwardRenderCommands = new List<RenderCommand>();
		foreach (Renderer renderer in this.m_allRenderers)
		{
			if (renderer.gameObject.activeInHierarchy)
			{
				List<Material> sharedMaterials = new List<Material>();
				renderer.GetSharedMaterials(sharedMaterials);
				UnityEngine.Object exists = renderer as MeshRenderer;
				SkinnedMeshRenderer skinnedMeshRenderer = renderer as SkinnedMeshRenderer;
				int totalMeshCount = 1;
				if (exists)
				{
					MeshFilter meshFilter = renderer.GetComponent<MeshFilter>();
					if (meshFilter == null || meshFilter.sharedMesh == null)
					{
						goto IL_224;
					}
					totalMeshCount = meshFilter.sharedMesh.subMeshCount;
				}
				if (skinnedMeshRenderer)
				{
					totalMeshCount = skinnedMeshRenderer.sharedMesh.subMeshCount;
				}
				for (int meshIndex = 0; meshIndex < totalMeshCount; meshIndex++)
				{
					int materialIndex = meshIndex;
					if (materialIndex >= sharedMaterials.Count)
					{
						materialIndex = 0;
					}
					Material material = sharedMaterials[materialIndex];
					if (material == null)
					{
						Debug.LogError(string.Format("Material on mesh '{0}' at index {1} is null", renderer.gameObject, materialIndex), renderer);
					}
					else
					{
						if (materialProcessor != null)
						{
							//material = materialProcessor.ProcessMaterial(material);
						}
						this.m_forwardRenderCommands.Add(new RenderCommand
						{
							Renderer = renderer,
							Material = material,
							MeshIndex = meshIndex
						});
						if (this.ShadowPassEnabled && material.GetTag("RenderType", false) == "LegendaryPortrait" && renderer.shadowCastingMode != ShadowCastingMode.Off)
						{
							int passCount = material.passCount;
							for (int passIndex = 0; passIndex < passCount; passIndex++)
							{
								if (material.GetPassName(passIndex) == "Shadow Pass")
								{
									this.m_shadowRenderCommands.Add(new LegendarySkin.RenderCommandWithPass
									{
										Command = new RenderCommand
										{
											Renderer = renderer,
											Material = material,
											MeshIndex = meshIndex
										},
										ShaderPass = passIndex
									});
									break;
								}
							}
						}
					}
				}
			}
			IL_224:;
		}
		this.m_forwardRenderCommands.Sort(new Comparison<RenderCommand>(LegendarySkin.SortRenderCommands));
		this.m_shadowRenderCommands.Sort(new Comparison<LegendarySkin.RenderCommandWithPass>(LegendarySkin.SortRenderCommands));
	}

	// Token: 0x06005A6F RID: 23151 RVA: 0x001B57F0 File Offset: 0x001B39F0
	public void AddDynamicResController(LegendarySkinDynamicResController controller)
	{
		this.m_dynamicResolutionControllers.Add(controller);
		controller.UpdateMaterial(this.m_viewportFraction);
	}

	// Token: 0x06005A70 RID: 23152 RVA: 0x001B580B File Offset: 0x001B3A0B
	public void RemoveDynamicResController(LegendarySkinDynamicResController controller)
	{
		this.m_dynamicResolutionControllers.Remove(controller);
	}

	// Token: 0x06005A71 RID: 23153 RVA: 0x001B581C File Offset: 0x001B3A1C
	public void UpdateDynamicResControllers()
	{
		foreach (LegendarySkinDynamicResController legendarySkinDynamicResController in this.m_dynamicResolutionControllers)
		{
			legendarySkinDynamicResController.UpdateMaterial(this.m_viewportFraction);
		}
	}

	// Token: 0x06005A72 RID: 23154 RVA: 0x001B5874 File Offset: 0x001B3A74
	private static int SortRenderCommands(RenderCommand a, RenderCommand b)
	{
		if (a.Material.renderQueue == b.Material.renderQueue)
		{
			return a.Renderer.rendererPriority - b.Renderer.rendererPriority;
		}
		return a.Material.renderQueue - b.Material.renderQueue;
	}

	// Token: 0x06005A73 RID: 23155 RVA: 0x001B58C8 File Offset: 0x001B3AC8
	private static int SortRenderCommands(LegendarySkin.RenderCommandWithPass a, LegendarySkin.RenderCommandWithPass b)
	{
		return LegendarySkin.SortRenderCommands(a.Command, b.Command);
	}

	// Token: 0x04003F53 RID: 16211
	[Header("Camera")]
	public Camera RTTCamera;

	// Token: 0x04003F54 RID: 16212
	public int TextureSize;

	// Token: 0x04003F55 RID: 16213
	[FormerlySerializedAs("LookAtJoint")]
	public GameObject CameraBone;

	// Token: 0x04003F56 RID: 16214
	public LegendarySkin.CameraBoneUsage BoneUsage;

	// Token: 0x04003F57 RID: 16215
	public bool AnimateFOV;

	// Token: 0x04003F58 RID: 16216
	[Header("Lighting")]
	public LegendarySkinLight DirectionalLight;

	// Token: 0x04003F59 RID: 16217
	public bool ShadowPassEnabled;

	// Token: 0x04003F5A RID: 16218
	public int ShadowTextureSize;

	// Token: 0x04003F5B RID: 16219
	public PortraitLighting LightSettings;

	// Token: 0x04003F5C RID: 16220
	public LegendarySkinShadowVolume ShadowVolume;

	// Token: 0x04003F5D RID: 16221
	[Header("Render Texture Settings")]
	public LegendarySkin.AntiAliasingSetting AntiAliasingLevel;

	// Token: 0x04003F5E RID: 16222
	[Range(0f, 1f)]
	public float ScissorRegion = 1f;

	// Token: 0x04003F5F RID: 16223
	[Min(0f)]
	public int UpdatePriority;

	// Token: 0x04003F60 RID: 16224
	[Header("Baking pose")]
	public AnimationClip PoseAnimation;

	// Token: 0x04003F61 RID: 16225
	public float ClipTime;

	// Token: 0x04003F62 RID: 16226
	public float m_RimLightColorMult = 1f;

	// Token: 0x04003F63 RID: 16227
	private RenderTexture m_renderTexture;

	// Token: 0x04003F64 RID: 16228
	private Animator m_animator;

	// Token: 0x04003F65 RID: 16229
	private HashSet<LegendarySkinDynamicResController> m_dynamicResolutionControllers = new HashSet<LegendarySkinDynamicResController>();

	// Token: 0x04003F66 RID: 16230
	private static Stack<int> s_freeSlots = new Stack<int>();

	// Token: 0x04003F67 RID: 16231
	private static int s_nextFreeSlot = 0;

	// Token: 0x04003F68 RID: 16232
	private int m_slot;

	// Token: 0x04003F69 RID: 16233
	private bool m_renderersDirty;

	// Token: 0x04003F6A RID: 16234
	private bool m_commandBuffersDirty;

	// Token: 0x04003F6B RID: 16235
	private bool m_renderCommandBuffer;

	// Token: 0x04003F6C RID: 16236
	private int m_dynamicResolution;

	// Token: 0x04003F6D RID: 16237
	private float m_viewportFraction = 1f;

	// Token: 0x04003F6E RID: 16238
	private LegendarySkin.SuspendUpdateReason m_suspendUpdateReason;

	// Token: 0x04003F6F RID: 16239
	private Renderer[] m_allRenderers;

	// Token: 0x04003F70 RID: 16240
	private List<LegendarySkin.RenderCommandWithPass> m_shadowRenderCommands;

	// Token: 0x04003F71 RID: 16241
	private List<RenderCommand> m_forwardRenderCommands;

	// Token: 0x04003F72 RID: 16242
	private CommandBuffer m_forwardCommandBuffer;

	// Token: 0x04003F73 RID: 16243
	private Matrix4x4 m_projectionMatrix;

	// Token: 0x04003F74 RID: 16244
	private Matrix4x4 m_viewMatrix;

	// Token: 0x04003F75 RID: 16245
	private Vector3 m_cameraPosition;

	// Token: 0x04003F76 RID: 16246
	private static readonly int s_MainTexID = Shader.PropertyToID("_MainTex");

	// Token: 0x04003F77 RID: 16247
	private static readonly int s_PortraitShadowMatrixID = Shader.PropertyToID("_PortraitShadowMatrix");

	// Token: 0x04003F78 RID: 16248
	private static readonly int s_PortraitLightDirectionID = Shader.PropertyToID("_PortraitLightDirection");

	// Token: 0x04003F79 RID: 16249
	private static readonly int s_PortraitLightColourID = Shader.PropertyToID("_PortraitLightColour");

	// Token: 0x04003F7A RID: 16250
	private static readonly int s_PortraitShadowMapID = Shader.PropertyToID("_PortraitShadowMap");

	// Token: 0x04003F7B RID: 16251
	private static readonly int s_PortraitRimLightColorID = Shader.PropertyToID("_PortraitRimLightColor");

	// Token: 0x04003F7C RID: 16252
	private static readonly int s_PortraitHairRimLightColorID = Shader.PropertyToID("_PortraitHairRimLightColor");

	// Token: 0x04003F7D RID: 16253
	private static readonly int s_PortraitShadowColorID = Shader.PropertyToID("_PortraitShadowColor");

	// Token: 0x04003F7E RID: 16254
	private static readonly int s_PortraitCameraPositionID = Shader.PropertyToID("_PortraitCameraPosition");

	// Token: 0x04003F7F RID: 16255
	private static readonly int s_SoftnessID = Shader.PropertyToID("_Softness");

	// Token: 0x04003F80 RID: 16256
	private static readonly int s_SoftnessFalloffID = Shader.PropertyToID("_SoftnessFalloff");

	// Token: 0x04003F81 RID: 16257
	private static readonly int s_SSSLightDirID = Shader.PropertyToID("_SSSLightDir");

	// Token: 0x04003F82 RID: 16258
	private static readonly int s_ViewDirID = Shader.PropertyToID("_ViewDir");

	// Token: 0x04003F83 RID: 16259
	private static readonly int s_CubemapRotationID = Shader.PropertyToID("_CubemapRotationMatrix");

	// Token: 0x04003F84 RID: 16260
	private static readonly int s_CubemapID = Shader.PropertyToID("_Cubemap");

	// Token: 0x04003F85 RID: 16261
	private static readonly int s_RimLightConeID = Shader.PropertyToID("_RimLightCone");

	// Token: 0x04003F86 RID: 16262
	private static readonly int s_RimLightConeDirectionID = Shader.PropertyToID("_RimLightConeDirection");

	// Token: 0x04003F87 RID: 16263
	private static readonly int s_RimLightFalloffID = Shader.PropertyToID("_RimLightFalloff");

	// Token: 0x04003F88 RID: 16264
	private static readonly int s_ShadowRenderTextureID = Shader.PropertyToID("_ShadowRenderTexture");

	// Token: 0x04003F89 RID: 16265
	private static readonly int s_InvResolutionID = Shader.PropertyToID("_InvResolution");

	// Token: 0x04003F8A RID: 16266
	private static readonly int s_CameraFocalLengthID = Animator.StringToHash("Focal Length");

	// Token: 0x04003F8B RID: 16267
	public static bool DynamicResolutionEnabled = false;

	// Token: 0x04003F8C RID: 16268
	public static float DynamicResolutionScale = 1f;

	// Token: 0x02000B70 RID: 2928
	public enum AntiAliasingSetting
	{
		// Token: 0x04003F8E RID: 16270
		Off,
		// Token: 0x04003F8F RID: 16271
		Two,
		// Token: 0x04003F90 RID: 16272
		Four,
		// Token: 0x04003F91 RID: 16273
		Eight
	}

	// Token: 0x02000B71 RID: 2929
	[Flags]
	public enum SuspendUpdateReason
	{
		// Token: 0x04003F93 RID: 16275
		DynamicResolution = 1,
		// Token: 0x04003F94 RID: 16276
		UpdatePriority = 2
	}

	// Token: 0x02000B72 RID: 2930
	public enum CameraBoneUsage
	{
		// Token: 0x04003F96 RID: 16278
		LookAt,
		// Token: 0x04003F97 RID: 16279
		Parent
	}

	// Token: 0x02000B73 RID: 2931
	private struct RenderCommandWithPass
	{
		// Token: 0x04003F98 RID: 16280
		public RenderCommand Command;

		// Token: 0x04003F99 RID: 16281
		public int ShaderPass;
	}
}

public class ISkinMaterialProcessor
{

}