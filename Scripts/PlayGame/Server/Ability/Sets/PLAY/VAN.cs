using System.Collections;
using System.Collections.Generic;

public class VAN_CS1_042:MinionBase{
//NAME=闪金镇步兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class VAN_CS1_069:MinionBase{
//NAME=沼泽爬行者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class VAN_CS1_112:SpellBase{
//NAME=神圣新星
//TEXT=对所有敌人造成$2点伤害，为所有友方角色 恢复#2点生命值。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
         TaskDamageEnemyHero(1);
    }
}
public class VAN_CS1_113:SpellBase{
//NAME=精神控制
//TEXT=夺取一个敌方随从的控制权。
//MAJ=PRIEST|COST=10|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS1_129:SpellBase{
//NAME=心灵之火
//TEXT=使一个随从的攻击力等同于其生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS1_130:SpellBase{
//NAME=神圣惩击
//TEXT=造成$2点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class VAN_CS2_003:SpellBase{
//NAME=心灵视界
//TEXT=随机复制对手手牌中的一张牌，将其置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_004:SpellBase{
//NAME=真言术：盾
//TEXT=使一个随从获得+2生命值。 抽一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_005:SpellBase{
//NAME=爪击
//TEXT=使你的英雄获得2点护甲值，并在本回合中获得 +2攻击力。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_007:SpellBase{
//NAME=治疗之触
//TEXT=恢复#8点生命值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_008:SpellBase{
//NAME=月火术
//TEXT=造成$1点伤害。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_009:SpellBase{
//NAME=野性印记
//TEXT=使一个随从获得<b>嘲讽</b>和+2/+2。<i>（+2攻击力/+2生命值）</i>
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_009e:Ability{
//NAME=野性印记
//TEXT=+2/+2并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_011:SpellBase{
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
public class VAN_CS2_012:SpellBase{
//NAME=横扫
//TEXT=对一个敌人造成$4点伤害，并对所有其他敌人 造成$1点伤害。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_013:SpellBase{
//NAME=野性成长
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
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
public class VAN_CS2_022:SpellBase{
//NAME=变形术
//TEXT=使一个随从变形成为1/1的绵羊。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_023:SpellBase{
//NAME=奥术智慧
//TEXT=抽两张牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDraw(owner.myPlayer,owner).Resolve();
        new EffectDraw(owner.myPlayer,owner).Resolve();
    }
}
public class VAN_CS2_024:SpellBase{
//NAME=寒冰箭
//TEXT=对一个角色造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
    }
}
public class VAN_CS2_025:SpellBase{
//NAME=魔爆术
//TEXT=对所有敌方随从造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,1);
    }
}
public class VAN_CS2_026:SpellBase{
//NAME=冰霜新星
//TEXT=<b>冻结</b>所有敌方随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
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
public class VAN_CS2_027:SpellBase{
//NAME=镜像
//TEXT=召唤两个0/2，并具有<b>嘲讽</b>的随从。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAN_CS2_mirror");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class VAN_CS2_028:SpellBase{
//NAME=暴风雪
//TEXT=对所有敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,2);
    }
}
public class VAN_CS2_029:SpellBase{
//NAME=火球术
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
    }
}
public class VAN_CS2_031:SpellBase{
//NAME=冰枪术
//TEXT=<b>冻结</b>一个角色，如果该角色已被<b>冻结</b>，则改为对其造成$4点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
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
public class VAN_CS2_032:SpellBase{
//NAME=烈焰风暴
//TEXT=对所有敌方随从造成$4点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,4);
    }
}
public class VAN_CS2_033:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=NONE
}
public class VAN_CS2_037:SpellBase{
//NAME=冰霜震击
//TEXT=对一个敌方角色造成$1点伤害，并使其<b>冻结</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_038:SpellBase{
//NAME=先祖之魂
//TEXT=选择一个随从。当该随从被消灭时，使其返回战场。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_039:SpellBase{
//NAME=风怒
//TEXT=使一个随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"WindFury").Resolve();
    }
}
public class VAN_CS2_041:SpellBase{
//NAME=先祖治疗
//TEXT=为一个随从恢复所有生命值并使其获得<b>嘲讽</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_042:MinionBase{
//NAME=火元素
//TEXT=<b>战吼：</b>造成3点伤害。
//MAJ=SHAMAN|COST=6|ATK=6|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
    }
}
public class VAN_CS2_045:SpellBase{
//NAME=石化武器
//TEXT=在本回合中，使一个友方角色获得+3攻击力。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        target.ChangeTag(GameTag.AttackFot,3);
        new EffectChange(owner.myPlayer,owner,target).Resolve();
    }
}
public class VAN_CS2_046:SpellBase{
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
public class VAN_CS2_050:MinionBase{
//NAME=灼热图腾
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=TOTEM
}
public class VAN_CS2_051:MinionBase{
//NAME=石爪图腾
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=TOTEM
}
public class VAN_CS2_052:MinionBase{
//NAME=空气之怒图腾
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=TOTEM
}
public class VAN_CS2_053:SpellBase{
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
public class VAN_CS2_057:SpellBase{
//NAME=暗影箭
//TEXT=对一个随从造成$4点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_059:MinionBase{
//NAME=鲜血小鬼
//TEXT=<b>潜行</b> 在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=WARLOCK|COST=1|ATK=0|HP=1|RACE=DEMON
}
public class VAN_CS2_061:SpellBase{
//NAME=吸取生命
//TEXT=造成$2点伤害，为你的英雄恢复#2点生命值。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_062:SpellBase{
//NAME=地狱烈焰
//TEXT=对所有角色造成$3点伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(FindAllChar(),3);
    }
}
public class VAN_CS2_063:SpellBase{
//NAME=腐蚀术
//TEXT=选择一个敌方随从，在你的回合开始时，消灭该随从。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_064:MinionBase{
//NAME=恐惧地狱火
//TEXT=<b>战吼：</b>对所有其他角色造成1点伤害。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class VAN_CS2_065:MinionBase{
//NAME=虚空行者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class VAN_CS2_072:SpellBase{
//NAME=背刺
//TEXT=对一个未受伤的随从造成$2点 伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class VAN_CS2_073:SpellBase{
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
public class VAN_CS2_073_puzzle:SpellBase{
//NAME=冷血
//TEXT=使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
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
public class VAN_CS2_074:SpellBase{
//NAME=致命药膏
//TEXT=使你的武器获得+2攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_075:SpellBase{
//NAME=影袭
//TEXT=对敌方英雄造成$3点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target =null)
    {
        TaskDamageEnemyHero(3);
    }
}
public class VAN_CS2_076:SpellBase{
//NAME=刺杀
//TEXT=消灭一个敌方随从。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_077:SpellBase{
//NAME=疾跑
//TEXT=抽四张牌。
//MAJ=ROGUE|COST=7|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_080:WeaponBase{
//NAME=刺客之刃
//TEXT=
//MAJ=ROGUE|COST=5|ATK=3|HP=4|RACE=NONE
}
public class VAN_CS2_082:WeaponBase{
//NAME=邪恶短刀
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class VAN_CS2_084:SpellBase{
//NAME=猎人印记
//TEXT=使一个随从的生命值变为1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,hpChange:1-target.GetTag(GameTag.Health)).Resolve();
    }
}
public class VAN_CS2_087:SpellBase{
//NAME=力量祝福
//TEXT=使一个随从获得+3攻击力。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_088:MinionBase{
//NAME=列王守卫
//TEXT=<b>战吼：</b>为你的英雄恢复#6点生命值。
//MAJ=PALADIN|COST=7|ATK=5|HP=6|RACE=NONE
}
public class VAN_CS2_089:SpellBase{
//NAME=圣光术
//TEXT=恢复#6点生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_091:WeaponBase{
//NAME=圣光的正义
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=4|RACE=NONE
}
public class VAN_CS2_092:SpellBase{
//NAME=王者祝福
//TEXT=使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_093:SpellBase{
//NAME=奉献
//TEXT=对所有敌人造成$2点伤害。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
    }
}
public class VAN_CS2_094:SpellBase{
//NAME=愤怒之锤
//TEXT=造成$3点伤害。抽一张牌。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskDraw();
    }
}
public class VAN_CS2_097:WeaponBase{
//NAME=真银圣剑
//TEXT=每当你的英雄进攻，便为其恢复#2点生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class VAN_CS2_101t:MinionBase{
//NAME=白银之手新兵
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class VAN_CS2_102_H3:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_103:SpellBase{
//NAME=冲锋
//TEXT=使一个友方随从获得+2攻击力和<b>冲锋</b>。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Charge").Resolve();
    }
}
public class VAN_CS2_103_Puzzle:SpellBase{
//NAME=冲锋
//TEXT=使一个友方随从获得<b>冲锋</b>。在本回合中无法攻击英雄。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_103e2:Ability{
//NAME=冲锋
//TEXT=+2攻击力并获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_103e2_Puzzle:Ability{
//NAME=冲锋
//TEXT=拥有<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_104:SpellBase{
//NAME=狂暴
//TEXT=使一个受伤的随从获得+3/+3。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_105:SpellBase{
//NAME=英勇打击
//TEXT=在本回合中，使你的英雄获得+4攻击力。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_106:WeaponBase{
//NAME=炽炎战斧
//TEXT=
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=NONE
}
public class VAN_CS2_108:SpellBase{
//NAME=斩杀
//TEXT=消灭一个受伤的敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_112:WeaponBase{
//NAME=奥金斧
//TEXT=
//MAJ=WARRIOR|COST=5|ATK=5|HP=2|RACE=NONE
}
public class VAN_CS2_114:SpellBase{
//NAME=顺劈斩
//TEXT=随机对两个敌方随从造成 $2点伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_117:MinionBase{
//NAME=大地之环先知
//TEXT=<b>战吼：</b> 恢复#3点生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_CS2_118:MinionBase{
//NAME=岩浆暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=NONE
}
public class VAN_CS2_119:MinionBase{
//NAME=绿洲钳嘴龟
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=7|RACE=BEAST
}
public class VAN_CS2_120:MinionBase{
//NAME=淡水鳄
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class VAN_CS2_121:MinionBase{
//NAME=霜狼步兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_CS2_122:MinionBase{
//NAME=团队领袖
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class VAN_CS2_124:MinionBase{
//NAME=狼骑兵
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class VAN_CS2_125:MinionBase{
//NAME=铁鬃灰熊
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class VAN_CS2_127:MinionBase{
//NAME=银背族长
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class VAN_CS2_131:MinionBase{
//NAME=暴风城骑士
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class VAN_CS2_141:MinionBase{
//NAME=铁炉堡火枪手
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class VAN_CS2_142:MinionBase{
//NAME=狗头人地卜师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_CS2_146:MinionBase{
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
public class VAN_CS2_147:MinionBase{
//NAME=侏儒发明家
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class VAN_CS2_150:MinionBase{
//NAME=雷矛特种兵
//TEXT=<b>战吼：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=2|RACE=NONE
}
public class VAN_CS2_151:MinionBase{
//NAME=白银之手骑士
//TEXT=<b>战吼：</b>召唤一个2/2的侍从。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_CS2_152:MinionBase{
//NAME=侍从
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class VAN_CS2_155:MinionBase{
//NAME=大法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=7|RACE=NONE
}
public class VAN_CS2_161:MinionBase{
//NAME=拉文霍德刺客
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=5|RACE=NONE
}
public class VAN_CS2_162:MinionBase{
//NAME=竞技场主宰
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
}
public class VAN_CS2_168:MinionBase{
//NAME=鱼人袭击者
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MURLOC
}
public class VAN_CS2_169:MinionBase{
//NAME=幼龙鹰
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class VAN_CS2_171:MinionBase{
//NAME=石牙野猪
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class VAN_CS2_172:MinionBase{
//NAME=血沼迅猛龙
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class VAN_CS2_173:MinionBase{
//NAME=蓝鳃战士
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class VAN_CS2_179:MinionBase{
//NAME=森金持盾卫士
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class VAN_CS2_181:MinionBase{
//NAME=负伤剑圣
//TEXT=<b>战吼：</b>对自身造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=7|RACE=NONE
}
public class VAN_CS2_182:MinionBase{
//NAME=冰风雪人
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class VAN_CS2_186:MinionBase{
//NAME=作战傀儡
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class VAN_CS2_187:MinionBase{
//NAME=藏宝海湾保镖
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class VAN_CS2_188:MinionBase{
//NAME=叫嚣的中士
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class VAN_CS2_189:MinionBase{
//NAME=精灵弓箭手
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class VAN_CS2_196:MinionBase{
//NAME=剃刀猎手
//TEXT=<b>战吼：</b>召唤一个1/1的野猪。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class VAN_CS2_197:MinionBase{
//NAME=食人魔法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class VAN_CS2_200:MinionBase{
//NAME=石拳食人魔
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class VAN_CS2_201:MinionBase{
//NAME=熔火恶犬
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=9|HP=5|RACE=BEAST
}
public class VAN_CS2_203:MinionBase{
//NAME=铁喙猫头鹰
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class VAN_CS2_213:MinionBase{
//NAME=鲁莽火箭兵
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=2|RACE=NONE
}
public class VAN_CS2_221:MinionBase{
//NAME=恶毒铁匠
//TEXT=<b>激怒：</b>你的武器拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class VAN_CS2_222:MinionBase{
//NAME=暴风城勇士
//TEXT=你的其他随从拥有+1/+1。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class VAN_CS2_222o:Ability{
//NAME=暴风城之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_226:MinionBase{
//NAME=霜狼督军
//TEXT=<b>战吼：</b>战场上每有一个其他友方随从，便获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_CS2_227:MinionBase{
//NAME=风险投资公司雇佣兵
//TEXT=你的随从牌的法力值消耗增加（3）点。
//MAJ=NEUTRAL|COST=5|ATK=7|HP=6|RACE=NONE
}
public class VAN_CS2_231:MinionBase{
//NAME=小精灵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class VAN_CS2_232:MinionBase{
//NAME=埃隆巴克保护者
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=NONE
}
public class VAN_CS2_233:SpellBase{
//NAME=剑刃乱舞
//TEXT=摧毁你的武器，对所有敌人造成等同于其攻击力的伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_234:SpellBase{
//NAME=暗言术：痛
//TEXT=消灭一个攻击力小于或等于3的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_235:MinionBase{
//NAME=北郡牧师
//TEXT=每当一个随从获得治疗时，抽一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class VAN_CS2_236:SpellBase{
//NAME=神圣之灵
//TEXT=使一个随从的生命值翻倍。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_CS2_237:MinionBase{
//NAME=饥饿的秃鹫
//TEXT=每当你召唤一个野兽，抽一张牌。
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class VAN_CS2_boar:MinionBase{
//NAME=野猪
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class VAN_CS2_mirror:MinionBase{
//NAME=镜像
//TEXT=<b>嘲讽</b>
//MAJ=MAGE|COST=0|ATK=0|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class VAN_CS2_tk1:MinionBase{
//NAME=绵羊
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class VAN_DFX_001:SpellBase{
//NAME=Fast Spawn to Deck Dummy FX
//TEXT=Holds the FX for inserting a card into a deck quickly.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DFX_002:SpellBase{
//NAME=Time Warp Dummy FX
//TEXT=Holds the FX for playing Timewarp FX.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DFX_003:SpellBase{
//NAME=Frost Nova Dummy FX
//TEXT=Holds the FX for playing Frost Nova FX.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DFX_004:SpellBase{
//NAME=Holy Healing Dummy FX
//TEXT=Holds the FX for playing Holy Healing FX.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DFX_005:SpellBase{
//NAME=Flamestrike Dummy FX
//TEXT=Holds the FX for playing Flamestrike FX.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DREAM_01:MinionBase{
//NAME=欢笑的姐妹
//TEXT=<b>扰魔</b>
//MAJ=DREAM|COST=2|ATK=3|HP=5|RACE=NONE
}
public class VAN_DREAM_02:SpellBase{
//NAME=伊瑟拉苏醒
//TEXT=对除了伊瑟拉之外的所有角色造成$5点伤害。
//MAJ=DREAM|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_DREAM_03:MinionBase{
//NAME=翡翠幼龙
//TEXT=
//MAJ=DREAM|COST=4|ATK=7|HP=6|RACE=DRAGON
}
public class VAN_DREAM_04:SpellBase{
//NAME=梦境
//TEXT=将一个随从移回其拥有者的 手牌。
//MAJ=DREAM|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DREAM_05:SpellBase{
//NAME=梦魇
//TEXT=使一个随从获得+5/+5，在你的下个回合开始时，消灭该随从。
//MAJ=DREAM|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DREAM_05e:Ability{
//NAME=梦魇
//TEXT=拥有+5/+5，但它马上会被消灭。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_DS1_055:MinionBase{
//NAME=暗鳞治愈者
//TEXT=<b>战吼：</b>为所有友方角色恢复#2点生命值。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class VAN_DS1_070:MinionBase{
//NAME=驯兽师
//TEXT=<b>战吼：</b>使一个友方野兽获得+2/+2和<b>嘲讽</b>。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class VAN_DS1_175:MinionBase{
//NAME=森林狼
//TEXT=你的其他野兽拥有+1攻击力。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Beast) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAN_DS1_175e";
    }
}
public class VAN_DS1_175e:Ability{
//NAME=呀！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 1;
        }
        return 0;
    }
}
public class VAN_DS1_178:MinionBase{
//NAME=苔原犀牛
//TEXT=你的野兽拥有<b>冲锋</b>。
//MAJ=HUNTER|COST=5|ATK=2|HP=5|RACE=BEAST
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Beast) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "Charge";
    }
}
public class VAN_DS1_183:SpellBase{
//NAME=多重射击
//TEXT=随机对两个敌方随从造成$3点 伤害。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_DS1_184:SpellBase{
//NAME=追踪术
//TEXT=检视你的牌库顶的三张牌，抽其中一张，弃掉其余牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_DS1_185:SpellBase{
//NAME=奥术射击
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class VAN_DS1_188:WeaponBase{
//NAME=角斗士的长弓
//TEXT=你的英雄在攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=7|ATK=5|HP=2|RACE=NONE
}
public class VAN_DS1_233:SpellBase{
//NAME=心灵震爆
//TEXT=对敌方英雄造成$5点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(5);
    }
}
public class VAN_EX1_001:MinionBase{
//NAME=圣光护卫者
//TEXT=每当一个角色获得治疗，便获得 +2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class VAN_EX1_002:MinionBase{
//NAME=黑骑士
//TEXT=<b>战吼：</b>消灭一个具有<b>嘲讽</b>的敌方随从。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_004:MinionBase{
//NAME=年轻的女祭司
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class VAN_EX1_005:MinionBase{
//NAME=王牌猎人
//TEXT=<b>战吼：</b> 消灭一个攻击力大于或等于7的随从。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
}
public class VAN_EX1_006:MinionBase{
//NAME=报警机器人
//TEXT=在你的回合开始时，随机将你的手牌中的一张随从牌与本随从 交换。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=3|RACE=MECHANICAL
}
public class VAN_EX1_007:MinionBase{
//NAME=苦痛侍僧
//TEXT=每当本随从受到伤害，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
        if(amount>0)
            TaskDraw();
    }
}
public class VAN_EX1_008:MinionBase{
//NAME=银色侍从
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class VAN_EX1_009:MinionBase{
//NAME=愤怒的小鸡
//TEXT=<b>激怒：</b>+5攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class VAN_EX1_010:MinionBase{
//NAME=狼人渗透者
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class VAN_EX1_011:MinionBase{
//NAME=巫医
//TEXT=<b>战吼：</b> 恢复#2点生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class VAN_EX1_012:MinionBase{
//NAME=血法师萨尔诺斯
//TEXT=<b>法术伤害+1</b>，<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            if(source.cardType==CardType.Spell || source.cardType==CardType.Secret)
            {
                new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
            }
        }
    }
    public override void Deathrattle()
    {
        TaskDraw();
    }
}
public class VAN_EX1_014:MinionBase{
//NAME=穆克拉
//TEXT=<b>战吼：</b>使你的对手获得两根香蕉。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        CardDbf bana=CardDbf.GetCardDbfByGuid("EX1_014t");
        TaskCreate(bana,ZoneType.Hand,true);
        TaskCreate(bana,ZoneType.Hand,true);
    }
}
public class VAN_EX1_015:MinionBase{
//NAME=工程师学徒
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
}
public class VAN_EX1_016:MinionBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=<b>亡语：</b>随机夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
    public override void Deathrattle()
    {
        Card ToSteal = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToSteal!=null)
        {
            new EffectMove(owner.myPlayer.otherPlayer,ToSteal,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
        }
    }
}
public class VAN_EX1_017:MinionBase{
//NAME=丛林猎豹
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class VAN_EX1_019:MinionBase{
//NAME=破碎残阳祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class VAN_EX1_020:MinionBase{
//NAME=血色十字军战士
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class VAN_EX1_021:MinionBase{
//NAME=萨尔玛先知
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_023:MinionBase{
//NAME=银月城卫兵
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_025:MinionBase{
//NAME=机械幼龙技工
//TEXT=<b>战吼：</b>召唤一个2/1的机械幼龙。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class VAN_EX1_028:MinionBase{
//NAME=荆棘谷猛虎
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class VAN_EX1_029:MinionBase{
//NAME=麻风侏儒
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
    public override void Deathrattle()
    {
        TaskDamageEnemyHero(2);
    }
}
public class VAN_EX1_032:MinionBase{
//NAME=烈日行者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_033:MinionBase{
//NAME=风怒鹰身人
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_043:MinionBase{
//NAME=暮光幼龙
//TEXT=<b>战吼：</b> 你每有一张手牌，便获得+1生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=1|RACE=DRAGON
    public override void Battlecry(Card target =null)
    {
        int Num=owner.myPlayer.hand.Count;
        new EffectChange(owner.myPlayer,owner,owner,hpChange:Num).Resolve();
    }
}
public class VAN_EX1_044:MinionBase{
//NAME=任务达人
//TEXT=每当你使用一张牌时，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_045:MinionBase{
//NAME=上古看守者
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_046:MinionBase{
//NAME=黑铁矮人
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_048:MinionBase{
//NAME=破法者
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class VAN_EX1_049:MinionBase{
//NAME=年轻的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class VAN_EX1_050:MinionBase{
//NAME=寒光智者
//TEXT=<b>战吼：</b>每个玩家抽两张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class VAN_EX1_055:MinionBase{
//NAME=魔瘾者
//TEXT=在本回合中，每当你施放一个法术，便获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class VAN_EX1_057:MinionBase{
//NAME=年迈的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class VAN_EX1_058:MinionBase{
//NAME=日怒保卫者
//TEXT=<b>战吼：</b>使相邻的随从获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_059:MinionBase{
//NAME=疯狂的炼金师
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int atk = target.GetTag(GameTag.Attack);
        int hp = target.GetTag(GameTag.Health);
        new EffectChange(owner.myPlayer,owner,target,atkChange:hp-atk,hpChange:atk-hp).Resolve();
    }
}
public class VAN_EX1_062:MinionBase{
//NAME=老瞎眼
//TEXT=<b>冲锋</b>，在战场上每有一个其他鱼人便拥有+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            int num = 0;
            foreach(Card c in owner.myPlayer.board)
            {
                if(c.raceType.Contains(RaceType.Murloc) && c!=owner)
                {
                    num+=1;
                }
            }
            return num;
        }
        return 0;
    }
}
public class VAN_EX1_066:MinionBase{
//NAME=酸性沼泽软泥怪
//TEXT=<b>战吼：</b> 摧毁对手的武器。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class VAN_EX1_067:MinionBase{
//NAME=银色指挥官
//TEXT=<b>冲锋</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=2|RACE=NONE
}
public class VAN_EX1_076:MinionBase{
//NAME=小个子召唤师
//TEXT=你每个回合使用的第一张随从牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_080:MinionBase{
//NAME=奥秘守护者
//TEXT=每当有一张<b>奥秘</b>牌被使用时，便获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class VAN_EX1_082:MinionBase{
//NAME=疯狂投弹者
//TEXT=<b>战吼：</b>造成3点伤害，随机分配到所有其他角色身上。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class VAN_EX1_083:MinionBase{
//NAME=工匠大师欧沃斯巴克
//TEXT=<b>战吼：</b> 随机使另一个随从变形成为一个5/5的魔暴龙或一个1/1的松鼠。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_084:MinionBase{
//NAME=战歌指挥官
//TEXT=每当你召唤一个攻击力小于或等于3的随从，使其获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay() && tz==ZoneType.Board)
        {
            if(sc!=owner)
            {
                if(sc.cardType==CardType.Minion)
                {
                    if(sc.GetTag(GameTag.Attack)<=3)
                    {
                        new EffectGiveAbility(owner.myPlayer,owner,sc,"Charge").Resolve();
                    }
                }
            }
        }
    }
}
public class VAN_EX1_085:MinionBase{
//NAME=精神控制技师
//TEXT=<b>战吼：</b>如果你的对手有4个或者更多随从，随机夺取其中一个的控制权。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_089:MinionBase{
//NAME=奥术傀儡
//TEXT=<b>冲锋</b>，<b>战吼：</b>使你的对手获得一个法力水晶。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.otherPlayer.ChangeTag(GameTag.ManaThisTurn,1);
    }
}
public class VAN_EX1_091:MinionBase{
//NAME=秘教暗影祭司
//TEXT=<b>战吼：</b>夺取一个攻击力小于或等于2的敌方随从的控制权。
//MAJ=PRIEST|COST=6|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_093:MinionBase{
//NAME=阿古斯防御者
//TEXT=<b>战吼：</b>使相邻的随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_095:MinionBase{
//NAME=加基森拍卖师
//TEXT=每当你施放一个法术，抽一张牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_096:MinionBase{
//NAME=战利品贮藏者
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class VAN_EX1_097:MinionBase{
//NAME=憎恶
//TEXT=<b>嘲讽，亡语：</b>对所有角色造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_100:MinionBase{
//NAME=游学者周卓
//TEXT=每当一个玩家施放一个法术，复制该法术，将其置入另一个玩家的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class VAN_EX1_102:MinionBase{
//NAME=攻城车
//TEXT=在你的回合开始时，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=MECHANICAL
}
public class VAN_EX1_103:MinionBase{
//NAME=寒光先知
//TEXT=<b>战吼：</b>使所有其他鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class VAN_EX1_105:MinionBase{
//NAME=山岭巨人
//TEXT=你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=12|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                return -owner.myPlayer.hand.Count+1;
            }   
        }
        return 0;
    }
}
public class VAN_EX1_110:MinionBase{
//NAME=凯恩·血蹄
//TEXT=<b>亡语：</b>召唤一个4/5的贝恩·血蹄。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_110t:MinionBase{
//NAME=贝恩·血蹄
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class VAN_EX1_112:MinionBase{
//NAME=格尔宾·梅卡托克
//TEXT=<b>战吼：</b>召唤一项惊人的发明。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class VAN_EX1_116:MinionBase{
//NAME=火车王里诺艾
//TEXT=<b>冲锋，战吼：</b> 为你的对手召唤两条1/1的雏龙。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("EX1_116t");
        TaskCreate(ToSummon,ZoneType.Board,true);
        TaskCreate(ToSummon,ZoneType.Board,true);
    }
}
public class VAN_EX1_124:SpellBase{
//NAME=刺骨
//TEXT=造成$2点伤害；<b>连击：</b>改为造成$4点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_126:SpellBase{
//NAME=背叛
//TEXT=使一个敌方随从对其相邻的随从 造成等同于其攻击力的伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_128:SpellBase{
//NAME=隐藏
//TEXT=直到你的下个回合，使所有友方随从获得<b>潜行</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_129:SpellBase{
//NAME=刀扇
//TEXT=对所有敌方随从造成$1点伤害，抽一张牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_130:SecretBase{
//NAME=崇高牺牲
//TEXT=<b>奥秘：</b>当一个敌人攻击时，召唤一个2/1的防御者，并使其成为攻击的目标。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_130a:MinionBase{
//NAME=防御者
//TEXT=
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class VAN_EX1_131:MinionBase{
//NAME=迪菲亚头目
//TEXT=<b>连击：</b>召唤一个2/1的迪菲亚强盗。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_131t"),ZoneType.Board);
        }
    }
}
public class VAN_EX1_132:SecretBase{
//NAME=以眼还眼
//TEXT=<b>奥秘：</b> 当你的英雄受到伤害时，对敌方英雄造成等量伤害。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_133:WeaponBase{
//NAME=毁灭之刃
//TEXT=<b>战吼：</b>造成1点伤害。<b>连击：</b>改为造成2点伤害。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_134:MinionBase{
//NAME=军情七处特工
//TEXT=<b>连击：</b>造成2点伤害。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_136:SecretBase{
//NAME=救赎
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，使其回到战场，并具有1点生命值。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_137:SpellBase{
//NAME=裂颅之击
//TEXT=对敌方英雄造成$2点伤害；<b>连击：</b>在下个回合将其移回你的手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_144:SpellBase{
//NAME=暗影步
//TEXT=将一个友方随从移回你的手牌，它的法力值消耗减少 （2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand).Resolve();
        new EffectChange(owner.myPlayer,owner,target,manaChange:-target.GetTag(GameTag.Mana)+target.cardDbf.ManaCost-2).Resolve();
    }
}
public class VAN_EX1_145:SpellBase{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（3）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    private bool on = false;
    public override void Battlecry(Card target = null)
    {

        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            if (c.cardType == CardType.Spell)
            {
                new EffectChange(owner.myPlayer,owner, c, -3, 0, 0, 0).Resolve();
            }
        }

    }
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_145CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_145CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc.cardType == CardType.Spell && on && sc!=owner)
        {
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (c.cardType == CardType.Spell)
                {
                    new EffectChange(owner.myPlayer,owner, c, 3, 0, 0, 0).Resolve();
                }
            }
            on = false;
        }
    }
}
public class VAN_EX1_145e:Ability{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_145o:Ability{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（3）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_154:SpellBase{
//NAME=愤怒
//TEXT=<b>抉择：</b> 对一个随从造成$3点伤害；或者造成$1点伤害并抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDraw(owner.myPlayer).Resolve();
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class VAN_EX1_154a:SpellBase{
//NAME=阳炎之怒
//TEXT=对一个随从造成$3点伤害。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_154b:SpellBase{
//NAME=自然之怒
//TEXT=对一个随从造成$1点伤害，抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_155:SpellBase{
//NAME=自然印记
//TEXT=<b>抉择：</b> 使一个随从获得+4攻击力；或者+4生命值和<b>嘲讽</b>。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_155a:SpellBase{
//NAME=猛虎之怒
//TEXT=+4攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_155b:SpellBase{
//NAME=皮糙肉厚
//TEXT=+4生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_158:SpellBase{
//NAME=丛林之魂
//TEXT=使你的所有随从获得“<b>亡语：</b>召唤一个2/2的树人”。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_158e:Ability{
//NAME=丛林之魂
//TEXT=<b>亡语：</b>召唤一个2/2的树人。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_160:SpellBase{
//NAME=野性之力
//TEXT=<b>抉择：</b>使你的所有随从获得+1/+1；或者召唤一只3/2的 猎豹。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_160a:SpellBase{
//NAME=召唤猎豹
//TEXT=召唤一只3/2的猎豹。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_160b:SpellBase{
//NAME=兽群领袖
//TEXT=使你的所有随从获得+1/+1。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_161:SpellBase{
//NAME=自然平衡
//TEXT=消灭一个随从，你的对手抽两张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDraw(ToEn:true);
        TaskDraw(ToEn:true);
    }
}
public class VAN_EX1_162:MinionBase{
//NAME=恐狼前锋
//TEXT=相邻的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class VAN_EX1_164:SpellBase{
//NAME=滋养
//TEXT=<b>抉择：</b>获得两个法力水晶；或者抽三张牌。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(target.myPlayer==owner.myPlayer)
        {
            TaskDraw();
            TaskDraw();
            TaskDraw();
        }
        else{
            owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,2);
            owner.myPlayer.ChangeTag(GameTag.ManaLeft,2);
        }
    }
}
public class VAN_EX1_164a:SpellBase{
//NAME=快速生长
//TEXT=获得两个法力水晶。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_164b:SpellBase{
//NAME=摄取养分
//TEXT=抽三张牌。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_165:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>抉择：</b><b>冲锋</b>；或者获得+2生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_165a:SpellBase{
//NAME=猎豹形态
//TEXT=<b>冲锋</b>
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_165b:SpellBase{
//NAME=熊形态
//TEXT=+2生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_165t1:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>冲锋</b>
//MAJ=DRUID|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_165t2:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=5|ATK=4|HP=6|RACE=NONE
}
public class VAN_EX1_166:MinionBase{
//NAME=丛林守护者
//TEXT=<b>抉择：</b>造成2点伤害；或者<b>沉默</b>一个随从。
//MAJ=DRUID|COST=4|ATK=2|HP=4|RACE=NONE
}
public class VAN_EX1_166a:SpellBase{
//NAME=月火术
//TEXT=造成2点伤害。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_166b:SpellBase{
//NAME=禁魔
//TEXT=<b>沉默</b>一个随从。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_169:SpellBase{
//NAME=激活
//TEXT=在本回合中，获得两个 法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_170:MinionBase{
//NAME=帝王眼镜蛇
//TEXT=消灭任何受到本随从伤害的随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class VAN_EX1_173:SpellBase{
//NAME=星火术
//TEXT=造成$5点伤害。抽一张牌。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_178:MinionBase{
//NAME=战争古树
//TEXT=<b>抉择：</b> +5攻击力；或者+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=NONE
}
public class VAN_EX1_178a:SpellBase{
//NAME=扎根
//TEXT=+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_178b:SpellBase{
//NAME=拔根
//TEXT=+5攻击力。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_238:SpellBase{
//NAME=闪电箭
//TEXT=造成$3点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
    }
}
public class VAN_EX1_241:SpellBase{
//NAME=熔岩爆裂
//TEXT=造成$5点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_243:MinionBase{
//NAME=尘魔
//TEXT=<b>风怒</b>，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=1|ATK=3|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("WindFury");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class VAN_EX1_244:SpellBase{
//NAME=图腾之力
//TEXT=使你的图腾获得+2生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_245:SpellBase{
//NAME=大地震击
//TEXT=<b>沉默</b>一个随从，然后对其造成$1点伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_246:SpellBase{
//NAME=妖术
//TEXT=使一个随从变形成为一只0/1并具有<b>嘲讽</b>的青蛙。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_247:WeaponBase{
//NAME=雷铸战斧
//TEXT=<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_248:SpellBase{
//NAME=野性狼魂
//TEXT=召唤两只2/3并具有<b>嘲讽</b>的幽灵狼。<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAN_EX1_tk11");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class VAN_EX1_249:MinionBase{
//NAME=迦顿男爵
//TEXT=在你的回合结束时，对所有其他角色造成2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=5|RACE=NONE
}
public class VAN_EX1_250:MinionBase{
//NAME=土元素
//TEXT=<b>嘲讽</b>，<b>过载：</b>（3）
//MAJ=SHAMAN|COST=5|ATK=7|HP=8|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class VAN_EX1_251:SpellBase{
//NAME=叉状闪电
//TEXT=随机对两个敌方随从造成$2点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.board)
        {
            Pool.Add(c);
        }
        List<Card> ToListDamage = new List<Card>();
        while(true)
        {
            if(ToListDamage.Count==2 || Pool.Count==0)
            {
                break;
            }
            Card ToDamage = Pool.Choice(owner.myPlayer.randomGen);
            if(ToDamage!=null)
            {
                ToListDamage.Add(ToDamage);
            }
        }
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
        TaskDamageTargets(ToListDamage,2);
    }
}
public class VAN_EX1_258:MinionBase{
//NAME=无羁元素
//TEXT=每当你使用一张具有<b>过载</b>的牌，便获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=2|HP=4|RACE=NONE
}
public class VAN_EX1_259:SpellBase{
//NAME=闪电风暴
//TEXT=对所有敌方随从造成$2到$3点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
    }
}
public class VAN_EX1_274:MinionBase{
//NAME=虚灵奥术师
//TEXT=在你的回合结束时，如果你控制着<b>奥秘</b>，获得+2/+2。
//MAJ=MAGE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_275:SpellBase{
//NAME=冰锥术
//TEXT=<b>冻结</b>一个随从和其相邻的随从，并对它们造成$1点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_277:SpellBase{
//NAME=奥术飞弹
//TEXT=造成$3点伤害，随机分配到所有敌方角色身上。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3);
    }
}
public class VAN_EX1_278:SpellBase{
//NAME=毒刃
//TEXT=造成$1点伤害，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_279:SpellBase{
//NAME=炎爆术
//TEXT=造成$10点伤害。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,10).Resolve();
    }
}
public class VAN_EX1_283:MinionBase{
//NAME=冰霜元素
//TEXT=<b>战吼：</b> <b>冻结</b>一个角色。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class VAN_EX1_284:MinionBase{
//NAME=碧蓝幼龙
//TEXT=<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=DRAGON
}
public class VAN_EX1_287:SecretBase{
//NAME=法术反制
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，<b>反制</b>该法术。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_287CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_287CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Spell)
        {
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            sc.SetTag(GameTag.IsCanceled,1);
        }
    }
}
public class VAN_EX1_289:SecretBase{
//NAME=寒冰护体
//TEXT=<b>奥秘：</b>当你的英雄受到攻击时，获得8点护甲值。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_294:SecretBase{
//NAME=镜像实体
//TEXT=<b>奥秘：</b>当你的对手使用一张随从牌时，召唤一个该随从的复制。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
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
            TaskCreate(sc.cardDbf,ZoneType.Board);
        }
    }
}
public class VAN_EX1_295:SecretBase{
//NAME=寒冰屏障
//TEXT=<b>奥秘：</b>当你的英雄将要承受致命伤害时，防止这些伤害，并使其在本回合中<b>免疫</b>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,EX1_132CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_132CauseEvent(Card source, Card target, int amount)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head)
        {
            if (amount >= owner.myPlayer.hero[0].GetTag(GameTag.Health))
            {
                new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
                new EffectGiveAbility(owner.myPlayer, owner, owner.myPlayer.hero[0], "ImmueForOneTurn").Resolve();
            }
        }
    }
}

public class VAN_EX1_301:MinionBase{
//NAME=恶魔卫士
//TEXT=<b>嘲讽，战吼：</b>摧毁你的一个法力水晶。
//MAJ=WARLOCK|COST=3|ATK=3|HP=5|RACE=DEMON
}
public class VAN_EX1_302:SpellBase{
//NAME=死亡缠绕
//TEXT=对一个随从造成$1点伤害。如果“死亡缠绕”消灭该随从，抽一张牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        if(target.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
        {
            TaskDraw();
        }
    }
}
public class VAN_EX1_303:SpellBase{
//NAME=暗影烈焰
//TEXT=消灭一个友方随从，对所有敌方随从造成等同于其攻击力的伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target =null)
    {
        int Num = target.GetTag(GameTag.Attack);
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,Num);
    }
}
public class VAN_EX1_304:MinionBase{
//NAME=虚空恐魔
//TEXT=<b>战吼：</b>消灭两侧相邻的随从，并获得他们的攻击力和生命值。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class VAN_EX1_306:MinionBase{
//NAME=魔犬
//TEXT=<b>战吼：</b> 随机弃一张牌。
//MAJ=WARLOCK|COST=2|ATK=4|HP=3|RACE=DEMON
}
public class VAN_EX1_308:SpellBase{
//NAME=灵魂之火
//TEXT=造成$4点伤害，随机弃一 张牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
        TaskRandomDiscard();
    }
}
public class VAN_EX1_309:SpellBase{
//NAME=灵魂虹吸
//TEXT=消灭一个随从，为你的英雄恢复#3点生命值。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_310:MinionBase{
//NAME=末日守卫
//TEXT=<b>冲锋</b>，<b>战吼：</b>随机弃两张牌。
//MAJ=WARLOCK|COST=5|ATK=5|HP=7|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        TaskRandomDiscard();
        TaskRandomDiscard();
    }
}
public class VAN_EX1_312:SpellBase{
//NAME=扭曲虚空
//TEXT=消灭所有随从。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(FindAllMin());
    }
}
public class VAN_EX1_313:MinionBase{
//NAME=深渊领主
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。
//MAJ=WARLOCK|COST=4|ATK=5|HP=6|RACE=DEMON
}
public class VAN_EX1_315:MinionBase{
//NAME=召唤传送门
//TEXT=你的随从牌的法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=WARLOCK|COST=4|ATK=0|HP=4|RACE=NONE
}
public class VAN_EX1_316:SpellBase{
//NAME=力量的代价
//TEXT=使一个友方随从获得+4/+4，该随从会在回合结束时死亡。死得很惨。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_317:SpellBase{
//NAME=感知恶魔
//TEXT=从你的牌库中抽两张恶魔牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn = TaskDrawRace(RaceType.Demon);
        if(Drawn==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
        Card Drawn2 = TaskDrawRace(RaceType.Demon);
        if(Drawn2==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
    }
}
public class VAN_EX1_319:MinionBase{
//NAME=烈焰小鬼
//TEXT=<b>战吼：</b>对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=3|HP=2|RACE=DEMON
    public override void Battlecry(Card target=null)
    {
        TaskDamageMyHero(3);
    }
}
public class VAN_EX1_320:SpellBase{
//NAME=末日灾祸
//TEXT=对一个角色造成$2点伤害。如果“末日灾祸”消灭该角色，随机召唤一个恶魔。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_323:MinionBase{
//NAME=加拉克苏斯大王
//TEXT=<b>战吼：</b>消灭你的英雄，并用加拉克苏斯大王替换之。
//MAJ=WARLOCK|COST=9|ATK=3|HP=15|RACE=DEMON
}
public class VAN_EX1_332:SpellBase{
//NAME=沉默
//TEXT=<b>沉默</b>一个随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_334:SpellBase{
//NAME=暗影狂乱
//TEXT=直到回合结束，获得一个攻击力小于或等于3的敌方随从的控制权。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_335:MinionBase{
//NAME=光耀之子
//TEXT=本随从的攻击力始终等同于其生命值。
//MAJ=PRIEST|COST=4|ATK=0|HP=5|RACE=NONE
}
public class VAN_EX1_339:SpellBase{
//NAME=思维窃取
//TEXT=复制你对手的牌库中的两张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        for(int i=0;i<2;i++)
        {
            Card ToCopy = owner.myPlayer.otherPlayer.deck.Choice(owner.myPlayer.randomGen);
            if(ToCopy!=null)
                TaskCreate(ToCopy.cardDbf,ZoneType.Hand);
        }
    }
}
public class VAN_EX1_341:MinionBase{
//NAME=光明之泉
//TEXT=在你的回合开始时，随机为一个受伤的 友方角色恢复#3点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=5|RACE=NONE
}
public class VAN_EX1_345:SpellBase{
//NAME=控心术
//TEXT=随机将你对手的牌库中的一张随从牌的复制置入战场。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_345t:MinionBase{
//NAME=空无之影
//TEXT=控心术无效！你对手的牌库中没有 随从牌了！
//MAJ=PRIEST|COST=0|ATK=0|HP=1|RACE=NONE
}
public class VAN_EX1_349:SpellBase{
//NAME=神恩术
//TEXT=抽若干数量的牌，直到你的手牌数量等同于你对手的手牌数量。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        while(true)
        {
            if(owner.myPlayer.deck.Count==0)
            {
                break;
            }
            if(owner.myPlayer.hand.Count>=owner.myPlayer.otherPlayer.hand.Count)
            {
                break;
            }
            TaskDraw();
        }
    }
}
public class VAN_EX1_350:MinionBase{
//NAME=先知维伦
//TEXT=使你的法术和英雄技能的伤害和治疗效果翻倍。
//MAJ=PRIEST|COST=7|ATK=7|HP=7|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return ((c.cardType==CardType.Spell||c.cardType==CardType.HeroPower) && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAN_EX1_350e";
    }
}
public class VAN_EX1_350e:SpellBase
{
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.DamageEffMod)
        {
            return 1;
        }
        return 0;
    }
}
public class VAN_EX1_354:SpellBase{
//NAME=圣疗术
//TEXT=恢复#8点生命值，抽三张牌。
//MAJ=PALADIN|COST=8|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_355:SpellBase{
//NAME=受祝福的勇士
//TEXT=使一个随从的攻击力翻倍。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_360:SpellBase{
//NAME=谦逊
//TEXT=使一个随从的攻击力变为1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_362:MinionBase{
//NAME=银色保卫者
//TEXT=<b>战吼：</b>使一个其他友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_363:SpellBase{
//NAME=智慧祝福
//TEXT=选择一个随从，每当其进行攻击，便抽一张牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_365:SpellBase{
//NAME=神圣愤怒
//TEXT=抽一张牌，并造成等同于其法力值消耗的伤害。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card c = TaskDraw();
        new EffectDamage(owner.myPlayer,owner,target,c.GetTag(GameTag.Mana)).Resolve();
    }
}
public class VAN_EX1_366:WeaponBase{
//NAME=公正之剑
//TEXT=在你召唤一个随从后，使其获得+1/+1，这把武器失去1点耐久度。
//MAJ=PALADIN|COST=3|ATK=1|HP=5|RACE=NONE
}
public class VAN_EX1_371:SpellBase{
//NAME=保护之手
//TEXT=使一个随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_379:SecretBase{
//NAME=忏悔
//TEXT=<b>奥秘：</b> 在你的对手使用一张随从牌后，使该随从的生命值降为1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_382:MinionBase{
//NAME=奥尔多卫士
//TEXT=<b>战吼：</b>使一个敌方随从的攻击力变为1。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1-target.GetTag(GameTag.Attack)).Resolve();
    }
}
public class VAN_EX1_383:MinionBase{
//NAME=提里奥·弗丁
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>亡语：</b>装备一把5/3的 灰烬使者。
//MAJ=PALADIN|COST=8|ATK=6|HP=6|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_383t"),ZoneType.Weapon);
    }
}
public class VAN_EX1_384:SpellBase{
//NAME=复仇之怒
//TEXT=造成$8点伤害，随机分配到所有敌方角色身上。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_390:MinionBase{
//NAME=牛头人战士
//TEXT=<b>嘲讽</b>，<b>激怒：</b> +3攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_391:SpellBase{
//NAME=猛击
//TEXT=对一个随从造成$2点伤害，如果 它依然存活，则抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_392:SpellBase{
//NAME=战斗怒火
//TEXT=每有一个受伤的友方角色，便抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int DamageCnt=0;
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.hero))
        {
            if(c.GetTag(GameTag.Damage)>0)
            {
                DamageCnt+=1;
            }
        }
        for(int i =0;i<DamageCnt;i++)
        {
            TaskDraw();
        }
    }
}
public class VAN_EX1_393:MinionBase{
//NAME=阿曼尼狂战士
//TEXT=<b>激怒：</b>+3攻击力
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class VAN_EX1_396:MinionBase{
//NAME=魔古山守望者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=NONE
}
public class VAN_EX1_398:MinionBase{
//NAME=阿拉希武器匠
//TEXT=<b>战吼：</b>装备一把2/2的武器。
//MAJ=WARRIOR|COST=4|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_399:MinionBase{
//NAME=古拉巴什狂暴者
//TEXT=每当本随从受到伤害，获得+3攻击力。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=7|RACE=NONE
}
public class VAN_EX1_400:SpellBase{
//NAME=旋风斩
//TEXT=对所有随从造成$1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class VAN_EX1_402:MinionBase{
//NAME=铸甲师
//TEXT=每当一个友方随从受到伤害，便获得1点护甲值。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            if(amount>0)
            {
                TaskBuffMyHero(arm:1);
            }
        }
    }
}
public class VAN_EX1_405:MinionBase{
//NAME=持盾卫士
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=NONE
}
public class VAN_EX1_407:SpellBase{
//NAME=绝命乱斗
//TEXT=随机选择一个随从，消灭除了该随从外的所有其他随从。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_408:SpellBase{
//NAME=致死打击
//TEXT=造成$4点伤害；如果你的生命值小于或等于12点，则改为造成$6点伤害。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_409:SpellBase{
//NAME=升级
//TEXT=如果你装备着武器，使其获得+1/+1。否则装备一把1/3的武器。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        if (owner.myPlayer.weapon.Count == 0)
        {
            new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("EX1_409t"), owner.myPlayer), ZoneType.Weapon).Resolve();
            //new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], atkChange: 1).Resolve();
        }
        else
        {
            new EffectChange(owner.myPlayer,owner, owner.myPlayer.weapon[0], atkChange: 1, hpChange: 1).Resolve();
            new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], atkChange: 1).Resolve();
        }
    }
}
public class VAN_EX1_410:SpellBase{
//NAME=盾牌猛击
//TEXT=你每有1点护甲值，便对一个随从造成1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_411:WeaponBase{
//NAME=血吼
//TEXT=攻击随从不会消耗耐久度，改为降低1点攻击力。
//MAJ=WARRIOR|COST=7|ATK=7|HP=1|RACE=NONE
}
public class VAN_EX1_412:MinionBase{
//NAME=暴怒的狼人
//TEXT=<b>激怒：</b>+1攻击力并具有<b>风怒</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Init()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,2);
        owner.SetTag(GameTag.AttacksLeftThisTurn,2);//TaskInitAbility("WindFury");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            if(owner.GetTag(GameTag.Damage)>0)
            {
                return 1;
            }
        }
        return 0;
    }
}
public class VAN_EX1_414:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<b>冲锋</b> <b>激怒：</b>+6攻击力
//MAJ=WARRIOR|COST=8|ATK=4|HP=9|RACE=NONE
}
public class VAN_EX1_506:MinionBase{
//NAME=鱼人猎潮者
//TEXT=<b>战吼：</b>召唤一个1/1的鱼人斥候。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
}
public class VAN_EX1_506a:MinionBase{
//NAME=鱼人斥候
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=MURLOC
}
public class VAN_EX1_507:MinionBase{
//NAME=鱼人领军
//TEXT=所有其他鱼人拥有+2/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MURLOC
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Murloc) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAN_EX1_507e";
    }
}
public class VAN_EX1_507e:Ability{
//NAME=姆若咯啦啊咯啦！
//TEXT=鱼人领军使其获得+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        if(tg==GameTag.HealthMod)
        {
            return 1;
        }
        return 0;
    }
}
public class VAN_EX1_508:MinionBase{
//NAME=暗鳞先知
//TEXT=所有其他鱼人拥有+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Murloc) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_508o";
    }
}
public class VAN_EX1_509:MinionBase{
//NAME=鱼人招潮者
//TEXT=每当有玩家召唤一个鱼人，便获得 +1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
}
public class VAN_EX1_522:MinionBase{
//NAME=耐心的刺客
//TEXT=<b>潜行</b>。消灭任何受到本随从伤害的随从。
//MAJ=ROGUE|COST=2|ATK=1|HP=1|RACE=NONE
}
public class VAN_EX1_531:MinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方野兽死亡，便获得+2/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class VAN_EX1_533:SecretBase{
//NAME=误导
//TEXT=<b>奥秘：</b>当一个敌人攻击你的英雄时，改为该敌人随机攻击另一个角色。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_534:MinionBase{
//NAME=长鬃草原狮
//TEXT=<b>亡语：</b>召唤两只2/2的土狼。
//MAJ=HUNTER|COST=6|ATK=6|HP=5|RACE=BEAST
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("EX1_534t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class VAN_EX1_536:WeaponBase{
//NAME=鹰角弓
//TEXT=每当一个<b>奥秘</b>被揭示时，便获得+1耐久度。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class VAN_EX1_537:SpellBase{
//NAME=爆炸射击
//TEXT=对一个随从造成$5点伤害，并对其相邻的随从造成 $2点伤害。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_538:SpellBase{
//NAME=关门放狗
//TEXT=战场上每有一个敌方随从，便召唤一个 1/1并具有<b>冲锋</b>的猎犬。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num=owner.myPlayer.otherPlayer.board.Count;
        for(int i=0;i<Num;i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_538t"),ZoneType.Board);
        }
    }
}
public class VAN_EX1_539:SpellBase{
//NAME=杀戮命令
//TEXT=造成$3点伤害。如果你控制一个野兽，则改为造成 $5点伤害。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int dmg=3;
        if(CondCtrlAnotherRace(RaceType.Beast))
        {
            dmg=5;
        }
        new EffectDamage(owner.myPlayer,owner,target,dmg).Resolve();
    }
}
public class VAN_EX1_543:MinionBase{
//NAME=暴龙王克鲁什
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=9|ATK=8|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class VAN_EX1_544:SpellBase{
//NAME=照明弹
//TEXT=所有随从失去<b>潜行</b>，摧毁所有敌方<b>奥秘</b>，抽一张牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(owner.myPlayer.otherPlayer.head);
        TaskDraw();
    }
}
public class VAN_EX1_549:SpellBase{
//NAME=狂野怒火
//TEXT=在本回合中，使一个野兽获得+2攻击力和<b>免疫</b>。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_554:SecretBase{
//NAME=毒蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤三条1/1的蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_554t:MinionBase{
//NAME=蛇
//TEXT=
//MAJ=HUNTER|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class VAN_EX1_556:MinionBase{
//NAME=麦田傀儡
//TEXT=<b>亡语：</b>召唤一个2/1的损坏的傀儡。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class VAN_EX1_557:MinionBase{
//NAME=纳特·帕格
//TEXT=在你的回合开始时，你有50%的几率额外抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class VAN_EX1_558:MinionBase{
//NAME=哈里森·琼斯
//TEXT=<b>战吼：</b>摧毁对手的武器，并抽数量等同于其耐久度的牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class VAN_EX1_559:MinionBase{
//NAME=大法师安东尼达斯
//TEXT=每当你施放一个法术，将一张“火球术”法术牌置入你的手牌。
//MAJ=MAGE|COST=7|ATK=5|HP=7|RACE=NONE
}
public class VAN_EX1_560:MinionBase{
//NAME=诺兹多姆
//TEXT=玩家只有15秒的时间来进行他们的回合。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class VAN_EX1_561:MinionBase{
//NAME=阿莱克丝塔萨
//TEXT=<b>战吼：</b> 将一方英雄的剩余生命值变为15。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,hpChange:15-target.GetTag(GameTag.Health)).Resolve();
    }
}
public class VAN_EX1_562:MinionBase{
//NAME=奥妮克希亚
//TEXT=<b>战吼：</b>召唤数条1/1的雏龙，直到你的随从数量达到上限。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}

public class VAN_EX1_564:MinionBase{
//NAME=无面操纵者
//TEXT=<b>战吼：</b>选择一个随从，成为它的复制。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_565:MinionBase{
//NAME=火舌图腾
//TEXT=相邻的随从拥有+2攻击力。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class VAN_EX1_567:WeaponBase{
//NAME=毁灭之锤
//TEXT=<b>风怒，过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=2|HP=8|RACE=NONE
}
public class VAN_EX1_570:SpellBase{
//NAME=撕咬
//TEXT=使你的英雄获得4点护甲值，并在本回合中获得 +4攻击力。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_571:SpellBase{
//NAME=自然之力
//TEXT=召唤三个2/2并具有<b>冲锋</b>的树人，在回合结束时，消灭这些树人。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}

public class VAN_EX1_573:MinionBase{
//NAME=塞纳留斯
//TEXT=<b>抉择：</b>使你的所有其他随从获得+2/+2；或者召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=DRUID|COST=9|ATK=5|HP=8|RACE=NONE
}
public class VAN_EX1_573a:SpellBase{
//NAME=半神的恩赐
//TEXT=使你的所有其他随从获得+2/+2。
//MAJ=DRUID|COST=9|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_573b:SpellBase{
//NAME=恩师的教诲
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=DRUID|COST=9|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_575:MinionBase{
//NAME=法力之潮图腾
//TEXT=在你的回合结束时，抽一张牌。
//MAJ=SHAMAN|COST=3|ATK=0|HP=3|RACE=TOTEM
}
public class VAN_EX1_577:MinionBase{
//NAME=比斯巨兽
//TEXT=<b>亡语：</b> 为你的对手召唤一个3/3的皮普·急智。
//MAJ=NEUTRAL|COST=6|ATK=9|HP=7|RACE=BEAST
}
public class VAN_EX1_578:SpellBase{
//NAME=野蛮之击
//TEXT=对一个随从造成等同于你的英雄攻击力的伤害。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_581:SpellBase{
//NAME=闷棍
//TEXT=将一个敌方随从移回你对手的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_582:MinionBase{
//NAME=达拉然法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class VAN_EX1_583:MinionBase{
//NAME=艾露恩的女祭司
//TEXT=<b>战吼：</b>为你的英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=NONE
}
public class VAN_EX1_584:MinionBase{
//NAME=年迈的法师
//TEXT=<b>战吼：</b>使相邻的随从获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class VAN_EX1_586:MinionBase{
//NAME=海巨人
//TEXT=战场上每有一个其他随从，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                return -owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Count;
            }
        }
        return 0;
    }
}
public class VAN_EX1_587:MinionBase{
//NAME=风语者
//TEXT=<b>战吼：</b>使一个友方随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=4|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_590:MinionBase{
//NAME=血骑士
//TEXT=<b>战吼：</b>所有随从失去<b>圣盾</b>。每有一个随从失去圣盾，便获得+3/+3。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_591:MinionBase{
//NAME=奥金尼灵魂祭司
//TEXT=你的恢复生命值的牌和技能改为造成等量的伤害。
//MAJ=PRIEST|COST=4|ATK=3|HP=5|RACE=NONE
}
public class VAN_EX1_593:MinionBase{
//NAME=夜刃刺客
//TEXT=<b>战吼：</b>对敌方英雄造成3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class VAN_EX1_594:SecretBase{
//NAME=蒸发
//TEXT=<b>奥秘：</b>当一个随从攻击你的英雄，将其消灭。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_595:MinionBase{
//NAME=诅咒教派领袖
//TEXT=在一个友方随从死亡后，抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class VAN_EX1_596:SpellBase{
//NAME=恶魔之火
//TEXT=对一个随从造成$2点伤害，如果该随从是友方恶魔，则改为使其获得+2/+2。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_597:MinionBase{
//NAME=小鬼召唤师
//TEXT=在你的回合结束时，对本随从造成1点伤害，并召唤一个1/1的 小鬼。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class VAN_EX1_598:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class VAN_EX1_603:MinionBase{
//NAME=严酷的监工
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_604:MinionBase{
//NAME=暴乱狂战士
//TEXT=每当一个随从 受到伤害，便获得+1攻击力。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class VAN_EX1_606:SpellBase{
//NAME=盾牌格挡
//TEXT=获得5点护甲值。抽一张牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:5);
        TaskDraw();
    }
}
public class VAN_EX1_607:SpellBase{
//NAME=怒火中烧
//TEXT=对一个随从造成$1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
    }
}
public class VAN_EX1_608:MinionBase{
//NAME=巫师学徒
//TEXT=你的法术的法力值消耗减少（1）点。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardType==CardType.Spell &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAN_EX1_608e";
    }
}
public class VAN_EX1_608e:Ability{
//NAME=呀！
//TEXT=+1/+1。
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
public class VAN_EX1_609:SecretBase{
//NAME=狙击
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$4点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
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
            new EffectDamage(owner.myPlayer,owner, sc, 4).Resolve();
        }
    }
}
public class VAN_EX1_610:SecretBase{
//NAME=爆炸陷阱
//TEXT=<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_611:SecretBase{
//NAME=冰冻陷阱
//TEXT=<b>奥秘：</b>当一个敌方随从攻击时，将其移回拥有者的手牌，并且法力值消耗增加（2）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackBeforeAttack(this,EX1_611CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_611CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Minion)
        {
            sc.SetTag(GameTag.IsCanceled,1);
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            new EffectMove(owner.myPlayer.otherPlayer, sc, ZoneType.Board,ZoneType.Hand).Resolve();
            new EffectChange(owner.myPlayer.otherPlayer,owner,sc, manaChange:2).Resolve();
        }
    }
}
public class VAN_EX1_612:MinionBase{
//NAME=肯瑞托法师
//TEXT=<b>战吼：</b> 在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（0）点。
//MAJ=MAGE|COST=3|ATK=4|HP=3|RACE=NONE
    private bool on = false;
    public override void Battlecry(Card target = null)
    {

        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            if (c.cardType == CardType.Secret)
            {
                new EffectChange(owner.myPlayer,owner, c, -3, 0, 0, 0).Resolve();
            }
        }

    }
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_145CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_145CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc.cardType == CardType.Secret && on && sc!=owner)
        {
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (c.cardType == CardType.Secret)
                {
                    new EffectChange(owner.myPlayer,owner, c, 3, 0, 0, 0).Resolve();
                }
            }
            on = false;
        }
    }
}
public class VAN_EX1_613:MinionBase{
//NAME=艾德温·范克里夫
//TEXT=<b>连击：</b>在本回合中，使用此牌前每使用一张其他牌，便获得+2/+2。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num = owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)*2;
        new EffectChange(owner.myPlayer,owner,owner,atkChange:Num,hpChange:Num).Resolve();
    }
}
public class VAN_EX1_614:MinionBase{
//NAME=伊利丹·怒风
//TEXT=每当你使用一张牌时，召唤一个2/1的埃辛诺斯之焰。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=5|RACE=DEMON
}
public class VAN_EX1_616:MinionBase{
//NAME=法力怨魂
//TEXT=召唤所有随从的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_617:SpellBase{
//NAME=致命射击
//TEXT=随机消灭一个敌方随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class VAN_EX1_619:SpellBase{
//NAME=生而平等
//TEXT=将所有随从的生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1,hpDef:1);
    }
}
public class VAN_EX1_620:MinionBase{
//NAME=熔核巨人
//TEXT=你的英雄每受到1点伤害，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=20|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && owner.myPlayer.hero.Count>0)
            {
                return -owner.myPlayer.hero[0].GetTag(GameTag.Damage);
            }   
        }
        return 0;
    }
}
public class VAN_EX1_621:SpellBase{
//NAME=治疗之环
//TEXT=为所有随从恢复#4点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_622:SpellBase{
//NAME=暗言术：灭
//TEXT=消灭一个攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_623:MinionBase{
//NAME=圣殿执行者
//TEXT=<b>战吼：</b>使一个友方随从获得+3生命值。
//MAJ=PRIEST|COST=6|ATK=6|HP=6|RACE=NONE
}
public class VAN_EX1_624:SpellBase{
//NAME=神圣之火
//TEXT=造成$5点伤害。为你的英雄恢复#5点生命值。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_625:SpellBase{
//NAME=暗影形态
//TEXT=你的英雄技能变为“造成2点伤害”，如果已经处于暗影形态下：改为“造成3点伤害”。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_626:SpellBase{
//NAME=群体驱散
//TEXT=<b>沉默</b>所有敌方随从，抽一张牌。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_finkle:MinionBase{
//NAME=皮普·急智
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAN_EX1_tk11:MinionBase{
//NAME=幽灵狼
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class VAN_EX1_tk28:MinionBase{
//NAME=松鼠
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class VAN_EX1_tk29:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class VAN_EX1_tk31:Ability{
//NAME=精神控制
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_tk33:HeroPowerBase{
//NAME=地狱火！
//TEXT=<b>英雄技能</b> 召唤一个6/6的 地狱火。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_EX1_tk34:MinionBase{
//NAME=地狱火
//TEXT=
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class VAN_EX1_tk9:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class VAN_EX1_tk9b:MinionBase{
//NAME=树人
//TEXT=<b>冲锋</b>，在回合结束时，消灭本随从。
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class VAN_GAME_001:Ability{
//NAME=幸运币祝福
//TEXT=后手出牌会使你的生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GAME_002:MinionBase{
//NAME=幸运币化身
//TEXT=<i>你失去了先手，但比赛依然掌握在 你的手里。</i>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class VAN_GAME_003:Ability{
//NAME=幸运币复仇
//TEXT=后手出牌会使你的第一个随从获得增强。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GAME_004:Ability{
//NAME=挂机
//TEXT=你的回合时间减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GAME_006:SpellBase{
//NAME=不不不
//TEXT=出于某种原因，你曾经拥有的一张牌被删除了。拿着这张牌吧，它将成为那张牌的替代品！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_GAME_011:Ability{
//NAME=锦标赛简要流程
//TEXT=你的回合时间减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_001e:Ability{
//NAME=Cost = 1
//TEXT=Costs (1).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_002e:Ability{
//NAME=Cost - 2
//TEXT=Costs (2) less.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_003e:Ability{
//NAME=Cost - 1
//TEXT=Costs (1) less.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_004e:Ability{
//NAME=Cost - 3
//TEXT=Costs (3) less.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_005e:Ability{
//NAME=Cost + 2
//TEXT=Costs (2) more.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_006e:Ability{
//NAME=Cost = 2
//TEXT=Costs (2).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_007e:Ability{
//NAME=Cost = 10
//TEXT=Costs (10).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_008e:Ability{
//NAME=Cost - 4
//TEXT=Costs (4) less.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_009e:Ability{
//NAME=Cost = 0
//TEXT=Costs (0).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_GBL_010e:Ability{
//NAME=Cost = 3
//TEXT=Costs (3).
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_01bp:HeroPowerBase{
//NAME=全副武装！
//TEXT=<b>英雄技能</b> 获得2点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_01bp2:HeroPowerBase{
//NAME=坚壁
//TEXT=<b>英雄技能</b> 获得4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_02bp:HeroPowerBase{
//NAME=图腾召唤
//TEXT=<b>英雄技能</b> 随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_02bp2:HeroPowerBase{
//NAME=图腾崇拜
//TEXT=<b>英雄技能</b> 召唤一个你想要的图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_02e2:Ability{
//NAME=大地之力
//TEXT=+1攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_03bp:HeroPowerBase{
//NAME=匕首精通
//TEXT=<b>英雄技能</b> 装备一把1/2的 匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_03bp2:HeroPowerBase{
//NAME=浸毒匕首
//TEXT=<b>英雄技能</b> 装备一把2/2的 匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_04bp:HeroPowerBase{
//NAME=后援不断
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_04bp2:HeroPowerBase{
//NAME=白银之手
//TEXT=<b>英雄技能</b> 召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_05bp:HeroPowerBase{
//NAME=稳固射击
//TEXT=<b>英雄技能</b> 对敌方英雄造成$2点伤害。0<b>英雄技能</b> 造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_05bp2:HeroPowerBase{
//NAME=弩炮射击
//TEXT=<b>英雄技能</b> 对敌方英雄造成$3点伤害。0<b>英雄技能</b> 造成$3点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_06bp:HeroPowerBase{
//NAME=变形
//TEXT=<b>英雄技能</b> 本回合+1攻击力。+1护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_06bp2:HeroPowerBase{
//NAME=恐怖变形
//TEXT=<b>英雄技能</b> 本回合+2攻击力。+2护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_07bp:HeroPowerBase{
//NAME=生命分流
//TEXT=<b>英雄技能</b> 抽一张牌并受到$2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_07bp2:HeroPowerBase{
//NAME=灵魂分流
//TEXT=<b>英雄技能</b> 抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_08bp:HeroPowerBase{
//NAME=火焰冲击
//TEXT=<b>英雄技能</b> 造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_08bp2:HeroPowerBase{
//NAME=二级火焰冲击
//TEXT=<b>英雄技能</b> 造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_09bp:HeroPowerBase{
//NAME=次级治疗术
//TEXT=<b>英雄技能</b> 恢复#2点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_09bp2:HeroPowerBase{
//NAME=治疗术
//TEXT=<b>英雄技能</b> 恢复#4点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_09e1:Ability{
//NAME=次级坚韧
//TEXT=+1生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_10bp:HeroPowerBase{
//NAME=恶魔之爪
//TEXT=<b>英雄技能</b> 在本回合中获得+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_10bp2:HeroPowerBase{
//NAME=恶魔之咬
//TEXT=<b>英雄技能</b> 在本回合中获得+2攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_10bpe:Ability{
//NAME=恶魔之爪
//TEXT=在本回合中，你的英雄拥有+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_HERO_10pe2:Ability{
//NAME=恶魔之咬
//TEXT=在本回合中，你的英雄拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_003:SpellBase{
//NAME=牺牲契约
//TEXT=消灭一个恶魔，为你的英雄恢复#5点生命值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_004:SpellBase{
//NAME=消失
//TEXT=将所有随从移回其拥有者的 手牌。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_005:MinionBase{
//NAME=劫持者
//TEXT=<b>连击：</b>将一个随从移回其拥有者的手牌。
//MAJ=ROGUE|COST=6|ATK=5|HP=3|RACE=UNDEAD
}
public class VAN_NEW1_007:SpellBase{
//NAME=星辰坠落
//TEXT=<b>抉择：</b>对一个随从造成$5点伤害；或者对所有敌方随从造成$2点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_007a:SpellBase{
//NAME=星辰漂流
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_007b:SpellBase{
//NAME=星辰领主
//TEXT=对一个随从造成$5点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_008:MinionBase{
//NAME=知识古树
//TEXT=<b>抉择：</b>抽两张牌；或者恢复#5点生命值。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=NONE
}
public class VAN_NEW1_008a:SpellBase{
//NAME=古老的教诲
//TEXT=抽两张牌。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_008b:SpellBase{
//NAME=古老的秘密
//TEXT=恢复5点生命值。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_009:MinionBase{
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
public class VAN_NEW1_010:MinionBase{
//NAME=风领主奥拉基尔
//TEXT=<b>冲锋，圣盾，嘲讽，风怒</b>
//MAJ=SHAMAN|COST=8|ATK=3|HP=5|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
        TaskInitAbility("WindFury");
    }
}
public class VAN_NEW1_011:MinionBase{
//NAME=库卡隆精英卫士
//TEXT=<b>冲锋</b>
//MAJ=WARRIOR|COST=4|ATK=4|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class VAN_NEW1_012:MinionBase{
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
public class VAN_NEW1_014:MinionBase{
//NAME=伪装大师
//TEXT=<b>战吼：</b>使一个友方随从获得<b>潜行</b>。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class VAN_NEW1_016:MinionBase{
//NAME=船长的鹦鹉
//TEXT=<b>战吼：</b>从你的牌库中抽一张海盗牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class VAN_NEW1_017:MinionBase{
//NAME=鱼人杀手蟹
//TEXT=<b>战吼：</b>消灭一个鱼人，并获得+2/+2。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class VAN_NEW1_018:MinionBase{
//NAME=血帆袭击者
//TEXT=<b>战吼：</b> 获得等同于你的武器攻击力的攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=PIRATE
}
public class VAN_NEW1_019:MinionBase{
//NAME=飞刀杂耍者
//TEXT=在你召唤一个随从后，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class VAN_NEW1_020:MinionBase{
//NAME=狂野炎术师
//TEXT=在你施放一个法术后，对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
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
public class VAN_NEW1_021:MinionBase{
//NAME=末日预言者
//TEXT=在你的回合开始时，消灭所有随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=7|RACE=NONE
}
public class VAN_NEW1_022:MinionBase{
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
public class VAN_NEW1_023:MinionBase{
//NAME=精灵龙
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=DRAGON
}
public class VAN_NEW1_024:MinionBase{
//NAME=绿皮船长
//TEXT=<b>战吼：</b>使你的武器获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=PIRATE
}
public class VAN_NEW1_025:MinionBase{
//NAME=血帆海盗
//TEXT=<b>战吼：</b>使对手的武器失去1点耐久度。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=PIRATE
}
public class VAN_NEW1_026:MinionBase{
//NAME=紫罗兰教师
//TEXT=每当你施放一个法术，召唤一个1/1的紫罗兰学徒。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class VAN_NEW1_026t:MinionBase{
//NAME=紫罗兰学徒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class VAN_NEW1_027:MinionBase{
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
        return "VAN_NEW1_027e";
    }
}
public class VAN_NEW1_027e:Ability{
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
public class VAN_NEW1_029:MinionBase{
//NAME=米尔豪斯·法力风暴
//TEXT=<b>战吼：</b>下个回合敌方法术的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NONE
}
public class VAN_NEW1_029e:Ability{
//NAME=好好活着，米尔豪斯！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_030:MinionBase{
//NAME=死亡之翼
//TEXT=<b>战吼：</b> 消灭所有其他随从，并弃掉你的手牌。
//MAJ=NEUTRAL|COST=10|ATK=12|HP=12|RACE=DRAGON
}
public class VAN_NEW1_031:SpellBase{
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
public class VAN_NEW1_032:MinionBase{
//NAME=米莎
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=4|RACE=BEAST
}
public class VAN_NEW1_033:MinionBase{
//NAME=雷欧克
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class VAN_NEW1_034:MinionBase{
//NAME=霍弗
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class VAN_NEW1_036:SpellBase{
//NAME=命令怒吼
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAN_NEW1_037:MinionBase{
//NAME=铸剑师
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class VAN_NEW1_038:MinionBase{
//NAME=格鲁尔
//TEXT=在每个回合结束时，获得+1/+1。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class VAN_NEW1_040:MinionBase{
//NAME=霍格
//TEXT=在你的回合结束时，召唤一个2/2并具有<b>嘲讽</b>的豺狼人。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class VAN_NEW1_041:MinionBase{
//NAME=狂奔科多兽
//TEXT=<b>战吼：</b>随机消灭一个攻击力小于或等于2的敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=BEAST
}
public class VAN_PRO_001:MinionBase{
//NAME=精英牛头人酋长
//TEXT=<b>战吼：</b>让两位玩家都具有摇滚的能力！（双方各获得一张强力和弦牌）
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class VAN_PRO_001c:SpellBase{
//NAME=部落的力量
//TEXT=随机召唤一名部落勇士。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAN_skele11:MinionBase{
//NAME=骷髅
//TEXT=<b></b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class VAN_skele21:MinionBase{
//NAME=损坏的傀儡
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class VAN_tt_004:MinionBase{
//NAME=腐肉食尸鬼
//TEXT=每当一个随从死亡，便获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class VAN_tt_010:SecretBase{
//NAME=扰咒术
//TEXT=<b>奥秘：</b>当一个敌方法术以一个随从为目标时，召唤一个1/3的随从并使其成为新的目标。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAN_tt_010a:MinionBase{
//NAME=扰咒师
//TEXT=
//MAJ=MAGE|COST=0|ATK=1|HP=3|RACE=NONE
}
public class VAN_TU4e_002t:MinionBase{
//NAME=埃辛诺斯之焰
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class tt_004:MinionBase{
//NAME=腐肉食尸鬼
//TEXT=每当一个随从死亡，便获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class tt_004o:Ability{
//NAME=野蛮残食
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class tt_010:SecretBase{
//NAME=扰咒术
//TEXT=<b>奥秘：</b>当一个敌方法术以一个随从为目标时，召唤一个1/3的随从并使其成为新的目标。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class tt_010a:MinionBase{
//NAME=扰咒师
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
}
