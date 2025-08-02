using System.Collections;
using System.Collections.Generic;

public class CS2_003:SpellBase{
//NAME=心灵视界
//TEXT=随机复制对手手牌中的一张牌，将其置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CS2_004:SpellBase{
//NAME=真言术：盾
//TEXT=使一个随从获得+2生命值。 抽一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CS2_004_Puzzle:SpellBase{
//NAME=真言术：盾
//TEXT=使一个随从获得+2生命值。 抽一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CS2_004e:Ability{
//NAME=真言术：盾
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_005:SpellBase{
//NAME=爪击
//TEXT=使你的英雄获得2点护甲值，并在本回合中获得 +2攻击力。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(atk:2,arm:2);
    }
}
public class CS2_005o:Ability{
//NAME=爪击
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_007:SpellBase{
//NAME=治疗之触
//TEXT=恢复#8点生命值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class CS2_008:SpellBase{
//NAME=月火术
//TEXT=造成$1点伤害。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=ARCANE
}
public class CS2_009:SpellBase{
//NAME=野性印记
//TEXT=使一个随从获得<b>嘲讽</b>和+2/+3。<i>（+2攻击力/+3生命值）</i>
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CS2_009e:Ability{
//NAME=野性印记
//TEXT=+2/+3并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_011:SpellBase{
//NAME=野蛮咆哮
//TEXT=在本回合中，使你的所有角色获得+2攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.hero))
        {
            c.ChangeTag(GameTag.AttackFot,2);
        }
        new EffectChange(owner.myPlayer,owner,owner).Resolve();
    }
}
public class CS2_011o:Ability{
//NAME=野蛮咆哮
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_012:SpellBase{
//NAME=横扫
//TEXT=对一个敌人造成$4点伤害，并对所有其他敌人 造成$1点伤害。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> otherTargets=new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.hero.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c!=target)
            {
                otherTargets.Add(c);
            }
        }
        new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
        TaskDamageTargets(otherTargets,1);
    }
}
public class CS2_013:SpellBase{
//NAME=野性成长
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)==10)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("CS2_013t"),ZoneType.Hand);
        }
        else{
            owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,1);
        }
    }
}
public class CS2_013t:SpellBase{
//NAME=法力过剩
//TEXT=抽一张牌。<i>（你最多可以拥有 十个法力水晶。）</i>
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
    }
}
public class CS2_017_HS1:HeroPowerBase{
//NAME=变形
//TEXT=<b>英雄技能</b> 本回合+$a1攻击力。+$d1护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_017_HS2:HeroPowerBase{
//NAME=变形
//TEXT=<b>英雄技能</b> 本回合+$a1攻击力。+$d1护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_017_HS3:HeroPowerBase{
//NAME=变形
//TEXT=<b>英雄技能</b> 本回合+$a1攻击力。+$d1护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_017_HS4:HeroPowerBase{
//NAME=变形
//TEXT=<b>英雄技能</b> 本回合+$a1攻击力。+$d1护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_017o:Ability{
//NAME=额外攻击力
//TEXT=在本回合中，你的英雄拥有额外攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_022:SpellBase{
//NAME=变形术
//TEXT=使一个随从变形成为1/1的绵羊。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class CS2_022e:Ability{
//NAME=变形术
//TEXT=本随从被变形成为1/1的绵羊。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_023:SpellBase{
//NAME=奥术智慧
//TEXT=抽两张牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        new EffectDraw(owner.myPlayer,owner).Resolve();
        new EffectDraw(owner.myPlayer,owner).Resolve();
    }
}
public class CS2_024:SpellBase{
//NAME=寒冰箭
//TEXT=对一个角色造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
    }
}
public class CS2_025:SpellBase{
//NAME=魔爆术
//TEXT=对所有敌方随从造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,1);
    }
}
public class CS2_026:SpellBase{
//NAME=冰霜新星
//TEXT=<b>冻结</b>所有敌方随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        List<string> abis = new List<string>();
        foreach(Card c in owner.myPlayer.otherPlayer.board)
        {
            abis.Add("Frozen");
        }
        new EffectGiveAbility(owner.myPlayer,owner,targets:owner.myPlayer.otherPlayer.board,abinames:abis).Resolve();
    }
}
public class CS2_027:SpellBase{
//NAME=镜像
//TEXT=召唤两个0/2，并具有<b>嘲讽</b>的随从。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_mirror");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class CS2_028:SpellBase{
//NAME=暴风雪
//TEXT=对所有敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,2);
    }
}
public class CS2_029:SpellBase{
//NAME=火球术
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
    }
}
public class CS2_031:SpellBase{
//NAME=冰枪术
//TEXT=<b>冻结</b>一个角色，如果该角色已被<b>冻结</b>，则改为对其造成$4点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        if(target.HasAbility("Frozen"))
        {
            new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
        }
        else{
           new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve(); 
        }
    }
}
public class CS2_032:SpellBase{
//NAME=烈焰风暴
//TEXT=对所有敌方随从造成$5点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,5);
    }
}
public class CS2_033:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class CS2_034_H1:HeroPowerBase{
//NAME=火焰冲击
//TEXT=<b>英雄技能</b> 造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H1_AT_132:HeroPowerBase{
//NAME=二级火焰冲击
//TEXT=<b>英雄技能</b> 造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H2:HeroPowerBase{
//NAME=火焰冲击
//TEXT=<b>英雄技能</b> 造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H2_AT_132:HeroPowerBase{
//NAME=二级火焰冲击
//TEXT=<b>英雄技能</b> 造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H3:HeroPowerBase{
//NAME=火焰冲击
//TEXT=<b>英雄技能</b> 造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H3_AT_132:HeroPowerBase{
//NAME=二级火焰冲击
//TEXT=<b>英雄技能</b> 造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_034_H4:HeroPowerBase{
//NAME=火焰冲击
//TEXT=<b>英雄技能</b> 造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_037:SpellBase{
//NAME=冰霜震击
//TEXT=对一个敌方角色造成$1点伤害，并使其<b>冻结</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FROST
}
public class CS2_038:SpellBase{
//NAME=先祖之魂
//TEXT=使一个随从获得“<b>亡语</b>：再次召唤本随从。”
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_038e:Ability{
//NAME=先祖之魂
//TEXT=<b>亡语：</b>再次召唤本随从。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_039:SpellBase{
//NAME=风怒
//TEXT=使一个随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"WindFury").Resolve();
    }
}
public class CS2_041:SpellBase{
//NAME=先祖治疗
//TEXT=为一个随从恢复所有生命值并使其获得<b>嘲讽</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class CS2_041e:Ability{
//NAME=先祖眷顾
//TEXT=嘲讽
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_042:MinionBase{
//NAME=火元素
//TEXT=<b>战吼：</b>造成4点伤害。
//MAJ=SHAMAN|COST=6|ATK=6|HP=5|RACE=ELEMENTAL
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
    }
}
public class CS2_045:SpellBase{
//NAME=石化武器
//TEXT=在本回合中，使一个友方角色获得+3攻击力。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        target.ChangeTag(GameTag.AttackFot,3);
        new EffectChange(owner.myPlayer,owner,target).Resolve();
    }
}
public class CS2_045e:Ability{
//NAME=石化武器
//TEXT=在本回合中，本角色拥有+3攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_046:SpellBase{
//NAME=嗜血
//TEXT=在本回合中，使你的所有随从获得+3攻击力。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.board)
        {
            c.ChangeTag(GameTag.AttackFot,3);
        }
        new EffectChange(owner.myPlayer,owner,owner).Resolve();
    }
}
public class CS2_046e:Ability{
//NAME=嗜血
//TEXT=在本回合中+3攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H1:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H1_AT_132:HeroPowerBase{
//NAME=图腾崇拜
//TEXT=<b>英雄技能</b> 召唤一个你想要的图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H2:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H2_AT_132:HeroPowerBase{
//NAME=图腾崇拜
//TEXT=<b>英雄技能</b> 召唤一个你想要的图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H3:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H3_AT_132:HeroPowerBase{
//NAME=图腾崇拜
//TEXT=<b>英雄技能</b> 召唤一个你想要的图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H4:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H4_AT_132:HeroPowerBase{
//NAME=图腾崇拜
//TEXT=<b>英雄技能</b> 召唤一个你想要的图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_049_H5:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_050:MinionBase{
//NAME=灼热图腾
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=TOTEM
}
public class CS2_051:MinionBase{
//NAME=石爪图腾
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=TOTEM
    public override void Init()
    {
        base.Init();
        new EffectGiveAbility(owner.myPlayer,owner,owner,"Taunt",createVfx:false).Resolve();
    }
}
public class CS2_052:MinionBase{
//NAME=空气之怒图腾
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=TOTEM
}
public class CS2_053:SpellBase{
//NAME=视界术
//TEXT=抽一张牌，该牌的法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn=TaskDraw();
        if(Drawn!=null)
        {
            new EffectChange(owner.myPlayer,owner,Drawn,manaChange:-3).Resolve();
        }
    }
}
public class CS2_053e:Ability{
//NAME=视界术
//TEXT=法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_056_H1:HeroPowerBase{
//NAME=生命分流
//TEXT=<b>英雄技能</b> 抽一张牌并受到$2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_056_H2:HeroPowerBase{
//NAME=生命分流
//TEXT=<b>英雄技能</b> 抽一张牌并受到$2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_056_H3:HeroPowerBase{
//NAME=生命分流
//TEXT=<b>英雄技能</b> 抽一张牌并受到$2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_057:SpellBase{
//NAME=暗影箭
//TEXT=对一个随从造成$4点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class CS2_058:MinionBase{
//NAME=力量图腾
//TEXT=在你的回合结束时，使另一个友方随从获得+1攻击力。
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
            Card Target = ToBeHealed.Choice(owner.myPlayer.randomGen);
            new EffectChange(owner.myPlayer,owner,Target,0,1).Resolve();       
        }
    }
}
public class CS2_058e:Ability{
//NAME=大地之力
//TEXT=+1攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_059:MinionBase{
//NAME=鲜血小鬼
//TEXT=<b>潜行</b> 在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=WARLOCK|COST=1|ATK=0|HP=1|RACE=DEMON
}
public class CS2_059o:Ability{
//NAME=血之契印
//TEXT=生命值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_061:SpellBase{
//NAME=吸取生命
//TEXT=造成$2点伤害，为你的英雄恢复#2点生命值。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class CS2_062:SpellBase{
//NAME=地狱烈焰
//TEXT=对所有角色造成$3点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(FindAllChar(),3);
    }
}
public class CS2_063:SpellBase{
//NAME=腐蚀术
//TEXT=选择一个敌方随从，在你的回合开始时，消灭该随从。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CS2_063e:Ability{
//NAME=腐蚀术
//TEXT=在施放腐蚀术的玩家的回合开始时，消灭本随从。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_064:MinionBase{
//NAME=恐惧地狱火
//TEXT=<b>战吼：</b>对所有其他角色造成1点伤害。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class CS2_065:MinionBase{
//NAME=虚空行者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class CS2_072:SpellBase{
//NAME=背刺
//TEXT=对一个未受伤的随从造成$2点 伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class CS2_073:SpellBase{
//NAME=冷血
//TEXT=使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:4).Resolve();
        }
        else{
            new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
        }
    }
}
public class CS2_073e:Ability{
//NAME=冷血
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_073e2:Ability{
//NAME=冷血
//TEXT=+4攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_074:SpellBase{
//NAME=致命药膏
//TEXT=使你的武器获得+2攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.weapon.Count>0)
        {
            new EffectChange(owner.myPlayer,owner,owner.myPlayer.weapon[0],atkChange:2).Resolve();
            TaskBuffMyHero(atk:2);
        } 
    }
}
public class CS2_074e:Ability{
//NAME=致命药膏
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_075:SpellBase{
//NAME=影袭
//TEXT=对敌方英雄造成$3点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target =null)
    {
        TaskDamageEnemyHero(3);
    }
}
public class CS2_076:SpellBase{
//NAME=刺杀
//TEXT=消灭一个敌方随从。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class CS2_077:SpellBase{
//NAME=疾跑
//TEXT=抽四张牌。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CS2_080:WeaponBase{
//NAME=刺客之刃
//TEXT=
//MAJ=ROGUE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class CS2_082:WeaponBase{
//NAME=邪恶短刀
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CS2_082_H1:WeaponBase{
//NAME=邪恶短刀
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CS2_083b_H1:HeroPowerBase{
//NAME=匕首精通
//TEXT=<b>英雄技能</b> 装备一把1/2的 匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_083b_H2:HeroPowerBase{
//NAME=匕首精通
//TEXT=<b>英雄技能</b> 装备一把1/2的 匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_083e:Ability{
//NAME=打磨
//TEXT=这把武器本回合获得+1攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_084:SpellBase{
//NAME=猎人印记
//TEXT=使一个随从的生命值变为1。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,hpChange:1-target.GetTag(GameTag.Health)).Resolve();
    }
}
public class CS2_084e:Ability{
//NAME=猎人印记
//TEXT=本随从的生命值变为1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_087:SpellBase{
//NAME=力量祝福
//TEXT=使一个随从获得+3攻击力。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CS2_087e:Ability{
//NAME=力量祝福
//TEXT=+3攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_088:MinionBase{
//NAME=列王守卫
//TEXT=<b>嘲讽</b>，<b>战吼：</b>为你的英雄恢复#6点生命值。
//MAJ=PALADIN|COST=7|ATK=5|HP=7|RACE=NONE
}
public class CS2_089:SpellBase{
//NAME=圣光术
//TEXT=为你的英雄恢复#8点生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CS2_091:WeaponBase{
//NAME=圣光的正义
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=4|RACE=NONE
}
public class CS2_092:SpellBase{
//NAME=王者祝福
//TEXT=使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class CS2_092e:Ability{
//NAME=王者祝福
//TEXT=+4/+4。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_093:SpellBase{
//NAME=奉献
//TEXT=对所有敌人造成$2点伤害。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
    }
}
public class CS2_094:SpellBase{
//NAME=愤怒之锤
//TEXT=造成$3点伤害。抽一张牌。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskDraw();
    }
}
public class CS2_097:WeaponBase{
//NAME=真银圣剑
//TEXT=每当你的英雄进攻，便为其恢复#3点生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class CS2_101_H1:HeroPowerBase{
//NAME=援军
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H1_AT_132:HeroPowerBase{
//NAME=白银之手
//TEXT=<b>英雄技能</b> 召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H2:HeroPowerBase{
//NAME=援军
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H2_AT_132:HeroPowerBase{
//NAME=白银之手
//TEXT=<b>英雄技能</b> 召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H3:HeroPowerBase{
//NAME=援军
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H3_AT_132:HeroPowerBase{
//NAME=白银之手
//TEXT=<b>英雄技能</b> 召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101_H4:HeroPowerBase{
//NAME=援军
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_101t:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t2:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t3:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t4:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t5:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t6:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t7:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_101t8:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_102_H1:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得$d2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H1_AT_132:HeroPowerBase{
//NAME=铜墙铁壁！
//TEXT=<b>英雄技能</b> 获得$d4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H2:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得$d2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H2_AT_132:HeroPowerBase{
//NAME=铜墙铁壁！
//TEXT=<b>英雄技能</b> 获得$d4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H3:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得$d2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H3_AT_132:HeroPowerBase{
//NAME=铜墙铁壁！
//TEXT=<b>英雄技能</b> 获得$d4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H4:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得$d2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_102_H4_AT_132:HeroPowerBase{
//NAME=铜墙铁壁！
//TEXT=<b>英雄技能</b> 获得$d4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_103:SpellBase{
//NAME=冲锋
//TEXT=使一个友方随从获得+2攻击力和<b>冲锋</b>。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        
        new EffectGiveAbility(owner.myPlayer,owner,target,"Charge").Resolve();
        new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
    }
}
public class CS2_103e2:Ability{
//NAME=冲锋
//TEXT=+2攻击力并获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_104:SpellBase{
//NAME=狂暴
//TEXT=使一个受伤的随从获得+3/+3。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_104e:Ability{
//NAME=狂暴
//TEXT=+3/+3。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_105:SpellBase{
//NAME=英勇打击
//TEXT=在本回合中，使你的英雄获得+4攻击力。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_105e:Ability{
//NAME=英勇打击
//TEXT=在本回合中，+4攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_106:WeaponBase{
//NAME=炽炎战斧
//TEXT=
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CS2_108:SpellBase{
//NAME=斩杀
//TEXT=消灭一个受伤的敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CS2_112:WeaponBase{
//NAME=奥金斧
//TEXT=
//MAJ=WARRIOR|COST=5|ATK=5|HP=2|RACE=NONE
}
public class CS2_114:SpellBase{
//NAME=顺劈斩
//TEXT=随机对两个敌方随从造成 $2点伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CS2_117:MinionBase{
//NAME=大地之环先知
//TEXT=<b>战吼：</b> 恢复#3点生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CS2_118:MinionBase{
//NAME=岩浆暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=ELEMENTAL
}
public class CS2_119:MinionBase{
//NAME=绿洲钳嘴龟
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=7|RACE=BEAST
}
public class CS2_120:MinionBase{
//NAME=淡水鳄
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class CS2_121:MinionBase{
//NAME=霜狼步兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CS2_122:MinionBase{
//NAME=团队领袖
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CS2_122e:Ability{
//NAME=强化
//TEXT=团队领袖使本随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_124:MinionBase{
//NAME=狼骑兵
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class CS2_125:MinionBase{
//NAME=铁鬃灰熊
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class CS2_127:MinionBase{
//NAME=银背族长
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class CS2_131:MinionBase{
//NAME=暴风城骑士
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class CS2_141:MinionBase{
//NAME=铁炉堡火枪手
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class CS2_142:MinionBase{
//NAME=狗头人地卜师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CS2_146:MinionBase{
//NAME=南海船工
//TEXT=如果你装备着武器，本随从拥有 <b>冲锋</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=PIRATE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        if (owner.myPlayer.weapon.Count != 0)
        {
            new EffectGiveAbility(owner.myPlayer, owner, owner, "Charge").Resolve();
            new EffectChange(owner.myPlayer,owner,owner,visualFx:false).Resolve();
        }
    }
}
public class CS2_147:MinionBase{
//NAME=侏儒发明家
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class CS2_150:MinionBase{
//NAME=雷矛特种兵
//TEXT=<b>战吼：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=2|RACE=NONE
}
public class CS2_151:MinionBase{
//NAME=白银之手骑士
//TEXT=<b>战吼：</b>召唤一个2/2的侍从。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class CS2_152:MinionBase{
//NAME=侍从
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class CS2_155:MinionBase{
//NAME=大法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=7|RACE=NONE
}
public class CS2_161:MinionBase{
//NAME=拉文霍德刺客
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=5|RACE=NONE
}
public class CS2_162:MinionBase{
//NAME=竞技场主宰
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
}
public class CS2_168:MinionBase{
//NAME=鱼人袭击者
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MURLOC
}
public class CS2_169:MinionBase{
//NAME=幼龙鹰
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CS2_171:MinionBase{
//NAME=石牙野猪
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class CS2_172:MinionBase{
//NAME=血沼迅猛龙
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class CS2_173:MinionBase{
//NAME=蓝鳃战士
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class CS2_179:MinionBase{
//NAME=森金持盾卫士
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CS2_181:MinionBase{
//NAME=负伤剑圣
//TEXT=<b>战吼：</b>对自身造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=7|RACE=NONE
}
public class CS2_181e:Ability{
//NAME=鼎盛之力
//TEXT=本随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_182:MinionBase{
//NAME=冰风雪人
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class CS2_186:MinionBase{
//NAME=作战傀儡
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class CS2_187:MinionBase{
//NAME=藏宝海湾保镖
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class CS2_188:MinionBase{
//NAME=叫嚣的中士
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CS2_188o:Ability{
//NAME=“深受鼓舞”
//TEXT=在本回合中，本随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_189:MinionBase{
//NAME=精灵弓箭手
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class CS2_196:MinionBase{
//NAME=剃刀猎手
//TEXT=<b>战吼：</b>召唤一个1/1的野猪。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CS2_197:MinionBase{
//NAME=食人魔法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CS2_200:MinionBase{
//NAME=石拳食人魔
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class CS2_201:MinionBase{
//NAME=熔火恶犬
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=9|HP=5|RACE=BEAST
}
public class CS2_203:MinionBase{
//NAME=铁喙猫头鹰
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=BEAST
}
public class CS2_213:MinionBase{
//NAME=鲁莽火箭兵
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=2|RACE=NONE
}
public class CS2_221:MinionBase{
//NAME=恶毒铁匠
//TEXT=本随从受伤时，你的武器拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class CS2_221e:Ability{
//NAME=锋利无比！
//TEXT=恶毒铁匠使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_222:MinionBase{
//NAME=暴风城勇士
//TEXT=你的其他随从拥有+1/+1。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class CS2_222o:Ability{
//NAME=暴风城之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_226:MinionBase{
//NAME=霜狼督军
//TEXT=<b>战吼：</b>战场上每有一个其他友方随从，便获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class CS2_226e:Ability{
//NAME=霜狼军旗
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_227:MinionBase{
//NAME=风险投资公司雇佣兵
//TEXT=你的随从牌的法力值消耗增加（3）点。
//MAJ=NEUTRAL|COST=5|ATK=7|HP=6|RACE=NONE
}
public class CS2_227e:Ability{
//NAME=佣金
//TEXT=法力值消耗增加（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_231:MinionBase{
//NAME=小精灵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=UNDEAD
}
public class CS2_232:MinionBase{
//NAME=埃隆巴克保护者
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=NONE
}
public class CS2_233:SpellBase{
//NAME=剑刃乱舞
//TEXT=摧毁你的武器，对所有敌方随从 造成等同于其攻击力的伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.weapon.Count>0)
        {
            Card Target = owner.myPlayer.weapon[0];
            new EffectDestroy(owner.myPlayer,owner,Target).Resolve();
            TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),Target.GetTag(GameTag.Attack));
        }
        
    }
}
public class CS2_234:SpellBase{
//NAME=暗言术：痛
//TEXT=消灭一个攻击力小于或等于3的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CS2_235:MinionBase{
//NAME=北郡牧师
//TEXT=每当一个随从获得治疗时，抽一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CS2_236:SpellBase{
//NAME=神圣之灵
//TEXT=使一个随从的生命值翻倍。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CS2_236e:Ability{
//NAME=神圣之灵
//TEXT=本随从的生命值翻倍。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS2_237:MinionBase{
//NAME=饥饿的秃鹫
//TEXT=每当你召唤一个野兽，抽一张牌。
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class CS2_boar:MinionBase{
//NAME=野猪
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CS2_mirror:MinionBase{
//NAME=镜像
//TEXT=<b>嘲讽</b>
//MAJ=MAGE|COST=0|ATK=0|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class CS2_tk1:MinionBase{
//NAME=绵羊
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=BEAST
}
