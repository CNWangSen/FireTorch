using System.Collections;
using System.Collections.Generic;

public class WW_001:MinionBase{
//NAME=狗头人矿工
//TEXT=<b>战吼：</b> <b>发掘</b>一个宝藏。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectExcavate(owner.myPlayer).Resolve();
	}
}
public class WW_001t:SpellBase{
//NAME=石头
//TEXT=造成$3点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
	}
}
public class WW_001t11:LocationBase{
//NAME=魔拳岩
//TEXT=将一个随从的属性值变为6/7。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WW_001t11e:Ability{
//NAME=大好身材
//TEXT=属性值变成6/7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t12:SpellBase{
//NAME=塌陷
//TEXT=对所有敌人造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3);
	}
}
public class WW_001t13:MinionBase{
//NAME=铁皮鼹鼠
//TEXT=<b>嘲讽</b>。<b>复生</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("Reborn");
		TaskInitAbility("Elusive");
	}
}
public class WW_001t14:SpellBase{
//NAME=艾泽里特晶石
//TEXT=<b>发现</b>一张法力值消耗为（5）的卡牌，其消耗变为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_001t14e:Ability{
//NAME=艾泽里特光芒
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t16:MinionBase{
//NAME=活体石头
//TEXT=<b>嘲讽</b>。<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=ELEMENTAL
}
public class WW_001t17:MinionBase{
//NAME=主矿区幼龙
//TEXT=<b>突袭</b> <b>圣盾</b>。<b>吸血</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Rush");
		TaskInitAbility("DivineShield");
		TaskInitAbility("LifeSteal");
	}
}
public class WW_001t18:SpellBase{
//NAME=钱袋
//TEXT=获取两张幸运币。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("GAME_005"),ZoneType.Hand);
		TaskCreate(CardDbf.GetCardDbfByGuid("GAME_005"),ZoneType.Hand);
	}
}
public class WW_001t2:SpellBase{
//NAME=喷涌水源
//TEXT=恢复#3点生命值。抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectHeal(owner.myPlayer,owner,target,3).Resolve();
		TaskDraw();
	}
}
public class WW_001t23:MinionBase{
//NAME=艾泽里特蝎
//TEXT=<b>战吼：</b>随机获取4张法术牌。在本局对战中，你每<b>发掘</b>过一次，这些牌的法力值消耗便减少（1）点<i>（但不能少于1点）</i>。
//MAJ=ROGUE|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class WW_001t23e:Ability{
//NAME=蝎刺
//TEXT=在本局对战中，你每<b>发掘</b>过一次，这些牌的法力值消耗便减少（1）点<i>（但不能少于1点）</i>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t24:MinionBase{
//NAME=艾泽里特鹰
//TEXT=<b>战吼：</b>随机获取一张<b>泰坦</b>牌，其法力值消耗为（1）点。
//MAJ=MAGE|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class WW_001t25:MinionBase{
//NAME=艾泽里特蛇
//TEXT=<b>战吼：</b>你的英雄从敌方英雄处偷取7点生命值。
//MAJ=WARLOCK|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class WW_001t25e:Ability{
//NAME=艾泽里特弱势
//TEXT=生命值降低。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t25e2:Ability{
//NAME=艾泽里特强势
//TEXT=生命值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t26:MinionBase{
//NAME=艾泽里特鼠
//TEXT=<b>战吼：</b>复活你法力值消耗最高的随从。使其获得+2/+2，<b>复生</b>和<b>吸血</b>。
//MAJ=DEATHKNIGHT|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
	public override void Battlecry(Card target=null)
	{
		CardDbf ToReborn = null;
		foreach(Card c in owner.myPlayer.grave)
		{
			if(c.cardType==CardType.Minion)
			{
				if(ToReborn==null)
				{
					ToReborn=c.cardDbf;
				}
				else{
					if(c.cardDbf.ManaCost>=ToReborn.ManaCost)
					{
						ToReborn=c.cardDbf;
					}
				}
			}
		}
		if(ToReborn!=null)
		{
			Card Reborned = TaskCreate(ToReborn,ZoneType.Board);
			new EffectChange(owner.myPlayer,owner,Reborned,atkChange:2,hpChange:2).Resolve();
			new EffectGiveAbility(owner.myPlayer,owner,Reborned,"Reborn").Resolve();
			new EffectGiveAbility(owner.myPlayer,owner,Reborned,"LifeSteal").Resolve();
		}
	}
}
public class WW_001t26e:Ability{
//NAME=艾泽里特之魂
//TEXT=+2/+2，<b>复生</b>和<b>吸血</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t27:MinionBase{
//NAME=艾泽里特牛
//TEXT=<b>战吼：</b><b>发现</b>两个法力值消耗为（8）的随从，召唤它们。
//MAJ=WARRIOR|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class WW_001t3:SpellBase{
//NAME=愚人艾泽里特
//TEXT=<b>发现</b>一张法力值消耗为（2）的卡牌，其消耗变为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_001t4:MinionBase{
//NAME=脱逃的穴居人
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class WW_001t5:SpellBase{
//NAME=钟乳落石
//TEXT=对一个随从和敌方英雄造成$3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		TaskDamageEnemyHero(3);
	}
}
public class WW_001t7:MinionBase{
//NAME=金丝雀
//TEXT=<b>战吼：</b>将一个 敌方随从移回其拥有者的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,target).Resolve();
		new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand,toEn:true).Resolve();
	}
}
public class WW_001t8:SpellBase{
//NAME=辐光雕文
//TEXT=使一个随从及其相邻随从获得+1/+2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		ToListBuff.Add(target);
		int Index = target.myPlayer.board.IndexOf(target);
		if(Index>0)
		{
			ToListBuff.Add(target.myPlayer.board[Index-1]);
		}
		if(Index<target.myPlayer.board.Count-1)
		{
			ToListBuff.Add(target.myPlayer.board[Index+1]);
		}
		TaskBuffTargets(ToListBuff,atk:1,hp:2);
	}
}
public class WW_001t8e:Ability{
//NAME=辐光雕文
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_001t9:SpellBase{
//NAME=大块艾泽里特
//TEXT=<b>发现</b>一张法力值消耗为（3）的卡牌，其消耗变为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_002:MinionBase{
//NAME=破地钻机
//TEXT=<b>突袭</b>。<b>战吼：</b><b>发掘</b>一个宝藏。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectExcavate(owner.myPlayer).Resolve();
	}
}
public class WW_003:MinionBase{
//NAME=悬赏公告栏
//TEXT=你的<b>发掘，快枪</b>，<b>可交易</b>和<b>传说</b>牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=5|RACE=NONE
}
public class WW_003e:Ability{
//NAME=牛市行情
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_006:SpellBase{
//NAME=飞镖投掷
//TEXT=随机向敌方随从投掷两枚造成$2点伤害的飞镖。<i>（如果两枚击中同一个随从，获取一张幸运币！）</i>
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_009:SpellBase{
//NAME=低温贮藏
//TEXT=<b>冻结</b>一个敌人。<b>发掘</b>一个 宝藏。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class WW_010:MinionBase{
//NAME=荷利戴医生
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，装备九蛙魔杖。
//MAJ=SHAMAN|COST=5|ATK=4|HP=5|RACE=NONE
}
public class WW_010hexfrog:MinionBase{
//NAME=青蛙
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WW_010t:WeaponBase{
//NAME=九蛙魔杖
//TEXT=在你的英雄攻击后，召唤一只{0}/{1}并具有<b>嘲讽</b>的青蛙。<i>（每只青蛙都会比上一只 更大！）</i>
//MAJ=SHAMAN|COST=5|ATK=1|HP=9|RACE=NONE
}
public class WW_024:MinionBase{
//NAME=活体原野岩
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，召唤两只3/3并具有<b>突袭</b>的奶牛。
//MAJ=SHAMAN|COST=5|ATK=5|HP=4|RACE=ELEMENTAL
}
public class WW_024t:MinionBase{
//NAME=惊诧的奶牛
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_025:MinionBase{
//NAME=艾泽里特巨人
//TEXT=每有一个你使用过元素牌的连续的回合，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
}
public class WW_026:MinionBase{
//NAME=灾变飓风斯卡尔
//TEXT=<b>战吼：</b>对所有敌人造成1点伤害<i>（每有一个你使用过元素牌的连续的回合，伤害都会提升）</i>。
//MAJ=SHAMAN|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class WW_027:SpellBase{
//NAME=可靠陪伴
//TEXT=使一个随从获得+2/+3。如果该随从有随从类型，抽一张该类型的随从牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_027e:Ability{
//NAME=助手的副手
//TEXT=+2/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_041:MinionBase{
//NAME=排污助理
//TEXT=<b>战吼，亡语：</b>将一张淤泥桶置于你的 牌库底。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_042:MinionBase{
//NAME=废物清理工
//TEXT=在你的回合结束时，摧毁你牌库底的 三张牌。
//MAJ=WARLOCK|COST=4|ATK=5|HP=7|RACE=DEMON
}
public class WW_043:MinionBase{
//NAME=轮式淤泥怪
//TEXT=<b>突袭</b>。每当本随从受到伤害时，获取一张淤泥桶并将一张淤泥桶置于你的牌库底。
//MAJ=WARLOCK|COST=3|ATK=2|HP=4|RACE=NONE
}
public class WW_044:MinionBase{
//NAME=列车机务工
//TEXT=<b>亡语：</b>获取一张淤泥桶。<i>有毒废弃物：请妥善处理。</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class WW_044t:SpellBase{
//NAME=淤泥桶
//TEXT=当本牌被使用，弃掉或摧毁时，对生命值最低的敌人造成$4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FEL
}
public class WW_051:SpellBase{
//NAME=决战！
//TEXT=双方玩家各召唤三个3/3的歹徒，使你召唤的获得<b>突袭</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_051t:MinionBase{
//NAME=歹徒
//TEXT=
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WW_052:SpellBase{
//NAME=萤光虫群
//TEXT=召唤10只1/1并具有<b>吸血</b>的萤光虫。将超过随从数量上限的萤光虫存入法力值消耗为（1）的瓶子。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
}
public class WW_052t:MinionBase{
//NAME=萤光虫
//TEXT=<b>吸血</b>
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WW_052t2:SpellBase{
//NAME=瓶装萤光
//TEXT=召唤余下的1/1并具有<b>吸血</b>的萤光虫。0召唤{0}只1/1并具有<b>吸血</b>的萤光虫。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_053:SpellBase{
//NAME=飞车劫掠
//TEXT=获取你的对手上回合使用的每张卡牌的各一张复制。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WW_0700:HeroBase{
//NAME=孤胆游侠雷诺
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，清空敌方面板，且一回合内其面板位置上限为1。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=30|RACE=NONE
}
public class WW_0700e1:Ability{
//NAME=孤胆游侠
//TEXT=一回合内你的面板上限为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p:HeroPowerBase{
//NAME=雷诺的手枪
//TEXT=发射当回合的魔法枪弹！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p1:HeroPowerBase{
//NAME=奥术枪弹
//TEXT=造成$2点伤害。复原2个法力水晶。每回合切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p2:HeroPowerBase{
//NAME=冰霜枪弹
//TEXT=造成$2点伤害。获得$d4点护甲值。每回合切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p3:HeroPowerBase{
//NAME=火焰枪弹
//TEXT=造成$2点伤害，再对所有敌方随从造成$1点伤害。每回合 切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p4:HeroPowerBase{
//NAME=神圣枪弹
//TEXT=造成$2点伤害。随机使一个友方随从获得+2/+2。每回合切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p4e1:Ability{
//NAME=圣弹快乐
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p5:HeroPowerBase{
//NAME=自然枪弹
//TEXT=造成$2点伤害。<b>发现</b>一张法术牌。每回合切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p6:HeroPowerBase{
//NAME=暗影枪弹
//TEXT=造成$2点伤害。随机召唤一个法力值消耗为（3）的随从。每回合切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_0700p7:HeroPowerBase{
//NAME=邪能枪弹
//TEXT=造成$2点伤害。抽一张牌。每回合 切换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_080:SpellBase{
//NAME=两栖药剂
//TEXT=恢复#5点 生命值。<b>发现</b>一张法术牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class WW_090:SpellBase{
//NAME=巨型风滚草！
//TEXT=对所有随从造成$6点伤害。召唤一个6/6的风滚草。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class WW_090t:MinionBase{
//NAME=风滚草
//TEXT=
//MAJ=SHAMAN|COST=6|ATK=6|HP=6|RACE=NONE
}
public class WW_091:MinionBase{
//NAME=腐臭淤泥波普加
//TEXT=你的邪能法术法力值消耗减少（2）点且拥有<b>吸血</b>。<b>战吼：</b>获取两张淤泥桶。
//MAJ=WARLOCK|COST=4|ATK=2|HP=6|RACE=NONE
}
public class WW_092:SpellBase{
//NAME=液力压裂
//TEXT=检视你的牌库底的三张牌，抽其中一张，摧毁其余牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_300:MinionBase{
//NAME=陷坑蜘蛛
//TEXT=<b>潜行</b>。<b>剧毒</b>。在你的对手使用一张随从牌后，攻击该随从。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=BEAST
}
public class WW_322:MinionBase{
//NAME=骷髅矿工
//TEXT=<b>战吼：</b><b>发掘</b>一个宝藏，其法力值消耗为（0）点。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=3|RACE=UNDEAD
	public override void Battlecry(Card target=null)
	{
		new EffectExcavate(owner.myPlayer).Resolve();
		Card Excavated = owner.myPlayer.hand.Last();
		new EffectChange(owner.myPlayer,owner,Excavated,manaChange:-Excavated.GetTag(GameTag.Mana)).Resolve();
	}
}
public class WW_324:MinionBase{
//NAME=白骨堆
//TEXT=<b>亡语：</b>在你下次<b>发掘</b>时，再次 召唤本随从。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=1|RACE=UNDEAD
}
public class WW_324e:Ability{
//NAME=白骨堆
//TEXT=在你发掘后，再次召唤一个白骨堆。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_325:SpellBase{
//NAME=脱水
//TEXT=<b>吸血</b>。对一个随从造成$4点伤害。<b>快枪：</b>法力值消耗为（1）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_326:MinionBase{
//NAME=矿车巡逻兵
//TEXT=<b>突袭</b>。<b>过载：</b>（2）。<b>战吼：</b>如果你在上个回合使用过元素牌，则本牌不会<b>过载</b>。
//MAJ=SHAMAN|COST=3|ATK=4|HP=5|RACE=ELEMENTAL
}
public class WW_327:MinionBase{
//NAME=仙人掌割水工
//TEXT=<b>战吼：</b>抽一张法术牌。如果你在本回合中施放抽到的牌，则获得+1/+2和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class WW_327e:Ability{
//NAME=仙人掌割水工
//TEXT=如果在本回合中施放，使仙人掌割水工获得+1/+2和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_327e2:Ability{
//NAME=仙人掌割水工
//TEXT=+1/+2和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_329:MinionBase{
//NAME=机甲爆王
//TEXT=<b>嘲讽</b>。<b>战吼：</b>使你手牌中的<b>嘲讽</b>随从牌获得+2/+2。
//MAJ=WARRIOR|COST=4|ATK=3|HP=4|RACE=MECHANICAL
}
public class WW_329e:Ability{
//NAME=嘲上加嘲
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_331:MinionBase{
//NAME=奇迹推销员
//TEXT=<b>亡语：</b>获取一张<b>可交易</b>的蛇油。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("WW_331t"),ZoneType.Hand);
	}
}
public class WW_331t:SpellBase{
//NAME=蛇油
//TEXT=<b>可交易</b> 造成$0点伤害。<i>好像没什么用……</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,0).Resolve();
	}
}
public class WW_332:MinionBase{
//NAME=蛇油商人
//TEXT=<b>亡语：</b>将2张<b>可交易</b>的蛇油洗入你对手的 牌库。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NAGA
}
public class WW_333:MinionBase{
//NAME=交际鱼人
//TEXT=每当你的手牌少于三张，随机获取一张鱼人牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class WW_334:SpellBase{
//NAME=加固护板
//TEXT=获得6点 护甲值。<b>发掘</b> 一个宝藏。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_335:MinionBase{
//NAME=神圣牛仔
//TEXT=<b>战吼：</b>你的下一张神圣法术牌法力值消耗减少（2）点。
//MAJ=PALADIN|COST=3|ATK=4|HP=3|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
		{
			if(c.spellType.Contains(SpellSchoolType.Holy))
			{
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,mana:-2);
	}
}
public class WW_335e:Ability{
//NAME=神圣牛仔
//TEXT=你的下一张神圣法术牌法力值消耗减少（2）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_336:SpellBase{
//NAME=棱彩光束
//TEXT=对所有敌方随从造成$3点伤害。每有一个敌方随从，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=8|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return -owner.myPlayer.otherPlayer.board.Count;
		}
		return 0;
	}
}
public class WW_337:MinionBase{
//NAME=荒芜之地的精魂
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，则获取一张<i>永久</i>的 幻象牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class WW_337e:Ability{
//NAME=幻象
//TEXT=变形成为你牌库中的随从。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_337t:SpellBase{
//NAME=幻象
//TEXT=在你的回合开始时，变形成为你牌库中一个随从的复制。<i>（本牌保留在你手中。）</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_341:SpellBase{
//NAME=警务光环
//TEXT=你最左边的随从拥有+1攻击力和<b>吸血</b>。持续3回合。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class WW_341e:Ability{
//NAME=最爱的警务
//TEXT=+1攻击力和<b>吸血</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_342:MinionBase{
//NAME=长臂执法者
//TEXT=<b>突袭</b>。<b>吸血</b>。<b>战吼：</b>你每有一张手牌，便获得+1攻击力。
//MAJ=PALADIN|COST=5|ATK=1|HP=5|RACE=NONE
}
public class WW_342e:Ability{
//NAME=守法
//TEXT=+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_344:MinionBase{
//NAME=威猛银翼巨龙
//TEXT=<b>圣盾</b>。<b>亡语：</b>抽一张神圣法术牌。
//MAJ=PALADIN|COST=2|ATK=2|HP=1|RACE=DRAGON
}
public class WW_345:SpellBase{
//NAME=荒芜之地劫掠者
//TEXT=获取八张3/2并具有<b>额外效果</b>的劫掠者。手牌中放不下的劫掠者会被召唤。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class WW_345t1:MinionBase{
//NAME=硬邦邦
//TEXT=<b>圣盾</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t2:MinionBase{
//NAME=锈斑斑
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t3:MinionBase{
//NAME=红沙公主
//TEXT=<b>突袭</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t4:MinionBase{
//NAME=亮光光
//TEXT=<b>风怒</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t5:MinionBase{
//NAME=悄咪咪
//TEXT=<b>潜行</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t6:MinionBase{
//NAME=脏兮兮
//TEXT=<b>剧毒</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t7:MinionBase{
//NAME=算精精
//TEXT=<b>吸血</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_345t8:MinionBase{
//NAME=猛壮壮
//TEXT=<b>复生</b>
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WW_346:MinionBase{
//NAME=爆破龟
//TEXT=<b>嘲讽</b>。<b>战吼：</b>对所有敌方随从造成等同于本随从攻击力的伤害。
//MAJ=WARRIOR|COST=6|ATK=2|HP=7|RACE=BEAST
}
public class WW_347:WeaponBase{
//NAME=矿镐战斧
//TEXT=在你使用一张<b>嘲讽</b>随从牌后，获得+1耐久度。
//MAJ=WARRIOR|COST=3|ATK=4|HP=1|RACE=NONE
}
public class WW_347e:Ability{
//NAME=回到矿井
//TEXT=+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_348:SpellBase{
//NAME=误炸
//TEXT=对随机随从分别造成$3点，$2点和$1点伤害。<b>快枪：</b>可以选择目标。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_349:MinionBase{
//NAME=荒芜之地乱斗打手
//TEXT=<b>战吼：</b>发起一场绝命乱斗！如果你已经<b>发掘</b>过两次，则本随从总会赢得胜利。
//MAJ=WARRIOR|COST=7|ATK=4|HP=4|RACE=NONE
}
public class WW_351:MinionBase{
//NAME=偷牛贼
//TEXT=<b>战吼：</b>抽一张野兽牌，其法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=NONE
}
public class WW_351e:Ability{
//NAME=盗窃而来
//TEXT=法力值消耗减少（3）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_352:SpellBase{
//NAME=自埋自收
//TEXT=造成$3点 伤害。<b>发掘</b>一个 宝藏。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		new EffectExcavate(owner.myPlayer).Resolve();
	}
}
public class WW_354:SpellBase{
//NAME=堆尸荒野
//TEXT=对一个随从造成等同于你的<b>尸体</b>数量的伤害。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_356:MinionBase{
//NAME=泥犁耕牛
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你已经<b>发掘</b>过两次，在本回合中你的下一张牌法力值消耗减少（7）点。
//MAJ=DEATHKNIGHT|COST=7|ATK=7|HP=7|RACE=UNDEAD
}
public class WW_356e:Ability{
//NAME=魔牛苦寒
//TEXT=在本回合中，你的下一张牌法力值消耗减少（7）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_357:MinionBase{
//NAME=老腐和老墓
//TEXT=在你的回合结束时，获得5具<b>尸体</b>。在你的回合开始时，消耗5具<b>尸体</b>，使你的英雄获得+5生命值。
//MAJ=DEATHKNIGHT|COST=4|ATK=2|HP=8|RACE=UNDEAD
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEventAddHealth));
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEventAddCorpse));
	}
	public void CauseEventAddHealth()
	{
		if(CondInPlay())
		{
			if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=5)
			{
				TaskBuffMyHero(hp:5);
			}
		}
	}
	public void CauseEventAddCorpse()
	{
		if(CondInPlay())
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,5);
		}
	}
}
public class WW_357e:Ability{
//NAME=家的呵护
//TEXT=生命值提高。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_358:MinionBase{
//NAME=农场小助手
//TEXT=<b>战吼：</b><b>发现</b>一张亡灵牌。<b>快枪：</b>其法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class WW_358e:Ability{
//NAME=得力助手
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_359:MinionBase{
//NAME=桶沿警长
//TEXT=<b>战吼：</b>如果你的生命值小于或等于20点，开启荒芜之地监狱。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WW_359t:LocationBase{
//NAME=荒芜之地监狱
//TEXT=使一个随从<b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=3|RACE=NONE
}
public class WW_360:MinionBase{
//NAME=艾泽里特苦囚
//TEXT=<b>嘲讽</b>。<b>战吼，快枪：</b>召唤一个本随从的 复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		Card Another = new Card(owner.cardDbf,owner.myPlayer);
		Another.SetTag(GameTag.Attack,owner.GetTag(GameTag.Attack));
		Another.SetTag(GameTag.Health,owner.GetTag(GameTag.Health));
		Another.SetTag(GameTag.Damage,owner.GetTag(GameTag.Damage));
		new EffectCreate(owner.myPlayer,Another,ZoneType.Board).Resolve();
	}
}
public class WW_363:MinionBase{
//NAME=押注猎手
//TEXT=<b>快枪或连击：</b>获取一张幸运币。
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WW_364:MinionBase{
//NAME=威拉罗克·温布雷
//TEXT=当本牌在你手牌中时，使用一张另一职业的卡牌以揭示威拉罗克的真正形态！
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WW_364t:MinionBase{
//NAME=狡诈巨龙威拉罗克
//TEXT=<b>冲锋</b>。在本随从攻击后，<b>发现</b>一张另一职业的卡牌，其法力值消耗减少（3）点。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class WW_364te:Ability{
//NAME=狡诈巨龙威拉罗克
//TEXT=法力值消耗减少（3）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_365:SpellBase{
//NAME=不许乱动
//TEXT=<b>可交易</b> 将一个随从的攻击力和生命值变为1。<b>快枪：</b>然后对其造成$1点伤害。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class WW_365e:Ability{
//NAME=伸张正义
//TEXT=1/1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_366:MinionBase{
//NAME=活体天光
//TEXT=<b>嘲讽</b>。<b>圣盾</b>。你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=10|ATK=4|HP=6|RACE=ELEMENTAL
}
public class WW_367:MinionBase{
//NAME=倒霉的炸药师
//TEXT=<b>嘲讽</b>。<b>亡语：</b>使你手牌和牌库中的<b>嘲讽</b>随从牌获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class WW_367e:Ability{
//NAME=煤灰
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_368:SpellBase{
//NAME=耕地轮作
//TEXT=召唤四个1/1并具有<b>突袭</b>且会在回合结束时死亡的亡灵。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_368t:MinionBase{
//NAME=奔袭侏儒
//TEXT=<b>突袭</b>。在你的回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class WW_372:MinionBase{
//NAME=爆破工头索格伦
//TEXT=<b>战吼：</b>将3张TNT炸药洗入你对手的牌库。当抽到炸药时，炸毁其手牌，牌库和面板上的各一张牌。
//MAJ=WARRIOR|COST=8|ATK=7|HP=7|RACE=NONE
}
public class WW_372t:SpellBase{
//NAME=TNT炸药
//TEXT=<b>抽到时施放</b> 随机摧毁你的手牌，牌库和战场上的各一张牌<i>（TNT炸药除外）</i>。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class WW_373:MinionBase{
//NAME=矿坑老板雷斯卡
//TEXT=<b>突袭</b>。在本局对战中每有一个随从死亡，本牌的法力值消耗便减少（1）点。<b>亡语：</b>随机夺取一个敌方随从的控制权。
//MAJ=DEATHKNIGHT|COST=20|ATK=6|HP=3|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void Deathrattle()
	{
		Card Target = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectChange(owner.myPlayer,owner,Target).Resolve();
			new EffectMove(owner.myPlayer.otherPlayer,Target,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
		}
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			int Dead = 0;
			foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
			{
				if(c.cardType==CardType.Minion)
				{
					Dead+=1;
				}
			}
			return -Dead;
		}
		return 0;
	}
}
public class WW_374:SpellBase{
//NAME=凉尸农场
//TEXT=消耗最多 8具<b>尸体</b>，随机召唤一个法力值消耗相同的随从。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_375:MinionBase{
//NAME=偃息的焰喉
//TEXT=<b>突袭</b>。<b>嘲讽</b>。<b>休眠</b>6回合。<i>（<b>发掘</b>即可提前2回合唤醒！）</i>
//MAJ=WARRIOR|COST=4|ATK=16|HP=16|RACE=BEAST
}
public class WW_375e:Ability{
//NAME=偃息
//TEXT=<b>休眠</b>。 6回合后唤醒。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_375e2:Ability{
//NAME=Slagging
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_376:MinionBase{
//NAME=仙人掌暴怒者
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=2|ATK=5|HP=1|RACE=NONE
}
public class WW_377:SpellBase{
//NAME=热浪来袭
//TEXT=对一个敌方随从及其相邻随从造成$2点伤害。<b>快枪：</b>改为对所有敌人。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class WW_378:SpellBase{
//NAME=列车烟囱
//TEXT=对一个随从造成$1点伤害。如果该随从死亡，<b>发掘</b>一个 宝藏。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class WW_379:MinionBase{
//NAME=弗林特·枪臂
//TEXT=<b>战吼：</b>随机获取一张<b>快枪</b>牌。如果你在本回合使用获取的牌，重复此效果。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class WW_379e:Ability{
//NAME=弗林特·枪臂
//TEXT=如果在本回合使用，获取另一张<b>快枪</b>牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_380:SpellBase{
//NAME=起爆炸药
//TEXT=消灭一个受伤的敌方随从。<b>发掘</b>一个宝藏。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_381:MinionBase{
//NAME=受伤的搬运工
//TEXT=<b>战吼：</b>对本随从造成4点伤害。<b>过量治疗：</b>对所有敌方随从造成2点伤害。
//MAJ=PRIEST|COST=3|ATK=3|HP=7|RACE=NONE
}
public class WW_382:MinionBase{
//NAME=步移山丘
//TEXT=<b>突袭</b>。<b>吸血</b>。<b>超级风怒</b>。<b>过载：（2）</b>
//MAJ=SHAMAN|COST=9|ATK=4|HP=16|RACE=ELEMENTAL
}
public class WW_383:MinionBase{
//NAME=干鳞警官
//TEXT=<b>战吼：</b>你下一次抽到一张法术牌时，获取一张它的复制。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NAGA
}
public class WW_383e:Ability{
//NAME=干鳞警官
//TEXT=你抽到下一张法术牌时使你获得一张额外复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_384:MinionBase{
//NAME=和善的银行职员
//TEXT=<b>战吼：</b>从你的牌库中<b>发现</b>一张法术牌。<b>快枪：</b>改为从敌方牌库。
//MAJ=PRIEST|COST=3|ATK=2|HP=4|RACE=NONE
}
public class WW_387:MinionBase{
//NAME=口渴的流浪者
//TEXT=<b>嘲讽</b>。在本局对战中，你每使用过一张法力值消耗为（1）的牌，本牌的法力值消耗便减少（1）点。
//MAJ=PRIEST|COST=7|ATK=4|HP=6|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc.GetTag(GameTag.Mana)==1)
		{
			new EffectChange(owner.myPlayer,owner,owner,manaChange:-1,visualFx:false).Resolve();
		}
	}
}
public class WW_391:MinionBase{
//NAME=淘金客
//TEXT=在你的回合结束时，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class WW_392:MinionBase{
//NAME=荒地奇兵伊莉斯
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，随机召唤你牌库中4个随从的5/5的复制。
//MAJ=PRIEST|COST=8|ATK=5|HP=5|RACE=NONE
}
public class WW_392e:Ability{
//NAME=侠盗
//TEXT=5/5。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_393:SpellBase{
//NAME=影叶入侵
//TEXT=对一个敌方随从造成$10点伤害。将超过目标生命值的伤害存入法力值消耗为（1）的瓶子。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class WW_393t:SpellBase{
//NAME=瓶装影叶
//TEXT=对一个敌方随从造成余下的伤害。0对一个敌方随从造成${0}点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class WW_394:MinionBase{
//NAME=皮普，强力水霸
//TEXT=<b>战吼：</b>复制你手牌中法力值消耗为 （1）的牌。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WW_395:SpellBase{
//NAME=神圣泉水
//TEXT=为一个受伤的角色恢复#8点生命值。将超过目标生命值上限的治疗量存入法力值消耗为（1）的瓶子。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class WW_395t:SpellBase{
//NAME=瓶装泉水
//TEXT=恢复余下的生命值。0恢复#{0}点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class WW_397:MinionBase{
//NAME=炸裂元素
//TEXT=<b>嘲讽</b>。<b>亡语：</b>对除友方元素外的所有随从造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=ELEMENTAL
}
public class WW_398:MinionBase{
//NAME=提灯门卫
//TEXT=<b>战吼：</b>将你的手牌洗入牌库，然后抽取相同数量的牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=UNDEAD
}
public class WW_399:MinionBase{
//NAME=正午决斗者
//TEXT=<b>亡语：</b>双方玩家抽牌！摧毁其中法力值消耗较低的牌。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class WW_400:MinionBase{
//NAME=蛇眼
//TEXT=<b>战吼：</b>投两枚骰子，然后 <b>发现</b>法力值消耗分别对应点数的两张牌。<i>（投出对子可以额外<b>发现</b>一张！）</i>
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=4|RACE=NAGA
}
public class WW_400t1:SpellBase{
//NAME=投出一点！
//TEXT=<b>发现</b>一张 法力值消耗为（1）的卡牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_400t2:SpellBase{
//NAME=投出两点！
//TEXT=<b>发现</b>一张 法力值消耗为（2）的卡牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_400t3:SpellBase{
//NAME=投出三点！
//TEXT=<b>发现</b>一张 法力值消耗为（3）的卡牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_400t4:SpellBase{
//NAME=投出四点！
//TEXT=<b>发现</b>一张 法力值消耗为（4）的卡牌。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WW_400t5:SpellBase{
//NAME=投出五点！
//TEXT=<b>发现</b>一张 法力值消耗为（5）的卡牌。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class WW_400t6:SpellBase{
//NAME=投出六点！
//TEXT=<b>发现</b>一张 法力值消耗为（6）的卡牌。
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class WW_401:MinionBase{
//NAME=枪手库尔特鲁斯
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，则对敌方手牌中的随从开六枪，每枪造成2点伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=4|HP=6|RACE=NONE
}
public class WW_402:MinionBase{
//NAME=盲眼神射手
//TEXT=在你使用一张纳迦牌后，随机对一个敌人造成2点伤害，抽一张法术牌。 <i>（然后切换！）</i>2在你施放一个法术后，随机对一个敌人造成2点伤害，抽一张纳迦牌。 <i>（然后切换！）</i>
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=3|RACE=NAGA
}
public class WW_403:SpellBase{
//NAME=袋底藏沙
//TEXT=造成$3点伤害。<b>快枪：</b>你对手的下一张牌法力值消耗增加（1）点。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_403e:Ability{
//NAME=沙土迷眼
//TEXT=你的下一张牌法力值消耗增加（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_403e1:Ability{
//NAME=沙土
//TEXT=你的下一张牌法力值消耗增加（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_403e2:Ability{
//NAME=沙土
//TEXT=法力值消耗增加（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_404:SpellBase{
//NAME=绿洲歹徒
//TEXT=<b>发现</b>一张纳迦牌。如果你在此牌在你手中时使用过纳迦牌，发现的牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_405:SpellBase{
//NAME=迅疾连射
//TEXT=造成$6点伤害，分配到生命值最低的敌人身上。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class WW_406:MinionBase{
//NAME=午夜啸狼
//TEXT=<b>突袭</b>。<b>流放：</b>召唤一个本随从的复制。
//MAJ=DEMONHUNTER|COST=6|ATK=6|HP=6|RACE=BEAST
}
public class WW_407:MinionBase{
//NAME=焦渴的亡命徒
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，使你的英雄在本回合中获得+3攻击力。
//MAJ=DEMONHUNTER|COST=2|ATK=3|HP=2|RACE=NAGA
}
public class WW_407e:Ability{
//NAME=*咕噜*
//TEXT=在本回合中+3攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_408:MinionBase{
//NAME=机器调酒师
//TEXT=<b>战吼：</b>抽一张<b>流放</b>牌并将其放在你手牌中的最左边。
//MAJ=DEMONHUNTER|COST=2|ATK=3|HP=1|RACE=MECHANICAL
}
public class WW_409:SpellBase{
//NAME=装填弹膛
//TEXT=造成$2点伤害。你的下一张纳迦牌，邪能法术牌和武器牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class WW_409e:Ability{
//NAME=装填纳迦
//TEXT=你的下一张纳迦牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_409e1:Ability{
//NAME=装填完毕！
//TEXT=法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_409e2:Ability{
//NAME=装填邪能法术
//TEXT=你的下一张邪能法术牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_409e3:Ability{
//NAME=装填武器
//TEXT=你的下一张武器牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_410:SpellBase{
//NAME=三条七
//TEXT=对一个随从造成$7点伤害。 抽7张牌。
//MAJ=ROGUE|COST=7|ATK=0|HP=0|RACE=NONE
}
public class WW_411:SpellBase{
//NAME=持枪要挟
//TEXT=<b>发现</b>一张另一职业的<b>快枪</b>牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_412:WeaponBase{
//NAME=血石牌铁铲
//TEXT=<b>亡语：</b> <b>发掘</b>一个宝藏。
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class WW_413:MinionBase{
//NAME=古董投手
//TEXT=<b>战吼：</b>如果你已经<b>发掘</b>过两次，消灭一个敌方随从。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class WW_415:MinionBase{
//NAME=许愿井
//TEXT=在你使用一张幸运币后，随机获取一张另一职业的<b>传说</b>随从牌并将其法力值消耗变为（1）点。
//MAJ=ROGUE|COST=5|ATK=0|HP=7|RACE=NONE
}
public class WW_416:SpellBase{
//NAME=龟壳游戏
//TEXT=随机获取其他职业的史诗，稀有和普通卡牌各一张。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_417:MinionBase{
//NAME=钻头小子
//TEXT=<b>战吼，快枪，亡语：</b><b>发掘</b>一个宝藏。
//MAJ=ROGUE|COST=4|ATK=4|HP=3|RACE=MECHANICAL
}
public class WW_418:MinionBase{
//NAME=食人魔帮歹徒
//TEXT=<b>突袭。</b>50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class WW_419:MinionBase{
//NAME=食人魔帮骑手
//TEXT=<b>突袭。</b>攻击时有50%几率改为使你的英雄在本回合中获得+3攻击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class WW_419e:Ability{
//NAME=非常食人魔
//TEXT=在本回合中，你的英雄拥有+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_420:MinionBase{
//NAME=食人魔帮王牌
//TEXT=<b>突袭</b>。每当本随从攻击时，获得<b>圣盾</b>。<i>（50%的几率改为获得 <b>吸血</b>。）</i>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class WW_421:MinionBase{
//NAME=帮派头领普德
//TEXT=<b>战吼：</b>复活你的食人魔帮众，使其获得 <b>风怒</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class WW_422:SecretBase{
//NAME=艾泽里特矿脉
//TEXT=<b>奥秘：</b>当敌人使用一张在当回合进入手牌的牌时，获取一张它的复制，其法力值消耗为（0）点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_422e:Ability{
//NAME=碎裂
//TEXT=法力值消耗减半。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_422e2:Ability{
//NAME=碎裂
//TEXT=攻击力和生命值减半。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_423:MinionBase{
//NAME=沙龙酒仙
//TEXT=<b>战吼：</b>将一个友方随从移回你的手牌，使其获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WW_423e:Ability{
//NAME=客人点单
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_424:MinionBase{
//NAME=溢流熔岩
//TEXT=<b>战吼：</b>每有一个你使用过元素牌的连续的回合，召唤一个本随从的复制。0<i>（召唤0个）</i>
//MAJ=MAGE|COST=4|ATK=3|HP=2|RACE=ELEMENTAL
}
public class WW_425:SpellBase{
//NAME=观星
//TEXT=抽一张不同的奥术法术牌。如果你在本回合中使用这张抽到的牌，则会施放两次。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class WW_425e:Ability{
//NAME=凝视
//TEXT=如果在本回合中使用，施放两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_426:MinionBase{
//NAME=矿工炎术师
//TEXT=<b>战吼：发掘</b>一个宝藏。你每有一张手牌，便随机对一个敌人造成1点伤害。
//MAJ=MAGE|COST=6|ATK=4|HP=4|RACE=NONE
}
public class WW_427:SpellBase{
//NAME=夕阳漫射
//TEXT=造成$10点伤害，随机分配到所有敌人身上。随机召唤一个法力值消耗为（10）的随从。
//MAJ=MAGE|COST=9|ATK=0|HP=0|RACE=FIRE
}
public class WW_428:MinionBase{
//NAME=侵蚀沉积岩
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，<b>发现</b>一张来自过去的任意元素牌。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=ELEMENTAL
}
public class WW_429:MinionBase{
//NAME=碎裂巨岩迈沙顿
//TEXT=<b>战吼：</b>抽一张元素牌，将其拆成两半。
//MAJ=MAGE|COST=5|ATK=6|HP=5|RACE=ELEMENTAL
}
public class WW_430:MinionBase{
//NAME=泰瑟兰·血望者
//TEXT=你的套牌之外的牌法力值消耗减少（4）点<i>（但不能少于1点）</i>。
//MAJ=MAGE|COST=4|ATK=2|HP=5|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return ((c.cardType==CardType.Spell || c.cardType==CardType.Weapon) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "WW_430e";
    }
}
public class WW_430e:Ability{
//NAME=搜寻遗物
//TEXT=法力值消耗减少（4）点（但不能少于1点）。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
			int amount=-4;
			if(owner.cardDbf.ManaCost-4<1)
			{
				amount= -(owner.cardDbf.ManaCost-1);
			}
            return amount;
        }
        return 0;
    }
}
public class WW_431:MinionBase{
//NAME=枪尾蛇
//TEXT=在你的回合结束时，装填两发枪弹，每发可以造成1点伤害。<b>亡语：</b>随机对敌人开火！
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=BEAST
}
public class WW_431e:Ability{
//NAME=装填枪弹
//TEXT=已装填枪弹。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_432:MinionBase{
//NAME=神圣遗物学会研究员
//TEXT=<b>战吼：</b>如果你已经<b>发掘</b>过两次，随机施放两个法师<b>奥秘</b>。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class WW_433:MinionBase{
//NAME=排舞的伴侣
//TEXT=<b>战吼：</b>如果你手牌中有其他法力值消耗为3的牌，随机召唤一个法力值消耗为3的随从。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class WW_434:MinionBase{
//NAME=日斑巨龙
//TEXT=<b>可交易</b> <b>吸血</b>。<b>快枪：</b>造成6点伤害。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=DRAGON
}
public class WW_435:MinionBase{
//NAME=飞踏野兔
//TEXT=你的野兽拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class WW_435e:Ability{
//NAME=践踏
//TEXT=飞踏野兔使其获得<b>突袭</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_436:SpellBase{
//NAME=列车难题
//TEXT=弃掉你法力值最低的法术牌。召唤两节3/3并具有<b>突袭</b>的矿车。<b>快枪：</b>无需弃牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_437:MinionBase{
//NAME=列车司机杰里
//TEXT=<b>战吼：</b>如果你已经<b>发掘</b>过两次，召唤六节3/3并具有<b>突袭</b>的矿车。
//MAJ=WARLOCK|COST=7|ATK=4|HP=4|RACE=NONE
}
public class WW_437t:MinionBase{
//NAME=矿车
//TEXT=<b>突袭</b>
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WW_440:MinionBase{
//NAME=奔雷骏马
//TEXT=<b>嘲讽</b>。<b>亡语：</b>从你的牌库中召唤一个元素和一只野兽。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		
	}
}
public class WW_441:SpellBase{
//NAME=锅炉燃料
//TEXT=当本牌被使用，弃掉或摧毁时，抽两张牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class WW_442:MinionBase{
//NAME=钻拳莫尔葛
//TEXT=<b>嘲讽</b>。<b>亡语：</b><b>发掘</b>一个宝藏。
//MAJ=WARLOCK|COST=4|ATK=4|HP=5|RACE=DEMON
}
public class WW_600:SpellBase{
//NAME=夺舍对射
//TEXT=召唤你对手手牌中一个随机随从的4/4的复制。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class WW_600e:Ability{
//NAME=着魔
//TEXT=4/4。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_806:SpellBase{
//NAME=潜踪群蛇
//TEXT=召唤两条1/1并具有<b>潜行</b>的蛇。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WW_806t:MinionBase{
//NAME=侧进蛇
//TEXT=<b>潜行</b>
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WW_807:MinionBase{
//NAME=秃鹫信使
//TEXT=<b>亡语：</b>抽一张野兽牌。使你手牌中的随从牌获得+1/+1。
//MAJ=HUNTER|COST=2|ATK=1|HP=2|RACE=BEAST
}
public class WW_807e:Ability{
//NAME=传信
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_808:MinionBase{
//NAME=银蛇
//TEXT=<b><b>突袭</b>。<b>剧毒</b> 快枪：</b>在本回合中获得<b>免疫</b>。
//MAJ=HUNTER|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class WW_808e:Ability{
//NAME=银牙
//TEXT=在本回合中<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_809:MinionBase{
//NAME=骷髅牛
//TEXT=<b>亡语：</b>如果本随从的攻击力大于或等于4点，召唤一只骷髅牛。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810:SpellBase{
//NAME=迷彩坐骑
//TEXT=使一个随从获得+3/+3和一项随机<b>额外效果</b>。当该随从死亡时，召唤一只变色龙。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WW_810t1:MinionBase{
//NAME=变色龙
//TEXT=<b>圣盾</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t1e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>圣盾</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t2:MinionBase{
//NAME=变色龙
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t2e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>嘲讽</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t3:MinionBase{
//NAME=变色龙
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t3e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>突袭</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t4:MinionBase{
//NAME=变色龙
//TEXT=<b>风怒</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t4e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>风怒</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t5:MinionBase{
//NAME=变色龙
//TEXT=<b>潜行</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t5e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>潜行</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t6:MinionBase{
//NAME=变色龙
//TEXT=<b>剧毒</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t6e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>剧毒</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t7:MinionBase{
//NAME=变色龙
//TEXT=<b>吸血</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t7e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>吸血</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_810t8:MinionBase{
//NAME=变色龙
//TEXT=<b>复生</b>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class WW_810t8e1:Ability{
//NAME=骑乘变色龙
//TEXT=+3/+3和<b>复生</b>。<b>亡语：</b>召唤一只变色龙。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_811:SpellBase{
//NAME=宽檐高帽
//TEXT=抽一张随从牌。使其获得+1/+1和 “<b>亡语：</b>获取一张宽檐高帽”。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_811e:Ability{
//NAME=宽檐高帽
//TEXT=+1/+1。<b>亡语：</b>获取一张宽檐高帽。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_812:SpellBase{
//NAME=跨鞍飞驰
//TEXT=使你的随从获得“<b>亡语：</b>随机召唤一只法力值消耗小于或等于（3）点的野兽”。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WW_812e:Ability{
//NAME=鞍鞯齐备
//TEXT=<b>亡语：</b>随机召唤一只法力值消耗小于或等于（3）点的野兽。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_813:WeaponBase{
//NAME=明星手枪
//TEXT=在你的英雄攻击后，获取一张奥术射击。
//MAJ=HUNTER|COST=4|ATK=2|HP=3|RACE=NONE
}
public class WW_814:MinionBase{
//NAME=刺牙
//TEXT=<b>战吼，亡语：</b>随机召唤一只法力值消耗等同于本随从攻击力的 野兽。
//MAJ=HUNTER|COST=5|ATK=2|HP=5|RACE=BEAST
}
public class WW_815:MinionBase{
//NAME=迷失者塞尔杜林
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，在本回合中获得<b>免疫</b>并攻击所有敌人。
//MAJ=HUNTER|COST=4|ATK=3|HP=4|RACE=NONE
}
public class WW_815e:Ability{
//NAME=塞尔杜林之怒
//TEXT=在本回合中，获得<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_816:SpellBase{
//NAME=飞向天空
//TEXT=抽两张龙牌，使其获得+1/+1。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WW_816e:Ability{
//NAME=飞诶诶起来
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_816t:MinionBase{
//NAME=快乐的雏龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=DRAGON
}
public class WW_818:SpellBase{
//NAME=仙人掌构造术
//TEXT=<b>发现</b>一张法力值消耗为（2）的随从牌，召唤一个它的1/1的复制。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class WW_818e:Ability{
//NAME=小东西
//TEXT=属性值变为1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_819:MinionBase{
//NAME=戏水雏龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，获得一个空的法力水晶。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=DRAGON
}
public class WW_820:MinionBase{
//NAME=棘尾幼龙
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，则对一个敌方随从造成5点伤害。
//MAJ=DRUID|COST=4|ATK=5|HP=4|RACE=DRAGON
}
public class WW_821:SpellBase{
//NAME=巨龙传说
//TEXT=<b>抉择：</b>获取两张法力值消耗小于或等于（5）点的随机龙牌；或者获取两张法力值消耗大于（5）点的随机龙牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_821t1:SpellBase{
//NAME=精炼简洁
//TEXT=获取两张法力值消耗小于或等于（5）点的随机龙牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_821t2:SpellBase{
//NAME=惊天巨著
//TEXT=获取两张法力值消耗大于（5）点的随机龙牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WW_822:MinionBase{
//NAME=巨龙魔像
//TEXT=<b>嘲讽</b>。<b>战吼：</b>你手牌中每有一张龙牌，召唤一个本随从的复制。
//MAJ=DRUID|COST=7|ATK=3|HP=4|RACE=DRAGON
}
public class WW_823:SpellBase{
//NAME=补水
//TEXT=恢复#7点生命值。<b>快枪：</b>复原两个法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class WW_824:MinionBase{
//NAME=瑞亚丝塔萨
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，则召唤纯净龙巢。
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class WW_824e:Ability{
//NAME=孵化幸福
//TEXT=法力值消耗减少（4）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_824t:MinionBase{
//NAME=纯净龙巢
//TEXT=在你的回合开始时，<b>发现</b> 一张龙牌，其法力值消耗减少（4）点。
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class WW_825:MinionBase{
//NAME=落日灵龙菲伊
//TEXT=<b>突袭</b>。<b>吸血</b>。<b>嘲讽</b>。在本局对战中，你每召唤一条龙，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class WW_826:MinionBase{
//NAME=沙漠巢母
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你的手牌中有龙牌，复原四个法力水晶。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=DRAGON
}
public class WW_827:MinionBase{
//NAME=雏龙牧人
//TEXT=在你的回合结束时，获取一张1/2并具有<b>嘲讽</b>的雏龙。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class WW_900:MinionBase{
//NAME=蹄铁发射机
//TEXT=<b>战吼：</b>随机对一个敌方随从造成2点伤害。<b>快枪：</b>并对一个相邻随从造成伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=MECHANICAL
}
public class WW_901:MinionBase{
//NAME=贪婪的伴侣
//TEXT=<b>战吼：</b>如果你手牌中有其他法力值消耗为2的牌，获取一张 幸运币。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class WW_906:MinionBase{
//NAME=吵闹的伴侣
//TEXT=<b>战吼：</b>如果你手牌中有其他法力值消耗为4的牌，造成4点 伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class WW_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WW_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
