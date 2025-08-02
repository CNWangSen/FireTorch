using System.Collections;
using System.Collections.Generic;

public class BG21_000:MinionBase{
//NAME=跳蛙骑士
//TEXT=<b>亡语：</b>使一个友方野兽获得+1/+1以及此 <b>亡语</b>。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=3|RACE=BEAST
	public override void Init()
	{
		//TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		List<Card> TargetList = new List<Card>();
		List<int> buffList = new List<int>();
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board.Exclude(owner))
		{
			if(c.raceType.Contains(RaceType.Beast) && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.GetTag(GameTag.Health)>0)
			{
				Pool.Add(c);
			}
		}
		if(owner.GetTag(GameTag.CntLeapFrog)<1)
		{
			owner.SetTag(GameTag.CntLeapFrog,1);
		}
		for(int i=0;i<owner.GetTag(GameTag.CntLeapFrog);i++)
		{
			Card Target = Pool.Choice(owner.myPlayer.randomGen);
			if(Target!=null)
			{
				if(!Target.HasAbility("BG21_000"))
				{
					BG21_000 newab = new BG21_000();
					newab.AttachTo(Target);
				}
				Target.ChangeTag(GameTag.CntLeapFrog,1);
				if(TargetList.Contains(Target))
				{
					buffList[TargetList.IndexOf(Target)]+=1;
				}
				else{
					TargetList.Add(Target);
					buffList.Add(1);
				}
			}
		}
		new EffectChange(owner.myPlayer,owner,targets:TargetList,atkChanges:buffList,hpChanges:buffList).Resolve();
	}
}
public class BG21_000_G:MinionBase{
//NAME=跳蛙骑士
//TEXT=<b>亡语：</b>使一个友方野兽获得+2/+2以及此 <b>亡语</b>。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=6|RACE=BEAST
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
		//TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		List<Card> TargetList = new List<Card>();
		List<int> buffList = new List<int>();
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board.Exclude(owner))
		{
			if(c.raceType.Contains(RaceType.Beast) && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.GetTag(GameTag.Health)>0)
			{
				Pool.Add(c);
			}
		}
		if(owner.GetTag(GameTag.CntLeapFrog)<1)
		{
			owner.SetTag(GameTag.CntLeapFrog,1);
		}
		for(int i=0;i<owner.GetTag(GameTag.CntLeapFrog);i++)
		{
			Card Target = Pool.Choice(owner.myPlayer.randomGen);
			if(Target!=null)
			{
				if(!Target.HasAbility("BG21_000_G"))
				{
					BG21_000_G newab = new BG21_000_G();
					newab.AttachTo(Target);
				}
				Target.ChangeTag(GameTag.CntLeapFrog,1);
				if(TargetList.Contains(Target))
				{
					buffList[TargetList.IndexOf(Target)]+=2;
				}
				else{
					TargetList.Add(Target);
					buffList.Add(2);
				}
			}
		}
		new EffectChange(owner.myPlayer,owner,targets:TargetList,atkChanges:buffList,hpChanges:buffList).Resolve();
	}
}
public class BG21_000_Ge:Ability{
//NAME=蛙跳
//TEXT=属性值提高和<b>亡语：</b>使一个友方野兽获得此效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board.Exclude(owner))
		{
			if(c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			BG21_000_Ge newab = new BG21_000_Ge();
			newab.AttachTo(Target);
			new EffectChange(owner.myPlayer,owner,Target,atkChange:1,hpChange:1).Resolve();
		}
	}
}
public class BG21_000e:Ability{
//NAME=蛙跳
//TEXT=属性值提高和<b>亡语：</b>使一个友方野兽获得此效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_001:MinionBase{
//NAME=苍鳞鳄鱼
//TEXT=<b>复仇（2），亡语：</b>使另一个友方野兽获得+6/+6。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=BEAST
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public override void Deathrattle()
	{
		TriggBuff();
	}
	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,atkChange:6,hpChange:6).Resolve();
		}
	}
}
public class BG21_001_G:MinionBase{
//NAME=苍鳞鳄鱼
//TEXT=<b>复仇（2），亡语：</b>使另一个友方野兽获得+12/+12。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=10|RACE=BEAST
	private int RevengeCnt = 0;
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
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public override void Deathrattle()
	{
		TriggBuff();
	}
	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,atkChange:12,hpChange:12).Resolve();
		}
	}
}
public class BG21_001e:Ability{
//NAME=苍白鳞片
//TEXT=+6/+6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_001e2:Ability{
//NAME=苍白鳞片
//TEXT=+12/+12。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_002:MinionBase{
//NAME=鸟类的伙伴
//TEXT=<b>复仇（1）：</b>使你的野兽获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%1==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		TaskBuffTargets(Pool,atk:1,hp:1);
	}
}
public class BG21_002_G:MinionBase{
//NAME=鸟类的伙伴
//TEXT=<b>复仇（1）：</b>使你的野兽获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=8|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%1==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		TaskBuffTargets(Pool,atk:2,hp:2);
	}
}
public class BG21_002_Ge:Ability{
//NAME=进食充分
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_002e:Ability{
//NAME=进食充分
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_003:MinionBase{
//NAME=唤生响尾蛇
//TEXT=在你的回合结束时，使另一只友方野兽获得<b>复生</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class BG21_003_G:MinionBase{
//NAME=唤生响尾蛇
//TEXT=在你的回合结束时，使2只其他友方野兽获得<b>复生</b>。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_003_Ge2:Ability{
//NAME=唤生嘲讽
//TEXT=唤生响尾蛇使其获得+6/+6和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_003e:Ability{
//NAME=唤起新生
//TEXT=唤生响尾蛇使其获得<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_003e2:Ability{
//NAME=唤生嘲讽
//TEXT=唤生响尾蛇使其获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_004:MinionBase{
//NAME=贪食的乌祖尔
//TEXT=<b><b>嘲讽</b>。</b>在你使用一张恶魔牌后，吞食酒馆中的一个随从，获得其属性值。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG21_004_G:MinionBase{
//NAME=贪食的乌祖尔
//TEXT=<b><b>嘲讽</b>。</b>在你使用一张恶魔牌后，吞食酒馆中的一个随从，获得其双倍属性值。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=12|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG21_004e:Ability{
//NAME=吃饱喝足
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_005:MinionBase{
//NAME=饥饿的魔蝠
//TEXT=在你的回合结束时，你的恶魔各吞食酒馆中的一个随从，获得其属性值。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=5|RACE=DEMON
}
public class BG21_005_G:MinionBase{
//NAME=饥饿的魔蝠
//TEXT=在你的回合结束时，你的恶魔各吞食酒馆中的一个随从，获得其双倍属性值。
//MAJ=NEUTRAL|COST=6|ATK=16|HP=10|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_005e:Ability{
//NAME=魔蝠盛宴
//TEXT=吞食了随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_006:MinionBase{
//NAME=躁动欺诈者
//TEXT=<b>亡语：</b>使另一个友方随从获得本随从的生命值上限。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=DEMON
	public override void Deathrattle()
	{
		Card Target = owner.myPlayer.board.Exclude(owner).Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,hpChange:owner.cardDbf.MaxHealth).Resolve();
		}
	}
}
public class BG21_006_G:MinionBase{
//NAME=躁动欺诈者
//TEXT=<b>亡语：</b>使另一个友方随从获得本随从的生命值上限，触发两次。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=6|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		Card Target = owner.myPlayer.board.Exclude(owner).Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,hpChange:owner.cardDbf.MaxHealth).Resolve();
		}
		Card Target2 = owner.myPlayer.board.Exclude(owner).Choice(owner.myPlayer.randomGen);
		if(Target2!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target2,hpChange:owner.cardDbf.MaxHealth).Resolve();
		}
	}
}
public class BG21_006e:Ability{
//NAME=小鬼躁动
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_007:MinionBase{
//NAME=不耐烦的末日预言者
//TEXT=<b>复仇（4）：</b>随机获取一张恶魔牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class BG21_007_G:MinionBase{
//NAME=不耐烦的末日预言者
//TEXT=<b>复仇（4）：</b>随机获取2张恶魔牌。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_008:MinionBase{
//NAME=盐鳞队长
//TEXT=在你使用一张鱼人牌后，使两个友方鱼人获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class BG21_008_G:MinionBase{
//NAME=盐鳞队长
//TEXT=在你使用一张鱼人牌后，使两个友方鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_008_Ge:Ability{
//NAME=特别咸湿
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_008e:Ability{
//NAME=咸湿
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_009:MinionBase{
//NAME=军情鳍处鱼人
//TEXT=<b>复仇（4）：</b>使一个友方鱼人永久获得 <b>剧毒</b>。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=MURLOC
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%4==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}

	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Murloc))
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,Target,"Poisonous").Resolve();
		}
	}
}
public class BG21_009_G:MinionBase{
//NAME=军情鳍处鱼人
//TEXT=<b>复仇（4）：</b>使两个友方鱼人永久获得 <b>剧毒</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=12|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%4==0)
					{
						TriggBuff();
						TriggBuff();
					}
				}
			}
		}
	}

	public void TriggBuff()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.raceType.Contains(RaceType.Murloc))
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,Target,"Poisonous").Resolve();
		}
	}
}
public class BG21_009e:Ability{
//NAME=军情鳍处集训
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_010:MinionBase{
//NAME=筋肉鱼人
//TEXT=<b>战吼：</b>每有一个其他友方鱼人，便获得+2/+1。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=MURLOC
}
public class BG21_010_G:MinionBase{
//NAME=筋肉鱼人
//TEXT=<b>战吼：</b>每有一个其他友方鱼人，便获得+4/+2。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=4|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_010_Ge:Ability{
//NAME=肌肉特发达
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_010e:Ability{
//NAME=肌肉发达
//TEXT=+2/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_011:MinionBase{
//NAME=海鲜投喂手
//TEXT=<b>战吼：</b>使一个鱼人变为金色。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class BG21_011_G:MinionBase{
//NAME=海鲜投喂手
//TEXT=<b>战吼：</b>使一个鱼人变为金色。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_011_Ge:Ability{
//NAME=投出
//TEXT=+6/+6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_011e:Ability{
//NAME=投出
//TEXT=+3/+3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_011e2:Ability{
//NAME=Battlecry Self-Trigger DEPRECATED [DNT]
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_012:MinionBase{
//NAME=普瑞斯托的火炎子嗣
//TEXT=每当另一条友方的龙攻击时，对其目标造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=DRAGON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Dragon) && tc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectDamage(owner.myPlayer,owner,tc,3).Resolve();
			}
		}
	}
}
public class BG21_012_G:MinionBase{
//NAME=普瑞斯托的火炎子嗣
//TEXT=每当另一条友方的龙攻击时，对其目标造成6点伤害。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=10|RACE=DRAGON
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
			if(sc.raceType.Contains(RaceType.Dragon) && tc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectDamage(owner.myPlayer,owner,tc,6).Resolve();
			}
		}
	}
}
public class BG21_013:MinionBase{
//NAME=雏龙走私商
//TEXT=在一条友方的龙获得攻击力后，使其获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=5|RACE=NONE
}
public class BG21_013_G:MinionBase{
//NAME=雏龙走私商
//TEXT=在一条友方的龙获得攻击力后，使其获得+2生命值。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_013e:Ability{
//NAME=雏师大捷
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_014:MinionBase{
//NAME=珍稀增强幼龙
//TEXT=<b>战斗开始时：</b>使你的其他龙获得+3/+3。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=DRAGON
	public override void OnCombatStart()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Dragon),atk:3,hp:3);
	}
}
public class BG21_014_G:MinionBase{
//NAME=珍稀增强幼龙
//TEXT=<b>战斗开始时：</b>使你的其他龙获得+6/+6。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=8|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Dragon),atk:6,hp:6);
	}
}
public class BG21_014e:Ability{
//NAME=提升
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_015:MinionBase{
//NAME=泰蕾苟萨
//TEXT=本随从可永久保留战斗阶段受到的你的附加效果。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=DRAGON
}
public class BG21_015_G:MinionBase{
//NAME=泰蕾苟萨
//TEXT=本随从战斗阶段受到的你的附加效果翻倍，并可永久保留。
//MAJ=NEUTRAL|COST=3|ATK=10|HP=10|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_016:MinionBase{
//NAME=佩吉·布里特伯
//TEXT=在一张卡牌被置入你的手牌后，使另一个友方海盗获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=5|RACE=PIRATE
}
public class BG21_016_G:MinionBase{
//NAME=佩吉·布里特伯
//TEXT=在一张卡牌被置入你的手牌后，使另一个友方海盗获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=10|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_016_Ge:Ability{
//NAME=好货上手
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_016e:Ability{
//NAME=好货上手
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_017:MinionBase{
//NAME=海上走私贩
//TEXT=在你的回合结束时，如果你控制着其他海盗，获取一张铸币牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class BG21_017_G:MinionBase{
//NAME=海上走私贩
//TEXT=在你的回合结束时，如果你控制着其他海盗，获取2张铸币牌。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_018:MinionBase{
//NAME=挑衅的船工
//TEXT=每当本随从获得攻击力时，永久获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=5|RACE=PIRATE
}
public class BG21_018_G:MinionBase{
//NAME=挑衅的船工
//TEXT=每当本随从获得攻击力时，永久获得+2生命值。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=10|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_018_Ge:Ability{
//NAME=修整工整
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_018e:Ability{
//NAME=修整工整
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_019:MinionBase{
//NAME=好奇的掠夺者
//TEXT=每两个回合，随机获取一张金色随从牌。<i>（还剩2回合！）</i>
//MAJ=NEUTRAL|COST=6|ATK=9|HP=8|RACE=PIRATE
}
public class BG21_019_G:MinionBase{
//NAME=好奇的掠夺者
//TEXT=在你的回合开始时，随机获取一张金色随从牌。
//MAJ=NEUTRAL|COST=6|ATK=18|HP=16|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_020:MinionBase{
//NAME=炫目的光耀之子
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的元素拥有+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=ELEMENTAL
}
public class BG21_020_G:MinionBase{
//NAME=炫目的光耀之子
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的元素拥有+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=10|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_020e:Ability{
//NAME=炫目
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_020pe:Ability{
//NAME=炫目的光耀之子玩家强化
//TEXT=炫目的光耀之子使酒馆中的元素属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_021:MinionBase{
//NAME=烟雾元素
//TEXT=<b>战吼：</b>使一个友方元素获得等同于你当前等级的属性值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BG21_021_G:MinionBase{
//NAME=烟雾元素
//TEXT=<b>战吼：</b>使一个友方元素获得等同于你当前等级的属性值，触发两次。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_021e:Ability{
//NAME=烟雾缭绕
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_022:MinionBase{
//NAME=狗狗机器人
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
}
public class BG21_022_G:MinionBase{
//NAME=狗狗机器人
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
}
public class BG21_023:MinionBase{
//NAME=步行坦克
//TEXT=<b>复仇（2）：</b>对生命值最高的敌方随从造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=3|RACE=MECHANICAL
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}

	public void TriggBuff()
	{
		Card Target = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(Target==null)
			{
				Target=c;
			}
			else{
				if(c.GetTag(GameTag.Health) > Target.GetTag(GameTag.Health))
				{
					Target=c;
				}
			}
		}
		if(Target!=null)
		{
			new EffectDamage(owner.myPlayer,owner,Target,5).Resolve();
		}
	}
}
public class BG21_023_G:MinionBase{
//NAME=步行坦克
//TEXT=<b>复仇（2）：</b>对生命值最高的敌方随从造成5点伤害，触发两次。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=6|RACE=MECHANICAL
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
						TriggBuff();
					}
				}
			}
		}
	}

	public void TriggBuff()
	{
		Card Target = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(Target==null)
			{
				Target=c;
			}
			else{
				if(c.GetTag(GameTag.Health) > Target.GetTag(GameTag.Health))
				{
					Target=c;
				}
			}
		}
		if(Target!=null)
		{
			new EffectDamage(owner.myPlayer,owner,Target,5).Resolve();
		}
	}
}
public class BG21_024:MinionBase{
//NAME=滑油机器人
//TEXT=<b>圣盾</b>。在一个友方随从失去<b>圣盾</b>后，使其永久获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=4|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc, string abiname)
	{
		if(CondInPlay() && sc!=owner)
		{
			if(abiname=="DivineShield")
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:2,hpChange:2).Resolve();
			}
		}
	}
}
public class BG21_024_G:MinionBase{
//NAME=滑油机器人
//TEXT=<b>圣盾</b>。在一个友方随从失去<b>圣盾</b>后，使其永久获得+4/+4。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=8|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc, string abiname)
	{
		if(CondInPlay() && sc!=owner)
		{
			if(abiname=="DivineShield")
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:4,hpChange:4).Resolve();
			}
		}
	}
}
public class BG21_024_Ge:Ability{
//NAME=机油润滑
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_024e:Ability{
//NAME=机油润滑
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_025:MinionBase{
//NAME=欧米茄破坏者
//TEXT=<b>亡语：</b>召唤六个1/1的微型机器人。每有一个放不下的机器人，便使你的机械获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=MECHANICAL
	public override void Init()
	{
		//TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BG_BOT_312t");
		int N = owner.myPlayer.board.Count;
		int SummonNum = 6;
		int MaxNum = owner.myPlayer.maxnum[(int)ZoneType.Board];
		if(N+SummonNum>MaxNum)
		{
			SummonNum=MaxNum-N;
		}
		int Index = owner.GetTag(GameTag.AidDeathPos);
		for(int i=0;i<SummonNum;i++)
		{
			TaskCreate(ToSummon,ZoneType.Board,pos:Index);
		}
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Mechanical))
			{
				ToListBuff.Add(c);
			}
		}
		int BuffNum = 6-SummonNum;
		if(BuffNum>0)
			TaskBuffTargets(ToListBuff,atk:BuffNum,hp:BuffNum);
	}
}
public class BG21_025_G:MinionBase{
//NAME=欧米茄破坏者
//TEXT=<b>亡语：</b>召唤六个2/2的微型机器人。每有一个放不下的机器人，便使你的机械获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=12|RACE=MECHANICAL
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("TB_BaconUps_032t");
		int N = owner.myPlayer.board.Count;
		int SummonNum = 6;
		int MaxNum = owner.myPlayer.maxnum[(int)ZoneType.Board];
		if(N+SummonNum>MaxNum)
		{
			SummonNum=MaxNum-N;
		}
		int Index = owner.GetTag(GameTag.AidDeathPos);
		for(int i=0;i<SummonNum;i++)
		{
			TaskCreate(ToSummon,ZoneType.Board,pos:Index);
		}
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Mechanical))
			{
				ToListBuff.Add(c);
			}
		}
		int BuffNum = 2*(6-SummonNum);
		if(BuffNum>0)
			TaskBuffTargets(ToListBuff,atk:BuffNum,hp:BuffNum);
	}
}
public class TB_BaconUps_032t:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_025e:Ability{
//NAME=欧米茄爆发
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_025e2:Ability{
//NAME=欧米茄爆发
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_027:MinionBase{
//NAME=异变多彩龙
//TEXT=在你升级酒馆后，每有一条友方的龙，便获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=DRAGON
}
public class BG21_027_G:MinionBase{
//NAME=异变多彩龙
//TEXT=在你升级酒馆后，每有一条友方的龙，便获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=8|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_027_Ge:Ability{
//NAME=已异变
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_027e:Ability{
//NAME=已异变
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_029:MinionBase{
//NAME=粗鄙小鬼
//TEXT=<b>亡语：</b>召唤两个1/1的小鬼。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
	public override void Deathrattle()
	{
		CardDbf db = CardDbf.GetCardDbfByGuid("BG_BRM_006t");
		TaskCreate(db,ZoneType.Board);
		TaskCreate(db,ZoneType.Board);
	}
}
public class BG21_029_G:MinionBase{
//NAME=粗鄙小鬼
//TEXT=<b>亡语：</b>召唤两个2/2的小鬼。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		CardDbf db = CardDbf.GetCardDbfByGuid("TB_BaconUps_030t");
		TaskCreate(db,ZoneType.Board);
		TaskCreate(db,ZoneType.Board);
	}
}
public class BG21_030:MinionBase{
//NAME=幼苗催生员
//TEXT=<b>复仇（3）：</b>使相邻的随从永久获得+2/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%3==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		List<Card> Adj = FindAdj();
		TaskBuffTargets(Adj,atk:2,hp:1);
	}
}
public class BG21_030_G:MinionBase{
//NAME=幼苗催生员
//TEXT=<b>复仇（3）：</b>使相邻的随从永久获得+4/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=8|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					this.RevengeCnt+=1;
					if(this.RevengeCnt%3==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		List<Card> Adj = FindAdj();
		TaskBuffTargets(Adj,atk:4,hp:2);
	}
}
public class BG21_030_Ge:Ability{
//NAME=抽枝发芽
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_030e:Ability{
//NAME=抽枝发芽
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_031:MinionBase{
//NAME=托尼·双牙
//TEXT=<b>复仇（4）：</b>使另一个友方海盗永久变成 金色。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=PIRATE
}
public class BG21_031_G:MinionBase{
//NAME=托尼·双牙
//TEXT=<b>复仇（4）：</b>使另两个友方海盗永久变成 金色。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=12|RACE=PIRATE
}
public class BG21_036:MinionBase{
//NAME=现境大师
//TEXT=<b>嘲讽</b> 在一个友方元素获得属性值后，获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG21_036_G:MinionBase{
//NAME=现境大师
//TEXT=<b>嘲讽</b> 在一个友方元素获得属性值后，获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG21_036_Ge:Ability{
//NAME=元素位面
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_036e:Ability{
//NAME=元素位面
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_037:MinionBase{
//NAME=宝石切分者
//TEXT=在一个友方随从失去<b>圣盾</b>后，获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=QUILBOAR
}
public class BG21_037_G:MinionBase{
//NAME=宝石切分者
//TEXT=在一个友方随从失去<b>圣盾</b>后，获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=8|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_038:MinionBase{
//NAME=巫翼巢穴主母
//TEXT=<b>复仇（3）：</b>随机获取一张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class BG21_038_G:MinionBase{
//NAME=巫翼巢穴主母
//TEXT=<b>复仇（3）：</b>随机获取2张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_039:MinionBase{
//NAME=卡萨纳提尔
//TEXT=你的其他恶魔拥有 +2攻击力。你的英雄<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=DEMON
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Demon) && (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board || c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hero) && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            return "BG21_039e";
        }
        else{
            return "Immue";
        }
    }
}
public class BG21_039_G:MinionBase{
//NAME=卡萨纳提尔
//TEXT=你的其他恶魔拥有 +4攻击力。你的英雄<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=8|RACE=DEMON
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Demon) && (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board || c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hero) && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            return "BG21_039_Ge";
        }
        else{
            return "Immue";
        }
    }
}
public class BG21_039_Ge:Ability{
//NAME=卡萨纳提尔之握
//TEXT=卡萨纳提尔使其获得+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 4;
        }
        return 0;
    }
}
public class BG21_039e:Ability{
//NAME=卡萨纳提尔之握
//TEXT=卡萨纳提尔使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        return 0;
    }
}
public class BG21_040:MinionBase{
//NAME=回收魔灵
//TEXT=在你使用一张元素牌后，你下一次<b>刷新</b>酒馆的消耗减少（1）枚铸币。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=ELEMENTAL
}
public class BG21_040_G:MinionBase{
//NAME=回收魔灵
//TEXT=在你使用一张元素牌后，你下两次<b>刷新</b>酒馆的消耗减少（1）枚铸币。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=8|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_040e:Ability{
//NAME=刷新酒馆的消耗减少（1）枚铸币。
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000:HeroBase{
//NAME=凯瑞尔·罗姆
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000_Buddy:MinionBase{
//NAME=法莫斯队长
//TEXT=<b>抉择：</b>在本局对战的剩余时间内，“定罪”使随从额外获得+2攻击力；或者+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=7|HP=5|RACE=NONE
}
public class BG21_HERO_000_Buddy_G:MinionBase{
//NAME=法莫斯队长
//TEXT=<b>抉择：</b>在本局对战的剩余时间内，“定罪”使随从额外获得+4攻击力；或者+4生命值。
//MAJ=NEUTRAL|COST=5|ATK=14|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_HERO_000_Buddy_Gt:SpellBase{
//NAME=进攻姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_Buddyt:SpellBase{
//NAME=进攻姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_Buddyt2:SpellBase{
//NAME=防御姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_Buddyt3:SpellBase{
//NAME=进攻姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_Buddyt4:SpellBase{
//NAME=防御姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_Buddyt_Gt2:SpellBase{
//NAME=防御姿态
//TEXT=在本局对战中，“定罪”使随从额外获得+4生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000_SKIN_A:HeroBase{
//NAME=奔马凯瑞尔
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000_SKIN_B2:HeroBase{
//NAME=烈火绳镖凯瑞尔
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000_SKIN_C4:HeroBase{
//NAME=圣光之锤凯瑞尔
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000_SKIN_D:HeroBase{
//NAME=天选之子凯瑞尔
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000_SKIN_E:HeroBase{
//NAME=善念凯瑞尔
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_000e:Ability{
//NAME=凯瑞尔监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000p:HeroPowerBase{
//NAME=定罪
//TEXT=使{2}个友方随从获得+{0}/+{1}。<i>（在你升级酒馆后，选择一项提升！）</i>1使{2}个友方随从获得+{0}/+{1}。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000p2:HeroPowerBase{
//NAME=定罪（等级2）
//TEXT=随机使四个友方随从获得+{0}/+{1}。<i>（酒馆等级5时升级。）</i>
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000p3:HeroPowerBase{
//NAME=定罪（等级3）
//TEXT=使所有友方随从获得+{0}/+{1}。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000p_t1:SpellBase{
//NAME=结阵姿态
//TEXT=在本局对战中，“定罪”额外使一个友方随从获得属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_000pe:Ability{
//NAME=祝福
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_010:HeroBase{
//NAME=斯卡布斯·刀油
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_010_Buddy:MinionBase{
//NAME=典狱官塞尔沃特
//TEXT=在你的回合开始时，获取一张下一个对手的伙伴。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class BG21_HERO_010_Buddy_G:MinionBase{
//NAME=典狱官塞尔沃特
//TEXT=在你的回合开始时，获取2张下一个对手的伙伴。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=8|RACE=NONE
}
public class BG21_HERO_010_SKIN_A3:HeroBase{
//NAME=卧底大厨刀油
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_010_SKIN_B4:HeroBase{
//NAME=星夜斥候斯卡布斯
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_010_SKIN_C:HeroBase{
//NAME=MC斯卡布斯
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_010p:HeroPowerBase{
//NAME=间谍探查
//TEXT=从你下一个对手的战队中<b>发现</b>一个随从的原始版复制。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_020:HeroBase{
//NAME=厨师曲奇
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_020_Buddy:MinionBase{
//NAME=副厨师长
//TEXT=每个回合你可以额外使用一次英雄技能。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=5|RACE=MURLOC
}
public class BG21_HERO_020_Buddy_G:MinionBase{
//NAME=副厨师长
//TEXT=每个回合你可以额外使用2次英雄技能。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=10|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_HERO_020_SKIN_A2:HeroBase{
//NAME=熏烤大师曲奇
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_020_SKIN_B:HeroBase{
//NAME=宴会大师曲奇
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_020_SKIN_C:HeroBase{
//NAME=“亚煞极”曲奇
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_020_SKIN_D:HeroBase{
//NAME=包子大厨曲奇
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_020p:HeroPowerBase{
//NAME=搅动汤锅
//TEXT=将一个随从投入你的锅中。当你集齐3个随从时，从它们的类型中<b>发现</b>一个随从。<i>（还剩3个！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_030:HeroBase{
//NAME=斯尼德
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_030_Buddy:MinionBase{
//NAME=载人飓风机甲
//TEXT=<b>战斗开始时：</b>复制所有其他友方随从的<b>亡语</b><i>（载人飓风机甲除外）</i>。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=4|RACE=MECHANICAL
}
public class BG21_HERO_030_Buddy_e:Ability{
//NAME=飓风
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_030_Buddy_G:MinionBase{
//NAME=载人飓风机甲
//TEXT=<b>战斗开始时：</b>复制所有其他友方随从的<b>亡语</b>，复制两次<i>（载人飓风机甲除外）</i>。
//MAJ=NEUTRAL|COST=3|ATK=12|HP=8|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG21_HERO_030_SKIN_A:HeroBase{
//NAME=潜航斯尼德
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_030_SKIN_B3:HeroBase{
//NAME=罪碑斯尼德
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_030_SKIN_C:HeroBase{
//NAME=碎骨魔机斯尼德
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_030_SKIN_D:HeroBase{
//NAME=战车飙客斯尼德
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG21_HERO_030p:HeroPowerBase{
//NAME=斯尼德的复制器
//TEXT=使一个随从获得“<b>亡语：</b>随机召唤一个低一级的随从。”
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG21_HERO_030pe:Ability{
//NAME=复制
//TEXT=<b>亡语</b>：随机召唤一个低一级的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
