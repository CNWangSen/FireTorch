using System;

// Token: 0x02000649 RID: 1609
[Serializable]
public class HeroAttackDef
{
	// Token: 0x04004628 RID: 17960
	public float m_MoveToTargetDuration = 0.12f;

	// Token: 0x04004629 RID: 17961
	public iTween.EaseType m_MoveToTargetEaseType = iTween.EaseType.linear;

	// Token: 0x0400462A RID: 17962
	public float m_OrientToTargetDuration = 0.3f;

	// Token: 0x0400462B RID: 17963
	public iTween.EaseType m_OrientToTargetEaseType = iTween.EaseType.linear;

	// Token: 0x0400462C RID: 17964
	public float m_MoveBackDuration = 0.15f;

	// Token: 0x0400462D RID: 17965
	public iTween.EaseType m_MoveBackEaseType = iTween.EaseType.linear;

	// Token: 0x0400462E RID: 17966
	public float m_OrientBackDuration = 0.3f;

	// Token: 0x0400462F RID: 17967
	public iTween.EaseType m_OrientBackEaseType = iTween.EaseType.linear;
}
