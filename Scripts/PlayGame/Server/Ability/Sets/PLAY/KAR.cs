using System.Collections;
using System.Collections.Generic;

public class KAR_004:SecretBase{
//NAME=豹子戏法
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，召唤一只4/2并具有<b>潜行</b>的猎豹。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class KAR_004a:MinionBase{
//NAME=绅士豹
//TEXT=<b>潜行</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class KAR_005:MinionBase{
//NAME=慈祥的外婆
//TEXT=<b>亡语：</b>召唤一只3/2的大灰狼。
//MAJ=HUNTER|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class KAR_005a:MinionBase{
//NAME=大灰狼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class KAR_006:MinionBase{
//NAME=神秘女猎手
//TEXT=你的<b>奥秘</b>牌法力值消耗为（0）点。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class KAR_009:MinionBase{
//NAME=呓语魔典
//TEXT=<b>战吼：</b>随机将一张法师法术牌置入你的 手牌。
//MAJ=MAGE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class KAR_010:MinionBase{
//NAME=夜魇骑士
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便召唤两条1/1的雏龙。
//MAJ=PALADIN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class KAR_010a:MinionBase{
//NAME=雏龙
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=DRAGON
}
public class KAR_011:MinionBase{
//NAME=自负的演员
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class KAR_013:SpellBase{
//NAME=净化
//TEXT=<b>沉默</b>一个友方随从，抽一张牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class KAR_021:MinionBase{
//NAME=邪恶的巫医
//TEXT=每当你施放一个法术，随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class KAR_025:SpellBase{
//NAME=附灵术
//TEXT=召唤一个1/1的蜡烛，2/2的扫帚和3/3的茶壶。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=NONE
}
public class KAR_025a:MinionBase{
//NAME=蜡烛
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class KAR_025b:MinionBase{
//NAME=扫帚
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=NONE
}
public class KAR_025c:MinionBase{
//NAME=茶壶
//TEXT=
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class KAR_026:SpellBase{
//NAME=保卫国王
//TEXT=战场上每有一个敌方随从，便召唤一个1/1并具有<b>嘲讽</b>的 禁卫。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class KAR_026t:MinionBase{
//NAME=禁卫
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=1|ATK=1|HP=1|RACE=NONE
}
public class KAR_028:WeaponBase{
//NAME=愚者之灾
//TEXT=每个回合攻击次数不限，但无法攻击英雄。
//MAJ=WARRIOR|COST=5|ATK=3|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		base.RegisterEventEffect();
		owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent2));
	}
	private int CNT=1;

	public void CauseEvent2(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sz==ZoneType.Board && tz==ZoneType.Grave)
			{
				if(sc.myPlayer==owner.myPlayer.otherPlayer)
				{
					new EffectChange(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],atkChange:1).Resolve();
					if (owner.myPlayer.otherPlayer.board.Count==0)
					{
						for(int i=0;i<3;i++)
						{
							Card ToCreate = new Card(CardDbf.GetCardDbfByGuid("ICC_900t"),owner.myPlayer.otherPlayer);
							ToCreate.PropertyArr[(int)GameTag.AttackMod] = CNT;
							ToCreate.PropertyArr[(int)GameTag.HealthMod] = CNT;
							new EffectCreate(owner.myPlayer.otherPlayer,ToCreate,ZoneType.Board).Resolve();
						}
						CNT+=1;
					}
				}
			}
		}
	}
	public override void Battlecry(Card target = null)
	{

	}

	public override void AfterAttack(Card target = null)
	{
		if(CondInPlay())
		{
			string Db = "VAN_EX1_409";
			switch(owner.myPlayer.hero[0].cardDbf.Classes[0])
			{
				case(ClassType.DeathKnight):
					Db="RLK_087";
					break;
				case(ClassType.DemonHunter):
					Db="REV_834";
					break;
				case(ClassType.Druid):
					Db="CS2_005";
					break;
				case(ClassType.Hunter):
					Db="EX1_538";
					break;
				case(ClassType.Mage):
					Db="EX1_277";
					break;
				case(ClassType.Paladin):
					Db="TRL_302";
					break;
				case(ClassType.Priest):
					Db="EX1_192";
					break;
				case(ClassType.Rogue):
					Db="BAR_321";
					break;
				case(ClassType.Shaman):
					Db="TOY_500";
					break;
				case(ClassType.Warlock):
					Db="EX1_312";
					break;
				case(ClassType.Warrior):
					Db="VAN_EX1_409";
					break;		
				default:
					break;
			}

			Card c = TaskCreate(CardDbf.GetCardDbfByGuid(Db),ZoneType.Hand);
			owner.myPlayer.hero[0].SetTag(GameTag.AttacksLeftThisTurn,10000);
			new EffectPlay(owner.myPlayer,c,target).Resolve();

		}
	}
}
public class KAR_029:MinionBase{
//NAME=符文蛋
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=NONE
}
public class KAR_030:MinionBase{
//NAME=地窖蜘蛛
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=BEAST
}
public class KAR_030a:MinionBase{
//NAME=橱柜蜘蛛
//TEXT=<b>战吼：</b>召唤一只1/3的蜘蛛。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=BEAST
}
public class KAR_033:MinionBase{
//NAME=书卷之龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则消灭一个攻击力小于或等于3的敌方随从。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=6|RACE=DRAGON
}
public class KAR_035:MinionBase{
//NAME=宴会牧师
//TEXT=每当你施放一个法术，为你的英雄恢复#3点生命值。
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=NONE
}
public class KAR_036:MinionBase{
//NAME=奥术畸体
//TEXT=在你施放一个法术后，使本随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class KAR_036_Puzzle:MinionBase{
//NAME=奥术畸体
//TEXT=在你施放一个法术后，使本随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class KAR_036e:Ability{
//NAME=吞食
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_037:MinionBase{
//NAME=鸟禽守护者
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class KAR_037t:Ability{
//NAME=卡拉赞之谜
//TEXT=+1/+1并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_041:MinionBase{
//NAME=沟渠潜伏者
//TEXT=<b>战吼：</b>消灭一个随从。<b>亡语：</b>再次召唤被消灭的随从。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=3|RACE=NONE
}
public class KAR_041e:Ability{
//NAME=沟渠潜伏者
//TEXT=消灭{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_044:MinionBase{
//NAME=莫罗斯
//TEXT=<b>潜行</b> 在你的回合结束时，召唤一个1/1的 家仆。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class KAR_044a:MinionBase{
//NAME=家仆
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class KAR_057:MinionBase{
//NAME=象牙骑士
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。为你的英雄恢复等同于其法力值消耗的生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class KAR_061:MinionBase{
//NAME=馆长
//TEXT=<b>嘲讽，战吼：</b>从你的牌库中抽一张野兽牌、龙牌和鱼人牌。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=6|RACE=MECHANICAL
}
public class KAR_062:MinionBase{
//NAME=虚空幽龙史学家
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b>一张龙牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class KAR_063:WeaponBase{
//NAME=幽灵之爪
//TEXT=当你拥有<b>法术伤害</b>时，拥有 +2攻击力。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=NONE
}
public class KAR_065:MinionBase{
//NAME=展览馆守卫
//TEXT=<b>战吼：</b>选择一个友方野兽，召唤一个它的复制。
//MAJ=DRUID|COST=5|ATK=5|HP=4|RACE=NONE
}
public class KAR_069:MinionBase{
//NAME=吹嘘海盗
//TEXT=<b>战吼：</b>随机将一张另一职业的卡牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=PIRATE
}
public class KAR_070:MinionBase{
//NAME=虚灵商人
//TEXT=<b>战吼：</b>如果你的手牌中有另一职业的卡牌，则其法力值消耗减少（2）点。
//MAJ=ROGUE|COST=5|ATK=5|HP=6|RACE=NONE
}
public class KAR_073:SpellBase{
//NAME=大漩涡传送门
//TEXT=对所有敌方随从造成$1点伤害。随机召唤一个法力值消耗为（1）的随从。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class KAR_075:SpellBase{
//NAME=月光林地传送门
//TEXT=恢复#6点生命值。随机召唤一个法力值消耗为（6）的 随从。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class KAR_076:SpellBase{
//NAME=火焰之地传送门
//TEXT=造成$6点伤害。随机召唤一个法力值消耗为（6）的随从。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
}
public class KAR_077:SpellBase{
//NAME=银月城传送门
//TEXT=使一个随从获得+2/+2。随机召唤一个法力值消耗为（2）的随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class KAR_077e:Ability{
//NAME=白银之力
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_089:MinionBase{
//NAME=玛克扎尔的小鬼
//TEXT=每当你弃掉一张牌时，抽一张牌。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class KAR_091:SpellBase{
//NAME=铁炉堡传送门
//TEXT=获得4点护甲值。随机召唤一个法力值消耗为（4）的 随从。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class KAR_092:MinionBase{
//NAME=麦迪文的男仆
//TEXT=<b>战吼：</b> 如果你控制一个<b>奥秘</b>，则造成3点伤害。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.head.Count>0)
		{
			new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		}
	}
}
public class KAR_094:MinionBase{
//NAME=致命餐叉
//TEXT=<b>亡语：</b>将一张3/2的武器牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class KAR_094a:WeaponBase{
//NAME=锋利餐叉
//TEXT=
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class KAR_095:MinionBase{
//NAME=机械动物管理员
//TEXT=<b>战吼：</b>随机使一个友方野兽，龙和鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		List<Card> CandiBeast = new List<Card>();
		List<Card> CandiDragon = new List<Card>();
		List<Card> CandiMurloc = new List<Card>();

		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast) || c.raceType.Contains(RaceType.All))
			{
				CandiBeast.Add(c);
			}
			else{
				if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
				{
					CandiDragon.Add(c);
				}
				else{
					if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
					{
						CandiMurloc.Add(c);
					}
				}
			}
		}
		Card G1 = CandiBeast.Choice(owner.myPlayer.randomGen);
		Card G2 = CandiDragon.Choice(owner.myPlayer.randomGen);
		Card G3 = CandiMurloc.Choice(owner.myPlayer.randomGen);
		if(G1!=null)
		{
			ToListBuff.Add(G1);
		}
		if(G2!=null)
		{
			ToListBuff.Add(G2);
		}
		if(G3!=null)
		{
			ToListBuff.Add(G3);
		}
		TaskBuffTargets(ToListBuff,atk:1,hp:1);
	}
}
public class KAR_095_G:MinionBase{
//NAME=机械动物管理员
//TEXT=<b>战吼：</b>随机使一个友方野兽，龙和鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		List<Card> CandiBeast = new List<Card>();
		List<Card> CandiDragon = new List<Card>();
		List<Card> CandiMurloc = new List<Card>();

		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast) || c.raceType.Contains(RaceType.All))
			{
				CandiBeast.Add(c);
			}
			else{
				if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
				{
					CandiDragon.Add(c);
				}
				else{
					if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
					{
						CandiMurloc.Add(c);
					}
				}
			}
		}
		Card G1 = CandiBeast.Choice(owner.myPlayer.randomGen);
		Card G2 = CandiDragon.Choice(owner.myPlayer.randomGen);
		Card G3 = CandiMurloc.Choice(owner.myPlayer.randomGen);
		if(G1!=null)
		{
			ToListBuff.Add(G1);
		}
		if(G2!=null)
		{
			ToListBuff.Add(G2);
		}
		if(G3!=null)
		{
			ToListBuff.Add(G3);
		}
		TaskBuffTargets(ToListBuff,atk:2,hp:2);
	}
}
public class KAR_095e:Ability{
//NAME=进食充分
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_096:MinionBase{
//NAME=玛克扎尔王子
//TEXT=<b>对战开始时：</b>额外将五张<b>传说</b>随从牌置入你的牌库。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=6|RACE=DEMON
}
public class KAR_097:MinionBase{
//NAME=守护者麦迪文
//TEXT=<b>战吼：</b> 装备埃提耶什，守护者的传说之杖。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class KAR_097t:WeaponBase{
//NAME=埃提耶什
//TEXT=在你施放一个法术后，随机召唤一个法力值消耗相同的随从。 失去1点耐久度。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
}
public class KAR_114:MinionBase{
//NAME=巴内斯
//TEXT=<b>战吼：</b>随机挑选你牌库里的一个随从，召唤一个1/1的复制。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=NONE
}
public class KAR_114e:Ability{
//NAME=精彩绝伦
//TEXT=攻击力和生命值为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_204:MinionBase{
//NAME=玛瑙主教
//TEXT=<b>战吼：</b>随机召唤一个在本局对战中死亡的友方随从。
//MAJ=PRIEST|COST=4|ATK=3|HP=4|RACE=NONE
}
public class KAR_205:MinionBase{
//NAME=镀银魔像
//TEXT=如果你弃掉了这张随从牌，则会召唤它。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=NONE
}
public class KAR_300:MinionBase{
//NAME=魔法乌鸦
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class KAR_702:MinionBase{
//NAME=展览馆法师
//TEXT=<b>战吼：</b>随机使一个友方野兽，龙和鱼人获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		List<Card> CandiBeast = new List<Card>();
		List<Card> CandiDragon = new List<Card>();
		List<Card> CandiMurloc = new List<Card>();

		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast) || c.raceType.Contains(RaceType.All))
			{
				CandiBeast.Add(c);
			}
			else{
				if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
				{
					CandiDragon.Add(c);
				}
				else{
					if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
					{
						CandiMurloc.Add(c);
					}
				}
			}
		}
		Card G1 = CandiBeast.Choice(owner.myPlayer.randomGen);
		Card G2 = CandiDragon.Choice(owner.myPlayer.randomGen);
		Card G3 = CandiMurloc.Choice(owner.myPlayer.randomGen);
		if(G1!=null)
		{
			ToListBuff.Add(G1);
		}
		if(G2!=null)
		{
			ToListBuff.Add(G2);
		}
		if(G3!=null)
		{
			ToListBuff.Add(G3);
		}
		TaskBuffTargets(ToListBuff,atk:2,hp:2);
	}
}

public class KAR_702_G:MinionBase{
//NAME=展览馆法师
//TEXT=<b>战吼：</b>随机使一个友方野兽，龙和鱼人获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		List<Card> CandiBeast = new List<Card>();
		List<Card> CandiDragon = new List<Card>();
		List<Card> CandiMurloc = new List<Card>();

		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast) || c.raceType.Contains(RaceType.All))
			{
				CandiBeast.Add(c);
			}
			else{
				if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
				{
					CandiDragon.Add(c);
				}
				else{
					if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
					{
						CandiMurloc.Add(c);
					}
				}
			}
		}
		Card G1 = CandiBeast.Choice(owner.myPlayer.randomGen);
		Card G2 = CandiDragon.Choice(owner.myPlayer.randomGen);
		Card G3 = CandiMurloc.Choice(owner.myPlayer.randomGen);
		if(G1!=null)
		{
			ToListBuff.Add(G1);
		}
		if(G2!=null)
		{
			ToListBuff.Add(G2);
		}
		if(G3!=null)
		{
			ToListBuff.Add(G3);
		}
		TaskBuffTargets(ToListBuff,atk:4,hp:4);
	}
}

public class KAR_702e:Ability{
//NAME=简单把戏
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_710:MinionBase{
//NAME=奥能铁匠
//TEXT=<b>战吼：</b>召唤一个0/5并具有<b>嘲讽</b>的随从。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class KAR_710m:MinionBase{
//NAME=活化盾牌
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=5|RACE=NONE
}
public class KAR_711:MinionBase{
//NAME=奥术巨人
//TEXT=在本局对战中，你每施放一个法术，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=12|ATK=8|HP=8|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			int Cnt=0;
			foreach(Card c in owner.myPlayer.grave)
			{
				if(c.cardType==CardType.Spell)
				{
					Cnt+=1;
				}
			}
			return -Cnt;
		}
		return 0;
	}
}
public class KAR_712:MinionBase{
//NAME=紫罗兰幻术师
//TEXT=在你的回合中，你的英雄<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class KAR_712e:Ability{
//NAME=紫罗兰庇护
//TEXT=<b>免疫</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A01_01:HeroBase{
//NAME=魔镜
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class KAR_A01_01H:HeroBase{
//NAME=魔镜
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class KAR_A01_02:HeroPowerBase{
//NAME=反射
//TEXT=<b>被动</b> 每当使用一张随从牌，召唤一个它的1/1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A01_02e:Ability{
//NAME=反射
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A01_02H:HeroPowerBase{
//NAME=反射
//TEXT=<b>被动</b> 每当使用一张随从牌，魔镜就会召唤一个1/1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_01:MinionBase{
//NAME=餐盘
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class KAR_A02_01H:MinionBase{
//NAME=餐盘
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class KAR_A02_02:WeaponBase{
//NAME=餐勺
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class KAR_A02_02H:WeaponBase{
//NAME=餐勺
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=NONE
}
public class KAR_A02_03:MinionBase{
//NAME=餐叉
//TEXT=餐盘拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class KAR_A02_03e:Ability{
//NAME=餐叉冲锋
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_03H:MinionBase{
//NAME=餐叉
//TEXT=餐盘拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=3|RACE=NONE
}
public class KAR_A02_04:MinionBase{
//NAME=餐刀
//TEXT=餐盘拥有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=NONE
}
public class KAR_A02_04e:Ability{
//NAME=餐刀防御
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_04H:MinionBase{
//NAME=餐刀
//TEXT=餐盘拥有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=NONE
}
public class KAR_A02_05:MinionBase{
//NAME=餐杯
//TEXT=餐盘拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class KAR_A02_05e:Ability{
//NAME=餐杯之力
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_05e2:Ability{
//NAME=餐杯之力
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_05H:MinionBase{
//NAME=餐杯
//TEXT=餐盘拥有+3攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class KAR_A02_06:MinionBase{
//NAME=餐壶
//TEXT=<b>战吼：</b>使一个随从获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class KAR_A02_06e2:Ability{
//NAME=满饮此杯
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_06H:MinionBase{
//NAME=餐壶
//TEXT=<b>战吼：</b>使一个随从获得+3/+3。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NONE
}
public class KAR_A02_06He:Ability{
//NAME=满饮此杯
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_09:SpellBase{
//NAME=布置餐桌
//TEXT=使你的餐盘获得 +1/+1。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_09e:Ability{
//NAME=餐具齐备
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_09eH:Ability{
//NAME=餐具齐备
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_09H:SpellBase{
//NAME=布置餐桌
//TEXT=使你的餐盘获得 +2/+2。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_10:SpellBase{
//NAME=痛饮一番
//TEXT=你每有一个餐盘，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_11:SpellBase{
//NAME=餐盘齐舞
//TEXT=召唤五个1/1的餐盘。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_12:HeroBase{
//NAME=镀银魔像
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class KAR_A02_12H:HeroBase{
//NAME=镀银魔像
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class KAR_A02_13:HeroPowerBase{
//NAME=热情好客
//TEXT=召唤一个1/1的餐盘。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A02_13H:HeroPowerBase{
//NAME=热情好客
//TEXT=召唤两个1/1的餐盘。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class KAR_A10_01:MinionBase{
//NAME=黑棋禁卫
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=6|RACE=NONE
}
public class KAR_A10_02:MinionBase{
//NAME=白棋禁卫
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=6|RACE=NONE
}
public class KAR_A10_03:MinionBase{
//NAME=黑棋城堡
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class KAR_A10_04:MinionBase{
//NAME=白棋城堡
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class KAR_A10_05:MinionBase{
//NAME=白棋主教
//TEXT=<b>自动攻击：</b> 为相邻的随从恢复#2点生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=6|RACE=NONE
}
public class KAR_A10_06:MinionBase{
//NAME=黑棋主教
//TEXT=<b>自动攻击：</b> 为相邻的随从恢复#2点生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=6|RACE=NONE
}
public class KAR_A10_07:MinionBase{
//NAME=黑棋骑士
//TEXT=<b>冲锋</b> 无法攻击英雄。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class KAR_A10_08:MinionBase{
//NAME=白棋骑士
//TEXT=<b>冲锋</b> 无法攻击英雄。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class KAR_A10_09:MinionBase{
//NAME=白棋皇后
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成4点伤害。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=6|RACE=NONE
}
public class KAR_A10_10:MinionBase{
//NAME=黑棋皇后
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成4点伤害。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=6|RACE=NONE
}
public class KAR_A10_22:HeroPowerBase{
//NAME=堡垒
//TEXT=<b>发现</b>一枚棋子。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class KAR_A10_22H:HeroPowerBase{
//NAME=堡垒
//TEXT=将一个友方随从向左移，可以重复 使用。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class KAR_A10_33:HeroPowerBase{
//NAME=作弊
//TEXT=消灭最左边的敌方随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class KAR_a10_Boss1:HeroBase{
//NAME=白棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class KAR_a10_Boss1H:HeroBase{
//NAME=白棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class KAR_a10_Boss1H_TB:HeroBase{
//NAME=白棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=10|RACE=NONE
}
public class KAR_a10_Boss1H_TB22:HeroBase{
//NAME=白棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class KAR_a10_Boss2:HeroBase{
//NAME=黑棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class KAR_a10_Boss2H:HeroBase{
//NAME=黑棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class KAR_a10_Boss2H_TB:HeroBase{
//NAME=黑棋国王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=10|RACE=NONE
}
