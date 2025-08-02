using System;
using UnityEngine;

// Token: 0x020009C8 RID: 2504
public class OffScreenRenderFX : MonoBehaviour
{

	// Token: 0x06008586 RID: 34182 RVA: 0x002B8438 File Offset: 0x002B6638
	private void Start()
	{
		if (this.UseBounds)
		{
			Mesh mesh = base.GetComponent<MeshFilter>().mesh;
			this.RenderBounds = mesh.bounds;
		}
		this.Yoffset = OffScreenRenderFX.s_Yoffset;
		OffScreenRenderFX.s_Yoffset += 10f;
		this.PositionObjectToRender();
		this.CreateCamera();
		this.CreateRenderTexture();
		this.SetupCamera();
		this.SetupMaterial();
		base.GetComponent<Renderer>().enabled = true;
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x002B84AA File Offset: 0x002B66AA
	private void OnDestroy()
	{
		if (this.tempRenderBuffer != null && this.tempRenderBuffer.IsCreated())
		{
			RenderTexture.ReleaseTemporary(this.tempRenderBuffer);
		}
	}

	// Token: 0x06008588 RID: 34184 RVA: 0x002B84D4 File Offset: 0x002B66D4
	private void CreateCamera()
	{
		if (this.offscreenFXCameraGO == null)
		{
			if (this.offscreenFXCamera != null)
			{
				UnityEngine.Object.Destroy(this.offscreenFXCamera);
			}
			this.offscreenFXCameraGO = new GameObject();
			this.offscreenFXCamera = this.offscreenFXCameraGO.AddComponent<Camera>();
			this.offscreenFXCameraGO.name = base.name + "_OffScreenFXCamera";
			//SceneUtils.SetHideFlags(this.offscreenFXCameraGO, HideFlags.HideAndDontSave);
			//UniversalInputManager.Get().AddIgnoredCamera(this.offscreenFXCamera);
		}
	}

	// Token: 0x06008589 RID: 34185 RVA: 0x002B8560 File Offset: 0x002B6760
	private void SetupCamera()
	{
		this.offscreenFXCamera.orthographic = true;
		this.UpdateOffScreenCamera();
		this.offscreenFXCamera.transform.parent = base.transform;
		this.offscreenFXCamera.nearClipPlane = -this.AboveClip;
		this.offscreenFXCamera.farClipPlane = this.BelowClip;
		this.offscreenFXCamera.targetTexture = this.tempRenderBuffer;
		//this.offscreenFXCamera.depth = Camera.main.depth - 1f;
		this.offscreenFXCamera.backgroundColor = Color.black;
		this.offscreenFXCamera.clearFlags = CameraClearFlags.Color;
		this.offscreenFXCamera.rect = this.CameraRect;
		this.offscreenFXCamera.enabled = true;
		this.offscreenFXCamera.allowHDR = false;
	}

	// Token: 0x0600858A RID: 34186 RVA: 0x002B862C File Offset: 0x002B682C
	private void UpdateOffScreenCamera()
	{
		if (this.ObjectToRender == null)
		{
			return;
		}
		if (this.ForceSize == 0f)
		{
			float num = base.transform.localScale.x;
			if (this.UseBounds)
			{
				num *= this.RenderBounds.size.x;
			}
			this.offscreenFXCamera.orthographicSize = num / 2f;
		}
		else
		{
			this.offscreenFXCamera.orthographicSize = this.ForceSize;
		}
		this.offscreenFXCameraGO.transform.position = this.ObjectToRender.transform.position;
		this.offscreenFXCameraGO.transform.rotation = this.ObjectToRender.transform.rotation;
		this.offscreenFXCameraGO.transform.Rotate(90f, 180f, 0f);
	}

	// Token: 0x0600858B RID: 34187 RVA: 0x002B8705 File Offset: 0x002B6905
	private void CreateRenderTexture()
	{
		this.tempRenderBuffer = RenderTexture.GetTemporary(this.RenderResolutionX, this.RenderResolutionY);
	}

	// Token: 0x0600858C RID: 34188 RVA: 0x002B871E File Offset: 0x002B691E
	private void SetupMaterial()
	{
		//RenderMaterialCleaner.AttachTo(base.gameObject);
		base.gameObject.GetComponent<Renderer>().material.mainTexture = this.tempRenderBuffer;
	}

	// Token: 0x0600858D RID: 34189 RVA: 0x002B8748 File Offset: 0x002B6948
	private void PositionObjectToRender()
	{
		Vector3 b = Vector3.up * this.Yoffset;
		Vector3 b2 = Vector3.right * OffScreenRenderFX.s_Xoffset;
		if (this.ObjectToRender != null)
		{
			this.ObjectToRender.transform.position += b;
		}
		this.ObjectToRender.transform.position += b2;
	}
	

	// Token: 0x04006B00 RID: 27392
	public GameObject ObjectToRender;

	// Token: 0x04006B01 RID: 27393
	public bool UseBounds = true;

	// Token: 0x04006B02 RID: 27394
	public int RenderResolutionX = 256;

	// Token: 0x04006B03 RID: 27395
	public int RenderResolutionY = 256;

	// Token: 0x04006B04 RID: 27396
	public float AboveClip = 1f;

	// Token: 0x04006B05 RID: 27397
	public float BelowClip = 1f;

	// Token: 0x04006B06 RID: 27398
	public float ForceSize;

	// Token: 0x04006B07 RID: 27399
	public Rect CameraRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04006B08 RID: 27400
	private Camera offscreenFXCamera;

	// Token: 0x04006B09 RID: 27401
	private GameObject offscreenFXCameraGO;

	// Token: 0x04006B0A RID: 27402
	private RenderTexture tempRenderBuffer;

	// Token: 0x04006B0B RID: 27403
	private const int IgnoreLayer = 21;

	// Token: 0x04006B0C RID: 27404
	private float Yoffset;

	// Token: 0x04006B0D RID: 27405
	private Bounds RenderBounds;

	// Token: 0x04006B0E RID: 27406
	private static float s_Yoffset = 250f;

	// Token: 0x04006B0F RID: 27407
	private static float s_Xoffset = 250f;
}
