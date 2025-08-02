using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C07 RID: 3079
	[ActionCategory("iTween")]
	[Tooltip("Adds supplied Euler angles in degrees to a GameObject's rotation over time.")]
	public class iTweenRotateAdd : iTweenFsmAction
	{
		// Token: 0x060096E9 RID: 38633 RVA: 0x00308BEC File Offset: 0x00306DEC
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.time = 1f;
			this.delay = 0f;
			//this.loopType = iTween.LoopType.none;
			this.vector = new FsmVector3
			{
				UseVariable = true
			};
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.World;
		}

		// Token: 0x060096EA RID: 38634 RVA: 0x00308C63 File Offset: 0x00306E63
		public override void OnEnter()
		{/*
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();*/
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x00308C86 File Offset: 0x00306E86
		public override void OnExit()
		{
			//base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x00308C94 File Offset: 0x00306E94
		private void DoiTween()
		{/*
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = Vector3.zero;
			if (!this.vector.IsNone)
			{
				vector = this.vector.Value;
			}
			this.itweenType = "rotate";
			iTween.RotateAdd(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"amount",
				vector,
				"name",
				this.id.IsNone ? "" : this.id.Value,
				this.speed.IsNone ? "time" : "speed",
				this.speed.IsNone ? (this.time.IsNone ? 1f : this.time.Value) : this.speed.Value,
				"delay",
				this.delay.IsNone ? 0f : this.delay.Value,
				"easetype",
				this.easeType,
				"looptype",
				this.loopType,
				"oncomplete",
				"iTweenOnComplete",
				"oncompleteparams",
				this.itweenID,
				"onstart",
				"iTweenOnStart",
				"onstartparams",
				this.itweenID,
				"ignoretimescale",
				!this.realTime.IsNone && this.realTime.Value,
				"space",
				this.space
			}));*/
		}

		// Token: 0x040079EB RID: 31211
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040079EC RID: 31212
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x040079ED RID: 31213
		[RequiredField]
		[Tooltip("A vector that will be added to a GameObjects rotation.")]
		public FsmVector3 vector;

		// Token: 0x040079EE RID: 31214
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x040079EF RID: 31215
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x040079F0 RID: 31216
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x040079F1 RID: 31217
		//[Tooltip("The shape of the easing curve applied to the animation.")]
		//public iTween.EaseType easeType = iTween.EaseType.linear;

		// Token: 0x040079F2 RID: 31218
		//[Tooltip("The type of loop to apply once the animation has completed.")]
		//public iTween.LoopType loopType;

		// Token: 0x040079F3 RID: 31219
		public Space space;
	}
}
