using System.Collections;
using System.Collections.Generic;

public class DMF_002:MinionBase{
//NAME=恩佐斯，深渊之神
//TEXT=<b>战吼：</b>随机复活每个随从类型的各一个友方随从。
//MAJ=NEUTRAL|COST=9|ATK=5|HP=7|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<RaceType> ToSummonRace = new List<RaceType>();
		List<CardDbf> ToListSummon = new List<CardDbf>();
		foreach(Card c in owner.myPlayer.grave)
		{
			bool HasRace = true;
			if(c.raceType.Count!=0 && c.cardType==CardType.Minion)
			{
				foreach(RaceType rc in c.raceType)
				{
					if(!ToSummonRace.Contains(rc))
					{
						HasRace = false;
						ToSummonRace.Add(rc);
						break;
					}
				}
			}
			if(!HasRace)
			{
				ToListSummon.Add(c.cardDbf);
			}
		}
		foreach(CardDbf d in ToListSummon)
		{
			TaskCreate(d,ZoneType.Board);
		}
	}
}
public class DMF_004:MinionBase{
//NAME=尤格-萨隆，命运主宰
//TEXT=<b>战吼：</b>在本局对战中，如果你施放过10个法术，转动尤格-萨隆的命运之轮。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=10|ATK=7|HP=5|RACE=NONE
}
public class DMF_004t1:SpellBase{
//NAME=神秘魔盒
//TEXT=在本局对战中，你每施放过一个法术，便随机施放一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t1e:Ability{
//NAME=命运奖励！
//TEXT=在本回合中法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t2:SpellBase{
//NAME=命运之手
//TEXT=用随机法术牌填满你的手牌。在本回合中，这些法术牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t3:SpellBase{
//NAME=血肉诅咒
//TEXT=用随机随从填满面板，然后使你的这些随从获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t4:SpellBase{
//NAME=夺心护目镜
//TEXT=随机夺取三个敌方随从的 控制权。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t5:SpellBase{
//NAME=吞噬之饥
//TEXT=消灭所有其他随从。获得其攻击力和生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t5e:Ability{
//NAME=吞噬
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_004t6:SpellBase{
//NAME=燃烧权杖
//TEXT=随机施放炎爆术直到一方英雄 死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_044:MinionBase{
//NAME=岩石暴怒者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=5|HP=1|RACE=ELEMENTAL
}
public class DMF_053:MinionBase{
//NAME=戈霍恩之血
//TEXT=<b>嘲讽</b> 在你的回合结束时，召唤一个你牌库中的随从的5/5复制。
//MAJ=PRIEST|COST=9|ATK=8|HP=8|RACE=ELEMENTAL
}
public class DMF_053e:Ability{
//NAME=戈霍恩之血
//TEXT=攻击力和生命值变为5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_054:SpellBase{
//NAME=洞察
//TEXT=抽一张随从牌。<b>腐蚀：</b>使其法力值消耗减少（2）点。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_054e:Ability{
//NAME=洞察
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_054t:SpellBase{
//NAME=洞察
//TEXT=<b>已腐蚀</b> 抽一张随从牌，并使其法力值消耗减少（2）点。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_055:SpellBase{
//NAME=亚煞极神像
//TEXT=召唤一个你牌库中的随从的10/10复制。
//MAJ=PRIEST|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_055e:Ability{
//NAME=古神之像
//TEXT=攻击力和生命值变为10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_056:MinionBase{
//NAME=戈霍恩，鲜血之神
//TEXT=<b>战吼：</b>抽两张牌，使其消耗生命值，而非法力值。
//MAJ=PRIEST|COST=8|ATK=8|HP=8|RACE=NONE
}
public class DMF_056e:Ability{
//NAME=古神之血
//TEXT=消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_057:SpellBase{
//NAME=月蚀
//TEXT=对一个随从造成$3点伤害。在本回合中，你施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class DMF_057e:Ability{
//NAME=月光增效
//TEXT=你施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_057o:Ability{
//NAME=月光增效
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_058:SpellBase{
//NAME=日蚀
//TEXT=在本回合中，你施放的下一个法术将施放两次。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DMF_058e:Ability{
//NAME=日光增效
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_058o:Ability{
//NAME=日光增效
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_059:MinionBase{
//NAME=泡沫元素
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=DRUID|COST=9|ATK=10|HP=10|RACE=ELEMENTAL
}
public class DMF_060:MinionBase{
//NAME=幽影猫头鹰
//TEXT=<b>突袭</b> 在本局对战中，你每施放一个法术，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=7|ATK=4|HP=4|RACE=BEAST
}
public class DMF_061:MinionBase{
//NAME=马戏团树艺师
//TEXT=<b>抉择：</b>抽一张牌；或者召唤一个2/2的树人。<b>腐蚀：</b>同时拥有两种效果。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class DMF_061a:SpellBase{
//NAME=摘取果实
//TEXT=抽一张牌。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_061b:SpellBase{
//NAME=挖掘树人
//TEXT=召唤一个2/2的树人。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_061t:MinionBase{
//NAME=马戏团树艺师
//TEXT=<b>已腐蚀</b> <b>战吼：</b>召唤一个2/2的树人，抽一张牌。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class DMF_061t2:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class DMF_062:MinionBase{
//NAME=旋岩虫
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=ELEMENTAL
}
public class DMF_064:MinionBase{
//NAME=旋转木马
//TEXT=<b>圣盾</b>，<b>腐蚀：</b>获得+3/+3和<b>嘲讽</b>。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class DMF_064t:MinionBase{
//NAME=旋转木马
//TEXT=<b>已腐蚀</b> <b>圣盾，</b><b>嘲讽</b>
//MAJ=PALADIN|COST=5|ATK=8|HP=8|RACE=MECHANICAL
}
public class DMF_065:MinionBase{
//NAME=香蕉商贩
//TEXT=<b>战吼：</b>将两根香蕉置入每个玩家的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class DMF_065e:Ability{
//NAME=香蕉
//TEXT=拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_065t:SpellBase{
//NAME=香蕉
//TEXT=使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DMF_066:MinionBase{
//NAME=小刀商贩
//TEXT=<b>战吼：</b>对每个英雄造成4点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class DMF_067:MinionBase{
//NAME=奖品商贩
//TEXT=<b>战吼：</b>每个玩家抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class DMF_068:MinionBase{
//NAME=乐观的食人魔
//TEXT=50%几率攻击正确的敌人。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=7|RACE=NONE
}
public class DMF_069:MinionBase{
//NAME=娃娃机
//TEXT=<b>突袭，亡语：</b>抽一张随从牌并使其获得+3/+3。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=3|RACE=MECHANICAL
}
public class DMF_069e:Ability{
//NAME=啊啊！
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_070:MinionBase{
//NAME=暗月兔子
//TEXT=<b>突袭，剧毒</b> 同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=10|ATK=1|HP=1|RACE=BEAST
}
public class DMF_071:MinionBase{
//NAME=“赤烟”腾武
//TEXT=<b>战吼：</b>将一个友方随从移回你的手牌，在本回合中，其法力值消耗为（1）点。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DMF_071e:Ability{
//NAME=热力迸发
//TEXT=在本回合中法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_073:MinionBase{
//NAME=暗月飞船
//TEXT=<b>圣盾，腐蚀：</b>获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=MECHANICAL
}
public class DMF_073t:MinionBase{
//NAME=暗月飞船
//TEXT=<b>已腐蚀</b> <b>突袭，圣盾</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=MECHANICAL
}
public class DMF_074:MinionBase{
//NAME=希拉斯·暗月
//TEXT=<b>战吼：</b>选择一个方向，让所有随从转 起来。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=4|RACE=NONE
}
public class DMF_074a:SpellBase{
//NAME=向这边转
//TEXT=所有随从会向这个方向转动。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_074b:SpellBase{
//NAME=向那边转
//TEXT=所有随从会向那个方向转动。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_075:SpellBase{
//NAME=猜重量
//TEXT=抽一张牌。猜中你下一张牌的法力值消耗更大或更小，则可抽取下一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_075a:SpellBase{
//NAME=大
//TEXT=猜测下一张牌法力值消耗更大。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_075a2:SpellBase{
//NAME=小
//TEXT=猜测下一张牌法力值消耗更小。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_078:MinionBase{
//NAME=大力士
//TEXT=<b>嘲讽，腐蚀：</b>法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class DMF_078e:Ability{
//NAME=腐蚀
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_078t:MinionBase{
//NAME=大力士
//TEXT=<b>已腐蚀</b> <b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=NONE
}
public class DMF_079:MinionBase{
//NAME=低调的游客
//TEXT=<b>战吼：</b>从你的牌库中施放一个<b>奥秘</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class DMF_080:MinionBase{
//NAME=迅蹄珠齿象
//TEXT=<b>突袭</b> <b>腐蚀：</b>获得+4/+4。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class DMF_080t:MinionBase{
//NAME=迅蹄珠齿象
//TEXT=<b>已腐蚀</b> <b>突袭</b>
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class DMF_081:MinionBase{
//NAME=克熙尔祭师
//TEXT=<b>嘲讽，战吼：</b>随机将一张法力值消耗为（4）的随从牌置入你对手的手牌。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class DMF_082:MinionBase{
//NAME=暗月雕像
//TEXT=你的其他随从拥有+1攻击力。<b>腐蚀：</b>本随从获得+4攻击力。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=5|RACE=NONE
}
public class DMF_082e:Ability{
//NAME=宏伟雕像
//TEXT=暗月雕像使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_082t:MinionBase{
//NAME=暗月雕像
//TEXT=<b>已腐蚀</b> 你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=5|RACE=NONE
}
public class DMF_083:MinionBase{
//NAME=舞动的眼镜蛇
//TEXT=<b>腐蚀：</b>获得<b>剧毒</b>。
//MAJ=HUNTER|COST=2|ATK=1|HP=5|RACE=BEAST
}
public class DMF_083t:MinionBase{
//NAME=舞动的眼镜蛇
//TEXT=<b>已腐蚀</b> <b>剧毒</b>
//MAJ=HUNTER|COST=2|ATK=1|HP=5|RACE=BEAST
}
public class DMF_084:SpellBase{
//NAME=恩佐斯宝石
//TEXT=召唤三个在本局对战中死亡的友方<b>亡语</b>随从。
//MAJ=HUNTER|COST=8|ATK=0|HP=0|RACE=NONE
}
public class DMF_085:MinionBase{
//NAME=暗月坦克
//TEXT=<b>亡语：</b>随机对敌人发射四枚飞弹，每枚飞弹造成2点伤害。
//MAJ=HUNTER|COST=7|ATK=8|HP=5|RACE=MECHANICAL
}
public class DMF_086:SpellBase{
//NAME=宠物乐园
//TEXT=召唤一只3/3的陆行鸟。你每控制一个<b>奥秘</b>，重复一次。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_086e:MinionBase{
//NAME=暗月陆行鸟
//TEXT=
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class DMF_087:MinionBase{
//NAME=狂踏的犀牛
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，超过目标生命值的伤害会命中敌方英雄。
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class DMF_088:WeaponBase{
//NAME=瑞林的步枪
//TEXT=在你的英雄攻击后，<b>发现</b>一张<b>奥秘</b>牌并将其 施放。
//MAJ=HUNTER|COST=4|ATK=2|HP=2|RACE=NONE
}
public class DMF_089:MinionBase{
//NAME=玛克希玛·雷管
//TEXT=<b>战吼：</b>从你的牌库中召唤一个随从，使其攻击敌方英雄，然后死亡。
//MAJ=HUNTER|COST=6|ATK=4|HP=4|RACE=NONE
}
public class DMF_090:SpellBase{
//NAME=请勿投食
//TEXT=使你手牌中的所有野兽牌获得+1/+1。<b>腐蚀：</b>改为+2/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_090e:Ability{
//NAME=进食充分
//TEXT=+2/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_090e2:Ability{
//NAME=进食充分
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_090t:SpellBase{
//NAME=请勿投食
//TEXT=<b>已腐蚀</b> 使你手牌中的所有野兽牌获得+2/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_091:MinionBase{
//NAME=蠕动的恐魔
//TEXT=<b>战吼：</b>使相邻的随从获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class DMF_091e2:Ability{
//NAME=蠕动盘绕
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_100:MinionBase{
//NAME=甜点飓风
//TEXT=<b>战吼：</b>将两张1/2的甜蜜元素置入你的 手牌。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
}
public class DMF_100t:MinionBase{
//NAME=甜蜜元素
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
}
public class DMF_101:MinionBase{
//NAME=焰火元素
//TEXT=<b>战吼：</b>对一个随从造成3点伤害。<b>腐蚀：</b>改为12点。
//MAJ=MAGE|COST=5|ATK=3|HP=5|RACE=ELEMENTAL
}
public class DMF_101t:MinionBase{
//NAME=焰火元素
//TEXT=<b>已腐蚀</b> <b>战吼：</b>对一个随从造成12点伤害。
//MAJ=MAGE|COST=5|ATK=3|HP=5|RACE=ELEMENTAL
}
public class DMF_102:MinionBase{
//NAME=游戏管理员
//TEXT=你每个回合使用的第一张<b>奥秘</b>牌法力值消耗为（1）点。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DMF_102e:Ability{
//NAME=特殊减免
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_103:SpellBase{
//NAME=克苏恩面具
//TEXT=造成$10点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),10);
	}
}
public class DMF_104:SpellBase{
//NAME=华丽谢幕
//TEXT=召唤一个8/8的元素。你在上个回合每使用一张元素牌，重复一次。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=FIRE
}
public class DMF_104t:MinionBase{
//NAME=爆破烟火
//TEXT=
//MAJ=MAGE|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
}
public class DMF_105:SpellBase{
//NAME=套圈圈
//TEXT=<b>发现</b>一张<b>奥秘</b>牌并将其施放。<b>腐蚀：</b>改为<b>发现</b>两张。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DMF_105t:SpellBase{
//NAME=套圈圈
//TEXT=<b>已腐蚀</b> <b>发现</b>两张<b>奥秘</b>牌并将其施放。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DMF_106:MinionBase{
//NAME=隐秘咒术师
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便召唤一个本随从的复制。
//MAJ=MAGE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class DMF_107:SecretBase{
//NAME=非公平游戏
//TEXT=<b>奥秘：</b> 如果你在对手的回合没有受到任何伤害，抽三张牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_108:SpellBase{
//NAME=愚人套牌
//TEXT=将你牌库中的法术牌变形成为法力值消耗增加（3）点的法术牌。<i>（保留其原始法力值消耗。）</i>
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_108e:Ability{
//NAME=放弃理智
//TEXT=法力值消耗已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_109:MinionBase{
//NAME=暗月先知塞格
//TEXT=<b>战吼：</b>抽1张牌。<i>（在本局对战中，每触发一个友方<b>奥秘</b>都会升级！）</i>
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class DMF_110:MinionBase{
//NAME=吐火艺人
//TEXT=<b>战吼：</b>对所有非恶魔随从造成2点伤害。
//MAJ=WARLOCK|COST=4|ATK=4|HP=3|RACE=DEMON
}
public class DMF_111:MinionBase{
//NAME=摇滚堕落者
//TEXT=<b>战吼：</b>在本回合中，使一个友方恶魔获得+3攻击力和<b>吸血</b>。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=DEMON
}
public class DMF_111e:Ability{
//NAME=黑暗力量
//TEXT=直到回合结束，获得+3攻击力和<b>吸血</b>。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_113:SpellBase{
//NAME=免票入场
//TEXT=抽两张随从牌。如果两张都是恶魔牌，使其法力值消耗减少（2）点。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_113e:Ability{
//NAME=插队
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_114:MinionBase{
//NAME=癫狂的游客
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=2|ATK=1|HP=5|RACE=DEMON
}
public class DMF_115:MinionBase{
//NAME=怨灵捣蛋鬼
//TEXT=<b>战吼：</b>摧毁每个玩家的一个法力水晶。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DMF_116:MinionBase{
//NAME=无名者
//TEXT=<b>战吼：</b>选择一个随从，成为它的4/4复制，<b>沉默</b>目标随从。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=NONE
}
public class DMF_116e:Ability{
//NAME=无名
//TEXT=4/4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_117:SpellBase{
//NAME=连环灾难
//TEXT=随机消灭一个敌方随从。<b>腐蚀：</b>消灭两个。<b>再次腐蚀：</b>消灭三个。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DMF_117t:SpellBase{
//NAME=连环灾难
//TEXT=<b>已腐蚀</b> 随机消灭两个敌方随从。<b>腐蚀：</b>消灭 三个。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DMF_117t2:SpellBase{
//NAME=连环灾难
//TEXT=<b>已腐蚀</b> 随机消灭三个敌方随从。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DMF_118:MinionBase{
//NAME=提克特斯
//TEXT=<b>战吼：</b>移除你的牌库顶的五张牌。<b>腐蚀：</b>改为对手的牌库。
//MAJ=WARLOCK|COST=6|ATK=8|HP=8|RACE=DEMON
}
public class DMF_118t:MinionBase{
//NAME=提克特斯
//TEXT=<b>已腐蚀</b> <b>战吼：</b>移除你对手的牌库顶的五张牌。
//MAJ=WARLOCK|COST=6|ATK=8|HP=8|RACE=DEMON
}
public class DMF_119:SpellBase{
//NAME=邪恶低语
//TEXT=弃掉你手牌中法力值消耗最低的牌。使你的所有随从获得+1/+1。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_119e:Ability{
//NAME=夜幕降临
//TEXT=+1/+1。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_120:MinionBase{
//NAME=纳兹曼尼织血者
//TEXT=在你施放一个法术后，随机使你的一张手牌法力值消耗减少（1）点。
//MAJ=PRIEST|COST=3|ATK=2|HP=5|RACE=NONE
}
public class DMF_120e2:Ability{
//NAME=鲜血交织
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_121:MinionBase{
//NAME=占卜机
//TEXT=<b>嘲讽，战吼：</b> 你手牌中每有一张法术牌，便获得+1/+1。
//MAJ=PRIEST|COST=5|ATK=3|HP=3|RACE=MECHANICAL
}
public class DMF_121e2:Ability{
//NAME=命运法则
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_122:MinionBase{
//NAME=神秘获奖者
//TEXT=<b>战吼：</b> <b>发现</b>一张<b>奥秘</b>牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DMF_123:SecretBase{
//NAME=打开兽笼
//TEXT=<b>奥秘：</b>当你的回合开始时，如果你控制着两个随从，召唤一个动物伙伴。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_124:MinionBase{
//NAME=恐怖增生体
//TEXT=<b>腐蚀：</b>获得+1/+1。可以被无限<b>腐蚀</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DMF_124t:MinionBase{
//NAME=恐怖增生体
//TEXT=<b>已腐蚀</b> <b>腐蚀：</b>获得+1/+1。可以被无限<b>腐蚀</b>。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=3|RACE=NONE
}
public class DMF_125:MinionBase{
//NAME=安全检查员
//TEXT=<b>战吼：</b>把你手牌中法力值消耗最低的牌洗入牌库。抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class DMF_163:MinionBase{
//NAME=狂欢小丑
//TEXT=<b>嘲讽</b>。<b>战吼：</b>召唤本随从的两个复制。<b>腐蚀：</b>用本随从的复制填满你的面板。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=4|RACE=NONE
}
public class DMF_163t:MinionBase{
//NAME=狂欢小丑
//TEXT=<b>已腐蚀</b> <b>嘲讽，战吼：</b>用本随从的复制填满你的面板。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=4|RACE=NONE
}
public class DMF_174:MinionBase{
//NAME=马戏团医师
//TEXT=<b>战吼：</b>恢复#4点生命值。<b>腐蚀：</b>改为造成4点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class DMF_174t:MinionBase{
//NAME=马戏团医师
//TEXT=<b>已腐蚀</b> <b>战吼：</b>造成4点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class DMF_184:MinionBase{
//NAME=游乐园小丑
//TEXT=<b>嘲讽，腐蚀：</b>获得+4生命值。
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=NONE
}
public class DMF_184t:MinionBase{
//NAME=游乐园小丑
//TEXT=<b>已腐蚀</b> <b>嘲讽</b>
//MAJ=PRIEST|COST=3|ATK=4|HP=7|RACE=NONE
}
public class DMF_186:SpellBase{
//NAME=吉兆
//TEXT=随机召唤一个法力值消耗为（4）的随从。<b>腐蚀：</b>改为召唤法力值消耗为（7）的随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_186a:SpellBase{
//NAME=吉兆
//TEXT=<b>已腐蚀</b> 随机召唤一个法力值消耗为（7）的随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_187:SpellBase{
//NAME=解读手相
//TEXT=<b>发现</b>一张法术牌。使你手牌中所有法术牌的法力值消耗减少（1）点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_187e:Ability{
//NAME=Palm Reading
//TEXT=Costs (1) less.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_188:MinionBase{
//NAME=亚煞极，污染之源
//TEXT=<b>战吼：</b>将你在本局对战中使用过的每张<b>已腐蚀</b>牌的复制置入你的手牌。在本回合中，这些<b>已腐蚀</b>牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class DMF_188e:Ability{
//NAME=真正的腐蚀
//TEXT=你的下一张<b>腐蚀</b>牌法力值消耗为（0）。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_188e2:Ability{
//NAME=亚煞极的腐蚀
//TEXT=在本回合中法力值消耗为（0）。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_188t:SpellBase{
//NAME=腐蚀术
//TEXT=<b>腐蚀</b>你的所有卡牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DMF_189:MinionBase{
//NAME=盛装演员
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class DMF_189e:Ability{
//NAME=乐在其中
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_190:MinionBase{
//NAME=炫目火鸟
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class DMF_191:MinionBase{
//NAME=砸场游客
//TEXT=<b>亡语：</b><b>沉默</b>所有随从。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DMF_194:MinionBase{
//NAME=赤鳞驯龙者
//TEXT=<b>亡语：</b>抽一张龙牌。
//MAJ=PALADIN|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class DMF_195:SpellBase{
//NAME=零食大冲关
//TEXT=<b>发现</b>一张法术牌。为你的英雄恢复等同于其法力值消耗的生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_202:MinionBase{
//NAME=脱轨过山车
//TEXT=<b>战吼：</b>你的手牌中每有一张随从牌，召唤一个1/1并具有<b>突袭</b>的乘客。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=2|RACE=NONE
}
public class DMF_217:MinionBase{
//NAME=越线的游客
//TEXT=你的<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class DMF_217e:Ability{
//NAME=这写着能过
//TEXT=你的<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_219:SpellBase{
//NAME=冷酷追杀
//TEXT=在本回合中，使你的英雄获得+4攻击力和<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.hero.Count>0)
		{
			TaskBuffMyHero(atk:4);
			new EffectGiveAbility(owner.myPlayer,owner,owner.myPlayer.hero[0],"DivineShield").Resolve();
			//new EffectGiveAbility(owner.myPlayer,owner,owner.myPlayer.hero[0],"ImmueForOneTurn").Resolve();
		}
	}
}
public class DMF_219e:Ability{
//NAME=逐血而来
//TEXT=在本回合中，+4攻击力和<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_221:SpellBase{
//NAME=邪吼冲击
//TEXT=<b>吸血</b> 对一个随从和相邻的随从造成$1点伤害。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=FEL
}
public class DMF_222:MinionBase{
//NAME=获救的流民
//TEXT=在你使用一张<b>流放</b>牌后，获得+1/+1。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DMF_222e:Ability{
//NAME=流民的决心
//TEXT=+1/+1。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_223:MinionBase{
//NAME=知名表演者
//TEXT=<b>突袭，亡语：</b>召唤两个1/1并具有<b>嘲讽</b> 的助演。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DMF_223t:MinionBase{
//NAME=演出助手
//TEXT=<b>嘲讽</b>
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DMF_224:SpellBase{
//NAME=演员大接力
//TEXT=召唤七个1/1并具有<b>突袭</b>的伊利达雷。在本回合中，如果他们全部死亡，再召唤七个。
//MAJ=DEMONHUNTER|COST=7|ATK=0|HP=0|RACE=NONE
	private bool Act=false;
	private int Cnt=0;
	private int Cnt2=0;
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
		for(int i=0;i<7;i++)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
			Cnt2+=1;
		}
		Act=true;
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(Act)
		{
			if(sc.cardDbf.m_noteMiniGuid=="BT_036t")
			{
				Cnt+=1;
				if(Cnt==Cnt2)
				{
					for(int i=0;i<7;i++)
					{
						TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
					}
					Act=false;	
				}
			}
		}
	}
}
public class DMF_224e:Ability{
//NAME=接力演出
//TEXT=当没有伊利达雷存活时，再召唤七个。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_225:SpellBase{
//NAME=投掷利刃
//TEXT=对一个随从造成$2点伤害。如果该随从死亡，则将本牌的一张<b>临时</b>复制置入你的手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		if(target.GetTag(GameTag.Health)<=0)
		{
			Card c = TaskCreate(owner.cardDbf,ZoneType.Hand);
			new EffectGiveAbility(owner.myPlayer,owner,c,"DiscardOnTurnEnd").Resolve();
		}
	}
}
public class DMF_226:MinionBase{
//NAME=刀锋舞娘
//TEXT=<b>突袭</b> 如果你的英雄的攻击力大于或等于6点，则法力值消耗为（1）点。
//MAJ=DEMONHUNTER|COST=6|ATK=6|HP=6|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(owner.myPlayer.hero.Count>0)
			{
				if(owner.myPlayer.hero[0].GetTag(GameTag.Attack)>=6)
				{
					return -5;
				}
			}
		}
		return 0;
	}
}
public class DMF_227:WeaponBase{
//NAME=恐惧魔王之咬
//TEXT=<b>流放：</b>对所有敌人造成1点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DMF_229:MinionBase{
//NAME=高跷艺人
//TEXT=<b>战吼：</b>抽一张牌。如果你在本回合中使用抽到的牌，使你的英雄在本回合中获得+4攻击力。
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=1|RACE=NONE
	private Card Drawn;
	public override void Battlecry(Card target=null)
	{
		this.Drawn = TaskDraw();
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CancelEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==this.Drawn)
		{
			TaskBuffMyHero(atk:4);
		}
	}
	public void CancelEvent()
	{
		this.UnRegisterEventEffect();
	}
}
public class DMF_229e:Ability{
//NAME=踩高跷
//TEXT=在本回合中+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_229e2:Ability{
//NAME=踩上去
//TEXT=使用这张牌，在本回合中使你的英雄获得+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_230:MinionBase{
//NAME=伊格诺斯
//TEXT=<b>吸血</b> 你的<b>吸血</b>会对敌方英雄造成伤害，而非治疗你。
//MAJ=DEMONHUNTER|COST=4|ATK=2|HP=6|RACE=NONE
}
public class DMF_230e:Ability{
//NAME=腐蚀
//TEXT=你的<b>吸血</b>会对敌方英雄造成伤害，而非治疗你。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_231:MinionBase{
//NAME=扎依，出彩艺人
//TEXT=<b>战吼：</b> 复制你手牌中最左边和最右边的牌。
//MAJ=DEMONHUNTER|COST=5|ATK=5|HP=3|RACE=NONE
}
public class DMF_235:MinionBase{
//NAME=气球商人
//TEXT=<b>战吼：</b>使你的白银之手新兵获得+1攻击力和<b>圣盾</b>。
//MAJ=PALADIN|COST=4|ATK=3|HP=5|RACE=NONE
}
public class DMF_235e:Ability{
//NAME=轻飘飘
//TEXT=+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_236:SecretBase{
//NAME=古神在上
//TEXT=<b>奥秘：</b>在你的对手施放一个法术时，使其改为随机施放一个法力值消耗相同的法术。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_236t:Ability{
//NAME=古神在上
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_237:MinionBase{
//NAME=狂欢报幕员
//TEXT=每当你召唤一个生命值为1的随从，便使其获得+1/+2。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DMF_237e:Ability{
//NAME=园中狂欢
//TEXT=+1/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_238:WeaponBase{
//NAME=纳鲁之锤
//TEXT=<b>战吼：</b>召唤一个6/6并具有<b>嘲讽</b>的神圣元素。
//MAJ=PALADIN|COST=6|ATK=3|HP=3|RACE=NONE
}
public class DMF_238t:MinionBase{
//NAME=神圣元素
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=6|ATK=6|HP=6|RACE=ELEMENTAL
}
public class DMF_240:MinionBase{
//NAME=救赎者洛萨克森
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，在你召唤一个白银之手新兵后，使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=DEMON
    public override void UnRegisterEventEffect()
    {
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> targets = new List<Card>();
        List<int> Buffs = new List<int>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Totem))
            {
                targets.Add(c);
                Buffs.Add(2);
            }
        }
        new EffectChange(owner.myPlayer,owner,targets:targets,atkChanges:Buffs).Resolve();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc, ZoneType sz, ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.cardDbf.m_noteMiniGuid.Contains("CS2_101t")))
        {
            new EffectGiveAbility(owner.myPlayer,owner,sc,"DivineShield").Resolve();
        }
    }
}
public class DMF_240e:Ability{
//NAME=洛萨克森之力
//TEXT=使你的白银之手新兵获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_241:MinionBase{
//NAME=大主教伊瑞尔
//TEXT=<b>战吼：</b>如果你的牌库中没有中立卡牌，获得<b>突袭</b>，<b>吸血</b>，<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=8|ATK=7|HP=5|RACE=NONE
}
public class DMF_244:SpellBase{
//NAME=游园日
//TEXT=召唤三个白银之手新兵。<b>腐蚀：</b>召唤五个。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
		{
			if(sc.GetTag(GameTag.Mana)>owner.GetTag(GameTag.Mana))
			{
				new EffectMove(owner.myPlayer,owner,ZoneType.Hand,ZoneType.Grave).Resolve();
				TaskCreate(CardDbf.GetCardDbfByGuid("DMF_244t"),ZoneType.Hand);
			}
		}
	}
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_101t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class DMF_244t:SpellBase{
//NAME=游园日
//TEXT=<b>已腐蚀</b> 召唤五个白银之手新兵。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_101t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class DMF_247:MinionBase{
//NAME=贪食地狱犬
//TEXT=<b>嘲讽</b> <b>腐蚀：</b>获得+1/+1和<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=5|RACE=DEMON
}
public class DMF_247e:Ability{
//NAME=Corruption
//TEXT=Corrupted.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_247t:MinionBase{
//NAME=贪食地狱犬
//TEXT=<b>已腐蚀</b> <b>嘲讽</b>，<b>吸血</b>
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=6|RACE=DEMON
}
public class DMF_248:MinionBase{
//NAME=魔钢处决者
//TEXT=<b>腐蚀：</b>变为武器牌。
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=3|RACE=ELEMENTAL
}
public class DMF_248e:Ability{
//NAME=邪恶变形
//TEXT=生命值变为耐久度。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_248t:WeaponBase{
//NAME=魔钢处决者
//TEXT=<b>已腐蚀</b>
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=3|RACE=NONE
}
public class DMF_249:SpellBase{
//NAME=空翻杂技
//TEXT=抽两张牌。在本回合中，如果你使用了这两张牌，再抽 两张。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_249e:Ability{
//NAME=空翻杂技
//TEXT=使用这两张牌，再抽两张。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_254:MinionBase{
//NAME=克苏恩，破碎之劫
//TEXT=<b>对战开始时：</b>破碎成片。<b>战吼：</b>造成30点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=10|ATK=6|HP=6|RACE=NONE
}
public class DMF_254t3:SpellBase{
//NAME=克苏恩之眼
//TEXT=<b>克苏恩碎片（0/4）</b> 造成$7点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DMF_254t4:SpellBase{
//NAME=克苏恩之心
//TEXT=<b>克苏恩碎片（0/4）</b> 对所有随从造成$3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DMF_254t5:SpellBase{
//NAME=克苏恩之躯
//TEXT=<b>克苏恩碎片（0/4）</b> 召唤一个6/6并具有<b>嘲讽</b>的克苏恩残躯。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DMF_254t5t:MinionBase{
//NAME=克苏恩残躯
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class DMF_254t7:SpellBase{
//NAME=克苏恩之口
//TEXT=<b>克苏恩碎片（0/4）</b> 消灭一个随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DMF_511:MinionBase{
//NAME=狐人老千
//TEXT=<b>战吼：</b> 在本回合中，你的下一张<b>连击</b>牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
	private List<string> ComboPool = new List<string>(){"ETC_077","ETC_072","EX1_131","VAN_EX1_131","CORE_OG_070","OG_070","EX1_613","VAN_EX1_613","AV_201","DMF_515","ETC_073","VAC_460","RLK_573","VAN_CS2_073","CORE_CS2_073","CS2_073","DMF_519"};
    private bool on = false;
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            if (ComboPool.Contains(c.cardDbf.m_noteMiniGuid))
            {
                new EffectChange(owner.myPlayer,owner, c, -2, 0, 0, 0).Resolve();
            }
        }

    }
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_145CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_145CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (ComboPool.Contains(sc.cardDbf.m_noteMiniGuid) && on && sc!=owner)
        {
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (ComboPool.Contains(c.cardDbf.m_noteMiniGuid))
                {
                    new EffectChange(owner.myPlayer,owner, c, 2, 0, 0, 0).Resolve();
                }
            }
            on = false;
        }
    }
}
public class DMF_511e:Ability{
//NAME=启用机关
//TEXT=你的下一张<b>连击</b>牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_511e2:Ability{
//NAME=轻松连击
//TEXT=法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_512:SpellBase{
//NAME=暗影斗篷
//TEXT=直到你的下个回合，使你的英雄获得<b>潜行</b>。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_512e:Ability{
//NAME=隐秘行动
//TEXT=<b>潜行</b>一回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_513:SecretBase{
//NAME=暗影克隆
//TEXT=<b>奥秘：</b>在一个随从攻击你的英雄后，召唤一个它的具有<b>潜行</b>的复制。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_514:MinionBase{
//NAME=奖券老板
//TEXT=<b>亡语：</b>将三张奖券洗入你的牌库。当抽到奖券时，召唤一个3/3的玩具熊。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class DMF_514t:SpellBase{
//NAME=奖券
//TEXT=<b>抽到时施放</b> 召唤一个3/3的玩具熊。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_514t2:MinionBase{
//NAME=玩具熊
//TEXT=
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DMF_515:SpellBase{
//NAME=行骗
//TEXT=抽一张法术牌。<b>连击：</b>并抽一张随从牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDrawType(CardType.Spell);
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			TaskDrawType(CardType.Minion);
		}
	}
}
public class DMF_516:MinionBase{
//NAME=大女皇夏柯扎拉
//TEXT=<b>战吼：</b>从你的牌库中<b>发现</b>一张牌，抽取它的所有复制。
//MAJ=ROGUE|COST=6|ATK=5|HP=7|RACE=NONE
}
public class DMF_517:MinionBase{
//NAME=甜食狂
//TEXT=<b>腐蚀：</b>获得+2攻击力和<b>潜行</b>。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DMF_517a:MinionBase{
//NAME=甜食狂
//TEXT=<b>已腐蚀</b> <b>潜行</b>
//MAJ=ROGUE|COST=2|ATK=5|HP=2|RACE=NONE
}
public class DMF_518:SpellBase{
//NAME=致伤打击
//TEXT=消灭一个随从。你的牌库中每有一张套牌之外的牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DMF_519:MinionBase{
//NAME=奖品掠夺者
//TEXT=<b>连击：</b>在本回合中，你每使用一张其他牌，便对一个随从造成1点伤害。
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)).Resolve();
	}
}
public class DMF_519_COPY:MinionBase{
//NAME=奖品掠夺者
//TEXT=<b>连击：</b>在本回合中，你每使用一张其他牌，便对一个随从造成1点伤害。
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)).Resolve();
	}
}
public class DMF_520:MinionBase{
//NAME=巡游领队
//TEXT=在你召唤一个<b>突袭</b>随从后，使其获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class DMF_520e:Ability{
//NAME=领队奋进
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_521:MinionBase{
//NAME=吞剑艺人
//TEXT=<b>嘲讽，战吼：</b>装备一把3/2的剑。
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=PIRATE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("DMF_521t"),ZoneType.Weapon);
	}
}
public class DMF_521t:WeaponBase{
//NAME=断颚之刃
//TEXT=
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DMF_522:SpellBase{
//NAME=雷区挑战
//TEXT=造成$5点伤害，随机分配到所有随从身上。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomDistributeTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),5);
	}
}
public class DMF_523:MinionBase{
//NAME=碰碰车
//TEXT=<b>突袭，亡语：</b>将两张1/1并具有<b>突袭</b>的乘客置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=1|HP=3|RACE=MECHANICAL
}
public class DMF_523t:MinionBase{
//NAME=暗月乘客
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DMF_524:WeaponBase{
//NAME=马戏领班的节杖
//TEXT=在你的英雄攻击后，使你手牌中的一张机械牌，龙牌和海盗牌获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=1|HP=3|RACE=NONE
}
public class DMF_524e:Ability{
//NAME=顶尖演出
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_525:MinionBase{
//NAME=马戏领班威特利
//TEXT=<b>战吼：</b>抽一张机械牌，龙牌和海盗牌。
//MAJ=WARRIOR|COST=5|ATK=3|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDrawRace(RaceType.Mechanical);
		TaskDrawRace(RaceType.Dragon);
		TaskDrawRace(RaceType.Pirate);
	}
}
public class DMF_526:SpellBase{
//NAME=舞台跳水
//TEXT=抽一张<b>突袭</b>随从牌。<b>腐蚀：</b>使其获得+2/+1。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DMF_526a:SpellBase{
//NAME=舞台跳水
//TEXT=<b>已腐蚀</b> 抽一张<b>突袭</b>随从牌并使其获得+2/+1。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DMF_526e:Ability{
//NAME=呜呼！
//TEXT=+2/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_528:MinionBase{
//NAME=帐篷摧毁者
//TEXT=<b>突袭</b> 每有一个随从类型不同的友方随从，本牌的法力值消耗便减少（1）点。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class DMF_529:MinionBase{
//NAME=精英牛头人酋长，金属之神
//TEXT=在一个友方<b>突袭</b>随从攻击后，对敌方英雄造成2点伤害。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.HasAbility("Rush"))
			{
				TaskDamageEnemyHero(2);
			}
		}
	}
}
public class DMF_530:SpellBase{
//NAME=实力担当
//TEXT=随机使你手牌中的一张<b>嘲讽</b>随从牌获得+5/+5。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_530e:Ability{
//NAME=如此强壮
//TEXT=+5/+5。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_531:MinionBase{
//NAME=置景工
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=MECHANICAL
}
public class DMF_531e:Ability{
//NAME=准备开演
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_532:MinionBase{
//NAME=马戏团融合怪
//TEXT=<b>嘲讽</b> <i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=ALL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class DMF_533:MinionBase{
//NAME=火圈鬼母
//TEXT=<b>嘲讽，亡语：</b>召唤两个3/2的小鬼。
//MAJ=WARLOCK|COST=6|ATK=6|HP=4|RACE=DEMON
}
public class DMF_533t:MinionBase{
//NAME=火焰小鬼
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class DMF_534:SpellBase{
//NAME=混乱套牌
//TEXT=使你牌库中所有随从牌的法力值消耗和攻击力互换。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class DMF_534e:Ability{
//NAME=混乱套牌
//TEXT=攻击力已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_534e2:Ability{
//NAME=混乱套牌
//TEXT=法力值消耗已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_700:SpellBase{
//NAME=异变轮转
//TEXT=随机将所有随从变形成为法力值消耗相同的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DMF_701:SpellBase{
//NAME=深水炸弹
//TEXT=造成$4点伤害。<b>腐蚀：</b>再对所有敌方随从造成$2点伤害。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class DMF_701t:SpellBase{
//NAME=深水炸弹
//TEXT=<b>已腐蚀</b> 造成$4点伤害，再对所有敌方随从造成$2点 伤害。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class DMF_702:SpellBase{
//NAME=风暴打击
//TEXT=对一个随从造成$3点伤害。在本回合中，使你的英雄获得+3攻击力。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class DMF_702e:Ability{
//NAME=风暴打击
//TEXT=在本回合中+3攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_703:MinionBase{
//NAME=死斗场管理者
//TEXT=<b>战吼：</b>召唤一个3/2的决斗者。<b>腐蚀：</b>召唤两个。
//MAJ=SHAMAN|COST=3|ATK=1|HP=2|RACE=NONE
}
public class DMF_703t:MinionBase{
//NAME=死斗场管理者
//TEXT=<b>已腐蚀</b> <b>战吼：</b>召唤两个3/2的决斗者。
//MAJ=SHAMAN|COST=3|ATK=1|HP=2|RACE=NONE
}
public class DMF_703t2:MinionBase{
//NAME=决斗者
//TEXT=
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DMF_704:MinionBase{
//NAME=笼斗管理员
//TEXT=<b>战吼：</b> 抽一张武器牌。
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
	public override void Battlecry(Card target=null)
	{
		TaskDrawType(CardType.Weapon);
	}
}
public class DMF_705:WeaponBase{
//NAME=敲狼锤
//TEXT=在你的英雄攻击后，随机使一个友方随从获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DMF_705e:Ability{
//NAME=敲中啦！
//TEXT=+1/+1。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_706:SpellBase{
//NAME=死斗场帐篷
//TEXT=召唤一个3/2的决斗者。在本回合中，如果你的英雄进行过攻击，则再召唤一个。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DMF_706t:MinionBase{
//NAME=大帐决斗者
//TEXT=
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DMF_707:MinionBase{
//NAME=鱼人魔术师
//TEXT=在一个友方鱼人死亡后，随机将一张<b>传说</b>随从牌置入你的 手牌。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=MURLOC
}
public class DMF_708:MinionBase{
//NAME=伊纳拉·碎雷
//TEXT=在你的回合时，你的英雄拥有+2攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=5|ATK=4|HP=5|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hero && c.myPlayer==owner.myPlayer && c!=owner;
    }
    public override string AuraBuffName(Card c)
    {
        return "DMF_708e";
    }
}
public class DMF_708e:Ability{
//NAME=风雷破碎
//TEXT=+2攻击力并获得<b>风怒</b>.
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
	public int Rem=0;
    public override void RegisterEventEffect()
    {
    	Rem=owner.GetTag(GameTag.AttacksForOneTurn);
        if (owner.GetTag(GameTag.IsAwake) == 1 && owner.GetTag(GameTag.AttacksForOneTurn) == 1)
        {
            owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksLeftThisTurn) + this.amounts[2] - this.amounts[1]);
        }
        owner.SetTag(GameTag.AttacksForOneTurn, this.amounts[2]);
    }
    public override void UnRegisterEventEffect()
    {
    	owner.SetTag(GameTag.AttacksForOneTurn,Rem);
    }
    public override int AfterGetTag(GameTag tg)
    {
    	if(tg == GameTag.AttackMod && CondMyTurn())
    	{
    		return 2;
    	}
    	return 0;
    }
}
public class DMF_709:MinionBase{
//NAME=巨型图腾埃索尔
//TEXT=在你的回合结束时，使你手牌，牌库和战场上的所有其他图腾获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=0|HP=4|RACE=TOTEM
}
public class DMF_709e:Ability{
//NAME=埃索尔之力
//TEXT=+1/+1。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_730:SpellBase{
//NAME=月触项链
//TEXT=在本回合中，使你的英雄获得+4攻击力。<b>腐蚀：</b>并获得6点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_730e:Ability{
//NAME=月触项链
//TEXT=在本回合中+4攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_730t:SpellBase{
//NAME=月触项链
//TEXT=<b>已腐蚀</b> 在本回合中，使你的英雄获得+4攻击力。获得6点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DMF_732:SpellBase{
//NAME=塞纳里奥结界
//TEXT=获得8点护甲值。随机召唤一个法力值消耗为（8）的 随从。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class DMF_733:MinionBase{
//NAME=基利，艾露恩之眷
//TEXT=<b>战吼：</b> 将一张日蚀和一张月蚀置入你的手牌。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class DMF_734:MinionBase{
//NAME=格雷布
//TEXT=<b>嘲讽</b>，<b>亡语：</b>随机使一个友方随从获得“<b>亡语：</b>召唤格雷布。”
//MAJ=DRUID|COST=5|ATK=4|HP=6|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		Card ToBuff = owner.myPlayer.board.Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DMF_734e").Resolve();
		}
	}
}
public class DMF_734e:Ability{
//NAME=灰枝幼芽
//TEXT=<b>亡语：</b>召唤格雷布。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("DMF_734"),ZoneType.Board);
	}
}
public class DMF_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DMF_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
