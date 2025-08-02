using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020008EB RID: 2283
[Serializable]
public class SpellStateAnimObject
{
	/*
	// Token: 0x06007C7C RID: 31868 RVA: 0x00289FB7 File Offset: 0x002881B7
	public void Init()
	{
		if (this.m_GameObject == null)
		{
			return;
		}
		if (this.m_AnimClip == null)
		{
			return;
		}
		this.SetupAnimation();
	}

	// Token: 0x06007C7D RID: 31869 RVA: 0x00289FE0 File Offset: 0x002881E0
	private void SetupAnimation()
	{
		string name = this.m_AnimClip.name;
		Animation animation;
		if (this.m_GameObject.GetComponent<Animation>() == null)
		{
			animation = this.m_GameObject.AddComponent<Animation>();
		}
		else
		{
			animation = this.m_GameObject.GetComponent<Animation>();
		}
		animation.playAutomatically = false;
		if (animation[name] == null)
		{
			animation.AddClip(this.m_AnimClip, name);
		}
		animation[name].layer = this.m_AnimLayer;
	}

	// Token: 0x06007C7E RID: 31870 RVA: 0x0028A05C File Offset: 0x0028825C
	public void OnLoad(SpellState state)
	{
		if (this.m_Target == SpellStateAnimObject.Target.AS_SPECIFIED)
		{
			if (this.m_GameObject == null)
			{
				Debug.LogError("Error: spell state anim target has a null game object after load");
			}
			return;
		}
		if (this.m_Target == SpellStateAnimObject.Target.ACTOR)
		{
			Actor actor = SceneUtils.FindComponentInParents<Actor>(state.transform);
			if (actor == null || actor.gameObject == null)
			{
				Debug.LogError("Error: spell state anim target has a null game object after load");
				return;
			}
			this.m_GameObject = actor.gameObject;
			this.SetupAnimation();
			return;
		}
		else
		{
			if (this.m_Target != SpellStateAnimObject.Target.ROOT_OBJECT)
			{
				Debug.LogWarning("Error: unimplemented spell anim target");
				return;
			}
			Actor actor2 = SceneUtils.FindComponentInParents<Actor>(state.transform);
			if (actor2 == null || actor2.gameObject == null)
			{
				Debug.LogError("Error: spell state anim target has a null game object after load");
				return;
			}
			this.m_GameObject = actor2.GetRootObject();
			this.SetupAnimation();
			return;
		}
	}

	// Token: 0x06007C7F RID: 31871 RVA: 0x0028A128 File Offset: 0x00288328
	public void Play()
	{
		if (!this.m_Enabled)
		{
			return;
		}
		if (this.m_GameObject == null)
		{
			return;
		}
		if (this.m_AnimClip != null)
		{
			Animation component = this.m_GameObject.GetComponent<Animation>();
			string name = this.m_AnimClip.name;
			AnimationState animationState = component[name];
			animationState.enabled = true;
			animationState.speed = this.m_AnimSpeed;
			if (Mathf.Approximately(this.m_CrossFadeSec, 0f))
			{
				if (!component.Play(name))
				{
					Debug.LogWarning(string.Format("SpellStateAnimObject.PlayNow() - FAILED to play clip {0} on {1}", name, this.m_GameObject));
				}
			}
			else
			{
				component.CrossFade(name, this.m_CrossFadeSec);
			}
		}
		if (this.m_ControlParticles)
		{
			ParticleSystem component2 = this.m_GameObject.GetComponent<ParticleSystem>();
			if (component2 != null)
			{
				component2.Play();
			}
		}
	}

	// Token: 0x06007C80 RID: 31872 RVA: 0x0028A1F0 File Offset: 0x002883F0
	public void Stop()
	{
		if (this.m_GameObject == null)
		{
			return;
		}
		if (this.m_AnimClip != null)
		{
			this.m_GameObject.GetComponent<Animation>().Stop(this.m_AnimClip.name);
		}
		if (this.m_ControlParticles)
		{
			ParticleSystem component = this.m_GameObject.GetComponent<ParticleSystem>();
			if (component != null)
			{
				component.Stop();
			}
		}
	}

	// Token: 0x06007C81 RID: 31873 RVA: 0x0028A258 File Offset: 0x00288458
	public void Stop(List<SpellState> nextStateList)
	{
		if (this.m_GameObject == null)
		{
			return;
		}
		if (this.m_AnimClip != null)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < nextStateList.Count)
			{
				SpellState spellState = nextStateList[num];
				for (int i = 0; i < spellState.m_ExternalAnimatedObjects.Count; i++)
				{
					SpellStateAnimObject spellStateAnimObject = spellState.m_ExternalAnimatedObjects[i];
					if (spellStateAnimObject.m_Enabled && this.m_GameObject == spellStateAnimObject.m_GameObject && this.m_AnimLayer == spellStateAnimObject.m_AnimLayer)
					{
						flag = true;
						break;
					}
				}
				num++;
			}
			if (!flag)
			{
				this.m_GameObject.GetComponent<Animation>().Stop(this.m_AnimClip.name);
			}
		}
		if (this.m_ControlParticles)
		{
			ParticleSystem component = this.m_GameObject.GetComponent<ParticleSystem>();
			if (component != null)
			{
				component.Stop();
			}
		}
	}

	// Token: 0x06007C82 RID: 31874 RVA: 0x0028A33B File Offset: 0x0028853B
	public void Show()
	{
		if (this.m_GameObject == null)
		{
			return;
		}
		this.m_GameObject.SetActive(true);
	}

	// Token: 0x06007C83 RID: 31875 RVA: 0x0028A358 File Offset: 0x00288558
	public void Hide()
	{
		if (this.m_GameObject == null)
		{
			return;
		}
		this.m_GameObject.SetActive(false);
	}
*/
	// Token: 0x04006427 RID: 25639
	public GameObject m_GameObject;

	// Token: 0x04006428 RID: 25640
	public SpellStateAnimObject.Target m_Target;

	// Token: 0x04006429 RID: 25641
	public AnimationClip m_AnimClip;

	// Token: 0x0400642A RID: 25642
	public int m_AnimLayer;

	// Token: 0x0400642B RID: 25643
	public float m_AnimSpeed = 1f;

	// Token: 0x0400642C RID: 25644
	public float m_CrossFadeSec;

	// Token: 0x0400642D RID: 25645
	public bool m_ControlParticles;

	// Token: 0x0400642E RID: 25646
	public bool m_EmitParticles;

	// Token: 0x0400642F RID: 25647
	public string m_Comment;

	// Token: 0x04006430 RID: 25648
	public bool m_Enabled = true;

	// Token: 0x04006431 RID: 25649
	private bool m_prevParticleEmitValue;

	// Token: 0x020022B1 RID: 8881
	public enum Target
	{
		// Token: 0x0400D555 RID: 54613
		AS_SPECIFIED,
		// Token: 0x0400D556 RID: 54614
		ACTOR,
		// Token: 0x0400D557 RID: 54615
		ROOT_OBJECT
	}
}
