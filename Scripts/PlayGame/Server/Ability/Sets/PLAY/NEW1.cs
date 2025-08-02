using System.Collections;
using System.Collections.Generic;

public class NEW1_003:SpellBase{
//NAME=牺牲契约
//TEXT=消灭一个友方恶魔，为你的英雄恢复#5点生命值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class NEW1_004:SpellBase{
//NAME=消失
//TEXT=将所有随从移回其拥有者的 手牌。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class NEW1_005:MinionBase{
//NAME=劫持者
//TEXT=<b>连击：</b>将一个随从移回其拥有者的手牌。
//MAJ=ROGUE|COST=6|ATK=5|HP=3|RACE=UNDEAD
}
public class NEW1_007:SpellBase{
//NAME=星辰坠落
//TEXT=<b>抉择：</b>对一个随从造成$5点伤害；或者对所有敌方随从造成$2点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class NEW1_007a:SpellBase{
//NAME=星辰漂流
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class NEW1_007b:SpellBase{
//NAME=星辰领主
//TEXT=对一个随从造成$5点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class NEW1_008:MinionBase{
//NAME=知识古树
//TEXT=<b>抉择：</b>抽两张牌；或者恢复#7点生命值。
//MAJ=DRUID|COST=7|ATK=7|HP=7|RACE=NONE
}
public class NEW1_008a:SpellBase{
//NAME=古老的教诲
//TEXT=抽两张牌。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class NEW1_008b:SpellBase{
//NAME=古老的秘密
//TEXT=恢复7点生命值。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class NEW1_009:MinionBase{
//NAME=治疗图腾
//TEXT=在你的回合结束时，为所有友方随从恢复#1点生命值。
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=TOTEM
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
    }
    public void CauseEvent()
    {
        if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            List<Card> ToBeHealed = new List<Card>();
            foreach(Card c in owner.myPlayer.board)
            {
                if(c!=owner)
                {
                    ToBeHealed.Add(c);
                }
            }
            foreach(Card c in ToBeHealed)
            {
                new EffectHeal(owner.myPlayer,owner,c,1).Resolve();
            }            
        }
    }
}
public class NEW1_010:MinionBase{
//NAME=风领主奥拉基尔
//TEXT=<b>冲锋，圣盾，嘲讽，风怒</b>
//MAJ=SHAMAN|COST=8|ATK=3|HP=6|RACE=ELEMENTAL
    public override void Init()
    {
        TaskInitAbility("Charge");
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
        TaskInitAbility("WindFury");
    }
}
public class NEW1_011:MinionBase{
//NAME=库卡隆精英卫士
//TEXT=<b>冲锋</b>
//MAJ=WARRIOR|COST=4|ATK=4|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class NEW1_012:MinionBase{
//NAME=法力浮龙
//TEXT=每当你施放一个法术，便获得 +1攻击力。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
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
                new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
            }
        }
    }
}
public class NEW1_012o:Ability{
//NAME=法力吸取
//TEXT=攻击力提高。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_014:MinionBase{
//NAME=伪装大师
//TEXT=<b>战吼：</b>直到你的下个回合，使一个友方随从获得<b>潜行</b>。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class NEW1_014e:Ability{
//NAME=伪装
//TEXT=获得潜行直到你的下个回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_016:MinionBase{
//NAME=船长的鹦鹉
//TEXT=<b>战吼：</b>从你的牌库中抽一张海盗牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class NEW1_017:MinionBase{
//NAME=鱼人杀手蟹
//TEXT=<b>战吼：</b>消灭一个鱼人，并获得+2/+2。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class NEW1_017e:Ability{
//NAME=吃饱了
//TEXT=+2/+2。一个鱼人就吃饱了。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_018:MinionBase{
//NAME=血帆袭击者
//TEXT=<b>战吼：</b> 获得等同于你的武器攻击力的攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=PIRATE
}
public class NEW1_018e:Ability{
//NAME=财迷心窍
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_019:MinionBase{
//NAME=飞刀杂耍者
//TEXT=在你召唤一个随从后，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class NEW1_020:MinionBase{
//NAME=狂野炎术师
//TEXT=在你施放一个法术后，对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=UNDEAD
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
                TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
            }
        }
    }
}
public class NEW1_021:MinionBase{
//NAME=末日预言者
//TEXT=在你的回合开始时，消灭所有随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=7|RACE=NONE
}
public class NEW1_022:MinionBase{
//NAME=恐怖海盗
//TEXT=<b>嘲讽</b> 你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=PIRATE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.weapon.Count>0)
            {
                return -owner.myPlayer.weapon[0].GetTag(GameTag.Attack);
            }
        }
        return 0;
    }
}
public class NEW1_023:MinionBase{
//NAME=精灵龙
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=DRAGON
}
public class NEW1_024:MinionBase{
//NAME=绿皮船长
//TEXT=<b>战吼：</b>使你的武器获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=PIRATE
}
public class NEW1_024o:Ability{
//NAME=绿皮的命令
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_025:MinionBase{
//NAME=血帆海盗
//TEXT=<b>战吼：</b>使对手的武器失去1点耐久度。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=PIRATE
}
public class NEW1_025e:Ability{
//NAME=加固
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_026:MinionBase{
//NAME=紫罗兰教师
//TEXT=每当你施放一个法术，召唤一个1/1的紫罗兰学徒。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class NEW1_026t:MinionBase{
//NAME=紫罗兰学徒
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class NEW1_027:MinionBase{
//NAME=南海船长
//TEXT=你的其他海盗拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=PIRATE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Pirate) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "NEW1_027e";
    }
}
public class NEW1_027e:Ability{
//NAME=呀！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod || tg==GameTag.HealthMod)
        {
            return 1;
        }
        return 0;
    }
}
public class NEW1_029:MinionBase{
//NAME=米尔豪斯·法力风暴
//TEXT=<b>战吼：</b>下个回合敌方法术的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NONE
}
public class NEW1_029t:Ability{
//NAME=杀了米尔豪斯！
//TEXT=在本回合中，法术的法力值消耗为（0）点！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_030:MinionBase{
//NAME=死亡之翼
//TEXT=<b>战吼：</b> 消灭所有其他随从，并弃掉你的手牌。
//MAJ=NEUTRAL|COST=10|ATK=12|HP=12|RACE=DRAGON
}
public class NEW1_031:SpellBase{
//NAME=动物伙伴
//TEXT=随机召唤一个野兽伙伴。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListSummon = new List<string>(){"NEW1_032","NEW1_033","NEW1_034"};
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid(ToListSummon.Choice(owner.myPlayer.randomGen));
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class NEW1_032:MinionBase{
//NAME=米莎
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class NEW1_033:MinionBase{
//NAME=雷欧克
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "NEW1_033o";
    }
}
public class NEW1_033o:Ability{
//NAME=天空之眼
//TEXT=雷欧克使本随从获得+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 1;
        }
        return 0;
    }
}
public class NEW1_034:MinionBase{
//NAME=霍弗
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class NEW1_036:SpellBase{
//NAME=命令怒吼
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class NEW1_036e:Ability{
//NAME=命令怒吼
//TEXT=在本回合中，生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_036e2:Ability{
//NAME=命令怒吼
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_037:MinionBase{
//NAME=铸剑师
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class NEW1_037e:Ability{
//NAME=装备
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_038:MinionBase{
//NAME=格鲁尔
//TEXT=在每个回合结束时，获得+1/+1。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class NEW1_038o:Ability{
//NAME=生长
//TEXT=格鲁尔正在变得更强......
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NEW1_040:MinionBase{
//NAME=霍格
//TEXT=在你的回合结束时，召唤一个2/2并具有<b>嘲讽</b>的豺狼人。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class NEW1_040t:MinionBase{
//NAME=豺狼人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class NEW1_041:MinionBase{
//NAME=狂奔科多兽
//TEXT=<b>战吼：</b>随机消灭一个攻击力小于或等于2的敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=BEAST
}
