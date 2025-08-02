using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200064B RID: 1611
public class AttackSpellController : SpellController
{
	/*
	// Token: 0x060058EB RID: 22763 RVA: 0x001D57CC File Offset: 0x001D39CC
	protected override bool AddPowerSourceAndTargets(PowerTaskList taskList)
	{
		this.m_attackType = taskList.GetAttackType();
		if (this.m_attackType == AttackType.INVALID)
		{
			return false;
		}
		Entity attacker = taskList.GetAttacker();
		if (attacker != null)
		{
			base.SetSource(attacker.GetCard());
		}
		Entity defender = taskList.GetDefender();
		if (defender != null)
		{
			base.AddTarget(defender.GetCard());
		}
		return true;
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x001D581C File Offset: 0x001D3A1C
	protected override void OnProcessTaskList()
	{
		if (this.m_attackType == AttackType.ONLY_PROPOSED_ATTACKER || this.m_attackType == AttackType.ONLY_PROPOSED_DEFENDER || this.m_attackType == AttackType.ONLY_ATTACKER || this.m_attackType == AttackType.ONLY_DEFENDER || this.m_attackType == AttackType.WAITING_ON_PROPOSED_ATTACKER || this.m_attackType == AttackType.WAITING_ON_PROPOSED_DEFENDER || this.m_attackType == AttackType.WAITING_ON_ATTACKER || this.m_attackType == AttackType.WAITING_ON_DEFENDER)
		{
			this.FinishEverything();
			return;
		}
		Card source = base.GetSource();
		if (source == null || source.GetActor() == null)
		{
			this.FinishEverything();
			return;
		}
		Entity entity = source.GetEntity();
		if (entity == null)
		{
			this.FinishEverything();
			return;
		}
		Zone zone = source.GetZone();
		if (zone == null)
		{
			zone = ZoneMgr.Get().FindZoneOfType<ZonePlay>(source.GetControllerSide());
		}
		bool flag = zone.m_Side == Player.Side.FRIENDLY;
		this.m_sourceAttackSpell = this.GetSourceAttackSpell(source, flag);
		if (this.m_attackType == AttackType.CANCELED)
		{
			this.CancelAttackSpell(entity, this.m_sourceAttackSpell);
			source.SetDoNotSort(false);
			zone.UpdateLayout();
			source.EnableAttacking(false);
			this.FinishEverything();
			return;
		}
		if (this.m_sourceAttackSpell == null)
		{
			this.FinishEverything();
			return;
		}
		source.EnableAttacking(true);
		if (entity.GetTag(GAME_TAG.IMMUNE_WHILE_ATTACKING) != 0)
		{
			source.ActivateActorSpell(SpellType.IMMUNE);
		}
		else if (!source.ShouldShowImmuneVisuals())
		{
			SpellUtils.ActivateDeathIfNecessary(source.GetActor().GetSpellIfLoaded(SpellType.IMMUNE));
		}
		this.m_sourceAttackSpell.AddStateStartedCallback(new Spell.StateStartedCallback(this.OnSourceAttackStateStarted));
		if (flag)
		{
			if (this.m_sourceAttackSpell.GetActiveState() != SpellStateType.IDLE)
			{
				this.m_sourceAttackSpell.ActivateState(SpellStateType.BIRTH);
				return;
			}
			this.m_sourceAttackSpell.ActivateState(SpellStateType.ACTION);
			return;
		}
		else
		{
			if (this.m_sourceAttackSpell.GetActiveState() != SpellStateType.IDLE)
			{
				this.m_sourceAttackSpell.ActivateState(SpellStateType.BIRTH);
				return;
			}
			this.m_sourceAttackSpell.ActivateState(SpellStateType.ACTION);
			return;
		}
	}

	// Token: 0x060058ED RID: 22765 RVA: 0x001D59D4 File Offset: 0x001D3BD4
	private void OnSourceAttackStateStarted(Spell spell, SpellStateType prevStateType, object userData)
	{
		SpellStateType activeState = spell.GetActiveState();
		if (activeState == SpellStateType.IDLE)
		{
			spell.ActivateState(SpellStateType.ACTION);
			return;
		}
		if (activeState == SpellStateType.ACTION)
		{
			spell.RemoveStateStartedCallback(new Spell.StateStartedCallback(this.OnSourceAttackStateStarted));
			this.LaunchAttack();
		}
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x001D5A14 File Offset: 0x001D3C14
	private void LaunchAttack()
	{
		Card source = base.GetSource();
		Entity entity = source.GetEntity();
		Card target = base.GetTarget();
		bool flag = this.m_attackType == AttackType.PROPOSED;
		if (flag && entity.IsHero())
		{
			this.m_sourceAttackSpell.ActivateState(SpellStateType.IDLE);
			this.FinishEverything();
			return;
		}
		this.m_sourcePos = source.transform.position;
		this.m_sourceToTarget = target.transform.position - this.m_sourcePos;
		Vector3 impactPos = this.ComputeImpactPos();
		source.SetDoNotSort(true);
		this.MoveSourceToTarget(source, entity, impactPos);
		if (entity.IsHero())
		{
			this.OrientSourceHeroToTarget(source);
		}
		if (flag)
		{
			return;
		}
		target.SetDoNotSort(true);
		this.MoveTargetToSource(target, entity, impactPos);
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x001D5AC8 File Offset: 0x001D3CC8
	private bool HasFinishAttackSpellOnDamage()
	{
		Card source = base.GetSource();
		if (source == null)
		{
			return false;
		}
		Entity entity = source.GetEntity();
		if (entity == null)
		{
			return false;
		}
		if (!entity.IsHero())
		{
			return entity.HasTag(GAME_TAG.FINISH_ATTACK_SPELL_ON_DAMAGE);
		}
		Player controller = entity.GetController();
		if (controller == null)
		{
			return false;
		}
		Card weaponCard = controller.GetWeaponCard();
		if (weaponCard == null)
		{
			return false;
		}
		Entity entity2 = weaponCard.GetEntity();
		return entity2 != null && entity2.HasTag(GAME_TAG.FINISH_ATTACK_SPELL_ON_DAMAGE);
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x001D5B40 File Offset: 0x001D3D40
	private void UpdateTargetOnMoveToTargetFinished(Card targetCard)
	{
		targetCard.SetDoNotSort(false);
		Zone zone = targetCard.GetZone();
		if (zone == null)
		{
			zone = targetCard.GetPrevZone();
			if (!targetCard.GetEntity().IsHero())
			{
				Log.Spells.PrintWarning("AttackSpellController.UpdateTargetOnMoveToTargetFinished() - Non-hero target ({0}) was moved from {1} to SETASIDE before the attack was resolved.", new object[]
				{
					targetCard.name,
					zone.name
				});
			}
		}
		zone.UpdateLayout();
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x001D5BA8 File Offset: 0x001D3DA8
	private void OnMoveToTargetFinished()
	{
		Card source = base.GetSource();
		EntityBase entity = source.GetEntity();
		Card target = base.GetTarget();
		bool flag = this.m_attackType == AttackType.PROPOSED;
		this.DoTasks(source, target);
		if (!flag)
		{
			this.ActivateImpactEffects(source, target);
		}
		if (entity.IsHero())
		{
			this.MoveSourceHeroBack(source);
			this.OrientSourceHeroBack(source);
			this.UpdateTargetOnMoveToTargetFinished(target);
			if (this.HasFinishAttackSpellOnDamage())
			{
				this.FinishHeroAttack();
				return;
			}
		}
		else
		{
			if (flag)
			{
				this.FinishEverything();
				return;
			}
			source.SetDoNotSort(false);
			source.GetZone().UpdateLayout();
			this.UpdateTargetOnMoveToTargetFinished(target);
			if (this.HasFinishAttackSpellOnDamage())
			{
				this.FinishAttackSpellController();
			}
			else
			{
				this.m_sourceAttackSpell.AddStateFinishedCallback(new Spell.StateFinishedCallback(this.OnMinionSourceAttackStateFinished));
			}
			this.m_sourceAttackSpell.ActivateState(SpellStateType.DEATH);
		}
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x001D5C67 File Offset: 0x001D3E67
	private void DoTasks(Card sourceCard, Card targetCard)
	{
		GameUtils.DoDamageTasks(this.m_taskList, sourceCard, targetCard);
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x001D5C78 File Offset: 0x001D3E78
	private void MoveSourceHeroBack(Card sourceCard)
	{
		Hashtable args = iTween.Hash(new object[]
		{
			"position",
			this.m_sourcePos,
			"time",
			this.m_HeroInfo.m_MoveBackDuration,
			"easetype",
			this.m_HeroInfo.m_MoveBackEaseType,
			"oncomplete",
			"OnHeroMoveBackFinished",
			"oncompletetarget",
			base.gameObject
		});
		iTween.MoveTo(sourceCard.gameObject, args);
	}

	// Token: 0x060058F4 RID: 22772 RVA: 0x001D5D0C File Offset: 0x001D3F0C
	private void OrientSourceHeroBack(Card sourceCard)
	{
		Hashtable args = iTween.Hash(new object[]
		{
			"rotation",
			Quaternion.LookRotation(this.m_sourceFacing).eulerAngles,
			"time",
			this.m_HeroInfo.m_OrientBackDuration,
			"easetype",
			this.m_HeroInfo.m_OrientBackEaseType
		});
		iTween.RotateTo(sourceCard.gameObject, args);
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x001D5D8C File Offset: 0x001D3F8C
	private void OnHeroMoveBackFinished()
	{
		Card source = base.GetSource();
		Entity entity = source.GetEntity();
		source.SetDoNotSort(false);
		source.EnableAttacking(false);
		if (this.HasFinishAttackSpellOnDamage())
		{
			return;
		}
		if (entity.GetController().IsLocalUser() || this.m_sourceAttackSpell.GetActiveState() == SpellStateType.NONE)
		{
			this.FinishHeroAttack();
			return;
		}
		this.m_sourceAttackSpell.AddStateFinishedCallback(new Spell.StateFinishedCallback(this.OnHeroSourceAttackStateFinished));
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x001D5DF4 File Offset: 0x001D3FF4
	private void OnHeroSourceAttackStateFinished(Spell spell, SpellStateType prevStateType, object userData)
	{
		if (spell.GetActiveState() != SpellStateType.NONE)
		{
			return;
		}
		spell.RemoveStateFinishedCallback(new Spell.StateFinishedCallback(this.OnHeroSourceAttackStateFinished));
		this.FinishHeroAttack();
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x001D5E18 File Offset: 0x001D4018
	private void FinishHeroAttack()
	{
		Card source = base.GetSource();
		Entity entity = source.GetEntity();
		this.PlayWindfuryReminderIfPossible(entity, source);
		this.FinishEverything();
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x001D5E41 File Offset: 0x001D4041
	private void OnMinionSourceAttackStateFinished(Spell spell, SpellStateType prevStateType, object userData)
	{
		if (spell.GetActiveState() != SpellStateType.NONE)
		{
			return;
		}
		spell.RemoveStateFinishedCallback(new Spell.StateFinishedCallback(this.OnMinionSourceAttackStateFinished));
		this.FinishAttackSpellController();
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x001D5E68 File Offset: 0x001D4068
	private void FinishAttackSpellController()
	{
		Card source = base.GetSource();
		Entity entity = source.GetEntity();
		source.EnableAttacking(false);
		if (!this.CanPlayWindfuryReminder(entity, source))
		{
			this.FinishEverything();
			return;
		}
		this.OnFinishedTaskList();
		base.StartCoroutine(this.WaitThenPlayWindfuryReminder(entity, source));
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x001D5EB0 File Offset: 0x001D40B0
	private void FinishEverything()
	{
		Card source = base.GetSource();
		if (source != null && !source.ShouldShowImmuneVisuals() && (source.GetEntity() == null || !source.GetEntity().HasTag(GAME_TAG.IMMUNE_WHILE_ATTACKING) || this.m_attackType != AttackType.PROPOSED))
		{
			source.GetActor().ActivateSpellDeathState(SpellType.IMMUNE);
		}
		this.OnFinishedTaskList();
		this.OnFinished();
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x001D5F11 File Offset: 0x001D4111
	private IEnumerator WaitThenPlayWindfuryReminder(Entity entity, Card card)
	{
		yield return new WaitForSeconds(1.2f);
		this.PlayWindfuryReminderIfPossible(entity, card);
		this.OnFinished();
		yield break;
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x001D5F30 File Offset: 0x001D4130
	private bool CanPlayWindfuryReminder(Entity entity, Card card)
	{
		return entity.HasWindfury() && !entity.IsExhausted() && entity.GetZone() == TAG_ZONE.PLAY && entity.GetController().IsCurrentPlayer() && !(card.GetActorSpell(SpellType.WINDFURY_BURST, true) == null);
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x001D5F7F File Offset: 0x001D417F
	private void PlayWindfuryReminderIfPossible(Entity entity, Card card)
	{
		if (!this.CanPlayWindfuryReminder(entity, card))
		{
			return;
		}
		card.ActivateActorSpell(SpellType.WINDFURY_BURST);
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x001D5F98 File Offset: 0x001D4198
	private void MoveSourceToTarget(Card sourceCard, Entity sourceEntity, Vector3 impactPos)
	{
		Vector3 b = this.ComputeImpactOffset(sourceCard, impactPos);
		Vector3 vector = impactPos + b;
		float moveToTargetDuration;
		iTween.EaseType moveToTargetEaseType;
		if (sourceEntity.IsHero())
		{
			moveToTargetDuration = this.m_HeroInfo.m_MoveToTargetDuration;
			moveToTargetEaseType = this.m_HeroInfo.m_MoveToTargetEaseType;
		}
		else
		{
			moveToTargetDuration = this.m_AllyInfo.m_MoveToTargetDuration;
			moveToTargetEaseType = this.m_AllyInfo.m_MoveToTargetEaseType;
		}
		Hashtable args = iTween.Hash(new object[]
		{
			"position",
			vector,
			"time",
			moveToTargetDuration,
			"easetype",
			moveToTargetEaseType,
			"oncomplete",
			"OnMoveToTargetFinished",
			"oncompletetarget",
			base.gameObject
		});
		iTween.MoveTo(sourceCard.gameObject, args);
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x001D606C File Offset: 0x001D426C
	private void OrientSourceHeroToTarget(Card sourceCard)
	{
		this.m_sourceFacing = sourceCard.transform.forward;
		Quaternion quaternion;
		if (this.m_sourceAttackSpell.GetSpellType() == SpellType.OPPONENT_ATTACK)
		{
			quaternion = Quaternion.LookRotation(-this.m_sourceToTarget);
		}
		else
		{
			quaternion = Quaternion.LookRotation(this.m_sourceToTarget);
		}
		Hashtable args = iTween.Hash(new object[]
		{
			"rotation",
			quaternion.eulerAngles,
			"time",
			this.m_HeroInfo.m_OrientToTargetDuration,
			"easetype",
			this.m_HeroInfo.m_OrientToTargetEaseType
		});
		iTween.RotateTo(sourceCard.gameObject, args);
	}

	// Token: 0x06005900 RID: 22784 RVA: 0x001D6120 File Offset: 0x001D4320
	private void MoveTargetToSource(Card targetCard, Entity sourceEntity, Vector3 impactPos)
	{
		float moveToTargetDuration;
		iTween.EaseType moveToTargetEaseType;
		if (sourceEntity.IsHero())
		{
			moveToTargetDuration = this.m_HeroInfo.m_MoveToTargetDuration;
			moveToTargetEaseType = this.m_HeroInfo.m_MoveToTargetEaseType;
		}
		else
		{
			moveToTargetDuration = this.m_AllyInfo.m_MoveToTargetDuration;
			moveToTargetEaseType = this.m_AllyInfo.m_MoveToTargetEaseType;
		}
		Hashtable args = iTween.Hash(new object[]
		{
			"position",
			impactPos,
			"time",
			moveToTargetDuration,
			"easetype",
			moveToTargetEaseType
		});
		iTween.MoveTo(targetCard.gameObject, args);
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x001D61BC File Offset: 0x001D43BC
	private Vector3 ComputeImpactPos()
	{
		float num = 1f;
		if (this.m_attackType == AttackType.PROPOSED)
		{
			num = 0.5f;
		}
		Vector3 b = num * this.m_ImpactStagingPoint * this.m_sourceToTarget;
		return this.m_sourcePos + b;
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x001D6200 File Offset: 0x001D4400
	private Vector3 ComputeImpactOffset(Card sourceCard, Vector3 impactPos)
	{
		if (Mathf.Approximately(this.m_SourceImpactOffset, 0.5f))
		{
			return Vector3.zero;
		}
		Bounds bounds = sourceCard.GetActor().GetMeshRenderer().bounds;
		bounds.center = this.m_sourcePos;
		Ray ray = new Ray(impactPos, bounds.center - impactPos);
		float d;
		if (!bounds.IntersectRay(ray, out d))
		{
			return Vector3.zero;
		}
		Vector3 b = ray.origin + d * ray.direction;
		Vector3 a = 2f * bounds.center - b - b;
		return 0.5f * a - this.m_SourceImpactOffset * a;
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x001D62C4 File Offset: 0x001D44C4
	private void ActivateImpactEffects(Card sourceCard, Card targetCard)
	{
		Spell spell = this.DetermineImpactSpellPrefab(sourceCard);
		if (spell == null)
		{
			return;
		}
		Spell spell2 = UnityEngine.Object.Instantiate<Spell>(spell);
		spell2.SetSource(sourceCard.gameObject);
		spell2.AddTarget(targetCard.gameObject);
		Vector3 position = targetCard.transform.position;
		spell2.SetPosition(position);
		Quaternion orientation = Quaternion.LookRotation(this.m_sourceToTarget);
		spell2.SetOrientation(orientation);
		spell2.AddStateFinishedCallback(new Spell.StateFinishedCallback(this.OnImpactSpellStateFinished));
		spell2.Activate();
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x001D6340 File Offset: 0x001D4540
	private Spell DetermineImpactSpellPrefab(Card sourceCard)
	{
		int atk = sourceCard.GetEntity().GetATK();
		SpellValueRange appropriateElementAccordingToRanges = SpellUtils.GetAppropriateElementAccordingToRanges<SpellValueRange>(this.m_ImpactDefs, (SpellValueRange x) => x.m_range, atk);
		if (appropriateElementAccordingToRanges != null && appropriateElementAccordingToRanges.m_spellPrefab != null)
		{
			return appropriateElementAccordingToRanges.m_spellPrefab;
		}
		return this.m_DefaultImpactSpellPrefab;
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x001D63A3 File Offset: 0x001D45A3
	private void OnImpactSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
	{
		if (spell.GetActiveState() != SpellStateType.NONE)
		{
			return;
		}
		UnityEngine.Object.Destroy(spell.gameObject);
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x001D63BC File Offset: 0x001D45BC
	protected override float GetLostFrameTimeCatchUpSeconds()
	{
		Card source = base.GetSource();
		if (source != null && source.GetEntity() != null && source.GetEntity().IsHero())
		{
			return 0f;
		}
		Card target = base.GetTarget();
		if (target != null && target.GetEntity() != null && target.GetEntity().IsHero())
		{
			return 0f;
		}
		return 0.8f;
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x001D6424 File Offset: 0x001D4624
	protected override void OnFinishedTaskList()
	{
		if (this.m_attackType != AttackType.PROPOSED)
		{
			Card source = base.GetSource();
			source.SetDoNotSort(false);
			if (!source.GetEntity().IsHero())
			{
				Zone zone = source.GetZone();
				zone.UpdateLayout();
				if (this.m_sourceAttackSpell == null)
				{
					bool isSourceFriendly = zone.m_Side == Player.Side.FRIENDLY;
					this.m_sourceAttackSpell = this.GetSourceAttackSpell(source, isSourceFriendly);
				}
				if (this.m_sourceAttackSpell != null && (this.m_sourceAttackSpell.GetActiveState() == SpellStateType.BIRTH || this.m_sourceAttackSpell.GetActiveState() == SpellStateType.IDLE || this.m_sourceAttackSpell.GetActiveState() == SpellStateType.ACTION))
				{
					this.CancelAttackSpell(source.GetEntity(), this.m_sourceAttackSpell);
				}
			}
		}
		base.OnFinishedTaskList();
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x001D64DD File Offset: 0x001D46DD
	private void CancelAttackSpell(Entity sourceEntity, Spell attackSpell)
	{
		if (attackSpell == null)
		{
			return;
		}
		if (sourceEntity == null)
		{
			attackSpell.ActivateState(SpellStateType.DEATH);
			return;
		}
		if (sourceEntity.IsHero())
		{
			attackSpell.ActivateState(SpellStateType.CANCEL);
			return;
		}
		attackSpell.ActivateState(SpellStateType.DEATH);
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x001D650C File Offset: 0x001D470C
	private Spell GetSourceAttackSpell(Card sourceCard, bool isSourceFriendly)
	{
		if (GameState.Get().GetGameEntity().HasTag(GAME_TAG.BACON_HIGHLIGHT_ATTACKING_MINION_DURING_COMBAT))
		{
			Spell actorSpell = sourceCard.GetActorSpell(SpellType.AUTO_ATTACK_WITH_HIGHLIGHT, true);
			if (actorSpell != null)
			{
				return actorSpell;
			}
			return null;
		}
		else
		{
			if (isSourceFriendly)
			{
				return sourceCard.GetActorSpell(SpellType.FRIENDLY_ATTACK, true);
			}
			return sourceCard.GetActorSpell(SpellType.OPPONENT_ATTACK, true);
		}
	}
*/
	// Token: 0x04004632 RID: 17970
	public HeroAttackDef m_HeroInfo;

	// Token: 0x04004633 RID: 17971
	public AllyAttackDef m_AllyInfo;

	// Token: 0x04004634 RID: 17972
	public float m_ImpactStagingPoint = 1f;

	// Token: 0x04004635 RID: 17973
	public float m_SourceImpactOffset = -0.25f;

	// Token: 0x04004636 RID: 17974
	public SpellValueRange[] m_ImpactDefs;

	// Token: 0x04004637 RID: 17975
	public Spell m_DefaultImpactSpellPrefab;

	// Token: 0x04004638 RID: 17976
	private const float PROPOSED_ATTACK_IMPACT_POINT_SCALAR = 0.5f;

	// Token: 0x04004639 RID: 17977
	private const float WINDFURY_REMINDER_WAIT_SEC = 1.2f;

	// Token: 0x0400463A RID: 17978
	//private AttackType m_attackType;

	// Token: 0x0400463B RID: 17979
	private Spell m_sourceAttackSpell;

	// Token: 0x0400463C RID: 17980
	private Vector3 m_sourcePos;

	// Token: 0x0400463D RID: 17981
	private Vector3 m_sourceToTarget;

	// Token: 0x0400463E RID: 17982
	private Vector3 m_sourceFacing;
}
