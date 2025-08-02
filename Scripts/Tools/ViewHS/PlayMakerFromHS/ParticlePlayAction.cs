using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E83 RID: 3715
	[ActionCategory("Pegasus")]
	[Tooltip("Play a Particle System. mschweitzer: I think this is equivalent to Simulate with a 1.0 speed.")]
	public class ParticlePlayAction : FsmStateAction
	{
		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00332871 File Offset: 0x00330A71
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_IncludeChildren = false;
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00332888 File Offset: 0x00330A88
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			ParticleSystem component = ownerDefaultTarget.GetComponent<ParticleSystem>();
			if (component == null && !this.m_IncludeChildren.Value)
			{
				Debug.LogWarning(string.Format("ParticlePlayAction.OnEnter() - {0} has no ParticleSystem component. Owner={1}", ownerDefaultTarget, base.Owner));
				base.Finish();
				return;
			}
			if (component == null && this.m_IncludeChildren.Value)
			{
				ParticleSystem[] componentsInChildren = ownerDefaultTarget.GetComponentsInChildren<ParticleSystem>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].Play(this.m_IncludeChildren.Value);
				}
				base.Finish();
				return;
			}
			component.Play(this.m_IncludeChildren.Value);
			base.Finish();
		}

		// Token: 0x040086A8 RID: 34472
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x040086A9 RID: 34473
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
