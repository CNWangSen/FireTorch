using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E80 RID: 3712
	[ActionCategory("Pegasus")]
	[Tooltip("Emit particles in a Particle System immediately.\nIf the particle system is not playing it will start playing.")]
	public class ParticleEmitAction : FsmStateAction
	{
		// Token: 0x0600A294 RID: 41620 RVA: 0x003325F1 File Offset: 0x003307F1
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_Count = 10;
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x00332608 File Offset: 0x00330808
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			if (this.m_IncludeChildren.Value)
			{
				this.EmitParticlesRecurse(ownerDefaultTarget);
			}
			else
			{
				this.EmitParticles(ownerDefaultTarget);
			}
			base.Finish();
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x0033265C File Offset: 0x0033085C
		private void EmitParticles(GameObject go)
		{
			ParticleSystem component = go.GetComponent<ParticleSystem>();
			if (component == null)
			{
				Debug.LogWarning(string.Format("ParticleEmitAction.OnEnter() - GameObject {0} has no ParticleSystem component", go));
				return;
			}
			component.Emit(this.m_Count.Value);
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x0033269C File Offset: 0x0033089C
		private void EmitParticlesRecurse(GameObject go)
		{
			ParticleSystem component = go.GetComponent<ParticleSystem>();
			if (component != null)
			{
				component.Emit(this.m_Count.Value);
			}
			foreach (object obj in go.transform)
			{
				Transform transform = (Transform)obj;
				this.EmitParticlesRecurse(transform.gameObject);
			}
		}

		// Token: 0x0400869C RID: 34460
		[RequiredField]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x0400869D RID: 34461
		[Tooltip("The number of particles to emit.")]
		public FsmInt m_Count;

		// Token: 0x0400869E RID: 34462
		[Tooltip("Run this action on all child objects' Particle Systems.")]
		public FsmBool m_IncludeChildren;
	}
}
