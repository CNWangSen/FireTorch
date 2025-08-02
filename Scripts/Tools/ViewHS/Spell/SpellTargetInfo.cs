using System;

// Token: 0x020008FD RID: 2301
[Serializable]
public class SpellTargetInfo
{
	// Token: 0x04006567 RID: 25959
	public SpellTargetBehavior m_Behavior;

	// Token: 0x04006568 RID: 25960
	public int m_RandomTargetCountMin = 8;

	// Token: 0x04006569 RID: 25961
	public int m_RandomTargetCountMax = 10;

	// Token: 0x0400656A RID: 25962
	public bool m_SuppressPlaySounds;
}
