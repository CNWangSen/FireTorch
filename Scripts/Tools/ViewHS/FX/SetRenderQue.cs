using System;
using UnityEngine;

// Token: 0x020009F2 RID: 2546
[RequireComponent(typeof(Renderer))]
public class SetRenderQue : MonoBehaviour
{
	// Token: 0x060086DA RID: 34522 RVA: 0x002C33ED File Offset: 0x002C15ED
	private void Awake()
	{
		this.m_Renderer = base.GetComponent<Renderer>();
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x002C33FC File Offset: 0x002C15FC
	private void Start()
	{
		RenderMaterialCleaner.AttachTo(base.gameObject);
		if (this.includeChildren)
		{
			foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
			{
				if (!(renderer == null))
				{
					renderer.sortingOrder += this.queue;
				}
			}
		}
		else
		{
			if (this.m_Renderer == null)
			{
				return;
			}
			this.m_Renderer.sortingOrder += this.queue;
		}
		if (this.queues == null)
		{
			return;
		}
		if (this.m_Renderer == null)
		{
			return;
		}
		Material[] sharedMaterials = this.m_Renderer.sharedMaterials;
		if (sharedMaterials == null)
		{
			return;
		}
		int num = sharedMaterials.Length;
		int num2 = 0;
		while (num2 < this.queues.Length && num2 < num)
		{
			int num3 = this.queues[num2];
			if (num3 != 0 && num3 != this.queue)
			{
				Material sharedMaterial = RenderUtils.GetSharedMaterial(this.m_Renderer, num2);
				if (!(sharedMaterial == null))
				{
					if (num3 < 0)
					{
						Debug.LogWarning(string.Format("WARNING: Using negative renderQueue for {0}'s {1} (renderQueue = {2})", base.transform.root.name, base.gameObject.name, this.queues[num2]));
					}
					Material material = new Material(sharedMaterial);
					material.renderQueue += num3;
					RenderUtils.SetMaterial(this.m_Renderer, num2, material);
				}
			}
			num2++;
		}
	}

	// Token: 0x04006D01 RID: 27905
	public int queue = 1;

	// Token: 0x04006D02 RID: 27906
	public bool includeChildren;

	// Token: 0x04006D03 RID: 27907
	public int[] queues;

	// Token: 0x04006D04 RID: 27908
	private Renderer m_Renderer;
}
