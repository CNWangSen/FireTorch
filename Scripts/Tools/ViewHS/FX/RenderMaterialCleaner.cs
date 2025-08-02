using System;
using UnityEngine;

// Token: 0x0200095F RID: 2399
public class RenderMaterialCleaner : MonoBehaviour
{
	// Token: 0x06008056 RID: 32854 RVA: 0x00299B7E File Offset: 0x00297D7E
	public static void AttachTo(Renderer renderer)
	{
		if (!renderer)
		{
			return;
		}
		RenderMaterialCleaner.AttachTo(renderer.gameObject);
	}

	// Token: 0x06008057 RID: 32855 RVA: 0x00299B94 File Offset: 0x00297D94
	public static void AttachTo(GameObject go)
	{
		if (!go)
		{
			return;
		}
		if (!go.GetComponent<RenderMaterialCleaner>())
		{
			go.AddComponent<RenderMaterialCleaner>();
		}
	}

	// Token: 0x06008058 RID: 32856 RVA: 0x00299BB4 File Offset: 0x00297DB4
	private void OnDestroy()
	{
		foreach (Renderer renderer in base.gameObject.GetComponents<Renderer>())
		{
			if (renderer != null)
			{
				RenderUtils.DestroyCreatedMaterials(renderer);
			}
		}
	}
}
