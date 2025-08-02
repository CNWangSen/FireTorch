using System;
using UnityEngine;

// Token: 0x020009FC RID: 2556
public class Spinner : MonoBehaviour
{
	// Token: 0x06008718 RID: 34584 RVA: 0x002C42EB File Offset: 0x002C24EB
	public void Update()
	{
		base.transform.Rotate(Vector3.right, Time.deltaTime * this.SpeedX);
		base.transform.Rotate(Vector3.up, Time.deltaTime * this.SpeedY, Space.World);
	}

	// Token: 0x04006D37 RID: 27959
	public float SpeedX;

	// Token: 0x04006D38 RID: 27960
	public float SpeedY;
}
