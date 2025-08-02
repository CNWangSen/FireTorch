using System.Collections;
using System.Collections.Generic;

public class BT_002:SpellBase{
//NAME=咒术洪流
//TEXT=使你牌库中所有法术牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class BT_002e:Ability{
//NAME=咒术洪流
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_003:SecretBase{
//NAME=虚空之风传送门
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，随机召唤一个法力值消耗为（4）的随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class BT_004:MinionBase{
//NAME=被禁锢的眼魔
//TEXT=<b>休眠</b>2回合。唤醒时，对所有敌方随从造成2点伤害。
//MAJ=MAGE|COST=3|ATK=4|HP=5|RACE=DEMON
}
public class BT_006:SpellBase{
//NAME=唤醒
//TEXT=用随机法师法术牌填满你的手牌。这些牌为<b>临时</b>牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class BT_006e:Ability{
//NAME=唤醒
//TEXT=在你的回合结束时弃掉。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_008:MinionBase{
//NAME=锈誓新兵
//TEXT=<b>亡语：</b>召唤一个1/1并具有<b>法术伤害+1</b>的小鬼施法者。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BT_008t:MinionBase{
//NAME=小鬼施法者
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class BT_009:MinionBase{
//NAME=被禁锢的阳鳃鱼人
//TEXT=<b>休眠</b>2回合。唤醒时，召唤两个1/1的 鱼人。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=MURLOC
}
public class BT_009t:MinionBase{
//NAME=阳鳃士兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class BT_010:MinionBase{
//NAME=邪鳍导航员
//TEXT=<b>战吼：</b>使你的其他鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MURLOC
}
public class BT_010e:Ability{
//NAME=邪鳍注能
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_011:SpellBase{
//NAME=正义圣契
//TEXT=装备一把1/4的武器。将所有敌方随从的生命值变为1。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_011t"),ZoneType.Weapon);
		TaskSetHpTargets(owner.myPlayer.otherPlayer.board,1);
	}
}
public class BT_011e:Ability{
//NAME=正义制裁
//TEXT=生命值变为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_011t:WeaponBase{
//NAME=迟到的正义
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=4|RACE=NONE
}
public class BT_014:MinionBase{
//NAME=星占师
//TEXT=<b>亡语：</b>抽一张法术牌。
//MAJ=MAGE|COST=2|ATK=3|HP=1|RACE=NONE
}
public class BT_018:WeaponBase{
//NAME=幽光鱼竿
//TEXT=在你的英雄攻击后，随机将一张鱼人牌置入你的手牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class BT_019:MinionBase{
//NAME=莫戈尔·莫戈尔格
//TEXT=<b>圣盾</b> <b>亡语：</b>将“终极莫戈尔格”洗入你的牌库。
//MAJ=PALADIN|COST=2|ATK=2|HP=1|RACE=MURLOC
}
public class BT_019t:MinionBase{
//NAME=终极莫戈尔格
//TEXT=<b>圣盾，战吼：</b>随机召唤四个鱼人。使它们获得<b>圣盾</b>。
//MAJ=PALADIN|COST=8|ATK=6|HP=3|RACE=MURLOC
}
public class BT_020:MinionBase{
//NAME=奥尔多侍从
//TEXT=<b>战吼：</b>在本局对战中，你的圣契的法力值消耗减少（1）点。
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=NONE
	private int cryed=0;
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		this.cryed+=1;
	}
    public override bool AuraActive()
    {
        return (this.cryed>0);
    }
    public override bool AuraBuffThis(Card c)
    {
        return c.cardDbf.CnName.Contains("圣契");
    }
    public override string AuraBuffName(Card c)
    {
        return "BT_020e";
    }
}
public class BT_020e:Ability{
//NAME=奥尔多侍从
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return -1;
		}
		return 0;
	}
}
public class BT_021:SpellBase{
//NAME=能量之泉
//TEXT=<b>发现</b>一张法师随从牌。如果你的牌库中没有随从牌，则保留全部三张牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class BT_022:MinionBase{
//NAME=埃匹希斯走私犯
//TEXT=在你使用一张<b>奥秘</b>牌后，<b>发现</b>一张 法术牌。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BT_024:SpellBase{
//NAME=希望圣契
//TEXT=恢复8点生命值。召唤一个8/8并具有<b>嘲讽</b>和<b>圣盾</b>的 守卫。
//MAJ=PALADIN|COST=9|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		new EffectHeal(owner.myPlayer,owner,target,8).Resolve();
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_024t"),ZoneType.Board);
	}
}
public class BT_024t:MinionBase{
//NAME=远古守卫
//TEXT=<b>嘲讽，圣盾</b>
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("DivineShield");
	}
}
public class BT_025:SpellBase{
//NAME=智慧圣契
//TEXT=使一个随从获得+1/+1，以及“<b>亡语：</b>将一张‘智慧圣契’法术牌置入你的手牌。”
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:1).Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,target,"BT_025e").Resolve();
	}
}
public class BT_025e:Ability{
//NAME=圣光的智慧
//TEXT=+1/+1。<b>亡语：</b>将一张“智慧圣契”置入你的手牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_025"),ZoneType.Hand);
	}
}
public class BT_026:MinionBase{
//NAME=奥尔多真理追寻者
//TEXT=<b>嘲讽，战吼：</b> 在本局对战中，你的圣契的法力值消耗减少（2）点。
//MAJ=PALADIN|COST=5|ATK=4|HP=6|RACE=NONE
	private int cryed=0;
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		this.cryed+=1;
	}
    public override bool AuraActive()
    {
        return (this.cryed>0);
    }
    public override bool AuraBuffThis(Card c)
    {
        return c.cardDbf.CnName.Contains("圣契");
    }
    public override string AuraBuffName(Card c)
    {
        return "BT_026e";
    }
}
public class BT_026e:Ability{
//NAME=奥尔多真理追寻者
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return -2;
		}
		return 0;
	}
}
public class BT_028:MinionBase{
//NAME=星术师索兰莉安
//TEXT=<b>法术伤害+1</b> <b>亡语：</b>将“终极索兰莉安”洗入你的牌库。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class BT_028t:MinionBase{
//NAME=终极索兰莉安
//TEXT=<b>法术伤害+1</b> <b>战吼：</b>随机施放五个法师法术<i>（尽可能以敌人为目标）</i>。
//MAJ=MAGE|COST=7|ATK=7|HP=7|RACE=DEMON
}
public class BT_035:SpellBase{
//NAME=混乱打击
//TEXT=在本回合中，使你的英雄获得+2攻击力。抽一张牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:2);
		TaskDraw();
	}
}
public class BT_035e:Ability{
//NAME=混乱打击
//TEXT=在本回合中，+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_036:SpellBase{
//NAME=协同打击
//TEXT=召唤三个1/1并具有<b>突袭</b>的伊利达雷。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
	}
}
public class BT_036t:MinionBase{
//NAME=伊利达雷新兵
//TEXT=<b>突袭</b>
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class BT_042:SecretBase{
//NAME=偷天换日
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，随机将其变形成为一个法力值消耗增加（3）点的随从。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_072:SpellBase{
//NAME=深度冻结
//TEXT=<b>冻结</b>一个敌人。召唤两个3/6的水元素。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=FROST
}
public class BT_100:SpellBase{
//NAME=毒蛇神殿传送门
//TEXT=造成$3点伤害。随机召唤一个法力值消耗为（3）的随从。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class BT_101:SpellBase{
//NAME=鲜活孢子
//TEXT=使你的所有随从获得“<b>亡语</b>：再次召唤本随从。”
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class BT_101e:Ability{
//NAME=菌光聚顶
//TEXT=<b>亡语：</b>再次召唤本随从。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_102:WeaponBase{
//NAME=沼泽拳刺
//TEXT=在你的英雄攻击后，随机将你的所有随从变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=5|ATK=4|HP=2|RACE=NONE
}
public class BT_106:MinionBase{
//NAME=泥沼巨钳龙虾人
//TEXT=<b>战吼：</b> 将相邻的随从随机变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class BT_109:MinionBase{
//NAME=瓦丝琪女士
//TEXT=<b>法术伤害+1</b> <b>亡语：</b>将“终极瓦丝琪”洗入你的牌库。
//MAJ=SHAMAN|COST=3|ATK=4|HP=3|RACE=NAGA
}
public class BT_109t:MinionBase{
//NAME=终极瓦丝琪
//TEXT=<b>法术伤害+1</b> <b>战吼：</b>抽三张法术牌，其法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=7|ATK=5|HP=4|RACE=NAGA
}
public class BT_109te:Ability{
//NAME=终极瓦丝琪
//TEXT=法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_110:SpellBase{
//NAME=洪流
//TEXT=对一个随从造成$8点伤害。如果你在上个回合施放过法术，则法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class BT_113:SpellBase{
//NAME=图腾映像
//TEXT=使一个随从获得+2/+2。如果该随从是图腾，召唤一个它的复制。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class BT_113e:Ability{
//NAME=图腾真棒
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_114:MinionBase{
//NAME=破碎奔行者
//TEXT=<b>战吼：</b> 如果你在上个回合施放过法术，则对所有其他随从造成2点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=6|RACE=ELEMENTAL
}
public class BT_115:MinionBase{
//NAME=沼泽之子
//TEXT=<b>战吼：</b>如果你在上回合施放过法术，<b>发现</b>一张法术牌。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class BT_117:SpellBase{
//NAME=剑刃风暴
//TEXT=对所有随从造成$1点伤害。重复此效果，直到某个随从 死亡。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		int GraveCnt = owner.myPlayer.grave.Merge(owner.myPlayer.otherPlayer.grave).Count;
		if(GraveCnt>0)
		{
			while(owner.myPlayer.grave.Merge(owner.myPlayer.otherPlayer.grave).Count==GraveCnt)
			{
				TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
			}
		}
	}
}
public class BT_120:MinionBase{
//NAME=战槌挑战者
//TEXT=<b>战吼：</b> 选择一个敌方随从。与其战斗至死！
//MAJ=WARRIOR|COST=3|ATK=1|HP=10|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		while(target.GetTag(GameTag.Health)>0 && owner.GetTag(GameTag.Health)>0)
		{
			new EffectAttack(owner.myPlayer,owner,target).Resolve();
		}
	}
}
public class BT_121:MinionBase{
//NAME=被禁锢的甘尔葛
//TEXT=<b>休眠</b>2回合。 唤醒时，装备一把3/2的斧子。
//MAJ=WARRIOR|COST=1|ATK=2|HP=2|RACE=DEMON
}
public class BT_123:MinionBase{
//NAME=卡加斯·刃拳
//TEXT=<b>突袭</b> <b>亡语：</b>将“终极卡加斯”洗入你的牌库。
//MAJ=WARRIOR|COST=4|ATK=4|HP=4|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_123t"),ZoneType.Deck,randpos:true);
	}
}
public class BT_123t:MinionBase{
//NAME=终极卡加斯
//TEXT=<b>突袭</b> 每当本随从攻击并消灭一个随从时，获得10点护甲值。
//MAJ=WARRIOR|COST=8|ATK=10|HP=10|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void AfterAttack(Card target=null)
	{
		if(target.GetTag(GameTag.Health)<=0)
		{
			TaskBuffMyHero(arm:10);
		}
	}
}
public class BT_124:SpellBase{
//NAME=海盗藏品
//TEXT=抽一张武器牌。使其获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_124e:Ability{
//NAME=虚空磨砺
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_126:MinionBase{
//NAME=塔隆·血魔
//TEXT=<b>战吼：</b>消灭所有其他友方随从。<b>亡语：</b>再次召唤被消灭的随从并使其获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class BT_126e:Ability{
//NAME=阴暗构造体
//TEXT=消灭了{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_126e2:Ability{
//NAME=复仇之魂
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_127:MinionBase{
//NAME=被禁锢的萨特
//TEXT=<b>休眠</b>2回合。唤醒时，使你手牌中的随机一张随从牌的法力值消耗减少（5）点。
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class BT_127e:Ability{
//NAME=被禁锢的萨特
//TEXT=法力值消耗减少（5）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_128:SpellBase{
//NAME=真菌宝藏
//TEXT=抽三张牌。 弃掉抽到的所有随从牌。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class BT_129:SpellBase{
//NAME=萌芽分裂
//TEXT=召唤一个友方随从的复制。使复制获得<b>嘲讽</b>。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class BT_129e:Ability{
//NAME=有丝分裂
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_130:SpellBase{
//NAME=过度生长
//TEXT=获得两个空的法力水晶。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class BT_131:MinionBase{
//NAME=伊谢尔·风歌
//TEXT=你的法术的法力值消耗为（1）点。
//MAJ=DRUID|COST=9|ATK=5|HP=5|RACE=NONE
}
public class BT_131e:Ability{
//NAME=伊谢尔·风歌
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_132:SpellBase{
//NAME=铁木树皮
//TEXT=使一个随从获得+1/+3和<b>嘲讽</b>。如果你拥有至少七个法力水晶，则法力值消耗为（0）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class BT_132e:Ability{
//NAME=铁木树皮
//TEXT=+1/+3和<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_133:MinionBase{
//NAME=沼泽多头蛇
//TEXT=<b>突袭</b> 在本随从攻击后，随机将一张法力值消耗为（8）的随从牌置入你的手牌。
//MAJ=DRUID|COST=7|ATK=7|HP=7|RACE=BEAST
}
public class BT_134:SpellBase{
//NAME=沼泽射线
//TEXT=对一个随从造成$3点伤害。如果你拥有至少七个法力水晶，则法力值消耗为（0）点。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=7)
                return -3;
        }
        return 0;
    }
}
public class BT_135:SpellBase{
//NAME=萤火成群
//TEXT=你的手牌中每有一张法术牌，召唤一只2/2的萤火虫。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BT_135t:MinionBase{
//NAME=萤火虫
//TEXT=
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class BT_136:MinionBase{
//NAME=孢子首领姆希菲
//TEXT=<b>嘲讽</b> <b>亡语：</b>将“终极姆希菲”洗入你的牌库。
//MAJ=DRUID|COST=3|ATK=3|HP=4|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_136t"),ZoneType.Deck,randpos:true);
	}
}
public class BT_136t:MinionBase{
//NAME=终极姆希菲
//TEXT=<b>嘲讽</b> <b>抉择：</b>召唤一个9/9的巨型真菌，并使其获得<b>嘲讽</b>；或者使其获得<b>突袭</b>。
//MAJ=DRUID|COST=10|ATK=9|HP=9|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		Card Summoned = TaskCreate(CardDbf.GetCardDbfByGuid("BT_136tt"),ZoneType.Board);
		if(target.myPlayer==owner.myPlayer)
		{
			new EffectGiveAbility(owner.myPlayer,owner,Summoned,"Taunt").Resolve();
		}
		else{
			new EffectGiveAbility(owner.myPlayer,owner,Summoned,"Rush").Resolve();
		}
	}
}
public class BT_136ta:SpellBase{
//NAME=姆希菲防护
//TEXT=召唤一个9/9并具有<b>嘲讽</b>的 守卫。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
}
public class BT_136tb:SpellBase{
//NAME=姆希菲出击
//TEXT=召唤一个9/9并具有<b>突袭</b>的 打手。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
}
public class BT_136tt:MinionBase{
//NAME=真菌守卫
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=10|ATK=9|HP=9|RACE=NONE
}
public class BT_136tt2:MinionBase{
//NAME=真菌打手
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=10|ATK=9|HP=9|RACE=NONE
}
public class BT_136tt3:MinionBase{
//NAME=真菌巨怪
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=DRUID|COST=10|ATK=9|HP=9|RACE=NONE
}
public class BT_138:MinionBase{
//NAME=沸血蛮兵
//TEXT=<b>突袭</b> 每有一个受伤的随从，本牌的法力值消耗便减少（1）点。
//MAJ=WARRIOR|COST=7|ATK=6|HP=8|RACE=NONE
}
public class BT_140:MinionBase{
//NAME=噬骨骑兵
//TEXT=<b>战吼：</b>如果有受伤的随从，便获得+1/+1和<b>突袭</b>。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class BT_140e:Ability{
//NAME=骑乘座狼
//TEXT=+1/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_142:MinionBase{
//NAME=影蹄杀手
//TEXT=<b>战吼：</b>在本回合中，使你的英雄获得+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=1|RACE=DEMON
}
public class BT_142e:Ability{
//NAME=利爪
//TEXT=本回合获得+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_155:MinionBase{
//NAME=废料场巨像
//TEXT=<b>嘲讽，亡语：</b>召唤一个7/7并具有<b>嘲讽</b>的邪爆巨像。
//MAJ=NEUTRAL|COST=10|ATK=7|HP=7|RACE=ELEMENTAL
}
public class BT_155t:MinionBase{
//NAME=邪爆巨像
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class BT_156:MinionBase{
//NAME=被禁锢的邪犬
//TEXT=<b>休眠</b>2回合。 <b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=5|RACE=DEMON
}
public class BT_159:MinionBase{
//NAME=逃脱的恐惧卫士
//TEXT=<b>战吼：</b>为你的对手召唤三个1/1的女猎手。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=DEMON
}
public class BT_159t:MinionBase{
//NAME=女猎手
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BT_160:MinionBase{
//NAME=锈誓信徒
//TEXT=<b>战吼：</b>使你的其他随从获得“<b>亡语：</b>召唤一个1/1的恶魔。”
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class BT_160e:Ability{
//NAME=锈誓契约
//TEXT=<b>亡语：</b>召唤一个1/1的恶魔。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_160t:MinionBase{
//NAME=铁锈恶鬼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class BT_163:SpellBase{
//NAME=纳格兰大冲撞
//TEXT=召唤四只3/5的裂蹄牛并使其攻击随机敌人。
//MAJ=HUNTER|COST=10|ATK=0|HP=0|RACE=NONE
}
public class BT_163t:MinionBase{
//NAME=裂蹄牛
//TEXT=
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class BT_173:SpellBase{
//NAME=统率伊利达雷
//TEXT=召唤六个1/1并具有<b>突袭</b>的伊利达雷。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BT_175:SpellBase{
//NAME=双刃斩击
//TEXT=在本回合中，使你的英雄获得+2攻击力。将“二次斩击”置入你的手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:2);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_175t"),ZoneType.Hand);
	}
}
public class BT_175e:Ability{
//NAME=双刃斩击
//TEXT=在本回合中，你的英雄拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=DEMON
}
public class BT_175t:SpellBase{
//NAME=二次斩击
//TEXT=在本回合中，使你的英雄获得+2攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:2);
	}
}
public class BT_187:MinionBase{
//NAME=凯恩·日怒
//TEXT=<b>冲锋</b> 所有友方攻击无视 <b>嘲讽</b>。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=5|RACE=NONE
}
public class BT_187e:Ability{
//NAME=死亡之舞
//TEXT=你的攻击无视<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_187e2:Ability{
//NAME=死亡之舞
//TEXT=凯恩使其无视<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_188:MinionBase{
//NAME=暗影珠宝师汉纳尔
//TEXT=在你使用一张<b>奥秘</b>牌后，<b>发现</b>一张不同职业的<b>奥秘</b>牌。
//MAJ=ROGUE|COST=2|ATK=1|HP=4|RACE=NONE
}
public class BT_190:MinionBase{
//NAME=复制机器人
//TEXT=在你的回合结束时，将一个相邻的随从变形成为本随从的复制。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=MECHANICAL
}
public class BT_196:MinionBase{
//NAME=击碎者克里丹
//TEXT=<b>战吼：</b>消灭一个随从。如果在本回合被抽到，则改为消灭除本随从外的所有随从。
//MAJ=WARLOCK|COST=6|ATK=3|HP=3|RACE=NONE
	bool quickDraw=true;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
		{
			quickDraw=false;
			this.UnRegisterEventEffect();
		}
	}
	public override void Battlecry(Card target=null)
	{
		if(quickDraw)
		{
			TaskDestroyTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner));
		}
		else{
			new EffectDestroy(owner.myPlayer,owner,target).Resolve();
		}
	}
}
public class BT_196e:Ability{
//NAME=Come Closer
//TEXT=Drawn this turn.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_197:MinionBase{
//NAME=灵魂之匣
//TEXT=<b>吸血</b> <b>亡语：</b>将“终极魂匣”洗入你的牌库。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_197t"),ZoneType.Deck);
	}
}
public class BT_197t:MinionBase{
//NAME=终极魂匣
//TEXT=<b>嘲讽</b>。<b>吸血</b> 在你对手的回合<b>扰魔</b>。
//MAJ=PRIEST|COST=7|ATK=6|HP=8|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("LifeSteal");
		TaskInitAbility("Elusive");
	}
}
public class BT_198:SpellBase{
//NAME=灵魂之镜
//TEXT=召唤所有敌方随从的复制，并使敌方随从攻击其复制。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<Card> AtkSrc = new List<Card>();
		List<Card> ToAtk = new List<Card>();
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(owner.myPlayer.board.Count<7)
			{
				Card Created=TaskCreate(c.cardDbf,ZoneType.Board);
				AtkSrc.Add(c);
				ToAtk.Add(Created);
			}
		}
		for(int i=0;i<AtkSrc.Count;i++)
		{
			new EffectAttack(owner.myPlayer,AtkSrc[i],ToAtk[i]).Resolve();
		}

	}
}
public class BT_199:SpellBase{
//NAME=不稳定的邪能箭
//TEXT=对一个敌方随从和一个随机友方随从造成$3点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class BT_201:MinionBase{
//NAME=强能箭猪
//TEXT=<b>亡语：</b> 造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class BT_202:MinionBase{
//NAME=地狱野猪
//TEXT=<b>亡语：</b>随机使你手牌中的一张野兽牌获得+1/+1。
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class BT_202e:Ability{
//NAME=血之气息
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_203:SecretBase{
//NAME=集群战术
//TEXT=<b>奥秘：</b>当一个友方随从受到攻击时，召唤一个该随从的3/3的复制。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_203e:Ability{
//NAME=集群成员
//TEXT=攻击力和生命值为3。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_205:SpellBase{
//NAME=废铁射击
//TEXT=造成$3点伤害。随机使你手牌中的一张野兽牌获得+3/+3。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BT_205e:Ability{
//NAME=废金利爪
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_210:MinionBase{
//NAME=顶级捕食者兹克索尔
//TEXT=<b>突袭</b> <b>亡语：</b>将“终极兹克索尔”洗入你的牌库。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class BT_210t:MinionBase{
//NAME=终极兹克索尔
//TEXT=<b>突袭，战吼：</b>召唤本随从的三个复制。
//MAJ=HUNTER|COST=8|ATK=4|HP=4|RACE=BEAST
}
public class BT_211:MinionBase{
//NAME=被禁锢的魔喉
//TEXT=<b>休眠</b>2回合。唤醒时，随机攻击一个 敌人。
//MAJ=HUNTER|COST=2|ATK=5|HP=4|RACE=DEMON
}
public class BT_212:MinionBase{
//NAME=莫克纳萨将狮
//TEXT=<b>突袭，战吼：</b>选择一个友方随从，获得其<b>亡语</b>的复制。
//MAJ=HUNTER|COST=4|ATK=5|HP=2|RACE=BEAST
}
public class BT_212e:Ability{
//NAME=追猎
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_213:SpellBase{
//NAME=拾荒者的智慧
//TEXT=抽一张野兽牌。使其获得+3/+3。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_213e:Ability{
//NAME=集群战术
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_214:MinionBase{
//NAME=兽王莱欧洛克斯
//TEXT=<b>战吼：</b>从你的手牌中召唤三只野兽。
//MAJ=HUNTER|COST=8|ATK=5|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectEmote(owner.myPlayer,owner,"来我身边！").Resolve();
		new EffectEmote(owner.myPlayer,null,"伤害翻倍！",CardDbf.GetCardDbfByGuid("TMP_EDR_005")).Resolve();
		new EffectEmote(owner.myPlayer,null,"吼吼吼!",CardDbf.GetCardDbfByGuid("EX1_543")).Resolve();
		int Cnt=0;
		List<Card> ToMove = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(Cnt<3 && c.raceType.Contains(RaceType.Beast))
			{
				ToMove.Add(c);
				Cnt+=1;
			}
		}
		foreach(Card c in ToMove)
		{
			new EffectMove(owner.myPlayer,c,ZoneType.Hand,ZoneType.Board).Resolve();
		}
	}
}
public class BT_230:MinionBase{
//NAME=鱼斯拉
//TEXT=<b>战吼：</b>对一个敌方随从造成3点伤害。如果该随从死亡，则对一个相邻的随从重复此效果。
//MAJ=SHAMAN|COST=6|ATK=6|HP=5|RACE=BEAST
}
public class BT_233:SpellBase{
//NAME=剑盾猛攻
//TEXT=对一个随从造成$2点伤害。获得2点护甲值。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		TaskBuffMyHero(arm:2);
	}
}
public class BT_235:SpellBase{
//NAME=混乱新星
//TEXT=对所有随从造成$4点伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),4);
	}
}
public class BT_249:MinionBase{
//NAME=废铁魔像
//TEXT=<b>嘲讽</b>。<b>亡语：</b>获得等同于本随从攻击力的护甲值。
//MAJ=WARRIOR|COST=5|ATK=4|HP=5|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskBuffMyHero(arm:owner.GetTag(GameTag.Attack));
	}
}
public class BT_252:SpellBase{
//NAME=复苏
//TEXT=恢复#3点 生命值。<b>发现</b>一张法术牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class BT_253:SpellBase{
//NAME=心灵分裂
//TEXT=使一个随从获得+1/+2，并召唤一个它的复制。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class BT_253e:Ability{
//NAME=双生视界
//TEXT=+1/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_254:MinionBase{
//NAME=塞泰克织巢者
//TEXT=在你对一个随从施放法术后，随机将一张牧师法术牌置入你的 手牌。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BT_255:MinionBase{
//NAME=凯尔萨斯·逐日者
//TEXT=在每回合中，你每施放三个法术，第三个法术的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=7|RACE=NONE
}
public class BT_255e:Ability{
//NAME=逐日者
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_256:MinionBase{
//NAME=龙喉监工
//TEXT=在你的回合结束时，使另一个友方随从获得+2/+2。
//MAJ=PRIEST|COST=3|ATK=2|HP=2|RACE=NONE
}
public class BT_256e:Ability{
//NAME=靴痕犹在
//TEXT=属性值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_257:SpellBase{
//NAME=神圣化身
//TEXT=使一个随从获得+2/+3和<b>吸血</b>。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class BT_257e:Ability{
//NAME=神圣化身
//TEXT=+2/+3和<b>吸血</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_258:MinionBase{
//NAME=被禁锢的矮劣魔
//TEXT=<b>休眠</b>2回合。<b>嘲讽</b>
//MAJ=PRIEST|COST=1|ATK=2|HP=5|RACE=DEMON
}
public class BT_262:MinionBase{
//NAME=龙喉哨兵
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>吸血</b>。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(CondHoldAnotherRace(RaceType.Dragon))
		{
			new EffectGiveAbility(owner.myPlayer,owner,owner,"LifeSteal").Resolve();
			new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
		}
	}
}
public class BT_262e:Ability{
//NAME=虚空视野
//TEXT=+1攻击力和<b>吸血</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_271:WeaponBase{
//NAME=斩炎
//TEXT=同时对其攻击目标相邻的随从 造成伤害。
//MAJ=DEMONHUNTER|COST=7|ATK=5|HP=3|RACE=NONE
}
public class BT_291:SpellBase{
//NAME=埃匹希斯冲击
//TEXT=造成$5点伤害。如果你的牌库中没有随从牌，随机召唤一个法力值消耗为（5）的随从。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BT_292:SpellBase{
//NAME=阿达尔之手
//TEXT=使一个随从获得+2/+1。 抽一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class BT_292e:Ability{
//NAME=阿达尔之手
//TEXT=+2/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_300:SpellBase{
//NAME=古尔丹之手
//TEXT=当你使用或弃掉这张牌时，抽三张牌。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class BT_301:MinionBase{
//NAME=夜影主母
//TEXT=<b>突袭，战吼：</b> 弃掉你手牌中法力值消耗最高的牌。
//MAJ=WARLOCK|COST=4|ATK=5|HP=5|RACE=DEMON
}
public class BT_302:SpellBase{
//NAME=黑暗之门
//TEXT=抽一张随从牌。如果你拥有至少八张手牌，则使其法力值消耗减少（5）点。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		Card Drawn = TaskDrawType(CardType.Minion);
		if(Drawn!=null && owner.myPlayer.hand.Count>=8)
		{
			new EffectChange(owner.myPlayer,owner,Drawn,manaChange:-5).Resolve();
		}
	}
}
public class BT_302e:Ability{
//NAME=黑暗之门
//TEXT=法力值消耗减少（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_304:MinionBase{
//NAME=改进型恐惧魔王
//TEXT=<b>嘲讽，亡语：</b>召唤一个5/5并具有<b>吸血</b>的恐惧魔王。
//MAJ=WARLOCK|COST=8|ATK=5|HP=7|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_304t"),ZoneType.Board);
	}
}
public class BT_304t:MinionBase{
//NAME=绝望的恐惧魔王
//TEXT=<b>吸血</b>
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
}
public class BT_305:MinionBase{
//NAME=被禁锢的拾荒小鬼
//TEXT=<b>休眠</b>2回合。唤醒时，使你手牌中的所有随从牌获得+2/+2。
//MAJ=WARLOCK|COST=2|ATK=3|HP=3|RACE=DEMON
}
public class BT_305e:Ability{
//NAME=废铁武器
//TEXT=+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_306:SpellBase{
//NAME=暗影议会
//TEXT=随机将你的手牌替换成恶魔牌，并使它们获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class BT_306e:Ability{
//NAME=仪式召唤
//TEXT=+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_307:MinionBase{
//NAME=黑眼
//TEXT=在你的英雄受到伤害后，复原一个 法力水晶。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=DEMON
}
public class BT_309:MinionBase{
//NAME=坎雷萨德·埃伯洛克
//TEXT=你的恶魔牌法力值消耗减少（1）点。<b>亡语：</b>将“终极坎雷萨德”洗入你的牌库。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=NONE
}
public class BT_309e:Ability{
//NAME=黑暗收割
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_309t:MinionBase{
//NAME=终极坎雷萨德
//TEXT=<b>战吼：</b>召唤三个在本局对战中死亡的友方恶魔。
//MAJ=WARLOCK|COST=8|ATK=7|HP=6|RACE=DEMON
}
public class BT_321:MinionBase{
//NAME=虚无行者
//TEXT=<b>战吼：</b> <b>发现</b>一张恶魔牌。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BT_323:MinionBase{
//NAME=盲眼监视者
//TEXT=<b>战吼：</b>检视你牌库中的三张牌。选择一张置于牌库顶。
//MAJ=DEMONHUNTER|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class BT_334:MinionBase{
//NAME=女伯爵莉亚德琳
//TEXT=<b>战吼：</b>将你在本局对战中施放在友方角色上的所有法术的复制置入你的手牌。
//MAJ=PALADIN|COST=7|ATK=4|HP=6|RACE=NONE
}
public class BT_341:MinionBase{
//NAME=骸骨巨龙
//TEXT=<b>嘲讽</b> 在你的回合结束时，将一张龙牌置入你的手牌。
//MAJ=PRIEST|COST=7|ATK=4|HP=9|RACE=DRAGON
}
public class BT_351:MinionBase{
//NAME=战斗邪犬
//TEXT=在你的英雄攻击后，获得+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=3|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(owner.myPlayer.hero.Count>0)
			{
				if(sc==owner.myPlayer.hero[0])
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
				}
			}
		}
	}
}
public class BT_351e:Ability{
//NAME=邪能驱使
//TEXT=攻击力提高。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_352:MinionBase{
//NAME=萨特监工
//TEXT=在你的英雄攻击后，召唤一个2/2的萨特。
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=2|RACE=DEMON
}
public class BT_352t:MinionBase{
//NAME=伊利达雷萨特
//TEXT=
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class BT_354:SpellBase{
//NAME=刃舞
//TEXT=随机对三个敌方随从造成等同于你的英雄攻击力的伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class BT_355:MinionBase{
//NAME=怒鳞纳迦
//TEXT=在一个友方随从死亡后，随机对一个敌人造成3点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=NAGA
}
public class BT_407:MinionBase{
//NAME=乌祖尔恐魔
//TEXT=<b>亡语：</b>将一张2/1的“迷失之魂”置入你的 手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=1|RACE=DEMON
}
public class BT_407t:MinionBase{
//NAME=迷失之魂
//TEXT=
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class BT_416:MinionBase{
//NAME=暴怒邪吼者
//TEXT=<b>战吼：</b>你的下一张恶魔牌的法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=4|RACE=NONE
}
public class BT_416e:Ability{
//NAME=邪能之吼
//TEXT=你的下一张恶魔牌的法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_423:MinionBase{
//NAME=灰舌将领
//TEXT=<b>嘲讽，吸血</b>
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=5|RACE=NONE
}
public class BT_427:SpellBase{
//NAME=灵魂盛宴
//TEXT=在本回合中每有一个友方随从死亡，抽一张牌。0<i>（抽0张牌）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class BT_429:SpellBase{
//NAME=恶魔变形
//TEXT=将你的英雄技能替换为“造成5点伤害。”使用两次后，换回原技能。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class BT_429p:HeroPowerBase{
//NAME=恶魔冲击
//TEXT=造成$5点伤害。<i>（还可使用两次！）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BT_429p2:HeroPowerBase{
//NAME=恶魔冲击
//TEXT=造成$5点伤害。<i>（还可使用一次！）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BT_430:WeaponBase{
//NAME=埃辛诺斯战刃
//TEXT=在攻击一个随从后，你的英雄可以再次攻击。
//MAJ=DEMONHUNTER|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BT_480:MinionBase{
//NAME=火色魔印奔行者
//TEXT=<b>流放：</b>抽一张牌。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BT_481:MinionBase{
//NAME=奈瑟兰达姆斯
//TEXT=<b>战吼：</b>随机召唤两个法力值消耗为（0）的随从。<i> （每有一个友方随从死亡都会升级！）</i>
//MAJ=DEMONHUNTER|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class BT_486:MinionBase{
//NAME=深渊指挥官
//TEXT=<b>嘲讽</b> 在你的回合结束时，从你的牌库中召唤一个恶魔。
//MAJ=DEMONHUNTER|COST=9|ATK=7|HP=9|RACE=DEMON
}
public class BT_487:MinionBase{
//NAME=巨型大恶魔
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，可再次攻击。
//MAJ=DEMONHUNTER|COST=8|ATK=5|HP=10|RACE=DEMON
}
public class BT_488:SpellBase{
//NAME=灵魂分裂
//TEXT=选择一个友方恶魔，召唤一个它的复制。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		if(target.raceType.Contains(RaceType.Demon))
			TaskCreate(target.cardDbf,ZoneType.Board);
	}
}
public class BT_490:SpellBase{
//NAME=吞噬魔法
//TEXT=<b>沉默</b>一个敌方随从。<b>流放：</b>抽一张牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class BT_491:SpellBase{
//NAME=幽灵视觉
//TEXT=抽一张牌。<b>流放：</b>再抽一张。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_493:MinionBase{
//NAME=愤怒的女祭司
//TEXT=在你的回合结束时，造成6点伤害，随机分配到所有敌人身上。
//MAJ=DEMONHUNTER|COST=7|ATK=6|HP=7|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
			TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),6);
	}
}
public class BT_495:MinionBase{
//NAME=刃缚精锐
//TEXT=<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，则造成4点 伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=6|HP=4|RACE=NONE
}
public class BT_496:MinionBase{
//NAME=暴怒的邪鳍
//TEXT=<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，则获得+1攻击力和<b>突袭</b>。
//MAJ=DEMONHUNTER|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class BT_496e:Ability{
//NAME=生鳍又生气
//TEXT=+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_509:MinionBase{
//NAME=邪能召唤师
//TEXT=<b>亡语：</b>随机从你的手牌中召唤一个恶魔。
//MAJ=DEMONHUNTER|COST=6|ATK=8|HP=3|RACE=NONE
}
public class BT_510:MinionBase{
//NAME=怒刺蛮兵
//TEXT=<b>嘲讽</b> 在本随从被攻击后，对所有敌人造成1点伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=2|HP=6|RACE=DEMON
}
public class BT_512:SpellBase{
//NAME=心中的恶魔
//TEXT=在本回合中，使你的英雄获得+8攻击力。
//MAJ=DEMONHUNTER|COST=8|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:8);
	}
}
public class BT_512e:Ability{
//NAME=恶魔之力
//TEXT=+8攻击力
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_512e3:Ability{
//NAME=烙印
//TEXT=在每个回合结束时受到1点伤害。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_514:SpellBase{
//NAME=献祭光环
//TEXT=对所有随从造成$1点伤害两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
	}
}
public class BT_601:SpellBase{
//NAME=古尔丹之颅
//TEXT=抽三张牌。<b>流放：</b>这些牌的法力值消耗减少（3）点。
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class BT_601e:Ability{
//NAME=拥抱力量
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_701:MinionBase{
//NAME=间谍女郎
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=1|ATK=3|HP=1|RACE=NONE
}
public class BT_702:MinionBase{
//NAME=灰舌杀手
//TEXT=<b>战吼：</b>在本回合中，使一个<b>潜行</b>的随从获得+3攻击力和<b>免疫</b>。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class BT_702e:Ability{
//NAME=灰舌的狡诈
//TEXT=在本回合中，+3攻击力和<b>免疫</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_703:MinionBase{
//NAME=被诅咒的流浪者
//TEXT=<b>亡语：</b>召唤一个7/5并具有<b>潜行</b>的阴影。
//MAJ=ROGUE|COST=7|ATK=7|HP=5|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_703t"),ZoneType.Board);
	}
}
public class BT_703t:MinionBase{
//NAME=被诅咒的阴影
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=7|ATK=7|HP=5|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Stealth");
	}
}
public class BT_707:SecretBase{
//NAME=伏击
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤一个2/3并具有<b>剧毒</b>的伏击者。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_707t:MinionBase{
//NAME=破碎者伏兵
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BT_709:SecretBase{
//NAME=邪恶计谋
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，抽两张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BT_710:MinionBase{
//NAME=暗心贤者
//TEXT=<b>战吼：</b>如果你控制一个<b>潜行</b>的随从，抽两张牌。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class BT_711:MinionBase{
//NAME=钉棍终结者
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，将一个随从移回其拥有者的手牌，并且法力值消耗增加（2）点。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class BT_711e:Ability{
//NAME=击晕
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_713:MinionBase{
//NAME=阿卡玛
//TEXT=<b>潜行</b> <b>亡语：</b>将“终极阿卡玛”洗入你的牌库。
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Stealth");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_713t"),ZoneType.Deck,randpos:true);
	}
}
public class BT_713t:MinionBase{
//NAME=终极阿卡玛
//TEXT=永久<b>潜行</b>。
//MAJ=ROGUE|COST=6|ATK=6|HP=5|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("StealthForever");
	}
}
public class BT_714:MinionBase{
//NAME=冰霜织影者
//TEXT=<b>战吼：</b> <b>冻结</b>一个敌人。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class BT_715:MinionBase{
//NAME=噬骨殴斗者
//TEXT=<b>嘲讽</b> 每当本随从受到伤害，便获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BT_715e:Ability{
//NAME=殴斗成性
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_716:MinionBase{
//NAME=噬骨先锋
//TEXT=<b>嘲讽</b> 每当本随从受到伤害，便获得+2攻击力。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=10|RACE=NONE
}
public class BT_716e:Ability{
//NAME=旗开得胜
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_717:MinionBase{
//NAME=潜地蝎
//TEXT=<b>战吼：</b>造成2点伤害。如果消灭了目标，则获得<b>潜行</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=2|RACE=BEAST
}
public class BT_720:MinionBase{
//NAME=锈骑劫匪
//TEXT=<b>嘲讽，突袭， 战吼：</b>在本回合获得+4攻击力。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=8|RACE=NONE
}
public class BT_720e:Ability{
//NAME=骑行永恒
//TEXT=在本回合中+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_721:MinionBase{
//NAME=起泡的腐泥怪
//TEXT=在你的回合结束时，召唤一个属性值等同于本随从的腐质。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=2|RACE=NONE
}
public class BT_721t:MinionBase{
//NAME=生命腐质
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BT_722:MinionBase{
//NAME=防护改装师
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class BT_723:MinionBase{
//NAME=火箭改装师
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class BT_724:MinionBase{
//NAME=虚灵改装师
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class BT_724e:Ability{
//NAME=虚灵改装
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_726:MinionBase{
//NAME=龙喉巡天者
//TEXT=<b>亡语：</b>召唤一个3/4的龙骑士。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=DRAGON
}
public class BT_726t:MinionBase{
//NAME=龙骑士
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class BT_727:MinionBase{
//NAME=魂缚灰舌
//TEXT=每当本随从受到伤害，对你的英雄造成等量的伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=4|RACE=NONE
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	TaskDamageMyHero(amount);
    }
}
public class BT_728:MinionBase{
//NAME=变装游荡者
//TEXT=<b>亡语：</b>召唤一个9/1的审判官。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=DEMON
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_728t"),ZoneType.Board);
	}
}
public class BT_728t:MinionBase{
//NAME=锈誓审判官
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=9|HP=1|RACE=DEMON
}
public class BT_729:MinionBase{
//NAME=废土守望者
//TEXT=<b>战吼：</b> 对一个随从及所有相同类型的其他随从造成3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BT_730:MinionBase{
//NAME=狂傲的兽人
//TEXT=<b>嘲讽</b> 当有所有生命值时，本随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=6|RACE=NONE
}
public class BT_731:MinionBase{
//NAME=传染孢子
//TEXT=在对随从造成伤害后，将其变为 传染孢子。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class BT_732:MinionBase{
//NAME=食腐破坏魔
//TEXT=<b>战吼：</b>造成6点伤害，随机分配到所有其他随从身上。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=3|RACE=DEMON
}
public class BT_733:MinionBase{
//NAME=莫尔葛工匠
//TEXT=所有随从受到的法术伤害翻倍。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=DEMON
}
public class BT_734:MinionBase{
//NAME=渊狱至尊
//TEXT=无法攻击英雄。
//MAJ=NEUTRAL|COST=8|ATK=12|HP=12|RACE=DEMON
}
public class BT_735:MinionBase{
//NAME=奥
//TEXT=<b>亡语：</b>召唤一个0/3的可以在你的下个回合 复活本随从的“奥的灰烬”。
//MAJ=NEUTRAL|COST=5|ATK=7|HP=3|RACE=ELEMENTAL
}
public class BT_735t:MinionBase{
//NAME=奥的灰烬
//TEXT=在你的回合开始时，变形成为奥。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class BT_737:MinionBase{
//NAME=玛维·影歌
//TEXT=<b>战吼：</b> 选择一个随从。使其<b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class BT_737e:Ability{
//NAME=被禁锢
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_740:SpellBase{
//NAME=灵魂裂劈
//TEXT=<b>吸血</b> 随机对两个敌方随从造成$2点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class BT_752:SpellBase{
//NAME=疾影
//TEXT=在本回合中，你的英雄无法受到伤害。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_752e:Ability{
//NAME=疾影
//TEXT=在本回合中<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_753:SpellBase{
//NAME=法力燃烧
//TEXT=下个回合，你的对手减少两个法力水晶。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=FEL
}
public class BT_753e:Ability{
//NAME=法力烧尽
//TEXT=本回合开始时减少两个法力水晶。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_761:MinionBase{
//NAME=盘牙督军
//TEXT=<b>突袭，亡语：</b>召唤一个5/9并具有<b>嘲讽</b> 的督军。
//MAJ=DEMONHUNTER|COST=8|ATK=9|HP=5|RACE=NAGA
}
public class BT_761t:MinionBase{
//NAME=螺盾督军
//TEXT=<b>嘲讽</b>
//MAJ=DEMONHUNTER|COST=8|ATK=5|HP=9|RACE=NAGA
}
public class BT_781:WeaponBase{
//NAME=埃辛诺斯壁垒
//TEXT=每当你的英雄即将受到伤害，改为埃辛诺斯壁垒失去1点耐久度。
//MAJ=WARRIOR|COST=3|ATK=1|HP=4|RACE=NONE
}
public class BT_801:SpellBase{
//NAME=眼棱
//TEXT=<b>吸血</b>。 对一个随从造成$3点伤害。<b>流放：</b>法力值消耗为（1）点。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class BT_814:MinionBase{
//NAME=伊利达雷邪刃武士
//TEXT=<b>突袭</b> <b>流放：</b>在本回合中获得<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=3|RACE=NONE
}
public class BT_814e:Ability{
//NAME=敏捷
//TEXT=在本回合中<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_850:MinionBase{
//NAME=玛瑟里顿
//TEXT=<b>休眠</b>。 <b>战吼：</b>为你的对手召唤三个1/3的典狱官。当她们死亡时，消灭所有随从并唤醒。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=DEMON
}
public class BT_850e:Ability{
//NAME=被禁锢
//TEXT=<b>休眠</b>。3名典狱官死亡后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BT_850t:MinionBase{
//NAME=地狱火典狱官
//TEXT=<i>（玛瑟里顿会在三名典狱官死亡后消灭所有随从并唤醒。）</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class BT_921:WeaponBase{
//NAME=奥达奇战刃
//TEXT=<b>吸血</b>
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=2|RACE=NONE
}
public class BT_922:WeaponBase{
//NAME=棕红之翼
//TEXT=<b>战吼：</b>召唤两只1/1的邪翼蝠。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=NONE
}
public class BT_922t:MinionBase{
//NAME=邪翼蝠
//TEXT=
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class BT_934:MinionBase{
//NAME=被禁锢的安塔恩
//TEXT=<b>休眠</b>2回合。 唤醒时，造成10点伤害，随机分配到所有敌人身上。
//MAJ=DEMONHUNTER|COST=5|ATK=10|HP=6|RACE=DEMON
}
public class BT_937:MinionBase{
//NAME=流放者奥图里斯
//TEXT=在你使用最左或最右边的一张手牌后，对所有敌人造成1点 伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class BT_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
