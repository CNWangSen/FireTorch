using System.Collections;
using System.Collections.Generic;

public class BG25_001:MinionBase{
//NAME=复活的骑兵
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("Reborn");
	}
}
public class BG25_001_G:MinionBase{
//NAME=复活的骑兵
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
		TaskInitAbility("Reborn");
	}
}
public class BG25_002:MinionBase{
//NAME=宴会食尸鬼
//TEXT=<b>复仇（2）：</b>使每个类型的各一个友方随从获得+3攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=UNDEAD
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
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner)
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,atkChange:3).Resolve();
		}
	}
}
public class BG25_002_G:MinionBase{
//NAME=宴会食尸鬼
//TEXT=<b>复仇（2）：</b>使每个类型的各一个友方随从获得+6攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=10|RACE=UNDEAD
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
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner)
			{
				Pool.Add(c);
			}
		}
		Card Target = Pool.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target,atkChange:6).Resolve();
		}
	}
}
public class BG25_002_Ge:Ability{
//NAME=美味的零食
//TEXT=+6攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_002e:Ability{
//NAME=美味的零食
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_003:MinionBase{
//NAME=无情的哨卫
//TEXT=<b>复仇（4）：</b>获得<b>嘲讽</b>和<b><b>复生</b>。</b>
//MAJ=NEUTRAL|COST=3|ATK=6|HP=1|RACE=UNDEAD
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
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Taunt").Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Reborn").Resolve();
	}
}
public class BG25_003_G:MinionBase{
//NAME=无情的哨卫
//TEXT=<b>复仇（4）：</b>获得<b>嘲讽</b>和<b><b>复生</b>。</b>
//MAJ=NEUTRAL|COST=3|ATK=12|HP=2|RACE=UNDEAD
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
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Taunt").Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Reborn").Resolve();
	}
}
public class BG25_003e:Ability{
//NAME=返岗就绪
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_004:MinionBase{
//NAME=附灵女妖
//TEXT=<b>战吼：</b>使一个亡灵获得+2/+7。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=7|RACE=UNDEAD
}
public class BG25_004_G:MinionBase{
//NAME=附灵女妖
//TEXT=<b>战吼：</b>使一个亡灵获得+4/+14。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=14|RACE=UNDEAD
}
public class BG25_004_Ge:Ability{
//NAME=你是我的！
//TEXT=+4/+14。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_004e:Ability{
//NAME=你是我的！
//TEXT=+2/+7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_005:MinionBase{
//NAME=黏冻大肚怪
//TEXT=在一个友方随从<b>复生</b>后，获得+3/+3。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=6|RACE=UNDEAD
}
public class BG25_005_G:MinionBase{
//NAME=黏冻大肚怪
//TEXT=在一个友方随从<b>复生</b>后，获得+6/+6。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=12|RACE=UNDEAD
}
public class BG25_005_Ge:Ability{
//NAME=黏冻
//TEXT=+6/+6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_005e:Ability{
//NAME=黏冻
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_006:MinionBase{
//NAME=巫妖医生
//TEXT=<b>嘲讽</b>。在你的回合开始时，使你在上一场战斗中死亡的随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class BG25_006_G:MinionBase{
//NAME=巫妖医生
//TEXT=<b>嘲讽</b>。在你的回合开始时，使你在上一场战斗中死亡的随从获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=4|RACE=UNDEAD
}
public class BG25_006_Ge:Ability{
//NAME=恰如所求
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_006e:Ability{
//NAME=恰如所求
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_007:MinionBase{
//NAME=蛛魔之王阿努巴拉克
//TEXT=<b>亡语：</b>在本局对战中，你的亡灵拥有+1攻击力<i>（无论它们在哪）</i>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Undead),atk:1);
	}
}
public class BG25_007_G:MinionBase{
//NAME=蛛魔之王阿努巴拉克
//TEXT=<b>亡语：</b>在本局对战中，你的亡灵拥有+2攻击力<i>（无论它们在哪）</i>。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Undead),atk:2);
	}
}
public class BG25_008:MinionBase{
//NAME=永恒骑士
//TEXT=在本局对战中，每有一个友方永恒骑士死亡，便拥有+1/+1<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=UNDEAD
	public static int Cnt=0;
	public override void Deathrattle()
	{
		BG25_008.Cnt+=1;
		BG25_008_G.Cnt+=1;
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod || tg==GameTag.HealthMod)
		{
			return BG25_008.Cnt;
		}
		return 0;
	}
}
public class BG25_008_e:Ability{
//NAME=永恒军团
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_008_G:MinionBase{
//NAME=永恒骑士
//TEXT=在本局对战中，每有一个友方永恒骑士死亡，便拥有+2/+2<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=8|HP=2|RACE=UNDEAD
	public static int Cnt=50;
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void Deathrattle()
	{
		BG25_008.Cnt+=1;
		BG25_008_G.Cnt+=1;
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod || tg==GameTag.HealthMod)
		{
			return BG25_008_G.Cnt*2;
		}
		return 0;
	}
}
public class BG25_008pe:Ability{
//NAME=永恒骑士玩家附加效果
//TEXT=记录死亡的永恒骑士数量。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_009:MinionBase{
//NAME=永恒召唤者
//TEXT=<b>复生</b>。<b>亡语：</b>召唤1个永恒骑士。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=1|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG25_008"),ZoneType.Board,pos:owner.GetTag(GameTag.AidDeathPos));
	}
}
public class BG25_009_G:MinionBase{
//NAME=永恒召唤者
//TEXT=<b>复生</b>。<b>亡语：</b>召唤一个金色的永恒骑士。
//MAJ=NEUTRAL|COST=6|ATK=16|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG25_008_G"),ZoneType.Board,pos:owner.GetTag(GameTag.AidDeathPos));
	}
}
public class BG25_010:MinionBase{
//NAME=断手被遗忘者
//TEXT=<b>亡语：</b>召唤一只2/1并具有<b>复生</b>的手。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=1|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG25_010t"),ZoneType.Board);
	}
}
public class BG25_010_G:MinionBase{
//NAME=断手被遗忘者
//TEXT=<b>亡语：</b>召唤一只4/2并具有<b>复生</b>的手。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG25_010_Gt"),ZoneType.Board);
	}
}
public class BG25_010_Gt:MinionBase{
//NAME=援手
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Reborn");
	}
}
public class BG25_010t:MinionBase{
//NAME=援手
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG25_011:MinionBase{
//NAME=死亡群居蛛魔
//TEXT=<b>战吼：</b>在本局对战中，你的亡灵拥有+1攻击力<i>（无论它们在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=UNDEAD
}
public class BG25_011_G:MinionBase{
//NAME=死亡群居蛛魔
//TEXT=<b>战吼：</b>在本局对战中，你的亡灵拥有+2攻击力<i>（无论它们在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=8|RACE=UNDEAD
}
public class BG25_011e2:Ability{
//NAME=不死军团
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_011pe:Ability{
//NAME=亡灵额外攻击力玩家效果
//TEXT=使亡灵获得攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_013:MinionBase{
//NAME=腐皮豺狼人
//TEXT=在本场战斗中，每有一个友方随从死亡，便拥有+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=UNDEAD
}
public class BG25_013_G:MinionBase{
//NAME=腐皮豺狼人
//TEXT=在本场战斗中，每有一个友方随从死亡，便拥有+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=8|RACE=UNDEAD
}
public class BG25_014:MinionBase{
//NAME=饥饿的憎恶
//TEXT=<b>复仇（1)：</b>永久获得+1/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=UNDEAD
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc!=owner)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:1,hpChange:2).Resolve();
				}
			}
		}
	}
}
public class BG25_014_G:MinionBase{
//NAME=饥饿的憎恶
//TEXT=<b>复仇（1)：</b>永久获得+2/+4。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=10|RACE=UNDEAD
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
			if(sc!=owner)
			{
				if(sz==ZoneType.Board && tz==ZoneType.Grave)
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:4).Resolve();
				}
			}
		}
	}
}
public class BG25_014_Ge:Ability{
//NAME=嚼啊嚼
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_014e:Ability{
//NAME=嚼啊嚼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_016:MinionBase{
//NAME=辛多雷直射手
//TEXT=<b>风怒</b>，<b>圣盾</b>。每当本随从攻击时，移除目标的<b>复生</b>和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("WindFury");
		TaskInitAbility("DivineShield");
	}
	public override void BeforeAttack(Card target=null)
	{
		new EffectRemoveAbility(owner.myPlayer,owner,target,"Reborn").Resolve();
		new EffectRemoveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
	}
}
public class BG25_016_G:MinionBase{
//NAME=辛多雷直射手
//TEXT=<b>风怒</b>，<b>圣盾</b>。每当本随从攻击时，移除目标的<b>复生</b>和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=8|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("WindFury");
		TaskInitAbility("DivineShield");
	}
	public override void BeforeAttack(Card target=null)
	{
		new EffectRemoveAbility(owner.myPlayer,owner,target,"Reborn").Resolve();
		new EffectRemoveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
	}
}
public class BG25_016e:Ability{
//NAME=万劫不复
//TEXT=不再拥有<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_016e2:Ability{
//NAME=嘲讽不再
//TEXT=不再拥有<b><b>嘲讽</b>。</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_020:MinionBase{
//NAME=亡语者姐妹
//TEXT=在一个友方随从<b>复生</b>后，使你的随从永久获得+1/+3。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=9|RACE=UNDEAD
}
public class BG25_020_G:MinionBase{
//NAME=亡语者姐妹
//TEXT=在一个友方随从<b>复生</b>后，使你的随从永久获得+2/+6。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=18|RACE=UNDEAD
}
public class BG25_020_Ge:Ability{
//NAME=黑暗耳语
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_020e:Ability{
//NAME=黑暗耳语
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_022:MinionBase{
//NAME=血色骷髅
//TEXT=<b>复生</b>。<b>亡语：</b>使一个友方亡灵获得+1/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
	public override void Deathrattle()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:1,hpChange:2).Resolve();
		}
	}
}
public class BG25_022_G:MinionBase{
//NAME=血色骷髅
//TEXT=<b>复生</b>。<b>亡语：</b>使一个友方亡灵获得+2/+4。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Reborn");
	}
	public override void Deathrattle()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:2,hpChange:4).Resolve();
		}
	}
}
public class BG25_022_Ge:Ability{
//NAME=血色恐惧
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_022e:Ability{
//NAME=血色恐惧
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_023:MinionBase{
//NAME=灵魂切分者
//TEXT=<b>复生</b>。<b>战斗开始时：</b>使一个友方亡灵获得<b>复生</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
	public override void OnCombatStart()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Reborn").Resolve();
		}
	}	
}
public class BG25_023_G:MinionBase{
//NAME=灵魂切分者
//TEXT=<b>复生</b>。<b>战斗开始时：</b>使2个友方亡灵获得<b>复生</b>。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=4|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Reborn");
	}
	public override void OnCombatStart()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Reborn").Resolve();
		}
		Card ToBuff2 = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff2!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff2,"Reborn").Resolve();
		}
	}	
}
public class BG25_023e:Ability{
//NAME=双份灵魂
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_027:MinionBase{
//NAME=采集者猎手
//TEXT=在本随从获得攻击力后，使你的所有随从获得+1生命值。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=DRAGON
}
public class BG25_027_G:MinionBase{
//NAME=采集者猎手
//TEXT=在本随从获得攻击力后，使你的所有随从获得+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=12|RACE=DRAGON
}
public class BG25_027_Ge:Ability{
//NAME=猎杀采集者
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_027e:Ability{
//NAME=猎杀采集者
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_032:MinionBase{
//NAME=佩吉·斯特迪伯
//TEXT=在一张卡牌被置入你的手牌后，使另一个友方海盗获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=PIRATE
}
public class BG25_032_G:MinionBase{
//NAME=佩吉·斯特迪伯
//TEXT=在一张卡牌被置入你的手牌后，使另一个友方海盗获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=4|RACE=PIRATE
}
public class BG25_032_Ge:Ability{
//NAME=好货上手
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_032e:Ability{
//NAME=好货上手
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_033:MinionBase{
//NAME=尸体提炼师
//TEXT=<b>复仇（4）：</b>出售本随从可多获得1枚铸币。4<b>复仇（4）：</b>出售本随从可多获得1枚铸币。<i>（可额外获得{0}枚！）</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class BG25_033_G:MinionBase{
//NAME=尸体提炼师
//TEXT=<b>复仇（4）：</b>出售本随从可多获得2枚铸币。4<b>复仇（4）：</b>出售本随从可多获得2枚铸币。<i>（可额外获得{0}枚！）</i>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=UNDEAD
}
public class BG25_034:MinionBase{
//NAME=杉德尔船长
//TEXT=<b>战吼：</b>使一个友方随从变为金色。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=PIRATE
}
public class BG25_034_G:MinionBase{
//NAME=杉德尔船长
//TEXT=<b>战吼：</b>使一个友方随从变为金色。
//MAJ=NEUTRAL|COST=7|ATK=14|HP=14|RACE=PIRATE
}
public class BG25_039:MinionBase{
//NAME=刺豚野猪
//TEXT=每当法术被用于本随从，直到下个回合，获得<b>烈毒</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=QUILBOAR
}
public class BG25_039_G:MinionBase{
//NAME=刺豚野猪
//TEXT=每当法术被用于本随从，获得<b>烈毒</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=12|RACE=QUILBOAR
}
public class BG25_039_Ge:Ability{
//NAME=刺豚饱胀
//TEXT=<b>烈毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_039e:Ability{
//NAME=刺豚气胀
//TEXT=直到下个回合，获得<b>烈毒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_040:MinionBase{
//NAME=烈火飞鱼
//TEXT=在你触发一个<b>战吼</b>后，获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=DRAGON
}
public class BG25_040_G:MinionBase{
//NAME=烈火飞鱼
//TEXT=在你触发一个<b>战吼</b>后，获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=8|RACE=DRAGON
}
public class BG25_040_Ge:Ability{
//NAME=荣耀之火
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_040e:Ability{
//NAME=荣耀之火
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_041:MinionBase{
//NAME=邪能元素
//TEXT=<b>战吼：</b>在本局对战中，酒馆中的随从拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=ELEMENTAL
}
public class BG25_041_G:MinionBase{
//NAME=邪能元素
//TEXT=<b>战吼：</b>在本局对战中，酒馆中的随从拥有+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=2|RACE=ELEMENTAL
}
public class BG25_041e:Ability{
//NAME=邪火玩家附加效果
//TEXT=邪能元素使酒馆中的元素属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_041e2:Ability{
//NAME=邪能元素
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_042:MinionBase{
//NAME=邪能践踏者
//TEXT=在战斗中，在你召唤一个随从后，使你的所有随从获得+3攻击力。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=7|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				TaskBuffTargets(owner.myPlayer.board,atk:3);
			}
		}
	}
}
public class BG25_042_G:MinionBase{
//NAME=邪能践踏者
//TEXT=在战斗中，在你召唤一个随从后，使你的所有随从获得+6攻击力。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=14|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.myPlayer==owner.myPlayer)
			{
				TaskBuffTargets(owner.myPlayer.board,atk:6);
			}
		}
	}
}
public class BG25_042_Ge:Ability{
//NAME=邪能充盈
//TEXT=+6攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_042e:Ability{
//NAME=邪能充盈
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_043:MinionBase{
//NAME=赛博格幼龙
//TEXT=<b>圣盾</b>。你的<b>圣盾</b>随从拥有+6攻击力。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=10|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return ((c.HasAbility("DivineShield") ||c.HasAbility("DivineShieldPro")) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "BG25_043e";
    }
}
    
public class BG25_043_G:MinionBase{
//NAME=赛博格幼龙
//TEXT=<b>圣盾</b>。你的<b>圣盾</b>随从拥有+12攻击力。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=20|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.HasAbility("DivineShield") &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "BG25_043Ge";
    }
}
public class BG25_043_Ge:Ability{
//NAME=赛博格强化
//TEXT=+12攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	private int rem=12;
	public override void AfterTakeDamage(Card source = null, int amount = 0)
	{
		rem =0;
	}
	public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return rem;
        }
        return 0;
    }
}
public class BG25_043e:Ability{
//NAME=赛博格强化
//TEXT=+6攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	private int rem=6;
	public override void AfterTakeDamage(Card source = null, int amount = 0)
	{
		rem =0;
	}

	public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return rem;
        }
        return 0;
    }
}
public class BG25_044:MinionBase{
//NAME=金枪格蕾塔
//TEXT=<b>塑造法术：</b> 直到下回合，使一个不同的友方海盗或纳迦变为金色。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=9|RACE=NAGA
}
public class BG25_044_G:MinionBase{
//NAME=金枪格蕾塔
//TEXT=<b>塑造法术：</b> 直到下回合，使一个不同的友方海盗或纳迦变为金色。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=18|RACE=NAGA
}
public class BG25_044e2:Ability{
//NAME=金枪爆头
//TEXT=直到下回合变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_044t:SpellBase{
//NAME=金枪
//TEXT=直到下回合，使一个友方海盗或纳迦<i>（金枪格蕾塔除外）</i>变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG25_045:MinionBase{
//NAME=刺棘船长
//TEXT=在一张牌被置入你的手牌后，直到下个回合，获得+1生命值。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=2|RACE=QUILBOAR
}
public class BG25_045_G:MinionBase{
//NAME=刺棘船长
//TEXT=在一张牌被置入你的手牌后，直到下个回合，获得+2生命值。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=4|RACE=QUILBOAR
}
public class BG25_045e:Ability{
//NAME=船长在此
//TEXT=直到下个回合，+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_045e2:Ability{
//NAME=船长在此
//TEXT=直到下个回合，+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_046:MinionBase{
//NAME=熔岩鱼人
//TEXT=在你的回合结束时，获得+1/+1。在本回合中你每使用过一张随从牌，重复一次。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=MURLOC
}
public class BG25_046_G:MinionBase{
//NAME=熔岩鱼人
//TEXT=在你的回合结束时，获得+2/+2。在本回合中你每使用过一张随从牌，重复一次。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=MURLOC
}
public class BG25_046_Ge:Ability{
//NAME=熔岩！
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_046e:Ability{
//NAME=熔岩！
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_050:MinionBase{
//NAME=太阳巨人守护者
//TEXT=<b>圣盾</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class BG25_050_G:MinionBase{
//NAME=太阳巨人守护者
//TEXT=<b>圣盾</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=6|ATK=12|HP=12|RACE=UNDEAD
}
public class BG25_104:MinionBase{
//NAME=克罗诺姆
//TEXT=当本随从在酒馆中时，会获得出售的随从的属性值。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=DRAGON
}
public class BG25_104_G:MinionBase{
//NAME=克罗诺姆
//TEXT=当本随从在酒馆中时，会获得出售的随从的双倍属性值。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=DRAGON
}
public class BG25_104e:Ability{
//NAME=过往加成
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_105:MinionBase{
//NAME=诗情笔友
//TEXT=<b>战吼：</b>使你下一个<b>伙伴</b>消耗的铸币减少（2）枚。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=NONE
}
public class BG25_105_G:MinionBase{
//NAME=诗情笔友
//TEXT=<b>战吼：</b>使你下一个<b>伙伴</b>消耗的铸币减少（4）枚。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=8|RACE=NONE
}
public class BG25_155:MinionBase{
//NAME=宝石走私商
//TEXT=<b>战吼：</b>对你的所有其他随从各使用一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=QUILBOAR
}
public class BG25_155_G:MinionBase{
//NAME=宝石走私商
//TEXT=<b>战吼：</b>对你的所有其他随从各使用2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=8|RACE=QUILBOAR
}
public class BG25_165:MinionBase{
//NAME=砰砰箱博士
//TEXT=<b>亡语：</b>对2个距离最近的敌方随从造成7点伤害。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=1|RACE=MECHANICAL
	private float GetX(int myindex,int myN)
	{
        float minx = -11.86f;
        float maxx = 11.21f;
        float cx = (minx + maxx) / 2f;
        float bw = (maxx - minx);
        float c1 = -bw / 12f;
        float c2 = bw / 6f;
        float myx= cx + c1 * (myN - 1) + c2 * myindex;
        return myx;
	}
	public override void Deathrattle()
	{
		float myX = GetX(owner.myPlayer.board.IndexOf(owner),owner.myPlayer.board.Count);
		Card Near1 = null;
		float Dis1 = 1000f;
		Card Near2 = null;
		float Dis2 = 1000f;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)<=0)
			{
				continue;
			}
			float X1 = GetX(owner.myPlayer.otherPlayer.board.IndexOf(c),owner.myPlayer.otherPlayer.board.Count);
			float Dis = X1-myX;
			if(Dis<0)
			{

				Dis=-Dis;
			}
			if(Near1==null)
			{
				Near1=c;
				Dis1=Dis;
			}
			else{
				if(Near2==null)
				{
					Near2=c;
					Dis2=Dis;
				}
				else{
					if(Dis<Dis1)
					{
						Near2=Near1;
						Dis2=Dis1;

						Near1=c;
						Dis1=Dis;
					}
					else{
						if(Dis<Dis2)
						{
							Near2=c;
							Dis2=Dis;
						}
					}
				}
			}
		}
		List<Card> ToDmg = new List<Card>();
		if(Near1!=null)
		{
			ToDmg.Add(Near1);
		}
		if(Near2!=null)
		{
			ToDmg.Add(Near2);
		}
		TaskDamageTargets(ToDmg,7);
	}
}
public class BG25_165_G:MinionBase{
//NAME=砰砰箱博士
//TEXT=<b>亡语：</b>对2个距离最近的敌方随从造成14点伤害。
//MAJ=NEUTRAL|COST=4|ATK=14|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	private float GetX(int myindex,int myN)
	{
        float minx = -11.86f;
        float maxx = 11.21f;
        float cx = (minx + maxx) / 2f;
        float bw = (maxx - minx);
        float c1 = -bw / 12f;
        float c2 = bw / 6f;
        float myx= cx + c1 * (myN - 1) + c2 * myindex;
        return myx;
	}
	public override void Deathrattle()
	{
		float myX = GetX(owner.myPlayer.board.IndexOf(owner),owner.myPlayer.board.Count);
		Card Near1 = null;
		float Dis1 = 1000f;
		Card Near2 = null;
		float Dis2 = 1000f;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)<=0)
			{
				continue;
			}
			float X1 = GetX(owner.myPlayer.otherPlayer.board.IndexOf(c),owner.myPlayer.otherPlayer.board.Count);
			float Dis = X1-myX;
			if(Dis<0)
			{
				Dis=-Dis;
			}
			if(Near1==null)
			{
				Near1=c;
				Dis1=Dis;
			}
			else{
				if(Near2==null)
				{
					Near2=c;
					Dis2=Dis;
				}
				else{
					if(Dis<Dis1)
					{
						Near2=Near1;
						Dis2=Dis1;

						Near1=c;
						Dis1=Dis;
					}
					else{
						if(Dis<Dis2)
						{
							Near2=c;
							Dis2=Dis;
						}
					}
				}
			}
		}
		List<Card> ToDmg = new List<Card>();
		if(Near1!=null)
		{
			ToDmg.Add(Near1);
		}
		if(Near2!=null)
		{
			ToDmg.Add(Near2);
		}
		TaskDamageTargets(ToDmg,14);
	}
}
public class BG25_309:MinionBase{
//NAME=达基萨斯将军
//TEXT=<b>战吼：</b>获取一张2/1并具有“<b>战吼：</b>使一条龙获得+5攻击力”的燃翼。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=8|RACE=DRAGON
}
public class BG25_309_G:MinionBase{
//NAME=达基萨斯将军
//TEXT=<b>战吼：</b>获取两张2/1并具有“<b>战吼：</b>使一条龙获得+5攻击力”的燃翼。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=16|RACE=DRAGON
}
public class BG25_309_Ge:Ability{
//NAME=燎火
//TEXT=+10攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_309_Gt:MinionBase{
//NAME=燃翼
//TEXT=<b>战吼：</b>使一条龙获得+10攻击力。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=2|RACE=DRAGON
}
public class BG25_309e:Ability{
//NAME=燎火
//TEXT=+5攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_309t:MinionBase{
//NAME=燃翼
//TEXT=<b>战吼：</b>使一条龙获得+5攻击力。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=1|RACE=DRAGON
}
public class BG25_354:MinionBase{
//NAME=提图斯·瑞文戴尔
//TEXT=你的<b>亡语</b>额外触发一次。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=7|RACE=NONE
	public override void Init()
	{
		//owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterDestroy(this,this.CauseEvent));
	}
	public void CauseEvent(Card source, Card target)
	{
		if(CondInPlay())
		{
			for(int i=0;i<1;i++)
			{
	            if (target.abilityList.Count != 0)
	            {
	                for (int j = 0; j < target.abilityList.Count; j++)
	                {
	                    target.abilityList[j].Deathrattle();
	                }
	            }				
			}
		}
	}
}
public class BG25_354_G:MinionBase{
//NAME=提图斯·瑞文戴尔
//TEXT=你的<b>亡语</b>额外触发两次。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=14|RACE=NONE
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterDestroy(this,this.CauseEvent));
	}
	public void CauseEvent(Card source, Card target)
	{
		if(CondInPlay())
		{
			for(int i=0;i<2;i++)
			{
	            if (target.abilityList.Count != 0)
	            {
	                for (int j = 0; j < target.abilityList.Count; j++)
	                {
	                    target.abilityList[j].Deathrattle();
	                }
	            }				
			}
		}
	}
}
public class BG25_399:MinionBase{
//NAME=电台明星
//TEXT=<b>亡语：</b>获取击杀本随从的随从的一张原始版复制。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class BG25_399_G:MinionBase{
//NAME=电台明星
//TEXT=<b>亡语：</b>获取击杀本随从的随从的2张原始版复制。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=4|RACE=UNDEAD
}
public class BG25_520:MinionBase{
//NAME=吸血地狱犬
//TEXT=购买本随从会消耗生命值，而非铸币。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class BG25_520_G:MinionBase{
//NAME=吸血地狱犬
//TEXT=购买本随从会消耗生命值，而非铸币。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=DEMON
}
public class BG25_806:MinionBase{
//NAME=狡猾的迅猛龙
//TEXT=<b>亡语：</b>随机召唤一只野兽，其属性值变为7/7。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=3|RACE=BEAST
	public override void Deathrattle()
	{
		Card Created = TaskCreate(CardDbf.AllBGSbeastDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		new EffectChange(owner.myPlayer,owner,Created,atkChange:7-Created.GetTag(GameTag.Attack),hpChange:7-Created.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG25_806_G:MinionBase{
//NAME=狡猾的迅猛龙
//TEXT=<b>亡语：</b>随机召唤一只野兽，其属性值变为14/14。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		Card Created = TaskCreate(CardDbf.AllBGSbeastDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		new EffectChange(owner.myPlayer,owner,Created,atkChange:14-Created.GetTag(GameTag.Attack),hpChange:14-Created.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG25_806_Ge:Ability{
//NAME=重获自由
//TEXT=属性值变为14/14。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_806e:Ability{
//NAME=重获自由
//TEXT=属性值变为7/7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_807:MinionBase{
//NAME=机械加拉克苏斯
//TEXT=<b>战吼：</b>随机获取一张机械-恶魔牌。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=15|RACE=DEMON
}
public class BG25_807_G:MinionBase{
//NAME=机械加拉克苏斯
//TEXT=<b>战吼：</b>随机获取2张机械-恶魔牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=30|RACE=DEMON
}
public class BG25_807e:Ability{
//NAME=铁锈君王
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_807e2:Ability{
//NAME=终极玛瑟里顿
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_807e3:Ability{
//NAME=巴萨拉克
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_807t:MinionBase{
//NAME=铁锈君王
//TEXT=<b>风怒</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=5|RACE=MECHANICAL
}
public class BG25_807t2:MinionBase{
//NAME=终极玛瑟里顿
//TEXT=<b>嘲讽</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=1|HP=10|RACE=MECHANICAL
}
public class BG25_807t2_G:MinionBase{
//NAME=终极玛瑟里顿
//TEXT=<b>嘲讽</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=20|RACE=MECHANICAL
}
public class BG25_807t3:MinionBase{
//NAME=巴萨拉克
//TEXT=<b>复生</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=1|RACE=MECHANICAL
}
public class BG25_807t3_G:MinionBase{
//NAME=巴萨拉克
//TEXT=<b>复生</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=20|HP=2|RACE=MECHANICAL
}
public class BG25_807t_G:MinionBase{
//NAME=铁锈君王
//TEXT=<b>风怒</b>。可以<b>磁力</b>吸附在机械<i>和</i>恶魔上。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=10|RACE=MECHANICAL
}
public class BG25_807t_Ge:Ability{
//NAME=铁锈君王
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_901e:Ability{
//NAME=赛博格强化
//TEXT=+10攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_901e2:Ability{
//NAME=赛博格强化
//TEXT=+20攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_922:MinionBase{
//NAME=烟火狂热者
//TEXT=每当你获取一个你已有的随从，使你的随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class BG25_922_G:MinionBase{
//NAME=烟火狂热者
//TEXT=每当你获取一个你已有的随从，使你的随从获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=6|RACE=NONE
}
public class BG25_922_Ge:Ability{
//NAME=烟火飞腾
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_922e:Ability{
//NAME=烟火飞腾
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_100:HeroBase{
//NAME=普崔塞德教授
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_100_Buddy:MinionBase{
//NAME=烂肠
//TEXT=<b>亡语：</b>随机召唤一个亡灵造物。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=2|RACE=UNDEAD
}
public class BG25_HERO_100_Buddy_G:MinionBase{
//NAME=烂肠
//TEXT=<b>亡语：</b>随机召唤2个亡灵造物。
//MAJ=NEUTRAL|COST=3|ATK=12|HP=4|RACE=UNDEAD
}
public class BG25_HERO_100_SKIN_A:HeroBase{
//NAME=石油大亨普崔塞德
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_100_SKIN_B:HeroBase{
//NAME=疯帽客普崔塞德
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_100p:HeroPowerBase{
//NAME=构造亡灵
//TEXT=制造一个自定义的亡灵。<i>（还剩{0}件作品！）</i>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_100pt:MinionBase{
//NAME=普崔塞德的作品
//TEXT={0}{1}
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=UNDEAD
}
public class BG25_HERO_103:HeroBase{
//NAME=塔隆·血魔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_103_Buddy:MinionBase{
//NAME=阴暗构造体
//TEXT=<b>亡语：</b>使另一个友方随从获得本随从的最大属性值。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=UNDEAD
}
public class BG25_HERO_103_Buddy_G:MinionBase{
//NAME=阴暗构造体
//TEXT=<b>亡语：</b>使另一个友方随从获得本随从的最大属性值，触发两次。
//MAJ=NEUTRAL|COST=3|ATK=10|HP=10|RACE=UNDEAD
}
public class BG25_HERO_103_Buddy_Ge:Ability{
//NAME=从阴影中来
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_103_Buddye:Ability{
//NAME=从阴影中来
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_103_SKIN_A:HeroBase{
//NAME=摆渡人塔隆
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_103_SKIN_B:HeroBase{
//NAME=牛仔塔隆
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_103_SKIN_C:HeroBase{
//NAME=天狗塔隆
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_103p:HeroPowerBase{
//NAME=飞速复活
//TEXT=选择一个友方随从。<b>战斗开始时：</b>将其消灭。当你有空位时，重新召唤一个完全相同的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_103pe:Ability{
//NAME=死亡迫近
//TEXT=会被消灭然后复活。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG25_HERO_105:HeroBase{
//NAME=乐队经理精英牛头人酋长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_105_Buddy:MinionBase{
//NAME=星探
//TEXT=<b>战吼：</b>使一个<b>伙伴</b>变为金色。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class BG25_HERO_105_Buddy_G:MinionBase{
//NAME=星探
//TEXT=<b>战吼：</b>使一个<b>伙伴</b>变为金色。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=NONE
}
public class BG25_HERO_105_SKIN_A:HeroBase{
//NAME=火热牛头人酋长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_105_SKIN_C:HeroBase{
//NAME=舞龙精英牛头人酋长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_105_SKIN_D:HeroBase{
//NAME=魔王经理精英牛头人酋长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG25_HERO_105p:HeroPowerBase{
//NAME=签约新人
//TEXT=<b>发现</b>一个<b>伙伴</b>。<i>（等级2时解锁。）</i>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
