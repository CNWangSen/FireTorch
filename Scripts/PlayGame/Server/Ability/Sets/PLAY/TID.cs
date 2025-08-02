using System.Collections;
using System.Collections.Generic;

public class TID_000:MinionBase{
//NAME=潮汐之灵
//TEXT=在你的回合结束时，如果你有未使用的法力水晶，获得+1/+2。
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class TID_000e:Ability{
//NAME=大海无尽
//TEXT=+1/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_001:SpellBase{
//NAME=月光射线
//TEXT=对一个敌人造成$1点伤害两次。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=ARCANE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
	}
}
public class TID_002:MinionBase{
//NAME=自然使徒
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过自然法术，使你的其他随从获得+1/+1。
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=NAGA
}
public class TID_002e:Ability{
//NAME=自然的慷慨
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_003:MinionBase{
//NAME=迷潮挖掘者
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是鱼人牌，召唤一个它的2/2的复制。
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=MURLOC
}
public class TID_003e2:Ability{
//NAME=挖出
//TEXT=2/2。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_004:MinionBase{
//NAME=小丑鱼
//TEXT=<b>战吼：</b>你的下两张鱼人牌的法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=MURLOC
}
public class TID_004e:Ability{
//NAME=小丑鱼车
//TEXT=你的下两张鱼人牌的法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_004e2:Ability{
//NAME=小丑出没
//TEXT=法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_005:SpellBase{
//NAME=耐普图隆的指令
//TEXT=召唤两个5/4并具有<b>突袭</b>的元素。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class TID_005t:MinionBase{
//NAME=水流亡魂
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=4|ATK=5|HP=4|RACE=ELEMENTAL
}
public class TID_074:MinionBase{
//NAME=上古海怪杀手
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，造成5点伤害。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=NAGA
}
public class TID_075:SpellBase{
//NAME=螺壳射击
//TEXT=随机对一个敌方随从造成$3点伤害。重复此效果，每次伤害减少1点。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class TID_077:MinionBase{
//NAME=光鳐
//TEXT=<b>嘲讽</b> 在本局对战中，你每使用过一张圣骑士牌，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=9|ATK=5|HP=5|RACE=ELEMENTAL
}
public class TID_078:MinionBase{
//NAME=碎冰蹒跚者
//TEXT=<b>战吼：</b>你使用的下一个<b>亡语</b>随从会立即死亡。
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=ELEMENTAL
}
public class TID_078e:Ability{
//NAME=举步维艰
//TEXT=你的下一个<b>亡语</b>随从会立即死亡。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_078e2:Ability{
//NAME=蹒跚
//TEXT=法力值消耗减少（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_080:MinionBase{
//NAME=墨晕伏击者
//TEXT=<b>潜行</b>。攻击时拥有+3攻击力和<b>免疫</b>。
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NAGA
}
public class TID_080e2:Ability{
//NAME=染墨
//TEXT=在攻击时+3攻击力和<b>免疫</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_085:MinionBase{
//NAME=圣光使徒
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过神圣法术，为所有友方角色恢复#6点生命值。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NAGA
}
public class TID_098:MinionBase{
//NAME=纳迦侍从
//TEXT=在你对本随从施放一个法术后，抽一张牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NAGA
}
public class TID_099:MinionBase{
//NAME=K9-0型机械狗
//TEXT=<b>战吼：</b> <b>探底</b>。如果选中的是法力值消耗为（1）的随从牌，则召唤它。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class TID_700:MinionBase{
//NAME=缴械元素
//TEXT=<b>战吼：</b> 为你的对手<b>探底</b>。将选中的牌法力值消耗变为（6）点。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class TID_700e:Ability{
//NAME=缴械
//TEXT=法力值消耗为（6）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_703:SpellBase{
//NAME=损毁神像
//TEXT=<b>探底</b>。揭示选中的牌，对所有随从造成等同于其法力值消耗的伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TID_704:MinionBase{
//NAME=化石狂热者
//TEXT=在你的英雄攻击后，抽一张邪能法术牌。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class TID_706:MinionBase{
//NAME=混乱使徒
//TEXT=<b>吸血</b>，<b>战吼：</b> 如果你在此牌在你手中时施放过邪能法术，获得<b>突袭</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=4|RACE=NAGA
}
public class TID_706e:Ability{
//NAME=邪能灌注
//TEXT=拥有<b>突袭</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_707:MinionBase{
//NAME=淹没的陨石
//TEXT=<b>亡语：</b>将两张法师奥术法术牌置入你的手牌。这些牌为<b>临时</b>牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class TID_707e:Ability{
//NAME=淹没水中
//TEXT=在你的回合结束时弃掉。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_708:SpellBase{
//NAME=变形术：水母
//TEXT=将一个随从变形成为一只4/1并具有<b>法术伤害+2</b>的水母。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class TID_708t:MinionBase{
//NAME=水母
//TEXT=<b>法术伤害+2</b>
//MAJ=MAGE|COST=3|ATK=4|HP=1|RACE=BEAST
}
public class TID_709:MinionBase{
//NAME=纳兹夏尔女士
//TEXT=此牌在你的手牌中时，会在你施放火焰，冰霜或奥术法术后 变形。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class TID_709e:Ability{
//NAME=纳兹夏尔的赠礼
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_709t:MinionBase{
//NAME=纳兹夏尔女士
//TEXT=<b>战吼：</b>使你手牌中所有法术牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class TID_709t2:MinionBase{
//NAME=纳兹夏尔女士
//TEXT=<b>战吼：</b> 对一个敌方随从造成5点伤害，并对相邻随从造成2点伤害。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class TID_709t3:MinionBase{
//NAME=纳兹夏尔女士
//TEXT=<b>战吼：</b> 获得8点护甲值。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class TID_710:MinionBase{
//NAME=毒鳍龙
//TEXT=<b>战吼：</b>使你牌库中的所有<b>战吼</b>随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class TID_710e:Ability{
//NAME=锋锐如刀
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_711:MinionBase{
//NAME=厄祖玛特
//TEXT=<b>巨型+6</b> <b>亡语：</b>每有一条厄祖玛特的触须，随机消灭一个敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=5|RACE=BEAST
}
public class TID_711t:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_711t2:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_711t3:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_711t4:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_711t5:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_711t6:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TID_712:MinionBase{
//NAME=猎潮者耐普图隆
//TEXT=<b>巨型+2</b> <b>突袭</b>，<b>风怒</b>，每当耐普图隆攻击时，如果你控制着任意耐普图隆之手，改为由手攻击。
//MAJ=NEUTRAL|COST=10|ATK=7|HP=7|RACE=ELEMENTAL
}
public class TID_712t:MinionBase{
//NAME=耐普图隆之手
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=ELEMENTAL
}
public class TID_712t2:MinionBase{
//NAME=耐普图隆之手
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=ELEMENTAL
}
public class TID_713:MinionBase{
//NAME=泡泡元素
//TEXT=在本随从受到刚好一点伤害后，消灭本随从。<i>（啪！）</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=ELEMENTAL
}
public class TID_714:MinionBase{
//NAME=火成熔岩吞食者
//TEXT=<b>嘲讽</b>，<b>战吼：</b><b>探底</b>。获得等同于选中的牌的法力值消耗的护甲值。
//MAJ=WARRIOR|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class TID_714e:Ability{
//NAME=啃噬
//TEXT=攻击力提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_715:SpellBase{
//NAME=巨型剧斗
//TEXT=随机将一张<b>巨型</b>随从牌置入双方玩家的手牌。你的那张法力值消耗减少（2）点。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TID_715e:Ability{
//NAME=巨大优势
//TEXT=法力值消耗减少（2）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_716:MinionBase{
//NAME=潮汐亡魂
//TEXT=<b>战吼：</b>造成5点伤害。获得8点护甲值。
//MAJ=WARRIOR|COST=8|ATK=5|HP=8|RACE=ELEMENTAL
}
public class TID_717:MinionBase{
//NAME=暗影使徒
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过暗影法术，从一个随从处偷取2点生命值。
//MAJ=WARLOCK|COST=3|ATK=4|HP=2|RACE=NAGA
}
public class TID_717e:Ability{
//NAME=遭受虹吸
//TEXT=生命值降低。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_717e2:Ability{
//NAME=暗影虹吸
//TEXT=生命值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_717e2b:Ability{
//NAME=Siphoned
//TEXT=Increased Health.
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_717eb:Ability{
//NAME=Siphoned
//TEXT=Reduced Health.
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_718:SpellBase{
//NAME=献祭
//TEXT=点燃你对手的所有手牌。3回合后，摧毁所有仍在手中的牌。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class TID_718e:Ability{
//NAME=火焰包围
//TEXT=3回合后，摧毁对手的着火的牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_718e2:Ability{
//NAME=火焰包围
//TEXT=这张牌着火了！
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_719:MinionBase{
//NAME=指挥官乌尔索克
//TEXT=<b>战吼：</b>下个回合，你对手的卡牌消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=5|ATK=7|HP=7|RACE=NONE
}
public class TID_719e:Ability{
//NAME=挤榨鲜血
//TEXT=在本回合中，你的卡牌消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_744:MinionBase{
//NAME=盘牙蟠蟒
//TEXT=<b>战吼：</b> 检视你对手的3张手牌并选择一张，使其无法在下回合中使用。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
}
public class TID_744e:Ability{
//NAME=紧紧束缚
//TEXT=下回合中无法使用。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TID_920:SpellBase{
//NAME=淹没
//TEXT=将一个敌方随从置于你的牌库底。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class TID_931:SpellBase{
//NAME=头等大奖
//TEXT=将两张其他职业的法力值消耗大于或等于（5）点的法术牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TID_949:SpellBase{
//NAME=战争前线
//TEXT=从每个玩家的牌库中各召唤一个随从。重复，直到任意一方的随从数量达到上限。
//MAJ=PALADIN|COST=9|ATK=0|HP=0|RACE=NONE
}
