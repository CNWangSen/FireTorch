using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E81 RID: 3713
	[ActionCategory("Pegasus")]
	[Tooltip("Turns a Particle Emitter on and off with optional delay.")]
	public class particleEmitterOnOff : FsmStateAction
	{
		// Token: 0x0600A299 RID: 41625 RVA: 0x0033271C File Offset: 0x0033091C
		public override void Reset()
		{
			this.gameObject = null;
			this.emitOnOff = false;
			this.delay = 0f;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x0033274F File Offset: 0x0033094F
		public override void OnEnter()
		{
			if (this.delay.Value <= 0f)
			{
				base.Finish();
				return;
			}
			this.startTime = Time.realtimeSinceStartup;
			this.timer = 0f;
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00332780 File Offset: 0x00330980
		public override void OnUpdate()
		{
			if (this.realTime)
			{
				this.timer = Time.realtimeSinceStartup - this.startTime;
			}
			else
			{
				this.timer += Time.deltaTime;
			}
			if (this.timer > this.delay.Value)
			{
				base.Finish();
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
		}

		// Token: 0x0400869F RID: 34463
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040086A0 RID: 34464
		[Tooltip("Set to True to turn it on and False to turn it off.")]
		public FsmBool emitOnOff;

		// Token: 0x040086A1 RID: 34465
		[Tooltip("If 0 it just acts like a switch. Values cause it to Toggle value after delay time (sec).")]
		public FsmFloat delay;

		// Token: 0x040086A2 RID: 34466
		public FsmEvent finishEvent;

		// Token: 0x040086A3 RID: 34467
		public bool realTime;

		// Token: 0x040086A4 RID: 34468
		private float startTime;

		// Token: 0x040086A5 RID: 34469
		private float timer;
	}
}
