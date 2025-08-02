using System;
using UnityEngine;

// Token: 0x02000788 RID: 1928
public class OverrideCustomDeathSpell : SuperSpell
{
	/*
	// Token: 0x06006711 RID: 26385 RVA: 0x00219E50 File Offset: 0x00218050
	protected override void OnAction(SpellStateType prevStateType)
	{
		this.m_effectsPendingFinish++;
		base.OnAction(prevStateType);
		foreach (GameObject gameObject in this.GetVisualTargets())
		{
			if (!(gameObject == null))
			{
				Card component = gameObject.GetComponent<Card>();
				component.OverrideCustomDeathSpell(UnityEngine.Object.Instantiate<Spell>(this.m_CustomDeathSpell));
				component.SuppressKeywordDeaths(this.m_SuppressKeywordDeaths);
				component.SetKeywordDeathDelaySec(this.m_KeywordDeathDelay);
			}
		}
		this.m_effectsPendingFinish--;
		base.FinishIfPossible();
	}
*/
	// Token: 0x04004EC2 RID: 20162
	//public Spell m_CustomDeathSpell;

	// Token: 0x04004EC3 RID: 20163
	public bool m_SuppressKeywordDeaths = true;

	// Token: 0x04004EC4 RID: 20164
	public float m_KeywordDeathDelay = 0.6f;
}
