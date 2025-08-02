using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000B54 RID: 2900
public class LegendaryHeroAnimController : MonoBehaviour
{
	// Token: 0x14000052 RID: 82
	// (add) Token: 0x060059F8 RID: 23032 RVA: 0x001B2D80 File Offset: 0x001B0F80
	// (remove) Token: 0x060059F9 RID: 23033 RVA: 0x001B2DB8 File Offset: 0x001B0FB8
	public event LegendaryHeroAnimController.RequestedAnimTransitionCallback OnRequestAnimTransition;

	// Token: 0x060059FA RID: 23034 RVA: 0x001B2DF0 File Offset: 0x001B0FF0
	private void Awake()
	{
		this.m_masterAnimator = base.gameObject.GetComponentInChildren<Animator>();
		LegendaryHeroAnimController.AnimatorEntry masterAnimator = new LegendaryHeroAnimController.AnimatorEntry(this.m_masterAnimator, 1f);
		this.m_animators.Add(masterAnimator);
		this.m_requestedState = LegendaryHeroAnimController.InternalState.Unknown;
		if (this.HasIdleFidgetAnimation)
		{
			this.SetupIdleFidget();
		}
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x001B2E44 File Offset: 0x001B1044
	private void SetupIdleFidget()
	{
		this.m_masterAnimator.gameObject.AddComponent<LegendaryHeroAnimController.AnimationEventHandler>().SetController(this);
		AnimatorOverrideController animatorOverrideController = this.m_masterAnimator.runtimeAnimatorController as AnimatorOverrideController;
		List<KeyValuePair<AnimationClip, AnimationClip>> overrides = new List<KeyValuePair<AnimationClip, AnimationClip>>();
		animatorOverrideController.GetOverrides(overrides);
		KeyValuePair<AnimationClip, AnimationClip> anim = overrides.Find((KeyValuePair<AnimationClip, AnimationClip> x) => x.Key.name == "Idle");
		if (anim.Value == null)
		{
			this.HasIdleFidgetAnimation = false;
		}
		AnimationEvent animEvent = new AnimationEvent();
		animEvent.functionName = "RaiseAnimEvent";
		animEvent.intParameter = 2;
		animEvent.time = 0f;
		anim.Value.AddEvent(animEvent);
		this.SetIdleFidgetCountdown();
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x001B2EF5 File Offset: 0x001B10F5
	//public void OnAttachedToActor(Actor actor)
	//{
	//	this.m_card = actor.GetComponentInParent<Card>();
	//	if (base.enabled)
	//	{
	//		this.OnEnable();
	//	}
	//}

	// Token: 0x060059FD RID: 23037 RVA: 0x001B2F11 File Offset: 0x001B1111
	private void OnEnable()
	{
		if (this.m_card != null)
		{
			//this.m_card.OnEmotePlayCallback += this.EmotePlayCallback;
		}
		this.DamageCountdown = 0f;
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x001B2F43 File Offset: 0x001B1143
	private void OnDisable()
	{
		if (this.m_card != null)
		{
			//this.m_card.OnEmotePlayCallback -= this.EmotePlayCallback;
		}
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x001B2F6C File Offset: 0x001B116C
	private void Update()
	{
		this.UpdateCountdownTimers();
		this.CheckAndTriggerTransitionListenersForIdle();
		if (!this.StateSupported(this.m_requestedState))
		{
			this.m_requestedState = LegendaryHeroAnimController.InternalState.Unknown;
		}
		bool resetStateTime = this.UpdateCountdownResets();
		this.UpdateIdleFidget();
		this.CheckForSummonInterruption();
		this.UpdateIgnoreAnimRequests();
		this.CrossFadeToRequestedState(resetStateTime);
	}

	// Token: 0x06005A00 RID: 23040 RVA: 0x001B2FBA File Offset: 0x001B11BA
	private void UpdateCountdownTimers()
	{
		this.UpdateTimer(ref this.AttackCountdown);
		this.UpdateTimer(ref this.HeroPowerCountdown);
		if (this.UpdateTimer(ref this.DamageCountdown))
		{
			this.m_requestedState = LegendaryHeroAnimController.InternalState.DamageComplete;
		}
	}

	// Token: 0x06005A01 RID: 23041 RVA: 0x001B2FEC File Offset: 0x001B11EC
	private bool UpdateCountdownResets()
	{
		if (this.m_requestedState == LegendaryHeroAnimController.InternalState.AttackComplete)
		{
			this.AttackCountdown = this.AttackDelay;
		}
		else if (this.m_requestedState == LegendaryHeroAnimController.InternalState.HeroPowerComplete)
		{
			this.HeroPowerCountdown = this.HeroPowerDelay;
		}
		return this.UpdateDamageCountdownReset();
	}

	// Token: 0x06005A02 RID: 23042 RVA: 0x001B3024 File Offset: 0x001B1224
	private void UpdateIdleFidget()
	{
		if (!this.HasIdleFidgetAnimation)
		{
			return;
		}
		if (this.m_requestedState == LegendaryHeroAnimController.InternalState.IdleFidget)
		{
			if (this.IdleFidgetCountdown > 0f)
			{
				this.m_requestedState = LegendaryHeroAnimController.InternalState.Unknown;
				return;
			}
			this.SetIdleFidgetCountdown();
			return;
		}
		else
		{
			if (this.m_requestedState == LegendaryHeroAnimController.InternalState.Idle)
			{
				this.SetIdleFidgetCountdown();
				return;
			}
			if (this.m_requestedState == LegendaryHeroAnimController.InternalState.Unknown && this.m_masterAnimator.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Idle"))
			{
				this.UpdateTimer(ref this.IdleFidgetCountdown);
			}
			return;
		}
	}

	// Token: 0x06005A03 RID: 23043 RVA: 0x001B309F File Offset: 0x001B129F
	private bool UpdateDamageCountdownReset()
	{
		if (this.m_requestedState != LegendaryHeroAnimController.InternalState.DamageStart)
		{
			return false;
		}
		if (this.DamageTimer == 0f)
		{
			this.m_requestedState = LegendaryHeroAnimController.InternalState.DamageComplete;
			return false;
		}
		this.DamageCountdown = this.DamageTimer;
		return true;
	}

	// Token: 0x06005A04 RID: 23044 RVA: 0x001B30D4 File Offset: 0x001B12D4
	private void CheckForSummonInterruption()
	{
		if (this.AllowSummonInterruption)
		{
			return;
		}
		if (this.m_requestedState != LegendaryHeroAnimController.InternalState.SummonMinion)
		{
			return;
		}
		string summonStateName = "Base Layer.Summon";
		if (!this.m_masterAnimator.GetCurrentAnimatorStateInfo(0).IsName(summonStateName) && !this.m_masterAnimator.GetNextAnimatorStateInfo(0).IsName(summonStateName))
		{
			return;
		}
		this.m_requestedState = LegendaryHeroAnimController.InternalState.Unknown;
	}

	// Token: 0x06005A05 RID: 23045 RVA: 0x001B3134 File Offset: 0x001B1334
	private void CrossFadeToRequestedState(bool resetStateTime)
	{
		if (this.m_requestedState == LegendaryHeroAnimController.InternalState.Unknown)
		{
			return;
		}
		int stateNameHash;
		if (LegendaryHeroAnimController.s_animatorStates.TryGetValue(this.m_requestedState, out stateNameHash))
		{
			foreach (LegendaryHeroAnimController.AnimatorEntry animatorEntry in this.m_animators)
			{
				float transitionTime = this.m_transitionTimes[(int)this.m_requestedState] * animatorEntry.m_transitionMultiplier;
				if (resetStateTime)
				{
					animatorEntry.m_animator.CrossFadeInFixedTime(stateNameHash, transitionTime, -1, 0f);
				}
				else
				{
					animatorEntry.m_animator.CrossFadeInFixedTime(stateNameHash, transitionTime * animatorEntry.m_transitionMultiplier);
				}
			}
			LegendaryHeroAnimController.RequestedAnimTransitionCallback onRequestAnimTransition = this.OnRequestAnimTransition;
			if (onRequestAnimTransition != null)
			{
				onRequestAnimTransition(this.m_requestedState);
			}
			this.m_lastRequestedState = this.m_requestedState;
		}
		this.m_requestedState = LegendaryHeroAnimController.InternalState.Unknown;
	}

	// Token: 0x06005A06 RID: 23046 RVA: 0x001B320C File Offset: 0x001B140C
	private void SetIdleFidgetCountdown()
	{
		this.IdleFidgetCountdown = UnityEngine.Random.Range(this.MinIdleFidgetTime, this.MaxIdleFidgetTime);
	}

	// Token: 0x06005A07 RID: 23047 RVA: 0x001B3225 File Offset: 0x001B1425
	private bool UpdateTimer(ref float timer)
	{
		if (timer > 0f)
		{
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005A08 RID: 23048 RVA: 0x001B3248 File Offset: 0x001B1448
	public void EmotePlayCallback(EmoteType emoteType)
	{
		LegendaryHeroAnimController.InternalState newState;
		if (this.TryGetStateFromEvent(emoteType, out newState))
		{
			this.m_requestedState = newState;
		}
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x001B3268 File Offset: 0x001B1468
	public void RaiseAnimEvent(LegendaryHeroAnimations animation)
	{
		if (this.m_ignoreAnimRequests.ContainsKey(animation))
		{
			Debug.Log("Ignoring animation " + animation.ToString() + " as ignore request was specified");
			return;
		}
		LegendaryHeroAnimController.InternalState newState;
		if (this.TryGetStateFromEvent(animation, out newState))
		{
			this.m_requestedState = newState;
		}
	}

	// Token: 0x06005A0A RID: 23050 RVA: 0x001B32B7 File Offset: 0x001B14B7
	public void RaiseAnimEvent(LegendaryHeroAnimController.InternalState newState)
	{
		if (newState == LegendaryHeroAnimController.InternalState.IdleFidget && this.m_requestedState != LegendaryHeroAnimController.InternalState.Unknown)
		{
			return;
		}
		this.m_requestedState = newState;
	}

	// Token: 0x06005A0B RID: 23051 RVA: 0x001B32D0 File Offset: 0x001B14D0
	public void AddSlaveAnimator(Animator animator, float transitionMultiplier)
	{
		if (this.m_animators.Find((LegendaryHeroAnimController.AnimatorEntry x) => x.m_animator == animator).m_animator == animator)
		{
			return;
		}
		this.m_animators.Add(new LegendaryHeroAnimController.AnimatorEntry(animator, transitionMultiplier));
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x001B332C File Offset: 0x001B152C
	public void RemoveSlaveAnimator(Animator animator)
	{
		this.m_animators.RemoveAll((LegendaryHeroAnimController.AnimatorEntry x) => x.m_animator == animator);
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x001B3360 File Offset: 0x001B1560
	internal bool TryGetStateFromEvent(LegendaryHeroAnimations animation, out LegendaryHeroAnimController.InternalState state)
	{
		switch (animation)
		{
		case LegendaryHeroAnimations.Emote_Thanks:
			state = LegendaryHeroAnimController.InternalState.Emote_Thanks;
			return true;
		case LegendaryHeroAnimations.Emote_WellPlayed:
			state = LegendaryHeroAnimController.InternalState.Emote_WellPlayed;
			return true;
		case LegendaryHeroAnimations.Emote_Greetings:
			state = LegendaryHeroAnimController.InternalState.Emote_Greetings;
			return true;
		case LegendaryHeroAnimations.Emote_Wow:
			state = LegendaryHeroAnimController.InternalState.Emote_Wow;
			return true;
		case LegendaryHeroAnimations.Emote_Oops:
			state = LegendaryHeroAnimController.InternalState.Emote_Oops;
			return true;
		case LegendaryHeroAnimations.Emote_Threaten:
			state = LegendaryHeroAnimController.InternalState.Emote_Threaten;
			return true;
		case LegendaryHeroAnimations.FriendlyAnnounceVO:
			state = LegendaryHeroAnimController.InternalState.IntroStart;
			return true;
		case LegendaryHeroAnimations.OpponentAnnounceVO:
			state = LegendaryHeroAnimController.InternalState.IntroStart;
			return true;
		case LegendaryHeroAnimations.Defeat:
			state = LegendaryHeroAnimController.InternalState.Defeat;
			return true;
		case LegendaryHeroAnimations.Victory:
			state = LegendaryHeroAnimController.InternalState.Victory;
			return true;
		case LegendaryHeroAnimations.SummonMinion:
			state = LegendaryHeroAnimController.InternalState.SummonMinion;
			return true;
		case LegendaryHeroAnimations.Damage:
			state = LegendaryHeroAnimController.InternalState.DamageStart;
			return true;
		case LegendaryHeroAnimations.SpellCard:
			state = LegendaryHeroAnimController.InternalState.Spell;
			return true;
		case LegendaryHeroAnimations.HeroPower:
			state = LegendaryHeroAnimController.InternalState.HeroPowerComplete;
			return true;
		case LegendaryHeroAnimations.WeaponCardPlayed:
			state = LegendaryHeroAnimController.InternalState.EquipWeapon;
			return true;
		case LegendaryHeroAnimations.IntroSequenceBegin:
			state = LegendaryHeroAnimController.InternalState.IntroStart;
			return true;
		case LegendaryHeroAnimations.IntroSequenceEnd:
			state = LegendaryHeroAnimController.InternalState.IntroComplete;
			return true;
		case LegendaryHeroAnimations.Attack:
			state = LegendaryHeroAnimController.InternalState.AttackComplete;
			return true;
		case LegendaryHeroAnimations.AttackBirth:
			state = LegendaryHeroAnimController.InternalState.AttackStart;
			return true;
		case LegendaryHeroAnimations.AttackCancel:
			state = LegendaryHeroAnimController.InternalState.Idle;
			return true;
		case LegendaryHeroAnimations.HeroPowerBirth:
			state = LegendaryHeroAnimController.InternalState.HeroPowerStart;
			return true;
		case LegendaryHeroAnimations.HeroPowerCancel:
			state = LegendaryHeroAnimController.InternalState.Idle;
			return true;
		case LegendaryHeroAnimations.HeroPowerAlt:
			state = LegendaryHeroAnimController.InternalState.HeroPowerCompleteAlt;
			return true;
		case LegendaryHeroAnimations.SocketInTriggered:
			state = LegendaryHeroAnimController.InternalState.SocketIn;
			return true;
		case LegendaryHeroAnimations.VictoryStrike:
			state = LegendaryHeroAnimController.InternalState.VictoryStrike;
			return true;
		case LegendaryHeroAnimations.DefeatStrike:
			state = LegendaryHeroAnimController.InternalState.DefeatStrike;
			return true;
		}
		state = LegendaryHeroAnimController.InternalState.Idle;
		return false;
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x001B3488 File Offset: 0x001B1688
	private bool TryGetStateFromEvent(EmoteType emote, out LegendaryHeroAnimController.InternalState state)
	{
		switch (emote)
		{
		case EmoteType.GREETINGS:
			state = LegendaryHeroAnimController.InternalState.Emote_Greetings;
			return true;
		case EmoteType.WELL_PLAYED:
			state = LegendaryHeroAnimController.InternalState.Emote_WellPlayed;
			return true;
		case EmoteType.OOPS:
			state = LegendaryHeroAnimController.InternalState.Emote_Oops;
			return true;
		case EmoteType.THREATEN:
			state = LegendaryHeroAnimController.InternalState.Emote_Threaten;
			return true;
		case EmoteType.THANKS:
			state = LegendaryHeroAnimController.InternalState.Emote_Thanks;
			return true;
		default:
			if (emote == EmoteType.WOW)
			{
				state = LegendaryHeroAnimController.InternalState.Emote_Wow;
				return true;
			}
			if (emote != EmoteType.MIRROR_GREETINGS)
			{
				state = LegendaryHeroAnimController.InternalState.Idle;
				return false;
			}
			state = LegendaryHeroAnimController.InternalState.Emote_Greetings;
			return true;
		}
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x001B34E4 File Offset: 0x001B16E4
	public bool StateSupported(LegendaryHeroAnimController.InternalState state)
	{
		if (this.AttackCountdown > 0f || this.HeroPowerCountdown > 0f)
		{
			return false;
		}
		if (this.DamageCountdown > 0f && state != LegendaryHeroAnimController.InternalState.DamageStart)
		{
			return false;
		}
		switch (state)
		{
		case LegendaryHeroAnimController.InternalState.Idle:
		case LegendaryHeroAnimController.InternalState.SocketIn:
			return true;
		case LegendaryHeroAnimController.InternalState.IdleFidget:
			return this.HasIdleFidgetAnimation;
		case LegendaryHeroAnimController.InternalState.Emote_Greetings:
		case LegendaryHeroAnimController.InternalState.Emote_Oops:
		case LegendaryHeroAnimController.InternalState.Emote_Thanks:
		case LegendaryHeroAnimController.InternalState.Emote_Threaten:
		case LegendaryHeroAnimController.InternalState.Emote_WellPlayed:
		case LegendaryHeroAnimController.InternalState.Emote_Wow:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Emotes);
		case LegendaryHeroAnimController.InternalState.EquipWeapon:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.EquipWeapon);
		case LegendaryHeroAnimController.InternalState.Spell:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Spell);
		case LegendaryHeroAnimController.InternalState.SummonMinion:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Summon);
		case LegendaryHeroAnimController.InternalState.Victory:
		case LegendaryHeroAnimController.InternalState.Defeat:
			return true;
		case LegendaryHeroAnimController.InternalState.AttackStart:
			return this.HasPreAttackAnimation && this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Attack);
		case LegendaryHeroAnimController.InternalState.AttackComplete:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Attack);
		case LegendaryHeroAnimController.InternalState.DamageStart:
		case LegendaryHeroAnimController.InternalState.DamageComplete:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Damage);
		case LegendaryHeroAnimController.InternalState.IntroStart:
			return this.voStartsComeIntoPlay && this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.IntoPlay);
		case LegendaryHeroAnimController.InternalState.IntroComplete:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.IntoPlayExit);
		case LegendaryHeroAnimController.InternalState.HeroPowerStart:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.HeroPowerBirth);
		case LegendaryHeroAnimController.InternalState.HeroPowerComplete:
		case LegendaryHeroAnimController.InternalState.HeroPowerCompleteAlt:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.HeroPower);
		case LegendaryHeroAnimController.InternalState.VictoryStrike:
		case LegendaryHeroAnimController.InternalState.DefeatStrike:
			return this.Features.HasFlag(LegendaryHeroAnimController.SupportedFeatures.Strikes);
		default:
			return false;
		}
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x001B36DC File Offset: 0x001B18DC
	public void UpdateIgnoreAnimRequests()
	{
		List<LegendaryHeroAnimations> requestsToRemove = new List<LegendaryHeroAnimations>();
		float deltaTime = Time.deltaTime;
		foreach (KeyValuePair<LegendaryHeroAnimations, float> request in this.m_ignoreAnimRequests.ToList<KeyValuePair<LegendaryHeroAnimations, float>>())
		{
			float value = request.Value;
			value -= Time.deltaTime;
			if (value - deltaTime <= 0f)
			{
				requestsToRemove.Add(request.Key);
			}
			else
			{
				this.m_ignoreAnimRequests[request.Key] = value;
			}
		}
		foreach (LegendaryHeroAnimations request2 in requestsToRemove)
		{
			this.m_ignoreAnimRequests.Remove(request2);
		}
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x001B37C0 File Offset: 0x001B19C0
	public void IgnoreAnim(LegendaryHeroAnimations anim, float time)
	{
		Debug.Log("Adding ignore anim request for " + anim.ToString());
		this.m_ignoreAnimRequests[anim] = time;
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x001B37EC File Offset: 0x001B19EC
	public float GetTransitionTime(LegendaryHeroAnimController.InternalState state)
	{
		if (state >= (LegendaryHeroAnimController.InternalState)this.m_transitionTimes.Length)
		{
			Array transitionTimes = this.m_transitionTimes;
			this.m_transitionTimes = Enumerable.Repeat<float>(0.25f, Enum.GetValues(typeof(LegendaryHeroAnimController.InternalState)).Length).ToArray<float>();
			transitionTimes.CopyTo(this.m_transitionTimes, 0);
		}
		return this.m_transitionTimes[(int)state];
	}

	// Token: 0x06005A13 RID: 23059 RVA: 0x001B3848 File Offset: 0x001B1A48
	public void SetTransitionTime(LegendaryHeroAnimController.InternalState state, float transitionTime)
	{
		if (state >= (LegendaryHeroAnimController.InternalState)this.m_transitionTimes.Length)
		{
			Array transitionTimes = this.m_transitionTimes;
			this.m_transitionTimes = Enumerable.Repeat<float>(0.25f, Enum.GetValues(typeof(LegendaryHeroAnimController.InternalState)).Length).ToArray<float>();
			transitionTimes.CopyTo(this.m_transitionTimes, 0);
		}
		this.m_transitionTimes[(int)state] = transitionTime;
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x001B38A4 File Offset: 0x001B1AA4
	public float GetCurrentAnimTime()
	{
		if (this.m_lastRequestedState == LegendaryHeroAnimController.InternalState.Unknown)
		{
			return 0f;
		}
		AnimatorStateInfo stateInfo = this.m_masterAnimator.GetCurrentAnimatorStateInfo(0);
		if (stateInfo.fullPathHash != LegendaryHeroAnimController.s_animatorStates[this.m_lastRequestedState])
		{
			stateInfo = this.m_masterAnimator.GetNextAnimatorStateInfo(0);
			if (stateInfo.fullPathHash != LegendaryHeroAnimController.s_animatorStates[this.m_lastRequestedState])
			{
				return 0f;
			}
		}
		float normalizedTime = stateInfo.normalizedTime;
		if (stateInfo.loop)
		{
			normalizedTime -= (float)((int)normalizedTime);
		}
		return normalizedTime * stateInfo.length;
	}

	// Token: 0x06005A15 RID: 23061 RVA: 0x001B3934 File Offset: 0x001B1B34
	public void CheckAndTriggerTransitionListenersForIdle()
	{
		if (this.m_masterAnimator.IsInTransition(0))
		{
			return;
		}
		if (this.m_masterAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash == LegendaryHeroAnimController.s_animatorStates[LegendaryHeroAnimController.InternalState.Idle] && this.m_lastRequestedState != LegendaryHeroAnimController.InternalState.Idle)
		{
			this.m_lastRequestedState = LegendaryHeroAnimController.InternalState.Idle;
			LegendaryHeroAnimController.RequestedAnimTransitionCallback onRequestAnimTransition = this.OnRequestAnimTransition;
			if (onRequestAnimTransition == null)
			{
				return;
			}
			onRequestAnimTransition(LegendaryHeroAnimController.InternalState.Idle);
		}
	}

	// Token: 0x04003ECD RID: 16077
	[Header("Supported Features")]
	public LegendaryHeroAnimController.SupportedFeatures Features = (LegendaryHeroAnimController.SupportedFeatures)(-1);

	// Token: 0x04003ECE RID: 16078
	public bool voStartsComeIntoPlay;

	// Token: 0x04003ECF RID: 16079
	public bool HasPreAttackAnimation;

	// Token: 0x04003ED0 RID: 16080
	public bool HasIdleFidgetAnimation;

	// Token: 0x04003ED1 RID: 16081
	[Min(0f)]
	[Header("Timers")]
	public float DamageTimer = 2.3f;

	// Token: 0x04003ED2 RID: 16082
	[Min(0f)]
	public float AttackDelay = 1f;

	// Token: 0x04003ED3 RID: 16083
	[Min(0f)]
	public float HeroPowerDelay = 2.5f;

	// Token: 0x04003ED4 RID: 16084
	[Min(0f)]
	public float MinIdleFidgetTime = 5f;

	// Token: 0x04003ED5 RID: 16085
	[Min(0f)]
	public float MaxIdleFidgetTime = 10f;

	// Token: 0x04003ED6 RID: 16086
	public bool AllowSummonInterruption = true;

	// Token: 0x04003ED7 RID: 16087
	[SerializeField]
	[HideInInspector]
	private float[] m_transitionTimes = Enumerable.Repeat<float>(0.25f, Enum.GetValues(typeof(LegendaryHeroAnimController.InternalState)).Length).ToArray<float>();

	// Token: 0x04003ED8 RID: 16088
	private Animator m_masterAnimator;

	// Token: 0x04003ED9 RID: 16089
	private List<LegendaryHeroAnimController.AnimatorEntry> m_animators = new List<LegendaryHeroAnimController.AnimatorEntry>();

	// Token: 0x04003EDA RID: 16090
	private Card m_card;

	// Token: 0x04003EDB RID: 16091
	[NonSerialized]
	public float DamageCountdown;

	// Token: 0x04003EDC RID: 16092
	[NonSerialized]
	public float AttackCountdown;

	// Token: 0x04003EDD RID: 16093
	[NonSerialized]
	public float HeroPowerCountdown;

	// Token: 0x04003EDE RID: 16094
	private float IdleFidgetCountdown;

	// Token: 0x04003EDF RID: 16095
	private Dictionary<LegendaryHeroAnimations, float> m_ignoreAnimRequests = new Dictionary<LegendaryHeroAnimations, float>();

	// Token: 0x04003EE0 RID: 16096
	private LegendaryHeroAnimController.InternalState m_requestedState;

	// Token: 0x04003EE1 RID: 16097
	private LegendaryHeroAnimController.InternalState m_lastRequestedState = LegendaryHeroAnimController.InternalState.Idle;

	// Token: 0x04003EE3 RID: 16099
	private static readonly Dictionary<LegendaryHeroAnimController.InternalState, int> s_animatorStates = new Dictionary<LegendaryHeroAnimController.InternalState, int>
	{
		{
			LegendaryHeroAnimController.InternalState.Idle,
			Animator.StringToHash("Base Layer.Idle")
		},
		{
			LegendaryHeroAnimController.InternalState.IdleFidget,
			Animator.StringToHash("Base Layer.Idle Fidget")
		},
		{
			LegendaryHeroAnimController.InternalState.AttackComplete,
			Animator.StringToHash("Base Layer.Attack")
		},
		{
			LegendaryHeroAnimController.InternalState.IntroComplete,
			Animator.StringToHash("Base Layer.Intro Sequence")
		},
		{
			LegendaryHeroAnimController.InternalState.DamageComplete,
			Animator.StringToHash("Base Layer.Damage")
		},
		{
			LegendaryHeroAnimController.InternalState.HeroPowerComplete,
			Animator.StringToHash("Base Layer.Hero Power")
		},
		{
			LegendaryHeroAnimController.InternalState.HeroPowerCompleteAlt,
			Animator.StringToHash("Base Layer.Hero Power Alt")
		},
		{
			LegendaryHeroAnimController.InternalState.Spell,
			Animator.StringToHash("Base Layer.Spell")
		},
		{
			LegendaryHeroAnimController.InternalState.HeroPowerStart,
			Animator.StringToHash("Base Layer.Hero Power Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.SummonMinion,
			Animator.StringToHash("Base Layer.Summon")
		},
		{
			LegendaryHeroAnimController.InternalState.EquipWeapon,
			Animator.StringToHash("Base Layer.Equip Weapon")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_Thanks,
			Animator.StringToHash("Base Layer.Emote Thanks")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_WellPlayed,
			Animator.StringToHash("Base Layer.Emote Well Played")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_Greetings,
			Animator.StringToHash("Base Layer.Emote Greetings")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_Wow,
			Animator.StringToHash("Base Layer.Emote Wow")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_Oops,
			Animator.StringToHash("Base Layer.Emote Oops")
		},
		{
			LegendaryHeroAnimController.InternalState.Emote_Threaten,
			Animator.StringToHash("Base Layer.Emote Threaten")
		},
		{
			LegendaryHeroAnimController.InternalState.AttackStart,
			Animator.StringToHash("Base Layer.Attack Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.IntroStart,
			Animator.StringToHash("Base Layer.Intro Sequence Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.DamageStart,
			Animator.StringToHash("Base Layer.Damage Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.Victory,
			Animator.StringToHash("Base Layer.Victory Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.Defeat,
			Animator.StringToHash("Base Layer.Defeat Intro")
		},
		{
			LegendaryHeroAnimController.InternalState.SocketIn,
			Animator.StringToHash("Base Layer.Socket In")
		},
		{
			LegendaryHeroAnimController.InternalState.VictoryStrike,
			Animator.StringToHash("Base Layer.Victory Strike")
		},
		{
			LegendaryHeroAnimController.InternalState.DefeatStrike,
			Animator.StringToHash("Base Layer.Defeat Strike")
		}
	};

	// Token: 0x02000B55 RID: 2901
	[Serializable]
	private struct AnimatorEntry
	{
		// Token: 0x06005A18 RID: 23064 RVA: 0x001B3C05 File Offset: 0x001B1E05
		public AnimatorEntry(Animator animator, float transitionMultiplier)
		{
			this.m_animator = animator;
			this.m_transitionMultiplier = transitionMultiplier;
		}

		// Token: 0x04003EE4 RID: 16100
		public Animator m_animator;

		// Token: 0x04003EE5 RID: 16101
		public float m_transitionMultiplier;
	}

	// Token: 0x02000B56 RID: 2902
	[Flags]
	public enum SupportedFeatures
	{
		// Token: 0x04003EE7 RID: 16103
		Attack = 1,
		// Token: 0x04003EE8 RID: 16104
		Damage = 2,
		// Token: 0x04003EE9 RID: 16105
		Emotes = 4,
		// Token: 0x04003EEA RID: 16106
		IntoPlay = 8,
		// Token: 0x04003EEB RID: 16107
		Spell = 16,
		// Token: 0x04003EEC RID: 16108
		Summon = 32,
		// Token: 0x04003EED RID: 16109
		EquipWeapon = 64,
		// Token: 0x04003EEE RID: 16110
		HeroPower = 128,
		// Token: 0x04003EEF RID: 16111
		HeroPowerBirth = 256,
		// Token: 0x04003EF0 RID: 16112
		IntoPlayExit = 512,
		// Token: 0x04003EF1 RID: 16113
		Strikes = 1024
	}

	// Token: 0x02000B57 RID: 2903
	public enum InternalState
	{
		// Token: 0x04003EF3 RID: 16115
		Unknown,
		// Token: 0x04003EF4 RID: 16116
		Idle,
		// Token: 0x04003EF5 RID: 16117
		IdleFidget,
		// Token: 0x04003EF6 RID: 16118
		Emote_Greetings,
		// Token: 0x04003EF7 RID: 16119
		Emote_Oops,
		// Token: 0x04003EF8 RID: 16120
		Emote_Thanks,
		// Token: 0x04003EF9 RID: 16121
		Emote_Threaten,
		// Token: 0x04003EFA RID: 16122
		Emote_WellPlayed,
		// Token: 0x04003EFB RID: 16123
		Emote_Wow,
		// Token: 0x04003EFC RID: 16124
		EquipWeapon,
		// Token: 0x04003EFD RID: 16125
		Spell,
		// Token: 0x04003EFE RID: 16126
		SummonMinion,
		// Token: 0x04003EFF RID: 16127
		Victory,
		// Token: 0x04003F00 RID: 16128
		Defeat,
		// Token: 0x04003F01 RID: 16129
		AttackStart,
		// Token: 0x04003F02 RID: 16130
		AttackComplete,
		// Token: 0x04003F03 RID: 16131
		DamageStart,
		// Token: 0x04003F04 RID: 16132
		DamageComplete,
		// Token: 0x04003F05 RID: 16133
		IntroStart,
		// Token: 0x04003F06 RID: 16134
		IntroComplete,
		// Token: 0x04003F07 RID: 16135
		HeroPowerStart,
		// Token: 0x04003F08 RID: 16136
		HeroPowerComplete,
		// Token: 0x04003F09 RID: 16137
		HeroPowerCompleteAlt,
		// Token: 0x04003F0A RID: 16138
		SocketIn,
		// Token: 0x04003F0B RID: 16139
		VictoryStrike,
		// Token: 0x04003F0C RID: 16140
		DefeatStrike
	}

	// Token: 0x02000B58 RID: 2904
	// (Invoke) Token: 0x06005A1A RID: 23066
	public delegate void RequestedAnimTransitionCallback(LegendaryHeroAnimController.InternalState state);

	// Token: 0x02000B59 RID: 2905
	public class AnimationEventHandler : MonoBehaviour
	{
		// Token: 0x06005A1B RID: 23067 RVA: 0x001B3C15 File Offset: 0x001B1E15
		public void SetController(LegendaryHeroAnimController controller)
		{
			this.m_controller = controller;
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x001B3C1E File Offset: 0x001B1E1E
		public void RaiseAnimEvent(int internalEvent)
		{
			this.m_controller.RaiseAnimEvent((LegendaryHeroAnimController.InternalState)internalEvent);
		}

		// Token: 0x04003F0D RID: 16141
		private LegendaryHeroAnimController m_controller;
	}
}
