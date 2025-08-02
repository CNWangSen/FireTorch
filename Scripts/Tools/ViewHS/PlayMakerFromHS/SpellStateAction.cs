using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EB8 RID: 3768
	[ActionCategory("Pegasus")]
	[Tooltip("Handles communication between a Spell and the SpellStates in an FSM.")]
	public class SpellStateAction : SpellAction
	{
		/*
		// Token: 0x0600A377 RID: 41847 RVA: 0x00335616 File Offset: 0x00333816
		protected override GameObject GetSpellOwner()
		{
			return base.Fsm.GetOwnerDefaultTarget(this.m_SpellObject);
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x0033562C File Offset: 0x0033382C
		public override void OnEnter()
		{
			base.OnEnter();
			if (this.m_spell == null)
			{
				return;
			}
			this.DiscoverSpellStateType();
			if (this.m_stateInvalid)
			{
				return;
			}
			this.m_spell.OnFsmStateStarted(base.State, this.m_spellStateType);
			base.Finish();
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x0033567C File Offset: 0x0033387C
		private void DiscoverSpellStateType()
		{
			if (!this.m_stateDirty)
			{
				return;
			}
			string name = base.State.Name;
			foreach (FsmTransition fsmTransition in base.Fsm.GlobalTransitions)
			{
				if (name.Equals(fsmTransition.ToState))
				{
					this.m_spellStateType = EnumUtils.GetEnum<SpellStateType>(fsmTransition.EventName);
					this.m_stateDirty = false;
					return;
				}
			}
			this.m_stateInvalid = true;
		}
		*/
		// Token: 0x0400876D RID: 34669
		public FsmOwnerDefault m_SpellObject;

		// Token: 0x0400876E RID: 34670
		private SpellStateType m_spellStateType;

		// Token: 0x0400876F RID: 34671
		private bool m_stateInvalid;

		// Token: 0x04008770 RID: 34672
		private bool m_stateDirty = true;
	}
}
