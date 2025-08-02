using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E3B RID: 3643
	[ActionCategory("Pegasus")]
	[Tooltip("Enables an Animator and plays one of its states.")]
	public class AnimatorPlayAction : FsmStateAction
	{
		// Token: 0x0600A174 RID: 41332 RVA: 0x0032D180 File Offset: 0x0032B380
		public override void Reset()
		{
			this.m_GameObject = null;
			this.m_StateName = null;
			this.m_LayerName = new FsmString
			{
				UseVariable = true
			};
			this.m_StartTimePercent = 0f;
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x0032D1B4 File Offset: 0x0032B3B4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.m_GameObject);
			if (!ownerDefaultTarget)
			{
				base.Finish();
				return;
			}
			Animator component = ownerDefaultTarget.GetComponent<Animator>();
			if (component)
			{
				int layer = -1;
				//if (!this.m_LayerName.IsNone)
				//{
				//	layer = AnimationUtil.GetLayerIndexFromName(component, this.m_LayerName.Value);
				//}
				float normalizedTime = float.NegativeInfinity;
				if (!this.m_StartTimePercent.IsNone)
				{
					normalizedTime = 0.01f * this.m_StartTimePercent.Value;
				}
				component.enabled = true;
				component.Play(this.m_StateName.Value, layer, normalizedTime);
			}
			base.Finish();
		}

		// Token: 0x04008555 RID: 34133
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("Game Object to play the animation on.")]
		public FsmOwnerDefault m_GameObject;

		// Token: 0x04008556 RID: 34134
		public FsmString m_StateName;

		// Token: 0x04008557 RID: 34135
		public FsmString m_LayerName;

		// Token: 0x04008558 RID: 34136
		[Tooltip("Percent of time into the animation at which to start playing.")]
		[HasFloatSlider(0f, 100f)]
		public FsmFloat m_StartTimePercent;
	}
}
