using System;

// Token: 0x02000902 RID: 2306
[Serializable]
public class SpellAreaEffectInfo
{
	// Token: 0x04006597 RID: 26007
	public bool m_Enabled = true;

	// Token: 0x04006598 RID: 26008
	public Spell m_Prefab;

	// Token: 0x04006599 RID: 26009
	public bool m_UseSuperSpellLocation;

	// Token: 0x0400659A RID: 26010
	public SpellLocation m_Location;

	// Token: 0x0400659B RID: 26011
	public bool m_SetParentToLocation;

	// Token: 0x0400659C RID: 26012
	public SpellFacing m_Facing;

	// Token: 0x0400659D RID: 26013
	public SpellFacingOptions m_FacingOptions;

	// Token: 0x0400659E RID: 26014
	public float m_SpawnDelaySecMin;

	// Token: 0x0400659F RID: 26015
	public float m_SpawnDelaySecMax;
}
