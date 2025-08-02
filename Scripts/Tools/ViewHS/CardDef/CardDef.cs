using System;
using System.Collections.Generic;
//using Hearthstone.Package.AssetManager;
using UnityEngine;

// Token: 0x020007E7 RID: 2023
//[CustomEditClass]
public class CardDef : MonoBehaviour
{
	//public CardDefIdFinder m_GameObject;
	public string m_PortraitTexturePath;

	public string m_PremiumPortraitMaterialPath;
	public string m_PremiumUberShaderAnimationPath;
	public string m_PremiumPortraitTexturePath;

	public string m_SignaturePortraitTexturePath;
	public string m_SignaturePortraitMaterialPath;
	public string m_SignatureUberShaderAnimationPath;

	public CardEffectDef m_PlayEffectDef;
	public CardEffectDef m_AttackEffectDef;
	public CardEffectDef m_DeathEffectDef;
	public CardEffectDef m_LifetimeEffectDef;
	public List<CardEffectDef> m_TriggerEffectDefs;
	public List<CardEffectDef> m_SubSpellEffectDefs;
	
	public string m_CustomSummonSpellPath;
	public string m_CustomSpawnSpellPath;
	public string m_CustomDeathSpellPath;
	public string m_CustomDiscardSpellPath;

	public string m_SocketInEffectFriendly;
	public string m_SocketInEffectOpponent;
	public string m_SocketInEffectFriendlyPhone;
	public string m_SocketInEffectOpponentPhone;
	public bool m_SocketInOverrideHeroAnimation;
	public bool m_SocketInParentEffectToHero = true;

	public string m_DiamondModel;
	public string m_LegendaryModel;

	public string m_DiamondPlaneRTT_Play;
	public string m_DiamondBackground_Play;

}