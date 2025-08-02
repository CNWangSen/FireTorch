using System.Collections;
using System.Collections.Generic;

public class YOG_082:SpellBase{
//NAME=星体射击
//TEXT=造成$3点伤害。你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class YOG_082e:Ability{
//NAME=群星环拥
//TEXT=你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_300:MinionBase{
//NAME=影触克瓦迪尔
//TEXT=<b>战吼：</b>你的下一次治疗效果转而造成等量的伤害。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class YOG_300e:Ability{
//NAME=扭曲入骨
//TEXT=你的治疗效果会造成伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_301:SpellBase{
//NAME=狂乱侵蚀
//TEXT=双方英雄受到疲劳伤害，受到两次。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_401:SpellBase{
//NAME=时间咒符
//TEXT=在你的下个回合开始时，额外抽三张牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class YOG_402:MinionBase{
//NAME=摧心魔
//TEXT=<b>战吼：</b>在本回合中你每抽一张牌，造成1点伤害。0<i>（造成0点）</i>
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=4|RACE=NONE
}
public class YOG_403:MinionBase{
//NAME=空中施肥者
//TEXT=<b>战吼，亡语：</b>召唤一个2/2的树人。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class YOG_410:SpellBase{
//NAME=汇编阵线
//TEXT=<b>发现</b>一张另一职业的机械牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class YOG_410e:Ability{
//NAME=机器火花
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_410e1:Ability{
//NAME=高端形态
//TEXT=法力值消耗为（0）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_411:MinionBase{
//NAME=越狱者
//TEXT=<b>战吼：</b>在本局对战中，如果你施放过5个或以上法术，对所有敌人造成2点伤害。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class YOG_500:MinionBase{
//NAME=维扎克斯将军
//TEXT=<b>突袭</b>。<b>战吼：</b>获得4点护甲值。<b>亡语：</b>失去4点护甲值以再次召唤本随从。
//MAJ=WARRIOR|COST=7|ATK=7|HP=6|RACE=NONE
}
public class YOG_500e2:Ability{
//NAME=势不可挡
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_501:MinionBase{
//NAME=历战无面者
//TEXT=<b>战吼：</b>变形成为一个受伤的随从的复制。
//MAJ=WARRIOR|COST=3|ATK=2|HP=2|RACE=NONE
}
public class YOG_502:SpellBase{
//NAME=清理污染
//TEXT=对所有随从造成等同于你的护甲值的伤害。<b>锻造：</b>先获得4点护甲值。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class YOG_502t:SpellBase{
//NAME=清理污染
//TEXT=<b>已锻造</b> 获得4点护甲值，然后对所有随从造成等同于你的护甲值的伤害。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class YOG_503:SpellBase{
//NAME=血肉诅咒
//TEXT=下个回合，敌方随从牌消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_503e1:Ability{
//NAME=血肉诅咒
//TEXT=在本回合中，你的卡牌消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_505:SpellBase{
//NAME=兽性癫狂
//TEXT=使你手牌，牌库和战场上的所有随从获得+1攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_505e:Ability{
//NAME=惊栗
//TEXT=+1攻击力
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_506:MinionBase{
//NAME=扭曲的霜翼龙
//TEXT=<b>突袭</b>。<b>亡语：</b>召唤一只属性值等同于本随从攻击力的奇美拉。
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class YOG_506t:MinionBase{
//NAME=奇美拉巢母
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class YOG_507:SpellBase{
//NAME=虚空经文
//TEXT=<b>发现</b>一张法术牌。如果你有足够的法力值使用发现的法术牌，则随机对一个敌人施放它的复制。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_508:SpellBase{
//NAME=暮光洪流
//TEXT=选择一个角色。如果是友方角色，为其恢复#6点生命值；如果是敌方角色，对其造成$3点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_508e:Ability{
//NAME=死亡之影
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_509:SpellBase{
//NAME=守护者的力量
//TEXT=使一个友方随从获得+2/+2。对所有其他随从造成等同于其攻击力的伤害。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class YOG_509e:Ability{
//NAME=征伐
//TEXT=+2/+2
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_510:MinionBase{
//NAME=报警安保机器人
//TEXT=<b>亡语：</b>抽一张其他随从牌。将其攻击力，生命值和法力值消耗变为5。
//MAJ=PALADIN|COST=4|ATK=4|HP=3|RACE=MECHANICAL
}
public class YOG_510e:Ability{
//NAME=报警命令
//TEXT=报警安保机器人使其变为5/5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_510e2:Ability{
//NAME=报警执行
//TEXT=法力值消耗为（5）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_511:SpellBase{
//NAME=黑暗符文
//TEXT=<b>发现</b>一张武器牌。消耗3具<b>尸体</b>，使其获得+1/+1。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_511e:Ability{
//NAME=黑暗设计
//TEXT=+1攻击力和+1耐久度。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_512:MinionBase{
//NAME=秽病行尸
//TEXT=在你召唤一个亡灵后，使其获得<b>剧毒</b>。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=5|RACE=UNDEAD
}
public class YOG_513:SpellBase{
//NAME=邪恶魂笼
//TEXT=使一个友方亡灵获得+2/+2。消耗5具<b>尸体</b>，召唤一个它的复制。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class YOG_513e:Ability{
//NAME=灵魂加持
//TEXT=+2/+2
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_514:MinionBase{
//NAME=混乱触须
//TEXT=<b>战吼：</b>随机施放一个法力值消耗为（1）的法术。提升你此后的混乱触须的效果。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class YOG_515:MinionBase{
//NAME=混沌之眼
//TEXT=<b>战吼：</b>获取两张1/1的混乱触须。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class YOG_516:MinionBase{
//NAME=脱困古神尤格-萨隆
//TEXT=<b>泰坦</b> 在本随从使用一个技能后，随机施放两个法术。
//MAJ=NEUTRAL|COST=9|ATK=7|HP=5|RACE=NONE
}
public class YOG_516e:Ability{
//NAME=死亡凝视
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_516t:SpellBase{
//NAME=混沌统治
//TEXT=夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_516t2:SpellBase{
//NAME=诱引狂乱
//TEXT=迫使每个敌方随从分别随机攻击一个敌方随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_516t3:SpellBase{
//NAME=触须攒聚
//TEXT=用1/1的混乱触须填满你的 手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_517:MinionBase{
//NAME=触须宠溺者
//TEXT=在你的回合结束时，获取一张1/1的 混乱触须。
//MAJ=WARLOCK|COST=3|ATK=2|HP=5|RACE=NONE
}
public class YOG_518:MinionBase{
//NAME=多事的仆从
//TEXT=<b>战吼：</b>在本局对战中，如果你施放过5个或以上法术，抽两张牌。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class YOG_519:MinionBase{
//NAME=腐化残渣
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则造成7点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=5|ATK=7|HP=4|RACE=ELEMENTAL
}
public class YOG_520:MinionBase{
//NAME=燃魂者瓦利亚
//TEXT=在一个友方亡灵死亡后，对敌方英雄造成2点伤害，并随机获取一张牧师暗影法术牌。
//MAJ=PRIEST|COST=3|ATK=1|HP=5|RACE=UNDEAD
}
public class YOG_521:MinionBase{
//NAME=萨隆铁矿蹒跚者
//TEXT=<b>战吼：</b>在本局对战中，如果你施放过5个或以上法术，使你的英雄在本回合中获得+4攻击力。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class YOG_521e:Ability{
//NAME=尖锐
//TEXT=在本回合中+4攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_522:SpellBase{
//NAME=电流导联
//TEXT=在本回合中，你的下一个法术还会以相邻的随从为目标。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class YOG_522e:Ability{
//NAME=导联
//TEXT=你的下一个法术还会对相邻的随从施放。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_523:MinionBase{
//NAME=被寄生的看守者
//TEXT=<b>嘲讽</b>。<b>亡语：</b>获取两张1/1的混乱触须。
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class YOG_524:MinionBase{
//NAME=雷电跳蛙
//TEXT=<b>战吼：</b>随机获取一张<b>过载</b>牌。
//MAJ=SHAMAN|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class YOG_525:MinionBase{
//NAME=健身肌器人
//TEXT=<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。<b>锻造：</b>改为+2/+2。
//MAJ=PALADIN|COST=3|ATK=2|HP=4|RACE=MECHANICAL
}
public class YOG_525e:Ability{
//NAME=练无止境
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_525e1:Ability{
//NAME=练无止境
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_525t:MinionBase{
//NAME=健身肌器人
//TEXT=<b>已锻造</b> <b>战吼：</b>使你手牌中的所有随从牌获得+2/+2。
//MAJ=PALADIN|COST=3|ATK=2|HP=4|RACE=MECHANICAL
}
public class YOG_526:SpellBase{
//NAME=触须缠握
//TEXT=造成$3点伤害。<b>连击：</b>获取一张1/1的混乱触须。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class YOG_527:MinionBase{
//NAME=迷你灭世者
//TEXT=<b>战吼：</b>如果你控制着其他机械，则造成4点伤害。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class YOG_528:MinionBase{
//NAME=受污染的鞭笞者
//TEXT=<b>战吼：</b>在本局对战中， 如果你施放过5个或以上法术，复原4个法力水晶。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=NONE
}
public class YOG_529:SpellBase{
//NAME=禁忌之果
//TEXT=消耗你所有的法力值。<b>抉择：</b>获得在本回合中的等量攻击力；或者获得双倍的护甲值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_529a:SpellBase{
//NAME=品尝罪孽
//TEXT=消耗你所有的法力值，在本回合中获得等量的攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_529b:SpellBase{
//NAME=拒绝诱惑
//TEXT=消耗你所有的法力值，获得双倍的护甲值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_529e:Ability{
//NAME=禁忌之果
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class YOG_530:MinionBase{
//NAME=暮光头领古加尔
//TEXT=<b>嘲讽</b>。<b>吸血</b>。<b>对战开始时：</b>有50%的几率用一项随机的畸变来腐蚀这场对战。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class YOG_530e:Ability{
//NAME=灵魂绑定
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
