using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E39 RID: 3641
	[ActionCategory("Pegasus")]
	[Tooltip("Plays an Animation on a Game Object and waits for the animation to finish.")]
	public class AnimationPlayAction : FsmStateAction
	{
		// Token: 0x0600A168 RID: 41320 RVA: 0x0032CDE4 File Offset: 0x0032AFE4
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_AnimName = null;
			this.m_PhoneAnimName = null;
			this.m_PlayMode = PlayMode.StopAll;
			this.m_CrossFadeSec = 0.3f;
			this.m_FinishEvent = null;
			this.m_LoopEvent = null;
			this.m_StopOnExit = false;
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x0032CE32 File Offset: 0x0032B032
		public override void OnEnter()
		{
			if (!this.CacheAnim())
			{
				base.Finish();
				return;
			}
			this.StartAnimation();
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x0032CE4C File Offset: 0x0032B04C
		public override void OnUpdate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			if (ownerDefaultTarget.GetComponent<Animation>() == null)
			{
				Debug.LogWarning(string.Format("AnimationPlayAction.OnUpdate() - GameObject {0} is missing an animation component", ownerDefaultTarget));
				base.Finish();
				return;
			}
			if (!this.m_animState.enabled || (this.m_animState.wrapMode == WrapMode.ClampForever && this.m_animState.time > this.m_animState.length))
			{
				base.Fsm.Event(this.m_FinishEvent);
				base.Finish();
			}
			if (this.m_animState.wrapMode != WrapMode.ClampForever && this.m_animState.time > this.m_animState.length && this.m_prevAnimTime < this.m_animState.length)
			{
				base.Fsm.Event(this.m_LoopEvent);
			}
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x0032CF34 File Offset: 0x0032B134
		public override void OnExit()
		{
			if (this.m_StopOnExit)
			{
				this.StopAnimation();
			}
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x0032CF44 File Offset: 0x0032B144
		private bool CacheAnim()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			this.m_animName = this.m_AnimName.Value;
			//if (UniversalInputManager.UsePhoneUI && !string.IsNullOrEmpty(this.m_PhoneAnimName.Value))
			//{
			//	this.m_animName = this.m_PhoneAnimName.Value;
			//}
			this.m_animState = ownerDefaultTarget.GetComponent<Animation>()[this.m_animName];
			return true;
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x0032CFBC File Offset: 0x0032B1BC
		private void StartAnimation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			float value = this.m_CrossFadeSec.Value;
			if (value <= Mathf.Epsilon)
			{
				ownerDefaultTarget.GetComponent<Animation>().Play(this.m_animName, this.m_PlayMode);
			}
			else
			{
				ownerDefaultTarget.GetComponent<Animation>().CrossFade(this.m_animName, value, this.m_PlayMode);
			}
			this.m_prevAnimTime = this.m_animState.time;
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x0032D034 File Offset: 0x0032B234
		private void StopAnimation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget.GetComponent<Animation>() == null)
			{
				return;
			}
			ownerDefaultTarget.GetComponent<Animation>().Stop(this.m_animName);
		}

		// Token: 0x04008545 RID: 34117
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("Game Object to play the animation on.")]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x04008546 RID: 34118
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation to play.")]
		public FsmString m_AnimName;

		// Token: 0x04008547 RID: 34119
		public FsmString m_PhoneAnimName;

		// Token: 0x04008548 RID: 34120
		[Tooltip("How to treat previously playing animations.")]
		public PlayMode m_PlayMode;

		// Token: 0x04008549 RID: 34121
		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time taken to cross fade to this animation.")]
		public FsmFloat m_CrossFadeSec;

		// Token: 0x0400854A RID: 34122
		[Tooltip("Event to send when the animation is finished playing. NOTE: Not sent with Loop or PingPong wrap modes!")]
		public FsmEvent m_FinishEvent;

		// Token: 0x0400854B RID: 34123
		[Tooltip("Event to send when the animation loops. If you want to send this event to another FSM use Set Event Target. NOTE: This event is only sent with Loop and PingPong wrap modes.")]
		public FsmEvent m_LoopEvent;

		// Token: 0x0400854C RID: 34124
		[Tooltip("Stop playing the animation when this state is exited.")]
		public bool m_StopOnExit;

		// Token: 0x0400854D RID: 34125
		private string m_animName;

		// Token: 0x0400854E RID: 34126
		private AnimationState m_animState;

		// Token: 0x0400854F RID: 34127
		private float m_prevAnimTime;
	}
}
