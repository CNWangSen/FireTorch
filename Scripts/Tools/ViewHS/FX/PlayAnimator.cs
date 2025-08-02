using System;
using UnityEngine;

// Token: 0x020009CF RID: 2511
public class PlayAnimator : MonoBehaviour
{
	// Token: 0x060085A0 RID: 34208 RVA: 0x002B915E File Offset: 0x002B735E
	public void PlayAnimator1()
	{
		if (this.m_Target1 == null)
		{
			return;
		}
		this.m_Target1.GetComponent<Animator>().enabled = true;
		this.m_Target1.GetComponent<Animator>().Play(this.m_Target1State, -1, 0f);
	}

	// Token: 0x060085A1 RID: 34209 RVA: 0x002B919C File Offset: 0x002B739C
	public void PlayAnimator2()
	{
		if (this.m_Target1 == null)
		{
			return;
		}
		this.m_Target2.GetComponent<Animator>().enabled = true;
		this.m_Target2.GetComponent<Animator>().Play(this.m_Target2State, -1, 0f);
	}

	// Token: 0x060085A2 RID: 34210 RVA: 0x002B91DA File Offset: 0x002B73DA
	public void PlayAnimator3()
	{
		if (this.m_Target1 == null)
		{
			return;
		}
		this.m_Target3.GetComponent<Animator>().enabled = true;
		this.m_Target3.GetComponent<Animator>().Play(this.m_Target3State, -1, 0f);
	}

	// Token: 0x04006B25 RID: 27429
	public GameObject m_Target1;

	// Token: 0x04006B26 RID: 27430
	public string m_Target1State;

	// Token: 0x04006B27 RID: 27431
	public GameObject m_Target2;

	// Token: 0x04006B28 RID: 27432
	public string m_Target2State;

	// Token: 0x04006B29 RID: 27433
	public GameObject m_Target3;

	// Token: 0x04006B2A RID: 27434
	public string m_Target3State;
}
