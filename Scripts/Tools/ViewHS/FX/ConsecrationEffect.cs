using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000752 RID: 1874
public class ConsecrationEffect : MonoBehaviour
{
/*
	// Token: 0x06006591 RID: 26001 RVA: 0x00211F71 File Offset: 0x00210171
	private void Awake()
	{
		if (UniversalInputManager.UsePhoneUI)
		{
			this.m_LiftHeightMin = 3f;
			this.m_LiftHeightMax = 5f;
		}
	}

	// Token: 0x06006592 RID: 26002 RVA: 0x00211F98 File Offset: 0x00210198
	private void Start()
	{
		Spell component = base.GetComponent<Spell>();
		if (component == null)
		{
			base.enabled = false;
		}
		this.m_SuperSpell = component.GetSuperSpellParent();
		this.m_ImpactSound = base.GetComponent<AudioSource>();
		this.m_ImpactObjects = new List<GameObject>();
	}

	// Token: 0x06006593 RID: 26003 RVA: 0x00211FE0 File Offset: 0x002101E0
	private void OnDestroy()
	{
		if (this.m_ImpactObjects.Count > 0)
		{
			foreach (GameObject obj in this.m_ImpactObjects)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06006594 RID: 26004 RVA: 0x00212040 File Offset: 0x00210240
	private void StartAnimation()
	{
		if (this.m_SuperSpell == null)
		{
			return;
		}
		int num = 0;
		foreach (GameObject gameObject in this.m_SuperSpell.GetTargets())
		{
			Vector3 position = gameObject.transform.position;
			Quaternion rotation = gameObject.transform.rotation;
			num++;
			float num2 = UnityEngine.Random.Range(this.m_StartDelayMin, this.m_StartDelayMax);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_StartImpact, position, rotation);
			this.m_ImpactObjects.Add(gameObject2);
			foreach (ParticleSystem particleSystem in gameObject2.GetComponentsInChildren<ParticleSystem>())
			{
				particleSystem.main.startDelay = num2;
				particleSystem.Play();
			}
			num2 += 0.2f;
			float num3 = UnityEngine.Random.Range(this.m_LiftHeightMin, this.m_LiftHeightMax);
			Hashtable args = iTween.Hash(new object[]
			{
				"time",
				this.m_LiftTime,
				"delay",
				num2,
				"position",
				new Vector3(position.x, position.y + num3, position.z),
				"easetype",
				iTween.EaseType.easeOutQuad,
				"name",
				string.Format("Lift_{0}_{1}", gameObject.name, num)
			});
			iTween.MoveTo(gameObject, args);
			Vector3 eulerAngles = rotation.eulerAngles;
			eulerAngles.x += UnityEngine.Random.Range(this.m_LiftRotMin, this.m_LiftRotMax);
			eulerAngles.z += UnityEngine.Random.Range(this.m_LiftRotMin, this.m_LiftRotMax);
			Hashtable args2 = iTween.Hash(new object[]
			{
				"time",
				this.m_LiftTime + this.m_HoverTime + this.m_SlamTime * 0.8f,
				"delay",
				num2,
				"rotation",
				eulerAngles,
				"easetype",
				iTween.EaseType.easeOutQuad,
				"name",
				string.Format("LiftRot_{0}_{1}", gameObject.name, num)
			});
			iTween.RotateTo(gameObject, args2);
			float num4 = this.m_StartDelayMax + this.m_LiftTime + this.m_HoverTime;
			Hashtable args3 = iTween.Hash(new object[]
			{
				"time",
				this.m_SlamTime,
				"delay",
				num4,
				"position",
				position,
				"easetype",
				iTween.EaseType.easeInCubic,
				"name",
				string.Format("SlamPos_{0}_{1}", gameObject.name, num)
			});
			iTween.MoveTo(gameObject, args3);
			Hashtable args4 = iTween.Hash(new object[]
			{
				"time",
				this.m_SlamTime * 0.8f,
				"delay",
				num4 + this.m_SlamTime * 0.2f,
				"rotation",
				Vector3.zero,
				"easetype",
				iTween.EaseType.easeInQuad,
				"oncomplete",
				"Finished",
				"oncompletetarget",
				base.gameObject,
				"name",
				string.Format("SlamRot_{0}_{1}", gameObject.name, num)
			});
			iTween.RotateTo(gameObject, args4);
			this.m_TotalTime = num4 + this.m_SlamTime;
			if (gameObject.GetComponentInChildren<MinionShake>())
			{
				MinionShake.ShakeObject(gameObject, ShakeMinionType.RandomDirection, gameObject.transform.position, ShakeMinionIntensity.LargeShake, 1f, 0.1f, num4 + this.m_SlamTime, true, true);
			}
			else
			{
				Bounce bounce = gameObject.GetComponent<Bounce>();
				if (bounce == null)
				{
					bounce = gameObject.AddComponent<Bounce>();
				}
				bounce.m_BounceAmount = num3 * this.m_Bounceness;
				bounce.m_BounceSpeed = 3.5f * UnityEngine.Random.Range(0.8f, 1.3f);
				bounce.m_BounceCount = 3;
				bounce.m_Bounceness = this.m_Bounceness;
				bounce.m_Delay = num4 + this.m_SlamTime;
				bounce.StartAnimation();
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.m_EndImpact, position, rotation);
			this.m_ImpactObjects.Add(gameObject3);
			foreach (ParticleSystem particleSystem2 in gameObject3.GetComponentsInChildren<ParticleSystem>())
			{
				particleSystem2.main.startDelay = num4 + this.m_SlamTime;
				particleSystem2.Play();
			}
		}
	}

	// Token: 0x06006595 RID: 26005 RVA: 0x0021253C File Offset: 0x0021073C
	private void Finished()
	{
		SoundManager.Get().Play(this.m_ImpactSound, null, null, null);
		CameraShakeMgr.Shake(Camera.main, new Vector3(0.15f, 0.15f, 0.15f), 0.9f);
	}
*/
	// Token: 0x04004D94 RID: 19860
	public float m_StartDelayMin = 2f;

	// Token: 0x04004D95 RID: 19861
	public float m_StartDelayMax = 3f;

	// Token: 0x04004D96 RID: 19862
	public float m_LiftTime = 1f;

	// Token: 0x04004D97 RID: 19863
	public float m_LiftHeightMin = 2f;

	// Token: 0x04004D98 RID: 19864
	public float m_LiftHeightMax = 3f;

	// Token: 0x04004D99 RID: 19865
	public float m_LiftRotMin = -15f;

	// Token: 0x04004D9A RID: 19866
	public float m_LiftRotMax = 15f;

	// Token: 0x04004D9B RID: 19867
	public float m_HoverTime = 0.8f;

	// Token: 0x04004D9C RID: 19868
	public float m_SlamTime = 0.2f;

	// Token: 0x04004D9D RID: 19869
	public float m_Bounceness = 0.2f;

	// Token: 0x04004D9E RID: 19870
	public GameObject m_StartImpact;

	// Token: 0x04004D9F RID: 19871
	public GameObject m_EndImpact;

	// Token: 0x04004DA0 RID: 19872
	public float m_TotalTime;

	// Token: 0x04004DA1 RID: 19873
	private SuperSpell m_SuperSpell;

	// Token: 0x04004DA2 RID: 19874
	private List<GameObject> m_ImpactObjects;

	// Token: 0x04004DA3 RID: 19875
	private AudioSource m_ImpactSound;
}
