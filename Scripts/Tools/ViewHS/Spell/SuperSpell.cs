using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpell : Spell
{
	public Spell m_CustomDeathSpell;
	public Spell m_SpellPrefab;
	public SpellStartInfo m_StartInfo;
	public SpellMissileInfo m_MissileInfo;
	public SpellImpactInfo m_ImpactInfo;
	
	public SpellAreaEffectInfo m_FriendlyAreaEffectInfo;
	public SpellAreaEffectInfo m_OpponentAreaEffectInfo;

	public SpellTargetInfo m_TargetInfo;
	//public SpellActionInfo m_ActionInfo;
	public SpellChainInfo m_ChainInfo;
	
	protected List<GameObject> m_visualTargets = new List<GameObject>();
}
