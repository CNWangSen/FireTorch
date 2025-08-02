using System.Collections;
using System.Collections.Generic;

public class BGS_001:MinionBase{
//NAME=纳斯雷兹姆监工
//TEXT=<b>战吼：</b>使一个友方恶魔获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		if(target.raceType.Contains(RaceType.Demon) || target.raceType.Contains(RaceType.All))
		{
			new EffectChange(owner.myPlayer,owner,target,atkChange:2,hpChange:2).Resolve();
		}
	}
}
public class BGS_001_G:MinionBase{
//NAME=纳斯雷兹姆监工
//TEXT=<b>战吼：</b>使一个友方恶魔获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		if(target.raceType.Contains(RaceType.Demon) || target.raceType.Contains(RaceType.All))
		{
			new EffectChange(owner.myPlayer,owner,target,atkChange:4,hpChange:4).Resolve();
		}
	}
}
public class BGS_001e:Ability{
//NAME=恶鬼缠身
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_002:MinionBase{
//NAME=灵魂杂耍者
//TEXT=在一个友方恶魔死亡后，随机对一个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					TaskDamageRandomEnemyMinion(3);
				}
			}
		}
	}
}
public class BGS_002_G:MinionBase{
//NAME=灵魂杂耍者
//TEXT=在一个友方恶魔死亡后，随机对一个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					TaskDamageRandomEnemyMinion(3);
					TaskDamageRandomEnemyMinion(3);
				}
			}
		}
	}
}
public class TB_BaconUps_075:MinionBase{
//NAME=灵魂杂耍者
//TEXT=在一个友方恶魔死亡后，随机对一个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					TaskDamageRandomEnemyMinion(3);
					TaskDamageRandomEnemyMinion(3);
				}
			}
		}
	}
}

public class BGS_004:MinionBase{
//NAME=愤怒编织者
//TEXT=在你使用一张恶魔牌后，对你的英雄造成1点伤害并获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				TaskDamageMyHero(1);
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:1).Resolve();
			}
		}
	}
}
public class BGS_004_G:MinionBase{
//NAME=愤怒编织者
//TEXT=在你使用一张恶魔牌后，对你的英雄造成1点伤害并获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				TaskDamageMyHero(1);
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:1).Resolve();
				TaskDamageMyHero(1);
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:1).Resolve();
			}
		}
	}
}
public class BGS_004e:Ability{
//NAME=织成愤怒
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_006:MinionBase{
//NAME=斯尼德的伐木机
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=7|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGSlegendaryDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_006_G:MinionBase{
//NAME=斯尼德的伐木机
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=7|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGSlegendaryDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGSlegendaryDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class TB_BaconUps_080:MinionBase{
//NAME=斯尼德的伐木机
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=7|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGSlegendaryDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGSlegendaryDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_008:MinionBase{
//NAME=阴森巨蟒
//TEXT=<b>亡语：</b>随机召唤 两个<b>亡语</b>随从。
//MAJ=PRIEST|COST=6|ATK=7|HP=7|RACE=BEAST
	public override void Deathrattle()
	{
		for(int i=0;i<2;i++)
		{
			int cnt=0;
			CardDbf ToSummon = null;
			while((ToSummon ==null) && cnt< 100)
			{
			 	CardDbf db = CardDbf.AllBGSdeathrattleDbf.Choice(owner.myPlayer.randomGen);
			 	if(db!=null)
			 	{
			 		if(db.m_noteMiniGuid[db.m_noteMiniGuid.Length-1]!='G')
			 		{
			 			ToSummon = db;
			 		}
			 		
			 	}
			 	cnt += 1;			
			}
			if(ToSummon!=null)
			{
				TaskCreate(ToSummon,ZoneType.Board);
			}
		 }
	}
}
public class BGS_008_G:MinionBase{
//NAME=阴森巨蟒
//TEXT=<b>亡语：</b>随机召唤 四个<b>亡语</b>随从。
//MAJ=PRIEST|COST=6|ATK=7|HP=7|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		for(int i=0;i<4;i++)
		{
			int cnt=0;
			CardDbf ToSummon = null;
			while((ToSummon ==null) && cnt< 100)
			{
			 	CardDbf db = CardDbf.AllBGSdeathrattleDbf.Choice(owner.myPlayer.randomGen);
			 	if(db!=null)
			 	{
			 		if(db.m_noteMiniGuid[db.m_noteMiniGuid.Length-1]!='G')
			 		{
			 			ToSummon = db;
			 		}
			 		
			 	}
			 	cnt += 1;			
			}
			if(ToSummon!=null)
			{
				TaskCreate(ToSummon,ZoneType.Board);
			}
		 }
	}
}
public class TB_BaconUps_057:MinionBase{
//NAME=阴森巨蟒
//TEXT=<b>亡语：</b>随机召唤 四个<b>亡语</b>随从。
//MAJ=PRIEST|COST=6|ATK=7|HP=7|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		for(int i=0;i<4;i++)
		{
			int cnt=0;
			CardDbf ToSummon = null;
			while((ToSummon ==null) && cnt< 100)
			{
			 	CardDbf db = CardDbf.AllBGSdeathrattleDbf.Choice(owner.myPlayer.randomGen);
			 	if(db!=null)
			 	{
			 		if(db.m_noteMiniGuid[db.m_noteMiniGuid.Length-1]!='G')
			 		{
			 			ToSummon = db;
			 		}
			 		
			 	}
			 	cnt += 1;			
			}
			if(ToSummon!=null)
			{
				TaskCreate(ToSummon,ZoneType.Board);
			}
		 }
	}
}

public class BGS_009:MinionBase{
//NAME=光牙执行者
//TEXT=在你的回合结束时，使每个类型的各一个友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			List<Card> ToListBuff = new List<Card>();
			List<RaceType> Already = new List<RaceType>();
			foreach(Card c in owner.myPlayer.board)
			{
				foreach(RaceType rc in c.raceType)
				{
					if(!Already.Contains(rc))
					{
						Already.Add(rc);
						ToListBuff.Add(c);
						break;
					}
				}
			}
			TaskBuffTargets(ToListBuff,atk:2,hp:2);
		}
	}
}

public class BGS_009_G:MinionBase{
//NAME=光牙执行者
//TEXT=在你的回合结束时，使每个类型的各一个友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			List<Card> ToListBuff = new List<Card>();
			List<RaceType> Already = new List<RaceType>();
			foreach(Card c in owner.myPlayer.board)
			{
				foreach(RaceType rc in c.raceType)
				{
					if(!Already.Contains(rc))
					{
						Already.Add(rc);
						ToListBuff.Add(c);
						break;
					}
				}
			}
			TaskBuffTargets(ToListBuff,atk:4,hp:4);
		}
	}
}
public class BGS_009e:Ability{
//NAME=祝福
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_010:MinionBase{
//NAME=安尼赫兰战场军官
//TEXT=<b>战吼：</b>你的英雄每缺失一点生命值，便获得+2生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=1|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.hero.Count>0)
		{
			Card H = owner.myPlayer.hero[0];
			new EffectChange(owner.myPlayer,owner,owner,hpChange:2*(H.cardDbf.MaxHealth-H.GetTag(GameTag.Health))).Resolve();
		}	
	}
}
public class BGS_010_G:MinionBase{
//NAME=安尼赫兰战场军官
//TEXT=<b>战吼：</b>你的英雄每缺失一点生命值，便获得+2生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=1|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.hero.Count>0)
		{
			Card H = owner.myPlayer.hero[0];
			new EffectChange(owner.myPlayer,owner,owner,hpChange:4*(H.cardDbf.MaxHealth-H.GetTag(GameTag.Health))).Resolve();
		}	
	}
}
public class BGS_010e:Ability{
//NAME=巨恶之力
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_012:MinionBase{
//NAME=坎格尔的学徒
//TEXT=<b>亡语：</b>召唤你本场战斗中最先死亡的 2个机械。
//MAJ=NEUTRAL|COST=9|ATK=3|HP=6|RACE=NONE
	public List<CardDbf> Deaths = new List<CardDbf>();
	public override void OnCombatStart()
	{
		Deaths.Clear();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer == owner.myPlayer && (sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All)))
			{
				Deaths.Add(sc.cardDbf);
			}
		}
	}
	public override void Deathrattle()
	{
		List<CardDbf> Mechs = new List<CardDbf>();
		foreach(CardDbf d in Deaths)
		{
			Mechs.Add(d);
		}
		CardDbf S1 = Mechs.Choice(owner.myPlayer.randomGen);
		if(S1!=null)
		{
			Mechs.Remove(S1);
			TaskCreate(S1,ZoneType.Board);
			CardDbf S2 = Mechs.Choice(owner.myPlayer.randomGen);
			if(S2!=null)
			{
				TaskCreate(S2,ZoneType.Board);
			}
		}
	}
}
public class BGS_012_G:MinionBase{
//NAME=坎格尔的学徒
//TEXT=<b>亡语：</b>召唤你本场战斗中最先死亡的 2个机械。
//MAJ=NEUTRAL|COST=9|ATK=3|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public List<CardDbf> Deaths = new List<CardDbf>();
	public override void OnCombatStart()
	{
		Deaths.Clear();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer == owner.myPlayer && (sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All)))
			{
				Deaths.Add(sc.cardDbf);
			}
		}
	}
	public override void Deathrattle()
	{
		List<CardDbf> Mechs = new List<CardDbf>();
		foreach(CardDbf d in Deaths)
		{
			Mechs.Add(d);
		}
		CardDbf S1 = Mechs.Choice(owner.myPlayer.randomGen);
		if(S1!=null)
		{
			Mechs.Remove(S1);
			TaskCreate(S1,ZoneType.Board);
			CardDbf S2 = Mechs.Choice(owner.myPlayer.randomGen);
			if(S2!=null)
			{
				TaskCreate(S2,ZoneType.Board);
				Mechs.Remove(S2);
				CardDbf S3 = Mechs.Choice(owner.myPlayer.randomGen);
				if(S3!=null)
				{
					TaskCreate(S3,ZoneType.Board);
					Mechs.Remove(S3);
					CardDbf S4 = Mechs.Choice(owner.myPlayer.randomGen);
					if(S4!=null)
					{
						TaskCreate(S4,ZoneType.Board);						
					}					
				}
			}
		}
	}
}
public class TB_BaconUps_087:MinionBase{
//NAME=坎格尔的学徒
//TEXT=<b>亡语：</b>召唤你本场战斗中最先死亡的 2个机械。
//MAJ=NEUTRAL|COST=9|ATK=3|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		List<CardDbf> Mechs = new List<CardDbf>();
		foreach(Card c in owner.myPlayer.grave)
		{
			if(c.cardType==CardType.Minion && (c.raceType.Contains(RaceType.Mechanical) || c.raceType.Contains(RaceType.All)))
			{
				if(Mechs.Count<4)
				{
					Mechs.Add(c.cardDbf);
				}
				else{
					break;
				}
			}
		}
		foreach(CardDbf db in Mechs)
		{
			TaskCreate(db,ZoneType.Board);
		}
	}
}

public class BGS_014:MinionBase{
//NAME=小鬼囚徒
//TEXT=<b>嘲讽，亡语：</b>召唤一个1/1的小鬼。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG_BRM_006t"),ZoneType.Board);
	}
}
public class TB_BaconUps_113:MinionBase{
//NAME=小鬼囚徒
//TEXT=<b>嘲讽，亡语：</b>召唤一个1/1的小鬼。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("TB_BaconUps_030t"),ZoneType.Board);
	}
}
public class TB_BaconUps_030t:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BGS_017:MinionBase{
//NAME=族群领袖
//TEXT=每当你召唤一个野兽，使其获得+2 攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:2).Resolve();
			}
		}
	}
}
public class BGS_017_G:MinionBase{
//NAME=族群领袖
//TEXT=每当你召唤一个野兽，使其获得+2 攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:4).Resolve();
			}
		}
	}
}
public class BGS_017e:Ability{
//NAME=野性呼唤
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_018:MinionBase{
//NAME=巨狼戈德林
//TEXT=<b>亡语：</b>在本场战斗的剩余时间内，你的野兽拥有+4/+4。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		//owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void Deathrattle()
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast))
			{
				//new EffectChange(owner.myPlayer,owner,c,atkChange:4,hpChange:4).Resolve();
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,atk:4,hp:4);
	}
}
public class BGS_018_G:MinionBase{
//NAME=巨狼戈德林
//TEXT=<b>亡语：</b>在本场战斗的剩余时间内，你的野兽拥有+4/+4。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast))
			{
				//new EffectChange(owner.myPlayer,owner,c,atkChange:4,hpChange:4).Resolve();
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,atk:8,hp:8);
	}
}
public class TB_BaconUps_085:MinionBase{
//NAME=巨狼戈德林
//TEXT=<b>亡语：</b>在本场战斗的剩余时间内，你的野兽拥有+4/+4。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast))
			{
				//new EffectChange(owner.myPlayer,owner,c,atkChange:4,hpChange:4).Resolve();
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,atk:8,hp:8);
	}
}
public class BGS_018e:Ability{
//NAME=猛兽之魂
//TEXT=仅在本场战斗中属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_018pe:Ability{
//NAME=戈德林玩家强化
//TEXT=在本场战斗的剩余时间内，你的野兽拥有的属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_019:MinionBase{
//NAME=红色雏龙
//TEXT=<b>战斗开始时：</b>随机对一个敌方随从造成等同于友方龙的数量的 伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=DRAGON
	public override void OnCombatStart()
	{
		TaskDamageRandomEnemyMinion(FindRace(owner.myPlayer.board,RaceType.Dragon).Count);
	}
}
public class TB_BaconUps_102:MinionBase{
//NAME=红色雏龙
//TEXT=<b>战斗开始时：</b>随机对一个敌方随从造成等同于友方龙的数量的 伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		TaskDamageRandomEnemyMinion(FindRace(owner.myPlayer.board,RaceType.Dragon).Count);
		TaskDamageRandomEnemyMinion(FindRace(owner.myPlayer.board,RaceType.Dragon).Count);
	}
}

public class BGS_020:MinionBase{
//NAME=蛮鱼斥候
//TEXT=<b>战吼：</b>如果你控制着其他鱼人，<b>发现</b>一张鱼人牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=2|RACE=MURLOC
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,TripleRewardCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void TripleRewardCauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner)
        {
            new EffectMove(owner.myPlayer, tc,ZoneType.Aside,ZoneType.Hand).Resolve();
            new EffectChange(owner.myPlayer,tc,tc,-tc.GetTag(GameTag.Mana),0,0,0).Resolve();
        }
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> Op=new List<Card>();
        
        List<CardDbf> Pool = CardDbf.AllBGSmurlocDbf;

        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
    }
}
public class BGS_020_G:MinionBase{
//NAME=蛮鱼斥候
//TEXT=<b>战吼：</b>如果你控制着其他鱼人，<b>发现</b>一张鱼人牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=2|RACE=MURLOC
	private int cnt = 0;
	public override void Init()
	{
		TaskSetGolden();
	}
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,TripleRewardCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void TripleRewardCauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner)
        {
            new EffectMove(owner.myPlayer, tc,ZoneType.Aside,ZoneType.Hand).Resolve();
            new EffectChange(owner.myPlayer,tc,tc,-tc.GetTag(GameTag.Mana),0,0,0).Resolve();
            if(cnt==0)
            {
            	cnt=1;
            	this.Battlecry(null);
            }
            else{
            	cnt=0;
            }
            
        }
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> Op=new List<Card>();
        
        List<CardDbf> Pool = CardDbf.AllBGSmurlocDbf;

        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
    }
}
public class BGS_021:MinionBase{
//NAME=熊妈妈
//TEXT=每当你召唤一只野兽，使其获得+4/+4。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:4,hpChange:4).Resolve();
			}
		}
	}
}
public class BGS_021_G:MinionBase{
//NAME=熊妈妈
//TEXT=每当你召唤一只野兽，使其获得+4/+4。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:8,hpChange:8).Resolve();
			}
		}
	}
}
public class TB_BaconUps_090:MinionBase{
//NAME=熊妈妈
//TEXT=每当你召唤一只野兽，使其获得+4/+4。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:8,hpChange:8).Resolve();
			}
		}
	}
}

public class BGS_021e:Ability{
//NAME=狂暴
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_022:MinionBase{
//NAME=扎普·斯里维克
//TEXT=<b>风怒</b> 本随从总会攻击攻击力最低的敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=11|HP=22|RACE=NONE
	private bool ReTarget=false;
	public override void Init()
	{
		//TaskInitAbility("WindFury");
	}
	public override void BeforeAttack(Card target=null)
	{	
		if(this.ReTarget)
		{
			return;
		}
		Card LeastAttack = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(LeastAttack==null)
			{
				LeastAttack=c;
			}
			else{
				if(c.GetTag(GameTag.Attack)<LeastAttack.GetTag(GameTag.Attack))
				{
					LeastAttack=c;
				}
			}
		}
		if(LeastAttack!=null)
		{
			this.ReTarget=true;
			new EffectAttack(owner.myPlayer,owner,LeastAttack).Resolve();
			if(owner.GetTag(GameTag.Health)>0)
			{
				Card LeastAttack2 = null;
				foreach(Card c in owner.myPlayer.otherPlayer.board)
				{
					if(LeastAttack2==null)
					{
						LeastAttack2=c;
					}
					else{
						if(c.GetTag(GameTag.Attack)<LeastAttack2.GetTag(GameTag.Attack))
						{
							LeastAttack2=c;
						}
					}
				}
				if(LeastAttack2!=null)
				{
					this.ReTarget=true;
					new EffectAttack(owner.myPlayer,owner,LeastAttack2).Resolve();
				}
			}
			
		}
		this.ReTarget=false;
		owner.SetTag(GameTag.IsCanceled,1);
		owner.SetTag(GameTag.AttacksLeftThisTurn,0);
	}
}
public class BGS_022_G:MinionBase{
//NAME=扎普·斯里维克
//TEXT=<b>风怒</b> 本随从总会攻击攻击力最低的敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=11|HP=22|RACE=NONE
	private bool ReTarget=false;
	public override void Init()
	{
		TaskSetGolden();
		//TaskInitAbility("WindFury");
	}
	public override void BeforeAttack(Card target=null)
	{
		if(this.ReTarget)
		{
			return;
		}
		Card LeastAttack = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(LeastAttack==null)
			{
				LeastAttack=c;
			}
			else{
				if(c.GetTag(GameTag.Attack)<LeastAttack.GetTag(GameTag.Attack))
				{
					LeastAttack=c;
				}
			}
		}
		if(LeastAttack!=null)
		{
			this.ReTarget=true;
			new EffectAttack(owner.myPlayer,owner,LeastAttack).Resolve();
			if(owner.GetTag(GameTag.Health)>0)
			{
				Card LeastAttack2 = null;
				foreach(Card c in owner.myPlayer.otherPlayer.board)
				{
					if(LeastAttack2==null)
					{
						LeastAttack2=c;
					}
					else{
						if(c.GetTag(GameTag.Attack)<LeastAttack2.GetTag(GameTag.Attack))
						{
							LeastAttack2=c;
						}
					}
				}
				if(LeastAttack2!=null)
				{
					this.ReTarget=true;
					new EffectAttack(owner.myPlayer,owner,LeastAttack2).Resolve();
				}
			}
			
		}
		this.ReTarget=false;
		owner.SetTag(GameTag.IsCanceled,1);
		owner.SetTag(GameTag.AttacksLeftThisTurn,0);
	}
}

public class TB_BaconUps_091:MinionBase{
//NAME=扎普·斯里维克
//TEXT=<b>风怒</b> 本随从总会攻击攻击力最低的敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=11|HP=22|RACE=NONE
	private bool ReTarget=false;
	public override void Init()
	{
		TaskSetGolden();
		//TaskInitAbility("WindFury");
	}
	public override void BeforeAttack(Card target=null)
	{
		if(this.ReTarget)
		{
			return;
		}
		Card LeastAttack = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(LeastAttack==null)
			{
				LeastAttack=c;
			}
			else{
				if(c.GetTag(GameTag.Attack)<LeastAttack.GetTag(GameTag.Attack))
				{
					LeastAttack=c;
				}
			}
		}
		if(LeastAttack!=null)
		{
			this.ReTarget=true;
			new EffectAttack(owner.myPlayer,owner,LeastAttack).Resolve();
			if(owner.GetTag(GameTag.Health)>0)
			{
				Card LeastAttack2 = null;
				foreach(Card c in owner.myPlayer.otherPlayer.board)
				{
					if(LeastAttack2==null)
					{
						LeastAttack2=c;
					}
					else{
						if(c.GetTag(GameTag.Attack)<LeastAttack2.GetTag(GameTag.Attack))
						{
							LeastAttack2=c;
						}
					}
				}
				if(LeastAttack2!=null)
				{
					this.ReTarget=true;
					new EffectAttack(owner.myPlayer,owner,LeastAttack2).Resolve();
				}
			}
			
		}
		this.ReTarget=false;
		owner.SetTag(GameTag.IsCanceled,1);
		owner.SetTag(GameTag.AttacksLeftThisTurn,0);
	}
}

public class BGS_023:MinionBase{
//NAME=载人收割机
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS2Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_023_G:MinionBase{
//NAME=载人收割机
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS2Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS2Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class TB_BaconUps_035:MinionBase{
//NAME=载人收割机
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS2Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS2Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_024:MinionBase{
//NAME=载人飞天魔像
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS4Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_024_G:MinionBase{
//NAME=载人飞天魔像
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS4Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS4Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class TB_BaconUps_050:MinionBase{
//NAME=载人飞天魔像
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS4Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS4Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_025:MinionBase{
//NAME=骑乘迅猛龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=BEAST
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS1Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_025_G:MinionBase{
//NAME=骑乘迅猛龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS1Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS1Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class TB_BaconUps_019:MinionBase{
//NAME=骑乘迅猛龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.AllBGS1Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		TaskCreate(CardDbf.AllBGS1Dbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
	}
}
public class BGS_027:MinionBase{
//NAME=微型战斗机甲
//TEXT=在每个回合开始时，获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
			new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
	}
}
public class BGS_027_G:MinionBase{
//NAME=微型战斗机甲
//TEXT=在每个回合开始时，获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
			new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
	}
}
public class BGS_028:MinionBase{
//NAME=蹦蹦兔
//TEXT=<b>战吼：</b>在本局对战中，你每使用过一张其他蹦蹦兔，便获得+2/+2。
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=MECHANICAL
	public static int CNT = 0;
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:BGS_028.CNT*2,hpChange:BGS_028.CNT*2);
		BGS_028.CNT+=1;
	}
}
public class BGS_028_G:MinionBase{
//NAME=蹦蹦兔
//TEXT=<b>战吼：</b>在本局对战中，你每使用过一张其他蹦蹦兔，便获得+2/+2。
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=MECHANICAL
	public static int CNT = 0;
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:BGS_028.CNT*4,hpChange:BGS_028.CNT*4);
		BGS_028.CNT+=1;
	}
}
public class BGS_028e:Ability{
//NAME=动能
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_028pe:Ability{
//NAME=PogoCounterEnchantment
//TEXT=Counts the number of Pogo-Hoppers played.
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_029:MinionBase{
//NAME=百变泽鲁斯
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张随从牌。保留附加效果。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BGS_029_G:MinionBase{
//NAME=百变泽鲁斯
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张随从牌。保留附加效果。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BGS_029e:Ability{
//NAME=变换色彩
//TEXT=随机变成一张龙牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_030:MinionBase{
//NAME=拜戈尔格国王
//TEXT=<b>战吼：</b>使你的其他鱼人获得+3/+3。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=3|RACE=MURLOC
}
public class BGS_030e:Ability{
//NAME=追随国王
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_031:MinionBase{
//NAME=温顺的巨壳龙
//TEXT=<b>战吼：</b><b>进化</b>你所有的鱼人。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
	public override void Battlecry(Card target=null)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Murloc),atk:3);
	}
}
public class BGS_031_G:MinionBase{
//NAME=温顺的巨壳龙
//TEXT=<b>战吼：</b><b>进化</b>你所有的鱼人。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
	public override void Battlecry(Card target=null)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Murloc),atk:3);
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Murloc),hp:4);
	}
}
public class BGS_032:MinionBase{
//NAME=火焰传令官
//TEXT=<b>超杀：</b>对最左边的敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=DRAGON
	public override void OverKill(Card target=null,int amount=0)
	{
		Card LeftMost = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)>0)
			{
				LeftMost=c;
				break;
			}
		}
		if(LeftMost!=null)
		{

			new EffectDamage(owner.myPlayer,owner,LeftMost,3).Resolve();
		}
	}
}
public class TB_BaconUps_103:MinionBase{
//NAME=火焰传令官
//TEXT=<b>超杀：</b>对最左边的敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OverKill(Card target=null,int amount=0)
	{
		Card LeftMost = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)>0)
			{
				LeftMost=c;
				break;
			}
		}
		if(LeftMost!=null)
		{

			new EffectDamage(owner.myPlayer,owner,LeftMost,6).Resolve();
		}
	}
}
public class BGS_033:MinionBase{
//NAME=急饿巨龙
//TEXT=在你的回合开始时，如果你在上一场战斗中获胜，则获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=DRAGON
}
public class BGS_033e1:Ability{
//NAME=进食充分
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_034:MinionBase{
//NAME=青铜守卫
//TEXT=<b>圣盾，复生</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=1|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("DivineShield");
		TaskInitAbility("Reborn");
	}
}
public class TB_BaconUps_149:MinionBase{
//NAME=青铜守卫
//TEXT=<b>圣盾，复生</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=1|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
		TaskInitAbility("Reborn");
	}
}

public class BGS_035:MinionBase{
//NAME=蜡烛骑士托瓦格尔
//TEXT=每当一条友方的龙消灭一个敌人，便获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
}
public class BGS_035e:Ability{
//NAME=巨龙之蜡
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_036:MinionBase{
//NAME=狂野的拉佐格尔
//TEXT=在你的回合结束时，每有一条其他的友方的龙，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=DRAGON
}
public class BGS_036e:Ability{
//NAME=龙人狂怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_037:MinionBase{
//NAME=时间管理者
//TEXT=当你出售本随从时，使酒馆中的所有随从获得+2/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=DRAGON
}
public class BGS_037e:Ability{
//NAME=时间延长
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_038:MinionBase{
//NAME=暮光使者
//TEXT=<b>嘲讽，战吼：</b>使一条友方的龙获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=3|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BGS_038e:Ability{
//NAME=暮光之拥
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_039:MinionBase{
//NAME=龙兽军官
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BGS_040:MinionBase{
//NAME=红衣纳迪娜
//TEXT=<b>亡语：</b>使3条友方的龙获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=4|RACE=NONE
	public override void Deathrattle()
	{
		List<Card> ToListBuff = FindRace(owner.myPlayer.board,RaceType.Dragon);
		for(int i=0;i<3;i++)
		{
			Card ToBuff = ToListBuff.Choice(owner.myPlayer.randomGen);
			if(ToBuff!=null)
			{
				new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DivineShield").Resolve();
				ToListBuff.Remove(ToBuff);
			}
		}
	}
}
public class TB_BaconUps_154:MinionBase{
//NAME=红衣纳迪娜
//TEXT=<b>亡语：</b>使3条友方的龙获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		List<Card> ToListBuff = FindRace(owner.myPlayer.board,RaceType.Dragon);
		for(int i=0;i<6;i++)
		{
			Card ToBuff = ToListBuff.Choice(owner.myPlayer.randomGen);
			if(ToBuff!=null)
			{
				new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DivineShield").Resolve();
				ToListBuff.Remove(ToBuff);
			}
		}
	}
}
public class BGS_041:MinionBase{
//NAME=奥术守护者卡雷苟斯
//TEXT=在你触发一个<b>战吼</b>后，使你的龙获得+1/+1。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class BGS_041e:Ability{
//NAME=奥术守护者
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_043:MinionBase{
//NAME=姆诺兹多
//TEXT=<b>战吼：</b>获取你上一个对手的战队中一个随从的一张原始版复制。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=5|RACE=DRAGON
}
public class BGS_044:MinionBase{
//NAME=小鬼妈妈
//TEXT=每当本随从受到伤害，随机召唤一个恶魔并使其获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=10|RACE=DEMON
	public override void AfterTakeDamage(Card source=null,int amount=0)
	{
		if(owner.GetTag(GameTag.Health)>0 && CondInPlay())
		{
			Card Summon = TaskCreate(CardDbf.AllBGSdemonDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
			new EffectGiveAbility(owner.myPlayer,owner,Summon,"Taunt").Resolve();
		}
	}
}
public class TB_BaconUps_116:MinionBase{
//NAME=小鬼妈妈
//TEXT=每当本随从受到伤害，随机召唤一个恶魔并使其获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=10|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterTakeDamage(Card source=null,int amount=0)
	{
		if(owner.GetTag(GameTag.Health)>0 && CondInPlay())
		{
			Card Summon = TaskCreate(CardDbf.AllBGSdemonDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
			new EffectGiveAbility(owner.myPlayer,owner,Summon,"Taunt").Resolve();
			Card Summon2 = TaskCreate(CardDbf.AllBGSdemonDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
			new EffectGiveAbility(owner.myPlayer,owner,Summon2,"Taunt").Resolve();
		}
	}
}

public class BGS_044e:Ability{
//NAME=保护鬼母！
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_045:MinionBase{
//NAME=雕文护卫者
//TEXT=每当本随从攻击时，其攻击力翻倍。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=DRAGON
	public override void BeforeAttack(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:owner.GetTag(GameTag.Attack)).Resolve();
	}
}
public class TB_BaconUps_115:MinionBase{
//NAME=雕文护卫者
//TEXT=每当本随从攻击时，其攻击力翻倍。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void BeforeAttack(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:2*owner.GetTag(GameTag.Attack)).Resolve();
	}
}

public class BGS_045e:Ability{
//NAME=冰冷之息
//TEXT=攻击力成倍提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_046:MinionBase{
//NAME=“钓鱼王”纳特·帕格
//TEXT=当本随从攻击并消灭一个随从时，随机获取一张随从牌。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=5|RACE=PIRATE
}
public class BGS_046t:MinionBase{
//NAME=宝箱
//TEXT=<b>亡语：</b>随机召唤一个金色随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=2|RACE=NONE
}
public class BGS_047:MinionBase{
//NAME=亡灵舰长伊丽扎
//TEXT=每当一个友方随从攻击时，使你的随从获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=PIRATE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer && sc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				TaskBuffTargets(owner.myPlayer.board,atk:1,hp:1);
			}
		}
	}
}
public class TB_BaconUps_134:MinionBase{
//NAME=亡灵舰长伊丽扎
//TEXT=每当一个友方随从攻击时，使你的随从获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer && sc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				TaskBuffTargets(owner.myPlayer.board,atk:2,hp:2);
			}
		}
	}
}
public class BGS_047e:Ability{
//NAME=呀哈！！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_048:MinionBase{
//NAME=南海勇夫
//TEXT=<b>战吼：</b>使一个友方海盗获得+1/+1。在本回合中你每购买过一个海盗，重复一次。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=PIRATE
}
public class BGS_048e:Ability{
//NAME=海盗刺青
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_049:MinionBase{
//NAME=白赚赌徒
//TEXT=出售本随从可以获得3枚铸币。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=PIRATE
}
public class BGS_053:MinionBase{
//NAME=血帆炮手
//TEXT=<b>战吼：</b>使你的其他海盗获得+3攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=PIRATE
}
public class BGS_053e:Ability{
//NAME=海盗人生
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_055:MinionBase{
//NAME=甲板杂兵
//TEXT=<b>战吼：</b>升级酒馆所需的铸币减少（1）枚。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=PIRATE
}
public class BGS_056:MinionBase{
//NAME=撕心狼队长
//TEXT=每当一个友方海盗攻击时，使其获得+3攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=PIRATE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer && (sc.raceType.Contains(RaceType.Pirate) || sc.raceType.Contains(RaceType.All)))
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:3).Resolve();
			}
		}
	}	
}
public class TB_BaconUps_139:MinionBase{
//NAME=撕心狼队长
//TEXT=每当一个友方海盗攻击时，使其获得+3攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer && (sc.raceType.Contains(RaceType.Pirate) || sc.raceType.Contains(RaceType.All)))
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:6).Resolve();
			}
		}
	}	
}
public class BGS_056e:Ability{
//NAME=撕心狼嚎
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_059:MinionBase{
//NAME=灵魂吞噬者
//TEXT=<b>战吼：</b>吞食一个友方恶魔，获得其属性值和3枚铸币。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=DEMON
}
public class BGS_059e:Ability{
//NAME=吞噬灵魂
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_060:MinionBase{
//NAME=喊号食人魔
//TEXT=<b>嘲讽</b> 在本随从受到攻击并存活下来后，你最左边的随从立即发起攻击。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=7|RACE=PIRATE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void AfterAttacked(Card source)
	{
		if(owner.GetTag(GameTag.Health)>0 && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
		{
			Card LeftMost = null;
			foreach(Card c in owner.myPlayer.board)
			{
				LeftMost=c;
				break;
			}
			if(LeftMost!=null)
			{
				Card ToAttack = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
				if(ToAttack!=null)
				{
					new EffectAttack(owner.myPlayer,LeftMost,ToAttack).Resolve();
				}
			}
		}
	}
}
public class TB_BaconUps_150:MinionBase{
//NAME=喊号食人魔
//TEXT=<b>嘲讽</b> 在本随从受到攻击并存活下来后，你最左边的随从立即发起攻击。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=7|RACE=PIRATE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void AfterAttacked(Card source)
	{
		if(owner.GetTag(GameTag.Health)>0 && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
		{
			Card LeftMost = null;
			foreach(Card c in owner.myPlayer.board)
			{
				LeftMost=c;
				break;
			}
			if(LeftMost!=null)
			{
				Card ToAttack = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
				if(ToAttack!=null)
				{
					new EffectAttack(owner.myPlayer,LeftMost,ToAttack).Resolve();
				}
			}
		}
	}
}
public class BGS_061:MinionBase{
//NAME=海盗无赖
//TEXT=<b>亡语：</b>召唤一个1/1的海盗并使其立即发起攻击。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=1|RACE=PIRATE
	public override void Deathrattle()
	{
		Card Summon = TaskCreate(CardDbf.GetCardDbfByGuid("BGS_061t"),ZoneType.Board);
		if(Summon.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
		{
			Card ToAttack = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
			if(ToAttack!=null)
			{
				new EffectChange(owner.myPlayer,owner,Summon).Resolve();
				new EffectAttack(owner.myPlayer,Summon,ToAttack).Resolve();
			}
		}
	}
}
public class TB_BaconUps_141:MinionBase{
//NAME=海盗无赖
//TEXT=<b>亡语：</b>召唤一个1/1的海盗并使其立即发起攻击。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=1|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		Card Summon = TaskCreate(CardDbf.GetCardDbfByGuid("TB_BaconUps_141t"),ZoneType.Board);
		if(Summon.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
		{
			Card ToAttack = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
			if(ToAttack!=null)
			{
				new EffectChange(owner.myPlayer,owner,Summon).Resolve();
				new EffectAttack(owner.myPlayer,Summon,ToAttack).Resolve();
			}
		}
	}
}
public class BGS_061t:MinionBase{
//NAME=空中海盗
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=PIRATE
}
public class TB_BaconUps_141t:MinionBase{
//NAME=空中海盗
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BGS_066:MinionBase{
//NAME=掘金者
//TEXT=在你的回合结束时，你每有一个金色友方随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=PIRATE
}
public class BGS_066e:Ability{
//NAME=掘金
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_067:MinionBase{
//NAME=龙人执行者
//TEXT=在一个友方随从失去<b>圣盾</b>后，获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=7|RACE=DRAGON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sourceCard, string Abiname)
	{
		if(CondInPlay())
		{
			if(Abiname=="DivineShield")
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
			}
		}	
	}
}
public class TB_BaconUps_117:MinionBase{
//NAME=龙人执行者
//TEXT=在一个友方随从失去<b>圣盾</b>后，获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=7|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sourceCard, string Abiname)
	{
		if(CondInPlay())
		{
			if(Abiname=="DivineShield")
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:4).Resolve();
			}
		}	
	}
}
public class BGS_067e:Ability{
//NAME=神圣之力
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_069:MinionBase{
//NAME=融合巨怪
//TEXT=<b>战吼：</b>每有一个不同的友方随从类型，随机<b>进化</b>一次。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=ALL
}
public class BGS_071:MinionBase{
//NAME=偏折机器人
//TEXT=<b>圣盾</b> 在战斗阶段中，每当你召唤一个机械，便获得+2攻击力和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
				new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
			}
		}
	}
}
public class TB_BaconUps_123:MinionBase{
//NAME=偏折机器人
//TEXT=<b>圣盾</b> 在战斗阶段中，每当你召唤一个机械，便获得+2攻击力和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
				new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
			}
		}
	}
}
public class BGS_071e:Ability{
//NAME=偏折机器人
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_072:MinionBase{
//NAME=霍格船长
//TEXT=每当你购买一个海盗，获得1枚铸币。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=PIRATE
}
public class BGS_075:MinionBase{
//NAME=暴怒的巨蜥
//TEXT=在你使用一张<b>亡语</b>随从牌后，获得+1/+2。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class BGS_075e:Ability{
//NAME=狂暴
//TEXT=+1/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_077:MinionBase{
//NAME=奥术火炮
//TEXT=无法攻击。在一个相邻的随从攻击后，对一个敌方随从造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("CanNotAttack");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			List<Card> Adj = FindAdj(owner);
			if(Adj.Contains(sc))
			{
				TaskDamageRandomEnemyMinion(2);
			}
		}
	}
}
public class TB_BaconUps_128:MinionBase{
//NAME=奥术火炮
//TEXT=无法攻击。在一个相邻的随从攻击后，对一个敌方随从造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("CanNotAttack");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			List<Card> Adj = FindAdj(owner);
			if(Adj.Contains(sc))
			{
				TaskDamageRandomEnemyMinion(2);
				TaskDamageRandomEnemyMinion(2);
			}
		}
	}
}
public class BGS_078:MinionBase{
//NAME=巨大的金刚鹦鹉
//TEXT=在本随从攻击后，触发你最左边的<b>亡语</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=BEAST
	public override void AfterAttack(Card target)
	{
		Card LeftDR = null;
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.HasAbility("Deathrattle"))
			{
				LeftDR=c;
				break;
			}
		}
		if(LeftDR!=null)
		{
            if (LeftDR.abilityList.Count != 0)
            {
                for (int j = 0; j < LeftDR.abilityList.Count; j++)
                {
                    LeftDR.abilityList[j].Deathrattle();
                }
            }
		}
	}
}
public class TB_BaconUps_135:MinionBase{
//NAME=巨大的金刚鹦鹉
//TEXT=在本随从攻击后，触发你最左边的<b>亡语</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterAttack(Card target)
	{
		for(int i=0;i<2;i++)
		{
			Card LeftDR = null;
			foreach(Card c in owner.myPlayer.board)
			{
				if(c.HasAbility("Deathrattle"))
				{
					LeftDR=c;
					break;
				}
			}
			if(LeftDR!=null)
			{
	            if (LeftDR.abilityList.Count != 0)
	            {
	                for (int j = 0; j < LeftDR.abilityList.Count; j++)
	                {
	                    LeftDR.abilityList[j].Deathrattle();
	                }
	            }
			}			
		}
	}
}
public class BGS_079:MinionBase{
//NAME=海浪剃刀号
//TEXT=<b>亡语：</b>随机召唤三个海盗。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=4|RACE=NONE
	public override void Deathrattle()
	{
		for(int i=0;i<3;i++)
		{
			TaskCreate(CardDbf.AllBGSpirateDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		}
	}
}
public class TB_BaconUps_137:MinionBase{
//NAME=海浪剃刀号
//TEXT=<b>亡语：</b>随机召唤三个海盗。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		for(int i=0;i<6;i++)
		{
			TaskCreate(CardDbf.AllBGSpirateDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		}
	}
}
public class BGS_080:MinionBase{
//NAME=破浪巨人
//TEXT=<b>风怒，超杀：</b>使你的其他海盗获得+2/+2。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=PIRATE
	public override void Init()
	{
		TaskInitAbility("WindFury");
	}
	public override void OverKill(Card target = null, int amount = 0)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Pirate),atk:2,hp:2);
	}
}
public class TB_BaconUps_142:MinionBase{
//NAME=破浪巨人
//TEXT=<b>风怒，超杀：</b>使你的其他海盗获得+2/+2。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("WindFuryPro");
	}
	public override void OverKill(Card target = null, int amount = 0)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Pirate),atk:4,hp:4);
	}
}
public class BGS_080e:Ability{
//NAME=劈波斩浪
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_081:MinionBase{
//NAME=海上掠夺者
//TEXT=每当你使用一张海盗牌时，获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=PIRATE
}
public class BGS_081e:Ability{
//NAME=夺宝！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_082:MinionBase{
//NAME=展馆茶杯
//TEXT=<b>战吼：</b>使3个属于不同类型的友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class BGS_082e:Ability{
//NAME=茗碗一啜
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_083:MinionBase{
//NAME=展馆茶壶
//TEXT=<b>战吼：</b>使3个属于不同类型的友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BGS_083e:Ability{
//NAME=解渴痛饮
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_100:MinionBase{
//NAME=小拉格
//TEXT=在你使用一张元素牌后，使一个友方随从获得等同于该元素等级的属性值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class BGS_100e:Ability{
//NAME=小小炎魔之手
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_104:MinionBase{
//NAME=“厨房煞星”诺米
//TEXT=在你使用一张元素牌后，酒馆中的元素在本局对战中拥有+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class BGS_104e1:Ability{
//NAME=酒馆盛宴
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_104pe:Ability{
//NAME=诺米玩家强化
//TEXT=“厨房煞星”诺米使酒馆中的元素属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_105:MinionBase{
//NAME=管理者埃克索图斯
//TEXT=在你的回合结束时，使你最左边的随从获得+1/+1。在本回合中你每使用过一张元素牌，就重复一次。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=3|RACE=NONE
}
public class BGS_105e:Ability{
//NAME=炎魔之王的护盾
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_106:MinionBase{
//NAME=克苏恩侍战者
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=3|RACE=NONE
}
public class BGS_110:MinionBase{
//NAME=帝国之手
//TEXT=每当一个友方<b>嘲讽</b>随从受到攻击时，使其永久获得+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		//owner.myPlayer.AddCallBack(new CallBackAfterAttack)
	}
}
public class BGS_110e:Ability{
//NAME=武装完毕！
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_111:MinionBase{
//NAME=亚煞极的勇士
//TEXT=每当一个友方<b>嘲讽</b>随从受到攻击时，便永久获得+1/+2。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class BGS_111e:Ability{
//NAME=亚煞极！！
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_112:MinionBase{
//NAME=其拉传令官
//TEXT=在一个友方<b>嘲讽</b>随从死亡后，使其相邻的随从获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class BGS_112e:Ability{
//NAME=预言者的幻象
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_113:MinionBase{
//NAME=无面酒客
//TEXT=<b>战吼：</b>选择一个酒馆中的随从，变形成为它的原始版复制。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class BGS_115:MinionBase{
//NAME=商贩元素
//TEXT=当你出售 本随从时，获取一张3/3的元素牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BGS_115t:MinionBase{
//NAME=水滴元素
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BGS_115t_G:MinionBase{
//NAME=水滴元素
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=6|HP=6|RACE=ELEMENTAL
}
public class BGS_116:MinionBase{
//NAME=刷新畸体
//TEXT=<b>战吼：</b>你下一次<b>刷新</b>酒馆的消耗为（0）枚铸币。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=ELEMENTAL
}
public class BGS_116e:Ability{
//NAME=消耗为0
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_119:MinionBase{
//NAME=爆裂飓风
//TEXT=<b>圣盾，风怒</b>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
		TaskInitAbility("WindFury");
	}
}
public class TB_BaconUps_159:MinionBase{
//NAME=爆裂飓风
//TEXT=<b>圣盾，风怒</b>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
		TaskInitAbility("WindFury");
	}
}
public class BGS_120:MinionBase{
//NAME=派对元素
//TEXT=在你使用一张元素牌后，使一个被使用的元素之外的友方元素获得+2/+1。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
}
public class BGS_120e:Ability{
//NAME=派对时间
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_121:MinionBase{
//NAME=温和的灯神
//TEXT=<b>嘲讽</b>。<b>亡语：</b>召唤并获取一个随机元素。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class TB_BaconUps_165:MinionBase{
//NAME=温和的灯神
//TEXT=<b>嘲讽</b>。<b>亡语：</b>召唤并获取一个随机元素。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BGS_122:MinionBase{
//NAME=静滞元素
//TEXT=<b>战吼：</b>随机在酒馆中添加一个元素并使其<b>冻结</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class BGS_123:MinionBase{
//NAME=酒馆旋风
//TEXT=<b>战吼：</b>随机获取一张元素牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=ELEMENTAL
}
public class BGS_124:MinionBase{
//NAME=炎魔副官加尔
//TEXT=<b>嘲讽</b> 在你使用一张元素牌后，每有一个友方元素，便获得+1生命值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class TB_BaconUps_163:MinionBase{
//NAME=炎魔副官加尔
//TEXT=<b>嘲讽</b> 在你使用一张元素牌后，每有一个友方元素，便获得+1生命值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BGS_124e:Ability{
//NAME=防护有加
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_126:MinionBase{
//NAME=野火元素
//TEXT=在本随从攻击并消灭一个随从后，对一个相邻的随从造成超过目标生命值的伤害。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=3|RACE=ELEMENTAL
	private Card rem;
	public override void BeforeAttack(Card target=null)
	{
		rem = FindAdj(target).Choice(owner.myPlayer.randomGen);
	}
	public override void AfterAttack(Card target=null)
	{
		if(target.GetTag(GameTag.Health)<0)
		{
			if(rem!=null)
			{
				new EffectDamage(owner.myPlayer,owner,rem,-target.GetTag(GameTag.Health)).Resolve();
			}
		}
	}
}
public class TB_BaconUps_166:MinionBase{
//NAME=野火元素
//TEXT=在本随从攻击并消灭一个随从后，对一个相邻的随从造成超过目标生命值的伤害。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=3|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
	}
	private List<Card> rem;
	public override void BeforeAttack(Card target=null)
	{
		rem = FindAdj(target);
	}
	public override void AfterAttack(Card target=null)
	{
		if(target.GetTag(GameTag.Health)<0)
		{
			if(rem!=null)
			{
				TaskDamageTargets(rem,-target.GetTag(GameTag.Health));
			}
		}
	}
}

public class BGS_127:MinionBase{
//NAME=熔融岩石
//TEXT=在你使用一张元素牌后，获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BGS_127e:Ability{
//NAME=熔岩之盾
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_128:MinionBase{
//NAME=奥术助手
//TEXT=<b>战吼：</b>使你的其他元素获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BGS_128e:Ability{
//NAME=元素能量
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_131:MinionBase{
//NAME=致命的孢子
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=NONE
	public override void RegisterEventEffect()
	{
		TaskInitAbility("Poisonous");
	}
}
public class BGS_200:MinionBase{
//NAME=古神的卫士
//TEXT=<b>亡语：</b>获取一张铸币牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NAGA
}
public class BGS_201:MinionBase{
//NAME=被折磨的祭师
//TEXT=<b>嘲讽</b> 每当本随从受到攻击时，使相邻的随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void BeforeAttacked(Card source)
	{
		TaskBuffTargets(FindAdj(owner),atk:1,hp:1);
	}
}
public class TB_BaconUps_257:MinionBase{
//NAME=被折磨的祭师
//TEXT=<b>嘲讽</b> 每当本随从受到攻击时，使相邻的随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
	public override void BeforeAttacked(Card source)
	{
		TaskBuffTargets(FindAdj(owner),atk:2,hp:2);
	}
}
public class BGS_201e:Ability{
//NAME=仪式献祭
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_202:MinionBase{
//NAME=拆解者米斯拉克斯
//TEXT=在你的回合结束时，每有一个不同的友方随从类型，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class BGS_202e:Ability{
//NAME=虚空回响
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_204:MinionBase{
//NAME=鬼狱火
//TEXT=在你召唤一个恶魔后，便永久获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay() && tz==ZoneType.Board)
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:1,hpChange:1).Resolve();
			}
		}
	}
}
public class TB_BaconUps_304:MinionBase{
//NAME=鬼狱火
//TEXT=在你召唤一个恶魔后，便永久获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay() && tz==ZoneType.Board)
		{
			if(sc.raceType.Contains(RaceType.Demon) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
			}
		}
	}
}
public class BGS_204e:Ability{
//NAME=小鬼长大了！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_205:MinionBase{
//NAME=永恒者艾丽斯特拉
//TEXT=<b>圣盾</b>，<b>复生</b> 每当一个友方<b>嘲讽</b>随从受到攻击时，改为本随从受到攻击。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("DivineShield");
		TaskInitAbility("Reborn");
	}
	
}
public class BGS_Treasures_000:SpellBase{
//NAME=大香蕉
//TEXT=使一个随从获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_000e:Ability{
//NAME=大香蕉
//TEXT=拥有+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_001:SpellBase{
//NAME=压袋零钱
//TEXT=获取2张铸币牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_003:SpellBase{
//NAME=日常折扣
//TEXT=升级酒馆所需的铸币减少（3）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_004:SpellBase{
//NAME=抽卡赠礼
//TEXT=<b>发现</b>一个<b>等级1</b>的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_006:SpellBase{
//NAME=酒馆异变
//TEXT=将酒馆中的所有随从替换为高一级的随从。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_007:SpellBase{
//NAME=暴风城之力
//TEXT=随机使三个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_007e:Ability{
//NAME=暴风城之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_009:SpellBase{
//NAME=格鲁尔的威力
//TEXT=使一个友方随从获得“在你的回合结束时，获得+2/+2。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_009e:Ability{
//NAME=格鲁尔的威力
//TEXT=在你的回合结束时获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_010:SpellBase{
//NAME=时光飞贼
//TEXT=从你上一个对手的战队中<b>发现</b>一个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_011:SpellBase{
//NAME=重新训练
//TEXT=<b>发现</b>一个新的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_012:SpellBase{
//NAME=免费酬宾
//TEXT=<b>发现</b>一个你当前<b>等级</b>的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_013:SpellBase{
//NAME=珍藏好酒
//TEXT=在本局对战中，酒馆中的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_013e1:Ability{
//NAME=好酒
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_013pe:Ability{
//NAME=珍藏好酒玩家强化
//TEXT=珍藏好酒使酒馆中的随从攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_014:SpellBase{
//NAME=无穷铸币
//TEXT=获得1枚铸币。在回合结束时，将该牌移回你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_014e:Ability{
//NAME=无穷铸币返回手牌
//TEXT=在回合结束时，将无穷铸币移回你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_015:SpellBase{
//NAME=圣光在售
//TEXT=使一个友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_016:SpellBase{
//NAME=提高身价
//TEXT=使一个友方随从变为金色，并将其移回你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_018:SpellBase{
//NAME=笼中之鼠
//TEXT=使一个随从获得+2攻击力，然后使其攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_018e:Ability{
//NAME=困鼠之斗
//TEXT=攻击力+2，翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_019:SpellBase{
//NAME=香蕉满手
//TEXT=用香蕉填满你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_020:SpellBase{
//NAME=顶级优选
//TEXT=<b>发现</b>一个<b>等级6</b>的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_022:SpellBase{
//NAME=亲友折扣
//TEXT=在本局对战中，酒馆中随从的铸币消耗为（2）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_022e:Ability{
//NAME=Discounted
//TEXT=Costs (2).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_022pe:Ability{
//NAME=亲友折扣玩家强化
//TEXT=酒馆中随从的消耗为（2）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_023:SpellBase{
//NAME=酒水免单
//TEXT=在每回合中，你的前五次刷新消耗（0）枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_023pe:Ability{
//NAME=刷新消耗为0
//TEXT=<b>刷新</b>消耗（0）枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_025:SpellBase{
//NAME=再来一轮
//TEXT=复原你的铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_026:SpellBase{
//NAME=护馆保镖
//TEXT=使一个友方随从获得+6/+6和 <b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_026e:Ability{
//NAME=保护酒馆
//TEXT=+6/+6并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_028:SpellBase{
//NAME=爱宠福利
//TEXT=使一个友方随从获得<b>圣盾</b>，<b>风怒</b>以及+10/+10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_028e:Ability{
//NAME=磨牙骨棒
//TEXT=+10/+10，<b>圣盾</b>以及<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_029:SpellBase{
//NAME=摇起来吧
//TEXT=你下三次<b>刷新</b>酒馆的消耗为（0）枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_030:SpellBase{
//NAME=布莱恩的好戏
//TEXT=在本回合中，你的<b>战吼</b>额外触发一次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_030e:Ability{
//NAME=布莱恩的好戏
//TEXT=在本回合中，你的<b>战吼</b>额外触发一次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_032:SpellBase{
//NAME=超级赢家
//TEXT=从之前每个奖励回合的选项中<b>发现</b>一个暗月奖品。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_033:SpellBase{
//NAME=物色新人
//TEXT=在本局对战中，酒馆额外提供一个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_033e:Ability{
//NAME=物色新人
//TEXT=在本局对战中，酒馆额外提供一个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_034:SpellBase{
//NAME=回头客
//TEXT=将一个非金色友方随从移回你的手牌，并使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_034e:Ability{
//NAME=回头客
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_036:SpellBase{
//NAME=绝妙的交易
//TEXT=升级酒馆所需的铸币减少（5）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_036e:Ability{
//NAME=绝妙的交易
//TEXT=升级酒馆所需的铸币减少（5）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_037:SpellBase{
//NAME=金光闪闪
//TEXT=随机使酒馆中的一个随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_039:SpellBase{
//NAME=夺心护目镜
//TEXT=偷取酒馆中的所有随从，然后<b>刷新</b>酒馆。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGS_Treasures_040:SpellBase{
//NAME=一串香蕉
//TEXT=获取2根香蕉。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
