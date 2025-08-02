using System;
using UnityEngine;

// Token: 0x02000987 RID: 2439
public class CameraShaker : MonoBehaviour
{
	// Token: 0x06008247 RID: 33351 RVA: 0x002A0D78 File Offset: 0x0029EF78
	public void StartShake()
	{
		float? holdAtTime = null;
		if (this.m_Hold)
		{
			holdAtTime = new float?(this.m_HoldAtSec);
		}
		//CameraShakeMgr.Shake(Camera.main, this.m_Amount, this.m_IntensityCurve, holdAtTime);
	}

	// Token: 0x040067FD RID: 26621
	public Vector3 m_Amount;

	// Token: 0x040067FE RID: 26622
	public AnimationCurve m_IntensityCurve;

	// Token: 0x040067FF RID: 26623
	public bool m_Hold;

	// Token: 0x04006800 RID: 26624
	public float m_HoldAtSec;
}
