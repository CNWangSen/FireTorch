using System.Collections;
using System.Collections.Generic;

public class ULDA_001:MinionBase{
//NAME=“圣光”阿玛基尔
//TEXT=在本随从攻击后，随机将两张治疗法术牌置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=6|RACE=NONE
}
public class ULDA_002:MinionBase{
//NAME=弗洛·岩印
//TEXT=<b>战吼，亡语：</b>随机将一张宝藏牌置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=4|HP=4|RACE=NONE
}
public class ULDA_003:MinionBase{
//NAME=埃达尔拉
//TEXT=<b>战吼：</b>将所有敌方随从洗入你的牌库。
//MAJ=PRIEST|COST=3|ATK=3|HP=6|RACE=NONE
}
public class ULDA_004:SpellBase{
//NAME=坎努匹克陶罐
//TEXT=使你的所有随从获得“<b>亡语：</b>随机召唤一个<b>传说</b>随从。”
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_004e:Ability{
//NAME=坎努匹克陶罐
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_005:SpellBase{
//NAME=木乃伊魔法
//TEXT=每回合中，在你使用第一张<b>亡语</b>随从牌后，使其获得<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_005e:Ability{
//NAME=木乃伊魔法玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_006:SpellBase{
//NAME=亡者之书
//TEXT=对所有敌人造成$7点伤害。在本局对战中，每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=12|ATK=0|HP=0|RACE=SHADOW
}
public class ULDA_007:SpellBase{
//NAME=钩杖与连枷
//TEXT=<b>被动</b> 在你施放一个法术后，将一个随从从你的牌库置入战场。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_007e2:Ability{
//NAME=钩杖与连枷玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_008:SpellBase{
//NAME=异鳞之杖
//TEXT=召唤三条1/1并具有<b>突袭，剧毒</b>和<b>复生</b>的蛇。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULDA_008t:MinionBase{
//NAME=远古毒蛇
//TEXT=<b>突袭，剧毒</b> <b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ULDA_009:SpellBase{
//NAME=潜力解锁
//TEXT=<b>被动</b> 对战开始时，使你所有随从牌的攻击力等同于其生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_009e:Ability{
//NAME=潜力解锁
//TEXT=攻击力等同于其生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_010:SpellBase{
//NAME=正义之剑
//TEXT=将所有随从变形成为1/1的鱼人。用随机鱼人牌填满你的手牌，其法力值消耗为（0）点。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_011:SpellBase{
//NAME=高级会员
//TEXT=<b>被动</b> 提升入住的酒馆的档次！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_012:SpellBase{
//NAME=石狐雕像
//TEXT=选择一个随从，将两张它的复制置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULDA_013:SpellBase{
//NAME=杰弗里斯的神灯
//TEXT=<b>对战开始时：</b>抽到这张牌。许愿获得一张完美的卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_014:SpellBase{
//NAME=传说金碟
//TEXT=<b>被动</b> 在你使用一张传说随从牌后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_014d:SpellBase{
//NAME=传说金碟占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_014e:Ability{
//NAME=传说金碟玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_015:MinionBase{
//NAME=初级侦查员
//TEXT=<b>冲锋，风怒</b> 在你的回合结束时，随机对一个敌方随从造成4点伤害。
//MAJ=SHAMAN|COST=3|ATK=4|HP=4|RACE=NONE
}
public class ULDA_016:MinionBase{
//NAME=初级探墓员
//TEXT=<b>战吼：</b>在本局对战中，如果你使用了6张奥秘牌，则将你的英雄技能变为“<b>发现</b>一张宝藏牌”。
//MAJ=MAGE|COST=4|ATK=5|HP=5|RACE=NONE
}
public class ULDA_017:MinionBase{
//NAME=初级导航员
//TEXT=每当你以本随从为目标施放一个法术，将法术牌的两张复制置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=1|HP=5|RACE=NONE
}
public class ULDA_018:MinionBase{
//NAME=初级挖掘师
//TEXT=<b>战吼：</b>抽三张牌。抽到的随从牌法力值消耗减少（2）点。
//MAJ=HUNTER|COST=4|ATK=2|HP=5|RACE=NONE
}
public class ULDA_018e:Ability{
//NAME=挖掘出土
//TEXT=法力值消耗减少（2）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_019:SpellBase{
//NAME=运货驮骡
//TEXT=使你初始10张卡牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_019e:Ability{
//NAME=减轻负重
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_020:MinionBase{
//NAME=高级侦查员
//TEXT=<b>冲锋，风怒</b> 在你的回合结束时，随机对一个敌方随从造成6点伤害。
//MAJ=SHAMAN|COST=3|ATK=6|HP=6|RACE=NONE
}
public class ULDA_021:MinionBase{
//NAME=高级探墓员
//TEXT=<b>战吼：</b>在本局对战中，如果你使用了3张奥秘牌，则将你的英雄技能变为“<b>发现</b>一张宝藏牌”。
//MAJ=MAGE|COST=4|ATK=7|HP=7|RACE=NONE
}
public class ULDA_022:MinionBase{
//NAME=高级导航员
//TEXT=每当你以本随从为目标施放一个法术，将法术牌的两张复制置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=2|HP=10|RACE=NONE
}
public class ULDA_023:MinionBase{
//NAME=高级挖掘师
//TEXT=<b>战吼：</b>抽三张牌。抽到的随从牌法力值消耗减少（5）点。
//MAJ=HUNTER|COST=4|ATK=3|HP=6|RACE=NONE
}
public class ULDA_023e:Ability{
//NAME=深度挖掘
//TEXT=法力值消耗减少（5）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_024:SpellBase{
//NAME=高级驮骡
//TEXT=使你牌库中所有卡牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_024e:Ability{
//NAME=减轻负重
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_026:MinionBase{
//NAME=希亚玛特的仆从
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=ELEMENTAL
}
public class ULDA_030:SpellBase{
//NAME=流沙陷阱
//TEXT=<b>抽到时施放</b> 移除你牌库顶的两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_031:MinionBase{
//NAME=圣殿魔像
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class ULDA_032:MinionBase{
//NAME=怒火魔像
//TEXT=<b>亡语：</b>对所有随从造成3点伤害，并召唤一个圣殿魔像。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class ULDA_033:MinionBase{
//NAME=拉卡尼休
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的<b>跟班</b>变为4/4。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=ELEMENTAL
}
public class ULDA_034:MinionBase{
//NAME=逃生旋翼机
//TEXT=<b>突袭</b>。<b>亡语：</b>对所有敌方随从造成5点伤害，然后将本随从洗入你的牌库。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=1|RACE=MECHANICAL
}
public class ULDA_035:SpellBase{
//NAME=神秘幻象
//TEXT=<b>双生法术</b> 复原你所有的法力水晶，并在本回合中获取新的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_035d:SpellBase{
//NAME=幻象占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_035e:Ability{
//NAME=幻象玩家强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_035ts:SpellBase{
//NAME=神秘幻象
//TEXT=复原你所有的法力水晶，并在本回合中获取新的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_036:SpellBase{
//NAME=飞蝗来袭
//TEXT=<b>双生法术</b> 选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_036t:MinionBase{
//NAME=巨型蝗虫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class ULDA_036ts:SpellBase{
//NAME=飞蝗来袭
//TEXT=选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_038:SpellBase{
//NAME=回炉重修
//TEXT=选择一个新的初始英雄技能。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_039:HeroPowerBase{
//NAME=奥丹姆宝箱
//TEXT=<b>发现</b>一张宝藏牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_040:SpellBase{
//NAME=群灯荟萃
//TEXT=<b>对战开始时：</b>抽到这张牌。用杰弗里斯的神灯填满你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_041:SpellBase{
//NAME=阿穆纳伊之杖
//TEXT=<b>双生法术</b> 在本回合中，你的所有随从拥有<b>风怒</b>以及<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ULDA_041e:Ability{
//NAME=王室热忱
//TEXT=在本回合中获得<b>风怒</b>以及<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_041e2:Ability{
//NAME=王室热忱
//TEXT=在本回合中，你的随从拥有<b>风怒</b>和<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_041ts:SpellBase{
//NAME=阿穆纳伊之杖
//TEXT=在本回合中，你的随从拥有<b>风怒</b>和<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ULDA_042:SpellBase{
//NAME=暗光之炬
//TEXT=<b>被动</b> 在你使用一张法力值消耗为偶数的卡牌后，复原你的英雄技能。在本回合中英雄技能法力值消耗变为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_042e:Ability{
//NAME=暗光之炬玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_042e2:Ability{
//NAME=暗光之炬
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_043:WeaponBase{
//NAME=法奥瑞斯之刃
//TEXT=<b>风怒</b> 在你的英雄攻击并消灭一个随从后，该武器获得+2/+1。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=3|RACE=NONE
}
public class ULDA_043e:Ability{
//NAME=法奥瑞斯之怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_044:WeaponBase{
//NAME=灼日之刃
//TEXT=<b>战吼：</b> 使你牌库中的所有随从牌获得+2攻击力。 <b>亡语：</b>将这把武器移回你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class ULDA_044e:Ability{
//NAME=烈日灼灼
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_045:SpellBase{
//NAME=始生壁垒
//TEXT=<b>被动</b> 防止致命伤害，并对敌方英雄造成$20点伤害<i>（每场对战限一次）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_045t:SpellBase{
//NAME=始生壁垒
//TEXT=<b>奥秘：</b>防止致命伤害，并对敌方英雄造成$20点伤害<i>（可以在你的回合触发）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_046:SpellBase{
//NAME=蜂舞之戒
//TEXT=<b>被动</b> 你的法力值消耗小于或等于（2）点的随从拥有<b>剧毒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_046e:Ability{
//NAME=蜂舞之戒玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_046e2:Ability{
//NAME=蜂舞之戒
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_101:SpellBase{
//NAME=圣甲虫指环
//TEXT=<b>被动</b> 敌方随从拥有-1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_101e:Ability{
//NAME=圣甲虫指环玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_101e2:Ability{
//NAME=圣甲虫指环
//TEXT=-1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_102:SpellBase{
//NAME=迅捷圆盘
//TEXT=<b>被动</b> 你对手的前两个回合必须空过。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_102e:Ability{
//NAME=迅捷圆盘玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_103:SpellBase{
//NAME=炼金石
//TEXT=<b>被动</b> 在你使用一张法力值消耗为奇数的卡牌后，你的手牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_103e:Ability{
//NAME=炼金石玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_103e2:Ability{
//NAME=炼金术第一法则
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_110:MinionBase{
//NAME=蠕行之爪
//TEXT=<b>突袭，复生</b> <b>亡语：</b>从你对手的手牌中偷取一张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class ULDA_111:SpellBase{
//NAME=炉石
//TEXT=<b>对战开始时：</b>抽到这张牌。逃到酒馆，并将这张牌移出你的冒险套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_112:SpellBase{
//NAME=鲍勃的保镖
//TEXT=选择一个随从，然后施放“绝命乱斗”。如果该随从依然存活，则用它的复制填满你的面板。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_113:MinionBase{
//NAME=硬壳横行蟹
//TEXT=<b>战吼：</b>消灭一个随从。获得其双倍的攻击力和生命值。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=4|RACE=BEAST
}
public class ULDA_113e:Ability{
//NAME=嚼啊嚼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_114:WeaponBase{
//NAME=死亡护盾
//TEXT=你的英雄<b>免疫</b>。每个回合损失1点耐久度。<b>亡语：</b>对你的英雄造成100点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=10|RACE=NONE
}
public class ULDA_115:SpellBase{
//NAME=“侏儒克星”
//TEXT=造成$10点伤害。在迎战<b>灾祸领主</b>时，也会对灾祸领主造成$10点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_116:SpellBase{
//NAME=无恒药剂
//TEXT=<b>被动</b> 在你的回合结束时，将一个友方随从变形成为法力值消耗增加（1）点的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_116e:Ability{
//NAME=无恒药剂玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_117:SpellBase{
//NAME=无用卷轴
//TEXT=<b>被动</b> <b>法术伤害+10</b>。在你的回合结束时，失去1点<b>法术伤害</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_117e:Ability{
//NAME=无用卷轴玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_118:SpellBase{
//NAME=机动炸药
//TEXT=炸掉你对手的一半物资。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=FIRE
}
public class ULDA_201:WeaponBase{
//NAME=雷诺的灵动套索
//TEXT=在你的英雄攻击后，从你对手的手牌中偷取 一张牌。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class ULDA_202:WeaponBase{
//NAME=科多皮鞭
//TEXT=在你的英雄攻击一个随从后，如果该随从依然存活，则将其置于你的手牌中。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class ULDA_203:SpellBase{
//NAME=雷诺的幸运帽
//TEXT=使一个随从获得+2/+2以及<b>法术伤害+2</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_203e:Ability{
//NAME=雷诺的幸运帽
//TEXT=+2/+2以及<b>法术伤害+2</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_204:SpellBase{
//NAME=雷诺的魔法火把
//TEXT=造成$4点伤害。<b>连击：</b>将这张牌的一张复制洗入你的牌库，其造成的伤害增加2点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_205:SpellBase{
//NAME=幸运铁铲
//TEXT=<b>被动</b> 在你<b>发现</b>一张卡牌后，将两张该牌的复制置入你的手牌。这三张卡牌的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_205d:SpellBase{
//NAME=幸运铁铲占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_205e:Ability{
//NAME=幸运铁铲玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_206:MinionBase{
//NAME=雷·火掌
//TEXT=在你施放一个法术后，再次施放该法术<i>（目标不变）</i>。
//MAJ=MAGE|COST=2|ATK=2|HP=6|RACE=NONE
}
public class ULDA_207:SpellBase{
//NAME=加特林法杖
//TEXT=造成$3点伤害，随机分配到所有敌人身上<i>（在本局对战中你每施放一个法术都会提高）</i>。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class ULDA_208:SpellBase{
//NAME=泰坦指环
//TEXT=<b>被动</b> 你的所有随从拥有+1生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_208e:Ability{
//NAME=泰坦指环玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_208e2:Ability{
//NAME=泰坦指环
//TEXT=+1生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_208e3:Ability{
//NAME=泰坦指环
//TEXT=+1生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_301:SpellBase{
//NAME=奥丹姆地图
//TEXT=你在本次冒险中每击败一个<b>首领</b>，便<b>发现</b>一张卡牌并获得一个法力水晶。1<b>发现</b>{0}张牌。获得{0}个法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_302:SpellBase{
//NAME=学术研究
//TEXT=<b>对战开始时：</b>抽到这张牌。获得1个法力水晶<i>（每当一个友方随从死亡时都会升级）</i>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_302e:Ability{
//NAME=伊莉斯的发现
//TEXT=+5/+5并具有<b>吸血</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_303:SpellBase{
//NAME=逐星套装
//TEXT=<b>发现</b>一张随从牌和一张法术牌，其法力值消耗减少 （2）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_303e:Ability{
//NAME=事预则立
//TEXT=法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_304:SpellBase{
//NAME=重生法杖
//TEXT=复活七个法力值消耗最高的友方随从，并使其获得 <b>嘲讽</b>。
//MAJ=PRIEST|COST=7|ATK=0|HP=5|RACE=NONE
}
public class ULDA_305:WeaponBase{
//NAME=伊莉斯的弯刀
//TEXT=在你的英雄攻击后，召唤两个2/2的树人，并使其获得<b>突袭</b>。
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULDA_306:SpellBase{
//NAME=失窃的泰坦机密
//TEXT=在本次冒险的剩余时间内，复制<b>首领</b>的英雄技能。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_307:SpellBase{
//NAME=甲虫金饰
//TEXT=<b>双生法术</b> 复活在本局对战中最先死亡的四个友方随从。使其获得<b>复生</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_307ts:SpellBase{
//NAME=甲虫金饰
//TEXT=复活在本局对战中最先死亡的四个友方随从。使其获得 <b>复生</b>。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_401:WeaponBase{
//NAME=靠谱的老猎枪
//TEXT=在你的英雄攻击后，对所有敌人造成1点伤害。
//MAJ=WARRIOR|COST=3|ATK=4|HP=2|RACE=NONE
}
public class ULDA_402:SpellBase{
//NAME=布莱恩的鞍座
//TEXT=使一个友方野兽获得+3/+3，以及“<b>亡语：</b>随机将布莱恩的鞍座甩给另一个友方野兽。”
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_402d:SpellBase{
//NAME=布莱恩的鞍座占位效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_402e:Ability{
//NAME=鞍鞯齐备
//TEXT=+3/+3。<b>亡语：</b>随机将布莱恩的鞍座甩给另一个友方野兽。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_403:SpellBase{
//NAME=远古映像
//TEXT=选择一个随从。用它的1/1的复制填满你的面板。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULDA_403e:Ability{
//NAME=泰坦全息影像
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_404:SpellBase{
//NAME=泰坦钩爪
//TEXT=随机消灭两个敌方随从。获得等同于两个随从攻击力之和的护甲值。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_405:MinionBase{
//NAME=布莱恩的宝贝蛋
//TEXT=在本随从受到伤害后，召唤暴龙王 克鲁什。
//MAJ=HUNTER|COST=6|ATK=0|HP=5|RACE=NONE
}
public class ULDA_406:SpellBase{
//NAME=奔波尔霸的战斗号角
//TEXT=召唤七个鱼人并使其获得<b>突袭</b>。在你的下回合开始时，再次召唤。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class ULDA_406d:SpellBase{
//NAME=奔波尔霸号角占位
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_406e:Ability{
//NAME=为了鱼人！
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_406e2:Ability{
//NAME=奔波尔霸的战斗号角玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_407:SpellBase{
//NAME=追踪器
//TEXT=<b>对战开始时：</b>抽到这张牌。从你的牌库中抽取法力值消耗为（2），（3），（4）和（5）的卡牌 各一张。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_501:MinionBase{
//NAME=“威武战驹”麦克斯韦
//TEXT=<b>突袭，复生</b> 战场上每有一个其他随从，便拥有+2攻击力。
//MAJ=PALADIN|COST=3|ATK=3|HP=5|RACE=BEAST
}
public class ULDA_502:SpellBase{
//NAME=芬利的冒险头盔
//TEXT=使你的所有随从获得+2生命值。将这张牌洗入你的牌库。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_502e:Ability{
//NAME=沙漠探险者
//TEXT=+2生命值
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_503:SpellBase{
//NAME=高级瞄准镜
//TEXT=施放你牌库中所有法术牌的复制<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULDA_504:SpellBase{
//NAME=下午茶
//TEXT=<b>仅在下一场首领战中</b>获得四个法力水晶，额外抽两张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_505:WeaponBase{
//NAME=真银长枪
//TEXT=<b>吸血</b> 在你<b>过载</b>后，获得+2耐久度。
//MAJ=SHAMAN|COST=3|ATK=5|HP=1|RACE=NONE
}
public class ULDA_505e:Ability{
//NAME=真厉害
//TEXT=耐久度提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_507:MinionBase{
//NAME=走失的卡尔
//TEXT=<b>战吼：</b>召唤六个1/1的白银之手新兵，并使所有友方随从获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=6|HP=6|RACE=NONE
}
public class ULDA_508:SpellBase{
//NAME=缩法长袍
//TEXT=<b>被动</b> 在你抽到一张法术牌后，在本回合中将其法力值消耗减为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_508e:Ability{
//NAME=学识涌动玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_508e2:Ability{
//NAME=学识涌动
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_601:SpellBase{
//NAME=成员更替
//TEXT=选择一个友方随从。<b>发现</b>一个随从来将其替换出你的冒险模式套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_602:SpellBase{
//NAME=研究中断
//TEXT=<b>发现</b>一张法术牌。将其置入你的冒险模式套牌，它将始终出现在你的起始手牌中。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_603:SpellBase{
//NAME=友好的铁匠
//TEXT=<b>发现</b>一张任意职业的武器牌。使其获得+2/+2并置入你的冒险模式套牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_603e:Ability{
//NAME=友情升级
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_604:SpellBase{
//NAME=四人成众
//TEXT=<b>发现</b>一张随从牌。将所有敌方随从替换成与该随从类型相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_605:SpellBase{
//NAME=便捷快餐
//TEXT=将所有敌方随从加入你的冒险模式套牌。其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_605e:Ability{
//NAME=酒足饭饱
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_606:SpellBase{
//NAME=快去干活
//TEXT=将一个友方随从移出你的冒险模式套牌。使相邻的随从获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_606e:Ability{
//NAME=快去干活
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_607:SpellBase{
//NAME=外卖特供
//TEXT=将你的冒险模式套牌替换为鲍勃的一副惊爆套牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_608:SpellBase{
//NAME=精打细算
//TEXT=将所有法力值消耗小于或等于（2）点的卡牌移出你的冒险模式套牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_701e2:Ability{
//NAME=鱼人当家
//TEXT=<b>亡语：</b>随机召唤一个鱼人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_702:SpellBase{
//NAME=畸变：挥金如土
//TEXT=在使用一张随从牌后，使对方玩家获得一张幸运币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_702d:SpellBase{
//NAME=挥金如土占位
//TEXT=虚拟关联ULDA702e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_702e:Ability{
//NAME=畸变：挥金如土玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_703e2:Ability{
//NAME=窃据灵魂
//TEXT=<b>亡语：</b>随机夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_705:SpellBase{
//NAME=畸变：炸弹轰鸣
//TEXT=每当随从死亡时，都会将一张“炸弹”牌洗入随从拥有者的牌库。当抽到“炸弹”时，便会受到5点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_705d:SpellBase{
//NAME=爆破大师占位
//TEXT=虚拟关联ULDA705e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_705e:Ability{
//NAME=畸变：炸弹轰鸣玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_706:SpellBase{
//NAME=畸变：不许打脸
//TEXT=英雄在控制随从时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_706e:Ability{
//NAME=畸变：不许打脸玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_707:SpellBase{
//NAME=畸变：永恒大军
//TEXT=在随从死亡后，会将它的一张复制洗入随从拥有者的 牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_707d:SpellBase{
//NAME=永恒大军占位
//TEXT=虚拟关联ULDA707e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_707e:Ability{
//NAME=畸变：永恒大军玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_708:SpellBase{
//NAME=畸变：眩惑冲击
//TEXT=在一个英雄受到伤害后，随机调整其所有手牌的法力值 消耗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_708d:SpellBase{
//NAME=Dizzying Blows Dummy
//TEXT=虚拟关联ULDA708e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_708e:Ability{
//NAME=Anomaly - Dizzying Blows Player Enchantment
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_708e2:Ability{
//NAME=眩惑冲击卡牌附加效果
//TEXT=法力值消耗已被随机调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_709:SpellBase{
//NAME=畸变：天使神迹
//TEXT=随从的攻击力<b>始终</b>等同于其生 命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_709e:Ability{
//NAME=畸变：天使神迹玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_709e2:Ability{
//NAME=天使神迹
//TEXT=攻击力始终等同于生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_710:SpellBase{
//NAME=畸变：向前冲锋
//TEXT=所有随从拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_710e:Ability{
//NAME=畸变：向前冲锋玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_710e2:Ability{
//NAME=向前冲锋
//TEXT=畸变：向前冲锋使你的所有随从获得<b>冲锋</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_711:SpellBase{
//NAME=畸变：无情风怒
//TEXT=所有随从拥有<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_711e:Ability{
//NAME=畸变：无情风怒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_711e2:Ability{
//NAME=狂风之怒
//TEXT=拥有<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_712:SpellBase{
//NAME=畸变：全息影像
//TEXT=在使用一张随从牌后，为对方玩家召唤一个该随从的1/1 复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_712d:SpellBase{
//NAME=全息影像占位
//TEXT=虚拟关联ULDA712e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_712e:Ability{
//NAME=畸变：全息影像玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_713:SpellBase{
//NAME=畸变：呼啸飓风
//TEXT=在每个回合开始时，对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_713d:SpellBase{
//NAME=呼啸飓风占位
//TEXT=虚拟关联ULDA713e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_713e:Ability{
//NAME=畸变：呼啸飓风玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_714:SpellBase{
//NAME=畸变：直击面门
//TEXT=英雄受到的伤害翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_714e:Ability{
//NAME=畸变：欢迎打脸玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_715:SpellBase{
//NAME=畸变：慷慨馈赠
//TEXT=双方玩家在对战开始时拥有9张手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_719:SpellBase{
//NAME=畸变：马林归来
//TEXT=对战开始时，双方玩家的场上都会有一个宝箱。<i>（打破宝箱可以获得惊人的战利品！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_720:SpellBase{
//NAME=畸变：历战之躯
//TEXT=冒险开始时拥有100点生命值。战斗过后不会自动恢复生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_721:SpellBase{
//NAME=畸变：一片混乱
//TEXT=对战开始时，将双方的牌库混合重洗并平均分配。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_721d:SpellBase{
//NAME=一片混乱占位
//TEXT=虚拟关联ULDA721e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_724:SpellBase{
//NAME=畸变：法术护盾
//TEXT=在一个玩家施放一个法术后，便获得2点护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_724d:SpellBase{
//NAME=法术护盾占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_724e:Ability{
//NAME=畸变：法术护盾玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_729:SpellBase{
//NAME=畸变：混合职业
//TEXT=可以获得任意职业的战利品。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_801:SpellBase{
//NAME=情节：鱼人之灾祸
//TEXT=鱼人侵入了每一副套牌！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_801d:SpellBase{
//NAME=情节：鱼人之灾祸占位
//TEXT=ULDA801e占位效果
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_801e:Ability{
//NAME=鱼人情节玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_801t:SpellBase{
//NAME=鱼人惊喜
//TEXT=<b>抽到时施放</b> 随机召唤数个 鱼人。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_802:SpellBase{
//NAME=情节：疯狂之灾祸
//TEXT=在每个玩家的回合结束时，其最右边的随从会随机攻击一个敌人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_802e:Ability{
//NAME=疯狂情节玩家强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_803:SpellBase{
//NAME=情节：愤怒之灾祸
//TEXT=在一个随从受到伤害后，便会获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_803d:SpellBase{
//NAME=反击占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_803e:Ability{
//NAME=愤怒情节玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_803e2:Ability{
//NAME=暴怒
//TEXT=本随从的攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_804:SpellBase{
//NAME=情节：死亡之灾祸
//TEXT=双方玩家在对战开始时都拥有一座“永恒陵墓”。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_804t:MinionBase{
//NAME=永恒陵墓
//TEXT=在3个随从死亡后，随机召唤一个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_900:SpellBase{
//NAME=伊莉斯的随机套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_901:SpellBase{
//NAME=雷诺的随机套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_902:SpellBase{
//NAME=芬利的随机套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_903:SpellBase{
//NAME=布莱恩的随机套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_911:SpellBase{
//NAME=焚烧法术
//TEXT=查看你的冒险模式套牌中的四张法术牌。选择一张移出 套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_912:SpellBase{
//NAME=招揽人才
//TEXT=选择一个敌方随从，将其加入你的冒险模式套牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_999e:Ability{
//NAME=AI Play Control
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_01e:Ability{
//NAME=爆破之力
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_01ex:Ability{
//NAME=爆破之力
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_01h:HeroBase{
//NAME=废土游侠卡迪什
//TEXT=<i>即便是被炸死，他也要为怪盗军团尽最后一份力。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_01p:HeroPowerBase{
//NAME=高爆弹
//TEXT=召唤一个0/2的地精炸弹。使所有其他地精炸弹获得+1攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_01px:HeroPowerBase{
//NAME=高爆弹
//TEXT=召唤一个0/2的地精炸弹。使所有其他地精炸弹获得+2攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_02h:HeroBase{
//NAME=黑暗仪祭师扎法尔
//TEXT=<i>他的仪式和咖啡一样：黑，而且要冲煮两泡。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_02p:HeroPowerBase{
//NAME=木乃伊仪式
//TEXT=复活一个<b>复生</b>随从，其生命值为1点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_02px:HeroPowerBase{
//NAME=木乃伊仪式
//TEXT=复活一个<b>复生</b>随从，其生命值为1点。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_03e:Ability{
//NAME=怪盗晋升
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_03h:HeroBase{
//NAME=薇拉·莱德利
//TEXT=<i>发放工作福利时，跟班们都抢着跟她的班。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_03p:HeroPowerBase{
//NAME=怪盗晋升
//TEXT=<b>被动</b> 在你使用一张<b>跟班</b>牌后，使其获得+1/+1<i>（你每使用一张<b>跟班</b>牌都会升级）</i>。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_04h:HeroBase{
//NAME=巨虫纳什
//TEXT=<i>有传言说它其实是巨虫诺什的另一端。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_04p:HeroPowerBase{
//NAME=喷射
//TEXT=召唤一个在本局对战中死亡的随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_04px:HeroPowerBase{
//NAME=喷射
//TEXT=召唤一个在本局对战中死亡的随从。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_05e:Ability{
//NAME=剧毒蛰针
//TEXT=如果本随从受到伤害，则会被消灭。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_05h:HeroBase{
//NAME=巨蝎格拉克
//TEXT=<i>伊莉斯的日记中关于格拉克的记载很简单：“别被蛰。”</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_05p:HeroPowerBase{
//NAME=剧毒蛰针
//TEXT=蛰刺一个随从。当该随从受到伤害时，消灭该随从。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_06h:HeroBase{
//NAME=楚先生
//TEXT=<i>楚先生自告奋勇来“保卫”这座塞满了宝藏的古墓。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_06p:HeroPowerBase{
//NAME=“征用”装备
//TEXT=<b>被动</b> 在你攻击并消灭一个随从后，随机装备一把武器。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_07e:Ability{
//NAME=老鼠精华
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_07h:HeroBase{
//NAME=斯奎丽什
//TEXT=<i>她还有许多可怕的形态，比如松鼠和蘑菇。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_07p:HeroPowerBase{
//NAME=老鼠德鲁伊
//TEXT=使你的所有随从获得+1/+1。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_08h:HeroBase{
//NAME=陷阱
//TEXT=<i>避开陷阱的最佳方法就是早——啊！早干什么去了。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_08p:HeroPowerBase{
//NAME=黄沙涌动
//TEXT=将一张“流沙陷阱”洗入你对手的牌库。“流沙陷阱”在被抽到时会吞没卡牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_08px:HeroPowerBase{
//NAME=黄沙涌动
//TEXT=将一张“流沙陷阱”洗入你对手的牌库。“流沙陷阱”在被抽到时会吞没卡牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_09h:HeroBase{
//NAME=攻城车3V-11
//TEXT=<i>拉法姆在部落清仓拍卖时买了一台这玩意儿。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_09p:HeroPowerBase{
//NAME=护甲修复
//TEXT=获得2点护甲值。如果你的护甲值小于10点，则改为获得4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_10h:HeroBase{
//NAME=特拉维斯
//TEXT=<i>偷偷溜进古墓，就为了偷点法术和 武器。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_10p:HeroPowerBase{
//NAME=装备精良
//TEXT=随机将一张潜行者法术牌或武器牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_11h:HeroBase{
//NAME=狗头金刚
//TEXT=<i>他们再现了狗头人蛮兵。更快，更强，更火。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_11p:HeroPowerBase{
//NAME=不靠谱的武器
//TEXT=<b>被动</b> 在你召唤一个机械后，随机对一个敌人造成2点伤害。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_12e:Ability{
//NAME=举于版筑
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_12h:HeroBase{
//NAME=疯狂金字塔
//TEXT=<i>地，火，水，风……还有金字塔。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_12p:HeroPowerBase{
//NAME=添砖加瓦
//TEXT=<b>发现</b>一张元素牌，其法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_12px:HeroPowerBase{
//NAME=添砖加瓦
//TEXT=<b>发现</b>一张元素牌，其法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_13e:Ability{
//NAME=异常致命
//TEXT=拥有<b>剧毒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_13h:HeroBase{
//NAME=投蛇猎人大鼻子
//TEXT=<i>尖头蛇毒性猛烈，拿来当子弹最好不过了。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_13p:HeroPowerBase{
//NAME=投掷毒蛇
//TEXT=召唤一条1/1的蛇，并使其获得<b>剧毒</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_14e:Ability{
//NAME=Weapon Shuffle Tracker
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_14h:HeroBase{
//NAME=舞剑蛇姬希里尼尔
//TEXT=<i>相传每一位舞剑蛇姬都曾是弑君 狂徒。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_14p:HeroPowerBase{
//NAME=剑舞
//TEXT=<b>被动</b> 在你的武器被摧毁后，将其洗入你的牌库。保留所有附加效果。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_15e:Ability{
//NAME=河豚突袭
//TEXT=河豚突击队使你的鱼人获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_15h:HeroBase{
//NAME=鲱鱼中尉
//TEXT=<i>统率着可怕的怪盗河豚突击队，也就是著名的“飞鱼队”。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_15p:HeroPowerBase{
//NAME=河豚突击队
//TEXT=使你的鱼人获得<b>突袭</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_15px:HeroPowerBase{
//NAME=河豚突击队
//TEXT=使你的鱼人获得<b>突袭</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_16e:Ability{
//NAME=包起来
//TEXT=使一个随从获得<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_16h:HeroBase{
//NAME=巴特鲁德
//TEXT=<i>他的随从不全是木乃伊。也有缠坏了的残次品。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_16p:HeroPowerBase{
//NAME=裹布之下
//TEXT=<b>被动</b> 在你使用一张随从牌后，使其获得<b>复生</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_17e:Ability{
//NAME=受到诅咒
//TEXT=使一个随从获得<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_17h:HeroBase{
//NAME=被诅咒的伊卡博德
//TEXT=<i>这些侏儒被诅咒了！你也一样！不过你也可以反过来诅咒他们！</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_17p:HeroPowerBase{
//NAME=传播诅咒
//TEXT=召唤一个麻风侏儒，并使其获得<b>突袭</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_17px:HeroPowerBase{
//NAME=传播诅咒
//TEXT=召唤一个麻风侏儒，并使其获得<b>突袭</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_18e:Ability{
//NAME=感染灾祸
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_18h:HeroBase{
//NAME=焊钩
//TEXT=<i>焊钩传播的不仅是流感，还有关于他的流言。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_18p:HeroPowerBase{
//NAME=染病团伙
//TEXT=使一个随从获得“<b>亡语：</b>对敌方英雄造成2点伤害”。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_18px:HeroPowerBase{
//NAME=染病团伙
//TEXT=使一个随从获得“<b>亡语：</b>对敌方英雄造成2点伤害”。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_19h:HeroBase{
//NAME=索西斯
//TEXT=<i>这位可怕的泰坦守护者拥有一支私人武装。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_19p:HeroPowerBase{
//NAME=泰坦仪式
//TEXT=召唤两个1/1的魔古信徒。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_19px:HeroPowerBase{
//NAME=泰坦仪式
//TEXT=召唤两个1/1的魔古信徒。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_20h:HeroBase{
//NAME=卡姆
//TEXT=<i>瞻之在前，忽焉在后。现在你已经被刺穿了。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_20p:HeroPowerBase{
//NAME=幽灵剑士
//TEXT=<b>被动</b> 当你装备着武器时，你的英雄拥有 <b>潜行</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_21e:Ability{
//NAME=严正宣称
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_21h:HeroBase{
//NAME=伊利德拉·日晓
//TEXT=<i>神圣遗物学会专程给你发现了一点坏消息。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_21p:HeroPowerBase{
//NAME=宣称占有
//TEXT=<b>被动</b> 每当使用一张<b>发现</b>牌，所有随从获得+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_22h:HeroBase{
//NAME=太阳巨人守护者
//TEXT=<i>这位泰坦守护巨人厌恶所有弱者。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_22p:HeroPowerBase{
//NAME=愤怒之力
//TEXT=对所有受伤的随从造成1点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_22px:HeroPowerBase{
//NAME=愤怒之力
//TEXT=对所有受伤的随从造成2点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_23e:Ability{
//NAME=孵化中
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_23h:HeroBase{
//NAME=塞卡里克
//TEXT=<i>眼镜王蛇，百兽之王。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_23p:HeroPowerBase{
//NAME=正在孵化
//TEXT=你手牌中所有野兽牌的法力值消耗减少（1）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_24h:HeroBase{
//NAME=可疑的棕榈树
//TEXT=<i>这里原本是怡人的绿洲，直到哈加莎抢先发现了这里。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_24p:HeroPowerBase{
//NAME=腐化的绿洲
//TEXT=将两张2/2的树人置入你的手牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_24px:HeroPowerBase{
//NAME=腐化的绿洲
//TEXT=将两张2/2的树人置入你的手牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_25h:HeroBase{
//NAME=甲虫训练师赞妲
//TEXT=<i>甲虫奔踏的场面非常可怕。想想那些密密麻麻的小脚。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_25p:HeroPowerBase{
//NAME=甲虫奔踏
//TEXT=召唤一只硬壳甲虫。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_26h:HeroBase{
//NAME=撒德·锁簧
//TEXT=<i>如果法杖有了扳机和全自动连发，那还是法杖吗？</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_26p:HeroPowerBase{
//NAME=加特林法杖
//TEXT=造成2点伤害，分配到所有敌方随从身上。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_27e:Ability{
//NAME=特价战利品
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_27h:HeroBase{
//NAME=老托巴
//TEXT=<i>宝藏猎人老托巴并不想干这些抄袭的勾当。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_27p:HeroPowerBase{
//NAME=“退役”宝藏猎人
//TEXT=复制你对手的一张手牌，并将其置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_27px:HeroPowerBase{
//NAME=“退役”宝藏猎人
//TEXT=复制你对手的一张手牌，并将其置入你的手牌。其法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_28h:HeroBase{
//NAME=萨金
//TEXT=<i>大风起兮尘飞扬，你的随从兮在 何方？</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_28p:HeroPowerBase{
//NAME=巨力风暴
//TEXT=每个玩家将手牌中的一张随从牌与其场上的一个随从交换。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_29h:HeroBase{
//NAME=欧扎拉
//TEXT=<i>沙石之母欧扎拉坚信：勿以尘魔小而不为。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_29p:HeroPowerBase{
//NAME=沙石之母
//TEXT=<b>被动</b> 在你<b>过载</b>之后，召唤一个尘魔。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_30h:HeroBase{
//NAME=厄迈瓦
//TEXT=<i>厄迈瓦被尊奉为最初的火妖之主。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_30p:HeroPowerBase{
//NAME=塑造火焰
//TEXT=<b>被动</b> 在你施放一个法术后，造成$2点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_31e1:Ability{
//NAME=强能项链
//TEXT=拥有+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_31h:HeroBase{
//NAME=匪贼德莱萨
//TEXT=<i>德莱萨不吝和随从们分享偷来的 宝藏。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_31p:HeroPowerBase{
//NAME=偷来的古董
//TEXT=选择一个随从。随机使其获得+1/+1，<b>圣盾</b>或<b>嘲讽</b>中的一种。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_31px:HeroPowerBase{
//NAME=偷来的古董
//TEXT=选择一个随从。随机使其获得+1/+1，<b>圣盾</b>或<b>嘲讽</b>中的一种。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_32h:HeroBase{
//NAME=艾德拉
//TEXT=<i>这些上古生命守卫者用鲜（吸）血捍卫着这片圣地。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_32p:HeroPowerBase{
//NAME=精灵哨卫
//TEXT=召唤一个1/1的小精灵，并使其获得<b>吸血</b>。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_33h:HeroBase{
//NAME=失控的露比
//TEXT=<i>侏儒在潜艇上装了坦克履带来探险沙漠。呵，侏儒。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_33p:HeroPowerBase{
//NAME=失去控制
//TEXT=对最接近战场中间的随从造成1点 伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_34h:HeroBase{
//NAME=多沃·速熔
//TEXT=<i>多沃的发掘方式：把炸弹塞进古墓。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_34p:HeroPowerBase{
//NAME=坟头爆炸
//TEXT=造成4点伤害，随机分配到所有角色身上。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_35h:HeroBase{
//NAME=地怒者塔赫
//TEXT=<i>不要直迎塔赫的凝视。站在和他对视的人身边也不行。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_35p:HeroPowerBase{
//NAME=复仇构造体
//TEXT=选择一个生命值小于或等于2点的随从。消灭该随从及相邻的随从。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_36e:Ability{
//NAME=疯狂
//TEXT=这把武器本回合获得+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_36ex:Ability{
//NAME=疯狂
//TEXT=在本回合中+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_36h:HeroBase{
//NAME=卡萨·柔声
//TEXT=<i>疯狂之灾祸对待卡萨的方式可一点都不温柔。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_36p:HeroPowerBase{
//NAME=化身疯狂
//TEXT=在本回合中获得+1攻击力，随机攻击3个不同的敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_36px:HeroPowerBase{
//NAME=化身疯狂
//TEXT=在本回合中获得+3攻击力，随机攻击3个不同的敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_37h:HeroBase{
//NAME=扎特玛，死亡灾祸领主
//TEXT=<i>第三灾祸寄身死亡，远古领主阴险难防！</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=300|RACE=NONE
}
public class ULDA_BOSS_37h2:HeroBase{
//NAME=扎特玛，死亡灾祸领主
//TEXT=<i>第三灾祸寄身死亡，远古领主阴险难防！</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=200|RACE=NONE
}
public class ULDA_BOSS_37h3:HeroBase{
//NAME=扎特玛，死亡灾祸领主
//TEXT=<i>第三灾祸寄身死亡，远古领主阴险难防！</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=100|RACE=NONE
}
public class ULDA_BOSS_37p1:HeroPowerBase{
//NAME=凶恶命运
//TEXT=触发一个友方随从的<b>亡语</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_37p2:HeroPowerBase{
//NAME=死亡之拥
//TEXT=<b>被动</b> 每个玩家在每回合中死亡的第一个随从拥有<b>复生</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_37p3:HeroPowerBase{
//NAME=死亡凝视
//TEXT=对所有随从造成1点伤害。如果有随从死亡，则将一张“死于非命”置入你的 手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_37px3:HeroPowerBase{
//NAME=死亡凝视
//TEXT=对所有随从造成1点伤害。如果有随从死亡，则将一张“死于非命”置入你的 手牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_37t:SpellBase{
//NAME=死于非命
//TEXT=对所有敌人造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38h:HeroBase{
//NAME=凯兹莱斯，疯狂灾祸领主
//TEXT=<i>第二灾祸在你脑中，灼热沙丘疯魔逞凶。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=300|RACE=NONE
}
public class ULDA_BOSS_38h2:HeroBase{
//NAME=凯兹莱斯，疯狂灾祸领主
//TEXT=<i>第二灾祸在你脑中，灼热沙丘疯魔逞凶。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=200|RACE=NONE
}
public class ULDA_BOSS_38h3:HeroBase{
//NAME=凯兹莱斯，疯狂灾祸领主
//TEXT=<i>第二灾祸在你脑中，灼热沙丘疯魔逞凶。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=100|RACE=NONE
}
public class ULDA_BOSS_38p1:HeroPowerBase{
//NAME=唤起恐慌
//TEXT=迫使生命值最低的随从攻击其相邻的随从。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38p2:HeroPowerBase{
//NAME=全员叛乱
//TEXT=逆时针转动所有随从。对调换边的随从获得+1/+1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38p2e1:Ability{
//NAME=甄选叛徒
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38p2e2:Ability{
//NAME=前敌方随从标记
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38p2e3:Ability{
//NAME=前友方随从标记
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38p3:HeroPowerBase{
//NAME=致命呢喃
//TEXT=<b>被动</b> 在一个友方随从死亡后，将一个敌方随从的生命值变为1点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38px1:HeroPowerBase{
//NAME=唤起恐慌
//TEXT=迫使生命值最低的敌方随从攻击其相邻的随从。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_38px3:HeroPowerBase{
//NAME=致命呢喃
//TEXT=<b>被动</b> 在一个友方随从死亡后，随机消灭一个敌方随从。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39h:HeroBase{
//NAME=维希，鱼人灾祸领主
//TEXT=<i>第一灾祸源自鱼人，当心这些可怕瘟神。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=300|RACE=NONE
}
public class ULDA_BOSS_39h2:HeroBase{
//NAME=维希，鱼人灾祸领主
//TEXT=<i>第一灾祸源自鱼人，当心这些可怕瘟神。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=200|RACE=NONE
}
public class ULDA_BOSS_39h3:HeroBase{
//NAME=维希，鱼人灾祸领主
//TEXT=<i>第一灾祸源自鱼人，当心这些可怕瘟神。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=100|RACE=NONE
}
public class ULDA_BOSS_39m:MinionBase{
//NAME=石鳞魔像
//TEXT=<b>嘲讽，亡语：</b>使所有鱼人获得+1/+1。
//MAJ=SHAMAN|COST=1|ATK=0|HP=4|RACE=NONE
}
public class ULDA_BOSS_39me:Ability{
//NAME=大地附魔
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39p1:HeroPowerBase{
//NAME=来自鱼人
//TEXT=<b>被动</b> <b>免疫</b>。在一个鱼人死亡后，失去3点生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39p2:HeroPowerBase{
//NAME=死灰复燃
//TEXT=消灭一个友方鱼人，召唤一个石鳞 魔像。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39p3:HeroPowerBase{
//NAME=鱼人旋风
//TEXT=将所有随从洗入你的牌库。在一个鱼人死亡后，该技能的法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=15|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39px2:HeroPowerBase{
//NAME=死灰复燃
//TEXT=消灭一个鱼人，召唤一个石鳞魔像。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_39px3:HeroPowerBase{
//NAME=鱼人旋风
//TEXT=将所有随从洗入你的牌库。在一个鱼人死亡后，该技能的法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=10|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40h:HeroBase{
//NAME=伊卡拉斯，愤怒灾祸领主
//TEXT=<i>第四灾祸根植人心，激怒挚友离间至亲。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=300|RACE=NONE
}
public class ULDA_BOSS_40h2:HeroBase{
//NAME=伊卡拉斯，愤怒灾祸领主
//TEXT=<i>第四灾祸根植人心，激怒挚友离间至亲。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=200|RACE=NONE
}
public class ULDA_BOSS_40h3:HeroBase{
//NAME=伊卡拉斯，愤怒灾祸领主
//TEXT=<i>第四灾祸根植人心，激怒挚友离间至亲。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=100|RACE=NONE
}
public class ULDA_BOSS_40p1:HeroPowerBase{
//NAME=命令咆哮
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40p1e1:Ability{
//NAME=命令咆哮
//TEXT=在本回合中，生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40p2:HeroPowerBase{
//NAME=愤怒碾压
//TEXT=消灭一个受伤的随从。每有一个受伤的随从，法力值消耗增加（1）点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40p3:HeroPowerBase{
//NAME=蔑视之手
//TEXT=交换一个随从的攻击力和生命值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40p3e:Ability{
//NAME=蔑视之手
//TEXT=攻击力和生命值互换。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_40px2:HeroPowerBase{
//NAME=愤怒碾压
//TEXT=消灭一个受伤的随从。每有一个受伤的随从，法力值消耗增加（1）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_41h:HeroBase{
//NAME=艾尔达·派特里克
//TEXT=<i>艾尔达特别聪明，会坐下，会起立。还会打劫和召唤 野兽。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_41p:HeroPowerBase{
//NAME=狂野奔跑
//TEXT=从你的牌库中抽一张随从牌。如果是野兽牌，则将该牌的另一张复制置入你的手牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_41px:HeroPowerBase{
//NAME=狂野奔跑
//TEXT=从你的牌库中抽一张随从牌。如果是野兽牌，则将该牌的另一张复制置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42d:SpellBase{
//NAME=沙雕占位
//TEXT=虚拟关联ULDA035e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42e:Ability{
//NAME=流沙突袭
//TEXT=抽到时召唤
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42e2:Ability{
//NAME=流沙突袭玩家附加效果
//TEXT=抽到时召唤
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42e3:Ability{
//NAME=动如流沙
//TEXT=拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42h:HeroBase{
//NAME=沙雕师罗基
//TEXT=<i>罗基是一位沙雕师，复制沙雕随从，还造了一座沙雕 城堡。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_42p:HeroPowerBase{
//NAME=沙雕
//TEXT=将一个敌方随从的一张复制洗入你的牌库。当抽到复制牌时，自动召唤该 随从。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_42px:HeroPowerBase{
//NAME=沙雕
//TEXT=将一个敌方随从的一张复制洗入你的牌库。当抽到复制牌时，自动召唤该 随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_43e1:Ability{
//NAME=惨遭剧透
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_43h:HeroBase{
//NAME=乔里尼·诺特莉
//TEXT=<i>乔里尼的作品疯话连篇，语法更是糟糕透顶。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_43p:HeroPowerBase{
//NAME=剧透
//TEXT=复制你对手手牌中的一张法术牌，其法力值消耗减少（2）点。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_43px:HeroPowerBase{
//NAME=剧透
//TEXT=复制你对手手牌中的一张法术牌，其法力值消耗减少（2）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_44h:HeroBase{
//NAME=布满陷阱的房间
//TEXT=<i>雷诺非常擅长 探知陷阱。用他那张老脸。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_44p:HeroPowerBase{
//NAME=机关陷阱
//TEXT=随机从你的手牌或牌库中使用一张<b>奥秘</b>牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_44px:HeroPowerBase{
//NAME=机关陷阱
//TEXT=随机从你的手牌或牌库中使用一张<b>奥秘</b>牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_45h:HeroBase{
//NAME=贝洛克·辉刃
//TEXT=<i>神圣遗物学会的领袖，道貌岸然的高级窃贼。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_45p:HeroPowerBase{
//NAME=一学就会
//TEXT=<b>被动</b> 在你的对手施放一个法术后，将该法术牌的一张复制置入你的手牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_46h:HeroBase{
//NAME=狂牙
//TEXT=<i>“根本就没有什么沙海狂鲨……”笔记的下半部分被咬掉了。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_46p:HeroPowerBase{
//NAME=大漠巨口
//TEXT=消灭生命值最低的随从。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_47e:Ability{
//NAME=罐中人
//TEXT=属性值变为1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_47h:HeroBase{
//NAME=完全正常的罐子
//TEXT=<i>宝藏献殷勤，非奸即盗。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_47p:HeroPowerBase{
//NAME=罐子里是什么？
//TEXT=选择一个随从。召唤一个1/1的 复制。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_48h:HeroBase{
//NAME=伊尔扎·暴鼓
//TEXT=<i>伊尔扎是竞技场的王，诨名“残酷的决斗者”。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_48p:HeroPowerBase{
//NAME=竞技场专家
//TEXT=从每个玩家的牌库中各召唤一个随从，并使其互相攻击。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_49h:HeroBase{
//NAME=科雷兹
//TEXT=<i>这是科雷兹的地盘！快滚，不然他要喊朋友过来了！</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_49p:HeroPowerBase{
//NAME=恶魔特使
//TEXT=随机召唤一个法力值消耗小于或等于（3）点的恶魔。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_49px:HeroPowerBase{
//NAME=恶魔特使
//TEXT=随机召唤一个法力值消耗小于或等于（5）点的恶魔。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_50h:HeroBase{
//NAME=老疤眼
//TEXT=<i>老疤眼玩腻了高爆狙击枪，转手拿起了屠刀。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_50p:HeroPowerBase{
//NAME=沙漠作战
//TEXT=<b>被动</b> 在你的英雄攻击后，随机将一张猎人卡牌置入你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_51h:HeroBase{
//NAME=卡兹穆特
//TEXT=<i>这位过于优秀的阿努比萨斯喜欢帮人帮到底。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_51p:HeroPowerBase{
//NAME=托维尔死灵术
//TEXT=<b>被动</b> 在一个随从<b>复生</b>后，为其恢复所有生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_52h:HeroBase{
//NAME=巫妖巴兹亚尔
//TEXT=<i>巴兹亚尔骗过了死神，也要用卡牌骗骗你。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_52p1:HeroPowerBase{
//NAME=巫妖的护命匣
//TEXT=为你的英雄恢复$20点生命值。每有一个友方随从死亡，恢复的生命值减少1点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_52p2:HeroPowerBase{
//NAME=损坏的护命匣
//TEXT=<b>被动</b> 你受到的疲劳伤害翻倍。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_53h:HeroBase{
//NAME=监工玛鲁
//TEXT=<i>跟班们总是 跟不上这位怪盗监工的班。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_53p:HeroPowerBase{
//NAME=怪盗征募
//TEXT=随机将一张<b>跟班</b>牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_53px:HeroPowerBase{
//NAME=怪盗征募
//TEXT=随机将一张<b>跟班</b>牌置入你的手牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_54e:Ability{
//NAME=怪盗冲锋
//TEXT=拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_54h:HeroBase{
//NAME=贾内克
//TEXT=<i>这只满腹阴谋的猢狲是怪盗沙漠骑兵团的一员。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_54p:HeroPowerBase{
//NAME=军团驾到
//TEXT=对一个随从造成1点伤害，并使其获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_55h:HeroBase{
//NAME=送水的鱼人
//TEXT=<i>多年的人生经验告诉你：不能忽视这么可怕的威胁。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_55p:HeroPowerBase{
//NAME=鱼食
//TEXT=为所有鱼人恢复#2点生命值。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_56e:Ability{
//NAME=潜伏沙中
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_56h:HeroBase{
//NAME=沙漠豚蛙
//TEXT=<i>一只豚蛙一张嘴，一个随从见了鬼。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_56p:HeroPowerBase{
//NAME=沙漠伏兵
//TEXT=<b>被动</b> 在你使用一张法力值消耗为（1）的随从牌后，使其获得<b>潜行</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_57e:Ability{
//NAME=泰坦的坚忍
//TEXT=属性值变为3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_57h:HeroBase{
//NAME=飞翼守护者
//TEXT=<i>这头巨兽的咆哮既能鼓舞盟友，也能震慑敌人。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_57p:HeroPowerBase{
//NAME=泰坦守护兽
//TEXT=将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_57px:HeroPowerBase{
//NAME=泰坦守护兽
//TEXT=将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_58e:Ability{
//NAME=法术能量移除者
//TEXT=法术伤害提高。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_58h:HeroBase{
//NAME=提问者杰赛罗斯
//TEXT=<i>兽头人身颇可疑，谜题之中复谜题。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_58p:HeroPowerBase{
//NAME=人面狮之谜
//TEXT=<b>被动</b> 猜测<b>首领</b>会使用哪一张卡牌，猜中可抵消这张卡牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_59h:HeroBase{
//NAME=可怕的蝙蝠
//TEXT=<i>如果你不给它提供食物，那它也不会造成什么威胁。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_59p:HeroPowerBase{
//NAME=食物链
//TEXT=对一个随从造成2点伤害。如果该随从死亡，则为你的英雄恢复5点生命值。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_59px:HeroPowerBase{
//NAME=食物链
//TEXT=对一个随从造成2点伤害。如果该随从死亡，则为你的英雄恢复5点生命值。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_60h:HeroBase{
//NAME=扎拉姆
//TEXT=<i>扎拉姆的随从就是他力量的代价。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_60p:HeroPowerBase{
//NAME=禁忌力量
//TEXT=随机对一个敌人造成$1点伤害<i>（每有一个友方随从死亡都会升级）</i>。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_60px:HeroPowerBase{
//NAME=禁忌力量
//TEXT=随机对一个敌人造成$1点伤害<i>（每有一个友方随从死亡都会升级）</i>。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_61h:HeroBase{
//NAME=凯瑞斯
//TEXT=<i>让你的随从排好队形。接下来会很 刺激。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_61p:HeroPowerBase{
//NAME=闪电链
//TEXT=对一个随从造成$1点伤害。弹跳至相邻的随从，直到某个随从死亡。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_61px:HeroPowerBase{
//NAME=闪电链
//TEXT=对一个随从造成$1点伤害。弹跳至相邻的随从，直到某个随从死亡。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_62h:HeroBase{
//NAME=美丽的绿洲
//TEXT=<i>清泉爽冽，树荫婆娑，游戏环境也很平衡。是幻觉吧？</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class ULDA_BOSS_62p:HeroPowerBase{
//NAME=幻象
//TEXT=使你的对手获得一张幻象牌。使用幻象牌时会随机弃掉一张手牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_63h:HeroBase{
//NAME=维西纳
//TEXT=<i>怪盗焦躁便是德，维西纳堪称德高 望重。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_63p:HeroPowerBase{
//NAME=瘟疫使者
//TEXT=<b>被动</b> 你的法术牌会<b>过载</b>（1）点，但法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_65h:HeroBase{
//NAME=斯拉德
//TEXT=<i>总有人觉得潜行者一定要潜行。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_65p:HeroPowerBase{
//NAME=食人魔式盗窃
//TEXT=从你对手的牌库中偷取一张牌并置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_65px:HeroPowerBase{
//NAME=食人魔式盗窃
//TEXT=从你对手的牌库中偷取一张牌并置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_66h:HeroBase{
//NAME=希亚玛特
//TEXT=<i>南风（一般情况下）可以满足希亚玛特的需求。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_66p:HeroPowerBase{
//NAME=高阶灯神
//TEXT=召唤一个1/4并具有<b>嘲讽，突袭，风怒</b>或<b>圣盾</b>中<i>随机一种</i>的仆从。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_66px:HeroPowerBase{
//NAME=南风之主
//TEXT=召唤一个1/4的仆从，并使其获得<b>嘲讽，突袭，风怒</b>和<b>圣盾</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67d:SpellBase{
//NAME=塔卡恒洗牌占位
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67e2:Ability{
//NAME=塔卡恒交换英雄附加效果
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67e3:Ability{
//NAME=塔卡恒宝藏计时
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67h:HeroBase{
//NAME=塔卡恒，火焰灾祸领主
//TEXT=<i>第五灾祸是塔卡恒，终极领主火焰升腾！</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=300|RACE=NONE
}
public class ULDA_BOSS_67p1:HeroPowerBase{
//NAME=唤醒火焰
//TEXT=向一个圣殿魔像灌注火焰之力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67p2:HeroPowerBase{
//NAME=火焰诅咒
//TEXT=选择一个敌方随从。在你的下个回合开始时，如果该随从依然存活，则对所有角色造成5点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67p2e:Ability{
//NAME=火焰诅咒
//TEXT=在塔卡恒的回合，对所有角色造成5点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67p3:HeroPowerBase{
//NAME=灵魂火堆
//TEXT=<b>被动</b> 在一个玩家使用卡牌后，都会受到等同于法力值消耗的伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_67t:SpellBase{
//NAME=终极灾祸？！
//TEXT=<i>再次唤起沉落已久的灾祸。</i>
//MAJ=WARLOCK|COST=10|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_68h:HeroBase{
//NAME=武装胡蜂
//TEXT=<i>和蜜蜂不同，胡蜂可以反复地蛰你。用的还是激光。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_68p:HeroPowerBase{
//NAME=“高级”物种
//TEXT=对一个敌方随从造成等同于你控制的野兽数量的伤害。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_69h:HeroBase{
//NAME=伊希斯特
//TEXT=<i>魔法尊主偶施妙手，一切法术皆可<b>双生</b>。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_69p:HeroPowerBase{
//NAME=魔法尊主
//TEXT=<b>被动</b> 每当一个玩家施放第一个法术时，将法术牌的一张复制置入其手牌。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_70e:Ability{
//NAME=灿烂阳光
//TEXT=在本回合中，你拥有<b>法术伤害+3</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_70h:HeroBase{
//NAME=拉夏
//TEXT=<i>在施放法术之时，太阳尊主的强光最为炽烈。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_70p:HeroPowerBase{
//NAME=太阳尊主
//TEXT=在本回合中获得<b>法术伤害+3</b>。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_70px:HeroPowerBase{
//NAME=太阳尊主
//TEXT=在本回合中获得<b>法术伤害+3</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_71e:Ability{
//NAME=Cost + 1 This Turn Only
//TEXT=Costs (1) more.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_71h:HeroBase{
//NAME=阿穆纳伊
//TEXT=<i>每个团队都需要治疗。但没人像泰坦这么组队。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_71p:HeroPowerBase{
//NAME=生命尊主
//TEXT=为一个随从恢复所有生命值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_71px:HeroPowerBase{
//NAME=生命尊主
//TEXT=为一个随从恢复所有生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_72e:Ability{
//NAME=诅咒
//TEXT=在你的回合结束时对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_72ex:Ability{
//NAME=诅咒
//TEXT=在你的回合结束时对你的英雄造成4点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_72h:HeroBase{
//NAME=塞特斯
//TEXT=<i>塞特斯诅咒每一个随从……可他根本都不认识这些随从。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_72p:HeroPowerBase{
//NAME=毁灭尊主
//TEXT=随机诅咒一个敌方随从，使其每回合对拥有者造成伤害。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_73e:Ability{
//NAME=音爆
//TEXT=拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_73h:HeroBase{
//NAME=胡辛姆将军
//TEXT=<i>胡辛姆将军手下的兵跑起来快极了。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_73p:HeroPowerBase{
//NAME=震荡波
//TEXT=<b>被动</b> 你的所有随从拥有<b>突袭</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_74h:HeroBase{
//NAME=高阶预言者巴林姆
//TEXT=<i>巴林姆依靠替人算命养家糊口。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_74p:HeroPowerBase{
//NAME=强光迸发
//TEXT=<b>吸血</b>，对所有敌方随从造成$1点 伤害。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_74px:HeroPowerBase{
//NAME=强光迸发
//TEXT=<b>吸血</b>，对所有敌方随从造成$1点 伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_75h:HeroBase{
//NAME=阿沃祖
//TEXT=<i>只有上钩的猎物能暂时停住猎人阿沃祖的脚步。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_75p:HeroPowerBase{
//NAME=捕猎弱者
//TEXT=对一个随从造成$1点伤害并获得1点额外伤害。如果该随从死亡，则失去所有额外伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_75px:HeroPowerBase{
//NAME=捕猎弱者
//TEXT=对一个随从造成$2点伤害并获得2点额外伤害。如果该随从死亡，则失去所有额外伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_76h:HeroBase{
//NAME=塔库斯
//TEXT=<i>暴力会引发暴力，而塔库斯能引发大量暴力。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_76p:HeroPowerBase{
//NAME=高贵的勇士
//TEXT=随机对一个敌方随从造成等同于其攻击力的伤害。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_76px:HeroPowerBase{
//NAME=高贵的勇士
//TEXT=随机对一个敌方随从造成等同于其攻击力的伤害。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_77e:Ability{
//NAME=粗壮下颚
//TEXT=攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_77h:HeroBase{
//NAME=凝血之牙
//TEXT=<i>如果它张开了大嘴，快跑，二倍速跑起来。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_77p:HeroPowerBase{
//NAME=钳嘴巨颚
//TEXT=在本回合中，使你的英雄攻击力翻倍。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_77px:HeroPowerBase{
//NAME=钳嘴巨颚
//TEXT=在本回合中，使你的英雄攻击力翻倍。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_78h:HeroBase{
//NAME=八爪巨怪
//TEXT=<i>他最喜欢的数字是7。破坏完美阵型的人后果自负！</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_78p:HeroPowerBase{
//NAME=巨大触手
//TEXT=如果战场上的随从数大于或等于八个，则消灭所有随从。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_79e:Ability{
//NAME=自动驾驶
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_79h:HeroBase{
//NAME=机械犰狳
//TEXT=<i>让小动物来驾驶机甲，这是疯了吗？“不！没疯！”砰砰博士 喊道。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class ULDA_BOSS_79p:HeroPowerBase{
//NAME=机械“驾驶”
//TEXT=在本回合中，使一个机械获得+2攻击力并迫使其随机攻击一个敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_BOSS_99h:HeroBase{
//NAME=集市里的鲍勃
//TEXT=<i>在灾祸横行的沙漠里，他就是你最亲的人。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class ULDA_Brann:HeroBase{
//NAME=布莱恩·铜须
//TEXT=跨上恐龙，但求一战，布莱恩做好了准备，解决这 一切。
//MAJ=HUNTER|COST=0|ATK=0|HP=15|RACE=NONE
}
public class ULDA_Brann_01:SpellBase{
//NAME=小巧灵活
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_02:SpellBase{
//NAME=野兽成群
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_03:SpellBase{
//NAME=沙漠巨兽
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_04:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_05:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_06:SpellBase{
//NAME=坚实护卫
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_07:SpellBase{
//NAME=锈满套牌
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_08:SpellBase{
//NAME=亡语不断
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_09:SpellBase{
//NAME=备战就绪
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_10:SpellBase{
//NAME=苦尽甘来
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_11:SpellBase{
//NAME=永不停息
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_12:SpellBase{
//NAME=全副武装
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_13:SpellBase{
//NAME=直接命中
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_14:SpellBase{
//NAME=砍翻他们
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_15:SpellBase{
//NAME=呼叫援军
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_16:SpellBase{
//NAME=战意提升
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_17:SpellBase{
//NAME=快速抽牌
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_18:SpellBase{
//NAME=炸弹来了
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_19:SpellBase{
//NAME=机关陷阱
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_20:SpellBase{
//NAME=探险发现
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_21:SpellBase{
//NAME=驯服恐龙
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_22:SpellBase{
//NAME=恐怖突袭
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_HP1:HeroPowerBase{
//NAME=散射
//TEXT=造成$1点伤害，再对敌方英雄造成$1点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_HP2:HeroPowerBase{
//NAME=装备精良
//TEXT=随机装备一把武器，并将其耐久度变为1点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_HP3:HeroPowerBase{
//NAME=恐龙追踪
//TEXT=<b>被动</b> 在你的回合开始时，<b>发现</b>你要抽 的牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_HPe:Ability{
//NAME=布莱恩英雄技能监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Brann_PDWatcher:Ability{
//NAME=布莱恩灾祸伤害监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise:HeroBase{
//NAME=伊莉斯·逐星
//TEXT=一手魔法，一手弯刀，伊莉斯做好了准备，拯救奥 丹姆。
//MAJ=DRUID|COST=0|ATK=0|HP=15|RACE=NONE
}
public class ULDA_Elise_01:SpellBase{
//NAME=上古之神
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_02:SpellBase{
//NAME=巨型随从
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_03:SpellBase{
//NAME=亡者苏生
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_04:SpellBase{
//NAME=自我超越
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_05:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_06:SpellBase{
//NAME=复制随从
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_07:SpellBase{
//NAME=微型大军
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_08:SpellBase{
//NAME=一起嘲讽
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_09:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_10:SpellBase{
//NAME=不如一默
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_11:SpellBase{
//NAME=增益魔法
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_12:SpellBase{
//NAME=激励随从
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_13:SpellBase{
//NAME=法术生成
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_14:SpellBase{
//NAME=卡牌抽取
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_15:SpellBase{
//NAME=法力横流
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_16:SpellBase{
//NAME=探险发现
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_17:SpellBase{
//NAME=抉择之道
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_18:SpellBase{
//NAME=爆裂法术
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_19:SpellBase{
//NAME=杀人名医
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_20:SpellBase{
//NAME=生命快递
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_22:SpellBase{
//NAME=净化战场
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_23:SpellBase{
//NAME=瘟疫使者
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HP1:HeroPowerBase{
//NAME=伊莉斯的力量
//TEXT=<b>抉择：</b>在本回合中获得+$a2攻击力；或者获得+$d2点护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HP1a:SpellBase{
//NAME=防御姿态
//TEXT=+$d2护甲值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HP1b:SpellBase{
//NAME=进攻姿态
//TEXT=+$a2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HP2:HeroPowerBase{
//NAME=德鲁伊教学
//TEXT=为一个角色恢复#2点生命值。此时如果目标拥有所有生命值，抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HP3:HeroPowerBase{
//NAME=逐星
//TEXT=<b>被动</b> 在一回合中你施放两个法术后，将一张“月火术”置入你的手牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_HPe:Ability{
//NAME=伊莉斯英雄技能监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Elise_PDWatcher:Ability{
//NAME=伊莉斯灾祸伤害监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Explorers:HeroBase{
//NAME=奥丹姆奇兵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=200|RACE=NONE
}
public class ULDA_Finley:HeroBase{
//NAME=芬利爵士
//TEXT=战驹疾驰，正义将至，芬利爵士做好了准备，惩戒最终的敌人。
//MAJ=PALADIN|COST=0|ATK=0|HP=15|RACE=NONE
}
public class ULDA_Finley_01:SpellBase{
//NAME=微型军团
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_02:SpellBase{
//NAME=家族渊源
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_03:SpellBase{
//NAME=小小军团
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_04:SpellBase{
//NAME=死或新生
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_05:SpellBase{
//NAME=勇冠三军
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_06:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_07:SpellBase{
//NAME=坚实护卫
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_08:SpellBase{
//NAME=驾驭元素
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_09:SpellBase{
//NAME=开动机械
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_10:SpellBase{
//NAME=神圣之盾
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_11:SpellBase{
//NAME=救赎之光
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_12:SpellBase{
//NAME=力量均沾
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_13:SpellBase{
//NAME=强力压制
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_14:SpellBase{
//NAME=圣光之刃
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_15:SpellBase{
//NAME=直取要害
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_16:SpellBase{
//NAME=强力秘术
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_17:SpellBase{
//NAME=法力过载
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_18:SpellBase{
//NAME=同归于尽
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_19:SpellBase{
//NAME=快速抽牌
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_20:SpellBase{
//NAME=探险发现
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_21:SpellBase{
//NAME=战吼震天
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_22:SpellBase{
//NAME=妖术变形
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_HP1:HeroPowerBase{
//NAME=更新的“新兵”
//TEXT=召唤一个2/2的融合怪探险者。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_HP1t:MinionBase{
//NAME=融合怪探险者
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=ALL
}
public class ULDA_Finley_HP2:HeroPowerBase{
//NAME=气泡升腾
//TEXT=<b>发现</b>一张萨满祭司或圣骑士的<b>战吼</b>随从牌。 <b>过载：</b>（1）。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_HP3:HeroPowerBase{
//NAME=力量强化
//TEXT=使一个随从获得<b>圣盾</b>和<b>风怒</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_HP3e:Ability{
//NAME=实力大增
//TEXT=+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_HPe:Ability{
//NAME=芬利英雄技能监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Finley_PDWatcher:Ability{
//NAME=芬利灾祸伤害监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno:HeroBase{
//NAME=雷诺·杰克逊
//TEXT=带好宝藏，剪好胡须，雷诺做好了准备，干掉塔 卡恒！
//MAJ=MAGE|COST=0|ATK=0|HP=15|RACE=NONE
}
public class ULDA_Reno_01:SpellBase{
//NAME=威武之师
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_02:SpellBase{
//NAME=亡语不断
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_03:SpellBase{
//NAME=战吼震天
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_04:SpellBase{
//NAME=元素亲和
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_05:SpellBase{
//NAME=机械小队
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_06:SpellBase{
//NAME=海上游侠
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_07:SpellBase{
//NAME=英雄强化
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_08:SpellBase{
//NAME=暴走召唤
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_09:SpellBase{
//NAME=上古之神
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_10:SpellBase{
//NAME=强力法术
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_11:SpellBase{
//NAME=弑君狂徒
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_12:SpellBase{
//NAME=敌军千重
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_13:SpellBase{
//NAME=法术伤害
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_14:SpellBase{
//NAME=法力倾泻
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_15:SpellBase{
//NAME=法术票友
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_16:SpellBase{
//NAME=洗牌抽牌
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_17:SpellBase{
//NAME=寻找法术
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_18:SpellBase{
//NAME=探险发现
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_19:SpellBase{
//NAME=盗亦有道
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_20:SpellBase{
//NAME=神奇奥秘
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_21:SpellBase{
//NAME=安全措施
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_22:SpellBase{
//NAME=致命连击
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_HP1:HeroPowerBase{
//NAME=业余法师
//TEXT=造成$1点伤害。<b>连击：</b>改为造成$2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_HP2:HeroPowerBase{
//NAME=“考古专家”
//TEXT=在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_HP2e:Ability{
//NAME=神器之力
//TEXT=在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_HP3:HeroPowerBase{
//NAME=玩弄奥术
//TEXT=发射两枚飞弹，每枚造成$1点伤害。如果任何随从死亡，则重复此效果。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_HPe:Ability{
//NAME=雷诺英雄技能监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULDA_Reno_PDWatcher:Ability{
//NAME=雷诺灾祸伤害监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
