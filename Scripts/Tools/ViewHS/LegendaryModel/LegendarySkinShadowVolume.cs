using System;
using UnityEngine;

// Token: 0x02000B77 RID: 2935
public class LegendarySkinShadowVolume : MonoBehaviour
{
	// Token: 0x06005A7F RID: 23167 RVA: 0x001B5F4B File Offset: 0x001B414B
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(base.transform.position, this.Radius);
	}

	// Token: 0x06005A80 RID: 23168 RVA: 0x001B5F6D File Offset: 0x001B416D
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color32(byte.MaxValue, byte.MaxValue, 0, 128);
		Gizmos.DrawSphere(base.transform.position, this.Radius);
	}

	// Token: 0x04003FA6 RID: 16294
	[Min(0f)]
	public float Radius;
}
