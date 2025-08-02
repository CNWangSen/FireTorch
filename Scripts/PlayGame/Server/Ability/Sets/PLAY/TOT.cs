using System.Collections;
using System.Collections.Generic;

public class TOT_030:MinionBase{
//NAME=克罗米
//TEXT=<b>战吼：</b>将4张历史事件牌洗入你的牌库。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NONE
}
public class TOT_030t1:SpellBase{
//NAME=开启黑暗之门
//TEXT=<b>抽到时施放</b> 随机将两张传说随从牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOT_030t2:SpellBase{
//NAME=海加尔山之战
//TEXT=<b>抽到时施放</b> 使你的所有随从获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOT_030t2e:Ability{
//NAME=战斗祝福
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_030t3:SpellBase{
//NAME=逃离敦霍尔德
//TEXT=<b>抽到时施放</b> 随机将两张法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOT_030t4:SpellBase{
//NAME=净化斯坦索姆
//TEXT=<b>抽到时施放</b> 对所有敌人造成$2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOT_056:MinionBase{
//NAME=荒野探险家
//TEXT=<b>战吼：</b>随机将一张来自于<b>荣誉室</b>的卡牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TOT_067:MinionBase{
//NAME=无限鱼人
//TEXT=<b>战吼：</b>将一张无限鱼人洗入你的牌库。你此后的无限鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=MURLOC
}
public class TOT_067e:Ability{
//NAME=真·无限鱼人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_067ee:Ability{
//NAME=真·无限
//TEXT=每使用一次获得加成。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_069:SpellBase{
//NAME=永恒祝福
//TEXT=使一个随从获得“在你的回合结束时，获得+1/+1。”
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=HOLY
}
public class TOT_069e:Ability{
//NAME=聪慧过人
//TEXT=在你的回合结束时获得+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_069ee:Ability{
//NAME=学有所成
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_100e:Ability{
//NAME=稍纵即逝
//TEXT=回合结束时如果这张牌仍在手牌中，将其摧毁。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_102:MinionBase{
//NAME=裂隙卫士
//TEXT=<b>战吼：</b> 随机弃一张随从牌。 <b>亡语：</b> 召唤被弃的那个随从。
//MAJ=WARLOCK|COST=7|ATK=7|HP=7|RACE=DRAGON
}
public class TOT_103:SpellBase{
//NAME=掌握先机
//TEXT=抽两张牌，这些牌的法力值消耗减少（2）点。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOT_103e:Ability{
//NAME=稍纵即逝
//TEXT=回合结束时如果这张牌仍在手牌中，将其摧毁。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_105:SpellBase{
//NAME=疾速向前
//TEXT=每个玩家获得两个法力水晶，并抽两张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOT_107:MinionBase{
//NAME=快手窃贼
//TEXT=<b>战吼：</b>将你对手的牌库顶的一张牌的复制置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class TOT_108:SpellBase{
//NAME=似曾相识
//TEXT=<b>发现</b>一张你在本局对战中使用过的法术牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_109:MinionBase{
//NAME=静滞飞龙
//TEXT=起始休眠状态。两回合后唤醒本随从，并具有<b>突袭</b>。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=10|RACE=DRAGON
}
public class TOT_109t:MinionBase{
//NAME=静滞飞龙
//TEXT=2
//MAJ=NEUTRAL|COST=6|ATK=10|HP=10|RACE=DRAGON
}
public class TOT_110:MinionBase{
//NAME=时缚巨人
//TEXT=你每抽一张牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=15|ATK=8|HP=8|RACE=NONE
}
public class TOT_111:MinionBase{
//NAME=时光见证者
//TEXT=在你的回合开始时，你会从你的牌库中<b>发现</b>一张牌，而非抽牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class TOT_111e:Ability{
//NAME=时光漫步
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_112:MinionBase{
//NAME=机会探寻者
//TEXT=<b>战吼：</b>将你的手牌洗入牌库。抽取相同数量的牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=6|RACE=DRAGON
}
public class TOT_112e:Ability{
//NAME=牌库增长
//TEXT=发生增长
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_116:MinionBase{
//NAME=时道漫步者
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。使其法力值消耗减少（5）点，然后置入牌库顶。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=3|RACE=NONE
}
public class TOT_116e:Ability{
//NAME=计时！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_117:MinionBase{
//NAME=无限奔狼
//TEXT=<b>突袭</b> 在本随从攻击后将其洗入你的牌库，并使你此后的无限奔狼获得+2/+2。
//MAJ=HUNTER|COST=3|ATK=5|HP=5|RACE=BEAST
}
public class TOT_117e:Ability{
//NAME=回溯
//TEXT=“无限奔狼”每次攻击后获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_118:MinionBase{
//NAME=静滞元素
//TEXT=<b>战吼：</b><b>冻结</b>一个随从，直到静滞元素离开战场。
//MAJ=SHAMAN|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class TOT_118e:Ability{
//NAME=静滞
//TEXT=被<b>冻结</b>，直到静滞元素离开战场。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_204:MinionBase{
//NAME=时空漂移：恐惧战马
//TEXT=<b>亡语：</b>召唤一匹恐惧战马。
//MAJ=WARLOCK|COST=4|ATK=1|HP=1|RACE=DEMON
}
public class TOT_303t:MinionBase{
//NAME=欢快的雏龙
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=DRAGON
}
public class TOT_308:MinionBase{
//NAME=洞穴梦游者
//TEXT=在你的回合结束时，随机将一张法力值消耗小于或等于（2）点的法术牌置入你的手牌。
//MAJ=MAGE|COST=2|ATK=1|HP=3|RACE=NONE
}
public class TOT_313:MinionBase{
//NAME=现境大师
//TEXT=在你召唤一个随从后，随机将其变形成为一个法力值消耗增加（2）点的随从。
//MAJ=SHAMAN|COST=6|ATK=5|HP=8|RACE=NONE
}
public class TOT_316:MinionBase{
//NAME=龙人传令官
//TEXT=<b>战吼：</b><b>发现</b>一张随从牌。使其获得+3/+3，然后置入牌库顶。
//MAJ=WARRIOR|COST=6|ATK=6|HP=6|RACE=DRAGON
}
public class TOT_316e:Ability{
//NAME=预言之子
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_320:MinionBase{
//NAME=灾变先驱
//TEXT=在你的回合开始时，从每个玩家的牌库中召唤法力值消耗最高的随从。
//MAJ=DRUID|COST=6|ATK=6|HP=7|RACE=DRAGON
}
public class TOT_330:MinionBase{
//NAME=青铜龙巢母
//TEXT=当你抽到该牌时，召唤一条1/1的欢快的 雏龙。
//MAJ=PALADIN|COST=5|ATK=6|HP=6|RACE=DRAGON
}
public class TOT_332:MinionBase{
//NAME=姆诺兹多
//TEXT=<b>战吼：</b>从现在起，你的回合持续15秒，且你每个回合额外抽 两张牌。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=DRAGON
}
public class TOT_332e:Ability{
//NAME=时空扭曲
//TEXT=你的回合现在持续20秒。你每个回合额外抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_334:MinionBase{
//NAME=时空畸体
//TEXT=当你抽到该牌时，随机将一张<i>（你职业的）</i>法术牌置入你的 手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class TOT_340:SpellBase{
//NAME=超时空射击
//TEXT=将一个敌方随从移回你对手的手牌，并且法力值消耗增加（2）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOT_341:SpellBase{
//NAME=古往今来
//TEXT=随机将三张来自过去的法术牌置入你的手牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TOT_342:WeaponBase{
//NAME=命运之斧
//TEXT=在命运之斧消灭一个随从后，消灭其所有的复制<i>（无论它们在哪）</i>。
//MAJ=WARRIOR|COST=4|ATK=4|HP=2|RACE=NONE
}
public class TOT_343:SpellBase{
//NAME=追忆
//TEXT=随机将两张你的对手在本局对战中使用过的卡牌置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class TOT_345:SpellBase{
//NAME=时间涟漪
//TEXT=<b>发现</b>一张随从牌。如果你在本回合使用该牌，则其拥有<b>回响</b>。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class TOT_345e:Ability{
//NAME=涟漪
//TEXT=本回合获得回响。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TOT_345e2:Ability{
//NAME=涟漪玩家附魔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
