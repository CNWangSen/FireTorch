using System.Collections;
using System.Collections.Generic;

public class LOOT_008:SpellBase{
//NAME=心灵尖啸
//TEXT=将所有随从洗入你对手的牌库。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_010e:Ability{
//NAME=暗影力量
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_013:MinionBase{
//NAME=粗俗的矮劣魔
//TEXT=<b>嘲讽，战吼：</b>对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=4|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        TaskDamageMyHero(2);
    }
}
public class LOOT_013_G:MinionBase{
//NAME=粗俗的矮劣魔
//TEXT=<b>嘲讽，战吼：</b>对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=4|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        TaskDamageMyHero(4);
    }
}
public class LOOT_014:MinionBase{
//NAME=狗头人图书管理员
//TEXT=<b>战吼：</b> 抽一张牌。对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=1|ATK=2|HP=1|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDraw();
		TaskDamageMyHero(2);
	}
}
public class LOOT_017:SpellBase{
//NAME=黑暗契约
//TEXT=消灭一个友方随从。为你的英雄恢复#8点生命值。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],8,visualFx:false).Resolve();
    }
}
public class LOOT_018:MinionBase{
//NAME=铁钩掠夺者
//TEXT=<b>战吼：</b>如果你的生命值小于或等于15点，则获得+3/+3和<b>嘲讽</b>。
//MAJ=WARLOCK|COST=4|ATK=4|HP=4|RACE=DEMON
}
public class LOOT_018e:Ability{
//NAME=铁钩恐惧
//TEXT=+3/+3。<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_026:MinionBase{
//NAME=法多雷突袭者
//TEXT=<b>战吼：</b> 将三张伏击牌洗入你的牌库。 当抽到伏击牌时，召唤一只4/4的蜘蛛。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class LOOT_026e:SpellBase{
//NAME=蜘蛛伏击
//TEXT=<b>抽到时施放</b> 召唤一只4/4的 蜘蛛。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_026t:MinionBase{
//NAME=魔网蜘蛛
//TEXT=
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class LOOT_033:MinionBase{
//NAME=洞穴探宝者
//TEXT=<b>战吼：</b>从你的牌库中抽一张武器牌。
//MAJ=ROGUE|COST=2|ATK=3|HP=1|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDrawType(CardType.Weapon);
	}
}
public class LOOT_041:MinionBase{
//NAME=狗头人蛮兵
//TEXT=在你的回合开始时，随机攻击一名敌人。
//MAJ=WARRIOR|COST=3|ATK=4|HP=4|RACE=NONE
}
public class LOOT_043:SpellBase{
//NAME=小型法术紫水晶
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<i>（受到来自你的卡牌的伤害后升级。）</i>
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_043t2:SpellBase{
//NAME=法术紫水晶
//TEXT=<b>吸血</b> 对一个随从造成$5点伤害。<i>（受到来自你的卡牌的伤害后升级。）</i>
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_043t3:SpellBase{
//NAME=大型法术紫水晶
//TEXT=<b>吸血</b> 对一个随从造成$7点伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_044:WeaponBase{
//NAME=铁刃护手
//TEXT=攻击力等同于你的 护甲值。无法攻击英雄。
//MAJ=WARRIOR|COST=2|ATK=0|HP=2|RACE=NONE
}
public class LOOT_047:SpellBase{
//NAME=树皮术
//TEXT=使一个随从 获得+3生命值。 获得3点护甲值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_047e:Ability{
//NAME=树皮术
//TEXT=+3生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_048:MinionBase{
//NAME=铁木魔像
//TEXT=<b>嘲讽</b> 除非你的护甲值大于或等于3点，否则无法进行攻击。
//MAJ=DRUID|COST=4|ATK=3|HP=6|RACE=NONE
}
public class LOOT_051:SpellBase{
//NAME=小型法术玉石
//TEXT=对一个随从造成$2点伤害。<i>（获得3点护甲值后升级。）</i>
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_051t1:SpellBase{
//NAME=法术玉石
//TEXT=对一个随从造成$4点伤害。0
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_051t2:SpellBase{
//NAME=大型法术玉石
//TEXT=对一个随从造成$6点伤害。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_054:SpellBase{
//NAME=分岔路口
//TEXT=<b>选择两次：</b> 抽一张牌；使你的所有随从获得+1攻击力；或者获得6点护甲值。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_054b:SpellBase{
//NAME=探索黑暗
//TEXT=使你的所有随从获得+1攻击力。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_054be:Ability{
//NAME=无所畏惧
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_054c:SpellBase{
//NAME=打开宝箱
//TEXT=获得6点护甲值。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_054d:SpellBase{
//NAME=吃下蘑菇
//TEXT=抽一张牌。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_056:MinionBase{
//NAME=星界猛虎
//TEXT=<b>亡语：</b> 将本随从的一张复制洗入你的牌库。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class LOOT_060:SpellBase{
//NAME=粉碎之手
//TEXT=对一个随从造成$8点伤害。 <b>过载：</b>（3）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOOT_062:MinionBase{
//NAME=狗头人隐士
//TEXT=<b>战吼：</b>选择一个基础图腾并召唤它。
//MAJ=SHAMAN|COST=2|ATK=1|HP=1|RACE=NONE
}
public class LOOT_064:SpellBase{
//NAME=小型法术蓝宝石
//TEXT=选择一个友方随从，召唤一个它的复制。<i>（<b>过载</b>三个法力水晶后升级。）</i>
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_064t1:SpellBase{
//NAME=法术蓝宝石
//TEXT=选择一个友方随从，召唤两个它的复制。0
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_064t2:SpellBase{
//NAME=大型法术蓝宝石
//TEXT=选择一个友方随从，召唤三个它的复制。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_069:MinionBase{
//NAME=下水道爬行者
//TEXT=<b>战吼：</b>召唤一个2/3的巨鼠。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class LOOT_069t:MinionBase{
//NAME=巨鼠
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class LOOT_077:SpellBase{
//NAME=侧翼打击
//TEXT=对一个随从造成$3点伤害。召唤一只3/3的狼。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_077t:MinionBase{
//NAME=狼
//TEXT=
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class LOOT_078:MinionBase{
//NAME=洞穴多头蛇
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class LOOT_079:SecretBase{
//NAME=游荡怪物
//TEXT=<b>奥秘：</b> 当一个敌人攻击你的英雄时，随机召唤一个法力值消耗为（3）的随从，并使其成为攻击的目标。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOOT_080:SpellBase{
//NAME=小型法术翡翠
//TEXT=召唤两只3/3的狼。<i>（使用一个<b>奥秘</b>后升级。）</i>
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_080t2:SpellBase{
//NAME=法术翡翠
//TEXT=召唤三只3/3的狼。<i>（使用一个<b>奥秘</b>后升级。）</i>
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_080t3:SpellBase{
//NAME=大型法术翡翠
//TEXT=召唤四只3/3的狼。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_085:WeaponBase{
//NAME=伦鲁迪洛尔
//TEXT=<b>战吼：</b>如果你的牌库里没有随从牌，则用随机猎人法术牌填满你的手牌。
//MAJ=HUNTER|COST=7|ATK=4|HP=2|RACE=NONE
}
public class LOOT_088:SpellBase{
//NAME=英勇药水
//TEXT=使一个随从获得<b>圣盾</b>。抽 一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_091:SpellBase{
//NAME=小型法术珍珠
//TEXT=召唤一个2/2并具有<b>嘲讽</b>的灵魂。<i>（恢复3点生命值后升级。）</i>
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_091t:MinionBase{
//NAME=守护之魂
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class LOOT_091t1:SpellBase{
//NAME=法术珍珠
//TEXT=召唤一个4/4并具有<b>嘲讽</b>的灵魂。0
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_091t1t:MinionBase{
//NAME=守护之魂
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class LOOT_091t2:SpellBase{
//NAME=大型法术珍珠
//TEXT=召唤一个6/6并具有<b>嘲讽</b>的 灵魂。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_091t2t:MinionBase{
//NAME=守护之魂
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class LOOT_093:SpellBase{
//NAME=战斗号角
//TEXT=<b>招募</b>三个法力值消耗小于或等于（2）点的随从。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListSummon = new List<Card>();
        List<Card> SummonPool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion && c.GetTag(GameTag.Mana)<=2)
            {
                SummonPool.Add(c);
            }
        }
        while(true)
        {
            if(SummonPool.Count==0 || ToListSummon.Count==3)
            {
                break;
            }
            Card ToSummon = SummonPool.Choice(owner.myPlayer.randomGen);
            SummonPool.Remove(ToSummon);
            ToListSummon.Add(ToSummon);
        }
        foreach(Card c in ToListSummon)
        {
            new EffectMove(owner.myPlayer,c,ZoneType.Deck,ZoneType.Board).Resolve();
        }
    }
}
public class LOOT_101:SecretBase{
//NAME=爆炸符文
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$6点伤害，超过其生命值的伤害将由对方英雄 承受。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_609CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_609CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Minion)
        {
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            new EffectDamage(owner.myPlayer,owner, sc, 6).Resolve();
            if(sc.GetTag(GameTag.Health)<0)
                TaskDamageEnemyHero(-sc.GetTag(GameTag.Health));
        }
    }
}
public class LOOT_103:SpellBase{
//NAME=小型法术红宝石
//TEXT=随机将一张法师法术牌置入你的手牌。<i>（使用两张元素牌后升级。）</i>
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class LOOT_103t1:SpellBase{
//NAME=法术红宝石
//TEXT=随机将两张法师法术牌置入你的手牌。0
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class LOOT_103t2:SpellBase{
//NAME=大型法术红宝石
//TEXT=随机将三张法师法术牌置入你的手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class LOOT_104:SpellBase{
//NAME=变形卷轴
//TEXT=如果这张牌在你的手牌中，每个回合都会变成一张随机法师法术牌。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=ARCANE
}
public class LOOT_104e:Ability{
//NAME=变形
//TEXT=变成一张随机法师法术牌。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_106:SpellBase{
//NAME=惊奇套牌
//TEXT=将五张惊奇卡牌洗入你的牌库。抽到时随机施放一个 法术。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class LOOT_106t:SpellBase{
//NAME=惊奇卡牌
//TEXT=<b>抽到时施放</b> 随机施放一个 法术。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LOOT_108:WeaponBase{
//NAME=艾露尼斯
//TEXT=在你的回合结束时，抽三张牌。
//MAJ=MAGE|COST=6|ATK=0|HP=3|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
        {
            TaskDraw();
            TaskDraw();
            TaskDraw();
        }
    }
}
public class LOOT_111:MinionBase{
//NAME=机械异种蝎
//TEXT=<b>战吼：</b> 消灭一个攻击力小于或等于1的随从。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class LOOT_117:MinionBase{
//NAME=蜡油元素
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=ELEMENTAL
}
public class LOOT_118:MinionBase{
//NAME=黑色龙兽铁匠
//TEXT=<b>战吼：</b>随机使你手牌中的一张武器牌的 法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=DRAGON
}
public class LOOT_118e:Ability{
//NAME=锻造
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_122:MinionBase{
//NAME=腐蚀淤泥
//TEXT=<b>战吼：</b> 摧毁对手的武器。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class LOOT_124:MinionBase{
//NAME=孤胆英雄
//TEXT=<b>战吼：</b>如果你没有控制其他随从，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class LOOT_124e:Ability{
//NAME=孤胆
//TEXT=<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_125:MinionBase{
//NAME=石皮蜥蜴
//TEXT=<b>圣盾</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=BEAST
}
public class LOOT_130:MinionBase{
//NAME=奥术统御者
//TEXT=在本回合中，如果你施放过法力值消耗大于或等于（5）的法术，则这张牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=ELEMENTAL
}
public class LOOT_131:MinionBase{
//NAME=绿色凝胶怪
//TEXT=在你的回合结束时，召唤一个1/2并具有<b>嘲讽</b>的软泥怪。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class LOOT_131t1:MinionBase{
//NAME=绿色软泥怪
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class LOOT_132:MinionBase{
//NAME=屠龙者
//TEXT=<b>战吼：</b>对一条龙造成6点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class LOOT_134:MinionBase{
//NAME=利齿宝箱
//TEXT=在你的回合开始时，将本随从的攻击力 变为4。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=4|RACE=NONE
}
public class LOOT_134e:Ability{
//NAME=利齿
//TEXT=攻击力变为4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_136:MinionBase{
//NAME=鬼祟恶魔
//TEXT=<b>潜行</b> 你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=DEMON
}
public class LOOT_136e:Ability{
//NAME=恶魔之力
//TEXT=鬼祟恶魔使本随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_137:MinionBase{
//NAME=贪睡巨龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=9|ATK=6|HP=12|RACE=DRAGON
}
public class LOOT_137_puzzle:MinionBase{
//NAME=贪睡巨龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class LOOT_144:MinionBase{
//NAME=藏宝巨龙
//TEXT=<b>亡语：</b>使你的对手获得两张幸运币。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=DRAGON
}
public class LOOT_149:MinionBase{
//NAME=通道爬行者
//TEXT=当本牌在你的手牌中时，每当一个随从死亡，法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=7|ATK=2|HP=5|RACE=BEAST
}
public class LOOT_149e:Ability{
//NAME=爬行
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_150:MinionBase{
//NAME=缚苔熊怪
//TEXT=<b>战吼：</b>将一个友方随从变形成为一个6/6的元素。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=1|RACE=NONE
}
public class LOOT_150t1:MinionBase{
//NAME=苔藓元素
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=ELEMENTAL
}
public class LOOT_152:MinionBase{
//NAME=喧哗的诗人
//TEXT=<b>战吼：</b>使你的其他随从获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class LOOT_152e:Ability{
//NAME=士气振奋
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_153:MinionBase{
//NAME=紫色岩虫
//TEXT=<b>亡语：</b>召唤七只1/1的肉虫。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=BEAST
}
public class LOOT_153t1:MinionBase{
//NAME=肉虫
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class LOOT_154:MinionBase{
//NAME=砂齿骑兵
//TEXT=<b>战吼：</b>为你的对手随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=3|RACE=NONE
}
public class LOOT_161:MinionBase{
//NAME=食肉魔块
//TEXT=<b>战吼：</b> 消灭一个友方随从。 <b>亡语：</b>召唤两个被消灭随从的复制。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
    private CardDbf Eaten;
    public override void Battlecry(Card target=null)
    {
        this.Eaten=target.cardDbf;
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
    }
    public override void Deathrattle()
    {
        if(this.Eaten!=null)
        {
            TaskCreate(this.Eaten,ZoneType.Board);
            TaskCreate(this.Eaten,ZoneType.Board);
        }
    }
}
public class LOOT_161e:Ability{
//NAME=食肉魔块
//TEXT=消灭{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_165:MinionBase{
//NAME=影舞者索尼娅
//TEXT=在一个友方随从死亡后，将它的1/1复制置入你的手牌，其法力值消耗变为（1）点。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_165e:Ability{
//NAME=索尼娅之影
//TEXT=影舞者索尼娅将这张牌变为了1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_167:MinionBase{
//NAME=菌菇术士
//TEXT=<b>战吼：</b>使相邻的随从获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffTargets(FindAdj(),atk:2,hp:2);
	}
}
public class LOOT_167e:Ability{
//NAME=魔法蘑菇
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_170:MinionBase{
//NAME=乌鸦魔仆
//TEXT=<b>战吼：</b>揭示双方牌库里的一张法术牌。如果你的牌法力值消耗较大，抽这张牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        TaskDrawType(CardType.Spell);
    }
}
public class LOOT_172:SpellBase{
//NAME=巨龙怒火
//TEXT=揭示你牌库中的一张法术牌。对所有随从造成等同于其法力值消耗的伤害。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class LOOT_184:MinionBase{
//NAME=白银先锋
//TEXT=<b>亡语：</b> <b>招募</b>一个法力值消耗为（8）的随从。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=3|RACE=NONE
}
public class LOOT_187:SpellBase{
//NAME=暮光召唤
//TEXT=召唤两个在本局对战中死亡，并具有<b>亡语</b>的友方随从的1/1复制。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_187e:Ability{
//NAME=暗影力量
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_193:MinionBase{
//NAME=闪光的骏马
//TEXT=在你对手的回合<b>扰魔</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class LOOT_203:SpellBase{
//NAME=小型法术秘银石
//TEXT=召唤一个5/5的秘银魔像。 <i>（装备一把武器后升级。）</i>
//MAJ=WARRIOR|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LOOT_203t2:SpellBase{
//NAME=法术秘银石
//TEXT=召唤两个5/5的秘银魔像。 <i>（装备一把武器后升级。）</i>
//MAJ=WARRIOR|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LOOT_203t3:SpellBase{
//NAME=大型法术秘银石
//TEXT=召唤三个5/5的秘银魔像。
//MAJ=WARRIOR|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LOOT_203t4:MinionBase{
//NAME=秘银魔像
//TEXT=
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=NONE
}
public class LOOT_204:SecretBase{
//NAME=诈死
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，将其移回你的手牌，它的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOOT_204e:Ability{
//NAME=侥幸逃脱
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_209:WeaponBase{
//NAME=巨龙之魂
//TEXT=你在一回合中施放三个法术后，召唤一条5/5的龙。
//MAJ=PRIEST|COST=3|ATK=0|HP=3|RACE=NONE
}
public class LOOT_209t:MinionBase{
//NAME=巨龙的灵魂
//TEXT=
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class LOOT_210:SecretBase{
//NAME=叛变
//TEXT=<b>奥秘：</b>当一个随从攻击你的英雄时，改为该随从攻击与其相邻的一个随从。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOOT_211:MinionBase{
//NAME=精灵咏唱者
//TEXT=<b>连击：</b>从你的牌库中抽两张随从牌。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class LOOT_214:SecretBase{
//NAME=闪避
//TEXT=<b>奥秘：</b>你的英雄在受到伤害后，在本回合中<b>免疫</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOOT_214e:Ability{
//NAME=闪避
//TEXT=<b>免疫</b>，直到本回合结束。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_216:MinionBase{
//NAME=莱妮莎·炎伤
//TEXT=<b>战吼：</b>将你在本局对战中对友方随从施放过的所有法术施放在本随从身上。
//MAJ=PALADIN|COST=7|ATK=1|HP=1|RACE=NONE
}
public class LOOT_216e:Ability{
//NAME=大主教之光
//TEXT=对本随从施放法术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_217:SpellBase{
//NAME=来我身边
//TEXT=召唤一个动物伙伴，如果你的牌库里没有随从牌，则召唤两个。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_218:MinionBase{
//NAME=凶猛的聒噪怪
//TEXT=在本随从攻击一方英雄后，将一张它的复制置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class LOOT_222:WeaponBase{
//NAME=蜡烛弓
//TEXT=你的英雄在攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=1|ATK=1|HP=3|RACE=NONE
}
public class LOOT_231:MinionBase{
//NAME=奥术工匠
//TEXT=每当你施放一个法术，便获得等同于其法力值消耗的护甲值。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=ELEMENTAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.cardType==CardType.Spell)
            {
                TaskBuffMyHero(arm:sc.GetTag(GameTag.Mana));
            }
        }
    }
}
public class LOOT_233:MinionBase{
//NAME=被诅咒的门徒
//TEXT=<b>亡语：</b>召唤一个5/1的亡魂。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=1|RACE=NONE
}
public class LOOT_233t:MinionBase{
//NAME=被诅咒的亡魂
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=1|RACE=UNDEAD
}
public class LOOT_258:MinionBase{
//NAME=厄运鼹鼠
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class LOOT_278:SpellBase{
//NAME=未鉴定的药剂
//TEXT=使一个随从获得+2/+2。在你手牌中时获得额外效果。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_278e:Ability{
//NAME=闻起来像……？
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_278t1:SpellBase{
//NAME=生命药剂
//TEXT=使一个随从获得+2/+2和<b>吸血</b>。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_278t1e:Ability{
//NAME=生命之血
//TEXT=+2/+2，<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_278t2:SpellBase{
//NAME=纯净药剂
//TEXT=使一个随从获得+2/+2和<b>圣盾</b>。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_278t2e:Ability{
//NAME=纯净之力
//TEXT=+2/+2，<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_278t3:SpellBase{
//NAME=暗影药剂
//TEXT=使一个随从获得+2/+2，并召唤一个1/1复制。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_278t3e:Ability{
//NAME=暗影之触
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_278t3e2:Ability{
//NAME=暗影力量
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_278t4:SpellBase{
//NAME=希望药剂
//TEXT=使一个随从获得+2/+2，以及 “<b>亡语：</b>将本随从移回你的手牌。”
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_278t4e:Ability{
//NAME=希望之声
//TEXT=+2/+2。<b>亡语：</b>将本随从移回你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285:SpellBase{
//NAME=未鉴定的盾牌
//TEXT=获得5点护甲值。在你手牌中时获得额外效果。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285t:SpellBase{
//NAME=塔盾+10
//TEXT=获得5点护甲值，再获得10点护甲值。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285t2:SpellBase{
//NAME=锯齿盾牌
//TEXT=获得5点护甲值。造成$5点 伤害。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285t3:SpellBase{
//NAME=符文盾牌
//TEXT=获得5点护甲值。召唤一个5/5的魔像。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285t3t:MinionBase{
//NAME=钢铁魔像
//TEXT=
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=NONE
}
public class LOOT_285t4:SpellBase{
//NAME=尖刺盾牌
//TEXT=获得5点护甲值。装备一把5/2的武器。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_285t4t:WeaponBase{
//NAME=尖刺盾牌
//TEXT=
//MAJ=WARRIOR|COST=5|ATK=5|HP=2|RACE=NONE
}
public class LOOT_286:WeaponBase{
//NAME=未鉴定的重槌
//TEXT=在你手牌中时获得额外效果。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_286t1:WeaponBase{
//NAME=勇士重槌
//TEXT=<b>战吼：</b>召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_286t2:WeaponBase{
//NAME=神圣重槌
//TEXT=<b>战吼：</b>使你的所有随从获得<b>嘲讽</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_286t2e:Ability{
//NAME=神圣赐福
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_286t3:WeaponBase{
//NAME=祝福重槌
//TEXT=<b>战吼：</b>使你的所有随从获得+1 攻击力。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_286t3e:Ability{
//NAME=神圣祝福
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_286t4:WeaponBase{
//NAME=净化重槌
//TEXT=<b>战吼：</b>使你的所有随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class LOOT_291:MinionBase{
//NAME=蘑菇酿酒师
//TEXT=<b>战吼：</b> 恢复#4点生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class LOOT_306:MinionBase{
//NAME=着魔男仆
//TEXT=<b>亡语：</b> <b>招募</b>一个恶魔。
//MAJ=WARLOCK|COST=6|ATK=2|HP=2|RACE=NONE
}
public class LOOT_309:SpellBase{
//NAME=橡树的召唤
//TEXT=获得6点护甲值。从你的牌库中召唤一个法力值消耗小于或等于（4）点的随从。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:6);
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion && c.GetTag(GameTag.Mana)<=4)
            {
                Pool.Add(c);
            }
        }
        Card ToSummon = Pool.Choice(owner.myPlayer.randomGen);
        new EffectMove(owner.myPlayer,ToSummon,ZoneType.Deck,ZoneType.Board).Resolve();
    }
}
public class LOOT_313:MinionBase{
//NAME=水晶雄狮
//TEXT=<b>圣盾</b> 你每控制一个白银之手新兵，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=6|ATK=5|HP=5|RACE=NONE
}
public class LOOT_314:MinionBase{
//NAME=灰熊守护者
//TEXT=<b>嘲讽，亡语：</b><b>招募</b>两个法力值消耗小于或等于（4）点的随从。
//MAJ=DRUID|COST=8|ATK=3|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        List<Card> ToListSummon = new List<Card>();
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion && c.GetTag(GameTag.Mana)<=4)
            {
                Pool.Add(c);
            }
        }
        while(true)
        {
            if(ToListSummon.Count>=2 || Pool.Count==0)
            {
                break;
            }
            Card ToSummon = Pool.Choice(owner.myPlayer.randomGen);
            ToListSummon.Add(ToSummon);
            Pool.Remove(ToSummon);
        }
        foreach(Card c in ToListSummon)
        {
            new EffectMove(owner.myPlayer,c,ZoneType.Deck,ZoneType.Board).Resolve();
        }
    }
}
public class LOOT_315:MinionBase{
//NAME=穴居人食菌者
//TEXT=<b>嘲讽</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=5|ATK=1|HP=5|RACE=NONE
}
public class LOOT_329:MinionBase{
//NAME=伊克斯里德，真菌之王
//TEXT=在你使用一张随从牌后，召唤一个它的复制。
//MAJ=DRUID|COST=5|ATK=2|HP=4|RACE=NONE
}
public class LOOT_333:SpellBase{
//NAME=等级提升
//TEXT=使你的白银之手新兵获得+2/+2和<b>嘲讽</b>。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> SliverHands = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
            {
                SliverHands.Add(c);
            }
        }
        TaskBuffTargets(SliverHands,atk:2,hp:2);
        foreach(Card c in SliverHands)
        {
            new EffectGiveAbility(owner.myPlayer,owner,c,"Taunt").Resolve();
        }
    }
}
public class LOOT_333e:Ability{
//NAME=等级+1
//TEXT=+2/+2并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_344:SpellBase{
//NAME=原始护身符
//TEXT=使你的所有随从获得 “<b>亡语：</b>随机召唤一个基础图腾。”
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LOOT_344e:Ability{
//NAME=原始护身符
//TEXT=<b>亡语：</b>随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_347:MinionBase{
//NAME=狗头人学徒
//TEXT=<b>战吼：</b>造成3点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=NONE
}
public class LOOT_351:MinionBase{
//NAME=贪婪的林精
//TEXT=<b>亡语：</b>获得一个空的法力水晶。
//MAJ=DRUID|COST=3|ATK=3|HP=1|RACE=NONE
}
public class LOOT_353:SpellBase{
//NAME=灵能窥探
//TEXT=复制你对手的牌库中的一张法术牌，并将其置入你的 手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_357:MinionBase{
//NAME=“老狐狸”马林
//TEXT=<b>战吼：</b>为你的对手召唤一个0/8的宝箱。<i>（打破宝箱可以获得惊人的战利品！）</i>
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
}
public class LOOT_357l:MinionBase{
//NAME=大师宝箱
//TEXT=<b>亡语：</b>使你的对手获得一张神奇宝藏！
//MAJ=NEUTRAL|COST=3|ATK=0|HP=8|RACE=NONE
}
public class LOOT_358:MinionBase{
//NAME=撼世者格朗勃尔
//TEXT=<b>战吼：</b> 将你的其他随从移回你的手牌，并使其法力值消耗变为（1）点。
//MAJ=SHAMAN|COST=6|ATK=7|HP=7|RACE=ELEMENTAL
}
public class LOOT_358e:Ability{
//NAME=格朗勃尔之力
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_363:MinionBase{
//NAME=旱谷狱卒
//TEXT=<b>亡语：</b> 将三张“白银之手新兵”置入你的手牌。
//MAJ=PALADIN|COST=2|ATK=1|HP=1|RACE=NONE
}
public class LOOT_364:SpellBase{
//NAME=鲁莽风暴
//TEXT=消耗你所有的护甲值。对所有随从造成等同于所消耗护甲值数量的伤害。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LOOT_365:MinionBase{
//NAME=宝石魔像
//TEXT=<b>嘲讽</b> 除非你的护甲值大于或等于5点，否则无法进行攻击。
//MAJ=WARRIOR|COST=6|ATK=5|HP=9|RACE=NONE
}
public class LOOT_367:MinionBase{
//NAME=枯须铸甲师
//TEXT=<b>战吼：</b> 每有一个敌方随从，便获得2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class LOOT_368:MinionBase{
//NAME=虚空领主
//TEXT=<b>嘲讽，亡语：</b> 召唤三个1/3并具有<b>嘲讽</b>的恶魔。
//MAJ=WARLOCK|COST=9|ATK=3|HP=9|RACE=DEMON
}
public class LOOT_370:SpellBase{
//NAME=寻求组队
//TEXT=<b>招募</b>一个随从。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOOT_373:SpellBase{
//NAME=治疗之雨
//TEXT=恢复#12点生命值，随机分配到所有友方角色上。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_375:MinionBase{
//NAME=公会招募员
//TEXT=<b>战吼：</b><b>招募</b>一个法力值消耗小于或等于（4）点的随从。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=4|RACE=NONE
}
public class LOOT_380:WeaponBase{
//NAME=灾厄斩杀者
//TEXT=在你的英雄攻击后，<b>招募</b>一个 随从。
//MAJ=WARRIOR|COST=8|ATK=3|HP=3|RACE=NONE
}
public class LOOT_382:MinionBase{
//NAME=狗头人武僧
//TEXT=你的英雄拥有<b>扰魔</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class LOOT_383:MinionBase{
//NAME=饥饿的双头怪
//TEXT=<b>嘲讽，战吼：</b> 为你的对手随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=10|RACE=NONE
}
public class LOOT_388:MinionBase{
//NAME=菌菇附魔师
//TEXT=<b>战吼：</b>为所有友方角色恢复#2点生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class LOOT_389:MinionBase{
//NAME=狗头人拾荒者
//TEXT=<b>战吼：</b>将你的一把被摧毁的武器置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
}
public class LOOT_392:WeaponBase{
//NAME=世界之树的嫩枝
//TEXT=<b>亡语：</b>复原你的法力水晶。
//MAJ=DRUID|COST=4|ATK=1|HP=5|RACE=NONE
}
public class LOOT_394:MinionBase{
//NAME=闪光的蘑菇
//TEXT=在你的回合结束时，随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=2|RACE=NONE
}
public class LOOT_398:MinionBase{
//NAME=和蔼的灯神
//TEXT=在你的回合结束时，为你的英雄恢复#3点生命值。
//MAJ=PALADIN|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class LOOT_410:MinionBase{
//NAME=破晓之龙
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，则对所有其他随从造成3点伤害。
//MAJ=PRIEST|COST=4|ATK=3|HP=3|RACE=DRAGON
}
public class LOOT_412:MinionBase{
//NAME=狗头人幻术师
//TEXT=<b>亡语：</b>从你的手牌中召唤一个随从的 1/1复制。
//MAJ=ROGUE|COST=5|ATK=3|HP=3|RACE=NONE
    public override void Deathrattle()
    {
        Card ToSummon = owner.myPlayer.hand.Choice(owner.myPlayer.randomGen);
        if(ToSummon!=null)
        {
            CardDbf Small = ToSummon.cardDbf;
            Small.Attack=1;
            Small.MaxHealth=1;
            TaskCreate(Small,ZoneType.Board);
        }
    }
}
public class LOOT_412e:Ability{
//NAME=暗影力量
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_413:MinionBase{
//NAME=硬壳甲虫
//TEXT=<b>亡语：</b> 获得3点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class LOOT_414:MinionBase{
//NAME=资深档案管理员
//TEXT=在你的回合结束时，从你的牌库中施放一张法术牌<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=7|RACE=NONE
}
public class LOOT_415:MinionBase{
//NAME=首席门徒林恩
//TEXT=<b>嘲讽，亡语：</b> 将“第一封印”置入你的手牌。
//MAJ=WARLOCK|COST=6|ATK=3|HP=6|RACE=NONE
}
public class LOOT_415t1:SpellBase{
//NAME=第一封印
//TEXT=召唤一个2/2的恶魔。将“第二封印”置入你的手牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_415t1t:MinionBase{
//NAME=地狱猎犬
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class LOOT_415t2:SpellBase{
//NAME=第二封印
//TEXT=召唤一个3/3的恶魔。将“第三封印”置入你的手牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_415t2t:MinionBase{
//NAME=地狱猎犬
//TEXT=
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class LOOT_415t3:SpellBase{
//NAME=第三封印
//TEXT=召唤一个4/4的恶魔。将“第四封印”置入你的手牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_415t3t:MinionBase{
//NAME=地狱猎犬
//TEXT=
//MAJ=WARLOCK|COST=4|ATK=4|HP=4|RACE=DEMON
}
public class LOOT_415t4:SpellBase{
//NAME=第四封印
//TEXT=召唤一个5/5的恶魔。将“终极封印”置入你的手牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_415t4t:MinionBase{
//NAME=地狱猎犬
//TEXT=
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=DEMON
}
public class LOOT_415t5:SpellBase{
//NAME=终极封印
//TEXT=召唤一个6/6的恶魔。将“吞噬者阿扎里”置入你的手牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOOT_415t5t:MinionBase{
//NAME=地狱猎犬
//TEXT=
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class LOOT_415t6:MinionBase{
//NAME=吞噬者阿扎里
//TEXT=<b>战吼：</b> 摧毁你对手的牌库。
//MAJ=WARLOCK|COST=10|ATK=10|HP=10|RACE=DEMON
}
public class LOOT_417:SpellBase{
//NAME=大灾变
//TEXT=消灭所有随从。弃两张牌。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        for(int i=0;i<2;i++)
        {
            if(owner.myPlayer.hand.Count>0)
            {
                TaskRandomDiscard();
            }
        }
        new EffectDestroy(owner.myPlayer,owner,targets:owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board)).Resolve();

    }
}
public class LOOT_420:WeaponBase{
//NAME=堕落者之颅
//TEXT=在你的回合开始时，从你的手牌中召唤一个 恶魔。
//MAJ=WARLOCK|COST=5|ATK=0|HP=3|RACE=NONE
}
public class LOOT_440e:Ability{
//NAME=爆炸效果
//TEXT=ON FIRE!!!!
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_500:WeaponBase{
//NAME=瓦兰奈尔
//TEXT=<b>亡语：</b>使你手牌中的一张随从牌获得+4/+2。当该随从死亡时，重新装备这把武器。
//MAJ=PALADIN|COST=6|ATK=4|HP=2|RACE=NONE
}
public class LOOT_500d:WeaponBase{
//NAME=Val'anyr Reequip Effect Dummy
//TEXT=It is a dummy card for holding a effect to play when reequipping Val'anyr (LOOT 500)
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_500e:Ability{
//NAME=装备瓦兰奈尔
//TEXT=+4/+2。<b>亡语：</b>装备一把4/2的瓦兰奈尔。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_503:SpellBase{
//NAME=小型法术黑曜石
//TEXT=随机消灭一个敌方随从。<i>（使用三张<b>亡语</b>牌后升级。）</i>
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=SHADOW
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
    }
    private int CntUpgrade = 0;
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.HasAbility("Deathrattle"))
        {
            this.CntUpgrade+=1;
            if(this.CntUpgrade==3)
            {
                this.UnRegisterEventEffect();
                new EffectMorph(owner.myPlayer,owner,owner,CardDbf.GetCardDbfByGuid("LOOT_503t")).Resolve();
            }
        }
    }
}
public class LOOT_503t:SpellBase{
//NAME=法术黑曜石
//TEXT=随机消灭两个敌方随从。0
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=SHADOW
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
        TaskDestroyRandomEnemyMinion();
    }
    private int CntUpgrade = 0;
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.HasAbility("Deathrattle"))
        {
            this.CntUpgrade+=1;
            if(this.CntUpgrade==3)
            {
                this.UnRegisterEventEffect();
                new EffectMorph(owner.myPlayer,owner,owner,CardDbf.GetCardDbfByGuid("LOOT_503t2")).Resolve();
            }
        }
    }
}
public class LOOT_503t2:SpellBase{
//NAME=大型法术黑曜石
//TEXT=随机消灭三个敌方随从。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
        TaskDestroyRandomEnemyMinion();
        TaskDestroyRandomEnemyMinion();
    }
}
public class LOOT_504:SpellBase{
//NAME=不稳定的异变
//TEXT=<b>回响</b> 将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_504t:SpellBase{
//NAME=不稳定的异变
//TEXT=将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。在本回合可以重复使用。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class LOOT_506:WeaponBase{
//NAME=符文之矛
//TEXT=在你的英雄攻击后，<b>发现</b>一张法术牌，并向随机目标施放。
//MAJ=SHAMAN|COST=8|ATK=3|HP=3|RACE=NONE
}
public class LOOT_507:SpellBase{
//NAME=小型法术钻石
//TEXT=复活两个不同的友方随从。<i>（施放四个法术后升级。）</i>
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_507t:SpellBase{
//NAME=法术钻石
//TEXT=复活三个不同的友方随从。0
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_507t2:SpellBase{
//NAME=大型法术钻石
//TEXT=复活四个不同的友方随从。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class LOOT_511:MinionBase{
//NAME=卡瑟娜·冬灵
//TEXT=<b>战吼，亡语：</b><b>招募</b>一个野兽。
//MAJ=HUNTER|COST=8|ATK=6|HP=6|RACE=NONE
}
public class LOOT_516:MinionBase{
//NAME=蛇发女妖佐拉
//TEXT=<b>战吼：</b>选择一个友方随从。将它的金色复制置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NAGA
}
public class LOOT_517:MinionBase{
//NAME=低语元素
//TEXT=<b>战吼：</b>你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=SHAMAN|COST=2|ATK=1|HP=1|RACE=ELEMENTAL
}
public class LOOT_517e:Ability{
//NAME=低语
//TEXT=你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_517e2:Ability{
//NAME=低语
//TEXT=你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_518:MinionBase{
//NAME=风剪唤风者
//TEXT=<b>战吼：</b>如果你控制全部四种基础图腾，则召唤风领主奥拉基尔。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class LOOT_519:MinionBase{
//NAME=地塑师伊普
//TEXT=在你的回合结束时，随机召唤一个法力值消耗等同于你的护甲值<i>（最高不超过10点）</i>的随从。
//MAJ=WARRIOR|COST=8|ATK=4|HP=8|RACE=NONE
}
public class LOOT_520:MinionBase{
//NAME=渗水的软泥怪
//TEXT=<b>战吼：</b> 随机获得牌库中一个随从的<b>亡语</b>。
//MAJ=HUNTER|COST=6|ATK=5|HP=4|RACE=NONE
}
public class LOOT_520e:Ability{
//NAME=白化变色龙
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_521:MinionBase{
//NAME=欧克哈特大师
//TEXT=<b>战吼：</b> <b>招募</b>攻击力为1，2，3的随从各一个。
//MAJ=NEUTRAL|COST=9|ATK=5|HP=5|RACE=NONE
}
public class LOOT_522:SpellBase{
//NAME=碾压墙
//TEXT=消灭对手场上最左边和最右边的随从。
//MAJ=HUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LOOT_526:MinionBase{
//NAME=黑暗之主
//TEXT=起始<b>休眠</b>状态。 <b>战吼：</b>将三张蜡烛牌洗入对手的牌库。抽到三张蜡烛牌后唤醒本随从。
//MAJ=NEUTRAL|COST=4|ATK=20|HP=20|RACE=NONE
}
public class LOOT_526d:MinionBase{
//NAME=黑暗之主
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=20|HP=20|RACE=NONE
}
public class LOOT_526e:Ability{
//NAME=黑暗静息
//TEXT=<b>休眠</b>。当你的对手抽到3支蜡烛时唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_526et:Ability{
//NAME=黑暗蜡烛侦测
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_526t:SpellBase{
//NAME=黑暗蜡烛
//TEXT=<b>抽到时施放</b> 吹熄一根蜡烛。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LOOT_528:MinionBase{
//NAME=暮光侍僧
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则将本随从的攻击力与另一个随从交换。
//MAJ=PRIEST|COST=3|ATK=2|HP=4|RACE=NONE
}
public class LOOT_528e:Ability{
//NAME=暮光诅咒
//TEXT=攻击力交换。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_529:MinionBase{
//NAME=虚空撕裂者
//TEXT=<b>战吼：</b> 使所有其他随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class LOOT_529e:Ability{
//NAME=虚空转换
//TEXT=攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_534:MinionBase{
//NAME=镀金的石像鬼
//TEXT=<b>亡语：</b>将一张幸运币置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class LOOT_535:MinionBase{
//NAME=巨龙召唤者奥兰纳
//TEXT=<b>战吼：</b>在本局对战中，你每施放过一个法力值消耗大于或等于（5）点的法术，便召唤一个5/5的龙。
//MAJ=MAGE|COST=9|ATK=3|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num = 0;
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.cardType==CardType.Spell && c.GetTag(GameTag.Mana)>=5)
            {
                Num+=1;
            }
        }
        for(int i=0;i<Num;i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("LOOT_535t"),ZoneType.Board);
        }
    }
}
public class LOOT_535t:MinionBase{
//NAME=火龙
//TEXT=
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class LOOT_537:MinionBase{
//NAME=魔网操控者
//TEXT=<b>战吼：</b>如果你的手牌中有你的套牌之外的牌，则这些牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=4|ATK=4|HP=5|RACE=ELEMENTAL
}
public class LOOT_538:MinionBase{
//NAME=坦普卢斯
//TEXT=<b>战吼：</b>在本回合结束后，你的对手连续行动两个回合。然后你行动两个回合。
//MAJ=PRIEST|COST=7|ATK=6|HP=6|RACE=DRAGON
}
public class LOOT_539:MinionBase{
//NAME=恶毒的召唤师
//TEXT=<b>战吼：</b>揭示你牌库中的一张法术牌。随机召唤一个法力值消耗与其相同的随从。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class LOOT_540:MinionBase{
//NAME=驯龙师
//TEXT=在你的回合结束时，<b>招募</b>一条龙。
//MAJ=NEUTRAL|COST=9|ATK=2|HP=4|RACE=NONE
}
public class LOOT_541:MinionBase{
//NAME=托瓦格尔国王
//TEXT=<b>战吼：</b>与你的对手交换牌库。你的对手获得一张“赎金”法术牌，可以将牌库交换回来。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=5|RACE=NONE
}
public class LOOT_541t:SpellBase{
//NAME=国王的赎金
//TEXT=与你的对手交换牌库。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LOOT_542:WeaponBase{
//NAME=弑君
//TEXT=始终保留所有附加效果。<b>亡语：</b>将这把武器洗入你的牌库。
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class LOOT_542e:Ability{
//NAME=弑君洗牌
//TEXT=准备洗入牌库。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOOT_998h:SpellBase{
//NAME=托林的酒杯
//TEXT=抽一张牌。用它的复制填满你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LOOT_998j:SpellBase{
//NAME=扎罗格的王冠
//TEXT=<b>发现</b>一张<b>传说</b>随从牌。召唤两个它的复制。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LOOT_998k:MinionBase{
//NAME=黄金狗头人
//TEXT=<b>嘲讽</b>，<b>战吼：</b>将你的手牌替换成<b>传说</b> 随从。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=NONE
}
public class LOOT_998l:SpellBase{
//NAME=奇迹之杖
//TEXT=抽三张牌，其法力值消耗减为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LOOT_998le:Ability{
//NAME=杖之奇迹
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
