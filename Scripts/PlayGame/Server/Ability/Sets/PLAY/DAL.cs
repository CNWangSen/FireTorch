using System.Collections;
using System.Collections.Generic;

public class DAL_007:SpellBase{
//NAME=拉法姆的阴谋
//TEXT=召唤1个1/1的小鬼。<i>（每回合都会升级！）</i>
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class DAL_008:SpellBase{
//NAME=砰砰博士的阴谋
//TEXT=获得1点护甲值。<i>（每回合都会升级！）</i>
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DAL_009:SpellBase{
//NAME=哈加莎的阴谋
//TEXT=对所有随从造成$1点伤害。<i>（每回合都会升级！）</i>
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class DAL_010:SpellBase{
//NAME=托瓦格尔的阴谋
//TEXT=选择一个随从。将它的1张复制洗入你的牌库。<i>（每回合都会升级！）</i>
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_011:SpellBase{
//NAME=拉祖尔的阴谋
//TEXT=直到你的下个回合，使一个敌方随从的攻击力降低1点。<i>（每回合都会升级！）</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class DAL_011e:Ability{
//NAME=拉祖尔的诅咒
//TEXT=攻击力降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_030:MinionBase{
//NAME=阴暗的人影
//TEXT=<b>战吼：</b> 变形成为一个友方<b>亡语</b>随从的2/2复制。
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DAL_030e:Ability{
//NAME=暗藏身形
//TEXT=2/2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_039:MinionBase{
//NAME=无面渗透者
//TEXT=<b>嘲讽</b> <b>亡语：</b>随机消灭一个敌方随从。
//MAJ=PRIEST|COST=5|ATK=2|HP=6|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		TaskDestroyRandomEnemyMinion();
	}
}
public class DAL_040:MinionBase{
//NAME=荆棘帮箭猪
//TEXT=<b>亡语：</b>为敌方英雄恢复5点生命值。
//MAJ=PRIEST|COST=4|ATK=4|HP=7|RACE=QUILBOAR
}
public class DAL_047:MinionBase{
//NAME=活动喷泉
//TEXT=<b>吸血，突袭，风怒</b>
//MAJ=SHAMAN|COST=8|ATK=4|HP=8|RACE=ELEMENTAL
}
public class DAL_049:MinionBase{
//NAME=下水道渔人
//TEXT=在你使用一张鱼人牌后，随机将一张鱼人牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class DAL_052:MinionBase{
//NAME=泥沼变形怪
//TEXT=<b>战吼：</b>变形成为你的牌库中一个其他随从的4/4复制。
//MAJ=SHAMAN|COST=5|ATK=4|HP=4|RACE=NONE
}
public class DAL_052e:Ability{
//NAME=泥沼变形
//TEXT=4/4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_058:MinionBase{
//NAME=机械拷问者
//TEXT=<b>嘲讽，战吼：</b>使你的对手从牌库中召唤一个随从。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=8|RACE=MECHANICAL
}
public class DAL_059:SpellBase{
//NAME=空间撕裂器
//TEXT=召唤你的牌库中一个随从的两个复制。
//MAJ=WARRIOR|COST=10|ATK=0|HP=0|RACE=NONE
}
public class DAL_060:MinionBase{
//NAME=发条地精
//TEXT=<b>战吼：</b>将一张“炸弹” 牌洗入你对手的牌库。当抽到“炸弹”时，便会受到5点伤害。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class DAL_062:SpellBase{
//NAME=横扫攻击
//TEXT=使一个随从获得 “同时对其攻击目标相邻的随从造成伤害。”
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_062e:Ability{
//NAME=横扫攻击
//TEXT=同时对攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_062e2:Ability{
//NAME=横扫攻击英雄
//TEXT=同时对攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_063:WeaponBase{
//NAME=圣剑扳手
//TEXT=在你的英雄攻击后，将一张“炸弹”牌洗入你对手的牌库。
//MAJ=WARRIOR|COST=4|ATK=3|HP=2|RACE=NONE
}
public class DAL_064:MinionBase{
//NAME=爆破之王砰砰
//TEXT=<b>战吼：</b>你对手的牌库中每有一张“炸弹”牌，便召唤两个1/1的砰砰机器人。
//MAJ=WARRIOR|COST=7|ATK=7|HP=7|RACE=NONE
}
public class DAL_065:SpellBase{
//NAME=不眠之魂
//TEXT=<b>沉默</b>一个友方随从，然后召唤一个它的复制。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class DAL_070:MinionBase{
//NAME=砰砰机甲
//TEXT=<b>战吼：</b> 召唤一个你牌库中的随从的复制，并使其获得<b>突袭</b>。
//MAJ=WARRIOR|COST=10|ATK=7|HP=9|RACE=MECHANICAL
}
public class DAL_070e:Ability{
//NAME=劫掠
//TEXT=拥有<b>突袭</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_071:SpellBase{
//NAME=突变
//TEXT=将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class DAL_077:MinionBase{
//NAME=毒鳍鱼人
//TEXT=<b>战吼：</b>使一个友方鱼人获得<b>剧毒</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
}
public class DAL_077e:Ability{
//NAME=剧毒之鳍
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_078:MinionBase{
//NAME=旅行医者
//TEXT=<b>圣盾，战吼：</b>恢复#3点生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class DAL_081:MinionBase{
//NAME=破咒珠宝师
//TEXT=<b>战吼：</b>直到下个回合，你的英雄拥有<b>扰魔</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class DAL_081e:Ability{
//NAME=光彩照人
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_085:MinionBase{
//NAME=达拉然圣剑士
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class DAL_086:MinionBase{
//NAME=夺日者间谍
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DAL_086e:Ability{
//NAME=窃取机密
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_087:MinionBase{
//NAME=荆棘帮巫婆
//TEXT=<b>战吼：</b>召唤两个具有全部随从类型的1/1的融合怪。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DAL_087t:MinionBase{
//NAME=融合怪
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=ALL
}
public class DAL_087tw:WeaponBase{
//NAME=融合怪
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=ALL
}
public class DAL_088:MinionBase{
//NAME=机械保险箱
//TEXT=<b>嘲讽，亡语：</b>召唤一个0/5并具有<b>嘲讽</b>的保险柜。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=MECHANICAL
}
public class DAL_088t2:MinionBase{
//NAME=保险柜
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=5|RACE=MECHANICAL
}
public class DAL_089:MinionBase{
//NAME=魔法订书匠
//TEXT=<b>战吼：</b>如果你拥有<b>法术伤害</b>，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DAL_090:MinionBase{
//NAME=荆棘帮小偷
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=QUILBOAR
}
public class DAL_092:MinionBase{
//NAME=奥术仆从
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class DAL_095:MinionBase{
//NAME=紫罗兰魔剑士
//TEXT=<b>战吼：</b>你手牌中每有一张法术牌，便获得+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=6|RACE=NONE
}
public class DAL_095e:Ability{
//NAME=魔法光辉
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_096:MinionBase{
//NAME=紫罗兰典狱官
//TEXT=<b>嘲讽</b> <b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=7|RACE=NONE
}
public class DAL_141:SpellBase{
//NAME=孤注一掷
//TEXT=<b>双生法术</b> 随机施放一个圣骑士<b>奥秘</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_141ts:SpellBase{
//NAME=孤注一掷
//TEXT=随机施放一个圣骑士<b>奥秘</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_146:MinionBase{
//NAME=青铜传令官
//TEXT=<b>亡语：</b>将两张4/4的“青铜龙”置入你的手牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=DRAGON
}
public class DAL_146t:MinionBase{
//NAME=青铜龙
//TEXT=
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class DAL_147:MinionBase{
//NAME=龙语者
//TEXT=<b>战吼：</b>使你手牌中的所有龙牌获得+3/+3。
//MAJ=PALADIN|COST=5|ATK=3|HP=5|RACE=NONE
}
public class DAL_147e:Ability{
//NAME=巨龙之吼
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_163:MinionBase{
//NAME=渡鸦信使
//TEXT=<b>战吼：</b><b>发现</b>一张法师随从牌。
//MAJ=MAGE|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class DAL_173:SpellBase{
//NAME=至暗时刻
//TEXT=消灭所有友方随从。每消灭一个随从，便随机从你的牌库中召唤一个随从。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class DAL_177:SpellBase{
//NAME=咒术师的召唤
//TEXT=<b>双生法术</b> 消灭一个随从。召唤两个法力值消耗相同的随从来替换它。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class DAL_177ts:SpellBase{
//NAME=咒术师的召唤
//TEXT=消灭一个随从。召唤两个法力值消耗相同的随从来 替换它。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class DAL_182:MinionBase{
//NAME=魔法蓝蛙
//TEXT=在你施放一个法术后，随机对一个敌方随从造成1点伤害。
//MAJ=MAGE|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class DAL_185:MinionBase{
//NAME=阿兰纳丝蛛后
//TEXT=<b>嘲讽</b> 当你抽到该牌时，为你的英雄恢复#4点生命值。
//MAJ=WARLOCK|COST=6|ATK=4|HP=6|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==owner)
		{
			if(sz==ZoneType.Deck && tz==ZoneType.Hand)
			{
				TaskHealMyHero(4);
			}
		}
	}
}
public class DAL_256:SpellBase{
//NAME=森林的援助
//TEXT=<b>双生法术</b> 召唤五个2/2的 树人。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class DAL_256t2:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class DAL_256ts:SpellBase{
//NAME=森林的援助
//TEXT=召唤五个2/2的树人。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class DAL_350:SpellBase{
//NAME=水晶之力
//TEXT=<b>抉择：</b>对一个随从造成$2点伤害；或者恢复#5点生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DAL_350a:SpellBase{
//NAME=利刺荆棘
//TEXT=对一个随从造成$2点伤害。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DAL_350b:SpellBase{
//NAME=愈合之花
//TEXT=恢复#5点生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DAL_351:SpellBase{
//NAME=远古祝福
//TEXT=<b>双生法术</b> 使你的所有随从获得+1/+1。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class DAL_351e:Ability{
//NAME=远古的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_351ts:SpellBase{
//NAME=远古祝福
//TEXT=使你的所有随从获得+1/+1。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class DAL_352:SpellBase{
//NAME=晶歌传送门
//TEXT=<b>发现</b>一张德鲁伊随从牌。如果你的手牌中没有随从牌，则保留全部三张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DAL_354:MinionBase{
//NAME=橡果人
//TEXT=<b>亡语：</b>将两张1/1的“松鼠”置入你的手牌。
//MAJ=DRUID|COST=1|ATK=2|HP=1|RACE=NONE
}
public class DAL_354t:MinionBase{
//NAME=松鼠
//TEXT=
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DAL_355:MinionBase{
//NAME=织命者
//TEXT=每当有角色获得你的治疗时，随机将一张德鲁伊法术牌置入你的手牌。
//MAJ=DRUID|COST=3|ATK=2|HP=5|RACE=NONE
}
public class DAL_357:MinionBase{
//NAME=卢森巴克
//TEXT=<b>嘲讽</b>。<b>亡语：</b>进入<b>休眠</b>状态。累计恢复5点生命值可唤醒本随从。
//MAJ=DRUID|COST=8|ATK=4|HP=8|RACE=NONE
}
public class DAL_357t:MinionBase{
//NAME=卢森巴克之魂
//TEXT=<b>休眠</b> 当你累计恢复了5点生命值时，唤醒本随从。<i>（还剩下5点！）</i>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class DAL_366:SpellBase{
//NAME=未鉴定的合约
//TEXT=消灭一个随从。在你手牌中时获得额外效果。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_366t1:SpellBase{
//NAME=刺客合约
//TEXT=消灭一个随从。召唤一个1/2的耐心的刺客。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_366t2:SpellBase{
//NAME=招募合约
//TEXT=消灭一个随从。将一张它的复制置入你的手牌。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_366t3:SpellBase{
//NAME=赏金合约
//TEXT=消灭一个随从。将两张幸运币置入你的手牌。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_366t4:SpellBase{
//NAME=叛变合约
//TEXT=消灭一个随从，并使其对相邻的随从造成等同于其攻击力的伤害。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_371:SpellBase{
//NAME=标记射击
//TEXT=对一个随从造成$4点伤害。<b>发现</b>一张法术牌。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DAL_372:MinionBase{
//NAME=奥术弓箭手
//TEXT=每当你使用一张法力值消耗为（1）的随从牌，从你的牌库中抽一张法术牌。
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DAL_373:SpellBase{
//NAME=急速射击
//TEXT=<b>双生法术</b> 造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_373ts:SpellBase{
//NAME=急速射击
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_376:MinionBase{
//NAME=湮灭战车
//TEXT=<b>亡语：</b>从你的手牌中召唤一个机械，并触发其<b>亡语</b>。
//MAJ=HUNTER|COST=6|ATK=3|HP=4|RACE=MECHANICAL
}
public class DAL_377:SpellBase{
//NAME=九命兽魂
//TEXT=<b>发现</b>一个在本局对战中死亡的友方<b>亡语</b>随从，并触发其 <b>亡语</b>。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DAL_378:SpellBase{
//NAME=猛兽出笼
//TEXT=<b>双生法术</b> 召唤一只5/5并具有<b>突袭</b>的双足飞龙。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_378t1:MinionBase{
//NAME=双足飞龙
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class DAL_378ts:SpellBase{
//NAME=猛兽出笼
//TEXT=召唤一只5/5并具有<b>突袭</b>的双足飞龙。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DAL_379:MinionBase{
//NAME=温蕾萨·风行者
//TEXT=<b>战吼：</b>装备索利达尔，群星之怒。
//MAJ=HUNTER|COST=7|ATK=5|HP=6|RACE=NONE
}
public class DAL_379e:Ability{
//NAME=群星之怒
//TEXT=在本回合中，你拥有<b>法术伤害+2</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_379t:WeaponBase{
//NAME=索利达尔，群星之怒
//TEXT=在你的英雄攻击后，在本回合中获得<b>法术伤害+2</b>。
//MAJ=HUNTER|COST=3|ATK=2|HP=3|RACE=NONE
}
public class DAL_400:MinionBase{
//NAME=怪盗布缆鼠
//TEXT=<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class DAL_413:MinionBase{
//NAME=怪盗征募员
//TEXT=<b>亡语：</b>将一张<b>跟班</b>牌置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DAL_415:MinionBase{
//NAME=怪盗恶霸
//TEXT=<b>连击：</b>随机将两张<b>跟班</b>牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=1|HP=5|RACE=NONE
}
public class DAL_416:MinionBase{
//NAME=荆棘帮蟊贼
//TEXT=<b>战吼：</b><b>发现</b>一张另一职业的法术牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class DAL_417:MinionBase{
//NAME=劫匪之王托瓦格尔
//TEXT=<b>战吼：</b>如果你控制一个<b>跟班</b>，就可以选择一张神奇宝藏。
//MAJ=ROGUE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class DAL_422:MinionBase{
//NAME=至尊盗王拉法姆
//TEXT=<b>嘲讽</b> <b>战吼：</b>将你的手牌和牌库里的卡牌替换为<b>传说</b>随从。
//MAJ=WARLOCK|COST=7|ATK=7|HP=8|RACE=NONE
}
public class DAL_431:MinionBase{
//NAME=沼泽女王哈加莎
//TEXT=<b>战吼：</b> 将一个5/5的恐魔置入你的手牌，并教会它两个萨满祭司法术。
//MAJ=SHAMAN|COST=7|ATK=5|HP=5|RACE=NONE
}
public class DAL_431t:MinionBase{
//NAME=德鲁斯瓦恐魔
//TEXT=<b>战吼：</b>施放{0}和{1}。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class DAL_432:SpellBase{
//NAME=女巫杂酿
//TEXT=恢复#4点生命值。在本回合可以重复使用。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DAL_433:MinionBase{
//NAME=淤泥吞食者
//TEXT=<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=2|HP=1|RACE=MURLOC
}
public class DAL_434:MinionBase{
//NAME=奥术守望者
//TEXT=除非你拥有<b>法术伤害</b>， 否则无法进行攻击。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=6|RACE=NONE
}
public class DAL_538:MinionBase{
//NAME=隐秘破坏者
//TEXT=<b>战吼：</b> 随机使你的对手从手牌中施放一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=UNDEAD
}
public class DAL_539:MinionBase{
//NAME=夺日者战斗法师
//TEXT=<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，则造成4点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class DAL_544:MinionBase{
//NAME=药水商人
//TEXT=<b>战吼：</b>为所有友方角色恢复#2点生命值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_546:MinionBase{
//NAME=咖啡师林彻
//TEXT=<b>战吼：</b>将你的所有其他<b>战吼</b>随从的复制置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class DAL_548:MinionBase{
//NAME=艾泽里特元素
//TEXT=在你的回合开始时，获得<b>法术伤害+2</b>。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=7|RACE=ELEMENTAL
}
public class DAL_548e:Ability{
//NAME=奥术扩张
//TEXT=<b>法术伤害</b>提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_550:MinionBase{
//NAME=下水道软泥怪
//TEXT=在本随从受到伤害并存活下来后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=5|RACE=NONE
}
public class DAL_551:MinionBase{
//NAME=骄傲的防御者
//TEXT=<b>嘲讽</b> 如果你没有其他随从，则拥有+2攻 击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class DAL_553:MinionBase{
//NAME=恶狼大法师
//TEXT=在你的回合结束时，随机召唤一个法力值消耗为（6）的随从。
//MAJ=NEUTRAL|COST=10|ATK=6|HP=6|RACE=NONE
}
public class DAL_554:MinionBase{
//NAME=大厨诺米
//TEXT=<b>战吼：</b>如果你的牌库里没有牌，则召唤六个6/6的猛火元素。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class DAL_554t:MinionBase{
//NAME=猛火元素
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=ELEMENTAL
}
public class DAL_558:MinionBase{
//NAME=大法师瓦格斯
//TEXT=在你的回合结束时，施放你在本回合中施放过的一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
	private List<Card> Remembered=new List<Card>();
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.Remember));
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void Remember(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc.cardType==CardType.Spell)
		{
			Remembered.Add(sc);
		}
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			Card ToPlay = Remembered.Choice(owner.myPlayer.randomGen);
			if(ToPlay!=null)
			{
				Card RandomTarget = owner.myPlayer.GetValidTargetMatchOption(ToPlay.cardDbf.Targets).Choice(owner.myPlayer.randomGen);
				if(ToPlay.cardDbf.Targets!=TargetingOptions.NoTarget)
				{
					if(RandomTarget==null)
					{
						goto Invalid;
					}
				}
				foreach(Ability abi in ToPlay.abilityList)
				{
					abi.Battlecry(RandomTarget);
				}
			}
		}
		Invalid:
			Remembered.Clear();
	}
}
public class DAL_560:MinionBase{
//NAME=霸气的旅店老板娘
//TEXT=<b>嘲讽，战吼：</b>每有一个其他友方随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=4|RACE=NONE
}
public class DAL_560e2:Ability{
//NAME=保护窖藏！
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_561:MinionBase{
//NAME=巨型小鬼
//TEXT=当本牌在你的手牌中时，每当一个友方恶魔死亡，法力值消耗便减少（1）点。
//MAJ=WARLOCK|COST=10|ATK=8|HP=8|RACE=DEMON
}
public class DAL_561e:Ability{
//NAME=小鬼当家
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_563:MinionBase{
//NAME=性急的杂兵
//TEXT=<b>亡语：</b>随机使两个友方随从获得+2/+2。
//MAJ=WARLOCK|COST=4|ATK=2|HP=2|RACE=NONE
}
public class DAL_563e:Ability{
//NAME=邪恶之力
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_565:MinionBase{
//NAME=传送门大恶魔
//TEXT=<b>战吼：</b>将三张传送门洗入你的牌库。当抽到传送门时，召唤一个2/2并具有<b>突袭</b>的恶魔。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=DEMON
}
public class DAL_566:MinionBase{
//NAME=古怪的铭文师
//TEXT=<b>亡语：</b>召唤四个1/1的复仇卷轴。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=NONE
}
public class DAL_566t:MinionBase{
//NAME=复仇卷轴
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_568:SpellBase{
//NAME=光铸祝福
//TEXT=<b>双生法术</b> 使一个友方随从获得<b>吸血</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class DAL_568e:Ability{
//NAME=光铸祝福
//TEXT=<b>吸血</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_568ts:SpellBase{
//NAME=光铸祝福
//TEXT=使一个友方随从获得<b>吸血</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class DAL_570:SecretBase{
//NAME=永不屈服
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，使你的所有随从获得+2生命值。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_570e:Ability{
//NAME=永不屈服
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_571:WeaponBase{
//NAME=神秘之刃
//TEXT=<b>战吼：</b> 如果你控制一个<b>奥秘</b>，便获得+1攻击力。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DAL_571e:Ability{
//NAME=神秘力量
//TEXT=+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_573:MinionBase{
//NAME=指挥官蕾撒
//TEXT=你的<b>奥秘</b>会触发 两次。
//MAJ=PALADIN|COST=3|ATK=4|HP=3|RACE=NONE
}
public class DAL_575:MinionBase{
//NAME=卡德加
//TEXT=你的召唤随从的卡牌召唤数量翻倍。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DAL_576:MinionBase{
//NAME=肯瑞托三修法师
//TEXT=<b>法术伤害+3</b> 你的法术牌法力值消耗增加（1）点。
//MAJ=MAGE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DAL_576e:Ability{
//NAME=肯瑞托的诅咒
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_577:SpellBase{
//NAME=霜冻射线
//TEXT=<b>双生法术</b> <b>冻结</b>一个随从。如果该随从已被<b>冻结</b>，则对其造成$2点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class DAL_577ts:SpellBase{
//NAME=霜冻射线
//TEXT=<b>冻结</b>一个随从。如果该随从已被<b>冻结</b>，则对其造成$2点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class DAL_578:SpellBase{
//NAME=创世之力
//TEXT=<b>发现</b>一张法力值消耗为（6）的随从牌。召唤两个它的 复制。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=ARCANE
}
public class DAL_579p:HeroPowerBase{
//NAME=深蓝魔网
//TEXT=<b>发现</b>一张法术牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_581:MinionBase{
//NAME=诺萨莉
//TEXT=<b>战吼：</b>为双方英雄恢复所有生命值。
//MAJ=PALADIN|COST=10|ATK=4|HP=12|RACE=DRAGON
}
public class DAL_582:MinionBase{
//NAME=传送门守护者
//TEXT=<b>战吼：</b>将三张传送门洗入你的牌库。当抽到传送门时，召唤一个2/2并具有<b>突袭</b>的恶魔。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=2|RACE=DEMON
}
public class DAL_582t:SpellBase{
//NAME=地狱犬传送门
//TEXT=<b>抽到时施放</b> 召唤一只2/2并具有<b>突袭</b>的地狱犬。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_582t2:MinionBase{
//NAME=地狱犬
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class DAL_587:MinionBase{
//NAME=闪光蝴蝶
//TEXT=<b>亡语：</b> 随机将一张猎人法术牌置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DAL_589:SpellBase{
//NAME=狩猎盛宴
//TEXT=复制你手牌中的所有野兽牌。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DAL_589e:Ability{
//NAME=狩猎小队
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_592:MinionBase{
//NAME=莽头食人魔
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，可再次攻击。
//MAJ=NEUTRAL|COST=8|ATK=3|HP=12|RACE=NONE
}
public class DAL_602:SpellBase{
//NAME=情势反转
//TEXT=将你的手牌洗入牌库。抽取相同数量的牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToShuffle = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			ToShuffle.Add(c);
		}
		foreach(Card c in ToShuffle)
		{
			TaskMove(c,ZoneType.Deck,randpos:true);
		}
		for(int i =0;i<ToShuffle.Count;i++)
		{
			TaskDraw();
		}
	}
}
public class DAL_603:MinionBase{
//NAME=法力飓风
//TEXT=<b>战吼：</b>你在本回合中每施放过一个法术，便随机将一张法师法术牌置入你的手牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class DAL_604:MinionBase{
//NAME=机械巨熊
//TEXT=<b>亡语：</b>从你的牌库中抽一张机械牌。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class DAL_605:SpellBase{
//NAME=小鬼狱火
//TEXT=使你的恶魔获得+1攻击力。对所有敌方随从造成$1点 伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class DAL_605e:Ability{
//NAME=小鬼真棒
//TEXT=+1攻击力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_606:MinionBase{
//NAME=怪盗天才
//TEXT=<b>战吼：</b>消灭一个友方随从，随机将两张<b>跟班</b>牌置入你的手牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DAL_607:MinionBase{
//NAME=邪能领主贝图格
//TEXT=每当你抽到一张随从牌，召唤一个它的复制。该复制具有<b>突袭</b>，并会在回合结束时死亡。
//MAJ=WARLOCK|COST=8|ATK=5|HP=7|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Minion && sz==ZoneType.Deck && tz==ZoneType.Hand)
			{
				Card CreatedCard=TaskCreate(sc.cardDbf,ZoneType.Board);
				new EffectGiveAbility(owner.myPlayer,owner,CreatedCard,"Rush");
				new EffectGiveAbility(owner.myPlayer,owner,CreatedCard,"DieAfterTurnEnd");
			}	
		}
	}
}
public class DAL_607e:Ability{
//NAME=滚滚邪能
//TEXT=<b>突袭</b>。在回合结束时死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_608:SpellBase{
//NAME=魔术戏法
//TEXT=<b>发现</b>一张法力值消耗小于或等于（3）点的法术牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DAL_609:MinionBase{
//NAME=卡雷苟斯
//TEXT=你每个回合使用的第一张法术牌的法力值消耗为（0）点。<b>战吼：</b><b>发现</b>一张法术牌。
//MAJ=MAGE|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class DAL_609e:Ability{
//NAME=Aspect's Magic
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_613:MinionBase{
//NAME=无面跟班
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_614:MinionBase{
//NAME=狗头人跟班
//TEXT=<b>战吼：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_615:MinionBase{
//NAME=女巫跟班
//TEXT=<b>战吼：</b>将一个友方随从变形成为一个法力值消耗增加（1）点的随从。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_710:SpellBase{
//NAME=鱼人之魂
//TEXT=使你的所有随从获得“<b>亡语：</b>召唤一个1/1的鱼人。”
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_710e:Ability{
//NAME=鱼人之魂
//TEXT=<b>亡语：</b>召唤一个1/1的鱼人。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_714:MinionBase{
//NAME=下水道销赃人
//TEXT=<b>战吼：</b>如果你手牌中有另一职业的卡牌，则获得+1/+1和<b>突袭</b>。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DAL_714e:Ability{
//NAME=街头智慧
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_716:SpellBase{
//NAME=宿敌
//TEXT=对一个随从造成$4点伤害。如果你的手牌中有另一职业的卡牌，则法力值消耗为（0）点。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DAL_719:MinionBase{
//NAME=塔克·诺兹维克
//TEXT=每当你将一张牌洗入你的牌库时，将该牌的一张复制置入你的 手牌。
//MAJ=ROGUE|COST=7|ATK=6|HP=6|RACE=NONE
}
public class DAL_720:WeaponBase{
//NAME=摇摆矿锄
//TEXT=<b>亡语：</b>随机将一个友方随从移回你的手牌。它的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=4|ATK=4|HP=2|RACE=NONE
}
public class DAL_721:MinionBase{
//NAME=亡者卡特琳娜
//TEXT=在你的回合结束时，复活另一个友方亡灵随从。
//MAJ=PRIEST|COST=7|ATK=6|HP=8|RACE=UNDEAD
}
public class DAL_723:SpellBase{
//NAME=禁忌咒文
//TEXT=消耗你所有的法力值。消灭一个攻击力小于或等于所消耗法力值的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class DAL_724:SpellBase{
//NAME=群体复活
//TEXT=召唤三个在本局对战中死亡的友方随从。
//MAJ=PRIEST|COST=9|ATK=0|HP=0|RACE=HOLY
}
public class DAL_726:MinionBase{
//NAME=斯卡基尔
//TEXT=你的鱼人法力值消耗为（1）点。
//MAJ=SHAMAN|COST=5|ATK=4|HP=4|RACE=MURLOC
}
public class DAL_726e:Ability{
//NAME=斯卡基尔的祝福
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_727:SpellBase{
//NAME=冒险号角
//TEXT=从你的牌库中抽取法力值消耗最低的随从牌，使其获得+2/+2。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DAL_727e:Ability{
//NAME=雄姿英发
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_728:SpellBase{
//NAME=战略转移
//TEXT=将所有友方随从移回你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_729:MinionBase{
//NAME=拉祖尔女士
//TEXT=<b>战吼：</b><b>发现</b>一张你的对手手牌的复制。
//MAJ=PRIEST|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DAL_731:SpellBase{
//NAME=决斗
//TEXT=从每个玩家的牌库中各召唤一个随从，并使其互相 攻击！
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DAL_732:MinionBase{
//NAME=守护者斯塔拉蒂斯
//TEXT=在你施放了一个<b>抉择</b>法术后，将每个选项的复制置入你的手牌。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DAL_733:SpellBase{
//NAME=守卫梦境之路
//TEXT=召唤两个1/2并具有<b>吸血</b>的 树妖。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DAL_733t:MinionBase{
//NAME=水晶树妖
//TEXT=<b>吸血</b>
//MAJ=DRUID|COST=1|ATK=1|HP=2|RACE=NONE
}
public class DAL_735:MinionBase{
//NAME=达拉然图书管理员
//TEXT=<b>战吼：</b> <b>沉默</b>相邻的随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DAL_736:MinionBase{
//NAME=档案员艾丽西娜
//TEXT=<b>战吼：</b><b>发现</b>五张卡牌，将你牌库里的所有卡牌替换成每张卡牌的两张复制。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class DAL_739:MinionBase{
//NAME=地精跟班
//TEXT=<b>战吼：</b> 使一个友方随从获得+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_739e:Ability{
//NAME=超短引线
//TEXT=+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_741:MinionBase{
//NAME=虚灵跟班
//TEXT=<b>战吼：</b> <b>发现</b>一张法术牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DAL_742:MinionBase{
//NAME=暴走旋风
//TEXT=你的<b>风怒</b>随从拥有<b>超级风怒</b>。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=ELEMENTAL
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.HasAbility("WindFury") &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "WindFuryPro";
    }
}

public class DAL_742e:Ability{
//NAME=旋风冲锋
//TEXT=<b>超级风怒</b>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_743:MinionBase{
//NAME=荆棘帮斗猪
//TEXT=<b>突袭，亡语：</b>召唤一个1/1的鱼人。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class DAL_743t:MinionBase{
//NAME=荆棘帮马仔
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class DAL_744:MinionBase{
//NAME=无面暴怒者
//TEXT=<b>战吼：</b>复制一个友方随从的生命值。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=NONE
}
public class DAL_744e:Ability{
//NAME=熟谙脉络
//TEXT=复制了生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_747:MinionBase{
//NAME=飞行管理员
//TEXT=<b>战吼：</b>为每个玩家召唤一只2/2的狮鹫。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class DAL_747t:MinionBase{
//NAME=狮鹫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class DAL_748:MinionBase{
//NAME=法力之池
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=6|RACE=ELEMENTAL
}
public class DAL_749:MinionBase{
//NAME=再生大盗
//TEXT=<b>亡语：</b>如果本随从的攻击力大于或等于4，则再次召唤本随从。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class DAL_751:MinionBase{
//NAME=疯狂召唤师
//TEXT=<b>战吼：</b>用1/1的小鬼填满每个玩家的面板。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=DEMON
}
public class DAL_751t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class DAL_752:MinionBase{
//NAME=耶比托·乔巴斯
//TEXT=<b>战吼：</b>从你的牌库中抽两张随从牌。将其攻击力，生命值和法力值消耗变为1。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		Card Drawn1 = FindType(owner.myPlayer.deck,CardType.Minion).Choice(owner.myPlayer.randomGen);
		if(Drawn1!=null)
		{
			TaskDraw(Drawn1);
			new EffectChange(owner.myPlayer,owner,Drawn1,atkChange:1-Drawn1.GetTag(GameTag.Attack),hpChange:1-Drawn1.GetTag(GameTag.Health),manaChange:1-Drawn1.GetTag(GameTag.Mana)).Resolve();
		}
		Card Drawn2 = FindType(owner.myPlayer.deck,CardType.Minion).Choice(owner.myPlayer.randomGen);
		if(Drawn2!=null)
		{
			TaskDraw(Drawn2);
			new EffectChange(owner.myPlayer,owner,Drawn2,atkChange:1-Drawn2.GetTag(GameTag.Attack),hpChange:1-Drawn2.GetTag(GameTag.Health),manaChange:1-Drawn2.GetTag(GameTag.Mana)).Resolve();
		}

	}
}
public class DAL_752e:Ability{
//NAME=玩具模型
//TEXT=耶比托·乔巴斯把它变成了1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_752e2:Ability{
//NAME=大甩卖
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_759:MinionBase{
//NAME=凶恶的废钢猎犬
//TEXT=每当本随从造成伤害时，获得等量的 护甲值。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class DAL_760:MinionBase{
//NAME=推土壮汉
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=9|ATK=9|HP=9|RACE=NONE
}
public class DAL_769:SpellBase{
//NAME=提振士气
//TEXT=对一个随从造成$1点伤害。如果它依然存活，则将一张<b>跟班</b>牌置入你的手牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DAL_770:MinionBase{
//NAME=欧米茄毁灭者
//TEXT=<b>战吼：</b>如果你有十个法力水晶，对一个随从造成10点伤害。
//MAJ=WARRIOR|COST=4|ATK=4|HP=5|RACE=MECHANICAL
}
public class DAL_771:MinionBase{
//NAME=散财军士
//TEXT=每当本随从攻击时，使你的对手获得一张幸运币。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=ELEMENTAL
}
public class DAL_773:MinionBase{
//NAME=魔法飞毯
//TEXT=在你使用一张法力值消耗为（1）的随从牌后，使其获得+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=6|RACE=NONE
}
public class DAL_773e:Ability{
//NAME=飞得更高
//TEXT=+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DAL_774:MinionBase{
//NAME=特殊坐骑商人
//TEXT=每当你施放一个法术，随机召唤一个法力值消耗为（3）的 野兽。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=8|RACE=NONE
}
public class DAL_775:MinionBase{
//NAME=坑道爆破师
//TEXT=<b>嘲讽，亡语：</b>对所有随从造成3点伤害。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=7|RACE=NONE
}
public class DAL_799:MinionBase{
//NAME=晶角雄鹿
//TEXT=<b>突袭</b>。<b>战吼：</b>在本局对战中，如果你累计恢复了5点生命值，则召唤一个本随从的复制。@<i>（还剩下{0}点！）</i>@<i>（已经就绪！）</i>
//MAJ=DRUID|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class DAL_800:MinionBase{
//NAME=泽尔，暗影斗篷
//TEXT=你改用泽尔的一副怪盗套牌来开始对战！
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DAL_800h:HeroBase{
//NAME=泽尔，暗影斗篷
//TEXT=
//MAJ=WHIZBANG|COST=0|ATK=0|HP=30|RACE=NONE
}
public class DAL_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
