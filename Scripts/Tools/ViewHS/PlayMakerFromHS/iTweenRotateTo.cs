using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0A RID: 3082
	[ActionCategory("iTween")]
	[Tooltip("Rotates a GameObject to the supplied Euler angles in degrees over time.")]
	public class iTweenRotateTo : iTweenFsmAction
	{
		// Token: 0x060096F8 RID: 38648 RVA: 0x00309468 File Offset: 0x00307668
		public override void Reset()
		{
			
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.transformRotation = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorRotation = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.delay = 0f;
			this.loopType = iTween.LoopType.none;
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.World;
			
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x003094F1 File Offset: 0x003076F1
		public override void OnEnter()
		{
			/*
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
			*/
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x00309514 File Offset: 0x00307714
		public override void OnExit()
		{
			//base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x00309524 File Offset: 0x00307724
		private void DoiTween()
		{
			/*
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vectorRotation.IsNone ? Vector3.zero : this.vectorRotation.Value;
			if (!this.transformRotation.IsNone && this.transformRotation.Value)
			{
				vector = ((this.space == Space.World) ? (this.transformRotation.Value.transform.eulerAngles + vector) : (this.transformRotation.Value.transform.localEulerAngles + vector));
			}
			this.itweenType = "rotate";
			iTween.RotateTo(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"rotation",
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
				"islocal",
				this.space == Space.Self
			}));
			*/
		}

		// Token: 0x04007A07 RID: 31239
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04007A08 RID: 31240
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04007A09 RID: 31241
		[Tooltip("Rotate to a transform rotation.")]
		public FsmGameObject transformRotation;

		// Token: 0x04007A0A RID: 31242
		[Tooltip("A rotation the GameObject will animate from.")]
		public FsmVector3 vectorRotation;

		// Token: 0x04007A0B RID: 31243
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04007A0C RID: 31244
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04007A0D RID: 31245
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04007A0E RID: 31246
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType = iTween.EaseType.linear;

		// Token: 0x04007A0F RID: 31247
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04007A10 RID: 31248
		[Tooltip("Whether to animate in local or world space.")]
		public Space space;
	}
}
