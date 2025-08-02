using System;
using System.Collections;

// Token: 0x0200065C RID: 1628
public class ActorAttackSpell : Spell
{
	// Token: 0x060059CC RID: 22988 RVA: 0x001DAF82 File Offset: 0x001D9182
	//protected override void Start()
	//{
	//	base.Start();
	//}

	// Token: 0x060059CD RID: 22989 RVA: 0x001DAF8A File Offset: 0x001D918A
	//protected override void OnBirth(SpellStateType prevStateType)
	//{
	//	this.m_waitingToAct = true;
	//	base.OnBirth(prevStateType);
	//}

	// Token: 0x060059CE RID: 22990 RVA: 0x001DAF9A File Offset: 0x001D919A
	//protected override void OnAction(SpellStateType prevStateType)
	//{
	//	base.StartCoroutine(this.WaitThenDoAction(prevStateType));
	//}

	// Token: 0x060059CF RID: 22991 RVA: 0x001DAFAA File Offset: 0x001D91AA
	private void StopWaitingToAct()
	{
		this.m_waitingToAct = false;
	}

	// Token: 0x060059D0 RID: 22992 RVA: 0x001DAFB3 File Offset: 0x001D91B3
	protected IEnumerator WaitThenDoAction(SpellStateType prevStateType)
	{
		while (this.m_waitingToAct)
		{
			yield return null;
		}
		//base.OnAction(prevStateType);
		yield break;
	}

	// Token: 0x040046AA RID: 18090
	private bool m_waitingToAct = true;
}
