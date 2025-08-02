using System.Collections;
using System.Collections.Generic;

public class BG22_001:MinionBase{
//NAME=幼年克鲁什
//TEXT=每当本随从攻击时，召唤一只8/8的魔暴龙，并使其率先攻击目标。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=BEAST
	public override void BeforeAttack(Card target = null)
	{
		if(owner.myPlayer.board.Count<owner.myPlayer.maxnum[(int)ZoneType.Board])
		{
			Card Summon = TaskCreate(CardDbf.GetCardDbfByGuid("BG22_001t2"),ZoneType.Board);
			if(Summon.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,Summon).Resolve();
				new EffectAttack(owner.myPlayer,Summon,target).Resolve();

			}	
		}
	}
}
public class BG22_001_G:MinionBase{
//NAME=幼年克鲁什
//TEXT=每当本随从攻击时，召唤一只16/16的魔暴龙，并使其率先攻击目标。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=12|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void BeforeAttack(Card target = null)
	{
		if(owner.myPlayer.board.Count<owner.myPlayer.maxnum[(int)ZoneType.Board])
		{
			Card Summon = TaskCreate(CardDbf.GetCardDbfByGuid("BG22_001t2_G"),ZoneType.Board);
			if(Summon.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,Summon).Resolve();
				new EffectAttack(owner.myPlayer,Summon,target).Resolve();
			}
		}
	}
}
public class BG22_001e:Ability{
//NAME=Baby Krush
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_001t2:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class BG22_001t2_G:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=16|HP=16|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_202:MinionBase{
//NAME=塔德
//TEXT=当你出售本随从时，随机获取一张鱼人牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class BG22_202_G:MinionBase{
//NAME=塔德
//TEXT=当你出售本随从时，随机获取2张鱼人牌。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_401:MinionBase{
//NAME=沼泽前锋
//TEXT=在你召唤一个鱼人后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=5|RACE=MURLOC
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Murloc) && sc!=owner && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
			}
		}
	}
}
public class BG22_401_G:MinionBase{
//NAME=沼泽前锋
//TEXT=在你召唤一个鱼人后，获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=10|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Murloc) && sc!=owner && tz==ZoneType.Board)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
			}
		}
	}
}
public class BG22_401_Ge:Ability{
//NAME=沉溺沼泽
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_401e:Ability{
//NAME=沉溺沼泽
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_402:MinionBase{
//NAME=螳螂妖女皇
//TEXT=<b>烈毒</b>。<b>战斗开始时：</b>你每有一个随从类型，便从 +5/+5，<b>风怒</b>，<b>复生</b>或<b>嘲讽</b>中获得一项。
//MAJ=NEUTRAL|COST=1|ATK=5|HP=5|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Toxic");
		
	}
	private List<string> abis = new List<string>(){"Taunt","WindFury","Reborn"};
	public override void OnCombatStart()
	{
		if(CondInPlay())
		{
			if(abis.Count>0)
			{
				string Get = abis.Choice(owner.myPlayer.randomGen);
				if(Get!=null)
				{
					new EffectGiveAbility(owner.myPlayer,owner,owner,Get).Resolve();
					abis.Remove(Get);
				}
			}
			else{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:5,hpChange:5).Resolve();
			}
		}
	}
}
public class BG22_402_G:MinionBase{
//NAME=螳螂妖女皇
//TEXT=<b>烈毒</b>。<b>战斗开始时：</b>你每有一个随从类型，便从+5/+5，<b>风怒</b>，<b>复生</b>或<b>嘲讽</b>中获得一项。触发两次。
//MAJ=NEUTRAL|COST=1|ATK=10|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Toxic");
		
	}
	private List<string> abis = new List<string>(){"Taunt","WindFury","Reborn"};
	public override void OnCombatStart()
	{
		if(CondInPlay())
		{
			if(abis.Count>0)
			{
				string Get = abis.Choice(owner.myPlayer.randomGen);
				if(Get!=null)
				{
					new EffectGiveAbility(owner.myPlayer,owner,owner,Get).Resolve();
					abis.Remove(Get);
				}
			}
			else{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:5,hpChange:5).Resolve();
			}
		}
	}
}
public class BG22_402e:Ability{
//NAME=皇室风采
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_402e2:Ability{
//NAME=皇室迅捷
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_402e3:Ability{
//NAME=皇室庇护
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_402e4:Ability{
//NAME=皇室禁令
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_403:MinionBase{
//NAME=小瞎眼
//TEXT=在你的回合结束时，相邻的随从触发其<b>战吼</b>。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=5|RACE=MURLOC
}
public class BG22_403_G:MinionBase{
//NAME=小瞎眼
//TEXT=在你的回合结束时，相邻的随从触发其<b>战吼</b>，触发两次。
//MAJ=NEUTRAL|COST=6|ATK=16|HP=10|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_404:MinionBase{
//NAME=朋友的朋友
//TEXT=当你出售本随从时，<b>发现</b>一个<b>伙伴</b>。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=6|RACE=NONE
}
public class BG22_404_G:MinionBase{
//NAME=朋友的朋友
//TEXT=当你出售本随从时，<b>发现</b>2个<b>伙伴</b>。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_BuddyMeter:Ability{
//NAME=伙伴计量槽
//TEXT=
//MAJ=NEUTRAL|COST=24|ATK=0|HP=0|RACE=NONE
}
public class BG22_BuddyPlayerEnch:Ability{
//NAME=Buddy Player Enchantment [DNT]
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_BuddySpell:SpellBase{
//NAME=收买伙伴
//TEXT=获取你的伙伴！<i>（胜利/平局-消耗的铸币减少3枚）（失败-消耗的铸币减少2枚）</i>
//MAJ=NEUTRAL|COST=24|ATK=0|HP=0|RACE=NONE
}
public class BG22_BuddySpell_2:SpellBase{
//NAME=收买2个伙伴
//TEXT=获取2个伙伴！<i>（胜利/平局-消耗的铸币减少3枚）（失败-消耗的铸币减少2枚）</i>
//MAJ=NEUTRAL|COST=24|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000:HeroBase{
//NAME=塔维什·雷矛
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_000_Buddy:MinionBase{
//NAME=大钳蟹
//TEXT=在你的英雄技能造成伤害后，使相邻的随从获得等同于所造成伤害的属性值。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=3|RACE=BEAST
}
public class BG22_HERO_000_Buddy_e:Ability{
//NAME=大钳蟹
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000_Buddy_G:MinionBase{
//NAME=大钳蟹
//TEXT=在你的英雄技能造成伤害后，使相邻的随从获得等同于所造成伤害两倍的属性值。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class BG22_HERO_000_SKIN_A:HeroBase{
//NAME=侦查大师塔维什
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_000_SKIN_B:HeroBase{
//NAME=酒馆歌手塔维什
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_000_SKIN_C:HeroBase{
//NAME=远射手塔维什
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_000_SKIN_D:HeroBase{
//NAME=塔维什·雨矛
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_000p:HeroPowerBase{
//NAME=致命狙击
//TEXT=瞄准敌人！<b>战斗开始时：</b>对你的目标造成{1}点伤害。<i>（每{0}回合翻倍！）</i>3瞄准敌人！<b>战斗开始时：</b>对你的目标造成{1}点伤害。<i>（{0}回合后翻倍！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000p_t1:HeroPowerBase{
//NAME=瞄准左边！
//TEXT=<b>被动 战斗开始时：</b>对最左边的敌方随从造成{1}点伤害。<i>（{0}回合后翻倍！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000p_t2:HeroPowerBase{
//NAME=瞄准低处！
//TEXT=<b>被动 战斗开始时：</b>对生命值最低的敌方随从造成{1}点伤害。<i>（{0}回合后翻倍！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000p_t3:HeroPowerBase{
//NAME=瞄准高处！
//TEXT=<b>被动 战斗开始时：</b>对生命值最高的敌方随从造成{1}点伤害。<i>（{0}回合后翻倍！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_000p_t4:HeroPowerBase{
//NAME=瞄准右边！
//TEXT=<b>被动 战斗开始时：</b>对最右边的敌方随从造成{1}点伤害。<i>（{0}回合后翻倍！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001:HeroBase{
//NAME=布鲁坎
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_001_Buddy:MinionBase{
//NAME=幽灵迅猛龙
//TEXT=在你唤起一种新的元素后，记住该元素。<b>亡语：</b>唤起记住的元素。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class BG22_HERO_001_Buddy_e:Ability{
//NAME=元素记忆
//TEXT=记住一种元素。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001_Buddy_e1:Ability{
//NAME=大地记忆
//TEXT=记住大地祈咒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001_Buddy_e2:Ability{
//NAME=火焰记忆
//TEXT=记住火焰祈咒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001_Buddy_e3:Ability{
//NAME=流水记忆
//TEXT=记住流水祈咒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001_Buddy_e4:Ability{
//NAME=闪电记忆
//TEXT=记住闪电祈咒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001_Buddy_G:MinionBase{
//NAME=幽灵迅猛龙
//TEXT=在你唤起一种新的元素后，记住该元素。<b>亡语：</b>唤起记住的元素两次。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=4|RACE=UNDEAD
}
public class BG22_HERO_001_SKIN_A:HeroBase{
//NAME=受缚天灾布鲁坎
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_001_SKIN_B:HeroBase{
//NAME=摇滚之神布鲁坎
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_001_SKIN_C:HeroBase{
//NAME=祈求者布鲁坎
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_001p:HeroPowerBase{
//NAME=拥抱元素
//TEXT=选择一个元素。<b>战斗开始时：</b>唤起选择的元素。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t1:HeroPowerBase{
//NAME=大地祈咒
//TEXT=<b>战斗开始时：</b>随机使4个友方随从获得“<b>亡语：</b>召唤一个1/1的元素。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t1_s:SpellBase{
//NAME=大地祈咒
//TEXT=随机使4个友方随从获得“<b>亡语：</b>召唤一个1/1的元素。”
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t1e:Ability{
//NAME=元素：大地
//TEXT=<b>亡语：</b>召唤一个1/1的元素。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t1et:MinionBase{
//NAME=石元素
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class BG22_HERO_001p_t1et_G:MinionBase{
//NAME=石元素
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=ELEMENTAL
}
public class BG22_HERO_001p_t2:HeroPowerBase{
//NAME=火焰祈咒
//TEXT=<b>战斗开始时：</b>使你最左边的随从的攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t2_s:SpellBase{
//NAME=火焰祈咒
//TEXT=使你最左边的随从的攻击力翻倍。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t2e:Ability{
//NAME=元素：火焰
//TEXT=攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t3:HeroPowerBase{
//NAME=流水祈咒
//TEXT=<b>战斗开始时：</b>使你最右边的随从获得+3生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t3_s:SpellBase{
//NAME=流水祈咒
//TEXT=使你最右边的随从获得+3生命值和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t3e:Ability{
//NAME=元素：流水
//TEXT=+3生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t4:HeroPowerBase{
//NAME=闪电祈咒
//TEXT=<b>战斗开始时：</b>随机对5个敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_001p_t4_s:SpellBase{
//NAME=闪电祈咒
//TEXT=随机对5个敌方随从造成1点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_002_Buddy:MinionBase{
//NAME=霜狼军官
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=7|HP=4|RACE=NONE
}
public class BG22_HERO_002_Buddy_e:Ability{
//NAME=军官的引领
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002_Buddy_G:MinionBase{
//NAME=霜狼军官
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=14|HP=8|RACE=NONE
}
public class BG22_HERO_002_Buddy_Ge:Ability{
//NAME=军官的引领
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002_Buddye:Ability{
//NAME=霜狼玩家附加效果
//TEXT=霜狼军官使酒馆中的随从攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002_SKIN_A:HeroBase{
//NAME=蹦迪德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_002_SKIN_B:HeroBase{
//NAME=天灾之狼德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_002_SKIN_C:HeroBase{
//NAME=挑战者德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_002_SKIN_D:HeroBase{
//NAME=强盗德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_002e:Ability{
//NAME=军官的引领
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002p:HeroPowerBase{
//NAME=统率霜狼
//TEXT=<b>被动</b> <b>复仇（2）：</b>使你的随从永久获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002pe:Ability{
//NAME=霜狼热血
//TEXT=直到下个回合，复制最高的攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002pe2:Ability{
//NAME=Attack Set Until Next Turn
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_002pe3:Ability{
//NAME=Modified Attack Until Next Turn
//TEXT=Attack is increased or decreased until next turn.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_003_Buddy:MinionBase{
//NAME=雷矛军官
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的随从拥有+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=7|RACE=NONE
}
public class BG22_HERO_003_Buddy_e:Ability{
//NAME=军官的引领
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003_Buddy_G:MinionBase{
//NAME=雷矛军官
//TEXT=<b>复仇（2）：</b>在本局对战中，酒馆中的随从拥有+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=14|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_HERO_003_Buddy_Ge:Ability{
//NAME=军官的引领
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003_Buddye:Ability{
//NAME=雷矛玩家附加效果
//TEXT=雷矛军官使酒馆中的随从生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003_SKIN_A:HeroBase{
//NAME=指挥官范达尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_003_SKIN_B:HeroBase{
//NAME=雷鸣风笛范达尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_003_SKIN_C:HeroBase{
//NAME=警官范达尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_003_SKIN_D:HeroBase{
//NAME=矿洞住民范达尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_003e:Ability{
//NAME=军官的引领
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003p:HeroPowerBase{
//NAME=统率雷矛
//TEXT=<b>被动</b> <b>复仇（2）：</b>使你的随从永久获得+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003pe:Ability{
//NAME=雷矛之力
//TEXT=直到下个回合，复制最高的生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003pe2:Ability{
//NAME=Health Set Until Next Turn
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_003pe3:Ability{
//NAME=Modified Health Until Next Turn
//TEXT=Health is increased or decreased until next turn.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_004:HeroBase{
//NAME=瓦尔登·晨拥
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_004_Buddy:MinionBase{
//NAME=瓦尔登的水波勇士
//TEXT=好事成霜还会使这两个随从获得等同于你当前等级的属性值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class BG22_HERO_004_Buddy_e2:Ability{
//NAME=冰寒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_004_Buddy_G:MinionBase{
//NAME=瓦尔登的水波勇士
//TEXT=好事成霜还会使这两个随从获得等同于你当前等级的属性值，获得两次。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=12|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG22_HERO_004_SKIN_A:HeroBase{
//NAME=晨光守护者瓦尔登
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_004_SKIN_B:HeroBase{
//NAME=魔导师晨拥
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_004_SKIN_C:HeroBase{
//NAME=瓦格里瓦尔登
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_004_SKIN_D:HeroBase{
//NAME=艾泽里特瓦尔登
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_004p:HeroPowerBase{
//NAME=好事成霜
//TEXT=<b>被动</b> 在酒馆被<b>刷新</b>后，复制等级最高的随从并<b>冻结</b>这两个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_007:HeroBase{
//NAME=艾萨拉女王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_007_Buddy:MinionBase{
//NAME=皇家守护者
//TEXT=每当你对一个不同的友方随从施放<b>塑造法术</b>的法术时，还会对本随从施放。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=8|RACE=NAGA
}
public class BG22_HERO_007_Buddy_G:MinionBase{
//NAME=皇家守护者
//TEXT=每当你对一个不同的友方随从施放<b>塑造法术</b>的法术时，还会对本随从施放两次。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=16|RACE=NAGA
}
public class BG22_HERO_007_SKIN_A:HeroBase{
//NAME=仲夏女王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_007_SKIN_At:HeroBase{
//NAME=仲夏纳迦女王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_007_SKIN_B:HeroBase{
//NAME=管理者艾萨拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_007_SKIN_Bt:HeroBase{
//NAME=熔火女王艾萨拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_007p:HeroPowerBase{
//NAME=艾萨拉的野心
//TEXT=<b>被动</b> 当你的战队总计达到25点攻击力时，开启纳迦远征。0<b>被动</b> 当你的战队总计达到25点攻击力时，开启纳迦远征。<i>（还剩{0}点！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_007p2:HeroPowerBase{
//NAME=纳迦远征
//TEXT=<b>发现</b>一张纳迦牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_007t:HeroBase{
//NAME=纳迦女王艾萨拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_00e_Buddye:Ability{
//NAME=雷矛玩家附加效果
//TEXT=酒馆中的随从攻击力提升。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_200:HeroBase{
//NAME=伊妮·积雷
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_200_Buddy:MinionBase{
//NAME=潜水清扫机
//TEXT=在你使用一张机械牌后，获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=MECHANICAL
}
public class BG22_HERO_200_Buddy_e:Ability{
//NAME=扫到宝贝
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_200_Buddy_G:MinionBase{
//NAME=潜水清扫机
//TEXT=在你使用一张机械牌后，获得+4/+4。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=MECHANICAL
}
public class BG22_HERO_200_Buddy_Ge:Ability{
//NAME=扫到宝贝
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_200_SKIN_A:HeroBase{
//NAME=雪王伊妮
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_200_SKIN_B:HeroBase{
//NAME=脉冲大师伊妮
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_200_SKIN_C:HeroBase{
//NAME=雷霆战甲伊妮
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_200p:HeroPowerBase{
//NAME=敲打机械
//TEXT=<b>被动</b> 在10个友方随从死亡后，随机获取一张机械牌。10<b>被动</b> 在10个友方随从死亡后，随机获取一张机械牌。<i>（还剩{0}个！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_201:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_201_Buddy:MinionBase{
//NAME=水下大厨
//TEXT=<b>战吼：</b>获取等级1，3和5的随机随从牌各一张。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=NONE
}
public class BG22_HERO_201_Buddy_G:MinionBase{
//NAME=水下大厨
//TEXT=<b>战吼：</b>随机获取等级1，3和5的随从牌各2张。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=NONE
}
public class BG22_HERO_201_SKIN_A:HeroBase{
//NAME=费林伯爵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_201_SKIN_B:HeroBase{
//NAME=银月护卫费林
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_201_SKIN_C:HeroBase{
//NAME=贵族费林
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_201_SKIN_D:HeroBase{
//NAME=善念费林
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_201p:HeroPowerBase{
//NAME=远行计划
//TEXT=<b>被动</b> 跳过你的第一个回合。<b>发现</b>等级2，4和6的随从各一个，当你达到对应等级时才可使用。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_201pe:Ability{
//NAME=无法使用
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_305:HeroBase{
//NAME=奥妮克希亚
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_305_Buddy:MinionBase{
//NAME=雏龙群
//TEXT=每当你召唤一条雏龙，永久获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=DRAGON
}
public class BG22_HERO_305_Buddy_e:Ability{
//NAME=群拥
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_305_Buddy_G:MinionBase{
//NAME=雏龙群
//TEXT=每当你召唤一条雏龙，永久获得+4/+4。
//MAJ=NEUTRAL|COST=2|ATK=8|HP=4|RACE=DRAGON
}
public class BG22_HERO_305_Buddy_Ge:Ability{
//NAME=群拥
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_305_SKIN_A4:HeroBase{
//NAME=噩兆召唤者普瑞斯托
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_305_SKIN_B:HeroBase{
//NAME=弹簧飞翼奥妮克希亚
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_305_SKIN_C:HeroBase{
//NAME=普瑞斯托教授
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG22_HERO_305p:HeroPowerBase{
//NAME=巢母
//TEXT=<b>被动</b> <b>复仇（4）：</b>召唤一条3/1的雏龙，并使其立即发起攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG22_HERO_305t:MinionBase{
//NAME=奥妮克希亚雏龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=3|HP=1|RACE=DRAGON
}
public class BG22_HERO_305t_G:MinionBase{
//NAME=奥妮克希亚雏龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=6|HP=2|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
}
