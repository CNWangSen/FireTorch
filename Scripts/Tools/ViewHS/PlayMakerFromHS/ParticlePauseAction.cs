using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E82 RID: 3714
	[ActionCategory("Pegasus")]
	[Tooltip("Pause a Particle System.")]
	public class ParticlePauseAction : FsmStateAction
	{
		// Token: 0x0600A29D RID: 41629 RVA: 0x003327ED File Offset: 0x003309ED
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_IncludeChildren = false;
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00332804 File Offset: 0x00330A04
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
				Debug.LogWarning(string.Format("ParticlePauseAction.OnEnter() - GameObject {0} has no ParticleSystem component", ownerDefaultTarget));
				base.Finish();
				return;
			}
			component.Pause(this.m_IncludeChildren.Value);
			base.Finish();
		}

		// Token: 0x040086A6 RID: 34470
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x040086A7 RID: 34471
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
