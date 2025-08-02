using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EA1 RID: 3745
	[ActionCategory("Pegasus")]
	[Tooltip("INTERNAL USE ONLY. Do not put this on your FSMs.")]
	public abstract class SpellAction : FsmStateAction
	{
		public override void OnEnter()
		{
			UnityEngine.Debug.Log("Enter:!!!");
			base.Finish();
		}
		/*
		// Token: 0x0600A315 RID: 41749 RVA: 0x00334190 File Offset: 0x00332390
		public Spell GetSpell()
		{
			if (this.m_spell == null)
			{
				GameObject spellOwner = this.GetSpellOwner();
				if (spellOwner != null)
				{
					this.m_spell = SceneUtils.FindComponentInThisOrParents<Spell>(spellOwner);
				}
			}
			return this.m_spell;
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x003341D0 File Offset: 0x003323D0
		public Card GetCard(SpellAction.Which which)
		{
			Spell spell = this.GetSpell();
			if (spell == null)
			{
				return null;
			}
			if (which == SpellAction.Which.TARGET)
			{
				return spell.GetTargetCard();
			}
			Card sourceCard = spell.GetSourceCard();
			if (which == SpellAction.Which.SOURCE_HERO && sourceCard != null)
			{
				return sourceCard.GetHeroCard();
			}
			if (which == SpellAction.Which.CHOSEN_TARGET)
			{
				Card powerTargetCard = spell.GetPowerTargetCard();
				if (powerTargetCard != null)
				{
					return powerTargetCard;
				}
			}
			if (which == SpellAction.Which.SOURCE_PLAYER)
			{
				global::Log.All.PrintError("{0} cannot get card for source player: players are not cards. Did you mean to choose SOURCE_HERO?", new object[]
				{
					this
				});
				if (sourceCard != null)
				{
					return sourceCard.GetHeroCard();
				}
			}
			return sourceCard;
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x0033425C File Offset: 0x0033245C
		public Entity GetEntity(SpellAction.Which which)
		{
			Spell spell = this.GetSpell();
			if (spell == null)
			{
				return null;
			}
			if (which == SpellAction.Which.TARGET)
			{
				return spell.GetTargetCard().GetEntity();
			}
			Card sourceCard = spell.GetSourceCard();
			if (which == SpellAction.Which.SOURCE_HERO && sourceCard != null)
			{
				return sourceCard.GetHero();
			}
			if (which == SpellAction.Which.SOURCE_PLAYER && sourceCard != null)
			{
				return sourceCard.GetController();
			}
			if (which == SpellAction.Which.CHOSEN_TARGET)
			{
				Card powerTargetCard = spell.GetPowerTargetCard();
				if (powerTargetCard != null)
				{
					return powerTargetCard.GetEntity();
				}
			}
			return sourceCard.GetEntity();
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x003342DC File Offset: 0x003324DC
		public Actor GetActor(SpellAction.Which which)
		{
			Card card = this.GetCard(which);
			if (card == null)
			{
				return null;
			}
			return card.GetActor();
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x00334304 File Offset: 0x00332504
		public int GetIndexMatchingCardId(string cardId, string[] cardIds)
		{
			if (cardId == null || cardIds == null || cardIds.Length == 0)
			{
				return -1;
			}
			for (int i = 0; i < cardIds.Length; i++)
			{
				string value = cardIds[i].Trim();
				if (cardId.Equals(value, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600A31A RID: 41754
		protected abstract GameObject GetSpellOwner();

		// Token: 0x0600A31B RID: 41755 RVA: 0x00334341 File Offset: 0x00332541
		public override void OnEnter()
		{
			this.GetSpell();
			if (this.m_spell == null)
			{
				Debug.LogError(string.Format("{0}.OnEnter() - FAILED to find Spell component on Owner \"{1}\"", this, base.Owner));
				return;
			}
		}
		*/
		// Token: 0x04008715 RID: 34581
		protected Spell m_spell;

		// Token: 0x0200241E RID: 9246
		public enum Which
		{
			// Token: 0x0400DA9C RID: 55964
			SOURCE,
			// Token: 0x0400DA9D RID: 55965
			TARGET,
			// Token: 0x0400DA9E RID: 55966
			SOURCE_HERO,
			// Token: 0x0400DA9F RID: 55967
			CHOSEN_TARGET,
			// Token: 0x0400DAA0 RID: 55968
			SOURCE_PLAYER
		}
	}
}
