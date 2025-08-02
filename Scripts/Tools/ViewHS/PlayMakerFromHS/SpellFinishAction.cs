using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EAB RID: 3755
	[ActionCategory("Pegasus")]
	[Tooltip("Tells the game that a Spell is finished, allowing the game to progress.")]
	public class SpellFinishAction : SpellAction
	{
		/*
		// Token: 0x0600A34A RID: 41802 RVA: 0x00334DBB File Offset: 0x00332FBB
		protected override GameObject GetSpellOwner()
		{
			return base.Fsm.GetOwnerDefaultTarget(this.m_SpellObject);
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x00334DD0 File Offset: 0x00332FD0
		public override void OnEnter()
		{
			base.OnEnter();
			if (this.m_spell == null)
			{
				Debug.LogError(string.Format("{0}.OnEnter() - FAILED to find Spell component on Owner \"{1}\"", this, base.Owner));
				return;
			}
			if (this.m_Delay.Value > 0f)
			{
				this.m_spell.StartCoroutine(this.DelaySpellFinished());
			}
			else
			{
				this.m_spell.OnSpellFinished();
			}
			base.Finish();
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x00334E3F File Offset: 0x0033303F
		private IEnumerator DelaySpellFinished()
		{
			yield return new WaitForSeconds(this.m_Delay.Value);
			this.m_spell.OnSpellFinished();
			yield break;
		}
		*/
		// Token: 0x0400874B RID: 34635
		public FsmOwnerDefault m_SpellObject;

		// Token: 0x0400874C RID: 34636
		public FsmFloat m_Delay = 0f;
	}
}
