using System;
using UnityEngine;

// Token: 0x02000B7B RID: 2939
public class SecondaryAnimationEventListener : MonoBehaviour
{
	// Token: 0x14000053 RID: 83
	// (add) Token: 0x06005A88 RID: 23176 RVA: 0x001B606C File Offset: 0x001B426C
	// (remove) Token: 0x06005A89 RID: 23177 RVA: 0x001B60A4 File Offset: 0x001B42A4
	public event SecondaryAnimationEventListener.SecondaryAnimationEventCallback OnAnimationEvent;

	// Token: 0x06005A8A RID: 23178 RVA: 0x001B60D9 File Offset: 0x001B42D9
	public void NotifyAnimationEvent(SecondaryAnimationEvent animEvent)
	{
		SecondaryAnimationEventListener.SecondaryAnimationEventCallback onAnimationEvent = this.OnAnimationEvent;
		if (onAnimationEvent == null)
		{
			return;
		}
		onAnimationEvent(animEvent);
	}

	// Token: 0x02000B7C RID: 2940
	// (Invoke) Token: 0x06005A8D RID: 23181
	public delegate void SecondaryAnimationEventCallback(SecondaryAnimationEvent animEvent);
}
