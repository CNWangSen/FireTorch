using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E46 RID: 3654
	[ActionCategory("Pegasus Audio")]
	[Tooltip("Plays the Audio Clip on a Game Object or plays a one shot clip. Does not wait for the audio to finish.")]
	public class AudioPlaythroughAction : FsmStateAction
	{
		// Token: 0x0600A1A4 RID: 41380 RVA: 0x0032E038 File Offset: 0x0032C238
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_VolumeScale = 1f;
			this.m_OneShotClip = null;
			this.m_Delay = 0f;
			this.m_DelayTime = 0f;
			this.m_OneShotSound = null;
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x0032E075 File Offset: 0x0032C275
		public override void OnEnter()
		{
			if (this.m_Delay > 0f)
			{
				this.m_DelayTime = this.m_Delay;
				base.StartCoroutine(this.Delay());
				return;
			}
			this.Play();
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x0032E0A4 File Offset: 0x0032C2A4
		private AudioSource GetSource()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				return null;
			}
			return ownerDefaultTarget.GetComponent<AudioSource>();
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x0032E0D4 File Offset: 0x0032C2D4
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
			if (this.m_IsMinionSummonVO && GameState.Get() != null && GameState.Get().GetGameEntity() != null && GameState.Get().GetGameEntity().HasTag(GAME_TAG.SUPPRESS_ALL_SUMMON_VO))
			{
				base.Fsm.Event(this.m_FinishedEvent);
				base.Finish();
				return;
			}
			*/
			SoundDef soundDef = this.m_OneShotSound.Value as SoundDef;
			if (soundDef == null)
			{
				foreach (SoundDef sd in Owner.GetComponentsInChildren<SoundDef>())
		        {
		            soundDef=sd;
		        }
				/*
				if (!this.m_VolumeScale.IsNone)
				{
					SoundManager.Get().SetVolume(source, this.m_VolumeScale.Value);
				}
				SoundManager.Get().Play(source, null, null, null);
				*/
			}
			else{

			}
			if(soundDef==null)
			{

			}
			else
			{
				/*
				SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
				soundPlayClipArgs.m_templateSource = source;
				soundPlayClipArgs.m_def = soundDef;
				if (!this.m_VolumeScale.IsNone)
				{
					soundPlayClipArgs.m_volume = new float?(this.m_VolumeScale.Value);
				}
				soundPlayClipArgs.m_parentObject = source.gameObject;
				if (SoundManager.Get() != null)
				{
					SoundManager.SoundOptions options = new SoundManager.SoundOptions
					{
						InstanceLimited = this.m_InstanceLimited,
						InstanceTimeLimit = this.m_InstanceLimitedDuration,
						MaxInstancesOfThisSound = this.m_InstanceLimitMaximum
					};
					SoundManager.Get().PlayClip(soundPlayClipArgs, true, options);
				}
				*/
	            if (soundDef.m_AudioClip!="")//soundPlayClipArgs.m_def.m_AudioClip != "")
	            {
	            	if (SfxMgr.Get().CanPlay(soundDef.m_AudioClip))
	            	{
						AudioClip clip = HSViewer.LoadAudioClipFromSoundDefInPlayMaker(soundDef.m_AudioClip);//soundPlayClipArgs.m_def.m_AudioClip);//abaud.LoadAsset<AudioClip>(audid);
		                if (clip != null)
		                {
		                    AudioSource src = Owner.AddComponent<AudioSource>();
		                    src.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
		                    src.clip = clip;
		                    src.Play();
		                }            		
	            	}
	            }
	            else{
	            }
			}
			base.Fsm.Event(this.m_FinishedEvent);
			base.Finish();
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x0032E23C File Offset: 0x0032C43C
		private IEnumerator Delay()
		{
			while (this.m_DelayTime > 0f)
			{
				this.m_DelayTime -= Time.deltaTime;
				yield return null;
			}
			this.Play();
			yield break;
		}

		// Token: 0x0400859D RID: 34205
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with the AudioSource component.")]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x0400859E RID: 34206
		[Tooltip("Scales the volume of the AudioSource just for this Play call.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_VolumeScale;

		// Token: 0x0400859F RID: 34207
		[ObjectType(typeof(AudioClip))]
		[Tooltip("Optionally play a One Shot AudioClip.")]
		public FsmObject m_OneShotClip;

		// Token: 0x040085A0 RID: 34208
		public float m_Delay;

		// Token: 0x040085A1 RID: 34209
		[ObjectType(typeof(SoundDef))]
		[Tooltip("Optionally play a one shot AudioClip.")]
		public FsmObject m_OneShotSound;

		// Token: 0x040085A2 RID: 34210
		[Tooltip("Event to send when the AudioSource finishes playing.")]
		public FsmEvent m_FinishedEvent;

		// Token: 0x040085A3 RID: 34211
		[Tooltip("If true, this audio clip will be suppressed by SUPPRESS_ALL_SUMMON_VO")]
		public bool m_IsMinionSummonVO;

		// Token: 0x040085A4 RID: 34212
		[Tooltip("If true, there will be a limit to the number instances of of this sound that can play at once.")]
		public bool m_InstanceLimited;

		// Token: 0x040085A5 RID: 34213
		[Tooltip("If instance limited, this defines the duration that each clip will prevent another from playing.  If zero, then it will measure the length of the audio file.")]
		public float m_InstanceLimitedDuration;

		// Token: 0x040085A6 RID: 34214
		[Tooltip("If instance limited, this defines the maximum number of instances of the sound that can be playing at once.")]
		public int m_InstanceLimitMaximum = 1;

		// Token: 0x040085A7 RID: 34215
		private float m_DelayTime;
	}
}
