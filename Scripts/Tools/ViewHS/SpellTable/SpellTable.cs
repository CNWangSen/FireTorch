using System;
using System.Collections.Generic;
using UnityEngine;

public class SpellTable : MonoBehaviour
{
	// Token: 0x04010073 RID: 65651
	public List<SpellTableEntry> m_Table = new List<SpellTableEntry>();

	// Token: 0x04010074 RID: 65652
	private Dictionary<SpellType, SpellTableEntry> m_Entries;
}
