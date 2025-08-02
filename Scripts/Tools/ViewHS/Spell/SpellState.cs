using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020008ED RID: 2285
public class SpellState : MonoBehaviour
{
	/*
	// Token: 0x06007C8B RID: 31883 RVA: 0x0028A4F4 File Offset: 0x002886F4
	private void Start()
	{
		this.m_spell = SceneUtils.FindComponentInParents<Spell>(base.gameObject);
		for (int i = 0; i < this.m_ExternalAnimatedObjects.Count; i++)
		{
			this.m_ExternalAnimatedObjects[i].Init();
		}
		for (int j = 0; j < this.m_AudioSources.Count; j++)
		{
			this.m_AudioSources[j].Init();
		}
		this.m_initialized = true;
		if (this.m_shown && this.m_playing)
		{
			this.PlayImpl();
			return;
		}
		this.StopImpl(null);
	}

	// Token: 0x06007C8C RID: 31884 RVA: 0x0028A585 File Offset: 0x00288785
	public void Play()
	{
		if (this.m_playing)
		{
			return;
		}
		if (!this.m_shown)
		{
			return;
		}
		this.m_playing = true;
		if (!this.m_initialized)
		{
			return;
		}
		this.PlayImpl();
	}

	// Token: 0x06007C8D RID: 31885 RVA: 0x0028A5AF File Offset: 0x002887AF
	public void Stop(List<SpellState> nextStateList)
	{
		if (!this.m_playing)
		{
			return;
		}
		this.m_playing = false;
		if (!this.m_initialized)
		{
			return;
		}
		this.StopImpl(nextStateList);
	}

	// Token: 0x06007C8E RID: 31886 RVA: 0x0028A5D1 File Offset: 0x002887D1
	public void ShowState()
	{
		if (this.m_shown)
		{
			return;
		}
		this.m_shown = true;
		if (!this.m_initialized)
		{
			return;
		}
		if (!this.m_playing)
		{
			return;
		}
		this.PlayImpl();
	}

	// Token: 0x06007C8F RID: 31887 RVA: 0x0028A5FB File Offset: 0x002887FB
	public void HideState()
	{
		if (!this.m_shown)
		{
			return;
		}
		this.m_shown = false;
		if (!this.m_initialized)
		{
			return;
		}
		if (!this.m_playing)
		{
			return;
		}
		this.StopImpl(null);
	}

	// Token: 0x06007C90 RID: 31888 RVA: 0x0028A628 File Offset: 0x00288828
	public void OnLoad()
	{
		base.gameObject.SetActive(true);
		foreach (SpellStateAnimObject spellStateAnimObject in this.m_ExternalAnimatedObjects)
		{
			spellStateAnimObject.OnLoad(this);
		}
	}

	// Token: 0x06007C91 RID: 31889 RVA: 0x0028A688 File Offset: 0x00288888
	private void OnStateFinished()
	{
		this.m_spell.OnStateFinished();
	}

	// Token: 0x06007C92 RID: 31890 RVA: 0x0028A695 File Offset: 0x00288895
	private void OnSpellFinished()
	{
		this.m_spell.OnSpellFinished();
	}

	// Token: 0x06007C93 RID: 31891 RVA: 0x0028A6A2 File Offset: 0x002888A2
	private void OnChangeState(SpellStateType stateType)
	{
		this.m_spell.ChangeState(stateType);
	}

	// Token: 0x06007C94 RID: 31892 RVA: 0x0028A6B0 File Offset: 0x002888B0
	private IEnumerator DelayedPlay()
	{
		yield return new WaitForSeconds(this.m_StartDelaySec);
		this.PlayNow();
		yield break;
	}

	// Token: 0x06007C95 RID: 31893 RVA: 0x0028A6BF File Offset: 0x002888BF
	private void PlayImpl()
	{
		base.gameObject.SetActive(true);
		if (Mathf.Approximately(this.m_StartDelaySec, 0f))
		{
			this.PlayNow();
			return;
		}
		base.StartCoroutine(this.DelayedPlay());
	}

	// Token: 0x06007C96 RID: 31894 RVA: 0x0028A6F4 File Offset: 0x002888F4
	private void StopImpl(List<SpellState> nextStateList)
	{
		if (nextStateList == null)
		{
			using (List<SpellStateAnimObject>.Enumerator enumerator = this.m_ExternalAnimatedObjects.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SpellStateAnimObject spellStateAnimObject = enumerator.Current;
					spellStateAnimObject.Stop();
				}
				goto IL_6A;
			}
		}
		foreach (SpellStateAnimObject spellStateAnimObject2 in this.m_ExternalAnimatedObjects)
		{
			spellStateAnimObject2.Stop(nextStateList);
		}
		IL_6A:
		foreach (SpellStateAudioSource spellStateAudioSource in this.m_AudioSources)
		{
			spellStateAudioSource.Stop();
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x0028A7D4 File Offset: 0x002889D4
	private void PlayNow()
	{
		foreach (SpellStateAnimObject spellStateAnimObject in this.m_ExternalAnimatedObjects)
		{
			spellStateAnimObject.Play();
		}
		foreach (SpellStateAudioSource spellStateAudioSource in this.m_AudioSources)
		{
			spellStateAudioSource.Play(this);
		}
	}
*/
	// Token: 0x04006438 RID: 25656
	public SpellStateType m_StateType;

	// Token: 0x04006439 RID: 25657
	public float m_StartDelaySec;

	// Token: 0x0400643A RID: 25658
	public List<SpellStateAnimObject> m_ExternalAnimatedObjects;

	// Token: 0x0400643B RID: 25659
	public List<SpellStateAudioSource> m_AudioSources;

	// Token: 0x0400643C RID: 25660
	private Spell m_spell;

	// Token: 0x0400643D RID: 25661
	private bool m_playing;

	// Token: 0x0400643E RID: 25662
	private bool m_initialized;

	// Token: 0x0400643F RID: 25663
	private bool m_shown = true;
}
