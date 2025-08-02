using System;
using UnityEngine;

// Token: 0x0200028B RID: 651
public class RenderTextureTracker
{
	// Token: 0x060020A4 RID: 8356 RVA: 0x00004FE6 File Offset: 0x000031E6
	private RenderTextureTracker()
	{
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000A15B7 File Offset: 0x0009F7B7
	public static RenderTextureTracker Get()
	{
		if (RenderTextureTracker.m_instance == null)
		{
			RenderTextureTracker.m_instance = new RenderTextureTracker();
		}
		return RenderTextureTracker.m_instance;
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000A15CF File Offset: 0x0009F7CF
	public RenderTexture CreateNewTexture(int width, int height, int depth, RenderTextureFormat format = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return new RenderTexture(width, height, depth, format, readWrite);
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000A15DD File Offset: 0x0009F7DD
	public void DestroyRenderTexture(RenderTexture renderTexture)
	{
		UnityEngine.Object.Destroy(renderTexture);
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000A15E5 File Offset: 0x0009F7E5
	public void ReleaseRenderTexture(RenderTexture renderTexture)
	{
		renderTexture.Release();
	}

	// Token: 0x0400122B RID: 4651
	private static RenderTextureTracker m_instance;
}
