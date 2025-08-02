using System;
using UnityEngine;

// Token: 0x020009E7 RID: 2535
public class RotateOverTime : MonoBehaviour
{
	// Token: 0x06008687 RID: 34439 RVA: 0x002C216C File Offset: 0x002C036C
	private void Start()
	{
		if (this.RandomStartX)
		{
			base.transform.Rotate(Vector3.left, (float)UnityEngine.Random.Range(0, 360));
		}
		if (this.RandomStartY)
		{
			base.transform.Rotate(Vector3.up, (float)UnityEngine.Random.Range(0, 360));
		}
		if (this.RandomStartZ)
		{
			base.transform.Rotate(Vector3.forward, (float)UnityEngine.Random.Range(0, 360));
		}
	}

	// Token: 0x06008688 RID: 34440 RVA: 0x002C21E8 File Offset: 0x002C03E8
	private void Update()
	{
		base.transform.Rotate(Vector3.left, Time.deltaTime * this.RotateSpeedX, Space.Self);
		base.transform.Rotate(Vector3.up, Time.deltaTime * this.RotateSpeedY, Space.Self);
		base.transform.Rotate(Vector3.forward, Time.deltaTime * this.RotateSpeedZ, Space.Self);
	}

	// Token: 0x04006CC1 RID: 27841
	public float RotateSpeedX;

	// Token: 0x04006CC2 RID: 27842
	public float RotateSpeedY;

	// Token: 0x04006CC3 RID: 27843
	public float RotateSpeedZ;

	// Token: 0x04006CC4 RID: 27844
	public bool RandomStartX;

	// Token: 0x04006CC5 RID: 27845
	public bool RandomStartY;

	// Token: 0x04006CC6 RID: 27846
	public bool RandomStartZ;
}
