using System;
using UnityEngine;
using UnityEngine.Playables;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EBB RID: 3771
	[ActionCategory("Pegasus")]
	[Tooltip("Plays the timeline on specified gameObject with a 'Playable Director' component.")]
	public class TimelinePlay : FsmStateAction
	{
		// Token: 0x0600A384 RID: 41860 RVA: 0x00335798 File Offset: 0x00333998
		public override void Reset()
		{
			this.gameObject = null;
			this.m_timeline.stopped -= this.OnTimelineStopped;
			this.m_timeline = null;
			this.finishOnTimelineStopped = false;
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x003357C8 File Offset: 0x003339C8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this.m_timeline = ownerDefaultTarget.GetComponent<PlayableDirector>();
				if (this.m_timeline != null)
				{
					this.m_timeline.Play();
				}
			}
			if (this.finishOnTimelineStopped)
			{
				this.m_timeline.stopped += this.OnTimelineStopped;
				return;
			}
			base.Finish();
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0033583B File Offset: 0x00333A3B
		private void OnTimelineStopped(PlayableDirector aDirector)
		{
			if (this.m_timeline == aDirector)
			{
				base.Finish();
			}
		}

		// Token: 0x04008775 RID: 34677
		[RequiredField]
		[CheckForComponent(typeof(PlayableDirector))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04008776 RID: 34678
		[Tooltip("Only Finish() when the timeline has stopped. DO NOT USE FOR LOOPING OR INFINITE TIMELINES.")]
		public bool finishOnTimelineStopped;

		// Token: 0x04008777 RID: 34679
		private PlayableDirector m_timeline;
	}
}
