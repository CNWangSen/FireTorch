using System.Collections;
using System.Collections.Generic;

public class LETLT_001_01:AutoChessMinionBase{
//NAME=剃刀沼泽兽王
//TEXT=<b>亡语：</b>使所有野猪人获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=10|RACE=QUILBOAR
}
public class LETLT_001_01e:Ability{
//NAME=野猪人之怒
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_002_01:AutoChessMinionBase{
//NAME=亡首教徒
//TEXT=<b>亡语：</b>使所有野猪人获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=15|RACE=QUILBOAR
}
public class LETLT_003_01:AutoChessMinionBase{
//NAME=剃刀野猪
//TEXT=<b>亡语：</b>使所有野猪人获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=10|RACE=BEAST
}
public class LETLT_004_01:AutoChessMinionBase{
//NAME=钢鬃卫兵
//TEXT=<b>亡语：</b>使所有野猪人获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=13|RACE=QUILBOAR
}
public class LETLT_005_01:AutoChessMinionBase{
//NAME=钢鬃掠夺者
//TEXT=<b>亡语：</b>使所有野猪人获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=QUILBOAR
}
public class LETLT_006_01:AutoChessMinionBase{
//NAME=霜舌半人马
//TEXT=每当本随从受到伤害，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=CENTAUR
}
public class LETLT_007_01:AutoChessMinionBase{
//NAME=受伤的掠夺者
//TEXT=每当本角色受到伤害并存活下来后，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=CENTAUR
}
public class LETLT_008_01:AutoChessMinionBase{
//NAME=科卡尔驯犬者
//TEXT=每当本随从受到伤害，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=CENTAUR
}
public class LETLT_009_01:AutoChessMinionBase{
//NAME=乱齿土狼
//TEXT=在每个回合结束时，对所有敌人造成等同于本角色攻击力的伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_010_01:AutoChessMinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方角色死亡时，便获得+{0}/+{0}。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=8|RACE=BEAST
}
public class LETLT_010e:Ability{
//NAME=进食充分
//TEXT=+{0}/+{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_011_01:AutoChessMinionBase{
//NAME=土狼头领
//TEXT=每个回合结束时，召唤一只土狼。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_012_01:AutoChessMinionBase{
//NAME=深渊巨蟒
//TEXT=<b>流血（0）</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_013_01:AutoChessMinionBase{
//NAME=潜地蝎
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_014_01:AutoChessMinionBase{
//NAME=饥饿的秃鹫
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_015_01:AutoChessMinionBase{
//NAME=厚皮科多兽
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_016_01:AutoChessMinionBase{
//NAME=剧毒魔蝎
//TEXT=<b>流血（0）</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_017_01:AutoChessMinionBase{
//NAME=石牙野猪
//TEXT=<i><b>攻击</b>比平常更快。</i>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class LETLT_018_01:AutoChessMinionBase{
//NAME=火羽精灵
//TEXT=<b>亡语：</b>随机对一个敌人造成等同于本角色攻击力的伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_018_01t:AutoChessMinionBase{
//NAME=烈焰元素
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_019_01:AutoChessMinionBase{
//NAME=火光元素
//TEXT=在每个回合结束时，获得<b>+1火焰伤害</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_019_01e:Ability{
//NAME=燃烧
//TEXT=<b>+0火焰伤害</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_020_01:AutoChessMinionBase{
//NAME=始生保护者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_021_01:AutoChessMinionBase{
//NAME=冰川裂片
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_022_01:AutoChessMinionBase{
//NAME=禁忌古树
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=60|RACE=TREANT
}
public class LETLT_022_02:Ability{
//NAME=古树生长
//TEXT=<b>攻击</b>一个敌人。<b>连击：</b>获得+{0}/+{0}。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_022_02e:Ability{
//NAME=古树生长
//TEXT=+{0}/+{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_023_01:AutoChessMinionBase{
//NAME=知识古树
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=TREANT
}
public class LETLT_023_02:Ability{
//NAME=古树知识
//TEXT=为相邻的角色恢复0点生命值，并使其下一个技能的速度值加快（1）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_023_02e:Ability{
//NAME=古树知识
//TEXT=本角色的下一个技能速度值会加快（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_025_01:AutoChessMinionBase{
//NAME=战争古树
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=80|RACE=TREANT
}
public class LETLT_025_02:Ability{
//NAME=古树的坚韧
//TEXT=获得<b>嘲讽</b>1回合。每有一个友方角色，获得+{0}/+{0}。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_025_02e:Ability{
//NAME=古树的嘲讽
//TEXT=<b>嘲讽</b>1回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_025_02e2:Ability{
//NAME=古树的坚韧
//TEXT=+{0}/+{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_027_01:AutoChessMinionBase{
//NAME=远古之树
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=80|RACE=TREANT
}
public class LETLT_027_02:Ability{
//NAME=捕虫
//TEXT=获得<b>嘲讽</b>2回合。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LETLT_027_02e:Ability{
//NAME=捕虫
//TEXT=<b>嘲讽</b>2回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_029_01:AutoChessMinionBase{
//NAME=古树
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=80|RACE=TREANT
}
public class LETLT_030_01:AutoChessMinionBase{
//NAME=树人
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=60|RACE=TREANT
}
public class LETLT_031_01:AutoChessMinionBase{
//NAME=恐惧地狱火
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=DEMON
}
public class LETLT_031_02:Ability{
//NAME=恐惧之火
//TEXT=对所有角色造成等同于此佣兵攻击力的伤害。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_032_01:AutoChessMinionBase{
//NAME=萨特监工
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=8|HP=50|RACE=DEMON
}
public class LETLT_032_02:Ability{
//NAME=暗影鞭笞
//TEXT=<b>攻击</b>一个敌人。如果目标尚未行动，则召唤一个伊利达雷萨特。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_032_02m_01:AutoChessMinionBase{
//NAME=伊利达雷萨特1
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=1|HP=8|RACE=DEMON
}
public class LETLT_032_02m_02:AutoChessMinionBase{
//NAME=伊利达雷萨特2
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=16|RACE=DEMON
}
public class LETLT_032_02m_03:AutoChessMinionBase{
//NAME=伊利达雷萨特3
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=3|HP=24|RACE=DEMON
}
public class LETLT_032_02m_04:AutoChessMinionBase{
//NAME=伊利达雷萨特4
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=32|RACE=DEMON
}
public class LETLT_032_02m_05:AutoChessMinionBase{
//NAME=伊利达雷萨特{0}
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=40|RACE=DEMON
}
public class LETLT_033_01:AutoChessMinionBase{
//NAME=双生小鬼
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=DEMON
}
public class LETLT_033_02:Ability{
//NAME=双生
//TEXT=<b>攻击</b>一个敌人。如果本角色依然存活，召唤一个本角色的复制。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_034_01:AutoChessMinionBase{
//NAME=鲜血小鬼
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=DEMON
}
public class LETLT_034_02:Ability{
//NAME=鲜血小鬼仪式
//TEXT=使相邻的恶魔获得+0生命值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=FEL
}
public class LETLT_034_02e:Ability{
//NAME=鲜血小鬼仪式
//TEXT=+0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_035_01:AutoChessMinionBase{
//NAME=巨型小鬼
//TEXT=在一个友方恶魔死亡后，此佣兵的技能的速度值加快（1）点。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=DEMON
}
public class LETLT_035_01e:Ability{
//NAME=巨型小鬼的复仇
//TEXT=速度值加快（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_036_01:AutoChessMinionBase{
//NAME=疯狂召唤师
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=60|RACE=DEMON
}
public class LETLT_036_02:Ability{
//NAME=疯狂召唤
//TEXT=随机为你或你的对手召唤一个小鬼魔仆。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FEL
}
public class LETLT_037_01:AutoChessMinionBase{
//NAME=图尔·怒爪
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=3|HP=60|RACE=FURBOLG
}
public class LETLT_037_02:Ability{
//NAME=怒爪
//TEXT=获得+0攻击力，持续1回合，并攻击一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_037_02e:Ability{
//NAME=怒爪
//TEXT=+0攻击力，持续1回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_037_03:Ability{
//NAME=图尔的防御
//TEXT=恢复0点生命值并获得<b>嘲讽</b>1回合。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_037_03e:Ability{
//NAME=图尔的防御
//TEXT=<b>嘲讽</b>1回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_037_04:Ability{
//NAME=闪电链
//TEXT=对一个敌人造成0点伤害。并随机在相邻的敌人身上弹跳两次。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_038_01:AutoChessMinionBase{
//NAME=熊怪图腾师
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=3|HP=60|RACE=FURBOLG
}
public class LETLT_038_02:Ability{
//NAME=图腾震击
//TEXT=对一个敌人造成0点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_038_03:Ability{
//NAME=图腾召唤
//TEXT=随机召唤一个石爪图腾或治疗图腾。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_038_03m_01:AutoChessMinionBase{
//NAME=石爪图腾1
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=2|RACE=TOTEM
}
public class LETLT_038_03m_02:AutoChessMinionBase{
//NAME=石爪图腾2
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=4|RACE=TOTEM
}
public class LETLT_038_03m_03:AutoChessMinionBase{
//NAME=石爪图腾3
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=6|RACE=TOTEM
}
public class LETLT_038_03m_04:AutoChessMinionBase{
//NAME=石爪图腾4
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=8|RACE=TOTEM
}
public class LETLT_038_03m_05:AutoChessMinionBase{
//NAME=石爪图腾{0}
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=10|RACE=TOTEM
}
public class LETLT_038_04m_01:AutoChessMinionBase{
//NAME=治疗图腾1
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=0|HP=2|RACE=TOTEM
}
public class LETLT_038_04m_01p:Ability{
//NAME=治疗脉动1
//TEXT=为所有其他你的角色恢复$2点生命值。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_038_04m_02:AutoChessMinionBase{
//NAME=治疗图腾2
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=0|HP=4|RACE=TOTEM
}
public class LETLT_038_04m_02p:Ability{
//NAME=治疗脉动2
//TEXT=为所有其他你的角色恢复$4点生命值。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_038_04m_03:AutoChessMinionBase{
//NAME=治疗图腾3
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=0|HP=6|RACE=TOTEM
}
public class LETLT_038_04m_03p:Ability{
//NAME=治疗脉动3
//TEXT=为所有其他你的角色恢复$6点生命值。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_038_04m_04:AutoChessMinionBase{
//NAME=治疗图腾4
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=0|HP=8|RACE=TOTEM
}
public class LETLT_038_04m_04p:Ability{
//NAME=治疗脉动4
//TEXT=为所有其他你的角色恢复$8点生命值。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_038_04m_05:AutoChessMinionBase{
//NAME=治疗图腾{0}
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=0|HP=10|RACE=TOTEM
}
public class LETLT_038_04m_05p:Ability{
//NAME=治疗脉动{0}
//TEXT=为所有其他你的角色恢复$10点生命值。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_039_01:AutoChessMinionBase{
//NAME=巨熊怪
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=12|HP=65|RACE=FURBOLG
}
public class LETLT_039_02:Ability{
//NAME=巨熊之爪
//TEXT=<b>攻击</b>一个敌人，同时对相邻的角色造成伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_040_01:AutoChessMinionBase{
//NAME=护巢熊怪
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=8|HP=70|RACE=FURBOLG
}
public class LETLT_040_02:Ability{
//NAME=熊怪的防御
//TEXT=<b>攻击</b>一个敌人。如果目标已经行动，则使你的角色获得+0攻击力。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_040_02e:Ability{
//NAME=熊怪的防御
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_041_01:AutoChessMinionBase{
//NAME=熊怪萨满祭司
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=3|HP=60|RACE=FURBOLG
}
public class LETLT_041_02:Ability{
//NAME=熊怪的平衡
//TEXT=对一个敌人造成0点伤害。随机为一个友方角色恢复等量的生命值。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_042_01:AutoChessMinionBase{
//NAME=探路熊怪
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=12|HP=65|RACE=FURBOLG
}
public class LETLT_043_01:AutoChessMinionBase{
//NAME=熊怪战士
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=8|HP=70|RACE=FURBOLG
}
public class LETLT_043_02:Ability{
//NAME=熊怪的挑战
//TEXT=<b>攻击</b>一个敌人。如果目标尚未行动，则获得<b>嘲讽</b>1回合。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_043_02e:Ability{
//NAME=熊怪的挑战
//TEXT=<b>嘲讽</b>1回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_044_01:AutoChessMinionBase{
//NAME=狂暴的枭兽
//TEXT=在每个回合结束时随机攻击。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_044_02:Ability{
//NAME=枭兽暴怒
//TEXT=<b>攻击</b>一个敌人，然后获得+3攻击力。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_044_02e:Ability{
//NAME=枭兽暴怒
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_045_01:AutoChessMinionBase{
//NAME=疯癫的枭兽
//TEXT=在每个回合结束时随机攻击。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_045_02:Ability{
//NAME=风狂嚎叫
//TEXT=在本回合中使所有友方角色获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LETLT_045_02e:Ability{
//NAME=乘风狂舞
//TEXT=<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_048_01:AutoChessMinionBase{
//NAME=霜刃捕食者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_048_02:Ability{
//NAME=裂伤
//TEXT=<b>攻击</b>一个敌人。直到目标被治疗，造成的伤害会在每个回合结束时重复。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_048_02e:Ability{
//NAME=裂伤
//TEXT=当回合结束时，造成0点伤害。<i>（受到治疗可移除。）</i>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_050_01:AutoChessMinionBase{
//NAME=辟法奇美拉
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_050_02:Ability{
//NAME=腐蚀喷吐
//TEXT=<b>流血（1）</b>
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_050_02e:Ability{
//NAME=腐蚀喷吐
//TEXT=在每个回合结束时受到0点伤害，直到被治疗。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_050_03:Ability{
//NAME=飞翼扑击
//TEXT=造成16点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_051_01:AutoChessMinionBase{
//NAME=冰封雄鹿守卫
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=1|HP=99|RACE=ELEMENTAL
}
public class LETLT_051_02:Ability{
//NAME=烈性难驯
//TEXT=随机对四到五个敌人造成$1-$3点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_051_03:Ability{
//NAME=诡谲突击
//TEXT=<b>攻击</b>一个敌人，并使目标的攻击力变为你的。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LETLT_051_03e:Ability{
//NAME=诡异
//TEXT=攻击力已变化。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_052_01:AutoChessMinionBase{
//NAME=冰风雪人
//TEXT=在每个回合结束时随机攻击。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_052_02:Ability{
//NAME=野蛮
//TEXT=在本回合中获得+3攻击力，并<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_052_02e:Ability{
//NAME=Savage Might
//TEXT=+0 Attack.
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_052_03:Ability{
//NAME=冰风吼叫
//TEXT=在本回合中，将所有具有<b>嘲讽</b>的敌人的攻击力变为0点。<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_052_03e:Ability{
//NAME=冰风吼叫
//TEXT=攻击力变为0点。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_053_01:AutoChessMinionBase{
//NAME=碎齿熊
//TEXT=在每个回合结束时随机攻击。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_053_02:Ability{
//NAME=摄人追击
//TEXT=<b>攻击</b>一个敌人。使所有敌人失去<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_054_01:AutoChessMinionBase{
//NAME=铁喙猫头鹰
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_054_02:Ability{
//NAME=飞掠攻击
//TEXT=<b>攻击</b>一个敌人，<b>攻击</b>时<b>免疫</b>。然后使你的所有角色获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class LETLT_054_02e_1:Ability{
//NAME=援助
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_054_02e_2:Ability{
//NAME=Flyby Immunity
//TEXT=<b>Immune</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_055_01:AutoChessMinionBase{
//NAME=霜刃裂片
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_055_02:Ability{
//NAME=骇人齐射
//TEXT=对两至三名敌人各造成$1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FROST
}
public class LETLT_055_03:Ability{
//NAME=冰刃锋缘
//TEXT=获得<b>+3冰霜伤害</b>。<b>火焰伤害</b>会移除此效果。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_055_03e:Ability{
//NAME=四季争雄
//TEXT=<b>+0冰霜伤害。</b><b>火焰伤害</b>会移除此效果。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_056_01:AutoChessMinionBase{
//NAME=残暴的林鬼
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_056_02:Ability{
//NAME=林鬼雪球
//TEXT=造成$5点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FROST
}
public class LETLT_056_03:Ability{
//NAME=寒冬集结
//TEXT=获得<b>+3冰霜伤害</b>。<b>火焰伤害</b>会移除此效果。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_057_01:AutoChessMinionBase{
//NAME=霜刃屠戮者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_057_02:Ability{
//NAME=粉碎冰旋
//TEXT=在本回合中提高等同于<b>冰霜伤害</b>的攻击力。<b>攻击</b>两个不同的敌人。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=FROST
}
public class LETLT_057_02e:Ability{
//NAME=Shredding Spiral
//TEXT=+0 Attack.
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_058_01:AutoChessMinionBase{
//NAME=狂怒风雪
//TEXT=在每个回合结束时获得等同于<b>冰霜伤害</b>的攻击力。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_058_02:Ability{
//NAME=积聚力量
//TEXT=<b>攻击</b>一个敌人。获得+1<b>冰霜伤害</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=FROST
}
public class LETLT_058_02e:Ability{
//NAME=Massive Ice
//TEXT=+0 Attack.
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_059_01:AutoChessMinionBase{
//NAME=活体冰霜之墙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_059_02:Ability{
//NAME=先行屠灭
//TEXT=获得<b>嘲讽</b>。如果本角色已经拥有<b>嘲讽</b>，则对所有敌人造成$5点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=FROST
}
public class LETLT_059_02e:Ability{
//NAME=冻结壁垒
//TEXT=<b>嘲讽</b>。此效果只有<b>火焰伤害</b>可以解除。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_060_01:AutoChessMinionBase{
//NAME=冰吼寒流
//TEXT=在每个回合结束时，对所有已被<b>冻结</b>的敌人造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_060_01e:Ability{
//NAME=寒冰之噬
//TEXT=回合结束时，对所有已被<b>冻结</b>的敌人造成<b>3点冰霜伤害</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_060_02:Ability{
//NAME=刺骨之寒
//TEXT=<b>攻击</b>一个敌人，并对其相邻敌人造成$3点伤害。<b>冻结</b>其中在本回合中未使用过火焰技能的敌人。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=FROST
}
public class LETLT_060_02e:Ability{
//NAME=Frozen
//TEXT=<b>Frozen</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_060_03:Ability{
//NAME=饥饿寒冰
//TEXT=所有友方角色会<b>冻结</b>伤害的敌人。<b>火焰伤害</b>会终结此效果。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FROST
}
public class LETLT_060_03e:Ability{
//NAME=饥饿寒冰
//TEXT=<b>冻结</b>受到本角色伤害的敌人。<b>火焰伤害</b>会终结此效果。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_061_01:AutoChessMinionBase{
//NAME=巨大的枭兽
//TEXT=在每个回合结束时随机攻击。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_070_01:AutoChessMinionBase{
//NAME=龙蛋
//TEXT=<b>亡语：</b>如果你控制一个非龙蛋角色，则召唤一条破壳雏龙。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=1|RACE=EGG
}
public class LETLT_070m_01:AutoChessMinionBase{
//NAME=破壳雏龙1
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=DRAGON
}
public class LETLT_070m_02:AutoChessMinionBase{
//NAME=破壳雏龙2
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class LETLT_070m_03:AutoChessMinionBase{
//NAME=破壳雏龙3
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=DRAGON
}
public class LETLT_070m_04:AutoChessMinionBase{
//NAME=破壳雏龙4
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=DRAGON
}
public class LETLT_070m_05:AutoChessMinionBase{
//NAME=破壳雏龙{0}
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=10|HP=10|RACE=DRAGON
}
public class LETLT_071_01:AutoChessMinionBase{
//NAME=龙王配偶
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=12|HP=40|RACE=DRAGON
}
public class LETLT_071p1_01:Ability{
//NAME=充能打击
//TEXT=<b>攻击</b>一个敌人。其他友方龙的下一个技能速度值加快（0）点。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_071p1e:Ability{
//NAME=充能
//TEXT=本角色的下一个技能速度值会加快（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_072_01:AutoChessMinionBase{
//NAME=饥饿的巨龙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=12|HP=40|RACE=DRAGON
}
public class LETLT_072p1_01:Ability{
//NAME=喂食时间
//TEXT=<b>攻击</b>生命值最低的敌人。<b>击杀：</b>恢复0点生命值。
//MAJ=NEUTRAL|COST=9|ATK=0|HP=0|RACE=NONE
}
public class LETLT_072p2_01:Ability{
//NAME=布置餐桌
//TEXT=为你的对手召唤一个巨龙餐点。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_072p2e:Ability{
//NAME=巨龙餐点
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_072p2m_01:AutoChessMinionBase{
//NAME=巨龙餐点1
//TEXT=<b>亡语：</b>消灭本角色的角色获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=2|RACE=BEAST
}
public class LETLT_072p2m_02:AutoChessMinionBase{
//NAME=巨龙餐点2
//TEXT=<b>亡语：</b>消灭本角色的角色获得+4攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=BEAST
}
public class LETLT_072p2m_03:AutoChessMinionBase{
//NAME=巨龙餐点3
//TEXT=<b>亡语：</b>消灭本角色的角色获得+6攻击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=BEAST
}
public class LETLT_072p2m_04:AutoChessMinionBase{
//NAME=巨龙餐点4
//TEXT=<b>亡语：</b>消灭本角色的角色获得+8攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=8|RACE=BEAST
}
public class LETLT_072p2m_05:AutoChessMinionBase{
//NAME=巨龙餐点{0}
//TEXT=<b>亡语：</b>消灭本角色的角色获得+10攻击力。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=10|RACE=BEAST
}
public class LETLT_073_01:AutoChessMinionBase{
//NAME=龙人打击者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=9|HP=60|RACE=DRAGON
}
public class LETLT_073p1_01:Ability{
//NAME=龙人打击
//TEXT=<b>攻击</b>一个敌人。如果目标的生命值更低，则先获得+{0}/+{0}。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_073p1e:Ability{
//NAME=龙人打击
//TEXT=+{0}/+{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_074_01:AutoChessMinionBase{
//NAME=龙人巫师
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=6|HP=30|RACE=DRAGON
}
public class LETLT_074p1_01:Ability{
//NAME=巫术之火
//TEXT=造成$0点伤害。<b>火焰连击：</b>先获得<b>+1火焰伤害</b>。
//MAJ=NEUTRAL|COST=9|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_074p1e:Ability{
//NAME=巫术充能
//TEXT=+1火焰伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_075_01:AutoChessMinionBase{
//NAME=暮光雏龙
//TEXT=如果有其他友方的龙，则在每个回合结束时获得+0生命值。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=10|RACE=DRAGON
}
public class LETLT_075e:Ability{
//NAME=暮光生长
//TEXT=+0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_076_01:AutoChessMinionBase{
//NAME=火山幼龙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=12|HP=40|RACE=DRAGON
}
public class LETLT_076p1_01:Ability{
//NAME=火山之焰
//TEXT=随机对一个敌人造成$0点伤害。在本局对战中每有一个角色死亡，重复一次。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_077_01:AutoChessMinionBase{
//NAME=精灵龙
//TEXT=以精灵龙为目标的技能改为随机选择目标。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=30|RACE=DRAGON
}
public class LETLT_080_01:AutoChessMinionBase{
//NAME=上古熔火恶犬
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=BEAST
}
public class LETLT_080_01e:Ability{
//NAME=玛格曼达的恩赐
//TEXT=当其他熔火恶犬存活时，无法被消灭。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_080_01e2:Ability{
//NAME=阴燃
//TEXT=0回合后复活。当没有其他熔火恶犬存活时会被消灭。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_080_02:Ability{
//NAME=炽灼巨口
//TEXT=<b>攻击</b>一个敌人。直到下回合结束，使其速度值减慢（3）点，且无法被治疗。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_080_02e:Ability{
//NAME=炽灼巨口
//TEXT=速度值减慢（3）点且无法被治疗。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_080_03:Ability{
//NAME=上古绝望
//TEXT=为所有本回合中施放过的敌方技能增加2回合的冷却。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_081_01:AutoChessMinionBase{
//NAME=熔核巨人
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_081_02:Ability{
//NAME=重击
//TEXT=对一个敌人及一个相邻的角色造成等同于此佣兵攻击力的伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_081_03:Ability{
//NAME=岩石与火焰之盾
//TEXT=获得<b>嘲讽</b>。在本回合中，每次受到攻击前，攻击力翻倍。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_081_03e:Ability{
//NAME=岩石与火焰之盾
//TEXT=获得<b>嘲讽</b>。在本回合中，每次受到攻击前，攻击力翻倍。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_081_03e2:Ability{
//NAME=岩石与火焰之盾
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_082_01:AutoChessMinionBase{
//NAME=火焰领主
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_082_03:Ability{
//NAME=召唤熔岩爪牙
//TEXT=召唤一或两个会在回合结束时随机攻击并死亡的熔岩爪牙。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_082_04:AutoChessMinionBase{
//NAME=熔岩爪牙
//TEXT=在回合结束时随机攻击，然后死亡。
//MAJ=NEUTRAL|COST=4|ATK=9|HP=5|RACE=ELEMENTAL
}
public class LETLT_083_01:AutoChessMinionBase{
//NAME=火誓者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_083_02:Ability{
//NAME=献祭
//TEXT=对一个敌人造成$8点伤害。在下两个回合结束时，重复此伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_083_02e:Ability{
//NAME=献祭
//TEXT=在回合结束时受到{0}点火焰伤害。<i>（还剩{1}点。）</i>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_083_03:Ability{
//NAME=剧烈爆发
//TEXT=对本回合中已经行动过的敌人造成10点伤害。在下一场战斗开始时，重复此伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_083_03e:Ability{
//NAME=溅射岩浆
//TEXT=在下一场战斗开始时受到$10点火焰伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_084_01:AutoChessMinionBase{
//NAME=火妖哨兵
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_084_02:Ability{
//NAME=火妖三叉戟
//TEXT=造成9点伤害。目标下一次受到的伤害翻倍。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_084_02e:Ability{
//NAME=阴燃穿刺
//TEXT=下一次受到的伤害翻倍。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_085_01:AutoChessMinionBase{
//NAME=火妖传令官
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_085_02:Ability{
//NAME=延烧之火
//TEXT=引燃一个敌人，对一个敌人造成$3点伤害，并在回合结束时传播到一个相邻角色身上。<i>（受到治疗可移除。）</i>
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_085_02e:Ability{
//NAME=引燃
//TEXT=在回合结束时，受到0点火焰伤害并延烧。<i>（受到治疗可移除。）</i>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_086_01:AutoChessMinionBase{
//NAME=火妖
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_087_01:AutoChessMinionBase{
//NAME=熔岩元素
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_088_01:AutoChessMinionBase{
//NAME=火焰驱逐者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
public class LETLT_088_02:Ability{
//NAME=烈火突击
//TEXT=在本回合中提高等同于<b>火焰伤害</b>的攻击力并<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_088_02e:Ability{
//NAME=烈火突击
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_088_03:Ability{
//NAME=高耸地狱火
//TEXT=直到下回合结束时，获得<b>嘲讽</b>。在敌人<b>攻击</b>此佣兵后，获得<b>+2火焰伤害</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class LETLT_088_03e:Ability{
//NAME=高耸地狱火
//TEXT=<b>嘲讽</b>。在敌人<b>攻击</b>此佣兵后，提高2点<b>火焰伤害</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_088_03e2:Ability{
//NAME=Towering Inferno
//TEXT=+0 Fire Damage
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_090_01:AutoChessMinionBase{
//NAME=恐怖的奴隶主
//TEXT=当本角色受到伤害并存活下来后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=20|RACE=DWARF
}
public class LETLT_091_01:AutoChessMinionBase{
//NAME=掷斧者
//TEXT=每当掷斧者受到伤害时，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=DWARF
}
public class LETLT_091_02:Ability{
//NAME=掷斧
//TEXT=对一个敌人及一个相邻的角色造成等同于此佣兵攻击力的伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_100_01:AutoChessMinionBase{
//NAME=负伤剑圣
//TEXT=当拥有所有生命值时，基础攻击力翻倍。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=45|RACE=ORC
}
public class LETLT_100_02:Ability{
//NAME=挥砍
//TEXT=<b>攻击</b>一个敌人。如果目标已经受到过伤害，则先获得+1攻击力。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_100_03:Ability{
//NAME=剑刃风暴
//TEXT=对所有敌人造成等同于此佣兵攻击力的伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_100e:Ability{
//NAME=挥砍
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_101_01:AutoChessMinionBase{
//NAME=反射工程师
//TEXT=<b>对战开始时：</b>获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=GOBLIN
}
public class LETLT_101_02:Ability{
//NAME=治疗刺激
//TEXT=恢复#30点生命值。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LETLT_101_03:Ability{
//NAME=激光束
//TEXT=造成$11点伤害。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_102_01:AutoChessMinionBase{
//NAME=联盟旗帜
//TEXT=敌方部落角色始终会受到暴击伤害。联盟旗帜每次只会受到1点伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=15|RACE=NONE
}
public class LETLT_103_01:AutoChessMinionBase{
//NAME=穴居人元素师
//TEXT=每当敌人使用造成元素伤害的技能时，获得<b>+1自然伤害</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_103_02:Ability{
//NAME=闪电箭
//TEXT=造成${0}点伤害。获得<b>+{1}自然伤害</b>。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_103_03:Ability{
//NAME=闪电链
//TEXT=对一个敌人造成$10点伤害。额外对1个相邻敌人重复此技能。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class LETLT_103e:Ability{
//NAME=穴居人魔法
//TEXT=+0自然伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_104_01:AutoChessMinionBase{
//NAME=穴居人石匠
//TEXT=每当敌人使用造成元素伤害的技能时，获得+3攻击力。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_104_02:Ability{
//NAME=穴居人出击
//TEXT=<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_104e:Ability{
//NAME=穴居之力
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_105_01:AutoChessMinionBase{
//NAME=穴居人前锋
//TEXT=每当敌人使用造成元素伤害的技能时，获得+5生命值。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=NONE
}
public class LETLT_105_02:Ability{
//NAME=穴居人讨厌魔法
//TEXT=获得<b>嘲讽</b>和+5攻击力。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_105e:Ability{
//NAME=穴居强韧
//TEXT=+0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_105e2:Ability{
//NAME=穴居嘲讽
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_106_01:AutoChessMinionBase{
//NAME=雷矛特种兵
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DWARF
}
public class LETLT_106_02:Ability{
//NAME=瞄准
//TEXT=雷矛特种兵正在准备射击。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_106_03:Ability{
//NAME=爆头
//TEXT=对一个敌人造成$35点伤害。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_106_04:Ability{
//NAME=刺刀突击
//TEXT=<b>攻击</b>一个敌人，并施加<b>流血</b>（0）。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_107_01:AutoChessMinionBase{
//NAME=苦工
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=ORC
}
public class LETLT_107_02:Ability{
//NAME=修复
//TEXT=为冰血要塞恢复#0点生命值。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_107_03:Ability{
//NAME=攻击
//TEXT=<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_108_01:AutoChessMinionBase{
//NAME=冰血要塞
//TEXT=每次只受到1点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=NONE
}
public class LETLT_108_02:Ability{
//NAME=招募
//TEXT=召唤一个步兵。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_109_01:AutoChessMinionBase{
//NAME=废铁步兵
//TEXT=你的其他兽人受到的伤害降低1点。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=66|RACE=ORC
}
public class LETLT_109_02:Ability{
//NAME=为了霜狼！
//TEXT=使你的兽人获得+0攻击力。<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_109e:Ability{
//NAME=霜狼之力
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_110_01:AutoChessMinionBase{
//NAME=雷矛防御者
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=6|HP=70|RACE=DWARF
}
public class LETLT_110_02:Ability{
//NAME=卧倒！
//TEXT=在本回合中，所有友方角色受到的伤害减少{0}点。友方角色每受到一点伤害，本角色获得+1/+{1}。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_110_03:Ability{
//NAME=攻击
//TEXT=<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_110e:Ability{
//NAME=防护
//TEXT=受另一名佣兵保护。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_110e2:Ability{
//NAME=英勇无私
//TEXT=+{0}/{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_111_01:AutoChessMinionBase{
//NAME=联盟法师
//TEXT=此佣兵第一次即将死亡时，使其在本回合中<b>免疫</b>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=70|RACE=HIGHELF
}
public class LETLT_111_02:Ability{
//NAME=冰风暴
//TEXT=随机对3名敌方佣兵造成$7点伤害，并使其在下回合中速度值减慢（1）点。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=FROST
}
public class LETLT_112_01:AutoChessMinionBase{
//NAME=雷矛羊骑兵
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DWARF
}
public class LETLT_112_02:Ability{
//NAME=冲撞攻击
//TEXT=获得+2攻击力。<b>攻击</b>此佣兵对面的敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_112_02e:Ability{
//NAME=山羊冲撞
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_113_01:AutoChessMinionBase{
//NAME=傲狮猎手
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=5|HP=60|RACE=TROLL
}
public class LETLT_113_02:Ability{
//NAME=证明自己
//TEXT=每有一个你的尚未行动的部落角色，获得+0攻击力。<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class LETLT_113_02e:Ability{
//NAME=高傲自信
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_114_01:AutoChessMinionBase{
//NAME=霜狼嗥叫者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=15|HP=30|RACE=BEAST
}
public class LETLT_115_01:AutoChessMinionBase{
//NAME=雷矛军用坐骑
//TEXT=<b>流血（5）</b>
//MAJ=NEUTRAL|COST=4|ATK=25|HP=20|RACE=BEAST
}
public class LETLT_116_01:AutoChessMinionBase{
//NAME=武装教士
//TEXT=<b>亡语：</b>使你的所有角色获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=45|RACE=DRAENEI
}
public class LETLT_117_01:AutoChessMinionBase{
//NAME=冰封猛犸
//TEXT=在每个回合结束时，如果你没有控制其他角色，则<b>解冻</b>。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=20|RACE=BEAST
}
public class LETLT_118_01:AutoChessMinionBase{
//NAME=霜狼宝宝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=12|HP=60|RACE=BEAST
}
public class LETLT_118_02:Ability{
//NAME=抓住你啦！
//TEXT=随机<b>攻击</b>两个敌人。在<b>攻击</b>攻击力更低的敌人前，获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_118_02e:Ability{
//NAME=抓住猎物
//TEXT=+{1}/+{0}
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_119_01:AutoChessMinionBase{
//NAME=始祖龟预言者
//TEXT=在每个回合结束时，使所有已被<b>冻结</b>的角色获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=60|RACE=NONE
}
public class LETLT_119_01e:Ability{
//NAME=低温异能
//TEXT=+{0}/+{1}
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_120_01:AutoChessMinionBase{
//NAME=霜狼守卫者
//TEXT=每有一个其他友方兽人，便拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=80|RACE=ORC
}
public class LETLT_120_02:Ability{
//NAME=部落保卫者
//TEXT=获得<b>嘲讽</b>，且在本回合中受到的伤害减少5点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class LETLT_120_04:Ability{
//NAME=防守！
//TEXT=受到的伤害降低0点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_121_01:AutoChessMinionBase{
//NAME=霜狼军团士兵
//TEXT=每有一个其他友方兽人，便拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=65|RACE=ORC
}
public class LETLT_121_02:Ability{
//NAME=嗜血暴怒
//TEXT=随机<b>攻击</b>一个敌人。每有一个受伤的兽人，重复一次。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_122_01:AutoChessMinionBase{
//NAME=霜狼兽栏管理员
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=4|HP=55|RACE=ORC
}
public class LETLT_122_02:Ability{
//NAME=霜狼
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=4|ATK=10|HP=15|RACE=BEAST
}
public class LETLT_122_03:Ability{
//NAME=治疗宠物
//TEXT=为一只友方野兽恢复所有生命值。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class LETLT_122_04:AutoChessMinionBase{
//NAME=霜狼
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=4|ATK=10|HP=15|RACE=BEAST
}
public class LETLT_123_01:AutoChessMinionBase{
//NAME=雷矛狂战士
//TEXT=如果本角色是你唯一的角色，便拥有+5攻击力和<b>风怒</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DWARF
}
public class LETLT_123_01e:Ability{
//NAME=狂怒
//TEXT=+5攻击力及<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_124_01:AutoChessMinionBase{
//NAME=雷矛军需官
//TEXT=在每个回合结束时，为你的联盟角色恢复5点生命值。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DWARF
}
public class LETLT_125_01:AutoChessMinionBase{
//NAME=奥妮克希亚幼龙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DRAGON
}
public class LETLT_126_01:AutoChessMinionBase{
//NAME=光腹虚空幼龙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DRAGON
}
public class LETLT_126_02:Ability{
//NAME=折磨
//TEXT=对一个敌人造成${0}点伤害，并对所有其他敌人造成${1}点伤害。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class LETLT_127_01:AutoChessMinionBase{
//NAME=奥妮克希亚守卫
//TEXT=每有一条其他友方的龙，受到的伤害减少1点。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DRAGON
}
public class LETLT_127_02:Ability{
//NAME=噬咬
//TEXT=在本局对战中每有一条友方的龙死亡，获得+0攻击力。<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_127e1:Ability{
//NAME=咀嚼
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_128_01:AutoChessMinionBase{
//NAME=奥妮克希亚雏龙
//TEXT=<b>流血（0）</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DRAGON
}
public class LETLT_128_02:Ability{
//NAME=撕扯
//TEXT=<b>攻击</b>一个敌人两次。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LETLT_129_01:AutoChessMinionBase{
//NAME=军情七处探员
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=GNOME
}
public class LETLT_129_02:Ability{
//NAME=屠龙
//TEXT=消灭一条雏龙，召唤军情七处刺客。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LETLT_130_01:AutoChessMinionBase{
//NAME=军情七处刺客
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=9|HP=63|RACE=NIGHTELF
}
public class LETLT_130_02:Ability{
//NAME=快刀乱斩
//TEXT=<b>攻击</b>一个敌人。此技能始终造成<b>爆击伤害</b>。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LETLT_130_03:Ability{
//NAME=处决
//TEXT=造成{0}点伤害。每有一个其他友方军情七处刺客，伤害提高{1}点。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_131_01:AutoChessMinionBase{
//NAME=军情七处渗透者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=HUMAN
}
public class LETLT_131_02:Ability{
//NAME=定时爆破
//TEXT=对一个敌人造成0点伤害。如果此佣兵最后一个行动，则改为对所有敌人造成伤害。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LETLT_132_01:AutoChessMinionBase{
//NAME=骸骨巨龙
//TEXT=在回合结束时，复活所有在本局对战中死亡的骸骨巨龙。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DRAGON
}
public class LETLT_133_01:AutoChessMinionBase{
//NAME=虚空领主
//TEXT=<b>亡语：</b>召唤三个虚空行者。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DEMON
}
public class LETLT_133_02:Ability{
//NAME=暗影之雨
//TEXT=对所有敌人造成${0}点伤害。此技能每施放一次，伤害提高{1}点。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class LETLT_134_01:AutoChessMinionBase{
//NAME=虚空行者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=6|HP=50|RACE=DEMON
}
public class LETLT_135_01:AutoChessMinionBase{
//NAME=虚空碾压者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DEMON
}
public class LETLT_135_02:Ability{
//NAME=真空
//TEXT=为对手的所有非神圣技能添加1冷却。敌人每有一个受影响的技能，便会受到$0点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class LETLT_136_01:AutoChessMinionBase{
//NAME=虚空吸食者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DEMON
}
public class LETLT_136_02:Ability{
//NAME=灵魂裂隙
//TEXT=从一个敌人处偷取{0}/{1}点属性值。每当一个神圣技能被使用时，失去该属性值。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class LETLT_136e1:Ability{
//NAME=灵魂榨取
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_136e2:Ability{
//NAME=灵魂碎裂
//TEXT=属性值降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_137_01:AutoChessMinionBase{
//NAME=空灵召唤者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=DEMON
}
public class LETLT_137_02:Ability{
//NAME=暗影低语
//TEXT=在本回合中，将一个敌人的攻击力降低为0。对其造成伤害，数值等同于降低的攻击力。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class LETLT_137e:Ability{
//NAME=消音
//TEXT=在本回合中，攻击力变为0。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LETLT_138_01:AutoChessMinionBase{
//NAME=军情七处特工
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=20|RACE=HUMAN
}
public class LETLT_138_02:Ability{
//NAME=反复打击
//TEXT=造成{0}点伤害。<b>连击</b>：改为造成{1}点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LETLT_400_01:AutoChessMinionBase{
//NAME=熔岩爪牙
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=15|RACE=ELEMENTAL
}
