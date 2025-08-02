using System;
using UnityEngine;

// Token: 0x02000901 RID: 2305
[Serializable]
public class SpellImpactInfo
{
	// Token: 0x0400658C RID: 25996
	public bool m_Enabled = true;

	// Token: 0x0400658D RID: 25997
	[Tooltip("This spell will be chosen by default if the card deals no damage.")]
	public Spell m_Prefab;

	// Token: 0x0400658E RID: 25998
	[Tooltip("If the card deals damage, the spell in the appropriate damage range will be chosen. If the damage exceeds all ranges, we pick the one with the highest maximum range. If the damage number is not within any specified range, we will use the default spell (see above)")]
	public SpellValueRange[] m_damageAmountImpactSpells;

	// Token: 0x0400658F RID: 25999
	public bool m_UseSuperSpellLocation;

	// Token: 0x04006590 RID: 26000
	public SpellLocation m_Location = SpellLocation.TARGET;

	// Token: 0x04006591 RID: 26001
	public bool m_SetParentToLocation;

	// Token: 0x04006592 RID: 26002
	public float m_SpawnDelaySecMin;

	// Token: 0x04006593 RID: 26003
	public float m_SpawnDelaySecMax;

	// Token: 0x04006594 RID: 26004
	public float m_SpawnOffset;

	// Token: 0x04006595 RID: 26005
	public float m_GameDelaySecMin = 0.5f;

	// Token: 0x04006596 RID: 26006
	public float m_GameDelaySecMax = 0.5f;
}
