using System.Collections;
using System.Collections.Generic;

public class DALA_501:MinionBase{
//NAME=欢快的灵魂
//TEXT=每当你抽到一张法术牌，将一张它的复制置入你的牌库。
//MAJ=MAGE|COST=2|ATK=2|HP=4|RACE=NONE
}
public class DALA_502:MinionBase{
//NAME=愤怒的银行家
//TEXT=每当有一张“幸运币”被使用，便获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
}
public class DALA_502e:Ability{
//NAME=富有
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_503:MinionBase{
//NAME=肯瑞托卫兵
//TEXT=每有一个其他友方肯瑞托卫兵，便拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class DALA_504:MinionBase{
//NAME=肯瑞托元素
//TEXT=你的法术额外施放 一次。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class DALA_700:SpellBase{
//NAME=连续体对撞器
//TEXT=获得一个额外回合。此后你的对手获得一个额外回合。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_701:SpellBase{
//NAME=魔盒
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张 宝藏牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_701e:Ability{
//NAME=变形
//TEXT=随机变成一张宝藏牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_702:SpellBase{
//NAME=侏儒军刀
//TEXT=使一个随从获得<b>冲锋，风怒，圣盾，吸血，剧毒，嘲讽</b>以及<b>潜行</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DALA_702e:Ability{
//NAME=武装到牙齿！
//TEXT=获得<b>冲锋，风怒，圣盾，吸血，剧毒，嘲讽</b>以及<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_703:MinionBase{
//NAME=大块头
//TEXT=<b>战吼：</b> 随机将三张卡牌置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class DALA_704:SpellBase{
//NAME=超级猴子球
//TEXT=召唤穆克拉。使其获得<b>免疫</b>和<b>扰魔</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class DALA_705:MinionBase{
//NAME=残暴的奴隶主
//TEXT=在你的回合结束时，召唤一个本随从的 复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DALA_706:SpellBase{
//NAME=怪盗海报
//TEXT=夺取所有敌方随从的控制权。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class DALA_707:MinionBase{
//NAME=铁杆匪徒
//TEXT=<b>对战开始时：</b>抽到这张牌。<b>嘲讽</b>。如果这张牌在你的手牌中，每个回合获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DALA_707e:Ability{
//NAME=盘算阴谋
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_708:SpellBase{
//NAME=未知的宝物
//TEXT=随机将五张宝藏牌洗入你的 牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_709:MinionBase{
//NAME=金蜡烛
//TEXT=<b>嘲讽，战吼：</b>将所有其他卡牌替换成随机传说随从牌。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=7|RACE=NONE
}
public class DALA_711:SpellBase{
//NAME=梦境林地指环
//TEXT=<b>发现</b>一张<b>传说</b>随从牌。召唤五个它的复制。
//MAJ=NEUTRAL|COST=9|ATK=0|HP=0|RACE=NATURE
}
public class DALA_712:SpellBase{
//NAME=未知的宝珠
//TEXT=造成$20点伤害，分配到所有敌人身上。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=FEL
}
public class DALA_713:MinionBase{
//NAME=长者塔格瓦格
//TEXT=<b>战吼：</b>对所有敌方随从造成4点伤害。 <b>亡语：</b>将本随从洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class DALA_714:SpellBase{
//NAME=一堆……大蜡烛？
//TEXT=<b>双生法术。</b> <b>双生法术。</b><b>双生法术。</b> 对所有敌方随从造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class DALA_714a:SpellBase{
//NAME=一堆……大蜡烛？
//TEXT=<b>双生法术</b> <b>双生法术</b> 对所有敌方随从造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class DALA_714b:SpellBase{
//NAME=一堆……大蜡烛？
//TEXT=<b>双生法术</b> 对所有敌方随从造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class DALA_714c:SpellBase{
//NAME=一堆……大蜡烛？
//TEXT=对所有敌方随从造成$3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class DALA_715:SpellBase{
//NAME=势不可挡
//TEXT=在本回合中，你在使用一张卡牌后，再次使用该卡牌<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_715e:Ability{
//NAME=势不可挡
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_716:SpellBase{
//NAME=炸弹天降
//TEXT=将一张“炸炸机器人”洗入你对手的牌库。当抽到“炸炸机器人”时，便会受到50点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DALA_716t:SpellBase{
//NAME=炸炸机器人
//TEXT=<b>抽到时施放</b> 你受到50点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_717:SpellBase{
//NAME=分析案例
//TEXT=<b>发现</b>一张<b>任务</b>牌的<b>奖励</b>。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_718:MinionBase{
//NAME=永恒者艾丽斯特拉
//TEXT=<b>战吼：</b>将你在本次冒险中对本随从施放过的所有法术再次施放在本随从身上。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class DALA_719:WeaponBase{
//NAME=掠魂之镰
//TEXT=<b>亡语：</b> 召唤所有在本次冒险中被该武器消灭的随从。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=1|RACE=NONE
}
public class DALA_720:SpellBase{
//NAME=沼泽女王的召唤
//TEXT=随机将你的所有随从变形成为<b>传说</b>随从。在本回合可以重复使用。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DALA_721:SpellBase{
//NAME=变形复制仪
//TEXT=选择一个友方随从。将你的冒险模式套牌中的所有随从牌替换为该随从的复制。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_722:SpellBase{
//NAME=吵吵号角
//TEXT=用吵闹的随从填满你的面板
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class DALA_723:WeaponBase{
//NAME=超级能量枪
//TEXT=<b>剧毒</b> 你的英雄在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class DALA_723e:Ability{
//NAME=超级能量枪附加效果
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_724:SpellBase{
//NAME=大炸弹
//TEXT=消灭所有随从。在你的下个回合开始时，再次消灭所有 随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_724d:SpellBase{
//NAME=大炸弹占位特效
//TEXT=为放出大炸弹的玩家保留效果（DALA 724e）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_724e:Ability{
//NAME=施放大炸弹的玩家附加效果
//TEXT=在你的回合开始时，消灭所有随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_725:SpellBase{
//NAME=香蕉分裂
//TEXT=使一个友方随从获得+2/+2，并召唤两个它的复制。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_725e:Ability{
//NAME=青光莹莹
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_726:SpellBase{
//NAME=大师级阴谋
//TEXT=造成$1点伤害。抽1张牌。获得1点护甲。召唤1个<b>砰砰机器人</b>。<i>（每回合都会升级！）</i>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_727:SpellBase{
//NAME=散播种子
//TEXT=使你牌库中的所有随从牌获得+3/+3。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class DALA_727e:Ability{
//NAME=种子扎根
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_728:SpellBase{
//NAME=回收
//TEXT=<b>被动</b> 在一个友方随从死亡后，获得2点护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_728d:SpellBase{
//NAME=回收占位效果
//TEXT=为开启回收的玩家保留效果（DALA 728e）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_728e:Ability{
//NAME=回收玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_729:MinionBase{
//NAME=达戈维克·黏趾
//TEXT=<b>潜行</b> 在本随从攻击英雄后，从你对手的手牌中偷取一张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class DALA_730:MinionBase{
//NAME=摩加莎
//TEXT=每当你使用一张牌，使你对手的一个法力水晶<b>过载</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=6|RACE=MURLOC
}
public class DALA_731:SpellBase{
//NAME=火箭背包
//TEXT=<b>被动</b> 你的所有随从拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_731e:Ability{
//NAME=火箭背包玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_731e2:Ability{
//NAME=火箭背包
//TEXT=拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_733:SpellBase{
//NAME=翠绿护目镜
//TEXT=<b>被动</b> 使你最左边的手牌法力值消耗减少 （2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_733e:Ability{
//NAME=翠绿护目镜玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_733e2:Ability{
//NAME=翠绿护目镜
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_735:SpellBase{
//NAME=华丽的长袍
//TEXT=<b>被动</b> 你的卡牌法力值消耗减半，但你每回合只能使用两张卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_735e:Ability{
//NAME=华丽的长袍玩家附加效果
//TEXT=你的卡牌法力值消耗减半，但你每回合只能使用两张卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_735e2:Ability{
//NAME=华丽的长袍
//TEXT=法力值消耗减半。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_735e3:Ability{
//NAME=华而不实
//TEXT=在本回合中不能使用卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_736:SpellBase{
//NAME=观星
//TEXT=<b>被动</b> 你每回合可以使用两次英雄技能，且英雄技能的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_736e:Ability{
//NAME=观星玩家强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_737:SpellBase{
//NAME=有备无患
//TEXT=<b>被动</b> 对战开始时，随机装备一把武器，并使其获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_737e:Ability{
//NAME=怪盗升级
//TEXT=+1攻击力和+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_738:SpellBase{
//NAME=王子的指环
//TEXT=<b>被动</b> 将你的初始英雄技能随机替换为一个死亡骑士英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_738e:Ability{
//NAME=A Prince's Ring Enchantment
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_739:SpellBase{
//NAME=惊奇之书
//TEXT=<b>被动</b> 对战开始时，将十张惊奇卡牌洗入你的 牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740:SpellBase{
//NAME=神奇的智慧之球
//TEXT=<b>被动</b> 偶尔给一点有用的建议。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740e:Ability{
//NAME=神奇的智慧之球玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740e2:Ability{
//NAME=神奇的智慧之球寒冰屏障
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740e3:Ability{
//NAME=神奇的智慧之球额外施法
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740ts:SpellBase{
//NAME=神奇的智慧之球复制卡牌标记法术
//TEXT=有几率使你额外获得一张卡牌的二到五张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740ts2:SpellBase{
//NAME=神奇的智慧之球空手牌标记法术
//TEXT=有几率使你获得五张随机卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740ts3:SpellBase{
//NAME=神奇的智慧之球免费随从标记法术
//TEXT=有几率使你获得三个随机随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740ts4:SpellBase{
//NAME=神奇的智慧之球随机传说标记法术
//TEXT=将一个随从随机变形成为<b>传说</b>随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_740ts5:SpellBase{
//NAME=神奇的智慧之球召唤嘲讽标记法术
//TEXT=随机召唤三个<b>嘲讽</b>随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_741:SpellBase{
//NAME=托瓦格尔的骰子
//TEXT=<b>被动</b> 在你的回合结束时，随机调整你所有手牌的法力值消耗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_741e:Ability{
//NAME=托瓦格尔的骰子玩家附加效果
//TEXT=在你的回合结束时，随机调整你所有手牌的法力值消耗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_741e2:Ability{
//NAME=掷骰子
//TEXT=托瓦格尔的骰子改变了它的法力值消耗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_743:SpellBase{
//NAME=砰砰博士的遥控器
//TEXT=<b>被动</b> 对战开始时，召唤三个1/1的砰砰机器人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_743e:Ability{
//NAME=Sleepy
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_744:SpellBase{
//NAME=哈加莎的拥抱
//TEXT=<b>被动</b> 在你的回合开始时，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_744d:SpellBase{
//NAME=哈加莎的拥抱占位效果
//TEXT=为施放了哈加莎的拥抱的玩家保留附加效果（DALA744e）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_744e:Ability{
//NAME=哈加莎的拥抱玩家附加效果
//TEXT=在你的回合开始时，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_744e2:Ability{
//NAME=哈加莎的拥抱
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_745:SpellBase{
//NAME=拉法姆之手
//TEXT=<b>被动</b> 对战开始时，使你的对手获得两张“诅咒”。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_746:SpellBase{
//NAME=活化药剂
//TEXT=<b>被动</b> 在你使用一张随从牌后，将两张它的复制洗入你的牌库，其法力值消耗为 （1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_746d:SpellBase{
//NAME=活化药剂占位效果
//TEXT=为使用活化药剂的玩家保留效果（DALA746e）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_746e:Ability{
//NAME=活化药剂玩家附加效果
//TEXT=在你使用一张随从牌后，将两张它的复制洗入你的牌库，其法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_747:SpellBase{
//NAME=能量药剂
//TEXT=<b>被动</b> 你每回合额外抽两张牌。你对<b>疲劳</b>效果 <b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_747e:Ability{
//NAME=能量药剂玩家附加效果
//TEXT=每回合额外抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_748:SpellBase{
//NAME=邪恶药剂
//TEXT=<b>被动</b> 你的法术消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_748e:Ability{
//NAME=邪恶药剂玩家附加效果
//TEXT=你的法术消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_800:SpellBase{
//NAME=随机法师套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_801:SpellBase{
//NAME=随机德鲁伊套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_802:SpellBase{
//NAME=随机猎人套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_803:SpellBase{
//NAME=随机圣骑士套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_804:SpellBase{
//NAME=随机牧师套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_805:SpellBase{
//NAME=随机潜行者套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_806:SpellBase{
//NAME=随机萨满祭司套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_807:SpellBase{
//NAME=随机术士套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_808:SpellBase{
//NAME=随机战士套牌
//TEXT=用一副随机套牌开始冒险。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_829:SpellBase{
//NAME=情节：钱箱
//TEXT=对战开始时，你对手的场上有一个“现金储备箱”。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_829t:MinionBase{
//NAME=现金储备箱
//TEXT=<b>亡语：</b>使每个玩家获得两张幸运币。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class DALA_830:SpellBase{
//NAME=情节：终局
//TEXT=本次冒险中会有四个额外的强大首领。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_831:SpellBase{
//NAME=情节：恶臭
//TEXT=所有随从的攻击力和生命值 互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_831e:Ability{
//NAME=难闻恶臭玩家附加效果
//TEXT=所有随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_831e2:Ability{
//NAME=恶臭
//TEXT=攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_832:SpellBase{
//NAME=情节：囚室
//TEXT=双方玩家在对战开始时都拥有一个“紫罗兰囚室”。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_832t:MinionBase{
//NAME=紫罗兰囚室
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_833:SpellBase{
//NAME=情节：市集
//TEXT=双方玩家最多可以拥有四个 随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_833t:MinionBase{
//NAME=水果市集
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=NONE
}
public class DALA_833t2:MinionBase{
//NAME=鱼类市集
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=NONE
}
public class DALA_833t3:MinionBase{
//NAME=肉类市集
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=NONE
}
public class DALA_833t4:MinionBase{
//NAME=甜品市集
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=NONE
}
public class DALA_850:SpellBase{
//NAME=畸变：奥术之力
//TEXT=所有法术的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_850e:Ability{
//NAME=畸变——奥术之力玩家附加效果
//TEXT=所有法术的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_851:SpellBase{
//NAME=畸变：召唤之力
//TEXT=在使用一张法术牌后，召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_851e:Ability{
//NAME=畸变——召唤之力玩家附加效果
//TEXT=在使用一张法术牌后，召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_852:SpellBase{
//NAME=畸变：战吼震天
//TEXT=所有<b>战吼</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_852e:Ability{
//NAME=畸变——战吼震天玩家附加效果
//TEXT=所有<b>战吼</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_853:SpellBase{
//NAME=畸变：亡语低回
//TEXT=所有<b>亡语</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_853e:Ability{
//NAME=畸变——亡语低回玩家附加效果
//TEXT=所有<b>亡语</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_854:SpellBase{
//NAME=畸变：层层嵌套
//TEXT=在使用一张随从牌后，使其获得“<b>亡语：</b>召唤一个本随从的1/1复制。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_854e:Ability{
//NAME=畸变——层层嵌套玩家附加效果
//TEXT=在使用一张随从牌后，使其获得“<b>亡语：</b>召唤一个本随从的1/1复制。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_854e2:Ability{
//NAME=嵌套
//TEXT=获得“<b>亡语：</b>召唤一个本随从的1/1复制。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_854e3:Ability{
//NAME=破壳而出
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_855:SpellBase{
//NAME=畸变：活力充沛
//TEXT=在每个玩家的回合结束时，该玩家抽若干牌，直至其手牌数量达到5张。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_855e:Ability{
//NAME=畸变——活力充沛玩家附加效果
//TEXT=在每个玩家的回合结束时，该玩家抽若干牌，直至其手牌数量达到5张。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_856:SpellBase{
//NAME=畸变：狂野魔法
//TEXT=所有法术额外施放一次<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_856e:Ability{
//NAME=畸变——狂野魔法玩家附加效果
//TEXT=所有法术额外施放一次<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_857:SpellBase{
//NAME=畸变：炫彩夺目
//TEXT=任意玩家在使用一张法力值消耗大于或等于（8）点的卡牌后，将一张宝藏牌置入其手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_857e:Ability{
//NAME=畸变——炫彩夺目玩家附加效果
//TEXT=任意玩家在使用一张法力值消耗大于或等于（8）点的卡牌后，将一张宝藏牌置入其手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_858:SpellBase{
//NAME=畸变：群鱼环伺
//TEXT=战斗期间鱼人会不时乱入。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_858e:Ability{
//NAME=畸变——群鱼环伺玩家附加效果
//TEXT=战斗期间鱼人会不时乱入。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_859:SpellBase{
//NAME=畸变：充分备战
//TEXT=对战开始时，双方玩家额外抽两张牌，并获得两个额外的法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_860:SpellBase{
//NAME=畸变：巨龙之魂
//TEXT=任意玩家在一回合中施放三个法术后，召唤一条 5/5的龙。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_860e:Ability{
//NAME=畸变——巨龙之魂玩家附加效果
//TEXT=任意玩家在一回合中施放三个法术后，召唤一条5/5的龙。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_861:SpellBase{
//NAME=畸变：食人魔化
//TEXT=所有随从有50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_861e:Ability{
//NAME=畸变——食人魔化玩家附加效果
//TEXT=所有随从有50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_861e2:Ability{
//NAME=食人魔化
//TEXT=50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_862:SpellBase{
//NAME=畸变：法力简化
//TEXT=在每个玩家各自的回合结束时，其所有手牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_862e:Ability{
//NAME=畸变——法力简化玩家附加效果
//TEXT=在每个玩家各自的回合结束时，其所有手牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_863:SpellBase{
//NAME=畸变：幻觉重重
//TEXT=对战开始时，将十张“幻觉”分别置入双方玩家的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_864:SpellBase{
//NAME=畸变：不断生长
//TEXT=所有随从会在其拥有者的回合结束时获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_864e:Ability{
//NAME=畸变——不断生长玩家附加效果
//TEXT=所有随从会在其拥有者的回合结束时获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_864e2:Ability{
//NAME=畸变生长
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_865:SpellBase{
//NAME=畸变：炸弹附体
//TEXT=在一个随从被召唤后，使其获得“<b>亡语：</b>对所有随从造成1点伤害。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_865e:Ability{
//NAME=畸变——炸弹附体玩家附加效果
//TEXT=在一个随从被召唤后，使其获得“<b>亡语：</b>对所有随从造成1点伤害。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_865e2:Ability{
//NAME=易燃易爆
//TEXT=获得“<b>亡语：</b>对所有随从造成1点伤害。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_866:SpellBase{
//NAME=畸变：自动愈合
//TEXT=在每个玩家的回合开始时，为其英雄恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_866e:Ability{
//NAME=畸变——自动愈合玩家附加效果
//TEXT=在每个玩家的回合开始时，为其英雄恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_867:SpellBase{
//NAME=畸变：力量灌注
//TEXT=在一个随从被召唤后，随机使其获得<b>嘲讽，圣盾，突袭</b>或<b>风怒</b>中的一种。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_867e:Ability{
//NAME=畸变——力量灌注玩家附加效果
//TEXT=在一个随从被召唤后，随机使其获得<b>嘲讽，圣盾，突袭</b>或<b>风怒</b>中的一种。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_901:SpellBase{
//NAME=招揽人才
//TEXT=选择一个敌方随从，将其加入你的冒险模式套牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_902:SpellBase{
//NAME=扫地出门
//TEXT=选择一个友方随从，将其移出你的冒险模式套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_903:SpellBase{
//NAME=碰碰运气
//TEXT=随机使你冒险模式套牌中的一张卡牌的法力值消耗减为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_903e:Ability{
//NAME=好运气
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_904:SpellBase{
//NAME=上等佳肴
//TEXT=你的初始生命值提高5点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_905:SpellBase{
//NAME=得力助手
//TEXT=选择一个友方随从，它将始终出现在你的起始手牌中。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_905e:Ability{
//NAME=得力助手
//TEXT=始终出现在起始手牌中。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_906:SpellBase{
//NAME=轮番豪饮
//TEXT=将所有敌方随从加入你的冒险模式套牌。在本次冒险中他们获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_906e:Ability{
//NAME=众宾欢笑
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_907:SpellBase{
//NAME=征召老兵
//TEXT=<b>发现</b>一张<b>传说</b>随从牌，并将其加入你的冒险模式套牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_908:SpellBase{
//NAME=讲个故事
//TEXT=使一个友方随从在本次冒险中获得+2/+2。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_908e:Ability{
//NAME=宣传得当
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_909:SpellBase{
//NAME=统统滚蛋
//TEXT=将场上的所有友方随从移出你的冒险模式套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_910:SpellBase{
//NAME=倾巢出动
//TEXT=选择一个友方随从，将它的三张全新复制加入你的冒险模式套牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_911:SpellBase{
//NAME=焚烧法术
//TEXT=查看你的冒险模式套牌中的四张法术牌。选择一张移出 套牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_912:SpellBase{
//NAME=生力军
//TEXT=用新的随从填满酒馆。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_913:SpellBase{
//NAME=夸大其词
//TEXT=选择一个友方随从，使其在本次冒险中获得+4/+4，且法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_913e:Ability{
//NAME=谣传
//TEXT=+4/+4且法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_914:SpellBase{
//NAME=先发制人
//TEXT=查看你的冒险模式套牌中的四张法术牌。选择一张，其法力值消耗在本次冒险中减少（3）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_914e:Ability{
//NAME=先发制人
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Barkeye:HeroBase{
//NAME=老疤眼
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_BOSS_01h:HeroBase{
//NAME=咀嚼者
//TEXT=<i>咀嚼者在下水道中依靠吞噬小型随从维持生计。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_01p:HeroPowerBase{
//NAME=咀嚼
//TEXT=<b>吸血</b>，对一个随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_01px:HeroPowerBase{
//NAME=咀嚼
//TEXT=<b>吸血</b>，对一个随从造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_02h:HeroBase{
//NAME=埃维罗，烹饪训练师
//TEXT=<i>这位大厨的菜品特别养生。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_02p:HeroPowerBase{
//NAME=丰盛宴会
//TEXT=<b>被动</b> 在你施放一个法术后，为你的英雄恢复#3点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_02px:HeroPowerBase{
//NAME=丰盛宴会
//TEXT=<b>被动</b> 在你施放一个法术后，为你的英雄恢复#5点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_03e:Ability{
//NAME=法力消减
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_03h:HeroBase{
//NAME=伟大的阿卡扎曼扎拉克
//TEXT=<i>这不是真正的魔术，他在袖子里藏牌了。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_03p:HeroPowerBase{
//NAME=神奇魔术
//TEXT=随机将一张神奇的魔术牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_03px:HeroPowerBase{
//NAME=神奇魔术
//TEXT=随机将一张神奇的魔术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_03t:SpellBase{
//NAME=法力消减
//TEXT=使双方玩家手牌和牌库中的所有法术牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DALA_BOSS_03t2:SpellBase{
//NAME=兔子戏法
//TEXT=随机将一个随从变形成为小 动物。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DALA_BOSS_03t3:SpellBase{
//NAME=惊爆传说
//TEXT=使每个玩家各获得一个随机金色<b>传说</b>随从。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DALA_BOSS_03t3e:Ability{
//NAME=传说主角
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_03t4:SpellBase{
//NAME=惊心动魄
//TEXT=将三张惊奇卡牌洗入每个玩家的牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DALA_BOSS_04h:HeroBase{
//NAME=凯娅·托吉
//TEXT=<i>第一步：打开传送门；第二步：随从决斗；第三步：……胜利？</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_04p:HeroPowerBase{
//NAME=打开虫洞
//TEXT=从双方玩家的牌库中各召唤一个随从，并使其互相攻击。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_05h:HeroBase{
//NAME=了不起的“碎骨爪”
//TEXT=<i>他在抄袭别人的法术方面造诣惊人。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_05p:HeroPowerBase{
//NAME=法力回荡
//TEXT=随机施放一个在本局对战中施放过的法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_06dk:HeroBase{
//NAME=“天灾领主”达兹克
//TEXT=<b>战吼：</b>装备一把4/3的影之哀伤，影之哀伤同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=8|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_06h:HeroBase{
//NAME=达兹克·“地狱咆哮”
//TEXT=<i>大酋长看起来有点……不对劲。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_06p:HeroPowerBase{
//NAME=“全副武装”
//TEXT=<b>英雄技能</b> 获得$d2点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_06px:HeroPowerBase{
//NAME=“铜墙铁壁”
//TEXT=<b>英雄技能</b> 获得$d4点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_07e:Ability{
//NAME=飞向高空
//TEXT=贝尔纳拉现在<b>免疫</b>了。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_07h:HeroBase{
//NAME=飞行管理员贝尔纳拉
//TEXT=<i>无论开战还是开溜，贝尔纳拉都很在行。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_07p:HeroPowerBase{
//NAME=起飞
//TEXT=<b>被动</b> 贝尔纳拉将在受到15点伤害后起飞<i>（还剩下15点伤害）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_07p2:HeroPowerBase{
//NAME=飞向高空
//TEXT=<b>被动</b> 贝尔纳拉将在2回合内着陆<i>（还剩2回合）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_08h:HeroBase{
//NAME=苹果树
//TEXT=<i>被这棵老树砸过 的人都变得更有学问了。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_08p:HeroPowerBase{
//NAME=苹果投掷
//TEXT=对生命值最低的敌人造成$1点伤害。如果该敌人死亡，则重复此效果。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_08px:HeroPowerBase{
//NAME=苹果投掷
//TEXT=对生命值最低的敌人造成$2点伤害。如果该敌人死亡，则重复此效果。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_09h:HeroBase{
//NAME=档案员奥希
//TEXT=<i>忘记历史就意味着重蹈失败的覆辙。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_09p:HeroPowerBase{
//NAME=历史重演
//TEXT=随机召唤一个在本回合中死亡的友方随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_09px:HeroPowerBase{
//NAME=历史重演
//TEXT=随机召唤一个在本局对战中死亡的友方随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_10h:HeroBase{
//NAME=莫·恩维斯克
//TEXT=<i>老莫有钱就变坏。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_10p:HeroPowerBase{
//NAME=街头智慧
//TEXT=<b>被动</b> 每当你使用一个幸运币，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_10px:HeroPowerBase{
//NAME=街头智慧
//TEXT=<b>被动</b> 每当有玩家使用一个幸运币，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_11e:Ability{
//NAME=背后袭击
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_11ex:Ability{
//NAME=背后袭击
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_11h:HeroBase{
//NAME=诺兹·木尾
//TEXT=<i>这位狗头人海盗把背后偷袭提升成了一门艺术。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_11p:HeroPowerBase{
//NAME=背刺偷袭
//TEXT=<b>被动</b> 每当一个<b>潜行</b>的随从被召唤，使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_11px:HeroPowerBase{
//NAME=背刺偷袭
//TEXT=<b>被动</b> 每当一个<b>潜行</b>的随从被召唤，使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_12h:HeroBase{
//NAME=卡维兹·洛典
//TEXT=<i>你和这位言情作家的战斗是不会有好结果的！</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_12p:HeroPowerBase{
//NAME=禁忌之爱
//TEXT=随机消灭每个玩家的一个随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_12px:HeroPowerBase{
//NAME=禁忌之爱
//TEXT=随机消灭每个玩家的一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_13h:HeroBase{
//NAME=阿尔宾·伊斯托夫
//TEXT=<i>朋友？敌人？这头暴走的凶兽可管不了那么多。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_13p:HeroPowerBase{
//NAME=随缘刀法
//TEXT=随机对三个随从各造成$1-$3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_14h:HeroBase{
//NAME=提埃拉·布莱瑟
//TEXT=<i>千万要记得给服务员小费（或者别的什么）！</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_14p:HeroPowerBase{
//NAME=客人点单
//TEXT=召唤一个2/2的友善的服务员。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_14px:HeroPowerBase{
//NAME=客人点单
//TEXT=召唤两个2/2的友善的服务员。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_14t:MinionBase{
//NAME=“友善”的服务员
//TEXT=攻击本随从的敌人有50%几率攻击其他角色。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DALA_BOSS_15h:HeroBase{
//NAME=月之女祭司妮希
//TEXT=<i>时间总会治愈伤痕。但你要是想挂急诊，还得找妮希。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_15p:HeroPowerBase{
//NAME=艾露恩的祝福
//TEXT=<b>被动</b> 所有治疗效果翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_16e:Ability{
//NAME=等价交换标记
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_16h:HeroBase{
//NAME=炼金师温蒂
//TEXT=<i>她不断搅动牌库，试图炼出金色 卡牌。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_16p:HeroPowerBase{
//NAME=等价交换
//TEXT=随机交换每个玩家的一张手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_16px:HeroPowerBase{
//NAME=等价交换
//TEXT=随机交换每个玩家的一张手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_17h:HeroBase{
//NAME=塔拉·岩怒
//TEXT=<i>德鲁伊之道多种多样，而塔拉走遍了所有道路。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_17p:HeroPowerBase{
//NAME=两重道路
//TEXT=<b>被动</b> 你的<b>抉择</b>牌和英雄技能可以同时拥有两种效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_18h:HeroBase{
//NAME=蒂丝德拉·雷光
//TEXT=<i>铁石心肠，天纵奇才，图腾大师。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_18p:HeroPowerBase{
//NAME=召唤图腾
//TEXT=随机召唤任意图腾。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_18px:HeroPowerBase{
//NAME=召唤图腾
//TEXT=随机召唤任意图腾。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_19h:HeroBase{
//NAME=琳兹·红齿
//TEXT=<i>这位小巧的潜行者能造成巨大的 伤害。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_19p:HeroPowerBase{
//NAME=小小刺骨
//TEXT=造成1点伤害。<b>连击：</b>改为造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_19px:HeroPowerBase{
//NAME=小小刺骨
//TEXT=造成1点伤害。<b>连击：</b>改为造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_20h:HeroBase{
//NAME=瓦萨诺
//TEXT=<i>这位巨魔水灵萨满擅于操纵暗流和法力过载。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_20p:HeroPowerBase{
//NAME=风暴激荡
//TEXT=<b>被动</b> 你的<b>过载</b>法术会施放两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_20px:HeroPowerBase{
//NAME=风暴激荡
//TEXT=<b>被动</b> 你的<b>过载</b>法术会施放三次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_21h:HeroBase{
//NAME=无所不知的威尔特
//TEXT=<i>洞察所有秘密的秘密是什么？那是个秘密。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_21p:HeroPowerBase{
//NAME=预言
//TEXT=将一个随机职业的<b>奥秘</b>置入战场。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_22ex:Ability{
//NAME=禁言
//TEXT=<b>沉默</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_22h:HeroBase{
//NAME=图书专家北巢
//TEXT=<i>请保持安静。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_22p:HeroPowerBase{
//NAME=嘘
//TEXT=<b>沉默</b>所有随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_22px:HeroPowerBase{
//NAME=嘘
//TEXT=<b>被动</b> 在一个随从被召唤后，将其<b>沉默</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_23h:HeroBase{
//NAME=鲨鱼麦卡芬
//TEXT=<i>超强鲨鱼，专吃 弱者。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_23p:HeroPowerBase{
//NAME=鲨鱼撕咬
//TEXT=随机消灭一个受伤的随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_23px:HeroPowerBase{
//NAME=鲨鱼撕咬
//TEXT=随机消灭一个受伤的敌方随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_24e:Ability{
//NAME=阿尔哈的召唤玩家附加效果
//TEXT=触发额外的<b>战吼</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_24h:HeroBase{
//NAME=游侠阿尔哈
//TEXT=<i>发出浩劫般的战吼，让雌斑虎在战争中肆虐横行！</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_24p:HeroPowerBase{
//NAME=阿尔哈的怒吼
//TEXT=你的下一个<b>战吼</b>额外触发一次。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_24px:HeroPowerBase{
//NAME=阿尔哈的怒吼
//TEXT=你的下一个<b>战吼</b>额外触发一次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_25e:Ability{
//NAME=玩具模型化
//TEXT=属性值变成1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_25h:HeroBase{
//NAME=耶比托·乔巴斯
//TEXT=<i>需要自行组装。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_25p:HeroPowerBase{
//NAME=玩具组装
//TEXT=<b>被动</b> 在任意玩家抽到一张随从牌后，召唤一个它的1/1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_25px:HeroPowerBase{
//NAME=玩具组装
//TEXT=<b>被动</b> 在你抽到一张随从牌后，召唤一个它的1/1的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_25t:SpellBase{
//NAME=玩具收藏
//TEXT=随机召唤五个随从的1/1复制。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_26h:HeroBase{
//NAME=达拉然喷泉魔像
//TEXT=<i>冷冷的喷泉在脸上胡乱地拍。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_26p:HeroPowerBase{
//NAME=凝水成冰
//TEXT=<b>被动</b> <b>冻结</b>每回合第一个攻击你的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_26px:HeroPowerBase{
//NAME=凝水成冰
//TEXT=<b>被动</b> 在一个随从攻击你后，将其<b>冻结</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_27h:HeroBase{
//NAME=拉希尔·火脉
//TEXT=<i>有人说艺术是带有主观性的，而拉希尔喜欢破坏性的。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_27p:HeroPowerBase{
//NAME=旷世杰作
//TEXT=消耗你所有的法力值，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_28e:Ability{
//NAME=智慧
//TEXT=在本回合中法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_28h:HeroBase{
//NAME=苏伊奥斯
//TEXT=<i>释放法术的大师，但并不擅长瞄准。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_28p:HeroPowerBase{
//NAME=卷轴智慧
//TEXT=<b>被动</b> 法术牌在被抽到的回合法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_29h:HeroBase{
//NAME=迪格丝大妈
//TEXT=<i>她不断地在套牌中挖掘新的元素。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class DALA_BOSS_29p:HeroPowerBase{
//NAME=采矿
//TEXT=对一个友方元素造成2点伤害，找到其中的矿藏。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_30h:HeroBase{
//NAME=鼠王
//TEXT=<i>一定要有一位鼠 妖王。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_30p:HeroPowerBase{
//NAME=鼠王的故事
//TEXT=召唤一只下水道老鼠。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_30t:MinionBase{
//NAME=下水道老鼠
//TEXT=当你的英雄死亡时，最年长的下水道老鼠会替换为你的英雄。
//MAJ=NEUTRAL|COST=3|ATK=10|HP=1|RACE=BEAST
}
public class DALA_BOSS_31e:Ability{
//NAME=金光灿烂！
//TEXT=拥有+4/+4。令人赞叹！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_31ex:Ability{
//NAME=金光灿烂！
//TEXT=拥有+8/+8。极致奢华！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_31h:HeroBase{
//NAME=提莫斯·琼斯
//TEXT=<i>提莫斯从不分解金色卡牌。一次都没分过！</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_31p:HeroPowerBase{
//NAME=穿金戴银
//TEXT=将一个随从变为金色随从。如果该随从已经为金色随从，则使其获得+4/+4。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_31px:HeroPowerBase{
//NAME=穿金戴银
//TEXT=将一个随从变为金色随从。如果该随从已经为金色随从，则使其获得+8/+8。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_32e1:Ability{
//NAME=低调难识
//TEXT=拥有<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_32e2:Ability{
//NAME=大背头
//TEXT=拥有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_32e3:Ability{
//NAME=飞机头
//TEXT=+2生命值
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_32e4:Ability{
//NAME=莫西干头
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_32h:HeroBase{
//NAME=吉兹·考波克利
//TEXT=<i>一位老练的造型师。一句惹毛她的人有危险。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_32p:HeroPowerBase{
//NAME=改头换面
//TEXT=使一个友方随从随机获得一个新 发型。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_33h:HeroBase{
//NAME=黄金元素
//TEXT=<i>许愿池水底好像有点不对劲。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class DALA_BOSS_33p:HeroPowerBase{
//NAME=浑身是钱
//TEXT=<b>被动</b> 每当你受到伤害时，将一张幸运币置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_34h:HeroBase{
//NAME=旋转木马
//TEXT=<i>你的随从转圈圈……</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_34p:HeroPowerBase{
//NAME=快乐旋转
//TEXT=<b>被动</b> 在你的回合结束时，让场上所有随从快乐地转起来。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_35h:HeroBase{
//NAME=预言家佐伊
//TEXT=<i>预言已毫无作用。这位治疗师将为城市而战！</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_35p:HeroPowerBase{
//NAME=治疗之手
//TEXT=<b>被动</b> 在你的回合开始时，为所有友方随从恢复#2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_35px:HeroPowerBase{
//NAME=治疗之手
//TEXT=<b>被动</b> 在你的回合开始时，为所有友方随从恢复所有生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_36h:HeroBase{
//NAME=达姆斯
//TEXT=<i>专业倒卖珍稀宠物。多数宠物都很危险。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_36p:HeroPowerBase{
//NAME=采购“宠物”
//TEXT=制造一个自定义的特殊宠物。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_36px:HeroPowerBase{
//NAME=采购“宠物”
//TEXT=制造一个自定义的特殊宠物。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_36t:MinionBase{
//NAME=特殊宠物
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DALA_BOSS_37h:HeroBase{
//NAME=老托巴
//TEXT=<i>他拼命地寻找宝藏……不过拼的可能是你的命。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_37p:HeroPowerBase{
//NAME=寻宝传奇
//TEXT=随机将一张古代宝藏牌洗入你的 牌库。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_37px:HeroPowerBase{
//NAME=寻宝传奇
//TEXT=随机将三张古代宝藏牌洗入你的 牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_38h:HeroBase{
//NAME=提布茜·沃布鲁尼
//TEXT=<i>一起来参加她的传送门派对吧！</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_38p:HeroPowerBase{
//NAME=传送门派对
//TEXT=随机将一张传送门牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_38px:HeroPowerBase{
//NAME=传送门派对
//TEXT=随机将一张传送门牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_38t:SpellBase{
//NAME=派对传送门
//TEXT=随机召唤一个派对达人。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_39e:Ability{
//NAME=遍体圣光
//TEXT=拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_39h:HeroBase{
//NAME=辉煌的阿基
//TEXT=<i>强化手牌其实没什么辉煌的，但他硬是要叫这个名字。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_39p:HeroPowerBase{
//NAME=为了圣光！
//TEXT=使你手牌中的所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_40h:HeroBase{
//NAME=奥克萨娜·屠魔
//TEXT=<i>猎杀恶魔是她的工作，而击败你是她的兴趣。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_40p:HeroPowerBase{
//NAME=献祭光环
//TEXT=<b>被动</b> 在一个随从攻击你后，对其造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_40px:HeroPowerBase{
//NAME=献祭光环
//TEXT=<b>被动</b> 在一个随从攻击你后，对其造成3点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_41h:HeroBase{
//NAME=安根·奥坎德
//TEXT=<i>他喜欢动物，说脏话，还有对着动物说脏话。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_41p:HeroPowerBase{
//NAME=召唤伙伴
//TEXT=随机召唤一个动物伙伴。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_41px:HeroPowerBase{
//NAME=召唤伙伴
//TEXT=随机召唤两个动物伙伴。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_42h:HeroBase{
//NAME=超大型蹦蹦
//TEXT=<i>这台仿生弹跳机械已经完全不受 控制了！</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_42p:HeroPowerBase{
//NAME=弹跳洗牌
//TEXT=选择一个随从。将该随从的三张复制洗入你的牌库。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_42px:HeroPowerBase{
//NAME=弹跳洗牌
//TEXT=选择一个随从。将该随从的三张复制洗入你的牌库。抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_43h:HeroBase{
//NAME=魔导师诺罗阿
//TEXT=<i>没时间看她的介绍了。上，快上！</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_43p:HeroPowerBase{
//NAME=时空畸变
//TEXT=<b>被动</b> 你的对手只有25秒的时间来进行他们的回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_44e:Ability{
//NAME=预知
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_44ex:Ability{
//NAME=预知
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_44h:HeroBase{
//NAME=埃雷克姆
//TEXT=<i>这个鸦人可以预见未来……他看见自己正在码牌。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_44p:HeroPowerBase{
//NAME=黑暗潮涌
//TEXT=揭示你牌库中的一张随从牌，使其获得+2/+2并将其置于牌库顶。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_44px:HeroPowerBase{
//NAME=黑暗潮涌
//TEXT=揭示你牌库中的一张随从牌，使其获得+4/+4并将其置于牌库顶。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_45h:HeroBase{
//NAME=摩拉格
//TEXT=<i>“犯人54293号，马上停止一切行为，禁止眼神交流。”</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_45p:HeroPowerBase{
//NAME=受难射线
//TEXT=对敌方英雄造成1点伤害<i>（每次使用都会提升）</i>。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_45px:HeroPowerBase{
//NAME=受难射线
//TEXT=对敌方英雄造成1点伤害<i>（每次使用都会提升）</i>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_46h:HeroBase{
//NAME=艾库隆
//TEXT=<i>小小元素麻烦不断，护盾泡泡绕身旋转。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_46p:HeroPowerBase{
//NAME=泡泡护盾
//TEXT=使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_46px:HeroPowerBase{
//NAME=泡泡护盾
//TEXT=使你所有的随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_47h:HeroBase{
//NAME=拉文索尔
//TEXT=<i>“拉文索尔，你嘴里是什么？快吐出来！坏狗狗！”</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_47p:HeroPowerBase{
//NAME=喷吐岩浆
//TEXT=召唤一个0/3的熔岩。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_47px:HeroPowerBase{
//NAME=喷吐岩浆
//TEXT=召唤一个0/3的熔岩。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_47t:MinionBase{
//NAME=熔融岩石
//TEXT=在你的回合结束时，对所有角色造成1点 伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class DALA_BOSS_48e:Ability{
//NAME=虚空
//TEXT=在虚空之中。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_48h:HeroBase{
//NAME=湮灭者祖拉玛特
//TEXT=<i>因触犯肯瑞托的禁湮条例不幸入狱。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_48p:HeroPowerBase{
//NAME=逐入虚空
//TEXT=将一个随从逐入虚空。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_48t:SpellBase{
//NAME=虚空转换
//TEXT=消灭所有随从。召唤虚空中的所有随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class DALA_BOSS_49h:HeroBase{
//NAME=塞安妮苟萨
//TEXT=<i>这位混乱魔法的大师曾是玛里苟斯亲选的仆从。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_49p:HeroPowerBase{
//NAME=无法控制的能量
//TEXT=<b>被动</b> 在你施放一个法术后，对所有敌人造成$1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_49px:HeroPowerBase{
//NAME=无法控制的能量
//TEXT=<b>被动</b> 在你施放一个法术后，对所有敌人造成$2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_50h:HeroBase{
//NAME=诺萨莉
//TEXT=<i>每当时间旅行失败时，青铜龙总会气得当场吐沙。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_50p:HeroPowerBase{
//NAME=沙尘吐息
//TEXT=随机对一个敌人造成$2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_50px:HeroPowerBase{
//NAME=沙尘吐息
//TEXT=随机对一个敌人造成$4点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_51h:HeroBase{
//NAME=米尔菲丝·法力风暴
//TEXT=<i>米尔豪斯的恐怖爱侣。这对夫妻之间有笔账要算。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_51p:HeroPowerBase{
//NAME=修补匠
//TEXT=召唤一个0/4的松鼠炸弹。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_51t:MinionBase{
//NAME=源质松鼠炸弹
//TEXT=在你的回合开始时，消灭本随从，并对所有敌人造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=MECHANICAL
}
public class DALA_BOSS_51t2:MinionBase{
//NAME=瑟银小鸡
//TEXT=在你的对手使用一张卡牌后，对你的对手造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=MECHANICAL
}
public class DALA_BOSS_52e:Ability{
//NAME=坚持住
//TEXT=+2生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_52ex:Ability{
//NAME=坚持住
//TEXT=+4生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_52h:HeroBase{
//NAME=辛克莱尔中尉
//TEXT=<i>她早就说过，监狱需要加强守卫。她早就说过的！</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_52p:HeroPowerBase{
//NAME=守住大门
//TEXT=使一个随从获得+2生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_52px:HeroPowerBase{
//NAME=守住大门
//TEXT=使一个随从获得+4生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_53e:Ability{
//NAME=舞过生死
//TEXT=获得“<b>亡语：</b>再次召唤本随从。”
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_53h:HeroBase{
//NAME=舞者达瑞尔
//TEXT=<i>开始永无止境的布吉乌吉舞蹈！</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_53p:HeroPowerBase{
//NAME=布吉舞步
//TEXT=使一个友方随从获得“<b>亡语：</b>再次召唤本随从。”
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_53px:HeroPowerBase{
//NAME=布吉舞步
//TEXT=使一个友方随从获得“<b>亡语：</b>再次召唤本随从。”
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_54h:HeroBase{
//NAME=锁匠吉布
//TEXT=<i>达拉然的法师们倚仗吉布的技巧来锁住他们的法术。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_54p:HeroPowerBase{
//NAME=法术锁定
//TEXT=<b>被动</b> 所有法术牌会造成与法力值消耗相同的<b>过载</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_55h:HeroBase{
//NAME=哈尼根队长
//TEXT=<i>卫兵！卫兵！！</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_55p:HeroPowerBase{
//NAME=敲响警报
//TEXT=召唤一个1/4的肯瑞托卫兵。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_55px:HeroPowerBase{
//NAME=敲响警报
//TEXT=召唤一个1/4的肯瑞托卫兵。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_56e:Ability{
//NAME=受贿
//TEXT=<b>亡语：</b>回到你对手的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_56h:HeroBase{
//NAME=瓦托格尔女王
//TEXT=<i>狗头人女王也在抢银行。她还要抢你的随从。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_56p:HeroPowerBase{
//NAME=贿赂
//TEXT=从你对手的牌库中召唤一个随从。当该随从死亡时，将其送还。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_56t:MinionBase{
//NAME=投敌叛徒
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class DALA_BOSS_57e:Ability{
//NAME=Tracking Coin Played Enchantment
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_57h:HeroBase{
//NAME=贸易亲王加里维克斯
//TEXT=<i>贸易亲王操纵着市场……来对付你</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_57p:HeroPowerBase{
//NAME=贪心无罪
//TEXT=<b>被动</b> 用一个幸运币购买一张你对手每回合使用的第一张卡牌的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_58e:Ability{
//NAME=爆破炸药
//TEXT=如果本随从受到伤害，则会被消灭。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_58e2:Ability{
//NAME=Wire Watcher Player Enchantment
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_58h:HeroBase{
//NAME=爆破大师弗拉克
//TEXT=<i>作为前砰砰实习生，弗拉克对随从们有一点爆炸情结。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_58p:HeroPowerBase{
//NAME=爆破炸药
//TEXT=为一个随从绑上爆破炸药。当它受到伤害时，消灭该随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_58t:MinionBase{
//NAME=导线
//TEXT=当导线连通时，在你的回合开始时受到5点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DALA_BOSS_58t2:MinionBase{
//NAME=另一根导线
//TEXT=当导线连通时，在你的回合开始时受到5点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DALA_BOSS_59e:Ability{
//NAME=赎票
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_59h:HeroBase{
//NAME=郭雅夫人
//TEXT=<i>“勒索”多难听，郭雅夫人收的是“保 护费”。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_59p:HeroPowerBase{
//NAME=勒索
//TEXT=用一张“勒索信”随机替换你对手的一张手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_59px:HeroPowerBase{
//NAME=勒索
//TEXT=用一张“勒索信”随机替换你对手的一张手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_59t:MinionBase{
//NAME=玉莲帮打手
//TEXT=每当有一张“勒索信”被使用时，便获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class DALA_BOSS_59t2:MinionBase{
//NAME=水果刀客
//TEXT=<b>战吼：</b>对一个敌人造成4点伤害。<b>连击：</b>并对所有其他敌人造成1点伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class DALA_BOSS_59t3:SpellBase{
//NAME=勒索信
//TEXT=将你的“{0}”移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_60h:HeroBase{
//NAME=大法师卡德加
//TEXT=<i>天真直率。率众御敌。敌莫能挡。挡……挡着路就不让你过去。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_60p:HeroPowerBase{
//NAME=召唤元素
//TEXT=召唤一个2/3的元素。它会复制你的 法术。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_60px:HeroPowerBase{
//NAME=召唤元素
//TEXT=召唤一个2/3的元素。它会复制你的法术。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_61h:HeroBase{
//NAME=赛尔奥隆
//TEXT=<i>像蜘蛛一样捕食猎物，像恶魔一样玩弄对手。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_61p:HeroPowerBase{
//NAME=蛛网抓捕
//TEXT=你的对手从手牌中召唤一个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_61t:MinionBase{
//NAME=相位蜘蛛
//TEXT=<b>免疫</b> 当它的对面有随从时<b>无法攻击</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DALA_BOSS_62e:Ability{
//NAME=暗淡
//TEXT=直到下个回合，获得-2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_62ex:Ability{
//NAME=暗淡
//TEXT=-1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_62h:HeroBase{
//NAME=哈洛·夕阳
//TEXT=<i>他已有一只蹄子踏入了暗影，并且因此获得了削弱敌人的能力。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_62p:HeroPowerBase{
//NAME=变暗
//TEXT=直到你的下个回合，使所有随从获得-2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_62px:HeroPowerBase{
//NAME=变暗
//TEXT=<b>被动</b> 你对手的随从拥有-1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_63h:HeroBase{
//NAME=达戈·残暴之力
//TEXT=<i>欺凌弱小绝非君子所为。但达戈又不是君子。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_63p:HeroPowerBase{
//NAME=欺凌弱小
//TEXT=对一个受伤的随从造成$2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_63px:HeroPowerBase{
//NAME=欺凌弱小
//TEXT=对一个受伤的随从造成$4点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_64e:Ability{
//NAME=投资收益
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_64h:HeroBase{
//NAME=银行家比格斯
//TEXT=<i>能产生复利的随从？有趣。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_64p:HeroPowerBase{
//NAME=投资
//TEXT=将一个友方随从移回你的手牌，使其获得+4/+4。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_64px:HeroPowerBase{
//NAME=投资
//TEXT=将一个友方随从移回你的手牌，使其获得+4/+4并复制该随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_65h:HeroBase{
//NAME=高等精灵瓦德拉
//TEXT=<i>他的笑容亲切可人，但他这身护甲极具威胁。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_65p:HeroPowerBase{
//NAME=坚不可摧
//TEXT=<b>被动</b> 你的英雄每次最多受到3点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_66h:HeroBase{
//NAME=玛蕾·卢姆
//TEXT=<i>她不会帮你理财，只会利用你的 财富。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=10|RACE=NONE
}
public class DALA_BOSS_66p:HeroPowerBase{
//NAME=下一位……
//TEXT=将每个玩家最左边的手牌与其各自牌库中的一张牌互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_67h:HeroBase{
//NAME=大法师瓦格斯
//TEXT=<i>瓦格斯受困外域多年，终于发现了新的魔力之源。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_67p:HeroPowerBase{
//NAME=奥术符文
//TEXT=随机将一张奥术法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_68h:HeroBase{
//NAME=里拉耶尔·炎泣
//TEXT=<i>她将宇宙的不稳定性巧妙地利用了 起来。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_68p:HeroPowerBase{
//NAME=迷你传送门
//TEXT=<b>被动</b> 在你施放一个法术后，随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_68px:HeroPowerBase{
//NAME=超级传送门
//TEXT=<b>被动</b> 在你施放一个法术后，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_69h:HeroBase{
//NAME=大法师卡雷
//TEXT=<i>他成为下一个玛里苟斯只是时间 问题。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_69p:HeroPowerBase{
//NAME=巨龙之怒
//TEXT=使你的英雄获得<b>法术伤害+1</b><i>（已增加0点）</i>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_69px:HeroPowerBase{
//NAME=巨龙之怒
//TEXT=使你的英雄获得<b>法术伤害+1</b><i>（已增加0点）</i>。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_70e:Ability{
//NAME=Bombardment Recharge Player Enchantment
//TEXT=装弹期间不能使用英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_70h:HeroBase{
//NAME=天空上尉施密格
//TEXT=<i>比他的胡须更广阔的，是他的侧舷。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_70p:HeroPowerBase{
//NAME=狂轰滥炸
//TEXT=对所有随从造成$2点伤害。需要两回合重新装弹。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_70px:HeroPowerBase{
//NAME=狂轰滥炸
//TEXT=对所有敌方随从造成$3点伤害。需要两回合重新装弹。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_71h:HeroBase{
//NAME=阿娜莉·暮林
//TEXT=<i>这位德鲁伊为树木代言。显然，树木没什么好脾气。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_71p:HeroPowerBase{
//NAME=召唤护卫
//TEXT=召唤一个2/2并具有<b>嘲讽</b>的树人。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_71px:HeroPowerBase{
//NAME=召唤护卫
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_72h:HeroBase{
//NAME=卡扎蒙·铁皮
//TEXT=<i>他不是鲁莽，他是十分鲁莽。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_72p:HeroPowerBase{
//NAME=铁皮
//TEXT=<b>被动</b> 你无法伤害自己。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_73e:Ability{
//NAME=大地母亲之怨
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_73ex:Ability{
//NAME=大地母亲之怨
//TEXT=<b>超级风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_73h:HeroBase{
//NAME=赫苏图·岩风
//TEXT=<i>这个萨满祭司总能让他的随从疯怒 不止。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_73p:HeroPowerBase{
//NAME=大地母亲之怒
//TEXT=使一个友方随从获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_73px:HeroPowerBase{
//NAME=大地母亲之怒
//TEXT=使一个友方随从获得<b>超级风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_74h:HeroBase{
//NAME=卡拉·斯坦普
//TEXT=<i>她可以为了获得更多随从而出卖灵魂。当然了，不是她自己的灵魂。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_74p:HeroPowerBase{
//NAME=灵魂编织
//TEXT=弃一张牌。随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_74px:HeroPowerBase{
//NAME=灵魂编织
//TEXT=弃一张牌。随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75e1:Ability{
//NAME=Bear Liver Quest
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75e2:Ability{
//NAME=Murloc Quest
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75e3:Ability{
//NAME=Turtle Escort Quest
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75e4:Ability{
//NAME=Herbalist Quest
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75e5:Ability{
//NAME=Hogger Quest
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_75h:HeroBase{
//NAME=指挥官博兰
//TEXT=<i>当心，他头顶有个巨大的感叹号。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DALA_BOSS_75p:HeroPowerBase{
//NAME=新任务
//TEXT=给你的对手一个任务。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_BOSS_98h:HeroBase{
//NAME=调酒机器人
//TEXT=<i>来酒馆坐坐吧，这里的每个人都了解你的套牌。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class DALA_BOSS_99h:HeroBase{
//NAME=调酒师鲍勃
//TEXT=<i>来酒馆坐坐吧，这里的每个人都了解你的套牌。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class DALA_Chu:HeroBase{
//NAME=楚先生
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Druid_01:SpellBase{
//NAME=一拥而上
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_02:SpellBase{
//NAME=自然愈合
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_03:SpellBase{
//NAME=抉择不断
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_04:SpellBase{
//NAME=枝繁叶茂
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_05:SpellBase{
//NAME=自然之怒
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_06:SpellBase{
//NAME=野性撕咬
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_07:SpellBase{
//NAME=自然生长
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_08:SpellBase{
//NAME=愤怒咆哮
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_09:SpellBase{
//NAME=坚实护卫
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_10:SpellBase{
//NAME=强化兽群
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_11:SpellBase{
//NAME=巨型伙伴
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_HP1:HeroPowerBase{
//NAME=生命绽放
//TEXT=为一个随从恢复所有生命值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_HP2:HeroPowerBase{
//NAME=树木之触
//TEXT=使一个随从获得+1/+1。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_HP2e:Ability{
//NAME=树皮
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Druid_HPe:Ability{
//NAME=Druid Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Eudora:HeroBase{
//NAME=尤朵拉船长
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_George:HeroBase{
//NAME=堕落的乔治
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Hunter_01:SpellBase{
//NAME=狩猎法术
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_02:SpellBase{
//NAME=隐秘行动
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_03:SpellBase{
//NAME=亡语不断
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_04:SpellBase{
//NAME=科技力量
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_05:SpellBase{
//NAME=森然巨兽
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_06:SpellBase{
//NAME=小小危机
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_07:SpellBase{
//NAME=力量强化
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_08:SpellBase{
//NAME=侵略如火
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_09:SpellBase{
//NAME=数量压制
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_10:SpellBase{
//NAME=专业猎手
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_11:SpellBase{
//NAME=战吼震天
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_HP1:HeroPowerBase{
//NAME=待时而动
//TEXT=在本回合中，使一个随从获得+2攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_HP1e:Ability{
//NAME=待时而动
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_HP2:HeroPowerBase{
//NAME=宠物训练
//TEXT=将一张1/1的变色龙置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_HP2e:Ability{
//NAME=变换色彩
//TEXT=随机变成一张法力值消耗为（1）的随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Hunter_HP2t:MinionBase{
//NAME=变色龙
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张法力值消耗为（1）的随从牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DALA_Hunter_HPe:Ability{
//NAME=Hunter Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Kriziki:HeroBase{
//NAME=克里兹奇
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Mage_01:SpellBase{
//NAME=多重施法
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_02:SpellBase{
//NAME=寒气凝结
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_03:SpellBase{
//NAME=召唤之力
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_04:SpellBase{
//NAME=充能完毕
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_05:SpellBase{
//NAME=能量爆棚
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_06:SpellBase{
//NAME=燃尽一切
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_07:SpellBase{
//NAME=元素之力
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_08:SpellBase{
//NAME=科技力量
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_09:SpellBase{
//NAME=命运之手
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_10:SpellBase{
//NAME=不传之秘
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_11:SpellBase{
//NAME=激励士气
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_HP1:HeroPowerBase{
//NAME=火焰智慧
//TEXT=随机使你的一张手牌法力值消耗减少（2）点。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_HP1e:Ability{
//NAME=机敏
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_HP2:HeroPowerBase{
//NAME=冰霜灼烧
//TEXT=<b>冻结</b>一个角色。如果该角色已被<b>冻结</b>，则对其造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Mage_HPe:Ability{
//NAME=Mage Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_01:SpellBase{
//NAME=神秘私语
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_02:SpellBase{
//NAME=小小军团
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_03:SpellBase{
//NAME=巨龙之力
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_04:SpellBase{
//NAME=圣能灌注
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_05:SpellBase{
//NAME=治疗之手
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_06:SpellBase{
//NAME=强化手牌
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_07:SpellBase{
//NAME=鱼人大军
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_08:SpellBase{
//NAME=智能机械
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_09:SpellBase{
//NAME=白银之手
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_10:SpellBase{
//NAME=坚实护卫
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_11:SpellBase{
//NAME=审判降临
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_HP1:HeroPowerBase{
//NAME=后备力量
//TEXT=将三张1/1的“白银之手新兵”置入你的手牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_HP2:HeroPowerBase{
//NAME=圣光恩泽
//TEXT=使一个友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Paladin_HPe:Ability{
//NAME=Paladin Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_01:SpellBase{
//NAME=神奇药剂
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_02:SpellBase{
//NAME=死后余生
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_03:SpellBase{
//NAME=墓中归来
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_04:SpellBase{
//NAME=暗影重重
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_05:SpellBase{
//NAME=侵占思维
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_06:SpellBase{
//NAME=上古之神
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_07:SpellBase{
//NAME=放大世界
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_08:SpellBase{
//NAME=巨龙之火
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_09:SpellBase{
//NAME=恣意扭曲
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_10:SpellBase{
//NAME=内心潜能
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_11:SpellBase{
//NAME=再现奇迹
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_HP1:HeroPowerBase{
//NAME=扭曲
//TEXT=使一个随从的攻击力和生命值互换。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_HP1e:Ability{
//NAME=扭曲变形
//TEXT=攻击力和生命值被扭曲互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_HP2:HeroPowerBase{
//NAME=安抚
//TEXT=直到你的下个回合，使一个随从获得-2攻击力。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_HP2e:Ability{
//NAME=受到安抚
//TEXT=直到你的下个回合，获得-2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Priest_HPe:Ability{
//NAME=Priest Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rakanishu:HeroBase{
//NAME=拉卡尼休
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Rogue_01:SpellBase{
//NAME=致命连击
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_02:SpellBase{
//NAME=窃贼之道
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_03:SpellBase{
//NAME=诡计多端
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_04:SpellBase{
//NAME=弑君狂徒
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_05:SpellBase{
//NAME=亡语不断
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_06:SpellBase{
//NAME=齿轮机械
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_07:SpellBase{
//NAME=侠盗怪客
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_08:SpellBase{
//NAME=见血封喉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_09:SpellBase{
//NAME=抽牌不停
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_10:SpellBase{
//NAME=战吼震天
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_11:SpellBase{
//NAME=嗜法如命
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_HP1:HeroPowerBase{
//NAME=妙手空空
//TEXT=随机将一张<i>（另一职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_HP2:HeroPowerBase{
//NAME=挥砍
//TEXT=对一个未受伤的随从造成$2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Rogue_HPe:Ability{
//NAME=Rogue Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_01:SpellBase{
//NAME=洪流滚滚
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_02:SpellBase{
//NAME=灵魂之力
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_03:SpellBase{
//NAME=鱼人成群
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_04:SpellBase{
//NAME=能量过载
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_05:SpellBase{
//NAME=高阶萨满
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_06:SpellBase{
//NAME=元素之怒
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_07:SpellBase{
//NAME=战吼嘶鸣
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_08:SpellBase{
//NAME=蛇人秘法
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_09:SpellBase{
//NAME=雕琢符文
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_10:SpellBase{
//NAME=自我恢复
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_11:SpellBase{
//NAME=异鳞突起
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_12:SpellBase{
//NAME=传说之力
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_HP1:HeroPowerBase{
//NAME=异变
//TEXT=将一个友方随从变形成为一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_HP2:HeroPowerBase{
//NAME=重整
//TEXT=抽一张牌。<b>过载：</b>（1）。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DALA_Shaman_HPe:Ability{
//NAME=Shaman Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Squeamlish:HeroBase{
//NAME=斯奎丽什
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Tekahn:HeroBase{
//NAME=塔卡恒
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Vessina:HeroBase{
//NAME=维西纳
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=15|RACE=NONE
}
public class DALA_Warlock_01:SpellBase{
//NAME=强壮即威猛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_02:SpellBase{
//NAME=数量即优势
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_03:SpellBase{
//NAME=抽牌即真理
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_04:SpellBase{
//NAME=牺牲即胜利
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_05:SpellBase{
//NAME=痛苦即信仰
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_06:SpellBase{
//NAME=放弃即索取
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_07:SpellBase{
//NAME=控场即一切
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_08:SpellBase{
//NAME=毁灭即新生
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_09:SpellBase{
//NAME=小巧即灵活
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_10:SpellBase{
//NAME=强化即致胜
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_11:SpellBase{
//NAME=药剂即力量
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_12:SpellBase{
//NAME=入手即传说
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_HP1:HeroPowerBase{
//NAME=痛苦分裂
//TEXT=受到$2点伤害。造成$2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_HP2:HeroPowerBase{
//NAME=契约
//TEXT=受到$2点伤害。召唤一个2/2的小鬼。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warlock_HP2t:MinionBase{
//NAME=邪恶小鬼
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class DALA_Warlock_HPe:Ability{
//NAME=Warlock Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_01:SpellBase{
//NAME=佣兵
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_02:SpellBase{
//NAME=创伤
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_03:SpellBase{
//NAME=巨头
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_04:SpellBase{
//NAME=投弹
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_05:SpellBase{
//NAME=突袭
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_06:SpellBase{
//NAME=钢铁
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_07:SpellBase{
//NAME=巨龙
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_08:SpellBase{
//NAME=护甲
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_09:SpellBase{
//NAME=武装
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_10:SpellBase{
//NAME=威猛
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_11:SpellBase{
//NAME=嘲讽
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_12:SpellBase{
//NAME=传说
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_HP1:HeroPowerBase{
//NAME=提神酒
//TEXT=对一个随从造成$1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_HP1e:Ability{
//NAME=精力充沛
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_HP2:HeroPowerBase{
//NAME=暗中爆破
//TEXT=将两张“炸药” 牌洗入你对手的牌库。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_HP2t:SpellBase{
//NAME=简易炸药
//TEXT=<b>抽到时施放</b> 受到3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DALA_Warrior_HPe:Ability{
//NAME=Warrior Hero Power Watcher
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Rogue_02:SpellBase{
//NAME=窃贼之道
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_02:SpellBase{
//NAME=数量即优势
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_03:SpellBase{
//NAME=抽牌即真理
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_07:SpellBase{
//NAME=控场即一切
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_09:SpellBase{
//NAME=小巧即灵活
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_10:SpellBase{
//NAME=强化即致胜
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EVILBRM_DALA_Warlock_11:SpellBase{
//NAME=药剂即力量
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_DALA_Minion1e:Ability{
//NAME=为达拉然献身
//TEXT=达拉然会授予这张卡牌生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_DALA_Minion3e:Ability{
//NAME=为了达拉然
//TEXT=达拉然会授予这张卡牌攻击力和生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_EVILBRM_DALA_Priest_09:SpellBase{
//NAME=恣意扭曲
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_SPT_DALA_Boss0:HeroBase{
//NAME=达拉然城
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TB_SPT_DALA_Boss1:HeroBase{
//NAME=装饰过的达拉然
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TB_SPT_DALA_Boss2:HeroBase{
//NAME=节庆中的达拉然
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TB_SPT_DALA_BossHeroPower:HeroPowerBase{
//NAME=达拉然防御者
//TEXT=随机召唤一名达拉然防御者。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TB_SPT_DALA_GiftEnch:Ability{
//NAME=EVIL Gift Enchant - Not Player Facing
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_SPT_DALA_GiftSpell:SpellBase{
//NAME=Gift Delivery Spell - Not Player Facing
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TB_SPT_DALA_Minion1:MinionBase{
//NAME=节庆交际客
//TEXT=<b>嘲讽，战吼：</b>获得生命值，数值相当于达拉然的攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=1|RACE=NONE
}
public class TB_SPT_DALA_Minion3:MinionBase{
//NAME=乖戾交际客
//TEXT=<b>战吼：</b>获得攻击力和生命值，数值相当于达拉然的攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class TB_TempleOutrun_DALA_719:WeaponBase{
//NAME=掠魂之镰
//TEXT=<b>亡语：</b> 召唤所有在本次冒险中被该武器消灭的随从。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=2|RACE=NONE
}
