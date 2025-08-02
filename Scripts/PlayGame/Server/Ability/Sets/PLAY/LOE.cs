using System.Collections;
using System.Collections.Generic;

public class LOE_002:SpellBase{
//NAME=老旧的火把
//TEXT=造成$3点伤害。将一张可造成6点伤害的“炽烈的火把”洗入你的牌库。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskCreate(CardDbf.GetCardDbfByGuid("LOE_002t"),ZoneType.Deck);
    }
}
public class LOE_002t:SpellBase{
//NAME=炽烈的火把
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
    }
}
public class LOE_003:MinionBase{
//NAME=虚灵巫师
//TEXT=<b>战吼： 发现</b>一张法术牌。
//MAJ=MAGE|COST=5|ATK=6|HP=4|RACE=NONE
}
public class LOE_006:MinionBase{
//NAME=博物馆馆长
//TEXT=<b>战吼：发现</b>一张<b>亡语</b>牌，其法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=1|HP=2|RACE=NONE
}
public class LOE_007:SpellBase{
//NAME=拉法姆的诅咒
//TEXT=使你的对手获得一张“诅咒”。在对手的回合开始时，如果它在对手的手牌中，则造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class LOE_007t:SpellBase{
//NAME=诅咒
//TEXT=如果这张牌在你的手牌中，在你的回合开始时，你的英雄受到2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class LOE_008:SpellBase{
//NAME=哈卡之眼
//TEXT=攫取你对手的牌库中的一个奥秘，并将其置入战场。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_008H:SpellBase{
//NAME=哈卡之眼
//TEXT=攫取你对手的牌库中的一个奥秘，并将其置入战场。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_009:MinionBase{
//NAME=黑曜石毁灭者
//TEXT=在你的回合结束时，召唤一只1/1并具有<b>嘲讽</b>的甲虫。
//MAJ=WARRIOR|COST=7|ATK=7|HP=7|RACE=NONE
}
public class LOE_009e:Ability{
//NAME=邪恶力量
//TEXT=+4/+4。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_009t:MinionBase{
//NAME=甲虫
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class LOE_010:MinionBase{
//NAME=深渊巨蟒
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class LOE_011:MinionBase{
//NAME=雷诺·杰克逊
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则为你的英雄恢复所有生命值。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(CondDeckUni())
            TaskHealMyHero(tofull:true);
    }
}
public class LOE_012:MinionBase{
//NAME=盗墓匪贼
//TEXT=<b>亡语：</b>获取一张 幸运币。
//MAJ=ROGUE|COST=4|ATK=6|HP=4|RACE=UNDEAD
}
public class LOE_016:MinionBase{
//NAME=顽石元素
//TEXT=在你使用一张具有 <b>战吼</b>的随从牌后，随机对一个敌人造成2点伤害。
//MAJ=SHAMAN|COST=4|ATK=2|HP=6|RACE=ELEMENTAL
}
public class LOE_016t:MinionBase{
//NAME=岩石
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=6|RACE=NONE
}
public class LOE_017:MinionBase{
//NAME=奥达曼守护者
//TEXT=<b>战吼：</b> 将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class LOE_017e:Ability{
//NAME=被注视
//TEXT=属性值变成3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_018:MinionBase{
//NAME=坑道穴居人
//TEXT=每当你<b>过载</b>时，每一个被锁的法力水晶会使其获得+1攻击力。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            new EffectChange(owner.myPlayer,owner,owner,atkChange:owner.myPlayer.GetTag(GameTag.ManaOverLoad)).Resolve();
        }
    }
}
public class LOE_018e:Ability{
//NAME=穴居人不是蠢蛋
//TEXT=攻击力提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_019:MinionBase{
//NAME=石化迅猛龙
//TEXT=<b>战吼：</b>选择一个友方随从，获得其<b>亡语</b>的复制。
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class LOE_019e:Ability{
//NAME=石化迅猛龙
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_019t:SpellBase{
//NAME=黄金猿藏宝图
//TEXT=将“黄金猿”洗入你的牌库。抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOE_019t2:MinionBase{
//NAME=黄金猿
//TEXT=<b>嘲讽</b> <b>战吼：</b>将你的手牌和牌库里的卡牌替换成<b>传说</b>随从。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class LOE_020:MinionBase{
//NAME=大漠沙驼
//TEXT=<b>战吼：</b>从双方的牌库中各将一个法力值消耗为（1）的随从置入战场。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        List<Card> SummonPool1 = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.GetTag(GameTag.Mana)==1 && c.cardType==CardType.Minion)
                SummonPool1.Add(c);
        }
        Card ToSummon1= SummonPool1.Choice(owner.myPlayer.randomGen);
        if(ToSummon1!=null)
        {
            new EffectMove(owner.myPlayer,ToSummon1,ZoneType.Deck,ZoneType.Board).Resolve();
        }
        List<Card> SummonPool2 = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.deck)
        {
            if(c.GetTag(GameTag.Mana)==1 && c.cardType==CardType.Minion)
                SummonPool2.Add(c);
        }
        Card ToSummon2= SummonPool2.Choice(owner.myPlayer.otherPlayer.randomGen);
        if(ToSummon2!=null)
        {
            new EffectMove(owner.myPlayer.otherPlayer,ToSummon2,ZoneType.Deck,ZoneType.Board).Resolve();
        }
    }
}
public class LOE_021:SecretBase{
//NAME=毒镖陷阱
//TEXT=<b>奥秘：</b> 在对方使用英雄技能后，随机对一个敌人造成$5点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LOE_022:MinionBase{
//NAME=凶暴猿猴
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class LOE_023:MinionBase{
//NAME=黑市摊贩
//TEXT=<b>战吼：发现</b>一张 法力值消耗为（1）的卡牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class LOE_024t:MinionBase{
//NAME=滚石
//TEXT=在你的回合结束时，消灭这张牌左侧的 随从。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=4|RACE=NONE
}
public class LOE_026:SpellBase{
//NAME=亡者归来
//TEXT=召唤七个在本局对战中死亡的 鱼人。
//MAJ=PALADIN|COST=10|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListSummon = new List<CardDbf>();
        List<CardDbf> SummonPool = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave.Merge(owner.myPlayer.otherPlayer.grave))
        {
            if(c.cardType==CardType.Minion && c.raceType.Contains(RaceType.Murloc))
                SummonPool.Add(c.cardDbf);
        }
        while(true)
        {
            if(SummonPool.Count==0 || ToListSummon.Count==7)
            {
                break;
            }
            CardDbf ToSummon = SummonPool.Choice(owner.myPlayer.randomGen);
            SummonPool.Remove(ToSummon);
            ToListSummon.Add(ToSummon);
        }
        foreach(CardDbf d in ToListSummon)
        {
            TaskCreate(d,ZoneType.Board);
        }
    }
}
public class LOE_027:SecretBase{
//NAME=审判
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，如果他控制至少三个其他随从，则将其消灭。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class LOE_029:MinionBase{
//NAME=宝石甲虫
//TEXT=<b>战吼：发现</b>一张 法力值消耗为（3）的卡牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class LOE_030e:Ability{
//NAME=镂空的铠甲
//TEXT=复制属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_038:MinionBase{
//NAME=纳迦海巫
//TEXT=你的卡牌法力值消耗为（5）点。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=5|RACE=NAGA
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "LOE_038e";
    }
}
public class LOE_038e:Ability{
//NAME=海巫之术
//TEXT=法力值消耗为（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.PropertyArr[(int)GameTag.Mana]+5;
        }
        return 0;//owner.PropertyArr[(int)tg];
    }
}
public class LOE_039:MinionBase{
//NAME=A3型机械金刚
//TEXT=<b>战吼：</b>如果你控制着其他机械，<b>发现</b>一张机械牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class LOE_046:MinionBase{
//NAME=巨型蟾蜍
//TEXT=<b>亡语：</b>随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class LOE_047:MinionBase{
//NAME=墓穴蜘蛛
//TEXT=<b>战吼： 发现</b>一张野兽牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class LOE_050:MinionBase{
//NAME=骑乘迅猛龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class LOE_051:MinionBase{
//NAME=丛林枭兽
//TEXT=双方玩家拥有 <b>法术伤害+2</b>。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=NONE
}
public class LOE_053:MinionBase{
//NAME=西风灯神
//TEXT=在你对一个其他友方随从施放法术后，将法术效果复制在本随从身上。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=ELEMENTAL
}
public class LOE_061:MinionBase{
//NAME=阿努比萨斯哨兵
//TEXT=<b>亡语：</b>随机使一个友方随从获得+3/+3。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class LOE_061e:Ability{
//NAME=泰坦之力
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_073:MinionBase{
//NAME=石化魔暴龙
//TEXT=<b>战吼：</b> 如果你控制着其他野兽，获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class LOE_073e:Ability{
//NAME=石化
//TEXT=拥有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_076:MinionBase{
//NAME=芬利·莫格顿爵士
//TEXT=<b>战吼：发现</b>一个新的基础英雄技能。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=MURLOC
}
public class LOE_077:MinionBase{
//NAME=布莱恩·铜须
//TEXT=你的<b>战吼</b>会触发 两次。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.cardType==CardType.Minion || sc.cardType==CardType.Weapon || sc.cardType==CardType.Hero)
            {
                new EffectChange(owner.myPlayer,owner,sc).Resolve();
                foreach(Ability abi in sc.abilityList)
                {
                    abi.Battlecry(tc);
                }
            }
        }
    }
}
public class LOE_077e:Ability{
//NAME=铜须战吼
//TEXT=你的<b>战吼</b>会触发 两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_079:MinionBase{
//NAME=伊莉斯·逐星
//TEXT=<b>战吼：</b>将“黄金猿藏宝图”洗入你的牌库。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class LOE_086:MinionBase{
//NAME=召唤石
//TEXT=每当你施放一个法术，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=6|RACE=NONE
}
public class LOE_089:MinionBase{
//NAME=摇摆的俾格米
//TEXT=<b>亡语：</b>召唤三个2/2的俾格米。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=6|RACE=NONE
}
public class LOE_089t:MinionBase{
//NAME=俾格米蛮兵
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class LOE_089t2:MinionBase{
//NAME=俾格米刺客
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class LOE_089t3:MinionBase{
//NAME=俾格米斥候
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class LOE_092:MinionBase{
//NAME=虚灵大盗拉法姆
//TEXT=<b>战吼：发现</b>一张强大的神器牌。
//MAJ=NEUTRAL|COST=9|ATK=7|HP=8|RACE=NONE
}
public class LOE_104:SpellBase{
//NAME=埋葬
//TEXT=选择一个敌方随从。将该随从洗入你的牌库。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LOE_105:SpellBase{
//NAME=探险帽
//TEXT=使一个随从获得+1/+1，以及“<b>亡语：</b>获取一张探险帽”。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_105e:Ability{
//NAME=探险帽
//TEXT=+1/+1。<b>亡语：</b>将一张“探险帽”置入你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_107:MinionBase{
//NAME=诡异的雕像
//TEXT=除非它是战场上唯一的一个随从，否则无法进行攻击。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=7|RACE=NONE
}
public class LOE_110:MinionBase{
//NAME=远古暗影
//TEXT=<b>战吼：</b>将一张“远古诅咒”牌洗入你的牌库。当你抽到该牌，便会受到7点伤害。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=4|RACE=UNDEAD
}
public class LOE_110t:SpellBase{
//NAME=远古诅咒
//TEXT=<b>抽到时施放</b> 你受到7点伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class LOE_111:SpellBase{
//NAME=极恶之咒
//TEXT=对所有随从造成$3点伤害。将该牌洗入你对手的牌库。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LOE_113:SpellBase{
//NAME=鱼人恩典
//TEXT=使你的所有随从获得+2/+2。你每控制一个鱼人，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LOE_113e:Ability{
//NAME=Mrglllraawrrrglrur!
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_115:SpellBase{
//NAME=乌鸦神像
//TEXT=<b>抉择：</b> <b>发现</b>一张随从牌；或者<b>发现</b>一张法术牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_115a:SpellBase{
//NAME=冲破束缚
//TEXT=<b>发现</b>一张随从牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_115b:SpellBase{
//NAME=梦醒时分
//TEXT=<b>发现</b>一张法术牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LOE_116:MinionBase{
//NAME=遗物搜寻者
//TEXT=<b>战吼：</b>如果你拥有六个其他随从，便获得+4/+4。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class LOE_118:WeaponBase{
//NAME=诅咒之刃
//TEXT=你的英雄受到的所有伤害效果翻倍。
//MAJ=WARRIOR|COST=1|ATK=2|HP=3|RACE=NONE
}
public class LOE_118e:Ability{
//NAME=诅咒之刃
//TEXT=你的英雄受到的所有伤害效果翻倍。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LOE_119:MinionBase{
//NAME=活化铠甲
//TEXT=你的英雄每次只会受到1点伤害。
//MAJ=MAGE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class LOE_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
