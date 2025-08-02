using System;
using UnityEngine;

// Token: 0x020009D1 RID: 2513
public class PlayNewParticles : MonoBehaviour
{
	// Token: 0x060085A7 RID: 34215 RVA: 0x002B926A File Offset: 0x002B746A
	public void PlayNewParticles3()
	{
		if (this.m_Target == null)
		{
			return;
		}
		this.m_Target.GetComponent<ParticleSystem>().Play();
	}

	// Token: 0x060085A8 RID: 34216 RVA: 0x002B928B File Offset: 0x002B748B
	public void StopNewParticles3()
	{
		if (this.m_Target == null)
		{
			return;
		}
		this.m_Target.GetComponent<ParticleSystem>().Stop();
	}

	// Token: 0x060085A9 RID: 34217 RVA: 0x002B92AC File Offset: 0x002B74AC
	public void PlayNewParticles3andChilds()
	{
		if (this.m_Target2 == null)
		{
			return;
		}
		this.m_Target2.GetComponent<ParticleSystem>().Play(true);
	}

	// Token: 0x060085AA RID: 34218 RVA: 0x002B92CE File Offset: 0x002B74CE
	public void StopNewParticles3andChilds()
	{
		if (this.m_Target2 == null)
		{
			return;
		}
		this.m_Target2.GetComponent<ParticleSystem>().Stop(true);
	}

	// Token: 0x060085AB RID: 34219 RVA: 0x002B92F0 File Offset: 0x002B74F0
	public void PlayNewParticles3andChilds2()
	{
		if (this.m_Target3 == null)
		{
			return;
		}
		this.m_Target3.GetComponent<ParticleSystem>().Play(true);
	}

	// Token: 0x060085AC RID: 34220 RVA: 0x002B9312 File Offset: 0x002B7512
	public void StopNewParticles3andChilds2()
	{
		if (this.m_Target3 == null)
		{
			return;
		}
		this.m_Target3.GetComponent<ParticleSystem>().Stop(true);
	}

	// Token: 0x060085AD RID: 34221 RVA: 0x002B9334 File Offset: 0x002B7534
	public void PlayNewParticles3andChilds3()
	{
		if (this.m_Target4 == null)
		{
			return;
		}
		this.m_Target4.GetComponent<ParticleSystem>().Play(true);
	}

	// Token: 0x060085AE RID: 34222 RVA: 0x002B9356 File Offset: 0x002B7556
	public void StopNewParticles3andChilds3()
	{
		if (this.m_Target4 == null)
		{
			return;
		}
		this.m_Target4.GetComponent<ParticleSystem>().Stop(true);
	}

	// Token: 0x04006B31 RID: 27441
	public GameObject m_Target;

	// Token: 0x04006B32 RID: 27442
	public GameObject m_Target2;

	// Token: 0x04006B33 RID: 27443
	public GameObject m_Target3;

	// Token: 0x04006B34 RID: 27444
	public GameObject m_Target4;
}
