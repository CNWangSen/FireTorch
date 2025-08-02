using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E85 RID: 3717
	[ActionCategory("Pegasus")]
	[Tooltip("Stop a Particle System.")]
	public class ParticleStopAction : FsmStateAction
	{
		// Token: 0x0600A2A6 RID: 41638 RVA: 0x003329DA File Offset: 0x00330BDA
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_IncludeChildren = false;
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x003329F0 File Offset: 0x00330BF0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
			if (component == null)
			{
				Debug.LogWarning(string.Format("ParticleStopAction.OnEnter() - GameObject {0} has no ParticleSystem component", ownerDefaultTarget));
				base.Finish();
				return;
			}
			component.Stop(this.m_IncludeChildren.Value);
			base.Finish();
		}

		// Token: 0x040086AD RID: 34477
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x040086AE RID: 34478
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
