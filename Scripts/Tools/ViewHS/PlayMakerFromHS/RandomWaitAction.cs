using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E8B RID: 3723
	[ActionCategory("Pegasus")]
	[Tooltip("Delays a State from finishing by a random time. NOTE: Other actions continue, but FINISHED can't happen before the delay.")]
	public class RandomWaitAction : FsmStateAction
	{
		// Token: 0x0600A2BA RID: 41658 RVA: 0x00332DE4 File Offset: 0x00330FE4
		public override void Reset()
		{
			this.m_MinTime = 1f;
			this.m_MaxTime = 1f;
			this.m_FinishEvent = null;
			this.m_RealTime = false;
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x00332E14 File Offset: 0x00331014
		public override void OnEnter()
		{
			if (this.m_MinTime.Value <= 0f && this.m_MaxTime.Value <= 0f)
			{
				base.Finish();
				if (this.m_FinishEvent != null)
				{
					base.Fsm.Event(this.m_FinishEvent);
				}
				return;
			}
			this.m_startTime = FsmTime.RealtimeSinceStartup;
			this.m_waitTime = 0f;//UnityEngine.Random.Range(this.m_MinTime.Value, this.m_MaxTime.Value);
			this.m_updateTime = 0f;
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x00332E9C File Offset: 0x0033109C
		public override void OnUpdate()
		{
			if (this.m_RealTime)
			{
				this.m_updateTime = FsmTime.RealtimeSinceStartup - this.m_startTime;
			}
			else
			{
				this.m_updateTime += Time.deltaTime;
			}
			if (this.m_updateTime > this.m_waitTime)
			{
				base.Finish();
				if (this.m_FinishEvent != null)
				{
					base.Fsm.Event(this.m_FinishEvent);
				}
			}
		}

		// Token: 0x040086C0 RID: 34496
		public FsmFloat m_MinTime;

		// Token: 0x040086C1 RID: 34497
		public FsmFloat m_MaxTime;

		// Token: 0x040086C2 RID: 34498
		public FsmEvent m_FinishEvent;

		// Token: 0x040086C3 RID: 34499
		public bool m_RealTime;

		// Token: 0x040086C4 RID: 34500
		private float m_startTime;

		// Token: 0x040086C5 RID: 34501
		private float m_waitTime;

		// Token: 0x040086C6 RID: 34502
		private float m_updateTime;
	}
}
