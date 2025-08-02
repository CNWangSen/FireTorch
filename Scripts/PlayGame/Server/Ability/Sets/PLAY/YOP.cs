using System.Collections;
using System.Collections.Generic;

public class YOP_001:SpellBase{
//NAME=伊利达雷研习
//TEXT=<b>发现</b>一张<b>流放</b>牌。你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class YOP_001e:Ability{
//NAME=孤独流放
//TEXT=你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_002:MinionBase{
//NAME=邪刃豹
//TEXT=在本回合中，除非你的英雄进行过攻击，否则无法进行攻击。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=6|RACE=DEMON
}
public class YOP_003:MinionBase{
//NAME=幸运之魂囤积者
//TEXT=<b>战吼：</b>将两张灵魂残片洗入你的牌库。<b>腐蚀：</b>抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class YOP_003t:MinionBase{
//NAME=幸运之魂囤积者
//TEXT=<b>已腐蚀</b> <b>战吼：</b>将两张灵魂残片洗入你的牌库，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class YOP_004:MinionBase{
//NAME=铁锈特使拉斯维克斯
//TEXT=<b>亡语：</b>随机将三张终极<b>传说</b>随从牌洗入你的牌库。
//MAJ=WARLOCK|COST=5|ATK=5|HP=4|RACE=DEMON
}
public class YOP_005:SpellBase{
//NAME=路障
//TEXT=召唤一个2/4并具有<b>嘲讽</b>的护卫。如果它是你唯一的一个随从，再召唤一个。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class YOP_005t:MinionBase{
//NAME=赛道护卫
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class YOP_006:SpellBase{
//NAME=狂乱
//TEXT=选择一个敌方随从，使其随机攻击随从，直至死亡。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class YOP_007:MinionBase{
//NAME=黑暗审判官夏奈什
//TEXT=<b>战吼：</b> 使你手牌和牌库中的所有<b>腐蚀</b>和<b>已腐蚀</b>牌的法力值消耗减少（2）点。
//MAJ=PRIEST|COST=5|ATK=3|HP=5|RACE=NONE
}
public class YOP_007e:Ability{
//NAME=黑暗审问
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_008:MinionBase{
//NAME=圣光战马
//TEXT=你的治疗效果同时会使受到影响的随从获得+2生命值。
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class YOP_008e:Ability{
//NAME=圣光战马
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_009:SpellBase{
//NAME=开赛集结
//TEXT=复活法力值消耗为（1），（2），（3）的友方随从 各一个。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class YOP_010:MinionBase{
//NAME=被禁锢的星骓
//TEXT=<b>休眠</b>2回合。<b>法术迸发：</b>使你的随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=4|HP=5|RACE=NONE
}
public class YOP_011:WeaponBase{
//NAME=审判圣契
//TEXT=<b>腐蚀：</b>获得<b>吸血</b>。
//MAJ=PALADIN|COST=7|ATK=5|HP=3|RACE=NONE
}
public class YOP_011t:WeaponBase{
//NAME=审判圣契
//TEXT=<b>已腐蚀</b> <b>吸血</b>
//MAJ=PALADIN|COST=7|ATK=5|HP=3|RACE=NONE
}
public class YOP_012:MinionBase{
//NAME=死亡守望者
//TEXT=<b>亡语</b>不会触发。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class YOP_012e:Ability{
//NAME=静逝无声
//TEXT=这张牌的<b>亡语</b>不会触发。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_013:WeaponBase{
//NAME=尖刺轮盘
//TEXT=当你的英雄有护甲值时，拥有+3攻击力。
//MAJ=WARRIOR|COST=1|ATK=0|HP=2|RACE=NONE
}
public class YOP_013e:Ability{
//NAME=蓄能冲击
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_014:MinionBase{
//NAME=铁甲战车
//TEXT=<b>战吼：</b>如果你的英雄有护甲值，便获得+2/+2。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=MECHANICAL
}
public class YOP_014e:Ability{
//NAME=顶级战车
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_015:SpellBase{
//NAME=氮素药膏
//TEXT=使一个随从获得+2攻击力。<b>腐蚀：</b>并使你的武器获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class YOP_015e:Ability{
//NAME=氮素药膏
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_015t:SpellBase{
//NAME=氮素药膏
//TEXT=<b>已腐蚀</b> 使一个随从和你的武器获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class YOP_016:MinionBase{
//NAME=欢脱的作弊选手
//TEXT=<b>战吼：</b>如果你的手牌中有<b>奥秘</b>牌，将其施放并抽一张牌。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class YOP_017:SecretBase{
//NAME=蕉猾诡计
//TEXT=<b>奥秘：</b>当你的对手在一个回合中抽到第二张牌时，将其变形成为一张香蕉。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class YOP_018:MinionBase{
//NAME=钥匙守护者艾芙瑞
//TEXT=<b>战吼：</b><b>发现</b>一张任意职业的双职业法术牌。<b>法术迸发：</b>获取发现的法术牌的另一张复制。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class YOP_018e:Ability{
//NAME=Key to Victory
//TEXT=<b>Spellburst</b> Add {0} to your hand.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_019:SpellBase{
//NAME=制造法力饼干
//TEXT=将一张可以复原两个法力水晶的饼干置入你的手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class YOP_019t:SpellBase{
//NAME=法力饼干
//TEXT=复原两个法力水晶。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_020:MinionBase{
//NAME=冰川竞速者
//TEXT=<b>法术迸发：</b>对所有已被<b>冻结</b>的敌人造成3点伤害。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class YOP_021:MinionBase{
//NAME=被禁锢的凤凰
//TEXT=<b>休眠</b>2回合。<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class YOP_022:MinionBase{
//NAME=迷雾行者
//TEXT=<b>战吼：</b>使一个友方随从获得+3/+3。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=5|ATK=4|HP=4|RACE=NONE
}
public class YOP_022e:Ability{
//NAME=乘雾而行
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_023:SpellBase{
//NAME=大地崩陷
//TEXT=对所有敌方随从造成$1点伤害。如果你有<b>过载</b>的法力水晶，再次造成$1点伤害。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class YOP_024:SpellBase{
//NAME=灵魂指引
//TEXT=检视两张法术牌。将其中一张置入你的手牌；或者<b>过载：</b>（1），获取这两张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class YOP_024t:SpellBase{
//NAME=灵魂之路
//TEXT=将两张法术牌都置入你的手牌。<b>过载</b>（1）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_025:MinionBase{
//NAME=迷梦幼龙
//TEXT=<b>嘲讽</b>，<b>腐蚀：</b>获得+2/+2。
//MAJ=DRUID|COST=3|ATK=3|HP=4|RACE=DRAGON
}
public class YOP_025t:MinionBase{
//NAME=迷梦幼龙
//TEXT=<b>已腐蚀</b> <b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=5|HP=6|RACE=DRAGON
}
public class YOP_026:SpellBase{
//NAME=树木生长
//TEXT=召唤两个2/2的树人。使你的随从获得+2/+1。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class YOP_026e:Ability{
//NAME=保卫森林
//TEXT=+2/+1
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_027:SpellBase{
//NAME=套索射击
//TEXT=对一个随从造成$1点伤害，并对其相邻的随从造成 $2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class YOP_028:MinionBase{
//NAME=鞍座管理员
//TEXT=在你使用一张野兽牌后，随机将一张野兽牌置入你的手牌。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class YOP_029:SpellBase{
//NAME=随心口袋
//TEXT=<b>发现</b>一张法力值消耗等同于你剩余法力水晶数量的卡牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class YOP_030:MinionBase{
//NAME=邪火神射手
//TEXT=你的英雄技能的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class YOP_030e:Ability{
//NAME=致命狙击
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_031:MinionBase{
//NAME=螃蟹骑士
//TEXT=<b>突袭</b>，<b>风怒</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=MURLOC
}
public class YOP_031e:Ability{
//NAME=乘蟹遨游
//TEXT=在本回合中<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOP_032:MinionBase{
//NAME=护甲商贩
//TEXT=<b>战吼：</b>使每个英雄获得4点护甲值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class YOP_033:SpellBase{
//NAME=赛车回火
//TEXT=抽三张牌。对你的英雄造成$3点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class YOP_034:MinionBase{
//NAME=窜逃的黑翼龙
//TEXT=在你的回合结束时，随机对一个敌方随从造成9点伤害。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=9|RACE=DRAGON
}
public class YOP_035:MinionBase{
//NAME=月牙
//TEXT=每次只能受到1点伤害。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=3|RACE=BEAST
}
