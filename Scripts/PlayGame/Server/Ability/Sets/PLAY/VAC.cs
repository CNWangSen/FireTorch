using System.Collections;
using System.Collections.Generic;

public class VAC_301:MinionBase{
//NAME=炫目演出者
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（5）的随从。在本局对战中你每施放过一个派系的法术，重复一次。0<i>（召唤0个）</i>
//MAJ=SHAMAN|COST=6|ATK=4|HP=4|RACE=NAGA
}
public class VAC_304:MinionBase{
//NAME=潮池学徒
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过3个法术，从中<b>发现</b>一张。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NAGA
}
public class VAC_305:SpellBase{
//NAME=冰霜摆件
//TEXT=召唤两个2/4并具有<b>嘲讽</b>和“<b>亡语：</b>获得4点护甲值”的元素。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=FROST
}
public class VAC_305t:MinionBase{
//NAME=冰雕
//TEXT=<b>嘲讽</b>。<b>亡语：</b>获得4点护甲值。
//MAJ=SHAMAN|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class VAC_308:SpellBase{
//NAME=海妖之歌
//TEXT=随机获取两张你在本局对战中未施放过的派系的法术牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAC_320:MinionBase{
//NAME=海床拖网者
//TEXT=<b>战吼：</b><b>探底</b>。每个玩家抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class VAC_321:MinionBase{
//NAME=伊辛迪奥斯
//TEXT=在你的回合结束时，你的爆发升级。 <b>战吼：</b>将5张爆发洗入你的牌库。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=10|RACE=ELEMENTAL
}
public class VAC_321t:SpellBase{
//NAME=爆发
//TEXT=<b>抽到时施放</b> 对所有敌人造成$1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class VAC_323:SpellBase{
//NAME=麦芽岩浆
//TEXT=对所有敌人造成$1点伤害。<i>（还剩3杯！）</i>
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class VAC_323t:SpellBase{
//NAME=麦芽岩浆
//TEXT=对所有敌人造成$1点伤害。<i>（还剩2杯！）</i>
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class VAC_323t2:SpellBase{
//NAME=麦芽岩浆
//TEXT=对所有敌人造成$1点伤害。<i>（最后一杯！）</i>
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class VAC_324:SpellBase{
//NAME=统一着装
//TEXT=将一个随从随机变形成为一个法力值消耗增加（1）点的随从，然后召唤一个它的复制。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAC_327:MinionBase{
//NAME=冰冷整脊师
//TEXT=<b>战吼：</b>使一个随从获得+3/+3并使其<b>冻结</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAC_327e:Ability{
//NAME=太刺脊了
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_328:MinionBase{
//NAME=消融元素
//TEXT=<b>嘲讽</b> 本随从永久被<b>冻结</b>。
//MAJ=SHAMAN|COST=3|ATK=3|HP=8|RACE=ELEMENTAL
}
public class VAC_328e:Ability{
//NAME=Stay Frosty
//TEXT=Permanently <b>Frozen</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_329:SpellBase{
//NAME=自然天性
//TEXT=随机获取纳迦牌和法术牌各一张， 其法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class VAC_330:WeaponBase{
//NAME=金属探测器
//TEXT=在你的英雄攻击 并消灭一个随从后，获取一张幸运币。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class VAC_332:MinionBase{
//NAME=海滩导购
//TEXT=<b>战吼：</b> 你使用的下一张非潜行者的职业牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=PIRATE
}
public class VAC_332e:Ability{
//NAME=海滩导购
//TEXT=你使用的下一张非潜行者的职业牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_333:MinionBase{
//NAME=蓄谋诈骗犯
//TEXT=<b>战吼：</b>再次使用你使用过的上一张非潜行者的职业牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class VAC_334:LocationBase{
//NAME=小玩物小屋
//TEXT=抽一张牌。如果你在本回合中使用抽到的这张牌，重新开启本地标。
//MAJ=ROGUE|COST=3|ATK=0|HP=4|RACE=NONE
}
public class VAC_335:SpellBase{
//NAME=小偷小摸
//TEXT=随机获取两张其他职业的法力值消耗为（1）的法术牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAC_336:MinionBase{
//NAME=面具变装大师
//TEXT=<b>术士游客</b> <b><b>战吼：</b>发现</b>一张来自过去的<i>（另一职业的）</i>英雄牌。
//MAJ=ROGUE|COST=6|ATK=6|HP=5|RACE=NONE
}
public class VAC_337:MinionBase{
//NAME=灶头厨师
//TEXT=<b>可交易</b> <b>嘲讽</b>。当你抽到本牌时，获取一张它的复制。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class VAC_338:SpellBase{
//NAME=腱力金杯
//TEXT=使你手牌中的一张随从牌获得+2/+1。<i>（还剩3杯！）</i>
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_338e:Ability{
//NAME=代餐杯饮
//TEXT=+2/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=FIRE
}
public class VAC_338t:SpellBase{
//NAME=腱力金杯
//TEXT=使你手牌中的一张随从牌获得+2/+1。<i>（还剩2杯！）</i>
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_338t2:SpellBase{
//NAME=腱力金杯
//TEXT=使你手牌中的一张随从牌获得+2/+1。<i>（最后一杯！）</i>
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_339:MinionBase{
//NAME=芝士怪物
//TEXT=<b>嘲讽</b> 在你的回合结束时，召唤一个属性值等同于本随从的元素。
//MAJ=WARRIOR|COST=9|ATK=6|HP=9|RACE=ELEMENTAL
}
public class VAC_339t:MinionBase{
//NAME=芝士元素
//TEXT=
//MAJ=WARRIOR|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class VAC_340:MinionBase{
//NAME=饥饿食客哈姆
//TEXT=<b>德鲁伊游客</b> <b>嘲讽</b>。在你的回合结束时，吃掉敌方牌库中的一个随从以获得+2/+2。
//MAJ=WARRIOR|COST=6|ATK=3|HP=3|RACE=NONE
}
public class VAC_340e:Ability{
//NAME=酒足饭饱
//TEXT=+2/+2
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_341:MinionBase{
//NAME=断生鱿鱼
//TEXT=<b>战吼：</b>消灭一个攻击力小于或等于本随从的敌方随从。
//MAJ=WARRIOR|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class VAC_402:MinionBase{
//NAME=霜噬海盗
//TEXT=<b>亡语：</b>随机<b>冻结</b>3个敌人，已被<b>冻结</b>的敌人改为受到5点伤害。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class VAC_404:SpellBase{
//NAME=夜影花茶
//TEXT=对一个随从造成$2点伤害。对你的英雄造成$2点伤害。<i>（还剩3杯！）</i>
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_404t1:SpellBase{
//NAME=夜影花茶
//TEXT=对一个随从造成$2点伤害。对你的英雄造成$2点伤害。<i>（还剩2杯！）</i>
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_404t2:SpellBase{
//NAME=夜影花茶
//TEXT=对一个随从造成$2点伤害。对你的英雄造成$2点伤害。<i>（最后一杯！）</i>
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_406:MinionBase{
//NAME=困倦的岛民
//TEXT=<b>嘲讽</b>。<b>亡语：</b>所有其他随从陷入沉睡。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class VAC_406e:Ability{
//NAME=Asleep
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_407:MinionBase{
//NAME=话痨鹦鹉
//TEXT=<b>战吼：</b><i>（尽可能对一个随机的敌人）</i>重新施放你对一个敌人施放的上一个法术。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class VAC_408:SpellBase{
//NAME=观赏鸟类
//TEXT=从你的牌库中<b>发现</b>一张随从牌。使其所有的复制获得+2/+1<i>（无论它们在哪）</i>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAC_408e:Ability{
//NAME=一鸟在手
//TEXT=+2/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_409:LocationBase{
//NAME=鹦鹉乐园
//TEXT=你的下一张<b>战吼</b>随从牌的法力值消耗减少（1）点。在你使用一张<b>战吼</b>随从牌后，重新开启本地标。
//MAJ=HUNTER|COST=2|ATK=0|HP=3|RACE=NONE
}
public class VAC_409e:Ability{
//NAME=鹦鹉学舌
//TEXT=你的下一个<b>战吼</b>随从的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_410:SpellBase{
//NAME=猛禽狂怒
//TEXT=选择一个敌人。召唤两只3/2并具有攻击时<b>免疫</b>的小鸟，攻击选中的敌人。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAC_410t:MinionBase{
//NAME=愤怒的小鸟
//TEXT=攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class VAC_412:MinionBase{
//NAME=当日渔获
//TEXT=<b>突袭</b>。<b>战吼： </b>为你的对手召唤一只2/1的鱼虫。
//MAJ=HUNTER|COST=1|ATK=3|HP=3|RACE=BEAST
}
public class VAC_412t:MinionBase{
//NAME=美味鱼虫
//TEXT=
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class VAC_413:MinionBase{
//NAME=园林护卫者基利
//TEXT=<b>战士游客</b> 在你的回合结束时，获取一张2/3的鳄鱼。<b>亡语：</b>使你手牌中的所有随从牌获得+2/+3。
//MAJ=HUNTER|COST=5|ATK=4|HP=6|RACE=NONE
}
public class VAC_413e3:Ability{
//NAME=利齿
//TEXT=+2/+3。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_413t:MinionBase{
//NAME=岛栖鳄鱼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class VAC_414:SpellBase{
//NAME=炽热火炭
//TEXT=对所有敌人造成$2点伤害。如果你的英雄在本回合受到过伤害，再造成$1点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=FIRE
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
		if(owner.myPlayer.hero[0].GetTag(GameTag.Damage)>0)
		{
			TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),1);
		}
	}
}
public class VAC_415:MinionBase{
//NAME=大叫巨鹦萨考克
//TEXT=<b>战吼：</b>重复你在上回合使用的每一张牌。
//MAJ=HUNTER|COST=7|ATK=4|HP=5|RACE=BEAST
}
public class VAC_416:SpellBase{
//NAME=死亡翻滚
//TEXT=消灭一个敌方随从。造成等同于其攻击力的伤害，随机分配到所有敌人身上。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAC_417:SpellBase{
//NAME=感官侵夺
//TEXT=召唤一个敌方随从的一个复制。如果你的生命值小于或等于20点，消灭本体。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_418:MinionBase{
//NAME=桑拿常客
//TEXT=<b>嘲讽</b>。你的英雄每在你的回合受到一次伤害，本牌的法力值消耗便减少（1）点。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class VAC_418e:Ability{
//NAME=桑拿蒸汽
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_419:SpellBase{
//NAME=针灸
//TEXT=对双方英雄造成$4点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		TaskDamageMyHero(4);
		TaskDamageEnemyHero(4);
	}
}
public class VAC_420:MinionBase{
//NAME=纳瑞安·柔想
//TEXT=<b>战吼：</b>获取两张预知命运。预知命运为你牌库顶的牌的复制。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=NONE
}
public class VAC_420e1:Ability{
//NAME=预知命运
//TEXT=变形成为你牌库顶的牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_420t:SpellBase{
//NAME=预知命运
//TEXT=本牌是你牌库顶的牌的复制
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_421:MinionBase{
//NAME=打盹的动物管理员
//TEXT=<b>战吼：</b>为你的对手 召唤一只8/8的野兽，使其攻击所在方的 所有随从。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=8|RACE=NONE
}
public class VAC_421t:MinionBase{
//NAME=暴乱野兽
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=BEAST
}
public class VAC_422e:Ability{
//NAME=游客额外效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_423:MinionBase{
//NAME=暮光灵媒师
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将你牌库顶的一张牌的法力值消耗变为（1）点。
//MAJ=PRIEST|COST=5|ATK=4|HP=5|RACE=NONE
}
public class VAC_423e4:Ability{
//NAME=烛光
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_424:MinionBase{
//NAME=沙滩塑形师蕾拉
//TEXT=<b>圣骑士游客</b> 在你施放一个法术后， 随机召唤一个法力值消耗为（2）的随从并使其 获得<b>圣盾</b>。
//MAJ=MAGE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class VAC_425:LocationBase{
//NAME=大地之末号
//TEXT=造成3点伤害，随机分配到所有敌人身上。在一个友方随从死亡后，重新开启本地标。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=5|RACE=NONE
}
public class VAC_426:MinionBase{
//NAME=伊丽扎·刺刃
//TEXT=<b>亡语：</b>在本局对战的剩余时间内，你的随从拥有+1攻击力。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=3|RACE=PIRATE
	private bool Act = false;
	public override void Deathrattle()
	{
		Act=true;
	}
    public override bool AuraActive()
    {
        return Act;
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardType==CardType.Minion && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAC_426e";
    }
}
public class VAC_426e:Ability{
//NAME=活力变换
//TEXT=在本局对战的剩余时间内，你的随从拥有+1攻击力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod)
		{
			return 1;
		}
		return 0;
	}
}
public class VAC_426e2:Ability{
//NAME=活力
//TEXT=+1攻击力
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_427:SpellBase{
//NAME=甜筒殡淇淋
//TEXT=造成$3点伤害。消耗3具<b>尸体</b>，在你的回合结束时将本牌移回你的手牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
}
public class VAC_427e:Ability{
//NAME=甜筒殡淇淋
//TEXT=在回合结束时获取一张甜筒殡激凌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_428:SpellBase{
//NAME=顺水漂流
//TEXT=选择一个随从。如果是敌方随从，将其<b>冻结</b>；如果是友方随从，使其获得<b>法术伤害+1</b>。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_428e:Ability{
//NAME=顺水漂流
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_429:MinionBase{
//NAME=滑雪高手
//TEXT=如果有被<b>冻结</b>的角色，则法力值消耗为（1）点。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class VAC_430:MinionBase{
//NAME=血帆征兵员
//TEXT=<b>战吼：</b> <b>发现</b>一张海盗牌。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=PIRATE
}
public class VAC_431:SpellBase{
//NAME=畅游海底
//TEXT=抽一张与本牌不同的法术牌，随机召唤一个法力值消耗与其相同的随从。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAC_432:MinionBase{
//NAME=景区代泊
//TEXT=<b>战吼：</b><b>发现</b>一张最新扩展包的牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=PIRATE
}
public class VAC_435:MinionBase{
//NAME=落难的大法师
//TEXT=你每个回合使用的第一张法术牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAC_435e:Ability{
//NAME=落难
//TEXT=你每个回合使用的第一张法术牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_436:MinionBase{
//NAME=脆骨海盗
//TEXT=每当你使用一张<b>亡语</b>随从牌时，使其获得<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=2|ATK=1|HP=4|RACE=UNDEAD
}
public class VAC_437:MinionBase{
//NAME=扣子
//TEXT=<b>萨满祭司游客</b> <b>战吼：</b>抽取每个派系的法术牌各一张。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class VAC_438:MinionBase{
//NAME=旅行社职员
//TEXT=<b>战吼：发现</b>一张任意职业的地标牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
}
public class VAC_439:MinionBase{
//NAME=海滨巨人
//TEXT=在本局对战中，你每使用过一次地标效果，本牌的法力值消耗便减少（2）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=NONE
}
public class VAC_440:MinionBase{
//NAME=海关执法者
//TEXT=敌方套牌之外的敌方卡牌法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=PIRATE
}
public class VAC_441:MinionBase{
//NAME=包裹分拣工
//TEXT=在你抽牌后，有50%的几率再抽一张。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class VAC_442:MinionBase{
//NAME=燃灯元素
//TEXT=<b>战吼：</b>造成1点伤害<i>（每有一个你使用过元素牌的连续的回合，伤害都会提升）</i>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=ELEMENTAL
}
public class VAC_443:MinionBase{
//NAME=冲浪章鱼
//TEXT=<b>战吼：</b>使你抽到的下一张法术牌获得<b>抽到时施放</b>效果。
//MAJ=MAGE|COST=5|ATK=5|HP=6|RACE=BEAST
}
public class VAC_443e:Ability{
//NAME=乘风破浪
//TEXT=使你抽到的下一张法术牌获得<b>抽到时施放</b>效果。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_443e2:Ability{
//NAME=乘风破浪2
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_444:MinionBase{
//NAME=规划狂人
//TEXT=<b>战吼：</b><b>发现</b>你牌库中的3张牌，将其按顺序置于牌库顶。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAC_445:SpellBase{
//NAME=食尸鬼之夜
//TEXT=召唤五个1/1的食尸鬼并使其攻击随机敌人。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAC_445t:MinionBase{
//NAME=夜场食尸鬼
//TEXT=
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class VAC_446:MinionBase{
//NAME=挂机的阿凯
//TEXT=在你的回合结束时，使所有其他未攻击的友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=5|RACE=NONE
}
public class VAC_446e:Ability{
//NAME=挂机
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_447:MinionBase{
//NAME=恐惧的逃亡者
//TEXT=如果本随从不在 你的套牌中，则拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=PIRATE
	public override void Init()
	{
		TaskInitAbility("Charge");
	}
}
public class VAC_449:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=此牌在你的手牌中时，使用两种不同派系的法术牌即可变形。@<i>（还剩{0}种）</i>@<i>（已经就绪！）</i>
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449e1:Ability{
//NAME=海妖之歌
//TEXT=+2/+2。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_449t:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。对敌方英雄造成 6点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t1:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。随机<b>冻结</b>三个 敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t10:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对敌方英雄造成6点伤害。对所有敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t11:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。随机<b>冻结</b>三个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t12:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>为你的英雄恢复6点生命值。随机<b>冻结</b>三个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t13:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>随机消灭两个敌方随从。随机<b>冻结</b>三个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t14:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对所有敌方随从造成2点伤害。随机<b>冻结</b>三个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t15:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。为你的英雄恢复6点生命值。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t16:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。随机消灭2个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t17:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。对所有敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t18:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>为你的英雄恢复6点生命值。随机消灭2个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t19:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>为你的英雄 恢复6点生命值。 对所有敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t2:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。获得+2/+2和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t20:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对所有敌方随从造成2点伤害。随机消灭2个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t3:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。为你的英雄恢复 6点生命值。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t4:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。随机消灭2个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t5:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>抽两张牌。对所有敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t6:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对敌方英雄造成6点伤害。随机<b>冻结</b>三个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t7:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对敌方英雄造成6点伤害。获得+2/+2和<b>嘲讽</b>。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t8:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对敌方英雄造成6点伤害。为你的英雄恢复6点生命值。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_449t9:MinionBase{
//NAME=歌唱明星卡瑞斯
//TEXT=<b>战吼：</b>对敌方英雄造成6点伤害。随机消灭2个敌方随从。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class VAC_450:MinionBase{
//NAME=悠闲的曲奇
//TEXT=<b>恶魔猎手游客</b> 在一个友方随从死亡后，随机召唤一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class VAC_457:SpellBase{
//NAME=安息
//TEXT=每个玩家分别召唤其在本局对战中死亡的法力值消耗最高的随从。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_460:SpellBase{
//NAME=把经理叫来！
//TEXT=造成$2点伤害。<b>连击：</b>获取一张幸运币。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("GAME_005"),ZoneType.Hand);
		}
	}
}
public class VAC_461:MinionBase{
//NAME=饮品侍者
//TEXT=<b>亡语：</b>随机获取一张饮品法术牌。<i>（饮品可以饮用3次！）</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
}
public class VAC_463:MinionBase{
//NAME=前台礼宾
//TEXT=你的其他职业的 牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=PIRATE
}
public class VAC_464:MinionBase{
//NAME=财宝猎人尤朵拉
//TEXT=<b>战吼：</b>开启一项使用3张其他职业的牌即可完成的<b>支线任务</b>，<b>发现</b>神奇的战利品！
//MAJ=ROGUE|COST=6|ATK=4|HP=5|RACE=PIRATE
}
public class VAC_464t:SpellBase{
//NAME=尤朵拉的猎宝之旅
//TEXT=<b>支线任务：</b>使用3张其他职业的牌。<b>奖励：</b><b>发现</b>两件神奇的战利品！
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t10:SpellBase{
//NAME=望远镜
//TEXT=随机复制对手手牌中的一张牌，将其置入你的手牌。该牌的法力值消耗减少 （3）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t11:MinionBase{
//NAME=发条助手
//TEXT=在本局对战中，你每施放一个法术，便拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=MECHANICAL
}
public class VAC_464t12:SpellBase{
//NAME=谜之匣
//TEXT=随机将所有随从变形成为法力值消耗增加（3）点的其他 随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_464t14:WeaponBase{
//NAME=超级能量枪
//TEXT=<b>剧毒</b> 你的英雄在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class VAC_464t15:SpellBase{
//NAME=侏儒军刀
//TEXT=使一个随从获得<b>突袭</b>，<b>风怒</b>，<b>圣盾</b>，<b>吸血</b>，<b>剧毒</b>，<b>嘲讽</b>以及<b>潜行</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t16:SpellBase{
//NAME=裂解魔杖
//TEXT=<b>沉默</b>并消灭所有敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_464t17:SpellBase{
//NAME=异鳞之杖
//TEXT=召唤三条1/1并具有<b>突袭，剧毒</b>和<b>复生</b>的蛇。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t18:SpellBase{
//NAME=坎努匹克陶罐
//TEXT=使你的所有随从获得“<b>亡语：</b>随机召唤一个<b>传说</b>随从。”
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t19:SpellBase{
//NAME=远古映像
//TEXT=选择一个随从。用它的1/1的复制填满你的面板。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_464t2:SpellBase{
//NAME=死灵毒药
//TEXT=消灭一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_464t20:SpellBase{
//NAME=香蕉分裂
//TEXT=使一个友方随从获得+2/+2，并召唤两个它的复制。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class VAC_464t21:SpellBase{
//NAME=砰砰博士的砰砰箱
//TEXT=召唤七个“砰砰机器人”。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t22:MinionBase{
//NAME=蜡油暴怒者
//TEXT=<b>亡语：</b> 再次召唤本随从。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=ELEMENTAL
}
public class VAC_464t23:SpellBase{
//NAME=拉格纳罗斯的余烬
//TEXT=随机向敌人射出三个火球，每个造成$8点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=FIRE
}
public class VAC_464t24:SpellBase{
//NAME=亡者之书
//TEXT=对所有敌人造成$7点伤害。在本局对战中，每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=14|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_464t25:SpellBase{
//NAME=吵吵号角
//TEXT=用吵闹的随从填满你的面板
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t26:MinionBase{
//NAME=残暴的奴隶主
//TEXT=在你的回合结束时，召唤一个本随从的 复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAC_464t27:MinionBase{
//NAME=野兽美女
//TEXT=<b>突袭</b> 在本随从攻击一个随从并存活下来后，变形成为8/8的随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class VAC_464t27t:MinionBase{
//NAME=美女野兽
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=NONE
}
public class VAC_464t28:SpellBase{
//NAME=吸血鬼之牙
//TEXT=消灭一个随从。为你的英雄恢复生命值，数值相当于该随从的生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_464t29:WeaponBase{
//NAME=奎尔德拉的剑刃
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class VAC_464t3:SpellBase{
//NAME=变异注射
//TEXT=使一个随从获得+4/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class VAC_464t30:SpellBase{
//NAME=奎尔德拉的剑柄
//TEXT=使一个随从获得+3/+3。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t31:WeaponBase{
//NAME=奎尔德拉
//TEXT=在你的英雄攻击后，对所有敌人造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class VAC_464t31t:SpellBase{
//NAME=铸造奎尔德拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_464t4:WeaponBase{
//NAME=驱魔者
//TEXT=<b>沉默</b>此武器攻击的任何随从。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=NONE
}
public class VAC_464t5:SpellBase{
//NAME=极寒之击
//TEXT=对敌方英雄造成$8点伤害，并使其<b>冻结</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=FROST
}
public class VAC_464t6:MinionBase{
//NAME=布巴
//TEXT=<b>战吼：</b>召唤六只 1/1并具有<b>突袭</b>的血猎犬并使其攻击一个 敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class VAC_464t7:SpellBase{
//NAME=神圣典籍
//TEXT=<b>沉默</b>并消灭一个随从。召唤一个它的10/10复制。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=HOLY
}
public class VAC_464t8:MinionBase{
//NAME=硬壳横行蟹
//TEXT=<b>战吼：</b>消灭一个随从。获得其攻击力和生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class VAC_464t9:SpellBase{
//NAME=浮光掠影
//TEXT=抽两张牌。 获得4点护甲值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_501:MinionBase{
//NAME=极限追逐者阿兰娜
//TEXT=<b>牧师游客</b> 你的英雄在你的回合中受到的伤害会转移给一个随机敌人。
//MAJ=DEMONHUNTER|COST=5|ATK=5|HP=6|RACE=NONE
}
public class VAC_503:MinionBase{
//NAME=召唤师达克玛洛
//TEXT=<b>死亡骑士游客</b> 你的<b>亡语</b>会触发两次。在你使用一张<b>亡语</b>随从牌后，将其消灭。
//MAJ=WARLOCK|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class VAC_503e:Ability{
//NAME=暗髓亡语
//TEXT=你的<b>亡语</b>会触发 两次。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_506:MinionBase{
//NAME=巡游船长萝拉
//TEXT=<b>战吼：</b>随机召唤 2个地标。
//MAJ=DRUID|COST=6|ATK=4|HP=5|RACE=PIRATE
}
public class VAC_507:MinionBase{
//NAME=阳光汲取者莱妮莎
//TEXT=<b>潜行者游客</b> 你的法力值消耗小于或等于（2）点的法术会施放两次。
//MAJ=PALADIN|COST=5|ATK=2|HP=6|RACE=NONE
}
public class VAC_507e:Ability{
//NAME=晒太阳
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_508:SpellBase{
//NAME=能量零食
//TEXT=仅在下回合，获得两个法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class VAC_508e:Ability{
//NAME=甜食亢奋
//TEXT=在本回合中，获得两个法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_509:SpellBase{
//NAME=海啸
//TEXT=召唤四个3/6的可以<b>冻结</b>攻击目标的水元素，并使其随机攻击敌人。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=FROST
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<4;i++)
		{
			Card Water = TaskCreate(CardDbf.GetCardDbfByGuid("VAC_509t"),ZoneType.Board);
			if(Water.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				Card Target = owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Choice(owner.myPlayer.randomGen);
				if(Target!=null)
				{
					new EffectAttack(owner.myPlayer,Water,Target).Resolve();
				}
			}
		}
	}
}
public class VAC_509t:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Freezing");
	}
}
public class VAC_511:MinionBase{
//NAME=嗜睡巨龙
//TEXT=<b>休眠</b>2回合。<b>休眠</b>状态下，在你的回合结束时召唤一条3/5并具有<b>嘲讽</b>的龙。
//MAJ=DRUID|COST=5|ATK=3|HP=5|RACE=DRAGON
}
public class VAC_511e:Ability{
//NAME=睡过头了
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_511e2:Ability{
//NAME=Sleepy
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_511t:MinionBase{
//NAME=躁动的雏龙
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class VAC_512:MinionBase{
//NAME=心灵按摩师
//TEXT=每当本随从受到伤害，对你的英雄造成等量的伤害。
//MAJ=PRIEST|COST=1|ATK=2|HP=4|RACE=UNDEAD
}
public class VAC_513:SpellBase{
//NAME=滑坡
//TEXT=<b>冻结</b>一个角色。每有一个被<b>冻结</b>的角色，抽一张牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
}
public class VAC_514:MinionBase{
//NAME=恐惧猎犬训练师
//TEXT=<b>突袭</b>。<b>亡语：</b>召唤一只1/1并具有<b>复生</b>的恐惧猎犬。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=PIRATE
}
public class VAC_514t:MinionBase{
//NAME=恐惧猎犬
//TEXT=<b>复生</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class VAC_517:LocationBase{
//NAME=远足步道
//TEXT=<b>发现</b>一张<b>嘲讽</b>随从牌。在你获得护甲值后，重新开启本地标。
//MAJ=DRUID|COST=3|ATK=0|HP=3|RACE=NONE
}
public class VAC_518:MinionBase{
//NAME=始祖龟旅行者
//TEXT=<b>嘲讽</b>。<b>亡语： </b>抽一张其他<b>嘲讽</b>随从牌，其法力值消耗减少（2）点。
//MAJ=DRUID|COST=3|ATK=1|HP=5|RACE=NONE
}
public class VAC_518e:Ability{
//NAME=旅行
//TEXT=法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_519:MinionBase{
//NAME=米斯塔·维斯塔
//TEXT=<b>法师游客</b> <b>战吼：</b>3回合后，再次使用你在这三回合期间施放过的所有法术。
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class VAC_519t3:SpellBase{
//NAME=美丽远景
//TEXT=3回合后， 再次使用你在这 三回合期间施放过的所有法术。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_520:SpellBase{
//NAME=银樽海韵
//TEXT=造成$2点伤害，随机分配到所有敌人身上。<i>（还剩3杯！）</i>
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class VAC_520t:SpellBase{
//NAME=银樽海韵
//TEXT=造成$2点伤害，随机分配到所有敌人身上。<i>（还剩2杯！）</i>
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class VAC_520t2:SpellBase{
//NAME=银樽海韵
//TEXT=造成$2点伤害，随机分配到所有敌人身上。<i>（最后一杯！）</i>
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class VAC_521:MinionBase{
//NAME=笨拙的搬运工
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class VAC_522:LocationBase{
//NAME=潮汐之池
//TEXT=<b>发现</b>一张法力值消耗小于或等于（3）点的法术牌。在你施放一个法术后，重新开启本地标。
//MAJ=MAGE|COST=3|ATK=0|HP=3|RACE=NONE
}
public class VAC_523:MinionBase{
//NAME=混调师
//TEXT=<b>战吼：</b>制造一张法力值消耗为（1）的自定义药水牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class VAC_523t:SpellBase{
//NAME=大师特调
//TEXT={0}{1}
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_524:MinionBase{
//NAME=海潮之王泰德
//TEXT=<b>战吼：</b>直到你的下个回合结束，双方玩家的法术的法力值消耗为（5）点。
//MAJ=MAGE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class VAC_524e:Ability{
//NAME=驾驭波涛
//TEXT=所有法术法力值消耗为（5）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_524e2:Ability{
//NAME=踏浪争锋
//TEXT=所有法术法力值消耗为（5）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_525:WeaponBase{
//NAME=黑麦切割者
//TEXT=<b>战吼，亡语：</b>获取一片面包。<i>（获取2片即可将随从夹进三明治！）</i>
//MAJ=WARRIOR|COST=5|ATK=4|HP=2|RACE=NONE
}
public class VAC_525e:Ability{
//NAME=三明治追踪器
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_525t1:SpellBase{
//NAME=面包片
//TEXT=<i>再获取一片面包片，即可将两片面包之间的所有随从夹进一块法力值消耗为（4）的三明治！</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_525t2:SpellBase{
//NAME=随从三明治
//TEXT=召唤夹进这块三明治中的所有随从0召唤夹进这块三明治中的{0}个随从。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class VAC_526:SpellBase{
//NAME=炭火
//TEXT=对一个随从造成$7点伤害。使你手牌中的一张随从牌获得等同于超过目标生命值伤害的属性值。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class VAC_526e:Ability{
//NAME=暖意融融
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_527:MinionBase{
//NAME=龙族美餐
//TEXT=<b>突袭</b>。<b>扰魔</b>。每次只能受到1点伤害。
//MAJ=WARRIOR|COST=8|ATK=6|HP=6|RACE=DRAGON
}
public class VAC_528:SpellBase{
//NAME=自助大餐
//TEXT=抽取三张不同类型的随从牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<RaceType> ToDrawRace = new List<RaceType>();
		List<Card> ToListDraw = new List<Card>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.raceType.Count>0 && c.cardType==CardType.Minion)
			{
				bool HasRace = true;
				foreach(RaceType rc in c.raceType)
				{
					if(!ToDrawRace.Contains(rc))
					{
						HasRace=false;
						ToDrawRace.Add(rc);
						ToListDraw.Add(c);
						break;
					}
				}
			}
			if(ToListDraw.Count>=3)
			{
				break;
			}
		}

		foreach(Card c in ToListDraw)
		{
			TaskDraw(c);
		}
	}
}
public class VAC_529:MinionBase{
//NAME=游学生
//TEXT=<b>战吼：</b>召唤一个友方地标的复制。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class VAC_531:MinionBase{
//NAME=湾鳍健身鱼人
//TEXT=在你的回合中，在你的对手召唤随从后，将其<b>沉默</b>并消灭。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=7|RACE=MURLOC
}
public class VAC_532:MinionBase{
//NAME=椰子火炮手
//TEXT=在相邻的随从攻击后，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=PIRATE
}
public class VAC_533:SpellBase{
//NAME=食物大战
//TEXT=为你的对手召唤一份0/6的主菜。当它死亡时，从你的牌库中召唤一个随从。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_533t:MinionBase{
//NAME=主菜
//TEXT=<b>亡语：</b> 使你的对手从牌库中召唤一个随从。
//MAJ=WARRIOR|COST=3|ATK=0|HP=6|RACE=NONE
}
public class VAC_558:SpellBase{
//NAME=海上船歌
//TEXT=召唤三个 5/5的海盗。在本局对战中，你每对角色施放一个法术，本牌的法力值消耗便 减少（1）点。
//MAJ=PALADIN|COST=10|ATK=0|HP=0|RACE=NONE
}
public class VAC_558t:MinionBase{
//NAME=和声海盗
//TEXT=
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=PIRATE
}
public class VAC_700:SpellBase{
//NAME=横夺硬抢
//TEXT=随机消灭两个敌方随从。你每使用过一张另一职业的卡牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=8|ATK=0|HP=0|RACE=NONE
}
public class VAC_701:MinionBase{
//NAME=刀剑保养师
//TEXT=<b>战吼：</b>将你的武器的攻击力和耐久度变为3。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.weapon.Count>0)
		{
			Card MyWeap = owner.myPlayer.weapon[0];
			new EffectChange(owner.myPlayer,owner,MyWeap,atkChange:3-MyWeap.GetTag(GameTag.Attack),hpChange:3-MyWeap.GetTag(GameTag.Health));
		}
	}
}
public class VAC_701e:Ability{
//NAME=砥砺生光
//TEXT=变为3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_702:MinionBase{
//NAME=经理马林
//TEXT=<b>战吼：</b>选择一张神奇宝藏。将其余3张洗入你的牌库。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=PIRATE
}
public class VAC_702t:SpellBase{
//NAME=扎罗格的王冠
//TEXT=<b>发现</b>一张<b>传说</b>随从牌。召唤两个它的复制。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_702t2:SpellBase{
//NAME=托林的酒杯
//TEXT=抽一张牌。用它的复制填满你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_702t3:SpellBase{
//NAME=奇迹之杖
//TEXT=抽三张牌，其法力值消耗减为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_702t4:MinionBase{
//NAME=黄金狗头人
//TEXT=<b>嘲讽</b>，<b>战吼：</b>将你的手牌替换成<b>传说</b> 随从。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=NONE
}
public class VAC_907:SpellBase{
//NAME=星夜露宿
//TEXT=<b>选择三次：</b>抽两张牌；获得5点护甲值；或者复原三个法力水晶。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_907t1:SpellBase{
//NAME=猎豹星座
//TEXT=抽两张牌。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_907t2:SpellBase{
//NAME=巨熊星座
//TEXT=获得5点护甲值。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_907t3:SpellBase{
//NAME=枭兽星座
//TEXT=复原三个法力水晶。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class VAC_915:SpellBase{
//NAME=大力扣杀
//TEXT=造成$4点伤害。随机使一个友方随从获得+4/+4。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class VAC_915e:Ability{
//NAME=大力扣杀
//TEXT=+4/+4。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_916:SpellBase{
//NAME=神圣佳酿
//TEXT=使一个角色获得<b>圣盾</b>。如果其已经拥有圣盾，使其在本回合中获得+1攻击力。<i>（还剩3杯！）</i>
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class VAC_916e:Ability{
//NAME=冰凉提神
//TEXT=在本回合中+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_916t2:SpellBase{
//NAME=神圣佳酿
//TEXT=使一个角色获得<b>圣盾</b>。如果其已经拥有圣盾，使其在本回合中获得+1攻击力。<i>（还剩2杯！）</i>
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class VAC_916t3:SpellBase{
//NAME=神圣佳酿
//TEXT=使一个角色获得<b>圣盾</b>。如果其已经拥有圣盾，使其在本回合中获得+1攻击力。<i>（最后一杯！）</i>
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class VAC_917:MinionBase{
//NAME=烧烤大师
//TEXT=<b>战吼：</b>抽取你法力值消耗最低的牌。<b>亡语：</b>抽取你法力值消耗最高的牌。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=NONE
}
public class VAC_917e:Ability{
//NAME=防晒霜
//TEXT=+1/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_917t:SpellBase{
//NAME=防晒霜
//TEXT=使一个随从获得+1/+2。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_919:MinionBase{
//NAME=救生员
//TEXT=<b>嘲讽</b>。<b>战吼：</b> 你施放的下一个法术拥有<b>吸血</b>。
//MAJ=PALADIN|COST=4|ATK=2|HP=7|RACE=NONE
}
public class VAC_919e:Ability{
//NAME=防护
//TEXT=你的下一个法术拥有<b>吸血</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_920:MinionBase{
//NAME=王牌发球手
//TEXT=在本随从获得攻击力后，使你手牌中法力值消耗最高的牌的法力值消耗减少（1）点。
//MAJ=PALADIN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class VAC_920e:Ability{
//NAME=精彩发球
//TEXT=法力值消耗减少。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_921:WeaponBase{
//NAME=沙滩排槌
//TEXT=在你的英雄攻击后，获取一张法力值消耗为（1）的防晒霜。防晒霜可以使随从获得+1/+2。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class VAC_922:SpellBase{
//NAME=救生光环
//TEXT=在你的回合结束时，获取一张法力值消耗为（1）的可以使随从获得+1/+2的防晒霜。 持续3回合。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class VAC_923:MinionBase{
//NAME=圣沙泽尔
//TEXT=<b>突袭</b> 在本随从攻击后，变成地标。
//MAJ=PALADIN|COST=5|ATK=3|HP=8|RACE=ELEMENTAL
}
public class VAC_923e:Ability{
//NAME=Sandy Castle
//TEXT=Has the stats of Sanc'Azel.
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_923e2:Ability{
//NAME=沙土
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_923t:LocationBase{
//NAME=圣沙泽尔
//TEXT=使一个友方随从获得+3攻击力和<b>突袭</b>。变回随从。
//MAJ=PALADIN|COST=5|ATK=0|HP=8|RACE=NONE
}
public class VAC_924:MinionBase{
//NAME=武器寄存员
//TEXT=<b>战吼：</b> 如果你控制着其他海盗，随机从你的牌库中装备一把武器。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=PIRATE
}
public class VAC_925:SpellBase{
//NAME=伞降咒符
//TEXT=在你的下个回合开始时，召唤三个1/1并具有<b>冲锋</b>的海盗。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
	public bool Used=false;
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(!Used)
		{
			CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAC_926t");
			TaskCreate(ToSummon,ZoneType.Board);
			TaskCreate(ToSummon,ZoneType.Board);
			TaskCreate(ToSummon,ZoneType.Board);
			Used=true;
		}
	}

}
public class VAC_926:SpellBase{
//NAME=高崖跳水
//TEXT=从你的牌库中召唤2个随从并使其获得<b>突袭</b>。在你的回合结束时，它们会返回牌库。
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class VAC_926e:Ability{
//NAME=蹦极
//TEXT=在回合结束时返回牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_926t:MinionBase{
//NAME=坠落的伊利达雷
//TEXT=<b>冲锋</b>
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=PIRATE
}
public class VAC_927:MinionBase{
//NAME=狂飙邪魔
//TEXT=在一个友方海盗攻击后，使你的英雄在 本回合中获得 +1攻击力。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Board && sc.raceType.Contains(RaceType.Pirate) && CondInPlay())
        {
            TaskBuffMyHero(atk:1);
        }
    }
}
public class VAC_927e:Ability{
//NAME=肾上腺素
//TEXT=本回合提高攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_928:SpellBase{
//NAME=飞翼滑翔
//TEXT=双方玩家抽三张牌。<b>流放：</b>只有你抽牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_929:LocationBase{
//NAME=惊险悬崖
//TEXT=召唤两个1/1并具有<b>冲锋</b>的海盗。在你的英雄攻击后，重新开启本地标。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=3|RACE=NONE
}
public class VAC_930:MinionBase{
//NAME=全地形虚空猎犬
//TEXT=每当本随从攻击时，使你的英雄在本回合中获得+5攻击力。
//MAJ=DEMONHUNTER|COST=7|ATK=5|HP=8|RACE=DEMON
}
public class VAC_930e:Ability{
//NAME=越野
//TEXT=本回合提高攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_931:SpellBase{
//NAME=生死一线
//TEXT=选择一个随从。在本回合中，你的英雄从该随从处偷取4点攻击力。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:4);
		new EffectGiveAbility(owner.myPlayer,owner,target,"VAC_931e").Resolve();
	}
}
public class VAC_931e:Ability{
//NAME=生死一线
//TEXT=在本回合中-4攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
	private bool Act=true;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		this.Act=false;
		this.UnRegisterEventEffect();
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod)
		{
			return -4;
		}
		return 0;
	}
}
public class VAC_931e1:Ability{
//NAME=悬于一线
//TEXT=在本回合中+0攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_932:WeaponBase{
//NAME=登山钩爪
//TEXT=当你控制着攻击力大于或等于5的随从时，不会失去耐久度。
//MAJ=DEMONHUNTER|COST=6|ATK=5|HP=2|RACE=NONE
}
public class VAC_932e:Ability{
//NAME=钩住了
//TEXT=当你控制着攻击力大于或等于5的随从时，不会失去耐久度。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_933:MinionBase{
//NAME=飞行员帕奇斯
//TEXT=<b>战吼：</b>将六张降落伞洗入你的牌库。当抽到降落伞时，召唤一个1/1并具有<b>冲锋</b>的海盗。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<6;i++)
		{
			CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAC_933t");
			TaskCreate(ToSummon,ZoneType.Deck,randpos:true);
		}
	}
}
public class VAC_933t:SpellBase{
//NAME=降落伞
//TEXT=<b>抽到时施放</b> 召唤一个1/1并具有<b>冲锋</b>的海盗。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("CastWhenDrawn");
	}
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("VAC_926t"),ZoneType.Board);
	}
}
public class VAC_934:MinionBase{
//NAME=搁浅巨鲸
//TEXT=<b>嘲讽</b>。<b>战吼：</b>对本随从造成10点伤害。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=20|RACE=BEAST
}
public class VAC_935:MinionBase{
//NAME=随行肉虫
//TEXT=<b>战吼：</b>获取一张法力值消耗为（1）的手提箱，将你牌库顶的2张牌装入其中。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
}
public class VAC_935e:Ability{
//NAME=随身额外效果记录器
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_935t:SpellBase{
//NAME=随行手提箱
//TEXT=获取{0}和{1}。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_935t2:SpellBase{
//NAME=随行手提箱
//TEXT=获取{0}。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_936:MinionBase{
//NAME=八爪按摩机
//TEXT=对随从造成 八倍伤害。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=8|RACE=BEAST
}
public class VAC_937:MinionBase{
//NAME=帆船舰长
//TEXT=<b>战吼：</b>使一个友方海盗获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		if(target.raceType.Contains(RaceType.Pirate))
		{
			new EffectGiveAbility(owner.myPlayer,owner,target,"WindFury").Resolve();
		}
	}
}
public class VAC_938:MinionBase{
//NAME=粗暴的猢狲
//TEXT=每当其他友方海盗攻击时，使其获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=PIRATE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Pirate) && sc!=owner)
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:1,hpChange:1).Resolve();
			}
		}
	}
}
public class VAC_938e:Ability{
//NAME=粗暴好斗
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_939:SpellBase{
//NAME=吃掉小鬼！
//TEXT=消灭一个友方随从以抽三张牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class VAC_940:MinionBase{
//NAME=派对邪犬
//TEXT=<b>战吼：</b>召唤两只1/1的邪能兽。对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class VAC_940t:MinionBase{
//NAME=邪能兽
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class VAC_941:SpellBase{
//NAME=弃明投暗
//TEXT=将你的英雄技能和非术士卡牌替换成术士的。它们的法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_941e:Ability{
//NAME=弃明投暗附魔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_942:MinionBase{
//NAME=无畏的火焰杂耍者
//TEXT=<b>战吼：</b>获得等同于你的英雄在本回合中所受伤害量的属性值。0<i>（获得0点）</i>
//MAJ=WARLOCK|COST=2|ATK=1|HP=1|RACE=DEMON
}
public class VAC_942e:Ability{
//NAME=火热计划
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_943:MinionBase{
//NAME=祭献小鬼
//TEXT=<b>亡语：</b>如果此时是你的回合，召唤一个6/6并具有<b>嘲讽</b>的小鬼。
//MAJ=WARLOCK|COST=3|ATK=1|HP=6|RACE=DEMON
}
public class VAC_943t:MinionBase{
//NAME=巨硕小鬼
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class VAC_944:SpellBase{
//NAME=咒怨纪念品
//TEXT=使一个随从获得+3/+3和“在你的回合开始时，对你的英雄造成3点伤害”。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class VAC_944e:Ability{
//NAME=咒怨纪念品
//TEXT=+3/+3和“在你的回合开始时，对你的英雄造成3点伤害”。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_945:MinionBase{
//NAME=派对策划者沃娜
//TEXT=<b>战吼：</b>如果你在你的回合中受到过8点伤害，召唤乌洛波斯。@<i>（还剩{0}点！）</i>@<i>（已经就绪！）</i>
//MAJ=WARLOCK|COST=6|ATK=4|HP=4|RACE=NONE
}
public class VAC_945e:Ability{
//NAME=必要代价
//TEXT=<b>亡语：</b>召唤世界之蛇乌洛波斯。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_945t:MinionBase{
//NAME=世界之蛇乌洛波斯
//TEXT=<b>嘲讽</b>。<b>亡语：</b> 使你手牌中的一张随从牌获得“<b>亡语：</b>召唤乌洛波斯”。
//MAJ=WARLOCK|COST=8|ATK=8|HP=8|RACE=BEAST
}
public class VAC_946:MinionBase{
//NAME=可怕的主厨
//TEXT=<b>战吼：</b>召唤一个0/2的蛛魔之卵。<b>亡语：</b>消灭它。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=UNDEAD
}
public class VAC_947:MinionBase{
//NAME=波池造浪者
//TEXT=<b>战吼：</b>使所有其他随从获得-1/-1。<b>亡语：</b>使所有其他随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=ELEMENTAL
}
public class VAC_947e1:Ability{
//NAME=退潮
//TEXT=-1/-1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_947e2:Ability{
//NAME=涨潮
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_948:SpellBase{
//NAME=补水区
//TEXT=复活你法力值消耗最高的三个不同的<b>嘲讽</b>随从。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NONE
}
public class VAC_949:SpellBase{
//NAME=攀上新高
//TEXT=将你的法力值上限提高3点，获得一个空的法力水晶。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.MaxTotalMana,3);
		owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,1);
	}
}
public class VAC_950:MinionBase{
//NAME=抱石伙伴
//TEXT=<b>突袭。嘲讽</b> 如果你拥有至少十个法力水晶，则法力值消耗为（1）点。
//MAJ=DRUID|COST=7|ATK=6|HP=7|RACE=ELEMENTAL
}
public class VAC_951:SpellBase{
//NAME=“健康”饮品
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<i>（还剩3杯！）</i>
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class VAC_951t:SpellBase{
//NAME=“健康”饮品
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<i>（还剩2杯！）</i>
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class VAC_951t2:SpellBase{
//NAME=“健康”饮品
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<i>（最后一杯！）</i>
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class VAC_952:SpellBase{
//NAME=邪能篝火
//TEXT=对一个随从造成$4点伤害。如果该随从死亡，你的下一个<b>亡语</b>随从的法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
}
public class VAC_952e:Ability{
//NAME=丰厚祭品
//TEXT=你的下一个亡语随从的法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_952e2:Ability{
//NAME=接纳祭品
//TEXT=法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_953:SpellBase{
//NAME=浪潮涌起
//TEXT=对所有随从造成 $2点伤害。如果没有随从死亡，再造成$2点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class VAC_954:MinionBase{
//NAME=顶流主唱
//TEXT=<b>战吼：</b>使你手牌中每个派系的各一张法术牌的法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=4|ATK=3|HP=3|RACE=NAGA
}
public class VAC_954e1:Ability{
//NAME=海妖欢歌
//TEXT=法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_955:MinionBase{
//NAME=戈贡佐姆
//TEXT=<b>战吼：</b>获取一张 法力值消耗为（2）的奶酪。奶酪可以召唤三个法力值消耗为（1）的随从，且每回合都会升级。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class VAC_955t:SpellBase{
//NAME=美味奶酪
//TEXT=随机召唤三个法力值消耗为（1）的随从。<i>（每回合都会升级！）</i>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class VAC_956:MinionBase{
//NAME=XB-931型家政机
//TEXT=在你使用一个 地标效果后，获得3点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class VAC_957:MinionBase{
//NAME=惬意的沃金
//TEXT=<b>猎人游客</b> <b>战吼：</b>选择2个随从，交换其属性值。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=NONE
}
public class VAC_957e:Ability{
//NAME=灵魂互换
//TEXT=属性值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_958:MinionBase{
//NAME=进化融合怪
//TEXT=<i>本随从拥有全部随从类型。</i><b>亡语：</b>将本随从洗入你的牌库。保留所有附加效果。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=ALL
}
public class VAC_959:MinionBase{
//NAME=诚信商家格里伏塔
//TEXT=<b>战吼：</b><b>发现</b>一款神奇的护符，赠予双方玩家。<i>（敌人的护符为伪劣版本！）</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class VAC_959t01:SpellBase{
//NAME=迷情护符
//TEXT=直到你的回合结束，夺取一个敌方随从的控制权。<i>（在本回合中其攻击力为1！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t01e:Ability{
//NAME=情感之力
//TEXT=在本回合中，本随从的控制权发生了变化。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t01e2:Ability{
//NAME=虚假情意
//TEXT=在本回合中，攻击力变为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t01t:SpellBase{
//NAME=迷情护符
//TEXT=直到你的回合结束，夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t05:SpellBase{
//NAME=追踪护符
//TEXT=随机获取3张<b>传说</b>卡牌。<i>（然后将其变形成为<b>普通</b>卡牌！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t05t:SpellBase{
//NAME=追踪护符
//TEXT=随机获取3张<b>传说</b>卡牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t06:SpellBase{
//NAME=生灵护符
//TEXT=随机召唤一个法力值消耗为（4）的随从并使其获得<b>嘲讽</b>。<i>（但它无法攻击！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t06e:Ability{
//NAME=伪造
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t06t:SpellBase{
//NAME=生灵护符
//TEXT=随机召唤一个法力值消耗为（4）的随从并使其获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t07:SpellBase{
//NAME=守卫护符
//TEXT=造成$6点伤害。<i>（仅可对随从！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t07t:SpellBase{
//NAME=守卫护符
//TEXT=造成$6点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t08:SpellBase{
//NAME=能量护符
//TEXT=为你的英雄恢复#12点生命值。<i>（然后受到$6点伤害！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t08t:SpellBase{
//NAME=能量护符
//TEXT=为你的英雄恢复#12点生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t09:SpellBase{
//NAME=灵动护符
//TEXT=抽三张牌。<i>（弃掉其中两张！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t09t:SpellBase{
//NAME=灵动护符
//TEXT=抽三张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t10:SpellBase{
//NAME=挺进护符
//TEXT=使你手牌中的所有卡牌的法力值消耗减少（1）点。<i>（法术牌除外！）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_959t10t:SpellBase{
//NAME=挺进护符
//TEXT=使你手牌中的所有卡牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class VAC_960:WeaponBase{
//NAME=可靠的鱼竿
//TEXT=在你的英雄攻击后，从你的牌库中召唤一个法力值消耗为（1）的随从。
//MAJ=HUNTER|COST=3|ATK=1|HP=2|RACE=NONE
}
public class VAC_961:MinionBase{
//NAME=宠物鹦鹉
//TEXT=<b>战吼：</b>重复你使用的上一张法力值消耗为（1）的牌。
//MAJ=HUNTER|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class VAC_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class VAC_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
