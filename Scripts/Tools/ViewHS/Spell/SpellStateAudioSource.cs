using System;
using System.Collections;
using UnityEngine;

// Token: 0x020008EC RID: 2284
[Serializable]
public class SpellStateAudioSource
{
	// Token: 0x06007C85 RID: 31877 RVA: 0x0028A38F File Offset: 0x0028858F
	public void Init()
	{
		if (this.m_AudioSource == null)
		{
			return;
		}
		this.m_AudioSource.playOnAwake = false;
	}

	// Token: 0x06007C86 RID: 31878 RVA: 0x0028A3AC File Offset: 0x002885AC
	public void Play(SpellState parent)
	{
		if (!this.m_Enabled)
		{
			return;
		}
		if (Mathf.Approximately(this.m_StartDelaySec, 0f))
		{
			this.PlayNow();
			return;
		}
		parent.StartCoroutine(this.DelayedPlay());
	}

	// Token: 0x06007C87 RID: 31879 RVA: 0x0028A3DD File Offset: 0x002885DD
	public void Stop()
	{
		if (!this.m_Enabled)
		{
			return;
		}
		if (this.m_AudioSource == null)
		{
			return;
		}
		if (this.m_PlayGlobally)
		{
			return;
		}
		if (this.m_StopOnStateChange)
		{
			this.m_AudioSource.Stop();
		}
	}

	// Token: 0x06007C88 RID: 31880 RVA: 0x0028A413 File Offset: 0x00288613
	private IEnumerator DelayedPlay()
	{
		yield return new WaitForSeconds(this.m_StartDelaySec);
		this.PlayNow();
		yield break;
	}

	// Token: 0x06007C89 RID: 31881 RVA: 0x0028A424 File Offset: 0x00288624
	private void PlayNow()
	{
		if (this.m_AudioSource == null)
		{
			return;
		}
		if (this.m_PlayGlobally)
		{
			SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
			//soundPlayClipArgs.m_def = //SoundManager.Get().GetSoundDef(this.m_AudioSource);
			soundPlayClipArgs.m_volume = new float?(this.m_AudioSource.volume);
			soundPlayClipArgs.m_pitch = new float?(this.m_AudioSource.pitch);
			//soundPlayClipArgs.m_category = new SoundCategory?(//SoundManager.Get().GetCategory(this.m_AudioSource));
			soundPlayClipArgs.m_parentObject = this.m_AudioSource.gameObject;
			//SoundManager.Get().PlayClip(soundPlayClipArgs, true, null);
			return;
		}
		//SoundManager.Get().Play(this.m_AudioSource, null, null, null);
	}

	// Token: 0x04006432 RID: 25650
	public AudioSource m_AudioSource;

	// Token: 0x04006433 RID: 25651
	public float m_StartDelaySec;

	// Token: 0x04006434 RID: 25652
	public bool m_PlayGlobally;

	// Token: 0x04006435 RID: 25653
	public bool m_StopOnStateChange;

	// Token: 0x04006436 RID: 25654
	public string m_Comment;

	// Token: 0x04006437 RID: 25655
	public bool m_Enabled = true;
}
