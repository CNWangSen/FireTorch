using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EA8 RID: 3752
	[ActionCategory("Pegasus")]
	[Tooltip("Send an event based on a Spell's Card's Type.")]
	public class SpellCardTypeAction : SpellAction
	{
		// Token: 0x0600A33D RID: 41789 RVA: 0x00334ADF File Offset: 0x00332CDF
		//protected override GameObject GetSpellOwner()
		//{
		//	return base.Fsm.GetOwnerDefaultTarget(this.m_SpellObject);
		//}

		// Token: 0x0600A33E RID: 41790 RVA: 0x00334AF2 File Offset: 0x00332CF2
		public override void Reset()
		{
			this.m_SpellObject = null;
			this.m_WhichCard = SpellAction.Which.SOURCE;
			this.m_MinionEvent = null;
			this.m_HeroEvent = null;
			this.m_HeroPowerEvent = null;
			this.m_WeaponEvent = null;
			this.m_SpellEvent = null;
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x00334B28 File Offset: 0x00332D28
		public override void OnEnter()
		{
			base.OnEnter();
			/*
			Card card = base.GetCard(this.m_WhichCard);
			if (card == null)
			{
				Error.AddDevFatal("SpellCardTypeAction.OnEnter() - Card not found!", Array.Empty<object>());
				base.Finish();
				return;
			}
			TAG_CARDTYPE cardType = card.GetEntity().GetCardType();
			switch (cardType)
			{
			case TAG_CARDTYPE.HERO:
				base.Fsm.Event(this.m_HeroEvent);
				goto IL_E4;
			case TAG_CARDTYPE.MINION:
				base.Fsm.Event(this.m_MinionEvent);
				goto IL_E4;
			case TAG_CARDTYPE.SPELL:
				base.Fsm.Event(this.m_SpellEvent);
				goto IL_E4;
			case TAG_CARDTYPE.WEAPON:
				base.Fsm.Event(this.m_WeaponEvent);
				goto IL_E4;
			case TAG_CARDTYPE.HERO_POWER:
				base.Fsm.Event(this.m_HeroPowerEvent);
				goto IL_E4;
			}
			Error.AddDevFatal("SpellCardTypeAction.OnEnter() - unknown type {0} on {1}", new object[]
			{
				cardType,
				card
			});
			IL_E4:
			*/
			base.Fsm.Event(this.m_MinionEvent);
			base.Finish();
		}

		// Token: 0x0400873E RID: 34622
		public FsmOwnerDefault m_SpellObject;

		// Token: 0x0400873F RID: 34623
		public SpellAction.Which m_WhichCard;

		// Token: 0x04008740 RID: 34624
		public FsmEvent m_MinionEvent;

		// Token: 0x04008741 RID: 34625
		public FsmEvent m_HeroEvent;

		// Token: 0x04008742 RID: 34626
		public FsmEvent m_HeroPowerEvent;

		// Token: 0x04008743 RID: 34627
		public FsmEvent m_WeaponEvent;

		// Token: 0x04008744 RID: 34628
		public FsmEvent m_SpellEvent;
	}
}
