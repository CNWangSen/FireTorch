using System.Collections;
using System.Collections.Generic;

public class AV_100:MinionBase{
//NAME=德雷克塔尔
//TEXT=<b>战吼：</b>如果本随从的法力值消耗大于你牌库中的所有随从牌，则召唤其中的一个。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class AV_101:MinionBase{
//NAME=洛克霍拉的使者
//TEXT=<b>战吼：</b>抽一张冰霜法术牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class AV_102:MinionBase{
//NAME=冷饮制冰机
//TEXT=<b>亡语：</b>随机<b>冻结</b>两个敌方随从。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class AV_107:SpellBase{
//NAME=冰川急冻
//TEXT=<b>发现</b>一张法力值消耗为（8）的随从牌。召唤并<b>冻结</b>该随从。
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=FROST
}
public class AV_108:SpellBase{
//NAME=裂盾一击
//TEXT=对所有随从造成$5点伤害。你每有1点护甲值，本牌的法力值消耗便减少（1）点。
//MAJ=WARRIOR|COST=10|ATK=0|HP=0|RACE=FROST
}
public class AV_109:SpellBase{
//NAME=凝冰护盾
//TEXT=获得10点护甲值。在你的下个回合开始时，失去5点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FROST
}
public class AV_109e:Ability{
//NAME=冰冷
//TEXT=下回合失去5点护甲值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_112:MinionBase{
//NAME=雪盲鹰身人
//TEXT=<b>战吼：</b>如果你的手牌中有冰霜法术牌，便获得5点护甲值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class AV_113:HeroBase{
//NAME=野兽追猎者塔维什
//TEXT=<b>战吼：</b><b>发现</b>并施放两张强化的<b>奥秘</b>牌。
//MAJ=HUNTER|COST=6|ATK=0|HP=30|RACE=NONE
}
public class AV_113p:HeroPowerBase{
//NAME=召唤宠物
//TEXT=召唤一个动物伙伴。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_113t1:SecretBase{
//NAME=强化爆炸陷阱
//TEXT=<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$3点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class AV_113t2:SecretBase{
//NAME=强化冰冻陷阱
//TEXT=<b>奥秘：</b>当一个敌方随从攻击时，将其移回拥有者的手牌，并且法力值消耗增加（4）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FROST
}
public class AV_113t2e:Ability{
//NAME=冰冻
//TEXT=法力值消耗增加（4）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_113t3:SecretBase{
//NAME=强化毒蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤三条2/2的蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_113t3t2:MinionBase{
//NAME=蛇
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class AV_113t7:SecretBase{
//NAME=强化集群战术
//TEXT=<b>奥秘：</b>当一个友方随从受到攻击时，召唤两个该随从的3/3的复制。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_113t8:SecretBase{
//NAME=强化打开兽笼
//TEXT=<b>奥秘：</b>当你的回合开始时，如果你控制着两个随从，召唤两个动物伙伴。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_113t9:SecretBase{
//NAME=强化冰霜陷阱
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，改为将其移回拥有者的手牌，并且法力值消耗增加（2）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FROST
}
public class AV_113t9e:Ability{
//NAME=强能冰霜
//TEXT=法力值消耗增加（2）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_114:MinionBase{
//NAME=战栗的女巫
//TEXT=<b>战吼：</b>使你手牌中法力值消耗最高的法术牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=1|ATK=2|HP=2|RACE=NONE
}
public class AV_114e:Ability{
//NAME=寒颤
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_115:MinionBase{
//NAME=风雪增幅体
//TEXT=<b>战吼：</b> 你的下一个英雄技能法力值消耗为（0）点，并且会<b>冻结</b>目标。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class AV_115e5:Ability{
//NAME=冰寒
//TEXT=你的英雄技能法力值消耗为（0）点，并且会<b>冻结</b>目标。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_116:SpellBase{
//NAME=奥术光辉
//TEXT=将你牌库中法力值消耗为（7），（8），（9）和（10）的法术牌的各一张复制置入你的手牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class AV_118:MinionBase{
//NAME=历战先锋
//TEXT=在你的英雄攻击后，召唤两只1/1的 邪翼蝠。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AV_119:SpellBase{
//NAME=奔赴前线
//TEXT=在本回合中，你的随从牌的法力值消耗减少（2）点<i>（但不能少于1点）</i>。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_119e:Ability{
//NAME=冲向前线
//TEXT=在本回合中，你的随从牌的法力值消耗减少（2）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_121:MinionBase{
//NAME=侏儒列兵
//TEXT=<b>荣誉消灭：</b>获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class AV_121e:Ability{
//NAME=侏儒的荣誉
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_122:MinionBase{
//NAME=下士
//TEXT=<b>荣誉消灭：</b>使你的其他随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AV_123:MinionBase{
//NAME=潜匿斥候
//TEXT=<b>潜行</b>，<b>荣誉消灭：</b> 你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class AV_123e:Ability{
//NAME=探查明了
//TEXT=你的英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_124:MinionBase{
//NAME=恐狼指挥官
//TEXT=<b>荣誉消灭：</b> 召唤一只2/2并具有<b>潜行</b>的狼。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class AV_125:MinionBase{
//NAME=塔楼中士
//TEXT=<b>战吼：</b>如果你控制至少两个其他随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class AV_125e:Ability{
//NAME=铜墙铁壁
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_126:MinionBase{
//NAME=碉堡中士
//TEXT=<b>战吼：</b>如果你的对手拥有2个或者更多随从，对所有敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_127:MinionBase{
//NAME=冰雪亡魂
//TEXT=每当你施放一个冰霜法术，便获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=ELEMENTAL
}
public class AV_127e:Ability{
//NAME=冰霜之魂
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_128:MinionBase{
//NAME=冰封猛犸
//TEXT=<b>被冻结</b>，直到你施放火焰法术。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=7|RACE=BEAST
}
public class AV_128e:Ability{
//NAME=Unthawed
//TEXT=<b>Frozen</b> until you cast a Fire spell.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_129:MinionBase{
//NAME=血卫士
//TEXT=每当本随从受到伤害，使你的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=7|RACE=NONE
}
public class AV_129e:Ability{
//NAME=激奋
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_130:MinionBase{
//NAME=军团士兵
//TEXT=<b>亡语：</b>使你手牌中的所有随从牌获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=9|HP=3|RACE=NONE
}
public class AV_130e:Ability{
//NAME=开拔令
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_131:MinionBase{
//NAME=骑士队长
//TEXT=<b>战吼：</b>造成3点伤害。<b>荣誉消灭：</b>获得+3/+3。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class AV_131e:Ability{
//NAME=全副武装
//TEXT=+3/+3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_132:MinionBase{
//NAME=巨魔百夫长
//TEXT=<b>突袭</b>， <b>荣誉消灭：</b>对敌方英雄造成8点伤害。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
}
public class AV_133:MinionBase{
//NAME=冰蹄护卫
//TEXT=<b>嘲讽</b> <b>冻结</b>任何受到本随从伤害的角色。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=10|RACE=NONE
}
public class AV_134:MinionBase{
//NAME=霜狼将领
//TEXT=在本回合中你每使用过一张牌，本牌的法力值消耗便减少 （1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class AV_135:MinionBase{
//NAME=雷矛元帅
//TEXT=<b>嘲讽</b>。如果你在你对手的回合中受到的伤害大于或等于5点，该牌的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class AV_136:MinionBase{
//NAME=狗头人监工
//TEXT=<b>战吼：</b> 将两张可以使一个随从获得+2生命值的护甲碎片置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_136e:Ability{
//NAME=锈蚀护甲
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_136t:SpellBase{
//NAME=护甲碎片
//TEXT=使一个随从获得+2生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class AV_137:MinionBase{
//NAME=深铁穴居人
//TEXT=在你的对手施放一个法术后，召唤另一个深铁穴居人。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public override void UnRegisterEventEffect()
	{
		owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Spell)
			{
				TaskCreate(owner.cardDbf,ZoneType.Board);
			}
		}
	}
}
public class AV_138:MinionBase{
//NAME=恐怖图腾赏金猎人
//TEXT=<b>战吼：</b>消灭一个敌方<b>传说</b>随从。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
}
public class AV_139:MinionBase{
//NAME=憎恶军官
//TEXT=在你的回合结束时，随机吞食一个敌方随从并获得其属性值。
//MAJ=NEUTRAL|COST=8|ATK=3|HP=5|RACE=UNDEAD
}
public class AV_139e:Ability{
//NAME=肚肚怪怪的
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_141t:MinionBase{
//NAME=冰雪之王洛克霍拉
//TEXT=<b>突袭</b>，<b>风怒</b>。如果你的生命值小于或等于15点，该牌的法力值消耗减少（5）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=ELEMENTAL
}
public class AV_142e:Ability{
//NAME=晶化表皮
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_142e2:Ability{
//NAME=拔根而起
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_142e3:Ability{
//NAME=森林护卫
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_142e4:Ability{
//NAME=枝叶招摇
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_142t:MinionBase{
//NAME=森林之王伊弗斯
//TEXT=<b>战吼：</b>消耗你剩余的法力值。每消耗一点法力值，便随机从+2/+2，<b>突袭</b>，<b>圣盾</b>或<b>嘲讽</b>中获得一项。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class AV_143:MinionBase{
//NAME=血怒者科尔拉克
//TEXT=<b>亡语：</b>如果本随从未被<b>荣誉消灭</b>，则再次召唤科尔拉克。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class AV_145:MinionBase{
//NAME=加尔范上尉
//TEXT=<b>战吼：</b>在本局对战中，如果你获得的护甲值大于或等于15点，便获得+3/+3和<b>冲锋</b>。@<i>（还剩{0}点！）</i>@<i>（已经就绪！）</i>
//MAJ=WARRIOR|COST=6|ATK=6|HP=6|RACE=NONE
}
public class AV_145e:Ability{
//NAME=霜狼之怒
//TEXT=+3/+3和<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_146:WeaponBase{
//NAME=无法撼动之物
//TEXT=不会失去耐久度。你的英雄受到的伤害减半，向上取整。
//MAJ=PALADIN|COST=7|ATK=2|HP=5|RACE=NONE
}
public class AV_146e:Ability{
//NAME=坚不可摧
//TEXT=受到的伤害减半，向上取整。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_146e2:Ability{
//NAME=Resilient Weapon
//TEXT=No durability loss.
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_147:SpellBase{
//NAME=丹巴达尔碉堡
//TEXT=在你的回合结束时，抽一张<b>奥秘</b>牌并将其法力值消耗变为（1）点。持续3回合。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_147e:Ability{
//NAME=掩藏的奥秘
//TEXT=法力值消耗为（1）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_200:HeroBase{
//NAME=魔导师晨拥
//TEXT=<b>战吼：</b>再次施放你在本局对战中施放过的每个法术派系的一个法术。
//MAJ=MAGE|COST=7|ATK=0|HP=30|RACE=NONE
}
public class AV_200p2:HeroPowerBase{
//NAME=奥术爆裂
//TEXT=造成$2点伤害。 <b>荣誉消灭：</b>获得+2伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_201:MinionBase{
//NAME=冷齿雪人
//TEXT=<b>连击：</b> 获得+3攻击力。
//MAJ=ROGUE|COST=3|ATK=1|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			new EffectChange(owner.myPlayer,owner,owner,atkChange:3).Resolve();
		}
	}
}
public class AV_201e:Ability{
//NAME=雪人狂怒
//TEXT=+3攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_202:HeroBase{
//NAME=勇气战将洛卡拉
//TEXT=<b>战吼：</b>装备一把5/2的无坚不摧之力。
//MAJ=WARRIOR|COST=7|ATK=0|HP=30|RACE=NONE
}
public class AV_202p:HeroPowerBase{
//NAME=巨力猛击
//TEXT=造成$2点伤害。<b>荣誉消灭：</b>获得$d4点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_202t2:WeaponBase{
//NAME=无坚不摧之力
//TEXT=在你攻击一个随从后，将其撞向敌方英雄！
//MAJ=WARRIOR|COST=7|ATK=5|HP=2|RACE=NONE
}
public class AV_203:HeroBase{
//NAME=迅影匠师斯卡布斯
//TEXT=<b>战吼：</b>将所有随从移回拥有者的手牌。召唤两个4/2并具有<b>潜行</b>的影子。
//MAJ=ROGUE|COST=8|ATK=0|HP=30|RACE=NONE
}
public class AV_203p:HeroPowerBase{
//NAME=手法娴熟
//TEXT=在本回合中，你使用的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_203pe:Ability{
//NAME=手法娴熟
//TEXT=在本回合中，你使用的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_203po:Ability{
//NAME=手法娴熟
//TEXT=在本回合中，你使用的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_203t:MinionBase{
//NAME=影子
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=4|HP=2|RACE=NONE
}
public class AV_204:HeroBase{
//NAME=裂魔者库尔特鲁斯
//TEXT=<b>战吼：</b>召唤两个1/4并具有<b>突袭</b>的恶魔。<i>（在本局对战中，你的英雄每攻击一次都会提升。）</i>
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=30|RACE=NONE
}
public class AV_204e:Ability{
//NAME=陨烬之力
//TEXT=在本回合中，+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_204p:HeroPowerBase{
//NAME=陨烬之怒
//TEXT=在本回合中+$a2攻击力。在一个友方随从攻击后，复原此技能。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class AV_204t2:MinionBase{
//NAME=魔蝠尖啸者
//TEXT=<b>突袭</b>
//MAJ=DEMONHUNTER|COST=3|ATK=1|HP=4|RACE=DEMON
}
public class AV_205:HeroBase{
//NAME=野性之心古夫
//TEXT=<b>战吼：</b>将你的法力值上限变为20。获得一个空的法力水晶。抽一张牌。
//MAJ=DRUID|COST=5|ATK=0|HP=30|RACE=NONE
}
public class AV_205a:SpellBase{
//NAME=冰雪绽放
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_205p:HeroPowerBase{
//NAME=培育
//TEXT=<b>抉择：</b>抽一张牌；或者获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_205pb:SpellBase{
//NAME=山谷植根
//TEXT=抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_206:HeroBase{
//NAME=光铸凯瑞尔
//TEXT=<b>战吼：</b>对所有敌人造成2点伤害。装备一块2/5的无法撼动之物。
//MAJ=PALADIN|COST=8|ATK=0|HP=30|RACE=NONE
}
public class AV_206p:HeroPowerBase{
//NAME=女王的祝福
//TEXT=随机使你手牌中的一张随从牌获得+4/+4。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_206pe:Ability{
//NAME=女王的祝福
//TEXT=+4/+4。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_207:HeroBase{
//NAME=虔诚祭司泽瑞拉
//TEXT=<b>战吼：</b>触发本局对战中每个死亡的友方随从的<b>亡语</b>。
//MAJ=PRIEST|COST=8|ATK=0|HP=30|RACE=NONE
}
public class AV_207p:HeroPowerBase{
//NAME=神圣之触
//TEXT=恢复#5点生命值。每回合翻转。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_207p2:HeroPowerBase{
//NAME=虚空之刺
//TEXT=造成$5点伤害。每回合翻转。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_209:WeaponBase{
//NAME=恐惧牢笼战刃
//TEXT=<b>荣誉消灭：</b>对敌方英雄造成等同于你英雄的攻击力的伤害。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=3|RACE=NONE
}
public class AV_210:MinionBase{
//NAME=开路者
//TEXT=<b>战吼：</b>施放你的上一个<b>抉择</b>法术的另一个选项。0<b>战吼：</b>{0}
//MAJ=DRUID|COST=3|ATK=3|HP=4|RACE=NONE
}
public class AV_210e:Ability{
//NAME=路径标记
//TEXT=标记法术选项
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_211:MinionBase{
//NAME=凶恶霜狼
//TEXT=<b>潜行</b>，<b>亡语：</b> 召唤一只2/2并具有<b>潜行</b>的狼。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class AV_211t:MinionBase{
//NAME=霜狼宝宝
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class AV_212:SpellBase{
//NAME=法力虹吸
//TEXT=造成$2点伤害。<b>荣誉消灭：</b>使你手牌中所有法术牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class AV_212e:Ability{
//NAME=真棒！
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_213:SpellBase{
//NAME=活力涌现
//TEXT=抽一张随从牌。为你的英雄恢复等同于其法力值消耗的生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class AV_215:MinionBase{
//NAME=狂乱角鹰兽
//TEXT=<b>突袭</b>，<b>荣誉消灭：</b>获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=BEAST
}
public class AV_218:SpellBase{
//NAME=群体变形
//TEXT=使所有随从变形成为1/1的绵羊。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=ARCANE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListMorph = new List<Card>();
		List<CardDbf> Dbfs= new List<CardDbf>();
		foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
		{
			ToListMorph.Add(c);
			Dbfs.Add(CardDbf.GetCardDbfByGuid("AV_218t"));
		}
		new EffectMorph(owner.myPlayer,owner,targets:ToListMorph,newDbfs:Dbfs).Resolve();
	}
}
public class AV_218t:MinionBase{
//NAME=绵羊
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class AV_219:MinionBase{
//NAME=群羊指挥官
//TEXT=<b>战吼：</b>将两张1/1并具有<b>突袭</b>的山羊置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AV_219t:MinionBase{
//NAME=作战山羊
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class AV_222:MinionBase{
//NAME=话痨奥术师
//TEXT=<b>战吼：</b>对所有其他随从造成1点伤害。如果有随从死亡，则重复此效果。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=NONE
}
public class AV_223:MinionBase{
//NAME=范达尔·雷矛
//TEXT=<b>战吼：</b>如果本随从的法力值消耗小于你牌库中的所有随从牌，则使这些牌的法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class AV_223e:Ability{
//NAME=占据要塞
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_224:SpellBase{
//NAME=布置陷阱
//TEXT=对一个随从造成$3点伤害，从你的牌库中施放一个<b>奥秘</b>。<b>荣誉消灭：</b>改为施放两个。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class AV_226:SecretBase{
//NAME=冰霜陷阱
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，改为将其移回拥有者的手牌，并且法力值消耗增加（1）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FROST
}
public class AV_226e:Ability{
//NAME=霜冻
//TEXT=法力值消耗增加（1）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_238:MinionBase{
//NAME=伏兵
//TEXT=<b>潜行</b> 在你的对手使用一张随从牌后，攻击该随从。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=NONE
}
public class AV_244:WeaponBase{
//NAME=觅血者
//TEXT=<b>荣誉消灭：</b>获得+1/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AV_244e:Ability{
//NAME=觅血
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_250:SpellBase{
//NAME=雪球大战
//TEXT=对一个随从造成$1点伤害并使其<b>冻结</b>。如果该随从依然存活，则对另一个随从重复此效果！
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=FROST
}
public class AV_251:MinionBase{
//NAME=作弊的雪地狗头人
//TEXT=在一个敌人被<b>冻结</b>后，对其造成3点 伤害。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class AV_255:MinionBase{
//NAME=雪落守护者
//TEXT=<b>战吼：</b><b>冻结</b>所有其他随从。
//MAJ=SHAMAN|COST=6|ATK=5|HP=5|RACE=ELEMENTAL
}
public class AV_255e:Ability{
//NAME=寒颤
//TEXT=属性值提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_256:MinionBase{
//NAME=反射工程师
//TEXT=<b>战吼：</b>使双方玩家手牌中所有随从牌的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_256e:Ability{
//NAME=镜像反射
//TEXT=攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_257:MinionBase{
//NAME=熊男爵格雷希尔
//TEXT=<b>战吼：</b>在本局对战中你每施放过一个冰霜法术，召唤一个3/4的可以<b>冻结</b>攻击目标的元素。0<i>（召唤0个）</i>
//MAJ=SHAMAN|COST=7|ATK=6|HP=6|RACE=ELEMENTAL
}
public class AV_257t:MinionBase{
//NAME=冰封雄鹿守卫
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class AV_258:HeroBase{
//NAME=元素使者布鲁坎
//TEXT=<b>战吼：</b>唤起两种元素之力！
//MAJ=SHAMAN|COST=8|ATK=0|HP=30|RACE=NONE
}
public class AV_258p:HeroPowerBase{
//NAME=元素精通
//TEXT=每回合唤起一个不同的元素之灵！
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258p2:HeroPowerBase{
//NAME=流水祈咒
//TEXT=为所有友方角色恢复#6点生命值。每回合切换。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258pt:HeroPowerBase{
//NAME=大地祈咒
//TEXT=召唤两个2/3并具有<b>嘲讽</b>的元素。每回合切换。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258pt3:HeroPowerBase{
//NAME=火焰祈咒
//TEXT=对敌方英雄造成$6点伤害。每回合切换。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258pt4:HeroPowerBase{
//NAME=闪电祈咒
//TEXT=对所有敌方随从造成$2点伤害。每回合切换。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258pt7:HeroPowerBase{
//NAME=号令元素
//TEXT=每回合唤起一个不同的元素之灵！
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_258t:SpellBase{
//NAME=大地祈咒
//TEXT=召唤两个2/3并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_258t2:SpellBase{
//NAME=流水祈咒
//TEXT=为所有友方角色恢复6点生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_258t3:SpellBase{
//NAME=火焰祈咒
//TEXT=对敌方英雄造成6点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_258t4:SpellBase{
//NAME=闪电祈咒
//TEXT=对所有敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_258t6:MinionBase{
//NAME=土灵守护者
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class AV_259:SpellBase{
//NAME=冰霜撕咬
//TEXT=造成$3点伤害。<b>荣誉消灭：</b>你对手的下一个法术法力值消耗增加（2）点。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class AV_259e:Ability{
//NAME=霜冻
//TEXT=你的下一个法术法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_259e2:Ability{
//NAME=霜冻
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_260:MinionBase{
//NAME=破霰元素
//TEXT=<b>战吼：</b>将一张冷风置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
}
public class AV_261:MinionBase{
//NAME=擎旗奔行者
//TEXT=每当一个友方随从死亡，便获得+1 攻击力。
//MAJ=DEMONHUNTER|COST=3|ATK=1|HP=6|RACE=NONE
}
public class AV_261e:Ability{
//NAME=团队玩家
//TEXT=+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_262:MinionBase{
//NAME=锁链守望者
//TEXT=<b>嘲讽</b>，<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的恶魔牌，便获得+1/+2。
//MAJ=DEMONHUNTER|COST=4|ATK=2|HP=6|RACE=NONE
}
public class AV_262e2:Ability{
//NAME=恐怖
//TEXT=+1/+2。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_264:SpellBase{
//NAME=清算咒符
//TEXT=在你的下个回合开始时，从你的手牌中召唤一个恶魔。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
}
public class AV_265:MinionBase{
//NAME=乌祖尔巨人
//TEXT=在本局对战中，每有一个友方随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=DEMONHUNTER|COST=13|ATK=8|HP=8|RACE=DEMON
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			int Dead = 0;
			foreach(Card c in owner.myPlayer.grave)
			{
				if(c.cardType==CardType.Minion)
				{
					Dead+=1;
				}
			}
			return -Dead;
		}
		return 0;
	}
}
public class AV_266:SpellBase{
//NAME=冷风
//TEXT=<b>冻结</b>一个随从。抽一张牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FROST
}
public class AV_267:MinionBase{
//NAME=凯丽娅·邪魂
//TEXT=<b>战吼：</b> 变形成为你牌库中一个恶魔的6/6复制。
//MAJ=DEMONHUNTER|COST=6|ATK=6|HP=6|RACE=NONE
	public override void Battlecry(Card target=null)
	{

		List<Card> DemonPool = new List<Card>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardType==CardType.Minion && c.raceType.Contains(RaceType.Demon))
			{
				DemonPool.Add(c);
			}
		}
		Card ToMorph = DemonPool.Choice(owner.myPlayer.randomGen);
		if(ToMorph!=null)
			new EffectMorph(owner.myPlayer,owner,owner,ToMorph.cardDbf).Resolve();
	}
}
public class AV_267e2:Ability{
//NAME=魔化
//TEXT=攻击力和生命值为6。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_268:SpellBase{
//NAME=蛮爪洞穴
//TEXT=在你的回合结束时，召唤一个3/4的可以<b>冻结</b>攻击目标的元素。持续3回合。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class AV_269:SpellBase{
//NAME=侧翼合击
//TEXT=召唤一个4/2并具有<b>突袭</b>的恶魔。如果它在本回合中死亡，再召唤一个。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class AV_269e:Ability{
//NAME=Woe Is Me
//TEXT=If this dies summon another.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_269t:MinionBase{
//NAME=落雪萨特
//TEXT=<b>突袭</b>
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=2|RACE=DEMON
}
public class AV_277:SpellBase{
//NAME=毁灭之种
//TEXT=将四张裂隙洗入你的牌库。当抽到裂隙时，召唤一个3/3的恐惧小鬼。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FEL
}
public class AV_281:SpellBase{
//NAME=邪火爆弹
//TEXT=抽一张法术牌，对所有敌人造成$2点伤害。如果抽到的是邪能法术牌，则再造成$1点。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=FEL
}
public class AV_282:SpellBase{
//NAME=堆塑雪人
//TEXT=召唤一个3/3的可以<b>冻结</b>攻击目标的雪人。将一张堆塑雪怪置入你的手牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class AV_282t:MinionBase{
//NAME=雪人
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class AV_282t2:SpellBase{
//NAME=堆塑雪怪
//TEXT=召唤一个6/6的可以<b>冻结</b>攻击目标的雪怪。将一张堆塑巨怪置入你的手牌。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=FROST
}
public class AV_282t3:MinionBase{
//NAME=雪怪
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=6|ATK=6|HP=6|RACE=ELEMENTAL
}
public class AV_282t4:SpellBase{
//NAME=堆塑巨怪
//TEXT=召唤一个9/9的可以<b>冻结</b>攻击目标的冰雪巨怪。
//MAJ=MAGE|COST=9|ATK=0|HP=0|RACE=FROST
}
public class AV_282t5:MinionBase{
//NAME=冰雪巨怪
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=9|ATK=9|HP=9|RACE=ELEMENTAL
}
public class AV_283:SpellBase{
//NAME=大法师的符文
//TEXT=对敌人施放消耗总计20点法力值的法师法术。
//MAJ=MAGE|COST=9|ATK=0|HP=0|RACE=NONE
}
public class AV_284:MinionBase{
//NAME=巴琳达·斯通赫尔斯
//TEXT=<b>战吼：</b>抽两张法术牌，使其法力值消耗与本随从的属性值交换。
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card c1 = TaskDrawType(CardType.Spell);
        Card c2 = TaskDrawType(CardType.Spell);
        if(c1!=null && c2!=null)
        {
	        int m1 = c1.GetTag(GameTag.Mana);
    	    int m2 = c2.GetTag(GameTag.Mana);

    	    int atk = owner.GetTag(GameTag.Attack);
    	    int hp = owner.GetTag(GameTag.Health);
    	    new EffectChange(owner.myPlayer,owner,owner,atkChange:-atk+m1,hpChange:-hp+m2).Resolve();
        	new EffectChange(owner.myPlayer,owner,c1,manaChange:-m1+atk).Resolve();
        	new EffectChange(owner.myPlayer,owner,c2,manaChange:-m2+hp).Resolve();
        }
    }
}
public class AV_284e:Ability{
//NAME=法力互换
//TEXT=法力值消耗互换。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_284e2:Ability{
//NAME=魔力互换
//TEXT=已交换攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_284e3:Ability{
//NAME=魔力互换
//TEXT=已交换生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_285:SpellBase{
//NAME=邪恶入骨
//TEXT=造成$5点伤害，随机分配到所有敌方随从身上。在本回合可以重复使用。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class AV_286:MinionBase{
//NAME=邪能行者
//TEXT=<b>嘲讽</b>，<b>战吼：</b>从你的手牌中施放法力值消耗最高的邪能法术。
//MAJ=WARLOCK|COST=6|ATK=3|HP=7|RACE=DEMON
}
public class AV_286e2:Ability{
//NAME=邪能充盈
//TEXT=+1/+1。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_290:SpellBase{
//NAME=冰血哨塔
//TEXT=在你的回合结束时，随机从你的牌库中施放另一个法术。持续3回合。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=NONE
}
public class AV_291:MinionBase{
//NAME=霜刃豹头领
//TEXT=<b>嘲讽</b> 在本局对战中，你每召唤一只野兽，该牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=7|ATK=4|HP=5|RACE=BEAST
}
public class AV_292:SpellBase{
//NAME=野性之心
//TEXT=使一个随从获得+2/+2，然后使你的野兽获得+1/+1。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AV_292e:Ability{
//NAME=领导兽群
//TEXT=+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_292e2:Ability{
//NAME=兽群成员
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_293:MinionBase{
//NAME=空军指挥官穆维里克
//TEXT=<b>突袭</b>。你的随从拥有“<b>荣誉消灭：</b>召唤一只2/2 并具有<b>突袭</b>的双足飞龙。”
//MAJ=DRUID|COST=4|ATK=2|HP=5|RACE=NONE
}
public class AV_293e:Ability{
//NAME=空中打击
//TEXT=<b>荣誉消灭：</b>召唤一只2/2并具有<b>突袭</b>的双足飞龙。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_293t:MinionBase{
//NAME=突击双足飞龙
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class AV_294:MinionBase{
//NAME=怒爪精锐
//TEXT=<b>战吼：</b>在本回合中，使所有其他友方角色获得+1攻击力。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.hero).Exclude(owner))
        {
            c.ChangeTag(GameTag.AttackFot,1);
        }
        new EffectChange(owner.myPlayer,owner,owner).Resolve();
    }
}
public class AV_294e:Ability{
//NAME=白雪覆盖
//TEXT=本回合获得+1攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_295:SpellBase{
//NAME=占领冷齿矿洞
//TEXT=<b>抉择：</b>抽取你法力值消耗最低的牌；或者抽取你法力值消耗最高的牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_295a:SpellBase{
//NAME=更多资源
//TEXT=抽取你法力值消耗最低的牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_295b:SpellBase{
//NAME=更多补给
//TEXT=抽取你法力值消耗最高的牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_296:MinionBase{
//NAME=傲狮猎手
//TEXT=<b>战吼：</b>你的下一张<b>抉择</b>牌法力值消耗减少（2）点。
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_296e:Ability{
//NAME=成长
//TEXT=你的下一张<b>抉择</b>牌法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_296e2:Ability{
//NAME=高傲
//TEXT=法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_298:MinionBase{
//NAME=蛮爪豺狼人
//TEXT=<b>突袭</b>。在本局对战中，你每将一张非潜行者的职业牌置入你的手牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=5|ATK=3|HP=5|RACE=NONE
}
public class AV_308:MinionBase{
//NAME=墓地污染者
//TEXT=<b>战吼：</b>复制你手牌中的一张邪能法术牌。
//MAJ=WARLOCK|COST=1|ATK=2|HP=1|RACE=NONE
}
public class AV_309:MinionBase{
//NAME=被背小鬼
//TEXT=<b>亡语：</b>召唤一个4/1的小鬼。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=1|RACE=DEMON
}
public class AV_309t:MinionBase{
//NAME=背背小鬼
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=4|HP=1|RACE=DEMON
}
public class AV_312:MinionBase{
//NAME=献祭召唤者
//TEXT=<b>战吼：</b>消灭一个友方随从。从你的牌库中召唤一个法力值消耗增加（1）点的随从。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class AV_313:MinionBase{
//NAME=可怕的憎恶
//TEXT=<b>战吼：</b>对所有敌方随从造成1点伤害。<b>荣誉消灭：</b>获得目标随从的攻击力。
//MAJ=WARLOCK|COST=5|ATK=2|HP=8|RACE=UNDEAD
}
public class AV_313e:Ability{
//NAME=吞噬
//TEXT=攻击力提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_315:SpellBase{
//NAME=超脱
//TEXT=对一个随从造成$3点伤害。<b>荣誉消灭：</b>召唤该随从的一个3/3的新的复制。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class AV_315e2:Ability{
//NAME=救赎
//TEXT=攻击力和生命值为3。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_316:HeroBase{
//NAME=恐惧巫妖塔姆辛
//TEXT=<b>战吼：</b>对所有随从造成3点伤害。将三张裂隙洗入你的牌库。抽三张牌。
//MAJ=WARLOCK|COST=6|ATK=0|HP=30|RACE=NONE
}
public class AV_316hp:HeroPowerBase{
//NAME=恐惧之链
//TEXT=将一张裂隙洗入你的牌库。抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_316t:MinionBase{
//NAME=恐惧小鬼
//TEXT=
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class AV_316t4:SpellBase{
//NAME=邪能裂隙
//TEXT=<b>抽到时施放</b> 召唤一个3/3的恐惧小鬼。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class AV_317:SpellBase{
//NAME=塔姆辛的护命匣
//TEXT=<b>发现</b>一个在本局对战中死亡的友方<b>亡语</b>随从。使你的所有随从获得其<b>亡语</b>。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class AV_317e:Ability{
//NAME=巫妖香水
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_321:MinionBase{
//NAME=荣耀追逐者
//TEXT=在你使用一张<b>嘲讽</b>随从牌后，抽一张牌。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class AV_322:SpellBase{
//NAME=冰雪围困
//TEXT=消灭一个受伤的随从。<b>冻结</b>所有其他随从。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=FROST
}
public class AV_323:MinionBase{
//NAME=废料铁匠
//TEXT=<b>嘲讽</b>，<b>战吼：</b>将两张2/4并具有<b>嘲讽</b>的步兵置入你的手牌。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_323t:MinionBase{
//NAME=废铁步兵
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class AV_324:SpellBase{
//NAME=暗言术：噬
//TEXT=选择一个随从，使其从所有其他随从处各偷取1点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class AV_324e2:Ability{
//NAME=优化
//TEXT=生命值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_324e2b:Ability{
//NAME=Superior
//TEXT=Increased Health.
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_324e3:Ability{
//NAME=劣化
//TEXT=生命值降低。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_324eb:Ability{
//NAME=Inferior
//TEXT=Reduced Health.
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_325:MinionBase{
//NAME=不死信徒
//TEXT=<b>嘲讽</b>。<b>亡语：</b>对所有敌方随从造成等同于本随从攻击力的伤害。
//MAJ=PRIEST|COST=6|ATK=3|HP=7|RACE=UNDEAD
}
public class AV_326:MinionBase{
//NAME=光辉晶簇
//TEXT=在一个友方随从受到治疗后，使其获得+2攻击力。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=ELEMENTAL
}
public class AV_326e:Ability{
//NAME=照耀
//TEXT=+2攻击力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_328:MinionBase{
//NAME=灵魂向导
//TEXT=<b>嘲讽</b>，<b>亡语：</b>抽一张神圣法术牌和一张暗影法术牌。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class AV_329:SpellBase{
//NAME=祝福
//TEXT=使一个随从获得+2生命值，然后使其攻击力等同于其生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class AV_329e:Ability{
//NAME=祝福
//TEXT=+2生命值，且本随从的攻击力等同于其生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_329e2:Ability{
//NAME=Blessed
//TEXT=+2 Health.
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_330:SpellBase{
//NAME=纳鲁的赐福
//TEXT=为所有角色恢复#3点生命值。如果有角色仍处于受伤状态，抽一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class AV_331:MinionBase{
//NAME=纳亚克·海克森
//TEXT=<b>战吼：</b>夺取一个敌方随从的控制权。<b>亡语：</b>归还控制的随从。
//MAJ=PRIEST|COST=4|ATK=1|HP=4|RACE=NONE
}
public class AV_331e:Ability{
//NAME=黑暗合剂
//TEXT=当纳亚克被消灭时归还本随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_331e2:Ability{
//NAME=黑暗合剂
//TEXT=控制{0}。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_333:SpellBase{
//NAME=复活宠物
//TEXT=<b>发现</b>一只在本局对战中死亡的友方野兽，并召唤该随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class AV_334:MinionBase{
//NAME=雷矛军用山羊
//TEXT=<b>突袭</b>，<b>亡语：</b>你的下一张野兽牌法力值消耗减少（2）点。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class AV_334e:Ability{
//NAME=准备战斗
//TEXT=法力值消耗减少（2）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_334e2:Ability{
//NAME=战斗准备
//TEXT=法力值消耗减少（2）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_335:MinionBase{
//NAME=驯羊师
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1和<b>潜行</b>。
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=NONE
}
public class AV_335e:Ability{
//NAME=悄悄躲藏
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_336:MinionBase{
//NAME=空军指挥官艾克曼
//TEXT=<b>战吼：</b>从你的牌库中召唤一只野兽并使其获得<b>突袭</b>。如果它在本回合中消灭了一个随从，重复此效果。
//MAJ=HUNTER|COST=9|ATK=5|HP=4|RACE=NONE
}
public class AV_336e:Ability{
//NAME=恐怖兽群
//TEXT=如果本随从在本回合中消灭了一个随从，随机从你的牌库中召唤一只野兽并使其获得<b>突袭</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_337:MinionBase{
//NAME=山岭野熊
//TEXT=<b>嘲讽</b>，<b>亡语：</b>召唤两只2/4并具有<b>嘲讽</b>的山熊宝宝。
//MAJ=HUNTER|COST=7|ATK=5|HP=6|RACE=BEAST
}
public class AV_337t:MinionBase{
//NAME=山熊宝宝
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class AV_338:SpellBase{
//NAME=坚守桥梁
//TEXT=使一个随从获得+2/+1和<b>圣盾</b>。直到回合结束，使其获得<b>吸血</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class AV_338e:Ability{
//NAME=士气高涨
//TEXT=+2/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_338e2:Ability{
//NAME=士气高涨
//TEXT=在本回合中<b>吸血</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_339:MinionBase{
//NAME=圣殿骑士队长
//TEXT=<b>突袭</b>。 在本随从攻击一个随从后，召唤一个5/5并具有<b>嘲讽</b>的防御者。
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=NONE
}
public class AV_340:MinionBase{
//NAME=亮铜之翼
//TEXT=在你的回合结束时，对所有敌人造成2点伤害。<b>荣誉消灭：</b>为你的英雄恢复4点生命值。
//MAJ=PALADIN|COST=8|ATK=9|HP=7|RACE=DRAGON
}
public class AV_341:WeaponBase{
//NAME=骑兵号角
//TEXT=<b>亡语：</b>召唤你手牌中法力值消耗最低的随从。
//MAJ=PALADIN|COST=5|ATK=3|HP=2|RACE=NONE
}
public class AV_342:SpellBase{
//NAME=舍己为人
//TEXT=召唤一个5/5并具有<b>嘲讽</b>的防御者。在本回合中，如果你的英雄受到治疗，再召唤一个。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class AV_342t:MinionBase{
//NAME=雷矛防御者
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class AV_343:MinionBase{
//NAME=石炉守备官
//TEXT=<b>战吼：</b>抽一张法力值消耗小于或等于（3）点的法术牌。在本回合中，其法力值消耗为（0）点。
//MAJ=PALADIN|COST=3|ATK=3|HP=1|RACE=NONE
}
public class AV_343e:Ability{
//NAME=石炉之韧
//TEXT=在本回合中法力值消耗为（0）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_344:SpellBase{
//NAME=丹巴达尔桥
//TEXT=在你召唤一个随从后，使其获得+2/+2。 持续3回合。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class AV_344e:Ability{
//NAME=冷齿补给品
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_345:MinionBase{
//NAME=血色骑士赛丹
//TEXT=<b>突袭</b> 每当本随从获得攻击力或生命值，该数值翻倍<i>（无论本随从在哪里）</i>。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class AV_360:SpellBase{
//NAME=霜狼巢屋
//TEXT=在你的回合结束时，召唤一只2/2并具有<b>潜行</b>的狼。持续3回合。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AV_400:SpellBase{
//NAME=雪落墓地
//TEXT=你的<b>亡语</b>会触发两次。持续3回合。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class AV_400e:Ability{
//NAME=补充亡魂
//TEXT=<b>亡语</b>会触发两次。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_401:MinionBase{
//NAME=雷矛军需官
//TEXT=在你施放一个法术后，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AV_401e:Ability{
//NAME=军需充足
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_402:WeaponBase{
//NAME=剥夺者
//TEXT=<b>荣誉消灭：</b>获取你对手牌库顶的一张牌的复制。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AV_403:MinionBase{
//NAME=赛拉辛·疾行
//TEXT=<b>战吼：</b>将你手牌和牌库中的随从牌替换成其他职业的。这些牌的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=NONE
}
public class AV_403e2:Ability{
//NAME=迅足
//TEXT=法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_405:SpellBase{
//NAME=珍藏私货
//TEXT=重新使用五张在本局对战中你所使用过的其他职业的卡牌。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class AV_565:MinionBase{
//NAME=执斧狂战士
//TEXT=<b>突袭</b>，<b>荣誉消灭：</b>抽一张武器牌。
//MAJ=WARRIOR|COST=4|ATK=3|HP=5|RACE=NONE
}
public class AV_601:MinionBase{
//NAME=被遗忘者军官
//TEXT=<b>潜行</b>。在你使用一张<b>亡语</b>随从牌后，变形成为它的2/2并具有<b>突袭</b>的复制。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class AV_601e:Ability{
//NAME=被遗忘者
//TEXT=2/2。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_657:SpellBase{
//NAME=被亵渎的墓园
//TEXT=在你的回合结束时，消灭你的攻击力最低的随从，召唤一个4/4的影魔。持续3回合。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AV_657e:Ability{
//NAME=牺牲
//TEXT=在回合结束时牺牲。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_657t:MinionBase{
//NAME=亵渎影魔
//TEXT=
//MAJ=WARLOCK|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class AV_660:SpellBase{
//NAME=冰血要塞
//TEXT=在你的回合结束时，对所有随从造成$1点伤害。持续3回合。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_661:SpellBase{
//NAME=征战平原
//TEXT=你的随从拥有+1攻击力。持续3回合。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_661e2:Ability{
//NAME=强化
//TEXT={0}使其获得+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_664:SpellBase{
//NAME=雷矛救援站
//TEXT=在你的回合结束时，使你的随从获得+2生命值。持续3回合。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AV_664e2:Ability{
//NAME=已恢复
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_704:MinionBase{
//NAME=巨型猫头鹰
//TEXT=<b>亡语：</b>随机对一个敌人造成8点伤害。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=4|RACE=BEAST
}
public class AV_710:SpellBase{
//NAME=侦察
//TEXT=<b>发现</b>一张另一职业的<b>亡语</b>随从牌， 其法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AV_710e:Ability{
//NAME=缔结合约
//TEXT=法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_711:MinionBase{
//NAME=双面间谍
//TEXT=<b>战吼：</b> 如果你的手牌中有另一职业的卡牌，召唤一个本随从的复制。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class AV_750:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class AV_751:HeroPowerBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class AV_752:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_753:HeroBase{
//NAME=？？？
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class AV_760:HeroPowerBase{
//NAME=移动
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_760t0:MinionBase{
//NAME=空位
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class AV_760t1:MinionBase{
//NAME=墙壁
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=NONE
}
public class AV_760t2:MinionBase{
//NAME=黑暗
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=1|RACE=NONE
}
public class AV_760t3:MinionBase{
//NAME=狂怒的树人
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=1|RACE=NONE
}
public class AV_760t4:MinionBase{
//NAME=熔岩
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=1|RACE=NONE
}
public class AV_760t5:MinionBase{
//NAME=开裂的墙壁
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=5|ATK=0|HP=1|RACE=NONE
}
public class AV_760t6:MinionBase{
//NAME=箱子
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=6|ATK=0|HP=1|RACE=NONE
}
public class AV_760t7:MinionBase{
//NAME=友好的商贩
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=1|RACE=NONE
}
public class AV_761t0:SpellBase{
//NAME=金币
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t1:SpellBase{
//NAME=火炬
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t2:SpellBase{
//NAME=罗盘
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t3:SpellBase{
//NAME=斧子
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t4:SpellBase{
//NAME=熔岩踏靴
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t5:SpellBase{
//NAME=炸药
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_761t6:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_780e:Ability{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_781:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_782:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_783:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_784:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_785:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_786:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AV_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
