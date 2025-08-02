using System.Collections;
using System.Collections.Generic;

public class BTA_01:HeroBase{
//NAME=阿兰娜·逐星
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_01p:HeroPowerBase{
//NAME=趁手工具
//TEXT=从你的牌库中<b>发现</b>一张牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_01s:SpellBase{
//NAME=天生领袖
//TEXT=聚集流放者，准备战斗！
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_02:HeroBase{
//NAME=释放自我的阿兰娜
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_02p:HeroPowerBase{
//NAME=组合出击
//TEXT=在本回合中+1攻击力。如果友方随从攻击过，则改为+2攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_02pe:Ability{
//NAME=组合攻击
//TEXT=在本回合中，你的英雄拥有+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_02pe2:Ability{
//NAME=组合攻击
//TEXT=在本回合中，你的英雄拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_02s:SpellBase{
//NAME=天生领袖
//TEXT=聚集你的恶魔猎手……准备战争！
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_03:MinionBase{
//NAME=流放者巴度
//TEXT=<b>战吼：</b>消灭一个敌方随从。<b>流放：</b>获得<b>潜行</b>和<b>剧毒</b>。
//MAJ=ROGUE|COST=5|ATK=5|HP=6|RACE=NONE
}
public class BTA_03e:Ability{
//NAME=暮光迷彩
//TEXT=拥有<b>潜行</b>和<b>剧毒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_05:MinionBase{
//NAME=流放者斯克里布
//TEXT=相邻的随从拥有+1攻 击力和<b>嘲讽</b>。<b>流放：</b>召唤两个0/6的亮顶蘑菇。
//MAJ=DRUID|COST=4|ATK=2|HP=6|RACE=NONE
}
public class BTA_05e:Ability{
//NAME=自然伪装
//TEXT=斯克里布使其获得+1攻击力和<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_06:MinionBase{
//NAME=恶魔猎手斯克里布
//TEXT=你的其他随从拥有+2攻击力。<b>流放：</b>召唤三个1/1并具有<b>突袭</b>的伊利达雷。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=6|RACE=NONE
}
public class BTA_06e:Ability{
//NAME=斯克里布的强化
//TEXT=斯克里布使本随从获得+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_07:MinionBase{
//NAME=流放者卡纳克
//TEXT=<b>吸血</b> 你的治疗翻倍。<b>流放：</b>召唤一个2/5的被禁锢的矮劣魔。
//MAJ=PRIEST|COST=5|ATK=3|HP=7|RACE=NONE
}
public class BTA_08:MinionBase{
//NAME=恶魔猎手卡纳克
//TEXT=<b>吸血</b> 你的治疗翻倍。<b>流放：</b>召唤一个10/6的被禁锢的安塔恩。
//MAJ=DEMONHUNTER|COST=5|ATK=4|HP=8|RACE=NONE
}
public class BTA_09:MinionBase{
//NAME=流放者沙尔亚
//TEXT=<b>风怒，突袭</b> <b>流放：</b>将三张萨满祭司法术牌置入你的 手牌。
//MAJ=SHAMAN|COST=6|ATK=3|HP=9|RACE=NONE
}
public class BTA_09e:Ability{
//NAME=休眠的沙尔亚
//TEXT=<b>休眠</b>。 4个恶魔死亡后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_10:MinionBase{
//NAME=恶魔猎手沙尔亚
//TEXT=<b>风怒，突袭</b> <b>流放：</b>随机装备一把武器，并将3张武器牌置入你的手牌。
//MAJ=DEMONHUNTER|COST=6|ATK=5|HP=9|RACE=NONE
}
public class BTA_11:MinionBase{
//NAME=锈誓勇士
//TEXT=<b>冲锋，战吼：</b>腐化你对手的一张可用手牌。对手将有一个回合的机会来使用那张牌！
//MAJ=WARLOCK|COST=6|ATK=5|HP=7|RACE=DEMON
}
public class BTA_11e:Ability{
//NAME=随锈而逝
//TEXT=在你的回合结束时弃掉这张牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_12:MinionBase{
//NAME=铁锈军团甘尔葛
//TEXT=在你的回合结束时，随机使你的一张手牌法力值消耗减少 （3）点。
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=DEMON
}
public class BTA_12e:Ability{
//NAME=铁锈铸造
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_13:SpellBase{
//NAME=邪变
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，则召唤一个3/3的被禁锢的拾荒小鬼。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FEL
}
public class BTA_14:MinionBase{
//NAME=铁锈蜥蜴
//TEXT=<b>剧毒</b> 在你的回合开始时，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class BTA_15:SpellBase{
//NAME=无尽军团
//TEXT=抽三张牌。召唤抽到的随从。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BTA_16:MinionBase{
//NAME=铁锈真菌巨人
//TEXT=<b>亡语：</b>随机召唤一个机械。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=4|RACE=NONE
}
public class BTA_17:MinionBase{
//NAME=铁锈虚空行者
//TEXT=<b>嘲讽</b> 在你的回合开始时，为本随从恢复2点生命值。
//MAJ=WARLOCK|COST=2|ATK=1|HP=4|RACE=DEMON
}
public class BTA_18:HeroBase{
//NAME=训练中的阿兰娜
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_18s:SpellBase{
//NAME=天生领袖
//TEXT=聚集你的恶魔猎手……准备战争！
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_01e:Ability{
//NAME=达克瑞尔之语
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_01h:HeroBase{
//NAME=审判官达克瑞尔
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_01p:HeroPowerBase{
//NAME=布道
//TEXT=消灭一个友方随从并触发其<b>亡语</b> 两次。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_02e:Ability{
//NAME=随锈而逝
//TEXT=在你的回合结束时弃掉这张牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_02h:HeroBase{
//NAME=佐戈斯
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_02p:HeroPowerBase{
//NAME=铁锈视线
//TEXT=腐化你对手的一张手牌。对手将有一个回合的机会来使用那张牌！
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_03e:Ability{
//NAME=暴虐
//TEXT=在本回合中+4攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_03h:HeroBase{
//NAME=顶级捕食者兹克索尔
//TEXT=
//MAJ=HUNTER|COST=1|ATK=0|HP=40|RACE=NONE
}
public class BTA_BOSS_03p:HeroPowerBase{
//NAME=杂食野性
//TEXT=在本回合中获得+4攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_03t:MinionBase{
//NAME=亮顶蘑菇
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=6|RACE=NONE
}
public class BTA_BOSS_04h:HeroBase{
//NAME=巴萨拉克
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_04p:HeroPowerBase{
//NAME=尽为我用
//TEXT=<b>被动</b> 在一个恶魔死亡后，抽一张牌并为你的英雄恢复10点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_04s:SpellBase{
//NAME=铁锈掩埋
//TEXT=巴萨拉克正在腐化流放者，诱使他们加入铁锈军团。救出卡纳克，他就会加入你的团队！
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_05h:HeroBase{
//NAME=终极坎雷萨德
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class BTA_BOSS_05p:HeroPowerBase{
//NAME=废铁重生
//TEXT=召唤三个在本局对战中死亡的友方恶魔。摧毁你的四个法力水晶。
//MAJ=WARLOCK|COST=10|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_06h:HeroBase{
//NAME=博格拉克·暴链
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class BTA_BOSS_06p:HeroPowerBase{
//NAME=机油工人
//TEXT=在任何机械死亡后，双方玩家各获得一张<b>零件</b>牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_06t:MinionBase{
//NAME=损坏的攻城车
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=12|RACE=NONE
}
public class BTA_BOSS_06te:Ability{
//NAME=需要维修
//TEXT=使用12个零件来维修
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07e:Ability{
//NAME=邪能风暴大逃亡效果
//TEXT=保持效果以便施放邪能风暴法术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07h:HeroBase{
//NAME=邪能风暴大逃亡
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_07h2:HeroBase{
//NAME=偷来的攻城车
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_07p:HeroPowerBase{
//NAME=邪能旋风
//TEXT=<b>被动</b> 愤怒的随从正从邪能风暴中倾巢而出！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07p2:HeroPowerBase{
//NAME=动力重连
//TEXT=你每有一张手牌，便发射一枚造成$1点伤害的飞弹。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07p2e:Ability{
//NAME=动力重连玩家附加效果
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07s:SpellBase{
//NAME=涡轮加速
//TEXT=离成功逃脱缩短了两个回合！
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07s2:SpellBase{
//NAME=尾气回火
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class BTA_BOSS_07s3:SpellBase{
//NAME=地狱火火炮
//TEXT=随机轰炸一个敌方随从，造成$8点伤害，并说服另一个敌方随从换边站！
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FEL
}
public class BTA_BOSS_07s4:SpellBase{
//NAME=自我修复
//TEXT=为你的英雄恢复5点生命值，并获得5点护甲值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_07s5:SpellBase{
//NAME=填充燃料
//TEXT=暂停逃脱，补充燃料，抽三张牌。逃脱时间增加两回合。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_08h:HeroBase{
//NAME=莎赫拉丝主母
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_08p:HeroPowerBase{
//NAME=招架反击
//TEXT=<b>被动</b> 每回合中你第一次受到伤害时，防止这次伤害并反击回去！
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_09h:HeroBase{
//NAME=流放者沙尔亚
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_09h2:HeroBase{
//NAME=恶魔猎手沙尔亚
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_09p:HeroPowerBase{
//NAME=邪能闪电
//TEXT=<b>被动</b> 在你使用一张<b>过载</b>牌后，随机施放一个闪电法术！
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_10e:Ability{
//NAME=邪能孢子
//TEXT=+1/+1
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_10h:HeroBase{
//NAME=流放者卡纳克
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_10h2:HeroBase{
//NAME=流放者斯克里布
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_10h3:HeroBase{
//NAME=恶魔猎手卡纳克
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_10h4:HeroBase{
//NAME=恶魔猎手斯克里布
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_10p:HeroPowerBase{
//NAME=恶魔之光
//TEXT=对一个随从造成$2点伤害。如果该随从死亡，则为你的英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_10p2:HeroPowerBase{
//NAME=邪能孢子
//TEXT=消灭一个亮顶蘑菇，使你的所有随从获得+1/+1， 抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_10t:MinionBase{
//NAME=亮顶蘑菇
//TEXT=<b>亡语：</b> 将本随从的一张复制洗入你的牌库。
//MAJ=DRUID|COST=0|ATK=1|HP=6|RACE=NONE
}
public class BTA_BOSS_11e:Ability{
//NAME=火箭驱动
//TEXT=由火箭驱动！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_11h:HeroBase{
//NAME=杰卡兹
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_11p:HeroPowerBase{
//NAME=火箭之翼
//TEXT=<b>被动</b> 你的所有随从拥有<b>突袭</b>和<b>风怒</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_11pe:Ability{
//NAME=火箭之翼玩家强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_12h:HeroBase{
//NAME=终极玛瑟里顿
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class BTA_BOSS_12p:HeroPowerBase{
//NAME=魔油与铁锈
//TEXT=<b>被动</b> 你的英雄在你的回合中受到伤害后，召唤一个2/2的铁锈邪兽人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_12t:MinionBase{
//NAME=铁锈邪兽人
//TEXT=在本随从攻击后，使所有其他铁锈邪兽人获得+1攻击力。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BTA_BOSS_12te:Ability{
//NAME=铁锈之怒
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_13h:HeroBase{
//NAME=高卡莫克
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_13p:HeroPowerBase{
//NAME=副首建议
//TEXT=随机施放一个外域法术，或召唤一个铁锈军团成员。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_14h:HeroBase{
//NAME=弗利克
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=25|RACE=NONE
}
public class BTA_BOSS_14h2:HeroBase{
//NAME=锈蚀的魔能机甲
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BTA_BOSS_14p:HeroPowerBase{
//NAME=召集炮灰
//TEXT=召唤一个1/1的游荡小鬼。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_14p2:HeroPowerBase{
//NAME=庞然大物
//TEXT=<b>被动</b> 你的所有随从拥有+2攻击力。魔能机甲改为+10攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_14p2e:Ability{
//NAME=邪能驱动
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_14p2e2:Ability{
//NAME=邪能驱动
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_15e:Ability{
//NAME=锈蚀之触
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_15e2:Ability{
//NAME=铁锈诡计
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_15h:HeroBase{
//NAME=终极巴度
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class BTA_BOSS_15p:HeroPowerBase{
//NAME=堕入铁锈
//TEXT=<b>被动</b> 在你使用一张随从牌后，使其获得<b>潜行</b>或<b>剧毒</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_15s:SpellBase{
//NAME=巴度的临终赠礼
//TEXT=<b>对战开始时：</b>抽到这张牌。消灭所有恶魔。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16e:Ability{
//NAME=邪能与仇恨
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16h:HeroBase{
//NAME=机械加拉克苏斯
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class BTA_BOSS_16p:HeroPowerBase{
//NAME=邪能与仇恨
//TEXT=<b>被动</b> 在你的回合结束时，提升你的反应堆的能量。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16s:SpellBase{
//NAME=恶魔铸造
//TEXT=随机召唤两个法力值消耗为$1点的<b>休眠</b>2回合的恶魔<i>（受<b>法术伤害</b>加成影响）</i>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16se:Ability{
//NAME=恶魔铸造
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16t:MinionBase{
//NAME=邪能反应堆
//TEXT=<b>法术伤害+1</b> <b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARLOCK|COST=0|ATK=0|HP=3|RACE=MECHANICAL
}
public class BTA_BOSS_16t2:MinionBase{
//NAME=仇恨反应堆
//TEXT=在你召唤一个随从后，使其获得+1/+1。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARLOCK|COST=0|ATK=0|HP=2|RACE=MECHANICAL
}
public class BTA_BOSS_16t2e:Ability{
//NAME=邪能法术伤害
//TEXT=<b>法术伤害</b>提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16t2e2:Ability{
//NAME=仇恨能量
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16te:Ability{
//NAME=邪能
//TEXT=邪能反应堆使其获得+5攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16te2:MinionBase{
//NAME=邪能反应堆
//TEXT=<b>法术伤害+1</b> <b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_16te3:MinionBase{
//NAME=仇恨反应堆
//TEXT=在你召唤一个随从后，使其获得+1/+1。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_17h:HeroBase{
//NAME=伊利丹·怒风
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=100|RACE=NONE
}
public class BTA_BOSS_17h2:HeroBase{
//NAME=伊利丹·怒风
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=100|RACE=NONE
}
public class BTA_BOSS_17p:HeroPowerBase{
//NAME=盛燃之怒
//TEXT=<b>被动</b> 在你的英雄攻击后，对所有敌人造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_18h:HeroBase{
//NAME=末日领主卡扎克
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class BTA_BOSS_18p:HeroPowerBase{
//NAME=扭曲映像
//TEXT=<b>被动</b> 在一个敌方随从死亡后，为你的英雄恢复5点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_19h:HeroBase{
//NAME=屠龙者格鲁尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=50|RACE=NONE
}
public class BTA_BOSS_19p:HeroPowerBase{
//NAME=崩裂
//TEXT=造成3点伤害，随机分配到所有敌人 身上。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_19s:SpellBase{
//NAME=强者杀手
//TEXT=<b>吸血</b> 对一个敌方随从造成4点伤害。对龙造成三倍伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_20h:HeroBase{
//NAME=玛瑟里顿
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_20p:HeroPowerBase{
//NAME=冲击新星
//TEXT=召唤一个控制方格。如果你有三个或以上方格，则改为对敌方英雄造成$10点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_20t:MinionBase{
//NAME=控制方格
//TEXT=无法攻击。 <b>亡语：</b>对你的英雄造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
}
public class BTA_BOSS_21h:HeroBase{
//NAME=苏普雷姆斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_21p:HeroPowerBase{
//NAME=火山喷射
//TEXT=对所有敌人造成$1点伤害。每有一个随从死亡，召唤一个6/6的渊狱火。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_22h:HeroBase{
//NAME=塔隆·血魔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_22p:HeroPowerBase{
//NAME=死亡之影
//TEXT=召唤一个4/4的阴暗构造体。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_22s:SpellBase{
//NAME=复仇之魂
//TEXT=消灭所有阴暗构造体。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class BTA_BOSS_22t:MinionBase{
//NAME=阴暗构造体
//TEXT=在一个敌方随从死亡后，对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NONE
}
public class BTA_BOSS_23h:HeroBase{
//NAME=莎赫拉丝主母
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_23p:HeroPowerBase{
//NAME=招架反击
//TEXT=<b>被动</b> 每回合中你第一次受到伤害时，防止这次伤害并反击回去！
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_24h:HeroBase{
//NAME=瓦丝琪女士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_24p:HeroPowerBase{
//NAME=闪电震击
//TEXT=对一个敌方随从造成$3点伤害。如果它依然存活，抽一张牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_24t:MinionBase{
//NAME=盘牙精英
//TEXT=<b>突袭</b> 在本随从攻击后，召唤一个中立鱼人。
//MAJ=SHAMAN|COST=6|ATK=6|HP=8|RACE=NONE
}
public class BTA_BOSS_25h:HeroBase{
//NAME=凯尔萨斯·逐日者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_25p:HeroPowerBase{
//NAME=炽炎魔法
//TEXT=<b>被动</b> 在你施放一个法术后，将一张“炎爆术”置入你的牌库，其法力值消耗减少（5）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_25p2:HeroPowerBase{
//NAME=引力失效
//TEXT=<b>被动</b> 你无法被攻击。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_25pe:Ability{
//NAME=炽炎魔法附加效果
//TEXT=法力值消耗减少（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_25s:SpellBase{
//NAME=引力失效
//TEXT=将所有敌方随从移回对手的手牌，并且法力值消耗增加（3）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_25se:Ability{
//NAME=引力失效附加效果
//TEXT=法力值消耗增加（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_26h:HeroBase{
//NAME=伊利丹·怒风
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=60|RACE=NONE
}
public class BTA_BOSS_26p:HeroPowerBase{
//NAME=盛燃之怒
//TEXT=<b>被动</b> 在你的英雄攻击后，对所有敌人造成$1点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_26s:SpellBase{
//NAME=你们这是自寻死路
//TEXT=在本回合中，使你的英雄获得+2攻击力和<b>吸血</b>，然后攻击所有敌人。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BTA_BOSS_26se:Ability{
//NAME=备战就绪
//TEXT=在本回合中拥有+2攻击力和<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BTA_Prevent_First_turn_Attack:Ability{
//NAME=精疲力竭
//TEXT=在本回合中，无法进行攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
