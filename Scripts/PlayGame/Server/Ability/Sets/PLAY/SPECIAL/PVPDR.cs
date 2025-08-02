using System.Collections;
using System.Collections.Generic;

public class PVPDR_022:MinionBase{
//NAME=小鬼援兵
//TEXT=每当你召唤一个恶魔，使其获得+2/+2。
//MAJ=WARLOCK|COST=3|ATK=4|HP=3|RACE=DEMON
}
public class PVPDR_022e:Ability{
//NAME=小鬼援助
//TEXT=+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_035:SpellBase{
//NAME=军团赠礼
//TEXT=在本回合中，每有一个随从死亡，获得+1攻击力。<b>流放：</b>将此法术牌移回你的手牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class PVPDR_035e:Ability{
//NAME=军团之赐
//TEXT=在本回合中，你的英雄拥有+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=DEMON
}
public class PVPDR_036:SpellBase{
//NAME=斯雷特的注射器
//TEXT=从一个敌方随从处偷取最多4点攻击力和生命值，随机使一只友方野兽获得该属性值。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_036e:Ability{
//NAME=抽取
//TEXT=-3/-3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_036e2:Ability{
//NAME=灌注
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_042:SpellBase{
//NAME=元素学习
//TEXT=随机将三张元素牌置入你的手牌。如果你在上个回合使用过元素牌，则使这三张元素牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class PVPDR_042e:Ability{
//NAME=基本元素
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Ashes_BucketList:SpellBase{
//NAME=外域的灰烬
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp1:HeroPowerBase{
//NAME=晋升！
//TEXT=使一个随从获得+1/+1和<b>突袭</b>，<b>剧毒</b>，<b>嘲讽</b>，<b>风怒</b>，<b>圣盾</b>或<b>潜行</b>中的一项。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp1e1:Ability{
//NAME=获得晋升
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp2:HeroPowerBase{
//NAME=派出斥候
//TEXT=召唤一个2/2的军情七处斥候。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp2m1:MinionBase{
//NAME=军情七处斥候
//TEXT=<b>亡语：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class PVPDR_AV_Neutralp3:HeroPowerBase{
//NAME=战斗策略
//TEXT=使你手牌中法力值消耗大于或等于（4）点的两张中立随从牌的法力值消耗减少（2）点
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3e1:Ability{
//NAME=更改战斗策略
//TEXT=每个回合，随机变形成为一个新的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3e2:Ability{
//NAME=战斗策略
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p1:HeroPowerBase{
//NAME=加强防御
//TEXT=<b>被动</b> 在本回合中，你召唤的中立随从获得+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p1e1:Ability{
//NAME=强固防御
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p2:HeroPowerBase{
//NAME=聚集物资
//TEXT=<b>被动</b> 在本回合中，你的中立随从拥有“<b>荣誉消灭：</b>随机将一张任意职业的法术牌置入你的手牌。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p2e1:Ability{
//NAME=聚集物资
//TEXT=<b>荣誉消灭：</b>随机将一张随机职业的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p3:HeroPowerBase{
//NAME=雷霆一击
//TEXT=如果你只有中立随从，则对所有敌方随从造成1点伤害并使其获得-1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3p3e1:Ability{
//NAME=雷霆余震
//TEXT=-1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp3s1:SpellBase{
//NAME=选择一项新战术。
//TEXT=选择一项新战术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp4:HeroPowerBase{
//NAME=大将之怒
//TEXT=对所有随从造成$1点伤害。<b>荣誉消灭：</b>在本回合中获得+$a1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp4e1:Ability{
//NAME=大将之怒
//TEXT=本回合获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp5:HeroPowerBase{
//NAME=驾驭元素
//TEXT=抽一张法术牌，其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp5e1:Ability{
//NAME=驾驭元素
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6:HeroPowerBase{
//NAME=战斗指令
//TEXT=抽一张法力值消耗小于或等于（3）点的中立随从牌。在本回合中，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6e1:Ability{
//NAME=变更战斗指令
//TEXT=每个回合，随机变形成为一个新的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6e2:Ability{
//NAME=战斗指令
//TEXT=在本回合中法力值消耗为（0）。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p1:HeroPowerBase{
//NAME=占领桥梁！
//TEXT=<b>被动</b> 在本回合中，你召唤的中立随从获得+2攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p1e1:Ability{
//NAME=占领桥梁！
//TEXT=+2攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p2:HeroPowerBase{
//NAME=召唤族群
//TEXT=<b>被动</b> 你的中立随从拥有“<b>荣誉消灭：</b>召唤一只2/2并具有<b>潜行</b>的霜狼宝宝。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p2e1:Ability{
//NAME=召唤族群
//TEXT=<b>荣誉消灭：</b>随机将一张随机职业的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p2m1:MinionBase{
//NAME=霜狼宝宝
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class PVPDR_AV_Neutralp6p3:HeroPowerBase{
//NAME=突袭要塞
//TEXT=使你的中立随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6p3e1:Ability{
//NAME=突袭要塞
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralp6s1:SpellBase{
//NAME=选择一项新指令
//TEXT=选择一项新战术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt1:SpellBase{
//NAME=圣光铸造
//TEXT=使你手牌中的所有随从牌获得+3/+3和<b>圣盾</b>。<b>结盟：</b>圣骑士。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt10:SpellBase{
//NAME=魔导师的狂放
//TEXT=直到你的回合结束，在你施放一个法术后，抽一张法术牌。<b>结盟：</b>法师。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt10e1:Ability{
//NAME=魔导师的狂放
//TEXT=直到回合结束，在你使用一张法术牌后，抽一张法术牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt11:SpellBase{
//NAME=心之禀赋
//TEXT=获得3个空的法力水晶。<b>结盟：</b>德鲁伊。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt12:SpellBase{
//NAME=为了部落！
//TEXT=<b>对战开始时：</b>抽到这张牌。将15张可以<b>发现</b>部落法术牌的<b>可交易</b>法术牌洗入你的牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt12t1:SpellBase{
//NAME=部落的力量
//TEXT=<b>可交易</b> <b>发现</b>一张部落法术牌。<i>（德鲁伊，法师，萨满祭司，术士和战士）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt1e1:Ability{
//NAME=圣光铸炼
//TEXT=+3/+3
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt2:SpellBase{
//NAME=间谍大师的计策
//TEXT=召唤你手牌中每个随从的复制并使其获得<b>潜行</b>。<b>结盟：</b>潜行者。
//MAJ=ROGUE|COST=8|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt2e1:Ability{
//NAME=间谍大师的计策
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt3:SpellBase{
//NAME=追猎者的补给
//TEXT=将每种强化后的<b>奥秘</b>牌洗入你的牌库。<b>结盟：</b>猎人。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt4:SpellBase{
//NAME=突破伏击
//TEXT=召唤你手牌中最左边和最右边的随从，并使其随机攻击敌方随从。<b>结盟：</b>恶魔猎手。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt5:SpellBase{
//NAME=虔诚祝福
//TEXT=将每个在你的上回合之后死亡的友方<b>亡语</b>随从的一张复制置入你的手牌。<b>结盟：</b>牧师。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt6:SpellBase{
//NAME=为了联盟！
//TEXT=<b>对战开始时：</b>抽到这张牌。将15张可以<b>发现</b>联盟法术牌的<b>可交易</b>法术牌洗入你的牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt6t1:SpellBase{
//NAME=团结一致
//TEXT=<b>可交易</b> <b>发现</b>一张联盟法术牌。<i>（恶魔猎手，圣骑士，猎人，牧师和潜行者）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt7:SpellBase{
//NAME=展现勇气
//TEXT=<b>发现</b>一把武器并装备，然后消灭所有随从。<b>结盟：</b>战士。
//MAJ=WARRIOR|COST=7|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt8:SpellBase{
//NAME=元素之乱
//TEXT=唤起全部四种元素的力量！<b>结盟：</b>萨满祭司。
//MAJ=SHAMAN|COST=8|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt8t:SpellBase{
//NAME=大地祈咒
//TEXT=召唤两个2/3并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt8t2:SpellBase{
//NAME=流水祈咒
//TEXT=为所有友方角色恢复6点生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt8t3:SpellBase{
//NAME=火焰祈咒
//TEXT=对敌方英雄造成$6点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt8t4:SpellBase{
//NAME=闪电祈咒
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Neutralt9:SpellBase{
//NAME=巫妖的契约
//TEXT=将五张邪能裂隙洗入你的牌库。抽三张牌。<b>结盟：</b>术士。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive03:SpellBase{
//NAME=相位变换之环
//TEXT=<b>被动</b> 在你使用一张<b>传说</b>随从牌后，随机将一张<b>传说</b>随从牌置入你的手牌，其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive03e1:Ability{
//NAME=相位变换之环
//TEXT=在你使用一张<b>传说</b>随从牌后，随机将一张<b>传说</b>随从牌置入你的手牌，其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive03e2:Ability{
//NAME=相位变换
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive04:SpellBase{
//NAME=初阶暗影施放
//TEXT=<b>被动</b> 每回合中，在你使用第一张随从牌后，将它的一张1/1的复制置入你的手牌，其法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive04e1:Ability{
//NAME=初阶暗影施放
//TEXT=每回合中，在你使用第一张随从牌后，将它的一张1/1的复制置入你的手牌，其法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive04e2:Ability{
//NAME=初阶暗影施放
//TEXT=属性值变成1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive06:SpellBase{
//NAME=简便葬礼
//TEXT=<b>被动</b> 对战开始时，将你手牌和牌库中的所有<b>亡语</b>随从变为1/1，且法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive06e1:Ability{
//NAME=简便葬礼附加效果
//TEXT=对战开始时，将你手牌和牌库中的所有<b>亡语</b>随从变为1/1，且法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive06e2:Ability{
//NAME=简便葬礼
//TEXT=属性值变成1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive07:SpellBase{
//NAME=引火护肩
//TEXT=<b>被动</b> 每当你以一个随从为目标施放法术时，对该随从相邻的随从再次施放。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive07e1:Ability{
//NAME=引火护肩附加效果
//TEXT=每当你以一个随从为目标施放法术时，对该随从相邻的随从再次施放。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive08:SpellBase{
//NAME=自然力量
//TEXT=<b>被动</b> <b>自然法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive08e1:Ability{
//NAME=自然力量附加效果
//TEXT=<b>自然法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive09:SpellBase{
//NAME=引火烈焰
//TEXT=<b>被动</b> <b>火焰法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive09e1:Ability{
//NAME=引火烈焰附加效果
//TEXT=<b>火焰法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive10:SpellBase{
//NAME=邪恶赠礼
//TEXT=<b>被动</b> 对战开始时，将8张<b>巫妖王</b>牌洗入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive10e1:Ability{
//NAME=邪恶赠礼附加效果
//TEXT=<b>被动</b> 对战开始时，将8张<b>巫妖王</b>牌洗入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive11:SpellBase{
//NAME=极苦至寒
//TEXT=<b>被动</b> <b>冰霜法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive11e1:Ability{
//NAME=极苦至寒附加效果
//TEXT=<b>冰霜法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive13:SpellBase{
//NAME=不稳定的魔法
//TEXT=<b>被动</b> 在你施放一个奥术法术后，随机将一个敌方随从变形成为1/1的绵羊。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive13e1:Ability{
//NAME=不稳定的魔法附加效果
//TEXT=在你施放一个奥术法术后，随机将一个敌方随从变形成为1/1的绵羊。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive15:SpellBase{
//NAME=守卫之光
//TEXT=<b>被动</b> 在你施放一个神圣法术后，召唤一个属性值等同于其法力值消耗的远古守卫。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive15e1:Ability{
//NAME=守卫之光附加效果
//TEXT=在你施放一个神圣法术后，召唤一个属性值等同于其法力值消耗的远古守卫。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive15m1:MinionBase{
//NAME=远古守卫
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class PVPDR_AV_Passive16:SpellBase{
//NAME=肯瑞托之火
//TEXT=<b>被动</b> 每回合中，在你施放第一个火焰法术后，随机将一张你职业的非<b>传说</b>火焰法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive16e1:Ability{
//NAME=肯瑞托之火
//TEXT=每回合中，在你施放第一个火焰法术后，随机将一张你职业的非<b>传说</b>火焰法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive17:SpellBase{
//NAME=鬼神长裤
//TEXT=<b>被动</b> 每回合中，在你施放第一个邪能法术后，将2张邪能裂隙洗入你的牌库，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive17e1:Ability{
//NAME=鬼神长裤
//TEXT=每回合中，在你施放第一个邪能法术后，将2张邪能裂隙洗入你的牌库，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive19:SpellBase{
//NAME=腐朽癫狂
//TEXT=<b>被动</b> 在你的回合中，每当一个中立随从死亡，便获得一个仅限本回合可用的法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive19e1:Ability{
//NAME=腐朽癫狂附加效果
//TEXT=在你的回合中，每当一个中立随从死亡，便获得一个仅限本回合可用的法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive20:SpellBase{
//NAME=钢铁根须
//TEXT=<b>被动</b> 在你施放一个自然法术后，随机使一个友方随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive20e1:Ability{
//NAME=钢铁根须附加效果
//TEXT=在你施放一个自然法术后，随机使一个友方随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive20e2:Ability{
//NAME=钢铁根须
//TEXT=属性值提高并获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive21:SpellBase{
//NAME=巨龙梦境
//TEXT=<b>被动</b> 在你使用一张龙牌后，将一张梦境之门洗入你的牌库。当抽到梦境之门时，召唤一条龙。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive21e1:Ability{
//NAME=巨龙梦境附加效果
//TEXT=在你使用一张龙牌后，将一张梦境之门洗入你的牌库。当抽到梦境之门时，召唤一条龙。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive23:SpellBase{
//NAME=青铜玺戒
//TEXT=<b>被动</b> 每当你抽到一张随从牌，将一张它的复制置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive23e1:Ability{
//NAME=青铜玺戒
//TEXT=每当你抽到一张随从牌，将一张它的复制置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive24e1:Ability{
//NAME=啸叫呓语附加效果
//TEXT=在你使用一张<b>战吼</b>随从牌后，随机使其获得一个关键字。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive27:SpellBase{
//NAME=战斗姿态
//TEXT=<b>被动</b> 你的英雄在你的回合拥有+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive27e1:Ability{
//NAME=战斗姿态附加效果
//TEXT=你的英雄在你的回合拥有+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive27e2:Ability{
//NAME=战斗姿态
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive28:SpellBase{
//NAME=黑冰之环
//TEXT=<b>被动</b> 每当随从被<b>冻结</b>时，将它的一张复制置入你的手牌。其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive28e1:Ability{
//NAME=黑冰之环附加效果
//TEXT=每当随从被<b>冻结</b>时，将它的一张复制置入你的手牌。其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive28e2:Ability{
//NAME=黑冰之环
//TEXT=在本回合中，法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive30:SpellBase{
//NAME=复原之环
//TEXT=<b>被动</b> 在你施放一个法术后，复原你的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive30e1:Ability{
//NAME=复原之环附加效果
//TEXT=在你施放一个法术后，复原你的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive31:SpellBase{
//NAME=艾露恩神像
//TEXT=<b>被动</b> 在你的回合结束时，施放你在本回合中施放过的一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive31e1:Ability{
//NAME=艾露恩神像附加效果
//TEXT=在你的回合结束时，施放你在本回合中施放过的一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive32:SpellBase{
//NAME=符文头盔
//TEXT=<b>被动</b> 在你的回合结束时，随机将一张<b>巫妖王</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive32e1:Ability{
//NAME=符文头盔
//TEXT=在你的回合结束时，随机将一张<b>巫妖王</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive32e2:Ability{
//NAME=加重装甲
//TEXT=属性值变成10/10。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive33:SpellBase{
//NAME=加重装甲
//TEXT=<b>被动</b> 对战开始时，将你的生命值变为10点。你每次只会受到1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive33e1:Ability{
//NAME=加重装甲附加效果
//TEXT=对战开始时，将你的生命值变为10点。你每次只会受到1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive34:SpellBase{
//NAME=逐日者王冠
//TEXT=<b>被动</b> 在每回合中，你每施放三个法术，第三个法术的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive34e1:Ability{
//NAME=逐日者王冠附加效果
//TEXT=在每回合中，你每施放三个法术，第三个法术的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive34e2:Ability{
//NAME=逐日者王冠
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive35:SpellBase{
//NAME=翡翠梦境斗篷
//TEXT=<b>被动</b> 在你的回合结束时，将一张梦境牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive35e1:Ability{
//NAME=翡翠梦境斗篷
//TEXT=在你的回合结束时，将一张梦境牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive36:SpellBase{
//NAME=冰川骤雨
//TEXT=<b>被动</b> 在你的回合结束时，如果你在本回合中施放了冰霜法术，召唤一个2/3的水元素。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive36e1:Ability{
//NAME=冰川骤雨附加效果
//TEXT=在你的回合结束时，如果你在本回合中施放了冰霜法术，召唤一个2/3的水元素。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_AV_Passive36m1:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=ELEMENTAL
}
public class PVPDR_AV_Passive37:SpellBase{
//NAME=小型背包
//TEXT=<b>被动</b> 对战开始时，抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Badlands_BucketList:SpellBase{
//NAME=荒芜决战
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive01:SpellBase{
//NAME=鼓舞士气
//TEXT=<b>被动</b> 每回合中，在你第一次使用<b>战吼</b>牌后，抽一张牌，其法力值消耗减少（2）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive01e1:Ability{
//NAME=鼓舞士气附加效果
//TEXT=每回合中，在你第一次使用<b>战吼</b>牌后，抽一张牌，其法力值消耗减少（2）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive01e2:Ability{
//NAME=鼓舞士气
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive02:SpellBase{
//NAME=团队集合
//TEXT=<b>被动</b> 你的<b>战吼</b>牌法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive02e1:Ability{
//NAME=团队集合附加效果
//TEXT=你的<b>战吼</b>牌法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive03:SpellBase{
//NAME=正义后备
//TEXT=<b>被动</b> 每回合中，在你使用第一张<b>圣盾</b>随从牌后，随机使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive03e1:Ability{
//NAME=正义后备附加效果
//TEXT=每回合中，在你使用第一张<b>圣盾</b>随从牌后，随机使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive04:SpellBase{
//NAME=复仇武备
//TEXT=<b>被动</b> 在一个友方随从失去<b>圣盾</b>后，使其获得+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive04e1:Ability{
//NAME=复仇武备附加效果
//TEXT=在一个友方随从失去<b>圣盾</b>后，使其获得+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive04e2:Ability{
//NAME=复仇武备
//TEXT=攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive05:SpellBase{
//NAME=耐力训练
//TEXT=<b>被动</b> 你的<b>嘲讽</b>随从牌法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive05e1:Ability{
//NAME=耐力训练附加效果
//TEXT=你的<b>嘲讽</b>随从牌法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive06:SpellBase{
//NAME=坚守阵地
//TEXT=<b>被动</b> 在你对手的回合中，你的<b>嘲讽</b>随从拥有+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive06e1:Ability{
//NAME=坚守阵地附加效果
//TEXT=在你对手的回合中，你的<b>嘲讽</b>随从拥有+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive07:SpellBase{
//NAME=开辟通路
//TEXT=<b>被动</b> 每回合中，在你第一次<b>发现</b>卡牌后，获取发现的牌的另一张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive07e1:Ability{
//NAME=开辟通路附加效果
//TEXT=每回合中，在你第一次<b>发现</b>卡牌后，获取发现的牌的另一张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive08:SpellBase{
//NAME=启示宝珠
//TEXT=<b>被动</b> 每回合中，在你第一次<b>发现</b>卡牌后，使你手牌中法术牌的法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive08e1:Ability{
//NAME=启示宝珠附加效果
//TEXT=每回合中，在你第一次<b>发现</b>卡牌后，使你手牌中法术牌的法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive08e2:Ability{
//NAME=启示宝珠
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive09:SpellBase{
//NAME=风暴导流
//TEXT=<b>被动</b> 在你的回合开始时，如果你有<b>过载</b>的法力水晶，则在本回合中获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive09e1:Ability{
//NAME=风暴导流附加效果
//TEXT=在你的回合开始时，如果你有<b>过载</b>的法力水晶，则在本回合中获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive09e2:Ability{
//NAME=风暴导流
//TEXT=本回合提高攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive10:SpellBase{
//NAME=火花药水
//TEXT=<b>被动</b> 在一个友方<b>突袭</b>随从攻击敌方随从后，随机对一个相邻敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive10e1:Ability{
//NAME=火花药水附加效果
//TEXT=在一个友方<b>突袭</b>随从攻击敌方随从后，随机对一个相邻敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive11:SpellBase{
//NAME=特快专递
//TEXT=<b>被动</b> 每回合中，在你使用第一张<b>突袭</b>随从牌后，召唤一个生命值为1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive11e1:Ability{
//NAME=特快专递附加效果
//TEXT=每回合中，在你使用第一张<b>突袭</b>随从牌后，召唤一个生命值为1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive11e2:Ability{
//NAME=Specially Delivered
//TEXT=Health changed to 1.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive12:SpellBase{
//NAME=[PH] Passive Treasure 12
//TEXT=待定
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive12e1:Ability{
//NAME=[PH] Passive Treasure 12 Enchantment
//TEXT=待定
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive13:SpellBase{
//NAME=[PH] Passive Treasure 13
//TEXT=待定
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive13e1:Ability{
//NAME=[PH] Passive Treasure 13 Enchantment
//TEXT=待定
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive14:SpellBase{
//NAME=疗愈之池
//TEXT=<b>被动</b> 每回合中，在你施放第一个自然法术后，为所有友方角色恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive14e1:Ability{
//NAME=疗愈之池附加效果
//TEXT=每当你使用一张自然法术牌，为所有友方角色恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive15:SpellBase{
//NAME=树苗滋长
//TEXT=<b>被动</b> 在你施放一个自然法术后，召唤一个1/1的树苗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive15e1:Ability{
//NAME=树苗滋长附加效果
//TEXT=在你施放一个自然法术后，召唤一个1/1的树苗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive16:SpellBase{
//NAME=奥金晶体
//TEXT=<b>被动</b> 在你施放一个奥术法术后，使你的一张手牌法力值消耗减少（1）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive16e1:Ability{
//NAME=奥金晶体附加效果
//TEXT=在你施放一个奥术法术后，使你的一张手牌法力值消耗减少（1）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive16e2:Ability{
//NAME=奥金装备
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive17:SpellBase{
//NAME=奥术洪流
//TEXT=<b>被动</b> 每回合中，在你施放第一个奥术法术后，<b>发现</b>一张你职业的牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive17e1:Ability{
//NAME=奥术洪流附加效果
//TEXT=每回合中，在你施放第一个奥术法术后，<b>发现</b>一张你职业的牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive18:SpellBase{
//NAME=已腐蚀的邪能石
//TEXT=<b>被动</b> 在你施放一个邪能法术后，使你手牌中最左边和最右边的随从牌获得+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive18e1:Ability{
//NAME=已腐蚀的邪能石附加效果
//TEXT=在你施放一个邪能法术后，使你手牌中最左边和最右边的随从牌获得+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive18e2:Ability{
//NAME=已腐蚀的邪能
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive19:SpellBase{
//NAME=欺凌弱者
//TEXT=<b>被动</b> 每回合中，在你施放第一个邪能法术后，对生命值最低的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive19e1:Ability{
//NAME=欺凌弱者附加效果
//TEXT=每回合中，在你施放第一个邪能法术后，对生命值最低的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive20:SpellBase{
//NAME=冰霜凝结
//TEXT=<b>被动</b> 每当<b>被冻结</b>的敌人受到伤害时，伤害增加2点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive20e1:Ability{
//NAME=冰霜凝结附加效果
//TEXT=每当<b>被冻结</b>的敌人受到伤害时，伤害增加2点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive21:SpellBase{
//NAME=寒甲术
//TEXT=<b>被动</b> 每回合中，在你第一次<b>冻结</b>敌人后，获得2点护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive21e1:Ability{
//NAME=寒甲术附加效果
//TEXT=每回合中，在你第一次<b>冻结</b>敌人后，获得2点护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive22:SpellBase{
//NAME=护火者的雕像
//TEXT=<b>被动</b> 在你施放一个火焰法术后，召唤一个1/2的烈焰元素，并添加一张置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive22e1:Ability{
//NAME=护火者的雕像附加效果
//TEXT=在你施放一个火焰法术后，召唤一个1/2的烈焰元素，并添加一张置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive23:SpellBase{
//NAME=烈焰波
//TEXT=<b>被动</b> 在你的回合结束时，你在本回合中每施放过一个火焰法术，便对所有敌方随从造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive23e1:Ability{
//NAME=烈焰波附加效果
//TEXT=<b>被动</b> 在你的回合结束时，你在本回合中每施放过一个火焰法术，便对所有敌方随从造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive24:SpellBase{
//NAME=振奋之光
//TEXT=<b>被动</b> 每当你使用一张神圣法术牌，使所有友方角色获得+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive24e1:Ability{
//NAME=振奋之光附加效果
//TEXT=每当你使用一张神圣法术牌，使所有友方角色获得+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive24e2:Ability{
//NAME=振奋之光
//TEXT=生命值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive25:SpellBase{
//NAME=神圣启迪
//TEXT=<b>被动</b> 每回合中，在你施放第一个神圣法术后，<b>发现</b>一张你职业的牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive25e1:Ability{
//NAME=神圣启迪附加效果
//TEXT=每回合中，在你施放第一个神圣法术后，<b>发现</b>一张你职业的牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive26:SpellBase{
//NAME=诡异之石
//TEXT=<b>被动</b> 在你用暗影法术消灭一个敌方随从后，将该随从的一张复制置入你的手牌，其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive26e1:Ability{
//NAME=诡异之石
//TEXT=在你用暗影法术消灭一个敌方随从后，将该随从的一张复制置入你的手牌，其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive26e2:Ability{
//NAME=诡异之石消耗附加效果
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive27:SpellBase{
//NAME=痛苦之杖
//TEXT=<b>被动</b> 在你施放一个暗影法术后，对每个英雄造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive27e1:Ability{
//NAME=痛苦之杖附加效果
//TEXT=在你施放一个暗影法术后，对每个英雄造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive28:SpellBase{
//NAME=蜂舞之戒
//TEXT=<b>被动</b> 每当你使用一张法力值消耗小于或等于（2）点的随从牌，使其获得<b>剧毒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive28e1:Ability{
//NAME=蜂舞之戒玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BAR_Passive28e2:Ability{
//NAME=蜂舞之戒
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Barrens_BucketList:SpellBase{
//NAME=贫瘠之地的锤炼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Blackrock_BucketList:SpellBase{
//NAME=黑石山的火焰
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Boom_BucketList:SpellBase{
//NAME=砰砰计划
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_HP1:HeroPowerBase{
//NAME=散射
//TEXT=造成$1点伤害，再对敌方英雄造成$1点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_HP2:HeroPowerBase{
//NAME=装备精良
//TEXT=随机装备一把你的职业的武器，并将其耐久度变为1点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_HP3:HeroPowerBase{
//NAME=恐龙追踪
//TEXT=<b>发现</b>一张你职业的野兽牌。使其获得+1/+1。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_HP3e1:Ability{
//NAME=恐龙追踪
//TEXT=属性值提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_T1:WeaponBase{
//NAME=靠谱的老猎枪
//TEXT=在你的英雄攻击后，对所有敌人造成1点伤害。
//MAJ=WARRIOR|COST=4|ATK=4|HP=2|RACE=NONE
}
public class PVPDR_Brann_T2:SpellBase{
//NAME=布莱恩的鞍座
//TEXT=使一个友方野兽获得+3/+3，以及“<b>亡语：</b>随机将布莱恩的鞍座甩给另一个友方野兽。”
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_T3:SpellBase{
//NAME=泰坦钩爪
//TEXT=随机消灭两个敌方随从。获得等同于两个随从攻击力之和的护甲值。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_T4:MinionBase{
//NAME=初级挖掘师
//TEXT=<b>战吼：</b>抽三张牌。抽到的随从牌法力值消耗减少（2）点。
//MAJ=HUNTER|COST=5|ATK=2|HP=5|RACE=NONE
}
public class PVPDR_Brann_T4_2:MinionBase{
//NAME=高级挖掘师
//TEXT=<b>战吼：</b>抽三张牌。抽到的随从牌法力值消耗减少（2）点。
//MAJ=HUNTER|COST=5|ATK=3|HP=6|RACE=NONE
}
public class PVPDR_Brann_T4_2e:Ability{
//NAME=深度挖掘
//TEXT=法力值消耗减少（2）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Brann_T5:MinionBase{
//NAME=弗洛·岩印
//TEXT=<b>战吼，亡语：</b>随机将一张宝藏牌置入你的手牌。
//MAJ=WARRIOR|COST=5|ATK=4|HP=4|RACE=NONE
}
public class PVPDR_Brann_T6:MinionBase{
//NAME=布莱恩的宝贝蛋
//TEXT=在本随从受到伤害后，召唤暴龙王 克鲁什。
//MAJ=HUNTER|COST=7|ATK=0|HP=3|RACE=NONE
}
public class PVPDR_Bucket_BigSpells:Ability{
//NAME=强力法术
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_1Cost:SpellBase{
//NAME=一费勇士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_1Health:SpellBase{
//NAME=一血雄师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Agonies:SpellBase{
//NAME=甜美痛苦
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_AllSchools:SpellBase{
//NAME=重返校园
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Arcane:SpellBase{
//NAME=奥术畸变
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Armor:SpellBase{
//NAME=坚如铁石
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Attack:SpellBase{
//NAME=掌控愤怒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_AttackReduct:SpellBase{
//NAME=缩小战术
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_BarrensChat:SpellBase{
//NAME=贫瘠之地
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Battlecry:SpellBase{
//NAME=战吼伙伴
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Beasts:SpellBase{
//NAME=野兽之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_BigMin:SpellBase{
//NAME=威猛斗士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_BigSpells:SpellBase{
//NAME=强力法术
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_BloodRunes:SpellBase{
//NAME=鲜血效能
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Bombs:SpellBase{
//NAME=爆破小队
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_ChooseOne:SpellBase{
//NAME=艰难决定
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Combo:SpellBase{
//NAME=三段连击
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Copy:SpellBase{
//NAME=仿冒复制
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_CorpseGain:SpellBase{
//NAME=藏品丰富
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_CorpseSpend:SpellBase{
//NAME=消耗战略
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Cthun:SpellBase{
//NAME=古神信仰
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_DamageSpells:SpellBase{
//NAME=伤害输出
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Deathrattle:SpellBase{
//NAME=致命死亡
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_DeckShuffle:SpellBase{
//NAME=大洗特洗
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_DeckTarget:SpellBase{
//NAME=牌库危机
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Demons:SpellBase{
//NAME=恶魔之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Destroy:SpellBase{
//NAME=彻底毁灭
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Discover:SpellBase{
//NAME=崭新发现
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_DivineShield:SpellBase{
//NAME=神圣使命
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Dormant:SpellBase{
//NAME=休眠时间
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Dragons:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Draw:SpellBase{
//NAME=快抽快打
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Elementals:SpellBase{
//NAME=元素之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Enrage:SpellBase{
//NAME=激发怒火
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Fatigue:SpellBase{
//NAME=致命疲劳
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Fel:SpellBase{
//NAME=狂怒邪能
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Fire:SpellBase{
//NAME=耀眼火焰
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Frost:SpellBase{
//NAME=碎裂寒冰
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_FrostRunes:SpellBase{
//NAME=冻结威力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_HandBuff:SpellBase{
//NAME=后备建设
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Healing:SpellBase{
//NAME=恢复之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_HeroPower:SpellBase{
//NAME=技能英雄
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Holy:SpellBase{
//NAME=神圣荣耀
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Imps:SpellBase{
//NAME=都是小鬼！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_LeftRight:SpellBase{
//NAME=左右为难
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Librams:SpellBase{
//NAME=馆藏圣契
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Lifesteal:SpellBase{
//NAME=吸血问题
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_LowestX:SpellBase{
//NAME=低级新手
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Mana:SpellBase{
//NAME=法力成长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Mechs:SpellBase{
//NAME=机械小队
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Menagerie:SpellBase{
//NAME=各显神通
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_MinionBuff:SpellBase{
//NAME=内心潜能
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_MinionTarget:SpellBase{
//NAME=选我！选我！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Murlocs:SpellBase{
//NAME=鱼人之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Naga:SpellBase{
//NAME=纳迦之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Nature:SpellBase{
//NAME=自然新生
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Outcast:SpellBase{
//NAME=流放之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Overload:SpellBase{
//NAME=过载之选
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Pain:SpellBase{
//NAME=苦尽甘来
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Pirates:SpellBase{
//NAME=海盗之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Plagues:SpellBase{
//NAME=疫病患者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Poison:SpellBase{
//NAME=绝命剧毒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_RandomGen:SpellBase{
//NAME=随机搭配
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Relic:SpellBase{
//NAME=遗物藏家
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Resurrect:SpellBase{
//NAME=亡者苏生
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Return:SpellBase{
//NAME=回到起点
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Rush:SpellBase{
//NAME=突袭快感
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Secrets:SpellBase{
//NAME=神秘私语
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Shadow:SpellBase{
//NAME=变幻暗影
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Silence:SpellBase{
//NAME=嘘！安静！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_SilverHand:SpellBase{
//NAME=超级银手
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_SmallMin:SpellBase{
//NAME=小小伙伴
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_SmallSpells:SpellBase{
//NAME=小型法术
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_SoulFrag:SpellBase{
//NAME=灵魂之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_SpellDamage:SpellBase{
//NAME=法术伤害
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_StatSetting:SpellBase{
//NAME=规则大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Steal:SpellBase{
//NAME=那是我的！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Stealth:SpellBase{
//NAME=潜行首领
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Swap:SpellBase{
//NAME=你想换吗？
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Taunt:SpellBase{
//NAME=神盾守卫
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Totems:SpellBase{
//NAME=图腾之道
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Transform:SpellBase{
//NAME=变形威能
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Treants:SpellBase{
//NAME=树人之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_UndamageMin:SpellBase{
//NAME=崭新目标
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Undead:SpellBase{
//NAME=亡灵之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_UnholyRunes:SpellBase{
//NAME=邪恶盟军
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Weapon:SpellBase{
//NAME=武器宝匣
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Wildseed:SpellBase{
//NAME=园艺妙手
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_BucketList_Windfury:SpellBase{
//NAME=呼啸狂风
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Buckets_AddDesigner:SpellBase{
//NAME=使用设计师牌筐填充游戏存档数据
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Buckets_AddSmart:SpellBase{
//NAME=使用智能牌筐填充游戏存档数据
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Buckets_AddSpecial:SpellBase{
//NAME=使用特殊牌筐填充游戏存档数据
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_CavernsOfTime_BucketList:SpellBase{
//NAME=时光之穴
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_P1:HeroPowerBase{
//NAME=开炮！
//TEXT=开炮！如果消灭任意随从，复原此技能。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_P2:HeroPowerBase{
//NAME=开炮攻击！
//TEXT=开炮！使你的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_P2e:Ability{
//NAME=爆破之力
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_P3:HeroPowerBase{
//NAME=连续开炮！
//TEXT=开炮两次！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_P3e:Ability{
//NAME=点火
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_PCannon:MinionBase{
//NAME=火炮
//TEXT=开炮时，对本随从对面的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=3|RACE=NONE
}
public class PVPDR_Darius_T1:SpellBase{
//NAME=避风港湾
//TEXT=选择一个随从并将其置入你的手牌。该牌的法力值消耗变为（0）点。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darius_T2:MinionBase{
//NAME=灰鬃后援
//TEXT=<b>战吼：</b>额外召唤一门火炮。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class PVPDR_Darius_T3:MinionBase{
//NAME=海象人海盗
//TEXT=<b>突袭</b> 在本随从攻击后， 开炮！
//MAJ=NEUTRAL|COST=4|ATK=3|HP=9|RACE=PIRATE
}
public class PVPDR_Darius_T4:MinionBase{
//NAME=破浪巨人
//TEXT=你的火炮每次开火，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=15|HP=15|RACE=PIRATE
}
public class PVPDR_Darius_T5:MinionBase{
//NAME=甲板杂兵
//TEXT=在你的回合结束时，开炮！
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=PIRATE
}
public class PVPDR_Darius_T6:SpellBase{
//NAME=龙族弹药
//TEXT=在本局对战的剩余时间内，你的火炮额外造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Darkmoon_BucketList:SpellBase{
//NAME=疯狂的暗月马戏团
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_DemonHunterp1:HeroPowerBase{
//NAME=外域住民
//TEXT=在本回合中，如果你使用过<b>流放</b>牌，<b>发现</b>一张邪能法术牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_DemonHunterp1e:Ability{
//NAME=外域之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_DemonHuntert1:MinionBase{
//NAME=莫尔葛流放者
//TEXT=在你使用最左边或最右边的手牌后，再次使用该卡牌<i>（目标随机而定）</i>。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class PVPDR_DMF_Druidp1:HeroPowerBase{
//NAME=振奋之花
//TEXT=使你手牌中法力值消耗大于或等于（5）点的牌的法力值消耗减少（1）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Druidp1e1:Ability{
//NAME=精力充沛
//TEXT=法力值消耗减少（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Druidt1:MinionBase{
//NAME=月夜枭兽
//TEXT=在你的回合结束时，将日月蚀各一张置入你的手牌。你的日月蚀法力值消耗为（0）点。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class PVPDR_DMF_Hunterp1:HeroPowerBase{
//NAME=死亡游戏
//TEXT=随机触发一个友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Huntert2:SpellBase{
//NAME=兽群追猎
//TEXT=随机召唤一只野兽。在本局对战中，你每使用过一张<b>奥秘</b>牌，重复一次。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Magep1:HeroPowerBase{
//NAME=秘密研究
//TEXT=抽一张<b>奥秘</b>牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Paladinp1:HeroPowerBase{
//NAME=招揽新兵
//TEXT=召唤一个1/1的白银之手新兵，并将一张白银之手新兵置入你的手牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Paladint1:SpellBase{
//NAME=拿起武器
//TEXT=在本局对战的剩余时间内，你的白银之手新兵拥有+2/+2。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class PVPDR_DMF_Paladint1e:Ability{
//NAME=备战！
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Paladint1e2:Ability{
//NAME=备战！
//TEXT=+2/+2
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Paladint2:MinionBase{
//NAME=机鱼之龙
//TEXT=<b>亡语：</b>抽一张龙牌，鱼人牌和机械牌，并使其法力值消耗减少（3）点。
//MAJ=PALADIN|COST=4|ATK=4|HP=6|RACE=DRAGON
}
public class PVPDR_DMF_Paladint2e:Ability{
//NAME=鱼人咆哮
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Passive01:SpellBase{
//NAME=格罗玛什的臂甲
//TEXT=<b>被动</b> 对战开始时，抽一张武器牌。你的武器牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Passive01e1:Ability{
//NAME=格罗玛什的臂甲附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Passive02:SpellBase{
//NAME=顺手牵羊
//TEXT=<b>被动</b> 你的套牌之外的牌法力值消耗减少（1）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Passive02e1:Ability{
//NAME=顺手牵羊玩家强化
//TEXT=<b>被动</b> 你的套牌之外的牌法力值消耗减少（1）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Priestp1:HeroPowerBase{
//NAME=心智锁链
//TEXT=<b>被动</b> 在你施放一个法术后，对敌方英雄造成1点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Priestt1:MinionBase{
//NAME=深渊之子
//TEXT=在每回合中，你施放的第三个法术不再消耗法力值，转而消耗生命值。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class PVPDR_DMF_Priestt2:MinionBase{
//NAME=狂乱液滴
//TEXT=<b>法术迸发：</b>将两张<b>腐蚀</b>牌置入你的手牌，并将其<b>腐蚀</b>。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NONE
}
public class PVPDR_DMF_Roguep1:HeroPowerBase{
//NAME=联络
//TEXT=<b>被动</b> 在你的回合开始时，随机将一张法力值消耗为（1）的随从牌置入你的手牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Roguep1m1:MinionBase{
//NAME=影蔽告密者
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class PVPDR_DMF_Roguet1:MinionBase{
//NAME=蛛魔商贩
//TEXT=在一张卡牌被置入你的手牌后，使其法力值消耗减少（2）点。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=UNDEAD
}
public class PVPDR_DMF_Roguet1e1:Ability{
//NAME=兜售叫卖
//TEXT=法力值消耗减少。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Roguet2:SpellBase{
//NAME=争取盟友
//TEXT=将一个随从移回其拥有者的手牌，并将两张它的复制洗入你的牌库。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_DMF_Shamanp1:HeroPowerBase{
//NAME=猛烈风暴
//TEXT=在本回合中获得+$a1攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Shamanp1e:Ability{
//NAME=猛烈风暴
//TEXT=在本回合中，+1攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Shamant1:WeaponBase{
//NAME=雷暴之怒
//TEXT=在你的英雄攻击后，随机对一个敌方角色施放闪电箭。
//MAJ=SHAMAN|COST=5|ATK=2|HP=3|RACE=NONE
}
public class PVPDR_DMF_Shamant2:SpellBase{
//NAME=祈求虚空
//TEXT=召唤两个7/7的投火无面者。<b>过载：（4）。</b>
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warlockp1:HeroPowerBase{
//NAME=恶魔之血
//TEXT=随机使你手牌中的一张恶魔牌获得+3/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warlockp1e:Ability{
//NAME=恶魔之血
//TEXT=攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warlockt3:SpellBase{
//NAME=古神垂赐
//TEXT=<b>发现</b>两张<b>腐蚀</b>牌，并将其<b>腐蚀</b>。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warriorp1:HeroPowerBase{
//NAME=激斗
//TEXT=使一个友方随从随机攻击一个敌方随从。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warriort1:SpellBase{
//NAME=收藏家之怒
//TEXT=从你的牌库中召唤一个机械，一个海盗和一条龙。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_DMF_Warriort2:MinionBase{
//NAME=残暴战鸡布鲁斯特
//TEXT=<b>突袭</b> 在本随从攻击后，从你的牌库中召唤一个<b>突袭</b>随从。
//MAJ=WARRIOR|COST=6|ATK=7|HP=5|RACE=BEAST
}
public class PVPDR_Dragons_BucketList:SpellBase{
//NAME=巨龙降临
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Aggro:SpellBase{
//NAME=永不退缩
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Armor:SpellBase{
//NAME=钢铁
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Balance:SpellBase{
//NAME=平衡之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Beast:SpellBase{
//NAME=野兽之心
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Beasts:SpellBase{
//NAME=野兽之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Big:SpellBase{
//NAME=威猛
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Blacklist:SpellBase{
//NAME=黑名单
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DBeasts:SpellBase{
//NAME=亡语野兽
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Deathrattl:SpellBase{
//NAME=亡语随从
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DH_DR:SpellBase{
//NAME=刀锋铮鸣
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHBig:SpellBase{
//NAME=气势压制
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHControl:SpellBase{
//NAME=前赴后继
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHFurusFel:SpellBase{
//NAME=狂怒邪能
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHNaga:SpellBase{
//NAME=污秽纳迦
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHRelic:SpellBase{
//NAME=圣物猎人
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHSoulFrag:SpellBase{
//NAME=灵魂控制
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHToken:SpellBase{
//NAME=无所畏惧
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DHWeapon:SpellBase{
//NAME=疾风骤雨
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_DMana:SpellBase{
//NAME=法力成长
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Enrage:SpellBase{
//NAME=激怒
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Face:SpellBase{
//NAME=最佳防御
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Feral:SpellBase{
//NAME=野性之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_H_GT:SpellBase{
//NAME=园艺妙手
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_HAHHHHRATS:SpellBase{
//NAME=啊啊啊啊老鼠！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_HNaga:SpellBase{
//NAME=深渊怪兽
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_HonorableR:Ability{
//NAME=荣誉招募
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_IceCold:Ability{
//NAME=极冰之寒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_LittleBite:SpellBase{
//NAME=啮嚼蚕食
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MFire:SpellBase{
//NAME=开火射击
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MFrost:SpellBase{
//NAME=冰冷寒霜
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MHP:SpellBase{
//NAME=英雄之力
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MMechs:SpellBase{
//NAME=机械魔法
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MNaga:SpellBase{
//NAME=纳迦之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MSecret:SpellBase{
//NAME=玄奥之秘
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MSpellPowe:SpellBase{
//NAME=能量之道
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_MSpells:SpellBase{
//NAME=更多法术
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Naga:SpellBase{
//NAME=流深水急
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NAuctionHs:SpellBase{
//NAME=拍卖行
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NBarensCht:SpellBase{
//NAME=贫瘠之地
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NBattlecry:SpellBase{
//NAME=战吼连击
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NCute:SpellBase{
//NAME=有何不可
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NDeathratt:SpellBase{
//NAME=死亡回声
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NDefense:SpellBase{
//NAME=自然守护
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NDisruptor:SpellBase{
//NAME=制造麻烦
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NDragons:SpellBase{
//NAME=巨龙
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NDraw:SpellBase{
//NAME=抽牌不停
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NFace:SpellBase{
//NAME=奇袭部队
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NHeroPower:SpellBase{
//NAME=英雄之力
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NHighCost:SpellBase{
//NAME=野蛮斗士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NLiveToWin:SpellBase{
//NAME=生存求胜
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NLowCost:SpellBase{
//NAME=地底走卒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NMedCost:SpellBase{
//NAME=追随者众
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NMenagerie:SpellBase{
//NAME=各显神通
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_NTaunt:SpellBase{
//NAME=嘲讽御敌
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaBuffs:SpellBase{
//NAME=圣光祝福
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaControl:SpellBase{
//NAME=和平使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaDivine:SpellBase{
//NAME=圣光战士
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaDragon:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaHealing:SpellBase{
//NAME=看护治愈
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaMid:SpellBase{
//NAME=沙场老兵
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaSecrets:SpellBase{
//NAME=神秘私语
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PaSlver:SpellBase{
//NAME=白银之手
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PBuffs:SpellBase{
//NAME=内心潜能
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PControl:SpellBase{
//NAME=尽在掌握
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PDivineDty:SpellBase{
//NAME=神圣使命
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PDragon:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PHealing:SpellBase{
//NAME=神奇药剂
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PMech:SpellBase{
//NAME=神圣引擎
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PMind:SpellBase{
//NAME=侵占思维
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Pnaga:MinionBase{
//NAME=鲭鱼圣者
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PShadow:SpellBase{
//NAME=暗影重重
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PShenaniga:SpellBase{
//NAME=灵视幻象
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PSilence:SpellBase{
//NAME=沉默寡言
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_PSummon:SpellBase{
//NAME=召唤之力
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RAggro:SpellBase{
//NAME=迅捷打击
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RCombo:SpellBase{
//NAME=连环出击
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RDeathratl:SpellBase{
//NAME=死亡回声
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Removal:SpellBase{
//NAME=扫荡
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RNaga:SpellBase{
//NAME=海中恶霸
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RRemoval:SpellBase{
//NAME=卑劣手段
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Rshenan:SpellBase{
//NAME=有借无还
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RSI7:SpellBase{
//NAME=军情七处
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RStealth:SpellBase{
//NAME=暗影密探
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RWeapon:SpellBase{
//NAME=武装佣兵
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_RWeaponBuf:SpellBase{
//NAME=惯用工具
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Secret:SpellBase{
//NAME=设置陷阱
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_SElement:Ability{
//NAME=祈求元素
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShAggro:SpellBase{
//NAME=元素突击
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShControl:SpellBase{
//NAME=妖术毒咒
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShDraw:SpellBase{
//NAME=智慧崇拜
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShMurlocs:SpellBase{
//NAME=来自深渊
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShOverload:SpellBase{
//NAME=战术过载
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShSpellDmg:SpellBase{
//NAME=法力超群
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShTotems:SpellBase{
//NAME=图腾之道
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_ShWeapon:SpellBase{
//NAME=神圣武器
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Sswarm:Ability{
//NAME=富有嚼劲
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Taunt:SpellBase{
//NAME=嘲讽
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Tokens:SpellBase{
//NAME=自然大军
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WControl:SpellBase{
//NAME=控场即一切
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WDeathratt:SpellBase{
//NAME=牺牲即胜利
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WDemons:SpellBase{
//NAME=恶魔即羁绊
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WDiscard:SpellBase{
//NAME=放弃即索取
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_Weapon:SpellBase{
//NAME=武器
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WMenagerie:SpellBase{
//NAME=各显神通
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WMurloc:SpellBase{
//NAME=鱼饵即食桶
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WPainZoo:SpellBase{
//NAME=痛苦即信仰
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WrARRRRRRG:SpellBase{
//NAME=啊呀儿！
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WRush:SpellBase{
//NAME=突袭冲刺
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WSoulF:SpellBase{
//NAME=灵魂即价值
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Duels_Buckets_WZoo:SpellBase{
//NAME=数量即优势
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_HP1:HeroPowerBase{
//NAME=伊莉斯的力量
//TEXT=<b>抉择：</b>在本回合中获得+$a2攻击力；或者获得+$d2点护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_HP2:HeroPowerBase{
//NAME=德鲁伊教学
//TEXT=为一个角色恢复#2点生命值。此时如果目标拥有所有生命值，抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_HP3:HeroPowerBase{
//NAME=逐星
//TEXT=<b>被动</b> 在一回合中你施放4个法术后，将一张“月火术”置入你的手牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_T1:SpellBase{
//NAME=逐星套装
//TEXT=<b>发现</b>一张随从牌和一张法术牌，其法力值消耗减少 （2）点。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_T2:WeaponBase{
//NAME=伊莉斯的弯刀
//TEXT=在你的英雄攻击后，召唤两个2/2的树人，并使其获得<b>突袭</b>。
//MAJ=DRUID|COST=5|ATK=3|HP=3|RACE=NONE
}
public class PVPDR_Elise_T3:MinionBase{
//NAME=埃达尔拉
//TEXT=<b>战吼：</b>将所有敌方随从洗入你的牌库。
//MAJ=PRIEST|COST=8|ATK=3|HP=6|RACE=NONE
}
public class PVPDR_Elise_T4:MinionBase{
//NAME=初级导航员
//TEXT=每当你以本随从为目标施放一个法力值消耗（2）点或以上的法术，将法术牌的一张复制置入你的手牌。
//MAJ=PRIEST|COST=5|ATK=1|HP=5|RACE=NONE
}
public class PVPDR_Elise_T4_2:MinionBase{
//NAME=高级导航员
//TEXT=在你以本随从为目标施放一个法力值消耗（2）点或以上的法术后，随机为另一个友方随从恢复3点生命值。
//MAJ=PRIEST|COST=3|ATK=2|HP=4|RACE=NONE
}
public class PVPDR_Elise_T5:SpellBase{
//NAME=学术研究
//TEXT=获得1个空的法力水晶<i>（每当一个友方随从死亡时都会升级）</i>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Elise_T6:SpellBase{
//NAME=重生法杖
//TEXT=复活5个法力值消耗最高的友方随从，并使其获得 <b>嘲讽</b>。
//MAJ=PRIEST|COST=8|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_EmptyBucketS1:SpellBase{
//NAME=别再来了
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_EmptyBucketS2:SpellBase{
//NAME=别再来了
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_EmptyBucketS3:SpellBase{
//NAME=别再来了
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_EmptyLootBucket_Name_1:SpellBase{
//NAME=别再来了
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_EmptyLootBucket_Name_2:SpellBase{
//NAME=别再来了
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Festival_BucketList:SpellBase{
//NAME=传奇音乐节
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_HP1:HeroPowerBase{
//NAME=更新的“新兵”
//TEXT=召唤一个2/2的融合怪探险者。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_HP2:HeroPowerBase{
//NAME=气泡升腾
//TEXT=<b>发现</b>一张萨满祭司或圣骑士的<b>战吼</b>随从牌。<b>过载：</b>（1）。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_HP3:HeroPowerBase{
//NAME=力量强化
//TEXT=使一个随从获得<b>圣盾</b>和<b>风怒</b>。<b>过载：</b>（2）。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_T1:SpellBase{
//NAME=芬利的冒险头盔
//TEXT=使你的所有随从获得+2生命值。将这张牌洗入你的牌库。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_T2:MinionBase{
//NAME=“威武战驹”麦克斯韦
//TEXT=<b>突袭，复生</b> 战场上每有一个其他随从，便拥有+2攻击力。
//MAJ=PALADIN|COST=5|ATK=3|HP=5|RACE=BEAST
}
public class PVPDR_Finley_T3:WeaponBase{
//NAME=真银长枪
//TEXT=<b>吸血</b> 在你<b>过载</b>后，获得+1耐久度。
//MAJ=SHAMAN|COST=5|ATK=3|HP=1|RACE=NONE
}
public class PVPDR_Finley_T3e:Ability{
//NAME=真厉害
//TEXT=耐久度提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Finley_T4:MinionBase{
//NAME=初级侦查员
//TEXT=<b>突袭</b>，<b>风怒</b>。在你的回合结束时，随机对一个敌方随从造成4点伤害。
//MAJ=SHAMAN|COST=5|ATK=4|HP=4|RACE=NONE
}
public class PVPDR_Finley_T4_2:MinionBase{
//NAME=高级侦查员
//TEXT=<b>突袭</b>，<b>风怒</b>。在你的回合结束时，随机对一个敌方随从造成6点伤害。
//MAJ=SHAMAN|COST=5|ATK=6|HP=6|RACE=NONE
}
public class PVPDR_Finley_T5:MinionBase{
//NAME=走失的卡尔
//TEXT=<b>战吼：</b>召唤六个1/1的白银之手新兵，并使所有友方随从获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=10|ATK=6|HP=6|RACE=NONE
}
public class PVPDR_Finley_T6:SpellBase{
//NAME=正义之剑
//TEXT=将所有随从变形成为1/1的鱼人。用随机鱼人牌填满你的手牌，其法力值消耗为（1）点。
//MAJ=SHAMAN|COST=8|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Fractyred_BucketList:SpellBase{
//NAME=奥特兰克的决裂
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_FrozenThrone_BucketList:SpellBase{
//NAME=冰封王座的骑士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Gadgetzan_BucketList:SpellBase{
//NAME=龙争虎斗加基森
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Galakrond_BucketList:SpellBase{
//NAME=迦拉克隆的觉醒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GALDRGBRK_BucketList:SpellBase{
//NAME=迦拉克隆的龙
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GrandT_BucketList:SpellBase{
//NAME=冠军的试炼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GTKAR_BucketList:SpellBase{
//NAME=麦迪文的试炼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop1:HeroPowerBase{
//NAME=末日冲锋
//TEXT=从你的牌库中<b>发现</b>一张随从牌。召唤一个它的复制，并使其随机攻击一个敌人然后死亡。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop2:HeroPowerBase{
//NAME=原始之力
//TEXT=受到$3点伤害。在本回合中获得+$a3攻击力。获得$d3点护甲值。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop2e1:Ability{
//NAME=原始之力
//TEXT=在本回合中，你的英雄拥有额外攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop3:HeroPowerBase{
//NAME=恶魔变形
//TEXT=随机弃一张牌。随机将一张法力值消耗相同的恶魔牌置入你的手牌，其法力值消耗减少（2）点。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop3e1:Ability{
//NAME=恶魔变形
//TEXT=法力值消耗减少。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop5:HeroPowerBase{
//NAME=超级原始之力
//TEXT=在本回合中获得+$a3攻击力。获得$d3点护甲值。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablop5e1:Ability{
//NAME=超级原始之力
//TEXT=在本回合中<b>吸血</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot1:WeaponBase{
//NAME=恐怖利爪
//TEXT=<b>对战开始时：</b>抽到这张牌。同时对攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=6|ATK=6|HP=3|RACE=NONE
}
public class PVPDR_GUEST_Diablot2:SpellBase{
//NAME=火焰践踏
//TEXT=对所有敌方角色造成$3点伤害。每击中一个敌人，便恢复1点生命值；如果敌人死亡，则额外恢复1点。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class PVPDR_GUEST_Diablot3:SpellBase{
//NAME=末日
//TEXT=消灭所有随从。在本局对战的剩余时间内，你的对手受到的伤害翻倍。
//MAJ=WARRIOR|COST=8|ATK=0|HP=0|RACE=FIRE
}
public class PVPDR_GUEST_Diablot3e:Ability{
//NAME=天启
//TEXT=使其受到的所有伤害翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot4:SpellBase{
//NAME=灵魂石陷阱
//TEXT=消灭一个随从，获得等同于其攻击力和生命值的攻击力和护甲值。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_GUEST_Diablot4e2:Ability{
//NAME=灵魂石强化
//TEXT=攻击力提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot5:WeaponBase{
//NAME=烈焰之角
//TEXT=在你的回合开始时，随机将一张暗影或火焰法术牌置入你的手牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=3|RACE=NONE
}
public class PVPDR_GUEST_Diablot6:SpellBase{
//NAME=向东流浪
//TEXT=<b>任务：</b>在你的回合中受到25点伤害。<b>奖励：</b>变形成为超级迪亚波罗。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot6h1:HeroBase{
//NAME=超级迪亚波罗
//TEXT=变形时，对所有敌人造成6点伤害。将一张超级末日置入你的手牌，抽3张牌。
//MAJ=WARRIOR|COST=6|ATK=0|HP=30|RACE=NONE
}
public class PVPDR_GUEST_Diablot6s3:SpellBase{
//NAME=超级末日
//TEXT=消灭所有随从。在本局对战的剩余时间内，敌方角色受到的伤害翻倍。
//MAJ=WARRIOR|COST=10|ATK=0|HP=0|RACE=FIRE
}
public class PVPDR_GUEST_Diablot6s3e:Ability{
//NAME=超级末日
//TEXT=使其受到的所有伤害翻倍。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot6s4:SpellBase{
//NAME=黑暗灵魂石
//TEXT=将一张迪亚波罗的签名版宝藏牌置入你的手牌。将这张牌洗入你的牌库。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_GUEST_Diablot7:SpellBase{
//NAME=乔丹之石
//TEXT=在本回合中获得+2攻击力。抽两张牌，抽到的任意法术牌会获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot7e1:Ability{
//NAME=乔丹之石附加效果
//TEXT=在本回合中+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GUEST_Diablot7e2:Ability{
//NAME=乔丹之石的法强
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GvG_BucketList:SpellBase{
//NAME=地精大战侏儒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_GVGNAX_BucketList:SpellBase{
//NAME=地精侏儒萨玛斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Hero_Bob:HeroBase{
//NAME=餐馆老板鲍勃
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class PVPDR_Hero_Brann:HeroBase{
//NAME=布莱恩·铜须
//TEXT=跨上恐龙，但求一战，布莱恩做好了准备，解决这 一切。
//MAJ=HUNTER|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Darius:HeroBase{
//NAME=达利乌斯·克罗雷
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Diablo:HeroBase{
//NAME=迪亚波罗
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekThar:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekTharv1:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekTharv2:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekTharv3:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekTharv4:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_DrekTharv5:HeroBase{
//NAME=德雷克塔尔
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Elise:HeroBase{
//NAME=伊莉斯·逐星
//TEXT=一手魔法，一手弯刀，伊莉斯做好了准备，拯救奥 丹姆。
//MAJ=DRUID|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Finley:HeroBase{
//NAME=芬利爵士
//TEXT=战驹疾驰，正义将至，芬利爵士做好了准备，惩戒最终的敌人。
//MAJ=PALADIN|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Fireheart:HeroBase{
//NAME=导师火心
//TEXT=过载，图腾，把其他玩家的宝藏随从衰变成课桌小鬼。
//MAJ=SHAMAN|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_HeadlessHorseman:HeroBase{
//NAME=无头骑士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=15|RACE=NONE
}
public class PVPDR_Hero_Illucia:HeroBase{
//NAME=裂心者伊露希亚
//TEXT=生成资源，控场，脏。
//MAJ=PRIEST|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_KelThuzad:HeroBase{
//NAME=校长克尔苏加德
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=15|RACE=NONE
}
public class PVPDR_Hero_Kulzon:HeroBase{
//NAME=施法大师库尔佐
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=15|RACE=NONE
}
public class PVPDR_Hero_Lilian:HeroBase{
//NAME=渗透者莉莉安
//TEXT=武器，<b>潜行</b>，就当对战面板是个充气城堡。
//MAJ=ROGUE|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Mozaki:HeroBase{
//NAME=决斗大师莫扎奇
//TEXT=法术，伤害，还有法术伤害
//MAJ=MAGE|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Omu:HeroBase{
//NAME=林地守护者欧穆
//TEXT=树人，法术伤害。第五回合用出优胜劣汰。
//MAJ=DRUID|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Rattlegore:HeroBase{
//NAME=血骨傀儡
//TEXT=护甲！<b>突袭</b>！伤痛！值了！
//MAJ=WARRIOR|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Reno:HeroBase{
//NAME=雷诺·杰克逊
//TEXT=带好宝藏，剪好胡须，雷诺做好了准备，干掉塔 卡恒！
//MAJ=MAGE|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Sai:HeroBase{
//NAME=萨伊·影风
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Scarlet:HeroBase{
//NAME=斯嘉丽·叶舞
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Slate:HeroBase{
//NAME=斯雷特教授
//TEXT=野兽，亡语，还有……奥秘。
//MAJ=HUNTER|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Stelina:HeroBase{
//NAME=明星学员斯特里娜
//TEXT=灵魂残片，进攻。以脸换脸。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Turalyon:HeroBase{
//NAME=终身教授图拉扬
//TEXT=提高属性值，复活。还剩一个盾，圣盾。
//MAJ=PALADIN|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndar:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndarv1:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndarv2:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndarv3:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndarv4:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Vanndarv5:HeroBase{
//NAME=范达尔·雷矛
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Hero_Willow:HeroBase{
//NAME=高阶女巫维洛
//TEXT=过牌，灵魂残片。恶魔？就是恶魔。
//MAJ=WARLOCK|COST=0|ATK=0|HP=20|RACE=NONE
}
public class PVPDR_Initiate_BucketList:SpellBase{
//NAME=新兵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Journey_BucketList:SpellBase{
//NAME=勇闯安戈洛
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Kara_BucketList:SpellBase{
//NAME=卡拉赞之夜
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Kobolds_BucketList:SpellBase{
//NAME=狗头人与地下世界
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_League_BucketList:SpellBase{
//NAME=探险者协会
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_LichKing_BucketList:SpellBase{
//NAME=巫妖王的进军
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_LOOT_SmartyPants:SpellBase{
//NAME=机智之裤
//TEXT=使一个随从获得+1/+1，以及“<b>亡语：</b>将一张“探险帽”置入你的手牌。”
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Murderous_BucketList:SpellBase{
//NAME=杀戮之选
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Naxx_BucketList:SpellBase{
//NAME=纳克萨玛斯的诅咒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Rastakhan_BucketList:SpellBase{
//NAME=拉斯塔哈的大乱斗
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Recipe_Check:SpellBase{
//NAME=检查配方
//TEXT=检查配方
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_HP1:HeroPowerBase{
//NAME=业余法师
//TEXT=造成$1点伤害。<b>连击：</b>改为造成$2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_HP2:HeroPowerBase{
//NAME=“考古专家”
//TEXT=在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_HP3:HeroPowerBase{
//NAME=玩弄奥术
//TEXT=随机向敌方随从发射两枚飞弹，每枚造成$1点伤害。如果任何随从死亡，则重复此效果。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_T1:SpellBase{
//NAME=雷诺的幸运帽
//TEXT=使一个随从获得+2/+2以及<b>法术伤害+2</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_T2:WeaponBase{
//NAME=雷诺的灵动套索
//TEXT=在你的英雄攻击后，复制你对手的一张手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class PVPDR_Reno_T3:SpellBase{
//NAME=雷诺的魔法火把
//TEXT=造成$4点伤害。<b>连击：</b>将这张牌的一张复制洗入你的牌库，其造成的伤害增加1点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_T4:MinionBase{
//NAME=初级探墓员
//TEXT=<b>战吼：</b>在本局对战中，如果你使用了9张奥秘牌，则将你的英雄技能变为“<b>发现</b>一张宝藏牌”。
//MAJ=MAGE|COST=4|ATK=5|HP=5|RACE=NONE
}
public class PVPDR_Reno_T4_2:MinionBase{
//NAME=高级探墓员
//TEXT=<b>战吼：</b>在本局对战中，如果你使用了5张奥秘牌，则将你的英雄技能变为“<b>发现</b>一张宝藏牌”。
//MAJ=MAGE|COST=4|ATK=5|HP=5|RACE=NONE
}
public class PVPDR_Reno_T4_2hp:HeroPowerBase{
//NAME=奥丹姆宝箱
//TEXT=<b>发现</b>一张宝藏牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Reno_T5:MinionBase{
//NAME=雷·火掌
//TEXT=每个回合中，在你施放第一个法术后，再次施放该法术<i>（目标不变）</i>。
//MAJ=MAGE|COST=4|ATK=2|HP=6|RACE=NONE
}
public class PVPDR_Reno_T6:SpellBase{
//NAME=加特林法杖
//TEXT=造成$3点伤害，随机分配到所有敌方随从身上<i>（在本局对战中你每施放一个法术都会提高）</i>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_REV_Passive1:SpellBase{
//NAME=注意地标
//TEXT=<b>被动</b> 对战开始时，拥有一个你的职业的地标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_REV_Passive2:SpellBase{
//NAME=急速指环
//TEXT=<b>被动</b> 在每回合中，你每使用三张随从牌，第三张随从牌的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_REV_Passive2e:Ability{
//NAME=急速指环附加效果
//TEXT=在每回合中，你每使用三张随从牌，第三张随从牌的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_REV_Passive3:SpellBase{
//NAME=热情好客
//TEXT=<b>被动</b> 对战开始时，将3张传说邀请函洗入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_REV_Passive4:SpellBase{
//NAME=易碎之骨
//TEXT=<b>被动</b> 在你施放法术并消灭敌人后，召唤一个2/2的不稳定的骷髅。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_REV_Passive4e:Ability{
//NAME=易碎之骨附加效果
//TEXT=在你施放法术并消灭敌人后，召唤一个2/2的不稳定的骷髅。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RiseShadows_BucketList:SpellBase{
//NAME=暗影崛起
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Active01:MinionBase{
//NAME=小小顶针
//TEXT=<b>突袭</b>，<b>亡语：</b>将一个均码顶针置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class PVPDR_RLK_Active01a:MinionBase{
//NAME=均码顶针
//TEXT=<b>突袭</b>。在本随从攻击并消灭一个随从后，获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=UNDEAD
}
public class PVPDR_RLK_Passive01:SpellBase{
//NAME=尸体收藏家
//TEXT=<b>被动</b> 每回合中，在你第一次获得<b>尸体</b>后，额外获得1具<b>尸体</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive01e1:Ability{
//NAME=尸体收藏家附加效果
//TEXT=每回合中，在你第一次获得<b>尸体</b>后，额外获得1具<b>尸体</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive02:SpellBase{
//NAME=鲜血护盾
//TEXT=<b>被动</b> 每回合中，在你第一次消耗<b>尸体</b>后，获得2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive02e1:Ability{
//NAME=鲜血护盾附加效果
//TEXT=每回合中，在你第一次消耗尸体后，获得2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive03:SpellBase{
//NAME=食尸鬼突进
//TEXT=<b>被动</b> 每回合中，在你第一次消耗<b>尸体</b>后，召唤一个2/2并具有<b>突袭</b>的复活的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive03e1:Ability{
//NAME=食尸鬼突进附加效果
//TEXT=每回合中，在你第一次消耗<b>尸体</b>后，召唤一个2/2并具有<b>突袭</b>的复活的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive03m1:MinionBase{
//NAME=复活的食尸鬼
//TEXT=<b>突袭</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class PVPDR_RLK_Passive04:SpellBase{
//NAME=逃婚联军
//TEXT=<b>被动</b> 在你的回合结束时，召唤一个属性值等同于你的<b>尸体</b>总量一半的复活的新郎。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive04e1:Ability{
//NAME=逃婚联军附加效果
//TEXT=每回合中，在你第一次消耗<b>尸体</b>后，召唤一个2/2并具有<b>突袭</b>的复活的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Passive04m1:MinionBase{
//NAME=复活的新郎
//TEXT=<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class PVPDR_RLK_Sai_HP1:HeroPowerBase{
//NAME=食尸鬼闪击
//TEXT=召唤一个2/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Sai_HP1t:MinionBase{
//NAME=无情的食尸鬼
//TEXT=<b>冲锋</b>。在你的回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class PVPDR_RLK_Sai_HP2:HeroPowerBase{
//NAME=风暴汇聚
//TEXT=获得一具<b>尸体</b>。抽一张牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Sai_HP3:HeroPowerBase{
//NAME=巫妖之躯的力量
//TEXT=使一个友方随从获得+3/+3。它会在你的回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Sai_HP3e:Ability{
//NAME=巫妖之躯的力量
//TEXT=本随从拥有+3/+3，但会在回合结束时死于非命。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Scarlet_HP1:HeroPowerBase{
//NAME=鲜血寄生虫
//TEXT=召唤一只2/1并具有<b>吸血</b>的血虫。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Scarlet_HP1t:MinionBase{
//NAME=血虫
//TEXT=<b>吸血</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class PVPDR_RLK_Scarlet_HP2:HeroPowerBase{
//NAME=血液学
//TEXT=消耗最多3具<b>尸体</b>。每消耗一具，使你一张手牌的法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Scarlet_HP2e1:Ability{
//NAME=血液学
//TEXT=法力值消耗减少。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_RLK_Scarlet_HP3:HeroPowerBase{
//NAME=天灾
//TEXT=<b>发现</b>一张亡灵牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Sai_T1:MinionBase{
//NAME=格拉斯
//TEXT=<b>战吼：</b>使你的其他亡灵获得+2/+1和<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=5|ATK=4|HP=2|RACE=UNDEAD
}
public class PVPDR_Sai_T1e:Ability{
//NAME=格拉斯的成长
//TEXT=+2/+1
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Sai_T2:WeaponBase{
//NAME=冰川之斧
//TEXT=<b>亡语：</b>装备一把2/3的冰斧翼刃。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=2|RACE=NONE
}
public class PVPDR_Sai_T2a:WeaponBase{
//NAME=冰斧翼刃
//TEXT=<b>风怒</b>，<b>亡语：</b>召唤三个1/1并具有<b>复生</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=4|ATK=2|HP=3|RACE=NONE
}
public class PVPDR_Sai_T2at:MinionBase{
//NAME=食尸鬼
//TEXT=
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class PVPDR_Sai_T2at1:MinionBase{
//NAME=蹒跚的僵尸
//TEXT=<b>复生</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class PVPDR_Sai_T3:SpellBase{
//NAME=冰冷回忆
//TEXT=复活在本局对战中你的冰霜法术消灭的随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=0|HP=0|RACE=FROST
}
public class PVPDR_Sai_T3e1:Ability{
//NAME=冰寒回忆
//TEXT={0}
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Sai_T4:SpellBase{
//NAME=邪恶之拥
//TEXT=消耗最多10具<b>尸体</b>，每消耗一具，将一张邪恶符文牌置入你的手牌。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Sai_T5:MinionBase{
//NAME=冰寒格拉斯
//TEXT=<b>战吼：</b>从你的牌库中召唤两个亡灵并使其<b>冻结</b>。
//MAJ=DEATHKNIGHT|COST=7|ATK=6|HP=4|RACE=UNDEAD
}
public class PVPDR_Sai_T6:MinionBase{
//NAME=酷寒食尸鬼
//TEXT=<b>突袭</b>，<b>复活</b>：（2）
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class PVPDR_Sai_T6e:Ability{
//NAME=溃烂之伤
//TEXT=<b>亡语：</b>传染给一个相邻角色，然后对你的英雄造成5点伤害。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Saviors_BucketList:SpellBase{
//NAME=奥丹姆奇兵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SAVLEAGUE_BucketList:SpellBase{
//NAME=奥丹姆探险者
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T1:WeaponBase{
//NAME=符文灵魂之剑
//TEXT=在你的英雄受到伤害后，对所有敌人造成1点伤害并失去1点耐久度。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=4|RACE=NONE
}
public class PVPDR_Scarlet_T1e:Ability{
//NAME=危险符文
//TEXT=每当你的英雄受到伤害时，对所有敌人造成1点伤害并失去1点耐久度。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T2:SpellBase{
//NAME=天灾打击
//TEXT=获得1具<b>尸体</b>，消灭1个敌方随从，抽1张牌。<i>（效果会随着对决进度提升）</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T3:MinionBase{
//NAME=血红之鹰
//TEXT=每当你的英雄获得治疗时，本随从获得等量的攻击力和生命值。
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=2|RACE=UNDEAD
}
public class PVPDR_Scarlet_T3e:Ability{
//NAME=进食充分
//TEXT=+{0}/+{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T4:WeaponBase{
//NAME=铁纹放血刃
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，每当你消耗<b>尸体</b>时，为你的英雄恢复2点生命值。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=2|RACE=NONE
}
public class PVPDR_Scarlet_T4e:Ability{
//NAME=铁纹放血刃附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T5:WeaponBase{
//NAME=黑锋重剑
//TEXT=每当你使用一张随从牌时，使其获得<b>复生</b>，这把武器失去1点耐久度。
//MAJ=DEATHKNIGHT|COST=3|ATK=1|HP=5|RACE=NONE
}
public class PVPDR_Scarlet_T5e:Ability{
//NAME=吸血诅咒
//TEXT=如果这张牌在你的手牌中，在你的回合开始时，你的英雄受到2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_Scarlet_T6:SpellBase{
//NAME=传染药剂
//TEXT=感染一个随从，使其获得“<b>亡语：</b>对你的英雄造成3点伤害，然后传染给一个相邻角色。”
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scarlet_T6e:Ability{
//NAME=疮毒传染
//TEXT=<b>亡语：</b>传染给一个相邻角色，然后对你的英雄造成3点伤害。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active01:SpellBase{
//NAME=拟态面具
//TEXT=选择一个随从。你手牌中的所有随从牌都变成它的复制。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active02:SpellBase{
//NAME=机关盒
//TEXT=随机将所有随从变形成为法力值消耗增加（3）点的其他 随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active03:SpellBase{
//NAME=散播种子
//TEXT=使你牌库中的所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Active03e1:Ability{
//NAME=种子扎根
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active05:SpellBase{
//NAME=势不可挡
//TEXT=在本回合中，你在使用一张卡牌后，再次使用该卡牌<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active05e1:Ability{
//NAME=势不可挡
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active07:SpellBase{
//NAME=裂解魔杖
//TEXT=<b>沉默</b>并消灭所有敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active08:MinionBase{
//NAME=宴会传送门
//TEXT=每当你施放一个法术，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=NONE
}
public class PVPDR_SCH_Active10:WeaponBase{
//NAME=大法师之杖
//TEXT=在你的回合开始时，随机将一张法师法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class PVPDR_SCH_Active11:SpellBase{
//NAME=充盈之袋
//TEXT=抽牌直到手牌数量达到上限。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active14:SpellBase{
//NAME=一袋钱币
//TEXT=将三张幸运币置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active17:SpellBase{
//NAME=狩猎经验
//TEXT=使你手牌中的所有卡牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active17e1:Ability{
//NAME=洞察
//TEXT=这张卡牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active19:SpellBase{
//NAME=坎努匹克陶罐
//TEXT=使你的所有随从获得“<b>亡语：</b>随机召唤一个<b>传说</b>随从。”
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active19e1:Ability{
//NAME=坎努匹克陶罐
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active20:WeaponBase{
//NAME=法奥瑞斯之刃
//TEXT=<b>风怒</b> 在你的英雄攻击并消灭一个随从后，该武器获得+2/+1。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=3|RACE=NONE
}
public class PVPDR_SCH_Active20e1:Ability{
//NAME=法奥瑞斯之怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active21:SpellBase{
//NAME=远古映像
//TEXT=选择一个随从。用它的1/1的复制填满你的面板。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Active21e1:Ability{
//NAME=泰坦全息影像
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active23:SpellBase{
//NAME=香蕉分裂
//TEXT=使一个友方随从获得+2/+2，并召唤两个它的复制。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Active23e1:Ability{
//NAME=青光莹莹
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active24:WeaponBase{
//NAME=奎尔德拉的剑刃
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class PVPDR_SCH_Active24e1:SpellBase{
//NAME=铸造奎尔德拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active25:WeaponBase{
//NAME=奎尔德拉
//TEXT=<b>对战开始时：</b>抽到这张牌。在你的英雄攻击后，对所有敌人造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class PVPDR_SCH_Active26:MinionBase{
//NAME=忠诚的小伙伴
//TEXT=<b>嘲讽</b> 在本次冒险中每打败过一个<b>对手</b>，便拥有+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
}
public class PVPDR_SCH_Active27:WeaponBase{
//NAME=贪婪之镐
//TEXT=在你的英雄攻击后，获得一个空的法力水晶。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
}
public class PVPDR_SCH_Active28:SpellBase{
//NAME=诡异的项链
//TEXT=召唤三个1/1的幽灵。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active28m1:MinionBase{
//NAME=阴郁的幽灵
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class PVPDR_SCH_Active28m2:MinionBase{
//NAME=阴郁的幽灵
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=UNDEAD
}
public class PVPDR_SCH_Active28m3:MinionBase{
//NAME=阴郁的幽灵
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=UNDEAD
}
public class PVPDR_SCH_Active28s1:SpellBase{
//NAME=恐怖的项链
//TEXT=召唤三个2/2的幽灵。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active28s2:SpellBase{
//NAME=诅咒的项链
//TEXT=召唤三个3/3并具有<b>吸血</b>的 幽灵。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active29:MinionBase{
//NAME=野兽美女
//TEXT=<b>突袭</b> 在本随从攻击一个随从并存活下来后，变形成为8/8的随从。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=NONE
}
public class PVPDR_SCH_Active29m1:MinionBase{
//NAME=美女野兽
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=NONE
}
public class PVPDR_SCH_Active30:SpellBase{
//NAME=鲜血之月
//TEXT=使你的所有随从获得+1/+1和 <b>吸血</b>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active30e1:Ability{
//NAME=鲜血渴望
//TEXT=+1/+1并具有<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active31:SpellBase{
//NAME=小袋钱币
//TEXT=随机召唤一个法力值消耗为（3）的随从。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active31s1:SpellBase{
//NAME=中袋钱币
//TEXT=随机召唤一个法力值消耗为（6）的随从。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active31s2:SpellBase{
//NAME=大袋钱币
//TEXT=随机召唤一个法力值消耗为（3）、（6）和（9）的 随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active34:MinionBase{
//NAME=大侦探摩洛克·福尔摩斯
//TEXT=每当你的对手抽一张牌时，将其复制置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MURLOC
}
public class PVPDR_SCH_Active35:SpellBase{
//NAME=陈旧的军号
//TEXT=使你的所有随从获得+1/+1和<b>嘲讽</b>。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active35e1:Ability{
//NAME=鼓舞士气
//TEXT=+1/+1并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active35e2:Ability{
//NAME=士气旺盛
//TEXT=+2/+2并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active35e3:Ability{
//NAME=团结一致
//TEXT=+4/+4，<b>嘲讽，圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active35s1:SpellBase{
//NAME=普通的军号
//TEXT=使你的所有随从获得+2/+2和<b>嘲讽</b>。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active35s2:SpellBase{
//NAME=老兵的军号
//TEXT=使你的所有随从获得+4/+4，<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active38:SpellBase{
//NAME=望远镜
//TEXT=随机复制对手手牌中的一张牌，将其置入你的手牌。该牌的法力值消耗减少 （3）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active39:SpellBase{
//NAME=粗鄙的暴徒
//TEXT=随机消灭一个敌方随从。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active39s1:SpellBase{
//NAME=愤怒的暴徒
//TEXT=随机消灭两个敌方随从。将此牌升级并洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active39s2:SpellBase{
//NAME=疯狂的暴徒
//TEXT=<b>沉默</b>并消灭所有敌方随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active42:WeaponBase{
//NAME=驱魔者
//TEXT=<b>沉默</b>此武器攻击的任何随从。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class PVPDR_SCH_Active43:SpellBase{
//NAME=神圣典籍
//TEXT=<b>沉默</b>并消灭一个随从。召唤一个它的10/10复制。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=HOLY
}
public class PVPDR_SCH_Active43e1:Ability{
//NAME=神圣精华
//TEXT=攻击力和生命值变为10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active44:SpellBase{
//NAME=融合
//TEXT=消灭所有友方随从。召唤一个融合怪，其攻击力与生命值是所有消灭随从的总和。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active44m1:MinionBase{
//NAME=融合怪
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=ALL
}
public class PVPDR_SCH_Active45:MinionBase{
//NAME=布奇
//TEXT=<b>突袭</b> 在本局对战中每有一个友方野兽死亡，便拥有+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=BEAST
}
public class PVPDR_SCH_Active46:MinionBase{
//NAME=公主
//TEXT=<b>战吼：</b> 随机获得牌库中三个随从的<b>亡语</b>。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=6|RACE=BEAST
}
public class PVPDR_SCH_Active46e1:Ability{
//NAME=公主的骨头
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active47:MinionBase{
//NAME=布巴
//TEXT=<b>战吼：</b>召唤六只1/1的血猎犬，攻击一个敌方随从。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=BEAST
}
public class PVPDR_SCH_Active47t:MinionBase{
//NAME=血猎犬
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class PVPDR_SCH_Active48:MinionBase{
//NAME=发条助手
//TEXT=在本局对战中，你每施放一个法术，便拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=MECHANICAL
}
public class PVPDR_SCH_Active49:SpellBase{
//NAME=混沌理论
//TEXT=双方玩家施放手牌中所有的法术牌<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active50:MinionBase{
//NAME=铁杆匪徒
//TEXT=<b>对战开始时：</b>抽到这张牌。<b>嘲讽</b>。如果这张牌在你的手牌中，每个回合获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
}
public class PVPDR_SCH_Active50e:Ability{
//NAME=盘算阴谋
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active51:WeaponBase{
//NAME=超级能量枪
//TEXT=<b>剧毒</b> 你的英雄在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class PVPDR_SCH_Active51e:Ability{
//NAME=超级能量枪附加效果
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active52:MinionBase{
//NAME=硬壳横行蟹
//TEXT=<b>战吼：</b>消灭一个随从。获得其攻击力和生命值。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=BEAST
}
public class PVPDR_SCH_Active52e:Ability{
//NAME=嚼啊嚼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active53:SpellBase{
//NAME=飞蝗来袭
//TEXT=<b>双生法术</b> 选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Active53s:SpellBase{
//NAME=飞蝗来袭
//TEXT=选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Active53t:MinionBase{
//NAME=巨型蝗虫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class PVPDR_SCH_Active54:SpellBase{
//NAME=亡者之书
//TEXT=对所有敌人造成$7点伤害。在本局对战中，每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=14|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active55:SpellBase{
//NAME=拉格纳罗斯的余烬
//TEXT=随机向敌人射出三个火球，每个造成$8点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=FIRE
}
public class PVPDR_SCH_Active56:SpellBase{
//NAME=许愿术
//TEXT=用<b>传说</b>随从填满你的面板。为你的英雄恢复所有生命值。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active57:SpellBase{
//NAME=死灵毒药
//TEXT=消灭一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Active58:SpellBase{
//NAME=心智末日
//TEXT=双方玩家各抽两张牌，获得一个法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=FEL
}
public class PVPDR_SCH_Active59:WeaponBase{
//NAME=巨颚
//TEXT=每当一个具有<b>亡语</b>的随从死亡，便获得+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class PVPDR_SCH_Active59e:Ability{
//NAME=利齿
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active60:SpellBase{
//NAME=增压
//TEXT=使你的所有随从获得+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active60e:Ability{
//NAME=已增压
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Active61:SpellBase{
//NAME=极寒之击
//TEXT=对敌方英雄造成$8点伤害，并使其<b>冻结</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=FROST
}
public class PVPDR_SCH_ComingSoon:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoon_Forever:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoon_Foreverp1:HeroPowerBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoonp2:HeroPowerBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoonp3:HeroPowerBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoont2:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoont3:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoont4:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_ComingSoont5:SpellBase{
//NAME=敬请期待
//TEXT=敬请期待！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_DemonHunterp1:HeroPowerBase{
//NAME=地狱火撞击
//TEXT=在本回合中获得+$a1攻击力。在你的英雄攻击并消灭一个随从后，获取一张“二次斩击”。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_DemonHunterp1e:Ability{
//NAME=地狱火撞击
//TEXT=获得一张二次斩击。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_DemonHuntert2:SpellBase{
//NAME=召唤仪式
//TEXT=从你的牌库中召唤三个恶魔。它们会<b>休眠</b>2回合。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
}
public class PVPDR_SCH_DemonHuntert2e1:Ability{
//NAME=召唤仪式
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidp3:HeroPowerBase{
//NAME=自然恩赐
//TEXT=<b>抉择：</b>在本回合中+$a2攻击力；或者在本回合中获得<b>法术伤害+2</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidp3s1:SpellBase{
//NAME=锋锐利爪
//TEXT=在本回合中，使你的英雄获得+$a2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidp3s1e1:Ability{
//NAME=锋锐利爪
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidp3s3:SpellBase{
//NAME=星光
//TEXT=在本回合中，获得<b>法术伤害+2</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidp3s3e1:Ability{
//NAME=星光
//TEXT=在本回合中<b>法术伤害+2</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidt1s2:SpellBase{
//NAME=守护者的视界
//TEXT=你每拥有一个法力水晶，召唤一个树人。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidt2:SpellBase{
//NAME=守护者的洞察
//TEXT=<b>抉择：</b>复原你的法力水晶；或者你每拥有一个法力水晶，召唤一个树人。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Druidt5:SpellBase{
//NAME=神奇菌丝
//TEXT=<b>发现</b>一张<b>抉择</b>牌，然后将它洗入你的牌库。这张抉择牌会同时拥有两种效果。重复3次。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Druidt5e:Ability{
//NAME=神奇孢子
//TEXT=在你的回合结束时弃掉这张牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Druidt6:WeaponBase{
//NAME=牧人号角
//TEXT=在你使用一张野兽牌后，召唤一个它的复制并失去1点耐久度。
//MAJ=DRUID|COST=2|ATK=0|HP=3|RACE=NONE
}
public class PVPDR_SCH_Hunterp1:HeroPowerBase{
//NAME=生存训练
//TEXT=对敌方英雄造成2点伤害，然后随机使一个友方随从获得+1攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Hunterp1e1:Ability{
//NAME=生存训练
//TEXT=+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Huntert2:MinionBase{
//NAME=碾骨兔
//TEXT=<b>突袭</b>，<b>亡语</b>：召唤两个本局对战中死亡的其他<b>亡语</b>随从。
//MAJ=HUNTER|COST=6|ATK=5|HP=3|RACE=BEAST
}
public class PVPDR_SCH_Magep3:HeroPowerBase{
//NAME=浮龙箭
//TEXT=造成$1点伤害。如果该英雄技能消灭了一个随从，则召唤一条1/3的法力浮龙。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Maget3:WeaponBase{
//NAME=决斗魔杖
//TEXT=你的英雄技能会额外造成1点伤害，在每次使用后失去1点耐久度。
//MAJ=MAGE|COST=1|ATK=0|HP=5|RACE=NONE
}
public class PVPDR_SCH_Maget5:SpellBase{
//NAME=无尽奥术
//TEXT=摧毁你的牌库。每回合从你被摧毁的牌库中<b>发现</b>一张牌并抽取，其法力值消耗减少（2）点。
//MAJ=MAGE|COST=9|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_SCH_Maget5e:Ability{
//NAME=一切答案
//TEXT=从你的牌库中<b>发现</b>一张牌。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Maget5e2:Ability{
//NAME=同中有异
//TEXT=法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Paladinp1:HeroPowerBase{
//NAME=圣光金辉
//TEXT=复活一个在本局对战中死亡的友方随从，其剩余生命值为1点。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Paladint1:WeaponBase{
//NAME=王室巨剑
//TEXT=在你的英雄攻击后，从你的牌库中召唤一个<b>传说</b>随从。
//MAJ=PALADIN|COST=7|ATK=5|HP=3|RACE=NONE
}
public class PVPDR_SCH_Passive05:SpellBase{
//NAME=罗宁的占卜宝珠
//TEXT=<b>被动</b> 在每回合中，你施放的第一个法术的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive05e1:Ability{
//NAME=罗宁的占卜宝珠附加效果
//TEXT=在每回合中，你施放的第一个法术的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive06:SpellBase{
//NAME=神秘典籍
//TEXT=<b>被动</b> 对战开始时，随机使用两张<b>奥秘</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive07:SpellBase{
//NAME=缩小长袍
//TEXT=<b>被动</b> 在你抽到一张法术牌后，在本回合中将其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive07e1:Ability{
//NAME=缩小长袍玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive07e2:Ability{
//NAME=缩小长袍
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive08:SpellBase{
//NAME=迷你背包
//TEXT=<b>被动</b> 对战开始时，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive09:SpellBase{
//NAME=学徒长袍
//TEXT=<b>被动</b> <b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive10:SpellBase{
//NAME=月之系带
//TEXT=<b>被动</b> 每回合你使用的第一张<b>亡语</b>随从牌会触发其<b>亡语</b>效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive10e:Ability{
//NAME=月之系带玩家强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive11:SpellBase{
//NAME=火箭背包
//TEXT=<b>被动</b> 在每个回合中，你使用的第一张随从牌拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive11e1:Ability{
//NAME=火箭背包玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive11e2:Ability{
//NAME=火箭背包
//TEXT=拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive12:SpellBase{
//NAME=翠绿护目镜
//TEXT=<b>被动</b> 使你最左边的手牌法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive12e1:Ability{
//NAME=翠绿护目镜玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive12e2:Ability{
//NAME=翠绿护目镜
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive14:SpellBase{
//NAME=晶化宝石
//TEXT=<b>被动</b> 在你的前两个回合，你有一个额外的法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive14e1:Ability{
//NAME=晶化宝石附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive15a1:SpellBase{
//NAME=散布蒺藜
//TEXT=<b>被动</b> 在你的对手每个回合使用其第一张随从牌后，对该随从造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive15a1e:Ability{
//NAME=散布蒺藜玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive16:SpellBase{
//NAME=打扫战场
//TEXT=<b>被动</b> 每当你的武器被摧毁时，随机装备一把法力值消耗相同的武器，并使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive16e2:Ability{
//NAME=打扫战场玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive16e3:Ability{
//NAME=打扫战场
//TEXT=攻击力提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive17:SpellBase{
//NAME=回收
//TEXT=<b>被动</b> 在一个友方随从死亡后，获得1点护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive17d:SpellBase{
//NAME=回收占位效果
//TEXT=为回收玩家附加效果（DALA728e）保留占位效果
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive17e:Ability{
//NAME=回收玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive18:SpellBase{
//NAME=尽为我用
//TEXT=<b>被动</b> 每回合中，在第一个友方恶魔死亡后，从你的牌库中抽一张随从牌并使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive18e:Ability{
//NAME=尽为我用
//TEXT=<b>被动</b> 每回合中，在第一个友方恶魔死亡后，从你的牌库中抽一张随从牌并使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive18e2:Ability{
//NAME=尽为我用
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive19:SpellBase{
//NAME=啃食
//TEXT=<b>被动</b> 每当一个友方随从死亡，使其相邻的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive19e:Ability{
//NAME=啃食
//TEXT=<b>被动</b> 每当一个友方随从死亡，使其相邻的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive19e2:Ability{
//NAME=如此美味
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive20:SpellBase{
//NAME=龙族亲和
//TEXT=<b>被动</b> 每回合中，你使用的第一张龙牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive20e:Ability{
//NAME=龙族亲和
//TEXT=每回合中，你使用的第一张龙牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive21:SpellBase{
//NAME=巨龙之血
//TEXT=<b>被动</b> 每回合中，在第一条友方的龙死亡后，使你手牌中的随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive21e:Ability{
//NAME=巨龙之血
//TEXT=每回合中，在第一条友方的龙死亡后，使你手牌中的随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive21e2:Ability{
//NAME=巨龙之血
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive22:SpellBase{
//NAME=龙骨仪式
//TEXT=<b>被动</b> 在你使用一张龙牌后，使其获得“<b>亡语：</b>进入休眠状态，两回合后复活。当其唤醒时，使其获得+1攻击力。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive22e:Ability{
//NAME=龙骨仪式
//TEXT=在你使用一张龙牌后，使其获得“<b>亡语：</b>进入休眠状态，两回合后复活。当其唤醒时，使其获得+1攻击力。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive22e2:Ability{
//NAME=巨龙墓场
//TEXT=<b>亡语：</b>进入休眠状态，两回合后复活。当其唤醒时，使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive22e3:Ability{
//NAME=龙骨仪式
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive23:SpellBase{
//NAME=塑造火焰
//TEXT=<b>被动</b> 在你施放一个法术后，随机对一个敌人造成$1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive23_T:MinionBase{
//NAME=骨堆
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive23e:Ability{
//NAME=塑造火焰
//TEXT=<b>被动</b> 在你施放一个法术后，随机对一个敌人造成$1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive24:SpellBase{
//NAME=沼泽诅咒
//TEXT=<b>被动</b> 每个回合中，在第一个敌人死亡后，复活一个1/1的浮肿僵尸。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive24e:Ability{
//NAME=沼泽诅咒
//TEXT=<b>被动</b> 每个回合中，在第一个敌人死亡后，复活一个1/1的浮肿僵尸。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive24t:MinionBase{
//NAME=浮肿僵尸
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class PVPDR_SCH_Passive28:SpellBase{
//NAME=法力风暴
//TEXT=<b>被动</b> 玩家在开始时拥有十个法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive30:SpellBase{
//NAME=瘟疫使者
//TEXT=<b>被动</b> 你的法术牌会过载（1）点，法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive30e:Ability{
//NAME=瘟疫使者
//TEXT=<b>被动</b> 你的法术牌会过载（1）点，法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive30e2:Ability{
//NAME=瘟疫使者
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive32:SpellBase{
//NAME=沙漠伏兵
//TEXT=<b>被动</b> 在你使用一张法力值消耗小于或等于3的随从牌后，使其获得<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive32e:Ability{
//NAME=沙漠伏兵
//TEXT=<b>被动</b> 在你使用一张法力值消耗小于或等于3的随从牌后，使其获得<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive32e2:Ability{
//NAME=潜伏沙中
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive34:SpellBase{
//NAME=宣称占有
//TEXT=<b>被动</b> 每回合中，在你使用第一张<b>发现</b>牌后，所有友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive34e:Ability{
//NAME=宣称占有
//TEXT=每回合中，在你使用第一张<b>发现</b>牌后，所有友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive34e2:Ability{
//NAME=严正宣称
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive36:SpellBase{
//NAME=饥饿
//TEXT=<b>被动</b> 在你的回合中，在第一只友方野兽死亡后，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive36e:Ability{
//NAME=饥饿
//TEXT=在你的回合中，在第一只友方野兽死亡后，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive36e2:Ability{
//NAME=饥饿
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive39:SpellBase{
//NAME=岩浆地板
//TEXT=<b>被动</b> 每回合中，在你使用第一张随从牌后，对其造成1点伤害并使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive39e:Ability{
//NAME=岩浆地板
//TEXT=每回合中，在你使用第一张随从牌后，对其造成1点伤害并使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Passive39e2:Ability{
//NAME=岩浆铺地
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Priestp1:HeroPowerBase{
//NAME=暗影愈合
//TEXT=为一个角色恢复#2点生命值。如果目标仍处于受伤状态，抽一张牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Priestt1:SpellBase{
//NAME=精神分裂
//TEXT=召唤一个随从的两个复制，然后<b>沉默</b>本体。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Roguep1:HeroPowerBase{
//NAME=利刃出鞘
//TEXT=装备一把1/2的匕首。<b>连击：</b>改为装备一把2/2的匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Roguet1:SpellBase{
//NAME=王牌降临
//TEXT=将你上回合使用的所有卡牌的复制置入手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Roguet2:SpellBase{
//NAME=致命武器手册
//TEXT=使你的武器获得+2/+2。<b>连击：</b>并使其获得<b>剧毒</b>。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_SCH_Roguet2e1:Ability{
//NAME=致命武器：剧毒
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Roguet2e2:Ability{
//NAME=致命武器：升级
//TEXT=+2攻击力和+2耐久度。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Shamanp1:HeroPowerBase{
//NAME=图腾力量
//TEXT=随机召唤一个基础图腾。如果你有<b>过载</b>的法力水晶，改为召唤一个非基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Shamant2:MinionBase{
//NAME=波动图腾
//TEXT=<b>潜行</b>一回合。在你的回合结束时，异变相邻的随从。
//MAJ=SHAMAN|COST=2|ATK=1|HP=4|RACE=TOTEM
}
public class PVPDR_SCH_Shamant2e1:SpellBase{
//NAME=波动
//TEXT=获得潜行直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warlockp2:HeroPowerBase{
//NAME=黑暗的艺术
//TEXT=检视你手牌里的3张牌，弃掉一张，然后抽一张牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warlockp2e:Ability{
//NAME=黑暗的艺术
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warlockp3:HeroPowerBase{
//NAME=灵魂研习
//TEXT=<b>被动</b> 每当你使用生成灵魂残片的牌时，召唤一个3/2的烈焰小鬼。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warlockt2:MinionBase{
//NAME=放逐者基尔莫克斯
//TEXT=<b>突袭</b>。<b>吸血</b> 在本局对战中，你每弃一张牌，本随从拥有+1/+1。如果这张随从牌被弃掉，将其移回你的手牌。
//MAJ=WARLOCK|COST=7|ATK=3|HP=3|RACE=DEMON
}
public class PVPDR_SCH_Warlockt2e:Ability{
//NAME=势不可挡
//TEXT=攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warlockt4:SpellBase{
//NAME=恶魔学识导论
//TEXT=消灭所有随从。每消灭一个敌方随从，将一张灵魂残片洗入你的牌库。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_SCH_Warlockt5:MinionBase{
//NAME=魔化恶魔
//TEXT=<b>战吼：</b>将1张恶魔牌置入你的手牌。这些恶魔牌的法力值消耗减少（2）点。<i>（效果会随着对决进度提升）</i>
//MAJ=WARLOCK|COST=5|ATK=4|HP=3|RACE=DEMON
}
public class PVPDR_SCH_Warlockt5e1:Ability{
//NAME=恶魔化
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warriorp1:HeroPowerBase{
//NAME=勇武过人
//TEXT=对一个随从造成1点伤害。如果该随从依然存活，使其获得+2攻击力；如果该随从死亡，获得$d2点护甲值。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warriorp1e:Ability{
//NAME=勇武
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warriort1:MinionBase{
//NAME=自走武库
//TEXT=每当本随从受到伤害，抽一张随从牌并使其获得+1/+1。
//MAJ=WARRIOR|COST=4|ATK=2|HP=6|RACE=MECHANICAL
}
public class PVPDR_SCH_Warriort1e:Ability{
//NAME=自动武装
//TEXT=+1/+1
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SCH_Warriort2:WeaponBase{
//NAME=尖刺武装
//TEXT=在你召唤一个随从后，对其造成1点伤害并使其获得+2攻击力。
//MAJ=WARRIOR|COST=4|ATK=1|HP=3|RACE=NONE
}
public class PVPDR_SCH_Warriort2e1:Ability{
//NAME=野蛮激励
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Scholomance_BucketList:SpellBase{
//NAME=通灵学园
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive20:SpellBase{
//NAME=无恒药剂
//TEXT=<b>被动</b> 在你的回合结束时，将一个友方随从变形成为法力值消耗增加（2）点的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive20e:Ability{
//NAME=无恒药剂玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive21:SpellBase{
//NAME=哈加莎的拥抱
//TEXT=<b>被动</b> 在你的回合开始时，随机使你手牌中的两张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive21d:SpellBase{
//NAME=哈加莎的拥抱占位效果
//TEXT=为施放了哈加莎的拥抱的玩家保留附加效果（PVPDR SW Passive21e）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive21e:Ability{
//NAME=哈加莎的拥抱玩家附加效果
//TEXT=在你的回合开始时，随机使你手牌中的两张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive21e2:Ability{
//NAME=哈加莎的拥抱
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_01:SpellBase{
//NAME=小队替补
//TEXT=<b>被动</b> 在你的回合开始时，召唤一个2/2并具有随机效果的冒险者。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_01e1:Ability{
//NAME=小队替补玩家附加效果
//TEXT=<b>被动</b> 在你的回合开始时，召唤一个2/2并具有随机效果的冒险者。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_02:SpellBase{
//NAME=振奋士气
//TEXT=<b>被动</b> 在你使用一张<b>传说</b>随从牌后，随机使你手牌中的一张卡牌的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_02e1:Ability{
//NAME=振奋士气附加效果
//TEXT=在你使用一张<b>传说</b>随从牌后，随机使你手牌中的一张卡牌的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_02e2:Ability{
//NAME=振奋士气
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_03:SpellBase{
//NAME=贪得无厌
//TEXT=<b>被动</b> 你的随从拥有+2/+2但法力值消耗增加（2）点<i>（最高不超过10点）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_03e1:Ability{
//NAME=贪得无厌附加效果
//TEXT=<b>被动</b> 你的随从拥有+2/+2但法力值消耗增加（2）点<i>（最高不超过10点）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_03e2:Ability{
//NAME=贪得无厌
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_03e3:Ability{
//NAME=贪得无厌
//TEXT=法力值消耗提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_04:SpellBase{
//NAME=精于驯服
//TEXT=<b>被动</b> 你的中立随从牌拥有+1/+1且法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_04e1:Ability{
//NAME=精于驯服附加效果
//TEXT=<b>被动</b> 你的中立随从牌拥有+1/+1且法力值消耗减少（1）点，但不能少于（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_04e2:Ability{
//NAME=精于驯服
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_04e3:Ability{
//NAME=精于驯服
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_06:SpellBase{
//NAME=传说级战利品
//TEXT=<b>被动</b> 在你的第一个回合，<b>发现</b>一张<b>传说</b>武器牌，其法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_06e1:Ability{
//NAME=传说级战利品附加效果
//TEXT=在你的第一个回合，<b>发现</b>一张<b>传说</b>武器牌，其法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_06e2:Ability{
//NAME=战利品
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_07:SpellBase{
//NAME=致命死亡
//TEXT=<b>被动</b> 在一个友方<b>亡语</b>随从死亡后，触发一个友方随从的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_07e1:Ability{
//NAME=致命死亡附加效果
//TEXT=在一个友方<b>亡语</b>随从死亡后，触发一个友方随从的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_08:SpellBase{
//NAME=哦，全是法术！
//TEXT=<b>被动</b> 对战开始时，摧毁你牌库中的所有随从牌。你的法术牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_08e1:Ability{
//NAME=哦，全是法术！附加效果
//TEXT=对战开始时，摧毁你牌库中的所有随从牌。你的法术牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_08e2:Ability{
//NAME=哦，全是法术！
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_09:SpellBase{
//NAME=传说金碟
//TEXT=<b>被动</b> 在你使用一张<b>传说</b>随从牌后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_09e1:Ability{
//NAME=传说金碟玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_09s2:SpellBase{
//NAME=Disks of Legend Dummy
//TEXT=Dummy Hook Up PVPDR SW Passive 09e1.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_18:SpellBase{
//NAME=活化药剂
//TEXT=<b>被动</b> 在你使用一张随从牌后，将两张它的复制洗入你的牌库，其法力值消耗为 （2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_18e1:Ability{
//NAME=活化药剂玩家附加效果
//TEXT=在你使用一张随从牌后，将两张它的复制洗入你的牌库，其法力值消耗为（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_SW_Passive_18s1:SpellBase{
//NAME=活化药剂占位
//TEXT=为施放了活化药剂的玩家保留附加效果（PVPDR SW Passive18e1）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerB2:SpellBase{
//NAME=创建一个设计师选项-栏位0-职业100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerB3:SpellBase{
//NAME=创建一个设计师选项-栏位1-职业100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerB4:SpellBase{
//NAME=创建一个设计师选项-栏位2-职业100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerB5:SpellBase{
//NAME=创建一个设计师选项-栏位1-职业50
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerB6:SpellBase{
//NAME=创建一个设计师选项-栏位2-职业50
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildDesignerBucket:SpellBase{
//NAME=创建一个设计师选项-栏位0-职业50
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildListB_2:SpellBase{
//NAME=Build a List Bucket - Slot0 - Class 100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildListB_3:SpellBase{
//NAME=Build a List Bucket - Slot1 - Class 100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_BuildListB_4:SpellBase{
//NAME=Build a List Bucket - Slot2 - Class 100
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_LoadBuckets:SpellBase{
//NAME=Load 3 Loot Buckets
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_SmartBucketTestLabe:SpellBase{
//NAME=小组学习
//TEXT=Create a loot bucket from your seed deck (Name, and 3 cards)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TEST_Will:SpellBase{
//NAME=守护者的意志
//TEXT=复原你的法力水晶。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Titans_BucketList:SpellBase{
//NAME=泰坦诸神
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_P1:HeroPowerBase{
//NAME=时光循环
//TEXT=重新开始你的回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_P2:HeroPowerBase{
//NAME=时光循环
//TEXT=重新开始你的回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_P3:HeroPowerBase{
//NAME=时光循环
//TEXT=重新开始你的回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_T1:SpellBase{
//NAME=混沌理论
//TEXT=双方玩家施放手牌中所有的法术牌<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_T2:SpellBase{
//NAME=增幅强化装置
//TEXT=随机将每个职业的一张法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_T3:SpellBase{
//NAME=午夜钟声
//TEXT=<b>回响</b> 随机消灭一个敌方随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Toki_T4:MinionBase{
//NAME=鲁莽的伙伴
//TEXT=<b>战吼：</b>与你的对手交换手牌。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=NONE
}
public class PVPDR_Toki_T5:MinionBase{
//NAME=发条助手
//TEXT=在本局对战中，你每施放一个法术，便拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=MECHANICAL
}
public class PVPDR_Toki_T6:SpellBase{
//NAME=谜之匣
//TEXT=随机将所有随从变形成为法力值消耗增加（3）点的其他 随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_TSC_Passive1:SpellBase{
//NAME=探底利器
//TEXT=<b>被动</b> 每回合中，在你第一次<b>探底</b>后，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive1e1:Ability{
//NAME=探底利器附加效果
//TEXT=<b>被动</b> 每回合中，在你第一次<b>探底</b>后，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive2:SpellBase{
//NAME=蛇盘施法
//TEXT=<b>被动</b> 每回合中，在你使用第一张纳迦牌后，随机将一张法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive2e1:Ability{
//NAME=蛇盘施法附加效果
//TEXT=每回合中，在你使用第一张纳迦牌后，随机将一张法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive3:SpellBase{
//NAME=改良磁极
//TEXT=<b>被动</b> 每回合中，在你使用第一张非<b>磁力</b>机械牌后，随机将一张法力值消耗为（1）的<b>磁力</b>机械牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive3e1:Ability{
//NAME=改良磁极附加效果
//TEXT=<b>被动</b> 每回合中，在你使用第一张非<b>磁力</b>机械牌后，随机将一张法力值消耗为（1）的<b>磁力</b>机械牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive4:SpellBase{
//NAME=召邀海盗
//TEXT=<b>被动</b> 每回合中，在你使用第一张海盗牌后，将一张海盗帕奇斯置入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive4e1:Ability{
//NAME=召邀海盗附加效果
//TEXT=每回合中，在你使用第一张海盗牌后，将一张海盗帕奇斯置入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive5:SpellBase{
//NAME=曲奇的汤勺
//TEXT=<b>被动</b> 每回合中，在你使用第一张鱼人牌后，抽一张鱼人牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive5e1:Ability{
//NAME=曲奇的汤勺附加效果
//TEXT=每回合中，在你使用第一张鱼人牌后，抽一张鱼人牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_TSC_Passive6:SpellBase{
//NAME=遗忘深渊
//TEXT=<b>被动</b> 对战开始时，将2张<b>巨型</b>随从牌置于你的牌库底。其法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_United_BucketList:SpellBase{
//NAME=暴风城下的集结
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Voyage_BucketList:SpellBase{
//NAME=探寻沉没之城
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Whispers_BucketList:SpellBase{
//NAME=上古之神的低语
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_Witchwood_BucketList:SpellBase{
//NAME=女巫森林
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_Active01:SpellBase{
//NAME=星界传送门
//TEXT=随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_YOP_Active02:SpellBase{
//NAME=法师护甲
//TEXT=获得10点护甲值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class PVPDR_YOP_DemHun:MinionBase{
//NAME=赛道驭手艾蕾萨
//TEXT=在你的英雄攻击后， 随机召唤一个恶魔伙伴，并使其攻击相同目标。
//MAJ=HUNTER|COST=3|ATK=2|HP=5|RACE=NONE
}
public class PVPDR_YOP_DemonHunterP1:HeroPowerBase{
//NAME=伊利达雷突击
//TEXT=选择一个敌方随从。召唤两个1/1并具有<b>突袭</b>的伊利达雷，攻击选中的敌方随从。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_DemonHuntert1:SpellBase{
//NAME=禁锢锁链
//TEXT=随机使三个敌方随从进入<b>休眠</b>状态2回合。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class PVPDR_YOP_DemonHuntert1e1:Ability{
//NAME=禁锢锁链
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_DemonHuntert2:WeaponBase{
//NAME=加速之刃
//TEXT=<b>战吼：</b>抽1张<b>流放</b>牌。这些<b>流放</b>牌的法力值消耗减少（1）点。<i>（效果会随着对决进度提升）</i>
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class PVPDR_YOP_DemonHuntert2e1:Ability{
//NAME=加速
//TEXT=法力值消耗减少。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_DemonHuntert2e2:Ability{
//NAME=加速
//TEXT=攻击力提高。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_DruidP1:HeroPowerBase{
//NAME=收割时间
//TEXT=消灭一个随从，为该随从的拥有者召唤两个1/1的树苗。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_DruidT1:MinionBase{
//NAME=苏醒的古树
//TEXT=<b>嘲讽</b>，<b>战吼：</b>抽1张牌，造成1点伤害，获得1点护甲值。<i>（效果会随着对决进度提升）</i>
//MAJ=DRUID|COST=8|ATK=8|HP=12|RACE=NONE
}
public class PVPDR_YOP_DruShaT1:MinionBase{
//NAME=狂野的祖卡拉
//TEXT=在你施放一个法力值消耗大于或等于（4）点的法术后，再次施放该法术<i>（目标随机而定）</i>。
//MAJ=DRUID|COST=3|ATK=3|HP=6|RACE=NONE
}
public class PVPDR_YOP_HunterP1:HeroPowerBase{
//NAME=野蛮奥秘
//TEXT=<b>被动</b> 在一个友方<b>奥秘</b>被揭示后，随机将一张法力值消耗为（2）的野兽牌置入你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_HunterT1:MinionBase{
//NAME=逐亡者
//TEXT=<b>战吼：</b>随机触发1个友方随从的<b>亡语</b>。<i>（效果会随着对决进度提升）</i>
//MAJ=HUNTER|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class PVPDR_YOP_HunterT2:WeaponBase{
//NAME=胡萝卜杆
//TEXT=在你攻击后，使你的野兽获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=1|HP=3|RACE=NONE
}
public class PVPDR_YOP_HunterT2e:Ability{
//NAME=野兽活力
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_LocPriT1:MinionBase{
//NAME=乔拉斯·寂灭
//TEXT=<b>突袭</b>。每当你的生命值在你的回合中发生变化，召唤一个本随从的 复制。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class PVPDR_YOP_MageP1:HeroPowerBase{
//NAME=寒冰碎片
//TEXT=造成$1点伤害。将一张2/1的可以<b>冻结</b>攻击目标的寒冰碎片置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_MageP1e1:Ability{
//NAME=元素碎片
//TEXT=法力值消耗减少。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_MageP1m1:MinionBase{
//NAME=寒冰碎片
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class PVPDR_YOP_MageT1:SpellBase{
//NAME=美味尤物
//TEXT=转动尤格-萨隆的命运之轮。法力值消耗减少（0）点。<i>（效果会随着对决进度提升）</i>
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_MageT1t:SpellBase{
//NAME=吞噬之饥
//TEXT=消灭所有随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_MageT3:MinionBase{
//NAME=灰烬施法者
//TEXT=<b>法术迸发：</b>将法术牌的三张复制置入你的手牌。
//MAJ=MAGE|COST=5|ATK=4|HP=5|RACE=NONE
}
public class PVPDR_YOP_PaladinP1:HeroPowerBase{
//NAME=谦逊的侍从
//TEXT=将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PaladinP1e1:Ability{
//NAME=谦逊的侍从
//TEXT=属性值变为3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PaladinT1:MinionBase{
//NAME=人气车手
//TEXT=<b>突袭</b>。<b>战吼：</b>随机对本随从施放1个祝福。<i>（效果会随着对决进度提升）</i>
//MAJ=PALADIN|COST=4|ATK=3|HP=3|RACE=NONE
}
public class PVPDR_YOP_PaladinT3:SpellBase{
//NAME=谦卑祝福
//TEXT=在本局对战的剩余时间内，将你的所有随从的攻击力，生命值和法力值消耗变为3。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class PVPDR_YOP_PaladinT3e1:Ability{
//NAME=谦卑祝福
//TEXT=你的随从的法力值消耗，攻击力和生命值均为3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PaladinT3e2:Ability{
//NAME=谦卑祝福
//TEXT=法力值消耗，攻击力和生命值变为3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PaladinT3e3:Ability{
//NAME=Humble Blessing
//TEXT=Cost, Attack, and Health are set 3.
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PriestP1:HeroPowerBase{
//NAME=疯狂召唤
//TEXT=召唤一个0/2的空灵魔。每个回合，它会从敌方英雄处偷取1点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PriestP1m1:MinionBase{
//NAME=空灵魔
//TEXT=在你的回合结束时，从敌方英雄处偷取1点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=2|RACE=NONE
}
public class PVPDR_YOP_PriestP1m1e:Ability{
//NAME=虚空饮吸
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PriestT1:SpellBase{
//NAME=暗言术：虚
//TEXT=消灭一个随从，召唤0/2的空灵魔，数量等同于该随从的生命值一半，向上取整。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class PVPDR_YOP_PriestT1e1:Ability{
//NAME=灵魂连接
//TEXT=<b>亡语：</b>移回你的手牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_PriestT2:MinionBase{
//NAME=鳞族先驱
//TEXT=<b>嘲讽</b>，<b>战吼：</b>将1张龙牌置入你的手牌。这些龙牌的法力值消耗减少（2）点。<i>（效果会随着对决进度提升）</i>
//MAJ=PRIEST|COST=4|ATK=4|HP=5|RACE=DRAGON
}
public class PVPDR_YOP_PriestT2e1:Ability{
//NAME=先驱前来
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_RogMagT1:MinionBase{
//NAME=布里茨·炎桶
//TEXT=在你使用一张法术牌后，随机召唤两个法力值消耗相同的随从。召唤的随从会在受到伤害时死亡。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class PVPDR_YOP_RogMagT1e:Ability{
//NAME=残象
//TEXT=本随从会在受到伤害时死亡。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_RogueP1:HeroPowerBase{
//NAME=邪恶混剂
//TEXT=使一个随从获得<b>剧毒</b>。<b>连击：</b>将一张毒素牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_RogueP1e:Ability{
//NAME=隐形
//TEXT=获得潜行直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_RogueT1:WeaponBase{
//NAME=翠绿始祖龟壳
//TEXT=<b>战吼：</b>随机将1个敌方随从移回其拥有者的手牌。<i>（效果会随着对决进度提升）</i>
//MAJ=ROGUE|COST=3|ATK=1|HP=3|RACE=NONE
}
public class PVPDR_YOP_ShamanP1:HeroPowerBase{
//NAME=追逐风暴
//TEXT=<b>被动</b> 你不会<b>过载</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_ShamanT1:MinionBase{
//NAME=图腾负载专家
//TEXT=<b>战吼：</b>将1张非基础图腾置入你的手牌。这些图腾牌的法力值消耗减少（2）点。<i>（效果会随着对决进度提升）</i>
//MAJ=SHAMAN|COST=4|ATK=3|HP=3|RACE=NONE
}
public class PVPDR_YOP_ShamanT1e1:Ability{
//NAME=专业减负
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_ShamanT2:SpellBase{
//NAME=混沌风暴
//TEXT=在本回合中，你使用一张<b>过载</b>牌后，将一张<b>过载</b>牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class PVPDR_YOP_ShamanT2e1:Ability{
//NAME=混沌风暴
//TEXT=在本回合中获得随机的<b>过载</b>牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_WarPalT1:MinionBase{
//NAME=先行者阿苏
//TEXT=在你召唤一个随从后，使其获得<b>圣盾</b>和<b>突袭</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=6|RACE=NONE
}
public class PVPDR_YOP_WarriorP1:HeroPowerBase{
//NAME=磁性地雷
//TEXT=<b>被动</b> 在你的回合结束时，如果你有护甲值，将一张“炸弹”洗入你对手的牌库。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_WarriorP1s1:SpellBase{
//NAME=磁性地雷
//TEXT=<b>抽到时施放</b> 你受到5点伤害。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class PVPDR_YOP_WarriorT1:MinionBase{
//NAME=废铁爆破师
//TEXT=<b>战吼：</b>获得5点护甲值。将1张“炸弹”洗入你对手的牌库。<i>（效果会随着对决进度提升）</i>
//MAJ=WARRIOR|COST=6|ATK=4|HP=5|RACE=MECHANICAL
}
