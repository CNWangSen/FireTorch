using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020009CE RID: 2510
[ExecuteAlways]
public class ParticlePlaybackSpeed : MonoBehaviour
{
	// Token: 0x0600859A RID: 34202 RVA: 0x002B8F7A File Offset: 0x002B717A
	private void Start()
	{
		this.Init();
	}

	// Token: 0x0600859B RID: 34203 RVA: 0x002B8F84 File Offset: 0x002B7184
	private void Update()
	{
		if (this.m_ParticlePlaybackSpeed == this.m_PreviousPlaybackSpeed)
		{
			return;
		}
		this.m_PreviousPlaybackSpeed = this.m_ParticlePlaybackSpeed;
		int i = 0;
		while (i < this.m_ParticleSystems.Count)
		{
			ParticleSystem particleSystem = this.m_ParticleSystems[i];
			if (particleSystem)
			{
				var pm = particleSystem.main;
				pm.simulationSpeed = this.m_ParticlePlaybackSpeed;
				i++;
			}
			else
			{
				this.m_OrgPlaybackSpeed.Remove(particleSystem);
				this.m_ParticleSystems.RemoveAt(i);
			}
		}
	}

	// Token: 0x0600859C RID: 34204 RVA: 0x002B9008 File Offset: 0x002B7208
	private void OnDisable()
	{
		if (this.m_RestoreSpeedOnDisable)
		{
			foreach (KeyValuePair<ParticleSystem, float> keyValuePair in this.m_OrgPlaybackSpeed)
			{
				ParticleSystem key = keyValuePair.Key;
				float value = keyValuePair.Value;
				if (key)
				{
					var pm = key.main;
					pm.simulationSpeed = value;
				}
			}
		}
		this.m_PreviousPlaybackSpeed = -10000000f;
		this.m_ParticleSystems.Clear();
		this.m_OrgPlaybackSpeed.Clear();
	}

	// Token: 0x0600859D RID: 34205 RVA: 0x002B8F7A File Offset: 0x002B717A
	private void OnEnable()
	{
		this.Init();
	}

	// Token: 0x0600859E RID: 34206 RVA: 0x002B90A8 File Offset: 0x002B72A8
	private void Init()
	{
		if (this.m_ParticleSystems == null)
		{
			this.m_ParticleSystems = new List<ParticleSystem>();
		}
		else
		{
			this.m_ParticleSystems.Clear();
		}
		if (this.m_OrgPlaybackSpeed == null)
		{
			this.m_OrgPlaybackSpeed = new Dictionary<ParticleSystem, float>();
		}
		else
		{
			this.m_OrgPlaybackSpeed.Clear();
		}
		foreach (ParticleSystem particleSystem in base.gameObject.GetComponentsInChildren<ParticleSystem>())
		{
			this.m_OrgPlaybackSpeed.Add(particleSystem, particleSystem.main.simulationSpeed);
			this.m_ParticleSystems.Add(particleSystem);
		}
	}

	// Token: 0x04006B20 RID: 27424
	public float m_ParticlePlaybackSpeed = 1f;

	// Token: 0x04006B21 RID: 27425
	public bool m_RestoreSpeedOnDisable = true;

	// Token: 0x04006B22 RID: 27426
	private float m_PreviousPlaybackSpeed = 1f;

	// Token: 0x04006B23 RID: 27427
	private Dictionary<ParticleSystem, float> m_OrgPlaybackSpeed;

	// Token: 0x04006B24 RID: 27428
	private List<ParticleSystem> m_ParticleSystems;
}
