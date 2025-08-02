using System.Collections;
using System.Collections.Generic;

public class MIS_006:MinionBase{
//NAME=玩具盗窃恶鬼
//TEXT=<b>扩大</b> <b>战吼：</b><b>发现</b>一张亡灵牌，使其降低等同于本随从攻击力的法力值消耗。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=1|RACE=UNDEAD
}
public class MIS_006e1:Ability{
//NAME=收藏福利
//TEXT=法力值消耗减少。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_006t:MinionBase{
//NAME=玩具盗窃恶鬼
//TEXT=<b>大型</b> <b>战吼：</b><b>发现</b>一张亡灵牌，使其降低等同于本随从攻击力的法力值消耗。
//MAJ=DEATHKNIGHT|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class MIS_025:MinionBase{
//NAME=复制鬼才
//TEXT=<b>微缩</b>，<b>扩大</b> 在你使用一张攻击力与本随从相同的随从牌后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class MIS_025t:MinionBase{
//NAME=复制鬼才
//TEXT=<b>微型</b> 在你使用一张与本随从攻击力相同的随从牌后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class MIS_025t1:MinionBase{
//NAME=复制鬼才
//TEXT=<b>大型</b> 在你使用一张与本随从攻击力相同的随从牌后，召唤一个它的复制。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=MECHANICAL
}
public class MIS_026:MinionBase{
//NAME=傀儡大师多里安
//TEXT=在你抽一张随从牌后，获取一张它的1/1且法力值消耗为（1）点的复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class MIS_026e:Ability{
//NAME=诡异傀儡
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_027:SpellBase{
//NAME=多米诺效应
//TEXT=对一个随从造成$2点伤害。向左侧或右侧重复此效果，每次伤害增加1点。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class MIS_100:SpellBase{
//NAME=屈辱头盔
//TEXT=使一个随从获得-5/-5。使你手牌中的一张随从牌获得+5/+5。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class MIS_100e:Ability{
//NAME=丢人
//TEXT=-5/-5。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_100e1:Ability{
//NAME=巫妖王折扣
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_101:WeaponBase{
//NAME=海绵斧
//TEXT=每当你的英雄攻击时，消耗3具 <b>尸体</b>以获得+1耐久度。
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=1|RACE=NONE
}
public class MIS_101e:Ability{
//NAME=仍需装配
//TEXT=+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_102:SpellBase{
//NAME=退货政策
//TEXT=<b>发现</b>一张你在 本局对战中使用过的友方<b>亡语</b>牌。 触发其<b>亡语</b>。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class MIS_104:SpellBase{
//NAME=狂野的卡牌包
//TEXT=随机将五张野兽牌置入你的手牌。这些牌为<b>临时</b>牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MIS_104e:Ability{
//NAME=山寨卡牌包
//TEXT=在你的回合结束时弃掉。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_105:SecretBase{
//NAME=折价篓
//TEXT=<b>奥秘：</b>在你的对手使用一张随从，法术或武器牌后，你抽取其余两种类型的牌各一张。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MIS_107:SpellBase{
//NAME=玩具故障
//TEXT=造成$3点伤害，随机分配到所有敌方随从身上。如果你的牌库中没有随从牌，再造成$3点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class MIS_300:MinionBase{
//NAME=抱抱泰迪熊
//TEXT=<b>扩大</b> <b>扰魔</b>，<b>吸血</b>，<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class MIS_300t:MinionBase{
//NAME=抱抱泰迪熊
//TEXT=<b>大型</b> <b>扰魔</b>，<b>吸血</b>，<b>嘲讽</b>
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=BEAST
}
public class MIS_301:SpellBase{
//NAME=豆蔓疯长
//TEXT=召唤一个2/2的树人。你每控制一个树人，抽一张牌。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class MIS_301t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class MIS_302:SpellBase{
//NAME=买一冻一
//TEXT=<b>冻结</b>一个随从，召唤一个它的<b>被冻结</b>的复制。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class MIS_303:MinionBase{
//NAME=暗月魔术师
//TEXT=<b>扰魔</b>。在你施放一个法术后，随机施放一个法力值消耗增加（1）点的法术。
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=NONE
}
public class MIS_305:SpellBase{
//NAME=产品延期
//TEXT=<b>发现</b>并召唤一个法力值消耗大于或等于（8）点的随从，并使其<b>休眠</b>2回合。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class MIS_305e:Ability{
//NAME=生产延后
//TEXT=将一个随从送入2回合后的未来。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_305e2:Ability{
//NAME=推迟
//TEXT=<b>休眠</b>。2回合后唤醒。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_306:MinionBase{
//NAME=火箭跳蛙
//TEXT=<b>突袭</b>。<b>过载：</b>（4）
//MAJ=SHAMAN|COST=5|ATK=10|HP=10|RACE=BEAST
}
public class MIS_307:MinionBase{
//NAME=水宝宝鱼人
//TEXT=<b>扩大</b> <b>战吼：</b>召唤一个属性值等同于本随从并具有<b>突袭</b>的鱼人宝宝。
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class MIS_307t:MinionBase{
//NAME=模塑鱼人宝宝
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class MIS_307t1:MinionBase{
//NAME=水宝宝鱼人
//TEXT=<b>大型</b> <b>战吼：</b>召唤一个属性值等同于本随从并具有<b>突袭</b>的鱼人宝宝。
//MAJ=SHAMAN|COST=8|ATK=8|HP=8|RACE=MURLOC
}
public class MIS_308:MinionBase{
//NAME=爆破工程师
//TEXT=在你的回合结束时，将一张“炸弹” 牌洗入你对手的牌库。当抽到“炸弹”时，便会受到5点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class MIS_308e:Ability{
//NAME=不稳定的玩具
//TEXT=如果在本回合中使用，触发其<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_314:MinionBase{
//NAME=积木魔像
//TEXT=<b>突袭</b>。<b>亡语：</b>随机召唤三个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=3|RACE=NONE
}
public class MIS_700:SpellBase{
//NAME=痛打豺狼人
//TEXT=<b>发现</b>一张来自过去的圣骑士武器牌，使其获得+1/+1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MIS_700e:Ability{
//NAME=嗷！
//TEXT=+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_701:SpellBase{
//NAME=恋旧风潮
//TEXT=将所有随从变形成为来自过去的随机<b>传说</b>随从。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class MIS_703:MinionBase{
//NAME=地狱火！
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将你的英雄的剩余生命值变为15。
//MAJ=WARLOCK|COST=4|ATK=6|HP=6|RACE=DEMON
}
public class MIS_703e:Ability{
//NAME=地狱火之力！
//TEXT=生命值变为15
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_705:SpellBase{
//NAME=标准的卡牌包
//TEXT=随机将五张<b>嘲讽</b>随从牌置入你的手牌。这些牌为<b>临时</b>牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MIS_706:MinionBase{
//NAME=滚灰兔
//TEXT=<b>战吼，亡语：</b>将一件垃圾置入你的手牌<i>（幸运币，石头，香蕉或短刀）</i>。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class MIS_707:SpellBase{
//NAME=批量生产
//TEXT=抽两张牌。对你的英雄造成$3点伤害。将两张本牌的复制洗入你的牌库。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MIS_708:SpellBase{
//NAME=幻变的卡牌包
//TEXT=随机将五张其他职业的牌置入你的手牌。这些牌为<b>临时</b>牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MIS_709:SpellBase{
//NAME=圣光荧光棒
//TEXT=<b>吸血</b>。造成$4点伤害。如果你在本回合中施放过神圣法术，则法力值消耗为（1）点。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc.cardType==CardType.Spell)
		{
			if(sc.spellType.Contains(SpellSchoolType.Holy))
			{
				this.Act=true;
			}
		}
	}
	private bool Act=false;
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(this.Act)
			{
				return -3;
			}
		}
		return 0;
	}
}
public class MIS_709e1:Ability{
//NAME=尽兴狂欢
//TEXT=+5/+5
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_710:MinionBase{
//NAME=滑矛布袋手偶
//TEXT=本随从的攻击力 随你的英雄的攻击力提高。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=3|RACE=NAGA
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod)
		{
			if(owner.myPlayer.hero.Count>0)
			{
				return owner.myPlayer.hero[0].GetTag(GameTag.Attack);
			}
		}
		return 0;
	}
}
public class MIS_711:MinionBase{
//NAME=安全专家
//TEXT=<b>突袭</b>。<b>亡语：</b>将三张“炸弹” 牌洗入你对手的牌库。
//MAJ=WARRIOR|COST=10|ATK=8|HP=8|RACE=MECHANICAL
}
public class MIS_712:MinionBase{
//NAME=模玩泰拉图斯
//TEXT=<b>嘲讽</b>，<b>扰魔</b> <b>战吼：</b>如果你有十个法力水晶，获得+7/+7。
//MAJ=DRUID|COST=6|ATK=7|HP=7|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("Elusive");
	}
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=10)
		{
			new EffectChange(owner.myPlayer,owner,owner,atkChange:7,hpChange:7).Resolve();
		}
	}
}
public class MIS_712e:Ability{
//NAME=恐龙魔精
//TEXT=+7/+7。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_714:SpellBase{
//NAME=哈哈镜
//TEXT=召唤一个敌方随从的一个复制并使其攻击本体。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class MIS_902:SpellBase{
//NAME=零件破拆
//TEXT=失去最多5点护甲值，你的下一张机械牌减少等量的法力值消耗。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MIS_902e:Ability{
//NAME=废铁零件
//TEXT=你的下一张机械牌法力值消耗减少。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_903:SpellBase{
//NAME=可疑交易
//TEXT=抽三张牌。<b>连击：</b>随机消灭一个敌方随从。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class MIS_906e:Ability{
//NAME=加入我们
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_911:MinionBase{
//NAME=残次聒噪怪
//TEXT=在你的英雄 攻击后，召唤另一个残次聒噪怪。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=3|RACE=DEMON
}
public class MIS_911e:Ability{
//NAME=尖利模型
//TEXT=你的下一个英雄技能会多获得4点攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_914:MinionBase{
//NAME=量产品9号
//TEXT=<b>战吼：</b>再次施放本局对战中触发过的每个友方<b>奥秘</b>。
//MAJ=HUNTER|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class MIS_916:MinionBase{
//NAME=高端玩家
//TEXT=<b>战吼：</b>向你的 对手发起挑战，玩一场剪刀石头布！胜者抽两张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class MIS_916a:SpellBase{
//NAME=石头！
//TEXT=如果你的对手选择了剪刀，你抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_916b:SpellBase{
//NAME=布！
//TEXT=如果你的对手选择了石头，你抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_916c:SpellBase{
//NAME=剪刀！
//TEXT=如果你的对手选择了布，你抽两张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_916e:Ability{
//NAME=剪刀石头布！
//TEXT=在你的回合开始时，猜测对手的选择，猜中即可抽两张牌！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_918:MinionBase{
//NAME=灯火机器人
//TEXT=<b>扩大</b> 在本局对战中，你每施放一个神圣法术，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class MIS_918e:Ability{
//NAME=灯火闪亮
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MIS_918t:MinionBase{
//NAME=灯火机器人
//TEXT=<b>大型</b> 在本局对战中，你每施放一个神圣法术，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=MECHANICAL
}
public class MIS_919:LocationBase{
//NAME=木偶剧场
//TEXT=选择一个敌方随从，获取一张它的1/1且法力值消耗为（1）点的复制。
//MAJ=PRIEST|COST=4|ATK=0|HP=2|RACE=NONE
}
public class MIS_919e:Ability{
//NAME=木偶
//TEXT=属性值变为1/1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
