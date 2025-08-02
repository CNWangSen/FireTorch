using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000E6C RID: 3692
	[ActionCategory("Pegasus")]
	[Tooltip("Get shadow color")]
	public class GetShadowColor : FsmStateAction
	{
		// Token: 0x0600A23A RID: 41530 RVA: 0x00330CB8 File Offset: 0x0032EEB8
		public override void Reset()
		{
			this.m_Color = Color.black;
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x00330CCA File Offset: 0x0032EECA
		public override void OnEnter()
		{
			this.m_Color.Value = new Color(0.098f, 0.098f, 0.235f, 0.45f);
			//this.m_Color.Value = Board.Get().m_ShadowColor;
			base.Finish();
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x00330CE7 File Offset: 0x0032EEE7
		public override void OnUpdate()
		{
			this.m_Color.Value = new Color(0.098f, 0.098f, 0.235f, 0.45f);
			//this.m_Color.Value = Board.Get().m_ShadowColor;
		}

		// Token: 0x04008639 RID: 34361
		public FsmColor m_Color;
	}
}
