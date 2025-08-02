using System;
using UnityEngine;
using UnityEngine.Playables;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000053 RID: 83
	[Tooltip("Enables the 'Playable Director' component on the given game object.")]
	[ActionCategory("Pegasus")]
	public class SetTimelineEnabled : FsmStateAction
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000B4C0 File Offset: 0x000096C0
		public override void Reset()
		{
			this.gameObject = null;
			this.enableTimeline = false;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000B4D0 File Offset: 0x000096D0
		public override void OnEnter()
		{
			GameObject go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (go != null)
			{
				PlayableDirector timeline = go.GetComponent<PlayableDirector>();
				if (timeline != null)
				{
					timeline.enabled = this.enableTimeline;
				}
			}
			base.Finish();
		}

		// Token: 0x04000214 RID: 532
		[RequiredField]
		[CheckForComponent(typeof(PlayableDirector))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04000215 RID: 533
		public bool enableTimeline;
	}
}
