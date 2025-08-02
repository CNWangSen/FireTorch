using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000EA9 RID: 3753
	[ActionCategory("Pegasus")]
	[Tooltip("Initialize a spell state, setting a variable that references one of the Actor's game objects by name.")]
	public class SpellCustomActorVariable : FsmStateAction
	{
		// Token: 0x0600A341 RID: 41793 RVA: 0x00334C1F File Offset: 0x00332E1F
		public override void Reset()
		{
			this.m_objectName = "";
			this.m_actorObject = null;
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x00334C38 File Offset: 0x00332E38
		public override void OnEnter()
		{
			if (!this.m_actorObject.IsNone)
			{
				/*
				Actor actor = SceneUtils.FindComponentInThisOrParents<Actor>(base.Owner);
				if (actor != null)
				{
					GameObject gameObject = SceneUtils.FindChildBySubstring(actor.gameObject, this.m_objectName.Value);
					if (gameObject == null)
					{
						Debug.LogWarning("Could not find object of name " + this.m_objectName + " in actor");
					}
					else
					{
						this.m_actorObject.Value = gameObject;
					}
				}
				*/
			}
			base.Finish();
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x0000258D File Offset: 0x0000078D
		public override void OnUpdate()
		{
		}

		// Token: 0x04008745 RID: 34629
		public FsmString m_objectName;

		// Token: 0x04008746 RID: 34630
		public FsmGameObject m_actorObject;
	}
}
