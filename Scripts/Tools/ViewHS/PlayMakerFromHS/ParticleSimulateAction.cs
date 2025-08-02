using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E84 RID: 3716
	[ActionCategory("Pegasus")]
	[Tooltip("Simulates a Particle System at a variable speed.")]
	public class ParticleSimulateAction : FsmStateAction
	{
		// Token: 0x0600A2A3 RID: 41635 RVA: 0x0033294D File Offset: 0x00330B4D
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_TimeToFastForwardTo = 0f;
			this.m_IncludeChildren = false;
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x00332974 File Offset: 0x00330B74
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
			if (component == null)
			{
				Debug.LogWarning(string.Format("ParticleSimulateAction.OnEnter() - GameObject {0} has no ParticleSystem component", ownerDefaultTarget));
				return;
			}
			component.Simulate(this.m_TimeToFastForwardTo.Value, this.m_IncludeChildren.Value);
		}

		// Token: 0x040086AA RID: 34474
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x040086AB RID: 34475
		[Tooltip("Time at which this particle displays. This leave the system in a paused state.")]
		public FsmFloat m_TimeToFastForwardTo;

		// Token: 0x040086AC RID: 34476
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
