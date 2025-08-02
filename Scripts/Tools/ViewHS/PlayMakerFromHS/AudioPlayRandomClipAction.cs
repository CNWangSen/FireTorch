using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E45 RID: 3653
	[ActionCategory("Pegasus Audio")]
	[Tooltip("Plays a random AudioClip. An AudioSource for the clip is created automatically based on the parameters.")]
	public class AudioPlayRandomClipAction : FsmStateAction
	{
		// Token: 0x0600A19C RID: 41372 RVA: 0x0032DD40 File Offset: 0x0032BF40
		public override void Reset()
		{
			this.m_ParentObject = null;
			this.m_Sounds = new SoundDef[3];
			this.m_Weights = new FsmFloat[]
			{
				1f,
				1f,
				1f
			};
			this.m_MinVolume = 1f;
			this.m_MaxVolume = 1f;
			this.m_MinPitch = 1f;
			this.m_MaxPitch = 1f;
			this.m_SpatialBlend = 0f;
			this.m_Category = SoundCategory.FX;
			this.m_TemplateSource = null;
			this.m_Delay = 0f;
			this.m_DelayTime = 0f;
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x0032DE07 File Offset: 0x0032C007
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

		// Token: 0x0600A19E RID: 41374 RVA: 0x0032DE36 File Offset: 0x0032C036
		private SoundDef ChooseClip()
		{
			if (this.m_Weights == null || this.m_Weights.Length == 0)
			{
				return this.m_Sounds[0];
			}
			return this.m_Sounds[ActionHelpers.GetRandomWeightedIndex(this.m_Weights)];
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x0032DE64 File Offset: 0x0032C064
		private float ChooseVolume()
		{
			float num = this.m_MinVolume.IsNone ? 1f : this.m_MinVolume.Value;
			float num2 = this.m_MaxVolume.IsNone ? 1f : this.m_MaxVolume.Value;
			if (Mathf.Approximately(num, num2))
			{
				return num;
			}
			return UnityEngine.Random.Range(num, num2);
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x0032DEC4 File Offset: 0x0032C0C4
		private float ChoosePitch()
		{
			float num = this.m_MinPitch.IsNone ? 1f : this.m_MinPitch.Value;
			float num2 = this.m_MaxPitch.IsNone ? 1f : this.m_MaxPitch.Value;
			if (Mathf.Approximately(num, num2))
			{
				return num;
			}
			return UnityEngine.Random.Range(num, num2);
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x0032DF24 File Offset: 0x0032C124
		private void Play()
		{
			if (this.m_Sounds == null || this.m_Sounds.Length == 0)
			{
				base.Finish();
				return;
			}
			SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
			soundPlayClipArgs.m_templateSource = this.m_TemplateSource;
			soundPlayClipArgs.m_def = this.ChooseClip();
			soundPlayClipArgs.m_volume = new float?(this.ChooseVolume());
			soundPlayClipArgs.m_pitch = new float?(this.ChoosePitch());
			if (!this.m_SpatialBlend.IsNone)
			{
				soundPlayClipArgs.m_spatialBlend = new float?(this.m_SpatialBlend.Value);
			}
			if (this.m_Category != SoundCategory.NONE)
			{
				soundPlayClipArgs.m_category = new SoundCategory?(this.m_Category);
			}
			soundPlayClipArgs.m_parentObject = base.Fsm.GetOwnerDefaultTarget(this.m_ParentObject);
			//SoundManager.SoundOptions options = new SoundManager.SoundOptions
			//{
			//	InstanceLimited = this.m_InstanceLimited,
			//	InstanceTimeLimit = this.m_InstanceLimitedDuration,
			//	MaxInstancesOfThisSound = this.m_InstanceLimitMaximum
			//};
			//SoundManager.Get().PlayClip(soundPlayClipArgs, true, options);

            SfxMgr.Get().PlaySoundByDef(soundPlayClipArgs.m_def,Owner);

			base.Finish();
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x0032E01A File Offset: 0x0032C21A
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

		// Token: 0x0400858E RID: 34190
		[Tooltip("Optional. If specified, the generated Audio Source will use the same transform as this object.")]
		public FsmOwnerDefault m_ParentObject;

		// Token: 0x0400858F RID: 34191
		[RequiredField]
		[CompoundArray("Sounds", "SoundDef", "Weight")]
		public SoundDef[] m_Sounds;

		// Token: 0x04008590 RID: 34192
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] m_Weights;

		// Token: 0x04008591 RID: 34193
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_MinVolume;

		// Token: 0x04008592 RID: 34194
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_MaxVolume;

		// Token: 0x04008593 RID: 34195
		[HasFloatSlider(-3f, 3f)]
		public FsmFloat m_MinPitch;

		// Token: 0x04008594 RID: 34196
		[HasFloatSlider(-3f, 3f)]
		public FsmFloat m_MaxPitch;

		// Token: 0x04008595 RID: 34197
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_SpatialBlend;

		// Token: 0x04008596 RID: 34198
		public SoundCategory m_Category;

		// Token: 0x04008597 RID: 34199
		public float m_Delay;

		// Token: 0x04008598 RID: 34200
		[Tooltip("If specified, this Audio Source will be used as a template for the generated Audio Source, otherwise the one in the SoundConfig will be the template.")]
		public AudioSource m_TemplateSource;

		// Token: 0x04008599 RID: 34201
		[Tooltip("If true, there will be a limit to the number instances of of this sound that can play at once.")]
		public bool m_InstanceLimited;

		// Token: 0x0400859A RID: 34202
		[Tooltip("If instance limited, this defines the duration that each clip will prevent another from playing.  If zero, then it will measure the length of the audio file.")]
		public float m_InstanceLimitedDuration;

		// Token: 0x0400859B RID: 34203
		[Tooltip("If instance limited, this defines the maximum number of instances of the sound that can be playing at once.")]
		public int m_InstanceLimitMaximum = 1;

		// Token: 0x0400859C RID: 34204
		private float m_DelayTime;
	}
}
