using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E44 RID: 3652
	[ActionCategory("Pegasus Audio")]
	[Tooltip("Generates an AudioSource based on a template, then plays that source.")]
	public class AudioPlayClipAction : FsmStateAction
	{

		// Token: 0x0600A197 RID: 41367 RVA: 0x0032DB2C File Offset: 0x0032BD2C
		public override void Reset()
		{
			this.m_ParentObject = null;
			this.m_Sound = null;
			this.m_Volume = 1f;
			this.m_Pitch = 1f;
			this.m_SpatialBlend = 0f;
			this.m_Category = SoundCategory.FX;
			this.m_TemplateSource = null;
			this.m_Delay = 0f;
			this.m_DelayTime = 0f;
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0032DB9B File Offset: 0x0032BD9B
		public override void OnEnter()
		{
			//UnityEngine.Debug.Log("Enter FSM audio Play");
			if (this.m_Delay > 0f)
			{
				this.m_DelayTime = this.m_Delay;
				base.StartCoroutine(this.Delay());
				return;
			}
			this.Play();
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0032DBCC File Offset: 0x0032BDCC
		private void Play()
		{
			if (this.m_Sound == null)
			{
				base.Finish();
				return;
			}
			//if (this.m_IsMinionSummonVO && GameState.Get() != null && GameState.Get().GetGameEntity() != null && GameState.Get().GetGameEntity().HasTag(GAME_TAG.SUPPRESS_ALL_SUMMON_VO))
			//{
			//	base.Finish();
			//	return;
			//}
			/*
			SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
			soundPlayClipArgs.m_templateSource = this.m_TemplateSource;
			soundPlayClipArgs.m_def = (this.m_Sound.Value as SoundDef);
			//UnityEngine.Debug.Log("FSM audio Play");
			//UnityEngine.Debug.Log(soundPlayClipArgs.m_def.m_AudioClip);
			if (!this.m_Volume.IsNone)
			{
				soundPlayClipArgs.m_volume = new float?(this.m_Volume.Value);
			}
			if (!this.m_Pitch.IsNone)
			{
				soundPlayClipArgs.m_pitch = new float?(this.m_Pitch.Value);
			}
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

			*/
			SoundDef soundDef = this.m_Sound.Value as SoundDef;
            SfxMgr.Get().PlaySoundByDef(soundDef,Owner);

			base.Finish();
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0032DD1F File Offset: 0x0032BF1F
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
		

		// Token: 0x04008581 RID: 34177
		[Tooltip("Optional. If specified, the generated Audio Source will be placed at the same location as this object.")]
		public FsmOwnerDefault m_ParentObject;

		// Token: 0x04008582 RID: 34178
		[RequiredField]
		[ObjectType(typeof(SoundDef))]
		public FsmObject m_Sound;

		// Token: 0x04008583 RID: 34179
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_Volume;

		// Token: 0x04008584 RID: 34180
		[HasFloatSlider(-3f, 3f)]
		public FsmFloat m_Pitch;

		// Token: 0x04008585 RID: 34181
		[HasFloatSlider(0f, 1f)]
		public FsmFloat m_SpatialBlend;

		// Token: 0x04008586 RID: 34182
		public SoundCategory m_Category;

		// Token: 0x04008587 RID: 34183
		public float m_Delay;

		// Token: 0x04008588 RID: 34184
		[Tooltip("If specified, this Audio Source will be used as a template for the generated Audio Source, otherwise the one in the SoundConfig will be the template.")]
		public AudioSource m_TemplateSource;

		// Token: 0x04008589 RID: 34185
		[Tooltip("If true, this audio clip will be suppressed by SUPPRESS_ALL_SUMMON_VO")]
		public bool m_IsMinionSummonVO;

		// Token: 0x0400858A RID: 34186
		[Tooltip("If true, there will be a limit to the number instances of of this sound that can play at once.")]
		public bool m_InstanceLimited;

		// Token: 0x0400858B RID: 34187
		[Tooltip("If instance limited, this defines the duration that each clip will prevent another from playing.  If zero, then it will measure the length of the audio file.")]
		public float m_InstanceLimitedDuration;

		// Token: 0x0400858C RID: 34188
		[Tooltip("If instance limited, this defines the maximum number of instances of the sound that can be playing at once.")]
		public int m_InstanceLimitMaximum = 1;

		// Token: 0x0400858D RID: 34189
		private float m_DelayTime;
	}
}
