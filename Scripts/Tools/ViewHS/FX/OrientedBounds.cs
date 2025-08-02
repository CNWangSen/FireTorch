using System;
using UnityEngine;

// Token: 0x0200096C RID: 2412
public class OrientedBounds
{
	// Token: 0x06008129 RID: 33065 RVA: 0x0029C7AD File Offset: 0x0029A9AD
	public Vector3 GetTrueCenterPosition()
	{
		return this.Origin + this.CenterOffset;
	}

	// Token: 0x040067A5 RID: 26533
	public Vector3[] Extents;

	// Token: 0x040067A6 RID: 26534
	public Vector3 Origin;

	// Token: 0x040067A7 RID: 26535
	public Vector3 CenterOffset;
}
