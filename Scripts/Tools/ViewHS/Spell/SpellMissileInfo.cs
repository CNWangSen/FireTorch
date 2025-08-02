using System;
using UnityEngine;

// Token: 0x02000900 RID: 2304
[Serializable]
public class SpellMissileInfo
{
	// Token: 0x04006572 RID: 25970
	public bool m_Enabled = true;

	// Token: 0x04006573 RID: 25971
	public Spell m_Prefab;

	// Token: 0x04006574 RID: 25972
	public Spell m_ReversePrefab;

	// Token: 0x04006575 RID: 25973
	public float m_reverseDelay;

	// Token: 0x04006576 RID: 25974
	public bool m_UseSuperSpellLocation = true;

	// Token: 0x04006577 RID: 25975
	public float m_SpawnDelaySecMin;

	// Token: 0x04006578 RID: 25976
	public float m_SpawnDelaySecMax;

	// Token: 0x04006579 RID: 25977
	public bool m_SpawnInSequence;

	// Token: 0x0400657A RID: 25978
	public float m_SpawnOffset;

	// Token: 0x0400657B RID: 25979
	public float m_PathDurationMin = 0.5f;

	// Token: 0x0400657C RID: 25980
	public float m_PathDurationMax = 1f;

	// Token: 0x0400657D RID: 25981
	public iTween.EaseType m_PathEaseType = iTween.EaseType.linear;

	// Token: 0x0400657E RID: 25982
	public bool m_OrientToPath;

	// Token: 0x0400657F RID: 25983
	public float m_CenterOffsetPercent = 50f;

	// Token: 0x04006580 RID: 25984
	public float m_CenterPointHeightMin;

	// Token: 0x04006581 RID: 25985
	public float m_CenterPointHeightMax;

	// Token: 0x04006582 RID: 25986
	public float m_RightMin;

	// Token: 0x04006583 RID: 25987
	public float m_RightMax;

	// Token: 0x04006584 RID: 25988
	public float m_LeftMin;

	// Token: 0x04006585 RID: 25989
	public float m_LeftMax;

	// Token: 0x04006586 RID: 25990
	public bool m_DebugForceMax;

	// Token: 0x04006587 RID: 25991
	public float m_DistanceScaleFactor = 8f;

	// Token: 0x04006588 RID: 25992
	public string m_TargetJoint = "TargetJoint";

	// Token: 0x04006589 RID: 25993
	public float m_TargetHeightOffset = 0.5f;

	// Token: 0x0400658A RID: 25994
	public Vector3 m_JointUpVector = Vector3.up;

	// Token: 0x0400658B RID: 25995
	public bool m_UseTargetCardPositionInsteadOfHandSlot;
}
