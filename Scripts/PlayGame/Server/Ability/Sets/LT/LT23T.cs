using System.Collections;
using System.Collections.Generic;

public class LT23T_100_01:AutoChessMinionBase{
//NAME=并鳍奇兵
//TEXT=在每个回合结束时，随机使友方和敌方各一个角色的技能的速度值加快（0）点。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=20|RACE=MURLOC
}
public class LT23T_100_01e:Ability{
//NAME=激流冲浪
//TEXT=本角色的下一个技能速度值会加快（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_100_02:Ability{
//NAME=鱼人冲浪
//TEXT=随机对一个敌人造成$0点伤害。每有一个已经行动的角色，重复一次。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class LT23T_101_01:AutoChessMinionBase{
//NAME=休息鱼人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=30|RACE=MURLOC
}
public class LT23T_101_02:Ability{
//NAME=休息时间！
//TEXT=为此佣兵恢复#{0}点生命值。<i>（你每控制一个其他鱼人，提高#{1}点。）</i>
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NATURE
}
public class LT23T_101_03:Ability{
//NAME=你瞅什么
//TEXT=对本角色对面的敌人造成$0点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=SHADOW
}
public class LT23T_102_01:AutoChessMinionBase{
//NAME=怒鳍猎潮者
//TEXT=在一个你的鱼人死亡后，获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=7|HP=15|RACE=MURLOC
}
public class LT23T_102_01e:Ability{
//NAME=恩佐斯的低语
//TEXT=+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_103_01:AutoChessMinionBase{
//NAME=虚鳃鱼人
//TEXT=在一个鱼人行动后，使其随机从一个敌人处偷取0点生命值。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=10|RACE=MURLOC
}
public class LT23T_103_01e:Ability{
//NAME=虚空灌注
//TEXT=+0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_103_01e2:Ability{
//NAME=虚空汲取
//TEXT=-0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_103_02:Ability{
//NAME=恩佐斯的躁动
//TEXT=随机对一个敌人造成$0点伤害。随机使一个鱼人下一个行动。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class LT23T_103_02e:Ability{
//NAME=Excitement of N'Zoth
//TEXT=This goes next.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_104_01:AutoChessMinionBase{
//NAME=小丑鱼
//TEXT=相邻的鱼人拥有+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=20|RACE=MURLOC
}
public class LT23T_104_01e:Ability{
//NAME=小丑鱼群
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_105_01:AutoChessMinionBase{
//NAME=黑暗深渊暴食者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=MURLOC
}
public class LT23T_105_02:Ability{
//NAME=吞食狂热
//TEXT=随机召唤一个{0}/{0}的黑海岸鱼人。
//MAJ=NEUTRAL|COST=9|ATK=0|HP=0|RACE=NONE
}
public class LT23T_106_01:AutoChessMinionBase{
//NAME=坚壳伏击者
//TEXT=本角色受到的伤害降低0点。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=10|RACE=MURLOC
}
public class LT23T_109_01:AutoChessMinionBase{
//NAME=纳迦战斗法师
//TEXT=在一个敌人释放技能后，在本回合中获得该派系的<b>+0抗性</b>。
//MAJ=NEUTRAL|COST=0|ATK=8|HP=25|RACE=NAGA
}
public class LT23T_109_01e:Ability{
//NAME=Naga Battlemage
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LT23T_109_02:Ability{
//NAME=艾萨拉的祭仪
//TEXT=<b>攻击</b>一个敌人。在本回合中，你的纳迦受到的伤害减少0点。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class LT23T_109_02e:Ability{
//NAME=Azsharan Ritual
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LT23T_110_01:AutoChessMinionBase{
//NAME=纳迦傀儡师
//TEXT=在每个回合结束时，召唤一个{0}/{1}并具有<b>嘲讽</b>的魔像。
//MAJ=NEUTRAL|COST=0|ATK=1|HP=15|RACE=NAGA
}
public class LT23T_111_01:AutoChessMinionBase{
//NAME=狼人信徒
//TEXT=每当暗影技能被使用时，获得<b>+0暗影伤害</b>。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=14|RACE=WORGEN
}
public class LT23T_111_01e:Ability{
//NAME=暗影环拥
//TEXT=<b>+0暗影伤害</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_111_02:Ability{
//NAME=暮光碎片
//TEXT=<b>攻击</b>一个敌人。在下个回合中，如果目标最后一个行动，对其造成$10点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class LT23T_111_02e:Ability{
//NAME=暮光碎片
//TEXT=如果本角色最后行动，受到$0点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class LT23T_112_01:AutoChessMinionBase{
//NAME=暮光尊者
//TEXT=在回合开始时，腐蚀每个敌人的各一个随机技能。敌人会在每个回合结束时受到0点伤害，直到其使用该技能。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=GNOME
}
public class LT23T_113_01:AutoChessMinionBase{
//NAME=沉没的拾荒者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=10|HP=15|RACE=MURLOC
}
public class LT23T_114_01:AutoChessMinionBase{
//NAME=无面巨兽
//TEXT=在另一个佣兵死亡后，获得+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_114_01e:Ability{
//NAME=进食充分
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_115_01:AutoChessMinionBase{
//NAME=魅影歹徒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_115_02:Ability{
//NAME=魅影匪徒
//TEXT=在左侧和右侧各生成一个此单位的复制。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class LT23T_115_03:Ability{
//NAME=弹幕乱射
//TEXT=造成0点伤害。场上每有一个魅影歹徒，重复一次。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class LT23T_116_01:AutoChessMinionBase{
//NAME=触手恐吓者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_116_02:Ability{
//NAME=全员攻击
//TEXT=随机对敌人造成${0}点伤害，触发{1}次。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=0|RACE=NONE
}
public class LT23T_117_01:AutoChessMinionBase{
//NAME=无面腐蚀者
//TEXT=在回合开始时，随机腐蚀一个敌人的随机一个技能。该敌人会在回合结束时受到0点伤害，直到其使用该技能。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_117_03:Ability{
//NAME=腐蚀之力
//TEXT=对一个敌人造成${0}点伤害。每施放一个已腐蚀的技能，提高${0}点。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=0|RACE=SHADOW
}
public class LT23T_117e:Ability{
//NAME=Corruption
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_117e2:Ability{
//NAME=腐蚀
//TEXT=如果本角色未使用此技能，则会在每个回合结束时受到$0点伤害，直到使用此技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_118_01:AutoChessMinionBase{
//NAME=狂热的新兵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_118_02:Ability{
//NAME=狂热鞭笞
//TEXT=获得<b>嘲讽</b>，持续1回合。在本回合中，对攻击此佣兵的敌人施加<b>流血</b>（0）。
//MAJ=NEUTRAL|COST=0|ATK=7|HP=0|RACE=SHADOW
}
public class LT23T_118e:Ability{
//NAME=狂热鞭笞
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_119_01:AutoChessMinionBase{
//NAME=奥秘吞噬者
//TEXT=<b>流血（2）</b>
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_120_01:AutoChessMinionBase{
//NAME=无面蹒跚者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=10|HP=25|RACE=NONE
}
public class LT23T_121_01:AutoChessMinionBase{
//NAME=牛头人德鲁伊
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=2|HP=12|RACE=TAUREN
}
public class LT23T_122_01:AutoChessMinionBase{
//NAME=牛头人武僧
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=10|RACE=TAUREN
}
public class LT23T_123_01:AutoChessMinionBase{
//NAME=牛头人圣骑士
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=3|HP=15|RACE=TAUREN
}
public class LT23T_124_01:AutoChessMinionBase{
//NAME=牛怪精魂
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=2|HP=8|RACE=BEAST
}
public class LT23T_125_01:AutoChessMinionBase{
//NAME=泡沫元素
//TEXT=
//MAJ=NEUTRAL|COST=9|ATK=10|HP=10|RACE=ELEMENTAL
}
public class LT23T_125_02:Ability{
//NAME=欢乐时光
//TEXT=使你的一个角色获得+{0}/+{1}。随机<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LT23T_125_02e:Ability{
//NAME=泡泡
//TEXT=+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_126_01:AutoChessMinionBase{
//NAME=游乐园小丑
//TEXT=<b>亡语：</b>在本局对战中每有一个你的角色死亡，造成0点伤害。
//MAJ=NEUTRAL|COST=9|ATK=10|HP=10|RACE=NONE
}
public class LT23T_126_02:Ability{
//NAME=疯狂横行
//TEXT=获得+0攻击力并随机<b>攻击</b>一个敌人。<b>击杀：</b>随机<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LT23T_126_02e:Ability{
//NAME=疯狂暴走
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class LT23T_127_01:AutoChessMinionBase{
//NAME=腐化的树艺师
//TEXT=<b>亡语：</b>为友方角色恢复所有生命值。
//MAJ=NEUTRAL|COST=9|ATK=10|HP=10|RACE=NONE
}
public class LT23T_127_02:Ability{
//NAME=腐化的果实
//TEXT=使你的一个角色获得+{0}/+{1}和<b>流血（3）</b>。使其随机<b>攻击</b>一个敌人。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class LT23T_127_02e:Ability{
//NAME=毒药之力
//TEXT=+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
