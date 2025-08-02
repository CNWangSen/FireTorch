using System;
using UnityEngine;

// Token: 0x02000B7A RID: 2938
public class SecondaryAnimationEventBehaviour : StateMachineBehaviour
{
	// Token: 0x06005A86 RID: 23174 RVA: 0x001B6040 File Offset: 0x001B4240
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int _)
	{
		SecondaryAnimationEventListener controller = animator.GetComponent<SecondaryAnimationEventListener>();
		if (controller != null)
		{
			controller.NotifyAnimationEvent(this.animEvent);
		}
	}

	// Token: 0x04003FA9 RID: 16297
	public SecondaryAnimationEvent animEvent;
}
