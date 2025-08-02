using System.Collections;
using System.Collections.Generic;

public class UNG_001:MinionBase{
//NAME=翼手龙宝宝
//TEXT=<b>战吼：</b><b>进化</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class UNG_002:MinionBase{
//NAME=火山龙
//TEXT=<b>战吼：</b> 连续<b>进化</b>两次。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=BEAST
}
public class UNG_004:SpellBase{
//NAME=巨化术
//TEXT=将一个随从的属性值变为7/14。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class UNG_004e:Ability{
//NAME=吼！
//TEXT=属性值变成7/14。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_009:MinionBase{
//NAME=暴掠龙幼崽
//TEXT=<b>战吼：</b>如果你控制至少两个其他随从，便获得<b>进化</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class UNG_010:MinionBase{
//NAME=臃肿的蛇颈龙
//TEXT=<b>嘲讽</b>。<b>亡语：</b>召唤三个1/1的鱼人。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=8|RACE=BEAST
    public override void Init()
    {
        //TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("UNG_201t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}

public class UNG_010_G:MinionBase{
//NAME=臃肿的蛇颈龙
//TEXT=<b>嘲讽</b>。<b>亡语：</b>召唤三个1/1的鱼人。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
        //TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("UNG_201t_G");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class UNG_011:MinionBase{
//NAME=水文学家
//TEXT=<b>战吼：</b><b>发现</b>并施放一个<b>奥秘</b>。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class UNG_015:MinionBase{
//NAME=守日者塔林姆
//TEXT=<b>嘲讽，战吼：</b>将所有其他随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=6|ATK=3|HP=7|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        TaskSetAtkTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),3);
        TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),3);
    }
}
public class UNG_015e:Ability{
//NAME=被注视
//TEXT=属性值变成3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_018:SpellBase{
//NAME=烈焰喷涌
//TEXT=造成$2点伤害。 将一张1/2的元素牌置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class UNG_019:MinionBase{
//NAME=空气元素
//TEXT=<b>扰魔</b>
//MAJ=SHAMAN|COST=1|ATK=3|HP=1|RACE=ELEMENTAL
}
public class UNG_020:MinionBase{
//NAME=秘法学家
//TEXT=<b>战吼：</b>抽一张<b>奥秘</b>牌。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawType(CardType.Secret);
    }
}
public class UNG_021:MinionBase{
//NAME=蒸汽涌动者
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，将一张“烈焰喷涌”置入你的手牌。
//MAJ=MAGE|COST=4|ATK=5|HP=4|RACE=ELEMENTAL
}
public class UNG_022:MinionBase{
//NAME=幻象制造者
//TEXT=<b>战吼：</b>选择一个随从，召唤一个它的1/1复制。
//MAJ=PRIEST|COST=3|ATK=2|HP=3|RACE=NONE
}
public class UNG_022e:Ability{
//NAME=幻象
//TEXT=1/1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_024:SecretBase{
//NAME=法术共鸣
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，将该法术的一张复制置入你的手牌，其法力值消耗变为（0）点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class UNG_025:SpellBase{
//NAME=火山喷发
//TEXT=造成$15点伤害，随机分配到所有随从身上。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class UNG_027:MinionBase{
//NAME=派烙斯
//TEXT=<b>亡语：</b>将本随从移回你的手牌，并变为法力值消耗为（4）点的6/6随从牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class UNG_027t2:MinionBase{
//NAME=派烙斯
//TEXT=<b>亡语：</b>将本随从移回你的手牌，并变为法力值消耗为（8）点的10/10随从牌。
//MAJ=MAGE|COST=4|ATK=6|HP=6|RACE=ELEMENTAL
}
public class UNG_027t4:MinionBase{
//NAME=派烙斯
//TEXT=
//MAJ=MAGE|COST=8|ATK=10|HP=10|RACE=ELEMENTAL
}
public class UNG_028:SpellBase{
//NAME=打开时空之门
//TEXT=<b>任务：</b>施放8个你的套牌之外的 法术。  <b>奖励：</b>时空扭曲。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_028t:SpellBase{
//NAME=时空扭曲
//TEXT=获得一个额外回合。<i>（每场对战限一次）</i>
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class UNG_029:SpellBase{
//NAME=暗影视界
//TEXT=从你的牌库中<b>发现</b>一张法术牌的复制。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class UNG_030:SpellBase{
//NAME=联结治疗
//TEXT=为你的英雄和一个随从恢复#5点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class UNG_032:MinionBase{
//NAME=结晶预言者
//TEXT=<b>亡语：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
    public override void Deathrattle()
    {
        Card ToCopy = owner.myPlayer.otherPlayer.deck.Choice(owner.myPlayer.randomGen);
        if(ToCopy!=null)
            TaskCreate(ToCopy.cardDbf,ZoneType.Hand);
    }
}
public class UNG_034:MinionBase{
//NAME=光照元素
//TEXT=你的法术的法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.cardType==CardType.Spell && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "UNG_034e";
    }
}
public class UNG_034e:Ability{
//NAME=光照元素
//TEXT=法力值消耗减少（1）点。
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
public class UNG_035:MinionBase{
//NAME=好奇的萤根草
//TEXT=<b>战吼：</b>检视三张卡牌。猜中来自你对手套牌中的卡牌，则获取该牌的一张复制。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NONE
}
public class UNG_037:MinionBase{
//NAME=始祖龟执盾者
//TEXT=<b>嘲讽，亡语：</b>随机使一个友方随从获得+1/+1。
//MAJ=PRIEST|COST=3|ATK=2|HP=5|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        Card ToBuff = owner.myPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:1,hpChange:1).Resolve();
        }
    }
}

public class UNG_037_G:MinionBase{
//NAME=始祖龟执盾者
//TEXT=<b>嘲讽，亡语：</b>随机使一个友方随从获得+1/+1。
//MAJ=PRIEST|COST=3|ATK=2|HP=5|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        Card ToBuff = owner.myPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:2,hpChange:2).Resolve();
        }
    }
}

public class UNG_037e:Ability{
//NAME=龟壳护盾
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_047:MinionBase{
//NAME=饥饿的翼手龙
//TEXT=<b>战吼：</b> 消灭一个友方随从，并连续<b>进化</b>两次。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class UNG_049:MinionBase{
//NAME=焦油潜伏者
//TEXT=<b>嘲讽</b> 在你对手的回合拥有+3攻击力。
//MAJ=WARLOCK|COST=5|ATK=1|HP=7|RACE=ELEMENTAL
}
public class UNG_057:SpellBase{
//NAME=刀瓣齐射
//TEXT=将两张可造成2点伤害的“刀瓣”置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class UNG_057t1:SpellBase{
//NAME=刀瓣
//TEXT=造成$2点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class UNG_058:MinionBase{
//NAME=刀瓣鞭笞者
//TEXT=<b>战吼：</b>将一张可造成2点伤害的“刀瓣”置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class UNG_060:SpellBase{
//NAME=拟态豆荚
//TEXT=抽一张牌，然后将一张它的复制置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class UNG_061:WeaponBase{
//NAME=黑曜石碎片
//TEXT=在本局对战中，你每将一张非潜行者的职业牌置入你的手牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class UNG_063:MinionBase{
//NAME=食人草
//TEXT=<b>连击：</b>在本回合中，你每使用一张其他牌，便获得+1/+1。
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NONE
}
public class UNG_063e:Ability{
//NAME=发芽
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_064:MinionBase{
//NAME=邪脊吞噬者
//TEXT=<b>连击：</b> 消灭一个随从。
//MAJ=ROGUE|COST=5|ATK=3|HP=4|RACE=NONE
}
public class UNG_065:MinionBase{
//NAME=“尸魔花”瑟拉金
//TEXT=<b>亡语：</b>进入<b>休眠</b>状态。在一回合中使用4张牌可复活本随从。
//MAJ=ROGUE|COST=4|ATK=6|HP=3|RACE=NONE
}
public class UNG_065t:MinionBase{
//NAME=瑟拉金之种
//TEXT=<b>休眠</b> 在一回合中使用4张牌可复活本随从。
//MAJ=ROGUE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class UNG_067:SpellBase{
//NAME=探索地下洞穴
//TEXT=<b>任务：</b>使用四张名称相同的随从牌。 <b>奖励：</b>水晶核心。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_067t1:SpellBase{
//NAME=水晶核心
//TEXT=在本局对战的剩余时间内，你的所有随从变为5/5。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class UNG_067t1e:Ability{
//NAME=晶化
//TEXT=你的所有随从变为5/5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_067t1e2:Ability{
//NAME=晶化
//TEXT=5/5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_070:MinionBase{
//NAME=托维尔塑石师
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class UNG_070e:Ability{
//NAME=石墙
//TEXT=<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_071:MinionBase{
//NAME=巨型乳齿象
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=9|ATK=6|HP=12|RACE=BEAST
}
public class UNG_072:MinionBase{
//NAME=石丘防御者
//TEXT=<b>嘲讽，战吼：</b> <b>发现</b>一张具有<b>嘲讽</b>的随从牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class UNG_073:MinionBase{
//NAME=石塘猎人
//TEXT=<b>战吼：</b>使一个友方鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class UNG_073e:Ability{
//NAME=训练有素
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_075:MinionBase{
//NAME=凶恶的翼龙
//TEXT=在本随从攻击英雄后，<b>进化</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class UNG_076:MinionBase{
//NAME=卑劣的窃蛋者
//TEXT=<b>亡语：</b>召唤两个1/1的迅猛龙。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class UNG_076t1:MinionBase{
//NAME=迅猛龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class UNG_078:MinionBase{
//NAME=始祖龟劫掠者
//TEXT=<b>战吼：</b>随机将一张攻击力大于或等于5的随从牌置入你的手牌。
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=NONE
}
public class UNG_079:MinionBase{
//NAME=冰冻粉碎者
//TEXT=在本随从攻击后，<b>冻结</b>本随从。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=ELEMENTAL
}
public class UNG_082:MinionBase{
//NAME=雷霆蜥蜴
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则获得<b>进化</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class UNG_083:MinionBase{
//NAME=魔暴龙蛋
//TEXT=<b>亡语：</b>召唤一个5/5的魔暴龙。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=3|RACE=NONE
}
public class UNG_083t1:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class UNG_084:MinionBase{
//NAME=火羽凤凰
//TEXT=<b>战吼：</b>造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=ELEMENTAL
}
public class UNG_085:MinionBase{
//NAME=翡翠蜂后
//TEXT=你的随从的法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=BEAST
}
public class UNG_085e:Ability{
//NAME=翡翠蜂巢
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_086:MinionBase{
//NAME=巨型蟒蛇
//TEXT=<b>嘲讽</b>。<b>亡语：</b>从你手牌中召唤一个攻击力大于或等于5的随从。
//MAJ=DRUID|COST=7|ATK=5|HP=3|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.cardType==CardType.Minion && c.GetTag(GameTag.Attack)>=5)
            {
                Pool.Add(c);
            }
        }
        Card ToSummon = Pool.Choice();
        if(ToSummon!=null)
        {
            new EffectMove(owner.myPlayer,ToSummon,ZoneType.Hand,ZoneType.Board).Resolve();
        }
    }
}
public class UNG_087:MinionBase{
//NAME=苦潮多头蛇
//TEXT=每当本随从受到伤害，对你的英雄造成 3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class UNG_088:MinionBase{
//NAME=始祖龟预言者
//TEXT=<b>战吼：</b> <b>发现</b>一张法术牌，并向随机目标施放。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=5|RACE=NONE
}
public class UNG_089:MinionBase{
//NAME=温顺的巨壳龙
//TEXT=<b>战吼：</b><b>进化</b>你所有的鱼人。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
}
public class UNG_099:MinionBase{
//NAME=狂奔的魔暴龙
//TEXT=<b>冲锋，战吼：</b>在本回合中无法攻击英雄。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,owner,"CantAttackHeroForOneTurn").Resolve();
    }
}
public class UNG_100:MinionBase{
//NAME=苍绿长颈龙
//TEXT=<b>战吼：</b><b>进化</b>。
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class UNG_101:MinionBase{
//NAME=变形神龟
//TEXT=<b>抉择：</b>变形成为5/3并具有<b>潜行</b>；或者变形成为3/5并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=4|ATK=3|HP=3|RACE=NONE
}
public class UNG_101a:MinionBase{
//NAME=迅猛龙形态
//TEXT=<b>潜行</b>
//MAJ=DRUID|COST=4|ATK=5|HP=3|RACE=BEAST
}
public class UNG_101b:MinionBase{
//NAME=恐角龙形态
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class UNG_101t:MinionBase{
//NAME=变形神龟
//TEXT=<b>潜行</b>
//MAJ=DRUID|COST=4|ATK=5|HP=3|RACE=BEAST
}
public class UNG_101t2:MinionBase{
//NAME=变形神龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class UNG_101t3:MinionBase{
//NAME=变形神龟
//TEXT=<b>潜行</b> <b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=5|HP=5|RACE=BEAST
}
public class UNG_103:SpellBase{
//NAME=生长孢子
//TEXT=<b>进化</b>你所有的随从。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class UNG_108:SpellBase{
//NAME=大地之鳞
//TEXT=使一个友方随从获得+1/+1，然后获得等同于其攻击力的 护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class UNG_108e:Ability{
//NAME=坚韧鳞甲
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_109:MinionBase{
//NAME=年迈的长颈龙
//TEXT=<b>战吼：</b> 如果你的手牌中有攻击力大于或等于5的随从牌，便获得<b>进化</b>。
//MAJ=DRUID|COST=3|ATK=5|HP=1|RACE=BEAST
}
public class UNG_111:SpellBase{
//NAME=活体法力
//TEXT=将你所有的法力水晶变成2/2的树人，当它们死亡时恢复你的法力值。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class UNG_111t1:MinionBase{
//NAME=法力树人
//TEXT=<b>亡语：</b>获得一个空的法力水晶。
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class UNG_113:MinionBase{
//NAME=热情的探险家
//TEXT=<b>战吼：</b>抽一张牌，使其法力值消耗变为（5）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card c1 = TaskDraw();
        if(c1!=null)
        {
            int m1 = c1.GetTag(GameTag.Mana);
            new EffectChange(owner.myPlayer,owner,c1,manaChange:-m1+5).Resolve();
        }
    }
}
public class UNG_113e:Ability{
//NAME=探险所得
//TEXT=法力值消耗为（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_116:SpellBase{
//NAME=丛林巨兽
//TEXT=<b>任务：</b>召唤4个攻击力大于或等于5的随从。 <b>奖励：</b>班纳布斯。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_116t:MinionBase{
//NAME=“践踏者”班纳布斯
//TEXT=<b>战吼：</b>使你牌库中所有随从的法力值消耗减为（0）点。
//MAJ=DRUID|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class UNG_116te:Ability{
//NAME=横冲直撞
//TEXT=法力值消耗为（0）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_201:MinionBase{
//NAME=蛮鱼图腾
//TEXT=在你的回合结束时，召唤一个1/1的鱼人。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskCreate(CardDbf.GetCardDbfByGuid("UNG_201t"),ZoneType.Board);
    }
}
public class UNG_201t:MinionBase{
//NAME=蛮鱼战士
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class UNG_202:MinionBase{
//NAME=火羽先锋
//TEXT=<b>战吼：</b>使你手牌中所有元素牌的法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=2|ATK=1|HP=1|RACE=ELEMENTAL
}
public class UNG_202e:Ability{
//NAME=炽燃
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_205:MinionBase{
//NAME=冰川裂片
//TEXT=<b>战吼：</b> <b>冻结</b>一个敌人。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class UNG_208:MinionBase{
//NAME=岩石哨兵
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则召唤两个2/3并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=5|ATK=4|HP=4|RACE=ELEMENTAL
}
public class UNG_208t:MinionBase{
//NAME=岩元素
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class UNG_211:MinionBase{
//NAME=荒蛮之主卡利莫斯
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则施放一个元素祈咒。
//MAJ=SHAMAN|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class UNG_211a:SpellBase{
//NAME=土之祈咒
//TEXT=用1/1的元素填满你的面板
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_211aa:MinionBase{
//NAME=石元素
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class UNG_211b:SpellBase{
//NAME=水之祈咒
//TEXT=为你的英雄恢复12点生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_211c:SpellBase{
//NAME=火之祈咒
//TEXT=对敌方英雄造成6点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_211d:SpellBase{
//NAME=气之祈咒
//TEXT=对所有敌方随从造成3点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_800:MinionBase{
//NAME=恐鳞追猎者
//TEXT=<b>战吼：</b>触发一个友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class UNG_801:MinionBase{
//NAME=筑巢双头鹏
//TEXT=<b>战吼：</b>如果你控制至少两个其他随从，便获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=7|RACE=BEAST
}
public class UNG_803:MinionBase{
//NAME=翡翠掠夺者
//TEXT=<b>战吼：</b>对每个英雄造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class UNG_806:MinionBase{
//NAME=摩天龙
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=7|HP=14|RACE=BEAST
}
public class UNG_807:MinionBase{
//NAME=葛拉卡爬行蟹
//TEXT=<b>战吼：</b>消灭一个海盗，并获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class UNG_807e:Ability{
//NAME=大腹便便
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_808:MinionBase{
//NAME=倔强的蜗牛
//TEXT=<b>嘲讽</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class UNG_809:MinionBase{
//NAME=火羽精灵
//TEXT=<b>战吼：</b>将一张1/2的元素牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
    public override void Battlecry(Card target =null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("UNG_809t1"),ZoneType.Hand);
    }
}
public class UNG_809t1:MinionBase{
//NAME=烈焰元素
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
}
public class UNG_810:MinionBase{
//NAME=剑龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=BEAST
}
public class UNG_812:MinionBase{
//NAME=剑齿追猎者
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=6|ATK=8|HP=2|RACE=BEAST
}
public class UNG_813:MinionBase{
//NAME=风暴看守
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=7|ATK=4|HP=8|RACE=ELEMENTAL
}
public class UNG_814:MinionBase{
//NAME=巨型黄蜂
//TEXT=<b>潜行</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class UNG_816:MinionBase{
//NAME=卡利莫斯的仆从
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则<b>发现</b>一张元素牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class UNG_817:SpellBase{
//NAME=海潮涌动
//TEXT=<b>吸血</b> 对一个随从造成$5点伤害。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class UNG_818:MinionBase{
//NAME=不稳定的元素
//TEXT=<b>亡语：</b>随机对一个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=ELEMENTAL
}
public class UNG_823:SpellBase{
//NAME=浸毒武器
//TEXT=使你的武器获得<b>剧毒</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class UNG_823e:Ability{
//NAME=浸毒
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_823ed:Ability{
//NAME=浸毒
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_829:SpellBase{
//NAME=拉卡利献祭
//TEXT=<b>任务：</b>弃掉六张牌。 <b>奖励：</b>虚空传送门。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_829t1:SpellBase{
//NAME=虚空传送门
//TEXT=打开一座会永久召唤3/2小鬼的传送门。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class UNG_829t2:MinionBase{
//NAME=虚空传送门
//TEXT=在你的回合结束时，召唤两个3/2的小鬼。
//MAJ=WARLOCK|COST=11|ATK=0|HP=1|RACE=NONE
}
public class UNG_829t3:MinionBase{
//NAME=虚空小鬼
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class UNG_830:MinionBase{
//NAME=残暴的恐龙统领
//TEXT=<b>亡语：</b>随机召唤一个你在本局对战中弃掉的随从。
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=NONE
}
public class UNG_831:SpellBase{
//NAME=腐化迷雾
//TEXT=诅咒所有随从，在你的下个回合开始时将其消灭。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class UNG_831e:Ability{
//NAME=腐化迷雾
//TEXT=在施放腐化迷雾的玩家的回合开始时，消灭本随从。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_832:SpellBase{
//NAME=血色绽放
//TEXT=在本回合中，你施放的下一个法术不再消耗法力值，转而消耗生命值。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class UNG_832e:Ability{
//NAME=黑暗力量
//TEXT=你的下一个法术消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_833:MinionBase{
//NAME=拉卡利地狱犬
//TEXT=<b>嘲讽</b>，<b>战吼：</b>弃掉你手牌中法力值消耗最低的两张牌。
//MAJ=WARLOCK|COST=4|ATK=3|HP=8|RACE=DEMON
}
public class UNG_834:SpellBase{
//NAME=喂食时间
//TEXT=对一个随从造成$3点伤害。召唤三只1/1的翼手龙并使其<b>进化</b>。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class UNG_834t1:MinionBase{
//NAME=翼手龙
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class UNG_835:MinionBase{
//NAME=聒噪的挖掘者
//TEXT=<b>战吼：</b> <b>发现</b>一张法术牌。对你的英雄造成等同于其法力值消耗的伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class UNG_836:MinionBase{
//NAME=萨瓦丝女王
//TEXT=每当你弃掉这张牌时，使其获得+2/+2，并将其移回你的手牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class UNG_836e:Ability{
//NAME=历久弥新
//TEXT=每次被弃时获得+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_838:MinionBase{
//NAME=焦油兽王
//TEXT=<b>嘲讽</b> 在你对手的回合拥有+4攻击力。
//MAJ=WARRIOR|COST=6|ATK=1|HP=11|RACE=ELEMENTAL
}
public class UNG_840:MinionBase{
//NAME=“丛林猎人”赫米特
//TEXT=<b>战吼：</b> 摧毁你牌库中所有法力值消耗小于或等于（3）点的卡牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class UNG_843:MinionBase{
//NAME=沃拉斯
//TEXT=在你对本随从施放一个法术后，召唤一个1/1的植物，并对其施放相同的法术。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class UNG_844:MinionBase{
//NAME=巨齿刀叶
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=8|RACE=NONE
}
public class UNG_845:MinionBase{
//NAME=火岩元素
//TEXT=<b>亡语：</b>将两张1/2的烈焰元素置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class UNG_846:MinionBase{
//NAME=活体风暴
//TEXT=<b>战吼：</b>随机将一张法师法术牌置入你的 手牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class UNG_847:MinionBase{
//NAME=火焰使者
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则造成5点伤害。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=ELEMENTAL
}
public class UNG_848:MinionBase{
//NAME=始生幼龙
//TEXT=<b>嘲讽，战吼：</b> 对所有其他随从造成2点伤害。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=8|RACE=DRAGON
}
public class UNG_851:MinionBase{
//NAME=“开拓者”伊莉斯
//TEXT=<b>战吼：</b> 将一张<b>安戈洛</b>卡牌包洗入你的牌库。如果你的牌库里没有相同的牌，则抽取这张卡牌包。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class UNG_851t1:SpellBase{
//NAME=安戈洛卡牌包
//TEXT=将五张<b>勇闯安戈洛</b>系列的卡牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_852:MinionBase{
//NAME=泰拉图斯
//TEXT=<b>嘲讽</b>。<b>扰魔</b>
//MAJ=DRUID|COST=10|ATK=14|HP=14|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("Elusive");
    }
}
public class UNG_854:SpellBase{
//NAME=琥口脱险
//TEXT=<b>发现</b>一张法力值消耗大于或等于（8）点的随从牌，并召唤该随从。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=NONE
}
public class UNG_856:SpellBase{
//NAME=幻觉
//TEXT=<b>发现</b>一张你对手职业的卡牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class UNG_900:MinionBase{
//NAME=灵魂歌者安布拉
//TEXT=在你召唤一个随从后，触发其<b>亡语</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay() && sz==ZoneType.Hand && tz==ZoneType.Board)
        {
            new EffectChange(owner.myPlayer,owner,sc).Resolve();
            for(int i = sc.abilityList.Count-1;i>=0;i--)
            {
                sc.abilityList[i].Deathrattle();
            }
        }
    }
}
public class UNG_907:MinionBase{
//NAME=欧泽鲁克
//TEXT=<b>嘲讽，战吼：</b>在上个回合，你每使用一张元素牌，便获得+5生命值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
}
public class UNG_907e:Ability{
//NAME=生命之光
//TEXT=+5生命值
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_910:SpellBase{
//NAME=凶残撕咬
//TEXT=对一个随从造成$3点伤害，并对其相邻的随从 造成$1点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_912:MinionBase{
//NAME=宝石鹦鹉
//TEXT=<b>战吼：</b>随机将一张野兽牌置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class UNG_913:MinionBase{
//NAME=托维尔守卫
//TEXT=<b>战吼：</b>从你的牌库中抽两张法力值消耗为（1）的随从牌。
//MAJ=HUNTER|COST=4|ATK=3|HP=4|RACE=NONE
}
public class UNG_914:MinionBase{
//NAME=迅猛龙宝宝
//TEXT=<b>亡语：</b>将一张4/5的“迅猛龙头领”洗入你的 牌库。
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class UNG_914t1:MinionBase{
//NAME=迅猛龙头领
//TEXT=
//MAJ=HUNTER|COST=1|ATK=4|HP=5|RACE=BEAST
}
public class UNG_915:MinionBase{
//NAME=雷鸣刺喉龙
//TEXT=<b>战吼：</b><b>进化</b>一个友方野兽。
//MAJ=HUNTER|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class UNG_916:SpellBase{
//NAME=奔踏
//TEXT=在本回合中，每当你使用一张野兽牌，随机将一张野兽牌置入你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_916e:Ability{
//NAME=奔踏
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_917:SpellBase{
//NAME=恐龙学
//TEXT=将你的英雄技能替换为“使一只野兽获得+3/+3”。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_917e:Ability{
//NAME=进食充分
//TEXT=+3/+3。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_917t1:HeroPowerBase{
//NAME=恐龙学
//TEXT=使一只野兽获得+3/+3。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_919:MinionBase{
//NAME=沼泽之王爵德
//TEXT=在你的对手使用一张随从牌后，攻击该随从。
//MAJ=HUNTER|COST=6|ATK=9|HP=9|RACE=BEAST
}
public class UNG_920:SpellBase{
//NAME=湿地女王
//TEXT=<b>任务：</b>使用七张法力值消耗为（1）的随从牌。 <b>奖励：</b>卡纳莎女王。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_920t1:MinionBase{
//NAME=卡纳莎女王
//TEXT=<b>突袭</b>。<b>战吼：</b>将20张迅猛龙牌洗入你的牌库。
//MAJ=HUNTER|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class UNG_920t2:MinionBase{
//NAME=卡纳莎的族群
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=HUNTER|COST=1|ATK=3|HP=2|RACE=BEAST
}
public class UNG_922:SpellBase{
//NAME=探索安戈洛
//TEXT=将你牌库里的所有卡牌替换成 “<b>发现</b>一张牌”。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_922t1:SpellBase{
//NAME=选择道路
//TEXT=<b>发现</b>一张牌。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_923:SpellBase{
//NAME=铜皮铁甲
//TEXT=获得5点护甲值。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_925:MinionBase{
//NAME=暴躁的恐角龙
//TEXT=<b>嘲讽，战吼：</b><b>进化</b>。
//MAJ=WARRIOR|COST=6|ATK=6|HP=6|RACE=BEAST
}
public class UNG_926:MinionBase{
//NAME=身陷绝境的哨卫
//TEXT=<b>嘲讽，战吼：</b> 为你的对手召唤三只1/1的迅猛龙。
//MAJ=WARRIOR|COST=2|ATK=2|HP=6|RACE=NONE
}
public class UNG_927:SpellBase{
//NAME=基因转接
//TEXT=复制所有受伤的友方随从。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToClone = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.GetTag(GameTag.Damage)>0)
            {
                ToClone.Add(c);
            }
        }
        foreach(Card c in ToClone)
        {
            new EffectCreate(owner.myPlayer,c.GetClone(owner.myPlayer,true),ZoneType.Board).Resolve();
        }
    }
}
public class UNG_928:MinionBase{
//NAME=焦油爬行者
//TEXT=<b>嘲讽</b> 在你对手的回合拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=ELEMENTAL
}
public class UNG_929:WeaponBase{
//NAME=熔岩之刃
//TEXT=如果这张牌在你的手牌中，每个回合都会变成一张新的武器牌。
//MAJ=WARRIOR|COST=1|ATK=1|HP=1|RACE=NONE
}
public class UNG_929e:Ability{
//NAME=熔岩形态
//TEXT=随机变成一张武器牌。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_933:MinionBase{
//NAME=暴龙之王摩什
//TEXT=<b>战吼：</b>消灭所有受伤的随从。
//MAJ=WARRIOR|COST=7|ATK=9|HP=7|RACE=BEAST
}
public class UNG_934:SpellBase{
//NAME=火羽之心
//TEXT=<b>任务：</b>使用七张具有<b>嘲讽</b>的随从牌。 <b>奖励：</b>萨弗拉斯。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_934t1:WeaponBase{
//NAME=萨弗拉斯
//TEXT=<b>战吼：</b>你的英雄技能变为“随机对一个敌人造成8点伤害”。
//MAJ=WARRIOR|COST=3|ATK=4|HP=2|RACE=NONE
}
public class UNG_934t2:HeroPowerBase{
//NAME=死吧，虫子！
//TEXT=随机对一个敌人造成$8点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class UNG_937:MinionBase{
//NAME=蛮鱼斥候
//TEXT=<b>战吼：</b>如果你控制着其他鱼人，<b>发现</b>一张鱼人牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class UNG_938:MinionBase{
//NAME=温泉守卫
//TEXT=<b>嘲讽，战吼：</b> 恢复#3点生命值。
//MAJ=SHAMAN|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class UNG_940:SpellBase{
//NAME=唤醒造物者
//TEXT=<b>任务：</b>召唤6个<b>亡语</b>随从。<b>奖励：</b>希望守护者阿玛拉。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_940t8:MinionBase{
//NAME=希望守护者阿玛拉
//TEXT=<b>嘲讽，战吼：</b> 将你英雄的生命值变为40。
//MAJ=PRIEST|COST=5|ATK=8|HP=8|RACE=NONE
}
public class UNG_940t8e:Ability{
//NAME=希望守护
//TEXT=生命值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_941:SpellBase{
//NAME=远古雕文
//TEXT=<b>发现</b>一张法术牌，使其法力值消耗减少（2）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class UNG_941e:Ability{
//NAME=远古魔法
//TEXT=法力值消耗减少。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_942:SpellBase{
//NAME=鱼人总动员
//TEXT=<b>任务：</b>召唤8个鱼人。 <b>奖励：</b>老鲨嘴。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_942t:MinionBase{
//NAME=老鲨嘴
//TEXT=<b>战吼：</b>用随机鱼人牌填满你的手牌。
//MAJ=SHAMAN|COST=5|ATK=8|HP=8|RACE=MURLOC
}
public class UNG_946:MinionBase{
//NAME=贪食软泥怪
//TEXT=<b>战吼：</b>摧毁对手的武器，并获得等同于其攻击力的护甲值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class UNG_948:SpellBase{
//NAME=熔岩镜像
//TEXT=选择一个友方随从，召唤一个该随从的复制。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class UNG_950:WeaponBase{
//NAME=斩棘刀
//TEXT=在你的英雄攻击后，召唤两个1/1的白银之手 新兵。
//MAJ=PALADIN|COST=6|ATK=4|HP=3|RACE=NONE
}
public class UNG_952:SpellBase{
//NAME=剑龙骑术
//TEXT=使一个随从获得+2/+6和<b>嘲讽</b>。当该随从死亡时，召唤一只剑龙。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class UNG_952e:Ability{
//NAME=骑乘剑龙
//TEXT=+2/+6并具有<b>嘲讽</b>。 <b>亡语：</b>召唤一个剑龙。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_953:MinionBase{
//NAME=蛮鱼勇士
//TEXT=<b>亡语：</b>将你施放在本随从身上的所有法术移回你的手牌。
//MAJ=PALADIN|COST=2|ATK=1|HP=3|RACE=MURLOC
}
public class UNG_953e:Ability{
//NAME=受到鼓舞
//TEXT=存放法术。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_954:SpellBase{
//NAME=最后的水晶龙
//TEXT=<b>任务：</b>对你的随从施放5个法术。 <b>奖励：</b>嘉沃顿。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class UNG_954t1:MinionBase{
//NAME=嘉沃顿
//TEXT=<b>战吼：</b> 连续<b>进化</b>五次。
//MAJ=PALADIN|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class UNG_955:SpellBase{
//NAME=陨石术
//TEXT=对一个随从造成$15点伤害，并对其相邻的随从造成 $4点伤害。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=FIRE
}
public class UNG_956:SpellBase{
//NAME=灵魂回响
//TEXT=使你的所有随从获得“<b>亡语：</b>将本随从移回你的手牌”。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class UNG_956e:Ability{
//NAME=回响之魂
//TEXT=<b>亡语：</b>移回你的手牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_957:MinionBase{
//NAME=恐角龙宝宝
//TEXT=<b>嘲讽</b>。<b>亡语：</b> 将一张8/12并具有<b>嘲讽</b>的“恐角龙头领”洗入你的牌库。
//MAJ=WARRIOR|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class UNG_957t1:MinionBase{
//NAME=恐角龙头领
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=5|ATK=8|HP=12|RACE=BEAST
}
public class UNG_960:SpellBase{
//NAME=迷失丛林
//TEXT=召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("CS2_101t"),owner.myPlayer),ZoneType.Board).Resolve();
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("CS2_101t"),owner.myPlayer),ZoneType.Board).Resolve();    
    }
}
public class UNG_961:SpellBase{
//NAME=适者生存
//TEXT=<b>进化</b>一个友方随从。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_962:MinionBase{
//NAME=光注剑龙
//TEXT=<b>战吼：</b><b>进化</b>你的白银之手新兵。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=BEAST
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
        TaskBuffTargets(SliverHands,atk:3);
    }
}
public class UNG_963:MinionBase{
//NAME=“太阳裂片”莱拉
//TEXT=每当你施放一个法术，随机将一张牧师法术牌置入你的手牌。
//MAJ=PRIEST|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class UNG_999t10:SpellBase{
//NAME=氤氲迷雾
//TEXT=获得<b>潜行</b>直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t10e:Ability{
//NAME=氤氲迷雾
//TEXT=获得潜行直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t13:SpellBase{
//NAME=毒液喷吐
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t13e:Ability{
//NAME=毒液喷吐
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t14:SpellBase{
//NAME=火山之力
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t14e:Ability{
//NAME=火山之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t2:SpellBase{
//NAME=活性孢子
//TEXT=<b>亡语：</b>召唤两个1/1的植物。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t2e:Ability{
//NAME=活性孢子
//TEXT=<b>亡语：</b>召唤两个1/1的植物。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t2t1:MinionBase{
//NAME=植物
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class UNG_999t3:SpellBase{
//NAME=烈焰利爪
//TEXT=+3攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t3e:Ability{
//NAME=烈焰利爪
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t4:SpellBase{
//NAME=岩质甲壳
//TEXT=+3生命值
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t4e:Ability{
//NAME=岩质甲壳
//TEXT=+3生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t5:SpellBase{
//NAME=液态外膜
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t5e:Ability{
//NAME=液态外膜
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t6:SpellBase{
//NAME=巨型体态
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t6e:Ability{
//NAME=巨型体态
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t7:SpellBase{
//NAME=闪电之速
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t7e:Ability{
//NAME=闪电之速
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t8:SpellBase{
//NAME=爆裂护盾
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class UNG_999t8e:Ability{
//NAME=爆裂护盾
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
