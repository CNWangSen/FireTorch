using System;
using System.Collections.Generic;

//BG30_101 防晒专家 <b>战斗开始时：</b>使你和你的对手最左边的3个随从获得<b>圣盾</b>。
//BG30_105 顽强的坐骑 <b>亡语：</b>召唤等级3，4和5的随机野兽各一只。

public class BG30_119:MinionBase{
	public override void OnCombatStart()
	{
		List<Card> ToGive = new List<Card>();
		List<string> Abis = new List<string>();
		foreach(Card c in owner.myPlayer.board.Exclude(owner))
		{
			if(c.raceType.Contains(RaceType.Pirate) || c.raceType.Contains(RaceType.All))
			{
				ToGive.Add(c);
				Abis.Add("BG30_119e");
			}
		}
		new EffectGiveAbility(owner.myPlayer,owner,targets:ToGive,abinames:Abis).Resolve();
	}
}
public class BG30_119e:Ability
{
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BGS_061"),ZoneType.Board);
	}
}
public class BG30_119_G:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		List<Card> ToGive = new List<Card>();
		List<string> Abis = new List<string>();
		foreach(Card c in owner.myPlayer.board.Exclude(owner))
		{
			if(c.raceType.Contains(RaceType.Pirate) || c.raceType.Contains(RaceType.All))
			{
				ToGive.Add(c);
				Abis.Add("BG30_119_Ge");
			}
		}
		new EffectGiveAbility(owner.myPlayer,owner,targets:ToGive,abinames:Abis).Resolve();
	}
}
public class BG30_119_Ge:Ability
{
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("TB_BaconUps_141"),ZoneType.Board);
	}
}