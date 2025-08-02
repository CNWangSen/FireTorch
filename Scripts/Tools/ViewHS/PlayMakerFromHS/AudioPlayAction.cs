using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E43 RID: 3651
	[ActionCategory("Pegasus Audio")]
	[Tooltip("Plays the Audio Clip on a Game Object or plays a one shot clip. Waits for the audio to finish.")]
	public class AudioPlayAction : FsmStateAction
	{
		// Token: 0x0600A191 RID: 41361 RVA: 0x0032D99A File Offset: 0x0032BB9A
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_VolumeScale = 1f;
			this.m_Delay = 0f;
			this.m_DelayTime = 0f;
			this.m_OneShotSound = null;
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x0032D9D0 File Offset: 0x0032BBD0
		public override void OnEnter()
		{
			this.m_DelayTime = this.m_Delay;
			base.StartCoroutine(this.Delay());
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x0032D9EC File Offset: 0x0032BBEC
		private AudioSource GetSource()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				return null;
			}
			return ownerDefaultTarget.GetComponent<AudioSource>();
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x0032DA1C File Offset: 0x0032BC1C
		private void Play()
		{
			/*
			AudioSource source = this.GetSource();
			if (source == null)
			{
				base.Fsm.Event(this.m_FinishedEvent);
				base.Finish();
				return;
			}
			*/
			SoundDef soundDef = this.m_OneShotSound.Value as SoundDef;
			SfxMgr.Get().PlaySoundByDef(soundDef,Owner);



			//if (!SoundManager.Get().IsActive(source))
			//{
				base.Fsm.Event(this.m_FinishedEvent);
				base.Finish();
			//}
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x0032DB1B File Offset: 0x0032BD1B
		private IEnumerator Delay()
		{
			while (this.m_DelayTime > 0f)
			{
				this.m_DelayTime -= Time.deltaTime;
				yield return null;
			}
			this.Play();
			//AudioSource source = this.GetSource();
			//while (SoundManager.Get().IsActive(source))
			//{
			//	yield return null;
			//}
			Debug.Log("Finish");
			base.Fsm.Event(this.m_FinishedEvent);
			base.Finish();
			yield break;
		}

		// Token: 0x0400857B RID: 34171
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with the AudioSource component.")]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x0400857C RID: 34172
		[Tooltip("Scales the volume of the AudioSource just for this Play call.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_VolumeScale;

		// Token: 0x0400857D RID: 34173
		public float m_Delay;

		// Token: 0x0400857E RID: 34174
		[ObjectType(typeof(SoundDef))]
		[Tooltip("Optionally play a one shot AudioClip.")]
		public FsmObject m_OneShotSound;

		// Token: 0x0400857F RID: 34175
		[Tooltip("Event to send when the AudioSource finishes playing.")]
		public FsmEvent m_FinishedEvent;

		// Token: 0x04008580 RID: 34176
		private float m_DelayTime;
	}
}
