using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E7F RID: 3711
	[ActionCategory("Pegasus")]
	[Tooltip("Remove all particles in a Particle System.")]
	public class ParticleClearAction : FsmStateAction
	{
		// Token: 0x0600A291 RID: 41617 RVA: 0x0033256F File Offset: 0x0033076F
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_IncludeChildren = false;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x00332584 File Offset: 0x00330784
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
			if (component != null)
			{
				Debug.LogWarning(string.Format("ParticlePlayAction.OnEnter() - GameObject {0} has no ParticleSystem component", ownerDefaultTarget));
				base.Finish();
				return;
			}
			component.Clear(this.m_IncludeChildren.Value);
			base.Finish();
		}

		// Token: 0x0400869A RID: 34458
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x0400869B RID: 34459
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
