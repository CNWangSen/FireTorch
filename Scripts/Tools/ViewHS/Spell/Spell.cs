using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020008E1 RID: 2273
public class Spell : MonoBehaviour
{
	protected virtual void Awake()
	{
		//this.BuildSpellStateMap();
		//this.m_fsm = base.GetComponent<PlayMakerFSM>();
		//if (!string.IsNullOrEmpty(this.m_LocationTransformName))
		//{
		//	this.m_LocationTransformName = this.m_LocationTransformName.Trim();
		//}
	}

	// Token: 0x040063D8 RID: 25560
	public GameObject m_ObjectContainer;

	// Token: 0x040063E3 RID: 25571
	protected SpellType m_spellType;

	public PlayMakerFSM m_fsm;
}
