using System.Collections;
using System.Collections.Generic;

public class WC_003:SpellBase{
//NAME=召唤咒符
//TEXT=在你的下个回合开始时，召唤两个2/2并具有<b>嘲讽</b>的恶魔。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class WC_003t:MinionBase{
//NAME=哀嚎恶魔
//TEXT=<b>嘲讽</b>
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class WC_004:MinionBase{
//NAME=牙缚德鲁伊
//TEXT=<b>嘲讽</b>，<b>亡语：</b> 使你手牌中的一张野兽牌法力值消耗减少（2）点。
//MAJ=DRUID|COST=3|ATK=4|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion && c.raceType.Contains(RaceType.Beast))
			{
				Pool.Add(c);
			}
		}
		Card ToBuff = Pool.Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,manaChange:-2).Resolve();
		}
	}
}
public class WC_004t:Ability{
//NAME=困于梦魇
//TEXT=法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_005:MinionBase{
//NAME=原初地下城历险家
//TEXT=<b>战吼：</b>抽一张法术牌。如果是自然法术牌，则再抽一张元素牌。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WC_006:MinionBase{
//NAME=安娜科德拉
//TEXT=你的自然法术的法力值消耗减少（2）点。
//MAJ=DRUID|COST=6|ATK=3|HP=7|RACE=NONE
}
public class WC_006e:Ability{
//NAME=自然强化
//TEXT=法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_007:SpellBase{
//NAME=毒蛇花
//TEXT=使一只友方野兽获得<b>剧毒</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_007e:Ability{
//NAME=毒蛇噬咬
//TEXT=<b>剧毒</b>
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_008:MinionBase{
//NAME=辛多雷气味猎手
//TEXT=<b>暴怒：</b>召唤四只1/1并具有<b>突袭</b>的土狼。
//MAJ=HUNTER|COST=4|ATK=1|HP=6|RACE=NONE
}
public class WC_013:MinionBase{
//NAME=虔诚地下城历险家
//TEXT=<b>战吼：</b>抽一张法术牌。如果是神圣法术牌，则使其法力值消耗减少（2）点。
//MAJ=PRIEST|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WC_013e:Ability{
//NAME=圣光射线
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_014:SpellBase{
//NAME=除奇致胜
//TEXT=消灭所有攻击力为奇数的随从。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class WC_015:MinionBase{
//NAME=水栖蝮蛇
//TEXT=<b>潜行</b> 如果你没有其他随从，则拥有<b>剧毒</b>。
//MAJ=ROGUE|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class WC_016:SpellBase{
//NAME=潜伏帷幕
//TEXT=抽两张随从牌，在本回合中使用则使其获得<b>潜行</b>一回合。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class WC_016e:Ability{
//NAME=隐蔽
//TEXT=在本回合中使用，以获得<b>潜行</b>一回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_016e2:Ability{
//NAME=隐形
//TEXT=<b>潜行</b>一回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_017:SpellBase{
//NAME=美味风蛇
//TEXT=将双方玩家手牌中的一张随从牌变形成为海盗或<b>潜行</b>随从牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WC_020:SpellBase{
//NAME=永恒之火
//TEXT=随机对一个敌方随从造成$3点伤害。如果该随从死亡，再次施放本法术。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class WC_021:SpellBase{
//NAME=不稳定的暗影震爆
//TEXT=对一个随从造成$6点伤害，超过目标生命值的伤害会命中你的英雄。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class WC_022:SpellBase{
//NAME=临终之息
//TEXT=对一个随从造成$1点伤害。如果该随从死亡，召唤一个2/2并具有随机效果的冒险者。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class WC_023:MinionBase{
//NAME=灵魂窃贼
//TEXT=每回合中你抽的第一张牌消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=4|ATK=2|HP=6|RACE=DEMON
}
public class WC_023e:Ability{
//NAME=被偷窃的灵魂
//TEXT=消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_024:MinionBase{
//NAME=武装战士
//TEXT=<b>战吼：</b>如果你装备着武器，便获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class WC_024e:Ability{
//NAME=武装
//TEXT=+1/+1
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_025:WeaponBase{
//NAME=砥石战斧
//TEXT=在你的英雄攻击后，使你手牌中的一张随从牌获得+1攻击力。
//MAJ=WARRIOR|COST=1|ATK=1|HP=4|RACE=NONE
}
public class WC_025e:Ability{
//NAME=武装
//TEXT=+1攻击力
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_026:MinionBase{
//NAME=克雷什，群龟之王
//TEXT=<b>暴怒：</b>获得8点护甲值。<b>亡语：</b>装备一把2/5的龟甲尖刺。
//MAJ=WARRIOR|COST=6|ATK=3|HP=9|RACE=BEAST
	public bool IsRaged=false;
	public override void AfterTakeDamage(Card source = null, int amount = 0)
	{
		if(!IsRaged && amount>0)
		{
			IsRaged=true;
			TaskBuffMyHero(arm:8);
		}
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("WC_026t"),ZoneType.Weapon);
	}
}
public class WC_026t:WeaponBase{
//NAME=龟甲尖刺
//TEXT=
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=NONE
}
public class WC_027:MinionBase{
//NAME=吞噬软浆怪
//TEXT=<b>亡语：</b> 召唤一个2/2并具有随机效果的冒险者。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class WC_028:MinionBase{
//NAME=集合石
//TEXT=在你的回合结束时，将一张2/2并具有随机效果的冒险者置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=NONE
}
public class WC_029:MinionBase{
//NAME=无私的同伴
//TEXT=<b>战吼：</b>随机从你的牌库中装备一把武器。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class WC_030:MinionBase{
//NAME=吞噬者穆坦努斯
//TEXT=<b>战吼：</b>吃掉你对手手牌中的一张随从牌，获得其属性值。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=4|RACE=MURLOC
	public override void Battlecry(Card target=null)
	{
		Card ToEat = owner.myPlayer.otherPlayer.hand.Choice(owner.myPlayer.randomGen);
		if(ToEat!=null)
		{
			int Atk=ToEat.GetTag(GameTag.Attack);
			int Hp=ToEat.GetTag(GameTag.Health);
			new EffectDestroy(owner.myPlayer,owner,ToEat).Resolve();
			new EffectChange(owner.myPlayer,owner,owner,atkChange:Atk,hpChange:Hp).Resolve();
		}
	}
}
public class WC_030e:Ability{
//NAME=吞噬消化
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_032:WeaponBase{
//NAME=淡云圆盾
//TEXT=<b>亡语：</b>使你的所有随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WC_033:SecretBase{
//NAME=公正审判
//TEXT=<b>奥秘：</b>当一个敌方随从攻击时，将其攻击力和生命值变为1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class WC_033e:Ability{
//NAME=审判之后
//TEXT=1/1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_034:SpellBase{
//NAME=小队集合
//TEXT=召唤五个2/2并具有随机效果的冒险者。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class WC_034t:MinionBase{
//NAME=致命的冒险者
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t2:MinionBase{
//NAME=健壮的冒险者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t3:MinionBase{
//NAME=虔诚的冒险者
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t4:MinionBase{
//NAME=无情的冒险者
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t5:MinionBase{
//NAME=奥术冒险者
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t6:MinionBase{
//NAME=鬼祟的冒险者
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class WC_034t7:MinionBase{
//NAME=活跃的冒险者
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_034t8:MinionBase{
//NAME=迅捷的冒险者
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WC_035:MinionBase{
//NAME=大德鲁伊纳拉雷克斯
//TEXT=<b>休眠</b>2回合。<b>休眠</b>状态下，在你的回合结束时，将一张梦境牌置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WC_035e:Ability{
//NAME=梦境
//TEXT=<b>休眠</b>状态下，在你的回合结束时，将一张梦境牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_035e2:Ability{
//NAME=Asleep
//TEXT=<b>Dormant</b>. Awaken in 2 turns.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_036:MinionBase{
//NAME=变异尖牙风蛇
//TEXT=在你施放一个自然法术后，召唤一条4/2并具有<b>突袭</b>的飞蛇。
//MAJ=DRUID|COST=8|ATK=4|HP=9|RACE=BEAST
}
public class WC_036t1:MinionBase{
//NAME=飞蛇
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class WC_037:WeaponBase{
//NAME=毒袭之弓
//TEXT=<b>剧毒</b>
//MAJ=HUNTER|COST=4|ATK=1|HP=2|RACE=NONE
}
public class WC_040:MinionBase{
//NAME=污心拷问者
//TEXT=<b>嘲讽</b> 你对手的法术的法力值消耗增加（2）点。
//MAJ=DEMONHUNTER|COST=8|ATK=8|HP=8|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardType==CardType.Spell &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer!=owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "WC_040e";
    }
}
public class WC_040e:Ability{
//NAME=饱受磨难
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return 2;
		}
		return 0;
	}
}
public class WC_041:SpellBase{
//NAME=冰爆冲击
//TEXT=消灭所有被<b>冻结</b>的随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class WC_042:MinionBase{
//NAME=哀嚎蒸汽
//TEXT=在你使用一张元素牌后，获得+1攻击力。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=ELEMENTAL
}
public class WC_042e:Ability{
//NAME=蒸汽升腾
//TEXT=+1攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WC_701:MinionBase{
//NAME=邪能响尾蛇
//TEXT=<b>突袭</b>，<b>亡语：</b>对所有敌方随从造成 1点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class WC_803:MinionBase{
//NAME=安瑟教士
//TEXT=<b>战吼：</b>在本回合中，如果你恢复过生命值，便从你的牌库中<b>发现</b>一张法术牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=NONE
}
public class WC_805:MinionBase{
//NAME=织霜地下城历险家
//TEXT=<b>战吼：</b>抽一张法术牌。如果是冰霜法术牌，则召唤两个1/1的可以<b>冻结</b>攻击目标的元素。
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WC_806:MinionBase{
//NAME=浮冰施法者
//TEXT=每有一个被<b>冻结</b>的敌人，本牌的法力值消耗便减少（2）点。
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
