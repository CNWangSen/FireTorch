using System.Collections;
using System.Collections.Generic;

public class SCH_120:MinionBase{
//NAME=秘教侍僧
//TEXT=<b>嘲讽，法术迸发：</b>随机获得一个攻击力小于或等于2的敌方随从的控制权。
//MAJ=PRIEST|COST=4|ATK=2|HP=6|RACE=NONE
}
public class SCH_126:MinionBase{
//NAME=教导主任加丁
//TEXT=在你使用一张随从牌后，将其消灭并召唤一个4/4的挂掉的 学生。
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=NONE
}
public class SCH_126t:MinionBase{
//NAME=挂掉的学生
//TEXT=
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class SCH_133:MinionBase{
//NAME=鹿角小飞兔
//TEXT=<b>战吼：</b>召唤一个本随从的复制。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
	public override void Battlecry(Card target=null)
	{
		TaskCreate(owner.cardDbf,ZoneType.Board);
	}
}
public class SCH_135:MinionBase{
//NAME=终身教授图拉扬
//TEXT=<b>突袭</b> 每当其攻击一个随从，将目标的攻击力和生命值变为3。
//MAJ=PALADIN|COST=8|ATK=3|HP=12|RACE=NONE
}
public class SCH_135e:Ability{
//NAME=受教
//TEXT=3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_136:SpellBase{
//NAME=真言术：宴
//TEXT=使一个随从获得+2/+2。在本回合结束时，使其恢复所有生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class SCH_136e:Ability{
//NAME=真言术：宴
//TEXT=+2/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_136e2:Ability{
//NAME=饥不可耐
//TEXT=在本回合结束时恢复所有生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_137:MinionBase{
//NAME=疲倦的大一新生
//TEXT=
//MAJ=PRIEST|COST=1|ATK=1|HP=4|RACE=NONE
}
public class SCH_138:SpellBase{
//NAME=威能祝福
//TEXT=使一个随从获得+8/+8，在本回合中无法攻击英雄。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class SCH_138e:Ability{
//NAME=威能祝福
//TEXT=+8/+8。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_138e2:Ability{
//NAME=崇高意图
//TEXT=在本回合中无法攻击英雄。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_139:MinionBase{
//NAME=虔诚的学徒
//TEXT=<b>圣盾，嘲讽</b> 在本局对战中，你每对友方角色施放一个法术，本牌的法力值消耗便减少 （1）点。
//MAJ=PALADIN|COST=6|ATK=4|HP=5|RACE=NONE
}
public class SCH_140:MinionBase{
//NAME=血肉巨人
//TEXT=你的英雄的生命值每在你的回合中变化一次，本牌的法力值消耗便减少（1）点。
//MAJ=PRIEST|COST=10|ATK=8|HP=8|RACE=UNDEAD
}
public class SCH_141:MinionBase{
//NAME=高阶修士奥露拉
//TEXT=<b>法术迸发：</b>从你的牌库中施放一张法术牌<i>（尽可能以本随从为目标）</i>。
//MAJ=PALADIN|COST=4|ATK=3|HP=6|RACE=NONE
}
public class SCH_142:MinionBase{
//NAME=贪婪的书虫
//TEXT=在你的回合结束时，抽若干牌，直至手牌数量达到3张。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			while(true)
			{
				if(owner.myPlayer.hand.Count>=3 || owner.myPlayer.deck.Count==0)
				{
					break;
				}
				TaskDraw();
			}
		}
	}
}
public class SCH_143:MinionBase{
//NAME=神圣暴怒者
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=1|RACE=ELEMENTAL
}
public class SCH_145:MinionBase{
//NAME=课桌小鬼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=DEMON
}
public class SCH_146:MinionBase{
//NAME=防护长袍
//TEXT=你的随从拥有<b>扰魔</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class SCH_146e:Ability{
//NAME=受到保护
//TEXT=防护长袍使其获得<b>扰魔</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_147:MinionBase{
//NAME=骨网之卵
//TEXT=<b>亡语：</b>召唤两只2/1的蜘蛛。如果你弃掉这张牌，触发其<b>亡语</b>。
//MAJ=WARLOCK|COST=2|ATK=0|HP=2|RACE=NONE
}
public class SCH_147t:MinionBase{
//NAME=骨网蜘蛛
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class SCH_149:MinionBase{
//NAME=银色自大狂
//TEXT=<b>战吼：</b>将本随从的攻击力与生命值分别变为与战场上最高的数值相同。
//MAJ=PALADIN|COST=2|ATK=1|HP=1|RACE=NONE
}
public class SCH_149e:Ability{
//NAME=超凡绝顶
//TEXT=属性值提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_157:MinionBase{
//NAME=魔化大锅
//TEXT=<b>法术迸发：</b>随机施放一个法力值消耗相同的法术。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=6|RACE=NONE
}
public class SCH_158:SpellBase{
//NAME=恶魔研习
//TEXT=<b>发现</b>一张恶魔牌。你的下一张恶魔牌法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class SCH_158e:Ability{
//NAME=恶魔研习
//TEXT=你的下一张恶魔牌法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_158e2:Ability{
//NAME=研习恶魔
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_159:MinionBase{
//NAME=裂心者伊露希亚
//TEXT=<b>战吼：</b>直到回合结束，将你的手牌替换成对手手牌的复制。
//MAJ=PRIEST|COST=3|ATK=1|HP=3|RACE=NONE
}
public class SCH_159e:Ability{
//NAME=心智裂换
//TEXT=在你的回合开始时，交换双方玩家的手牌和牌库。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_159e2:Ability{
//NAME=心智裂换
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_160:MinionBase{
//NAME=魔杖工匠
//TEXT=<b>战吼：</b>随机将一张你职业的法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_162:MinionBase{
//NAME=维克图斯
//TEXT=<b>战吼：</b>召唤两条1/1的雏龙。每条雏龙获得一个本局对战中死亡的友方随从的<b>亡语</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class SCH_162e:Ability{
//NAME=实验魔药
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_162t:MinionBase{
//NAME=魔药龙崽
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DRAGON
}
public class SCH_181:MinionBase{
//NAME=高阶女巫维洛
//TEXT=<b>战吼：</b>随机从你的手牌和牌库中召唤一个恶魔。
//MAJ=WARLOCK|COST=8|ATK=5|HP=5|RACE=NONE
}
public class SCH_182:MinionBase{
//NAME=演讲者吉德拉
//TEXT=<b>突袭，风怒</b> <b>法术迸发：</b>获得等同于法术法力值消耗的攻击力和生命值。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class SCH_182e:Ability{
//NAME=口才出众
//TEXT=属性值提高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199:MinionBase{
//NAME=转校生
//TEXT=根据你当前的 对战面板，拥有不同的效果。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t:MinionBase{
//NAME=转校生
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t10:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b> 消耗你所有的法力值，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t11:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>将一张<b>卡拉赞</b>传送门法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t12:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t12e:Ability{
//NAME=加基森的补给
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199t13:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>进化</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t14:MinionBase{
//NAME=转校生
//TEXT=<b>亡语：</b>随机将一张<b>巫妖王</b>牌置入你的 手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t15:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>招募</b>一个法力值消耗小于或等于（2）点的随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t16:MinionBase{
//NAME=转校生
//TEXT=<b>回响，突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t17:MinionBase{
//NAME=转校生
//TEXT=<b>嘲讽，战吼：</b>如果你有十个法力水晶，获得+5/+5。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t17e:Ability{
//NAME=欧米茄转换
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199t18:MinionBase{
//NAME=转校生
//TEXT=<b>突袭，超杀</b>：抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t19:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t2:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t20:MinionBase{
//NAME=转校生
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t21:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b> <b>发现</b>一张龙牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t22:MinionBase{
//NAME=转校生
//TEXT=<b>休眠</b>2回合。唤醒时，随机对两个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t23:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>将一张双职业卡牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t24:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>随机将一张武器牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t25:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>将一张<b>奥丹姆</b>灾祸法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t26:MinionBase{
//NAME=转校生
//TEXT=<b>腐蚀：</b>获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t26t:MinionBase{
//NAME=转校生
//TEXT=<b>已腐蚀</b>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NONE
}
public class SCH_199t27:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b> 随机将一张具有等级的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t28:MinionBase{
//NAME=转校生
//TEXT=<b>可交易</b> <b>战吼：</b>使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t29:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>造成1点伤害。<b>荣誉消灭：</b>获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t29e:Ability{
//NAME=奥特兰克补给
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199t3:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t30:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>沉没之城</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t31:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>纳斯利亚堡的悬案</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t32:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>巫妖王的进军</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t33:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>传奇音乐节</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t34:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>泰坦诸神</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t35:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>决战荒芜之地</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t36:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：</b><b>发现</b>一张<b>威兹班的工坊</b>卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t3e:Ability{
//NAME=熊猫人之印
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199t4:MinionBase{
//NAME=转校生
//TEXT=<b>潜行</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t5:MinionBase{
//NAME=转校生
//TEXT=<b>亡语：</b>随机将一个具有<b>亡语</b>的随从置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t6:MinionBase{
//NAME=转校生
//TEXT=<b>战吼，亡语：</b> 将一张<b>零件</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t7:MinionBase{
//NAME=转校生
//TEXT=在你的回合结束时，随机使你的一张手牌法力值消耗减少 （2）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t7e:Ability{
//NAME=能量转换
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_199t8:MinionBase{
//NAME=转校生
//TEXT=<b>激励：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_199t9:MinionBase{
//NAME=转校生
//TEXT=<b>战吼：发现</b>一个新的基础英雄技能。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SCH_224:MinionBase{
//NAME=校长克尔苏加德
//TEXT=<b>法术迸发：</b>如果法术消灭了任意随从，召唤被消灭的随从。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class SCH_224e3:Ability{
//NAME=克尔苏加德的召唤
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_224t:MinionBase{
//NAME=比格沃斯先生
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class SCH_230:MinionBase{
//NAME=黑岩法术抄写员
//TEXT=<b>法术迸发：</b>随机将两张你职业的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=9|RACE=DRAGON
}
public class SCH_231:MinionBase{
//NAME=新生刺头
//TEXT=<b>法术迸发：</b>获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class SCH_231e:Ability{
//NAME=准备上学
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_232:MinionBase{
//NAME=赤红急先锋
//TEXT=<b>法术迸发：</b>获得+1攻击力和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=DRAGON
}
public class SCH_232e:Ability{
//NAME=热力迸发
//TEXT=+1攻击力并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_233:SpellBase{
//NAME=龙族研习
//TEXT=<b>发现</b>一张龙牌。你的下一张龙牌法力值消耗减少（1）点。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_233e:Ability{
//NAME=龙族研习
//TEXT=你的下一张龙牌的法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_233e2:Ability{
//NAME=研习巨龙
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_234:MinionBase{
//NAME=调皮的大二学妹
//TEXT=<b>潜行，法术迸发：</b>将一张<b>连击</b>牌置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class SCH_235:SpellBase{
//NAME=衰变飞弹
//TEXT=随机向敌方随从发射三枚飞弹，使其变形成为法力值消耗减少（1）点的随从。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class SCH_236:MinionBase{
//NAME=笔记能手
//TEXT=<b>法术迸发：</b>将法术牌移回你的手牌。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class SCH_237:SpellBase{
//NAME=体能研习
//TEXT=<b>发现</b>一张<b>突袭</b>随从牌。你的下一张<b>突袭</b>随从牌法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_237e:Ability{
//NAME=体能研习
//TEXT=你的下一张<b>突袭</b>随从牌法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_237e2:Ability{
//NAME=研习体能
//TEXT=法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_238:WeaponBase{
//NAME=收割之镰
//TEXT=<b>法术迸发：</b>在本回合中同时对攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=4|ATK=4|HP=2|RACE=NONE
}
public class SCH_238e:Ability{
//NAME=收割
//TEXT=对攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_239:MinionBase{
//NAME=裂树三叶虫
//TEXT=<b>法术迸发：</b>随机消灭一个敌方随从。
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class SCH_241:MinionBase{
//NAME=火印火妖
//TEXT=<b>法术迸发：</b>造成4点伤害，随机分配到所有敌方随从身上。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class SCH_242:MinionBase{
//NAME=聒噪怪
//TEXT=<b>法术迸发：</b>召唤一个聒噪怪。
//MAJ=DRUID|COST=2|ATK=1|HP=1|RACE=NONE
}
public class SCH_243:MinionBase{
//NAME=浮龙培养师
//TEXT=<b><b>法术迸发</b>：</b>召唤两条1/3的法力浮龙。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class SCH_244:MinionBase{
//NAME=教师的爱宠
//TEXT=<b>嘲讽，亡语：</b>随机召唤一只法力值消耗为（3）的野兽。
//MAJ=HUNTER|COST=5|ATK=4|HP=5|RACE=BEAST
}
public class SCH_245:MinionBase{
//NAME=卷轴管理者
//TEXT=<b>法术伤害+1</b> <b>战吼：</b><b>发现</b>一张法术牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=ELEMENTAL
}
public class SCH_247:SpellBase{
//NAME=新生入学
//TEXT=随机将两张法力值消耗为（1）的随从牌置入你的手牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_248:MinionBase{
//NAME=甩笔侏儒
//TEXT=<b>战吼：</b>对一个随从造成1点伤害。<b>法术迸发：</b>将本随从移回你的 手牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class SCH_250:SpellBase{
//NAME=倦怠光波
//TEXT=直到你的下个回合，将所有敌方随从的攻击力变为1点。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_250e:Ability{
//NAME=怠惰不堪
//TEXT=直到下个回合，攻击力变为1点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_252:WeaponBase{
//NAME=切髓之刃
//TEXT=<b>战吼：</b>将两张灵魂残片洗入你的 牌库。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class SCH_253:SpellBase{
//NAME=仇恨之轮
//TEXT=对所有随从造成$3点伤害。每消灭一个随从，召唤一个3/3的怨魂。
//MAJ=DEMONHUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class SCH_253t:MinionBase{
//NAME=复仇怨魂
//TEXT=
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class SCH_259:WeaponBase{
//NAME=感知宝珠
//TEXT=在你的回合开始时，检视你牌库顶的卡牌。你可以将其置于牌库底，并失去1点耐久度。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=NONE
}
public class SCH_259t:SpellBase{
//NAME=新的命运
//TEXT=另抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_270:SpellBase{
//NAME=始生研习
//TEXT=<b>发现</b>一张<b>法术伤害</b>随从牌。你的下一张<b>法术伤害</b>随从牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class SCH_270e:Ability{
//NAME=符文研习
//TEXT=你的下一张<b>法术伤害</b>随从牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_270e2:Ability{
//NAME=研习符文
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_271:SpellBase{
//NAME=岩浆爆裂
//TEXT=造成$2点伤害，召唤相同数量的1/1的元素。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class SCH_271t:MinionBase{
//NAME=熔岩元素
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class SCH_273:MinionBase{
//NAME=莱斯·霜语
//TEXT=在你的回合结束时，对所有敌人造成$1点伤害<i>（受<b>法术伤害</b>加成影响）</i>。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class SCH_276:MinionBase{
//NAME=法师猎手
//TEXT=<b>突袭</b> 每当本随从攻击一个随从时，将其<b>沉默</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=3|RACE=NONE
}
public class SCH_279:WeaponBase{
//NAME=引月长弓
//TEXT=在你的英雄攻击一个随从后，你的所有随从也会攻击该随从。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=4|RACE=NONE
}
public class SCH_283:MinionBase{
//NAME=食魔影豹
//TEXT=<b>战吼：</b>在本回合中，如果你使用过你的英雄技能，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class SCH_300:SpellBase{
//NAME=腐食研习
//TEXT=<b>发现</b>一张<b>亡语</b>随从牌。你的下一张<b>亡语</b>随从牌法力值消耗减少（1）点。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_300e:Ability{
//NAME=腐食研习
//TEXT=你的下一张<b>亡语</b>随从牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_300e2:Ability{
//NAME=研习腐食
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_301:WeaponBase{
//NAME=符文匕首
//TEXT=在你的英雄攻击后，在本回合中获得<b>法术伤害+1</b>。
//MAJ=SHAMAN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class SCH_301e:Ability{
//NAME=符文能量
//TEXT=你在本回合中拥有<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_302:SpellBase{
//NAME=流光之赐
//TEXT=使一个随从获得<b>圣盾</b>，并召唤一个1/1的复制。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class SCH_302e:Ability{
//NAME=圣光的学生
//TEXT=1/1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_305:SpellBase{
//NAME=秘密通道
//TEXT=将你的手牌替换为你牌库中的4张牌。下回合换回。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
	private bool Used = false;
	private List<Card> Remembered = new List<Card>();
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEvent));
	}
	public override void Battlecry(Card target=null)
	{
		Used=true;
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c!=owner)
				Remembered.Add(c);
		}
		foreach(Card c in Remembered)
		{
			new EffectMove(owner.myPlayer,c,(ZoneType)c.GetTag(GameTag.ZoneType),ZoneType.Aside).Resolve();
		}
	}
	public void CauseEvent()
	{
		if(Used)
		{
			foreach(Card c in Remembered)
			{
				new EffectMove(owner.myPlayer,c,(ZoneType)c.GetTag(GameTag.ZoneType),ZoneType.Hand).Resolve();
			}
			Used=false;
		}
	}

}
public class SCH_305d:SpellBase{
//NAME=Secret Passage Dummy
//TEXT=Dummy Hook Up SCH 305e3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_305e:Ability{
//NAME=秘密出口
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_305e2:Ability{
//NAME=秘密入口
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_305e3:Ability{
//NAME=秘密通道玩家附加效果
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_307:SpellBase{
//NAME=校园精魂
//TEXT=对所有随从造成$2点伤害。将两张灵魂残片洗入你的 牌库。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class SCH_307t:SpellBase{
//NAME=灵魂残片
//TEXT=<b>抽到时施放</b> 为你的英雄恢复#2点生命值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
	public override void Init()
	{
		TaskInitAbility("CastWhenDrawn");
	}
	public override void Battlecry(Card target=null)
	{
		TaskHealMyHero(2);
	}
}
public class SCH_310:MinionBase{
//NAME=研究伙伴
//TEXT=<b>法术伤害+1</b>
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class SCH_311:MinionBase{
//NAME=活化扫帚
//TEXT=<b>突袭，战吼：</b>使你的其他随从获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class SCH_312:MinionBase{
//NAME=巡游向导
//TEXT=<b>战吼：</b> 你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.power.Count>0)
        {
            Card PowCard = owner.myPlayer.power[0];
            PowCard.SetTag(GameTag.ManaFot,-PowCard.GetTag(GameTag.Mana));
            new EffectChange(owner.myPlayer,owner,PowCard).Resolve();
        }
    }
}
public class SCH_312e:Ability{
//NAME=校园观光
//TEXT=你的英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_313:MinionBase{
//NAME=失心辅导员
//TEXT=<b>法术迸发：</b>对所有其他随从造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class SCH_317:MinionBase{
//NAME=团伙核心
//TEXT=在你使用一张<b>突袭</b>随从牌后，召唤一个剩余生命值为1的复制。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class SCH_333:SpellBase{
//NAME=自然研习
//TEXT=<b>发现</b>一张法术牌。你的下一张法术牌法力值消耗减少（1）点。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class SCH_333e:Ability{
//NAME=自然研习
//TEXT=你的下一张法术牌法力值消耗减少（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_333e2:Ability{
//NAME=研习自然
//TEXT=法力值消耗减少（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_337:MinionBase{
//NAME=问题学生
//TEXT=在你的回合结束时，召唤两个3/3的无赖并使其攻击随机敌人。
//MAJ=WARRIOR|COST=8|ATK=6|HP=8|RACE=NONE
}
public class SCH_337t:MinionBase{
//NAME=无赖
//TEXT=
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SCH_340:MinionBase{
//NAME=饱腹巨蟒
//TEXT=<b>亡语：</b>召唤一个4/4的倒霉的管理员。
//MAJ=HUNTER|COST=3|ATK=1|HP=2|RACE=BEAST
}
public class SCH_340t:MinionBase{
//NAME=倒霉的管理员
//TEXT=
//MAJ=HUNTER|COST=4|ATK=4|HP=4|RACE=NONE
}
public class SCH_343:MinionBase{
//NAME=虚空吸食者
//TEXT=<b>嘲讽，战吼：</b>摧毁一张你牌库中的灵魂残片，获得+3/+3。
//MAJ=WARLOCK|COST=5|ATK=4|HP=5|RACE=DEMON
}
public class SCH_343e:Ability{
//NAME=灵魂供能
//TEXT=+3/+3。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_348:SpellBase{
//NAME=燃烧
//TEXT=对一个随从造成$4点伤害，相邻的随从均会受到超过其生命值的伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class SCH_350:MinionBase{
//NAME=魔杖窃贼
//TEXT=<b>连击：</b><b>发现</b>一张法师法术牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class SCH_351:MinionBase{
//NAME=詹迪斯·巴罗夫
//TEXT=<b>战吼：</b>召唤两个法力值消耗为（5）的随从。秘密选择其中一个，使其在受到伤害时死亡。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=1|RACE=NONE
}
public class SCH_351a:Ability{
//NAME=这个是幻象。
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_351b:Ability{
//NAME=这个不是幻象。
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_351e:Ability{
//NAME=幻象
//TEXT=本随从可能是一个会在受到伤害时死亡的幻象。0{0}
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_351e2:Ability{
//NAME=幻象
//TEXT=本随从可能是一个会在受到伤害时死亡的幻象。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_352:SpellBase{
//NAME=幻觉药水
//TEXT=将你的所有随从的1/1的复制置入你的手牌，并使其法力值消耗变为（1）点。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class SCH_352e:Ability{
//NAME=幻觉药水
//TEXT=1/1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_352e2:Ability{
//NAME=幻觉药水
//TEXT=法力值消耗为（1）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_353:SpellBase{
//NAME=考前刷夜
//TEXT=抽$1张牌<i>（受<b>法术伤害</b>加成影响）</i>。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class SCH_354:MinionBase{
//NAME=上古虚空恶犬
//TEXT=在你的回合结束时，从所有敌方随从处偷取1点攻击力和生命值。
//MAJ=DEMONHUNTER|COST=9|ATK=10|HP=10|RACE=DEMON
}
public class SCH_354e:Ability{
//NAME=遭受虹吸
//TEXT=攻击力和生命值降低。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_354e2:Ability{
//NAME=虚空虹吸
//TEXT=攻击力和生命值提高。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_354e2a:Ability{
//NAME=Void Siphon
//TEXT=Increased Attack.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_354e2b:Ability{
//NAME=Void Siphon
//TEXT=Increased Health.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_354ea:Ability{
//NAME=Siphoned
//TEXT=Reduced Attack.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_354eb:Ability{
//NAME=Siphoned
//TEXT=Reduced Health.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_355:MinionBase{
//NAME=残片震爆秘术师
//TEXT=<b>战吼：</b>摧毁一张你牌库中的灵魂残片，对所有其他随从造成3点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class SCH_356:SpellBase{
//NAME=滑翔
//TEXT=将你的手牌洗入你的牌库，抽四张牌。<b>流放：</b>使你的对手做出相同行为。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class SCH_357:SpellBase{
//NAME=邪能护卫
//TEXT=召唤三个1/2并具有<b>嘲讽</b>的恶魔。每当一个友方随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=DEMONHUNTER|COST=7|ATK=0|HP=0|RACE=FEL
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_357t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_357t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_357t"),ZoneType.Board);
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc.myPlayer==owner.myPlayer && sz==ZoneType.Board && tz==ZoneType.Grave)
		{
			new EffectChange(owner.myPlayer,owner,owner,manaChange:-1).Resolve();
		}
	}
}
public class SCH_357e:Ability{
//NAME=灌注灵魂
//TEXT=法力值消耗减少。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_357t:MinionBase{
//NAME=食魂地狱犬
//TEXT=<b>嘲讽</b>
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=2|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class SCH_400:MinionBase{
//NAME=决斗大师莫扎奇
//TEXT=在你施放一个法术后，获得<b>法术伤害+1</b>。
//MAJ=MAGE|COST=5|ATK=3|HP=8|RACE=NONE
}
public class SCH_400e2:Ability{
//NAME=魔法大师
//TEXT=<b>法术伤害+1</b>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_422:SpellBase{
//NAME=二段跳
//TEXT=从你的牌库中抽一张<b>流放</b>牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_425:MinionBase{
//NAME=卡斯迪诺夫教授
//TEXT=<b>突袭</b> 每当本随从攻击时，使你的武器获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class SCH_425e:Ability{
//NAME=锐利
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_426:MinionBase{
//NAME=渗透者莉莉安
//TEXT=<b>潜行，亡语：</b>召唤一个4/2的被遗忘者莉莉安，并使其随机攻击一个敌人。
//MAJ=ROGUE|COST=4|ATK=4|HP=2|RACE=NONE
	public override void Deathrattle()
	{
		Card Summoned = TaskCreate(CardDbf.GetCardDbfByGuid("SCH_426t"),ZoneType.Board);
		if(Summoned!=null)
		{
			Card ToAttack = owner.myPlayer.GetValidTargetMatchOption(TargetingOptions.OpposingCharacters).Choice(owner.myPlayer.randomGen);
			if(ToAttack!=null)
			{
				new EffectAttack(owner.myPlayer,Summoned,ToAttack).Resolve();
			}
		}
	}
}
public class SCH_426t:MinionBase{
//NAME=被遗忘者莉莉安
//TEXT=
//MAJ=ROGUE|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class SCH_427:SpellBase{
//NAME=雷霆绽放
//TEXT=复原两个法力水晶。<b>过载：</b>（2）
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,2);
		TaskBuffMyHero();
	}
}
public class SCH_428:MinionBase{
//NAME=博学者普克尔特
//TEXT=<b>战吼：</b>将你的牌库按法力值消耗由高到低重新排序。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class SCH_507:MinionBase{
//NAME=导师火心
//TEXT=<b>战吼：</b><b>发现</b>一张法力值消耗大于或等于（1）点的法术牌。如果你在本回合使用这张法术牌，重复此效果。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SCH_507e:Ability{
//NAME=炽热连击！
//TEXT=如果在本回合使用，<b>发现</b>另一张法术牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_509:SpellBase{
//NAME=冰冷智慧
//TEXT=<b>冻结</b>一个随从。<b>连击：</b>并对其造成$3点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=FROST
}
public class SCH_512:SpellBase{
//NAME=通窍
//TEXT=对一个随从造成$4点伤害。如果“通窍”消灭该随从，召唤一个新的复制。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class SCH_513:MinionBase{
//NAME=脆骨破坏者
//TEXT=<b>战吼：</b>在本回合中，如果你的英雄的生命值发生变化，消灭一个随从。
//MAJ=PRIEST|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class SCH_514:SpellBase{
//NAME=亡者复生
//TEXT=对你的英雄造成$3点伤害。将两个在本局对战中死亡的友方随从移回你的手牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		TaskDamageMyHero(3);
		for(int i=0;i<2;i++)
		{
			Card Return = FindType(owner.myPlayer.grave,CardType.Minion).Choice(owner.myPlayer.randomGen);
			if(Return!=null)
				TaskCreate(Return.cardDbf,ZoneType.Hand);
		}
	}
}
public class SCH_517:MinionBase{
//NAME=影光学者
//TEXT=<b>战吼：</b>摧毁一张你牌库中的灵魂残片，造成3点伤害。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=NONE
}
public class SCH_519:MinionBase{
//NAME=狐人淬毒师
//TEXT=你的武器拥有+2攻击力。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SCH_519e:Ability{
//NAME=阿昆达之噬
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_521:SpellBase{
//NAME=胁迫
//TEXT=消灭一个受伤的随从。<b>连击：</b>消灭任意随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(target.GetTag(GameTag.Damage)>0 || CntCombo()>0)
			new EffectDestroy(owner.myPlayer,owner,target).Resolve();
	}
}
public class SCH_522:MinionBase{
//NAME=钢铁舞者
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗等同于你的武器攻击力的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class SCH_523:WeaponBase{
//NAME=仪式重槌
//TEXT=<b>法术迸发：</b>召唤一个属性值等同于法术法力值消耗的并具有<b>嘲讽</b>的学生。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class SCH_523t:MinionBase{
//NAME=仪仗学员
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class SCH_524:SpellBase{
//NAME=荣誉护盾
//TEXT=使一个受伤的随从获得+3攻击力和<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class SCH_524e:Ability{
//NAME=荣誉护盾
//TEXT=+3攻击力并具有<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_525:SpellBase{
//NAME=保持阵型
//TEXT=随机将两张<b>嘲讽</b>随从牌置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class SCH_526:MinionBase{
//NAME=巴罗夫领主
//TEXT=<b>战吼：</b>将所有其他随从的生命值变为1。<b>亡语：</b>对所有随从造成1点伤害。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),1);
	}
	public override void Deathrattle()
	{
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
	}
}
public class SCH_526e:Ability{
//NAME=平民百姓
//TEXT=生命值变为1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_530:MinionBase{
//NAME=巫术替身
//TEXT=<b>战吼：</b>如果你拥有<b>法术伤害</b>，召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class SCH_532:MinionBase{
//NAME=双盾优等生
//TEXT=<b>圣盾，法术迸发：</b>获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=NONE
}
public class SCH_533:SpellBase{
//NAME=毕业仪式
//TEXT=从你的牌库中召唤一个随从。使其获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class SCH_533e:Ability{
//NAME=顺利毕业
//TEXT=<b>嘲讽，圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_535:SpellBase{
//NAME=潮汐奔涌
//TEXT=<b>吸血</b> 对所有随从造成 $3点伤害。
//MAJ=SHAMAN|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class SCH_537:MinionBase{
//NAME=戏法图腾
//TEXT=在你的回合结束时，随机施放一个法力值消耗小于或等于（3）点的法术。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class SCH_538:MinionBase{
//NAME=金牌猎手克里
//TEXT=你的其他角色在攻击时<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=4|RACE=NONE
}
public class SCH_538e:Ability{
//NAME=金牌猎手特训
//TEXT=在攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_539:MinionBase{
//NAME=斯雷特教授
//TEXT=你的法术具有<b>剧毒</b>。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class SCH_539e:Ability{
//NAME=教授的剧毒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_600:SpellBase{
//NAME=恶魔伙伴
//TEXT=随机召唤一个恶魔伙伴。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListSummon = new List<string>(){"SCH_600t1","SCH_600t2","SCH_600t3"};
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid(ToListSummon.Choice(owner.myPlayer.randomGen));
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class SCH_600t1:MinionBase{
//NAME=弗霍
//TEXT=<b>冲锋</b>
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=1|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class SCH_600t2:MinionBase{
//NAME=莎米
//TEXT=<b>嘲讽</b>
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=2|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class SCH_600t3:MinionBase{
//NAME=克欧雷
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=2|RACE=DEMON
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "SCH_600t3e";
    }
}
public class SCH_600t3e:Ability{
//NAME=克欧雷的呼喊
//TEXT=克欧雷使本随从获得+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 1;
        }
        return 0;
    }
}
public class SCH_603:MinionBase{
//NAME=明星学员斯特里娜
//TEXT=<b>流放：</b>检视你对手的三张手牌。将其中一张洗入对手的牌库。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class SCH_604:SpellBase{
//NAME=数量压制
//TEXT=对一个随从造成$2点伤害。你每控制一只野兽，便多造成一点伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		int Num=0;
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Beast))
			{
				Num+=1;
			}
		}
		new EffectDamage(owner.myPlayer,owner,target,Num+2).Resolve();
	}
}
public class SCH_605:MinionBase{
//NAME=止水湖蛇颈龙
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class SCH_606:SpellBase{
//NAME=分配组员
//TEXT=随机将法力值消耗为（2）和（3）的野兽牌各一张置入你的手牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_607:MinionBase{
//NAME=大导师野爪
//TEXT=<b>抉择：</b>使你牌库中的所有野兽牌获得+1/+1；或者变形成为一只友方野兽的复制。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SCH_607a:SpellBase{
//NAME=拟态变形
//TEXT=变形成为一只友方野兽的复制。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SCH_607b:SpellBase{
//NAME=唤起兽群
//TEXT=使你牌库中的所有野兽牌获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SCH_607e:Ability{
//NAME=唤起斗志
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_609:SpellBase{
//NAME=优胜劣汰
//TEXT=使你手牌，牌库和战场上的所有随从获得+4/+4。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
}
public class SCH_609e:Ability{
//NAME=优胜劣汰
//TEXT=+4/+4。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_610:SpellBase{
//NAME=动物保镖
//TEXT=从你的牌库中召唤两只法力值消耗小于或等于（5）点的野兽，并使其获得<b>突袭</b>。
//MAJ=HUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class SCH_612:SpellBase{
//NAME=雕琢符文
//TEXT=<b>抉择：</b>召唤四个2/2的树人图腾；或者<b>过载：</b>（2）召唤四个2/2并具有<b>突袭</b>的树人图腾。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class SCH_612a:SpellBase{
//NAME=呼叫增援
//TEXT=召唤四个2/2的树人图腾。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class SCH_612b:SpellBase{
//NAME=警醒森林
//TEXT=召唤四个2/2并具有<b>突袭</b>的树人图腾。<b>过载：</b>（2）
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class SCH_612t:MinionBase{
//NAME=树人图腾
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=TOTEM
}
public class SCH_613:MinionBase{
//NAME=园地管理员
//TEXT=<b>嘲讽，战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，恢复5点生命值。
//MAJ=DRUID|COST=4|ATK=4|HP=5|RACE=NONE
}
public class SCH_614:MinionBase{
//NAME=林地守护者欧穆
//TEXT=<b>法术迸发：</b>复原你的法力水晶。
//MAJ=DRUID|COST=6|ATK=5|HP=4|RACE=NONE
}
public class SCH_615:MinionBase{
//NAME=图腾巨怪
//TEXT=<b>亡语：</b>召唤全部四种基础图腾。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=TOTEM
}
public class SCH_616:MinionBase{
//NAME=夜行虎
//TEXT=<b>潜行</b> 每当本随从攻击，抽两张牌。
//MAJ=DRUID|COST=5|ATK=5|HP=4|RACE=BEAST
}
public class SCH_617:SpellBase{
//NAME=萌物来袭
//TEXT=使一个随从获得+1/+1。召唤一个1/1的魔鼠宝宝。将一张魔鼠宝宝置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SCH_617e:Ability{
//NAME=可可爱爱
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_617t:MinionBase{
//NAME=魔鼠宝宝
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class SCH_618:MinionBase{
//NAME=嗜血传令官
//TEXT=如果这张牌在你的手牌中，每当一个友方随从死亡，便获得+1/+1。
//MAJ=DEMONHUNTER|COST=5|ATK=1|HP=1|RACE=UNDEAD
}
public class SCH_618e:Ability{
//NAME=无辜者之血
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_621:MinionBase{
//NAME=血骨傀儡
//TEXT=<b>亡语：</b>再次召唤本随从并具有-1/-1。
//MAJ=WARRIOR|COST=9|ATK=9|HP=9|RACE=UNDEAD
}
public class SCH_622:WeaponBase{
//NAME=自砺之锋
//TEXT=在你的英雄攻击后，获得+1攻击力。
//MAJ=ROGUE|COST=3|ATK=1|HP=4|RACE=NONE
}
public class SCH_622e:Ability{
//NAME=磨砺锋刃
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_623:SpellBase{
//NAME=劈砍课程
//TEXT=抽两张牌。你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDraw();
		TaskDraw();
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(owner.myPlayer.weapon.Count>0)
			{
				return -owner.myPlayer.weapon[0].GetTag(GameTag.Attack);
			}
		}
		return 0;
	}
}
public class SCH_700:MinionBase{
//NAME=精魂狱卒
//TEXT=<b>战吼：</b>将两张灵魂残片洗入你的牌库。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_307t"),ZoneType.Deck);
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_307t"),ZoneType.Deck);
	}
}
public class SCH_701:SpellBase{
//NAME=灵魂剥离
//TEXT=对一个随从造成$3点伤害。将两张灵魂残片洗入你的 牌库。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_307t"),ZoneType.Deck);
		TaskCreate(CardDbf.GetCardDbfByGuid("SCH_307t"),ZoneType.Deck);		
	}
}
public class SCH_702:SpellBase{
//NAME=邪能学说
//TEXT=复制你手牌中法力值消耗最低的恶魔牌。<b>流放：</b>使这两张恶魔牌获得+1/+1。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class SCH_702e:Ability{
//NAME=邪说倾向
//TEXT=+1/+1
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_703:MinionBase{
//NAME=灵魂学家玛丽希亚
//TEXT=<b>战吼：</b>你的牌库中每有一张灵魂残片，召唤一个3/3并具有<b>突袭</b>的灵魂。0<i>（召唤0个）</i>
//MAJ=WARLOCK|COST=7|ATK=5|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		int Num=0;
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardDbf.m_noteMiniGuid=="SCH_307t")
			{
				Num+=1;
			}
		}
		for(int i=0;i<Num;i++)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("SCH_703t"),ZoneType.Board);
		}
	}
}
public class SCH_703t:MinionBase{
//NAME=被释放的灵魂
//TEXT=<b>突袭</b>
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class SCH_704:MinionBase{
//NAME=铸魂宝石匠
//TEXT=<b>战吼：</b>摧毁一张你牌库中的灵魂残片，在本回合中使你的英雄获得+5攻击力。
//MAJ=DEMONHUNTER|COST=5|ATK=5|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListDestroy = new List<Card>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardDbf.m_noteMiniGuid=="SCH_307t")
			{
				ToListDestroy.Add(c);
			}
		}
		Card ToDestroy = ToListDestroy.Choice(owner.myPlayer.randomGen);
		if(ToDestroy!=null)
		{
			new EffectMove(owner.myPlayer,ToDestroy,ZoneType.Deck,ZoneType.Grave).Resolve();
			TaskBuffMyHero(atk:5);
		}
	}
}
public class SCH_704e:Ability{
//NAME=灵魂之怒
//TEXT=在本回合中+5攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_705:MinionBase{
//NAME=邪犬训练师
//TEXT=<b>流放：</b>召唤两个1/1的恶魔。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=4|RACE=NONE
}
public class SCH_705t:MinionBase{
//NAME=咆哮的邪犬
//TEXT=
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class SCH_706:SecretBase{
//NAME=抄袭
//TEXT=<b>奥秘：</b>在你对手的回合结束时，将其使用的卡牌的复制置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class SCH_707:MinionBase{
//NAME=鱼人飞骑
//TEXT=<b>突袭，亡语：</b>将一个4/3并具有<b>突袭</b>的幽灵置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MURLOC
}
public class SCH_707t:MinionBase{
//NAME=鬼灵飞骑
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MURLOC
}
public class SCH_708:MinionBase{
//NAME=少年惯偷
//TEXT=<b>潜行，亡语：</b>将一个3/1并具有<b>潜行</b>的幽灵置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=NONE
}
public class SCH_708t:MinionBase{
//NAME=鬼灵惯偷
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=UNDEAD
}
public class SCH_709:MinionBase{
//NAME=浮夸的大四学长
//TEXT=<b>嘲讽，亡语：</b>将一个5/7并具有<b>嘲讽</b>的幽灵置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class SCH_709t:MinionBase{
//NAME=鬼灵学长
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=UNDEAD
}
public class SCH_710:MinionBase{
//NAME=食人魔巫术师
//TEXT=每当你的对手施放一个法术，召唤一个2/2并具有<b>嘲讽</b>的骷髅。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=NONE
}
public class SCH_710t:MinionBase{
//NAME=复活的骷髅
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class SCH_711:MinionBase{
//NAME=魔药始祖龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（7）的随从。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class SCH_712:MinionBase{
//NAME=踏实的大三学姐
//TEXT=<b>吸血</b>
//MAJ=PALADIN|COST=6|ATK=4|HP=9|RACE=NONE
}
public class SCH_713:MinionBase{
//NAME=异教低阶牧师
//TEXT=<b>战吼：</b>下个回合你的对手法术的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		foreach(Card c in owner.myPlayer.otherPlayer.hand.Merge(owner.myPlayer.otherPlayer.board))
		{
			if(c.cardType==CardType.Spell)
			{
				c.ChangeTag(GameTag.ManaFot,1);
			}
		}
	}
}
public class SCH_713e:Ability{
//NAME=遭到戏耍
//TEXT=在本回合中，你的法术法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_713e2:Ability{
//NAME=遭到戏耍
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_714:MinionBase{
//NAME=驯化的雷象
//TEXT=每当使用一张法术牌，本随从会记住法术。<b>亡语：</b>将记住的法术牌洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class SCH_714e:Ability{
//NAME=驯服教育
//TEXT=记住了法术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SCH_717:MinionBase{
//NAME=钥匙专家阿拉巴斯特
//TEXT=每当你的对手抽一张牌时，将一张复制置入你的手牌，其法力值消耗变为（1）点。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=8|RACE=NONE
}
