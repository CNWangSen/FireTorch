using System;
using UnityEngine;

// Token: 0x02000B7E RID: 2942
public class SecondaryAnimationEventToFSM : MonoBehaviour
{
	// Token: 0x06005A8E RID: 23182 RVA: 0x001B60EC File Offset: 0x001B42EC
	private void Awake()
	{
		this.m_eventListener = base.GetComponentInChildren<SecondaryAnimationEventListener>();
	}

	// Token: 0x06005A8F RID: 23183 RVA: 0x001B60FA File Offset: 0x001B42FA
	private void OnEnable()
	{
		if (this.m_eventListener)
		{
			this.m_eventListener.OnAnimationEvent += this.ForwardAnimationEvent;
		}
	}

	// Token: 0x06005A90 RID: 23184 RVA: 0x001B6120 File Offset: 0x001B4320
	private void OnDisable()
	{
		if (this.m_eventListener)
		{
			this.m_eventListener.OnAnimationEvent -= this.ForwardAnimationEvent;
		}
	}

	// Token: 0x06005A91 RID: 23185 RVA: 0x001B6146 File Offset: 0x001B4346
	private void ForwardAnimationEvent(SecondaryAnimationEvent animEvent)
	{
		if (this.PlayMaker != null && animEvent != SecondaryAnimationEvent.Unknown)
		{
			this.PlayMaker.SendEvent(string.Format("On{0}", animEvent));
		}
	}

	// Token: 0x04003FCA RID: 16330
	public PlayMakerFSM PlayMaker;

	// Token: 0x04003FCB RID: 16331
	private SecondaryAnimationEventListener m_eventListener;
}
