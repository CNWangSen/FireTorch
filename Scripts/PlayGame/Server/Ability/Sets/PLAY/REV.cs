using System.Collections;
using System.Collections.Generic;

public class REV_000:MinionBase{
//NAME=可疑的炼金师
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。你的对手如果猜中了你的选择，即可获取一张复制。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class REV_000e:Ability{
//NAME=神秘谜题
//TEXT=在你的回合开始时，猜测你的对手选择了哪张牌，猜中即可获取复制。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_002:MinionBase{
//NAME=可疑的侍应
//TEXT=<b>战吼：</b><b>发现</b>一张<b>传说</b>随从牌。你的对手如果猜中了你的选择，即可获取一张复制。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class REV_006:MinionBase{
//NAME=可疑的海盗
//TEXT=<b>战吼：</b><b>发现</b>一张武器牌。你的对手如果猜中了你的选择，即可获取一张复制。
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=PIRATE
}
public class REV_011:MinionBase{
//NAME=嫉妒收割者
//TEXT=在你使用一张对手的卡牌的复制后，偷取本体。
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=NONE
}
public class REV_011e:Ability{
//NAME=从对手处复制
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_012:MinionBase{
//NAME=沼泽兽
//TEXT=<b>嘲讽</b>，<b>亡语：</b>召唤一滩2/4并具有<b>嘲讽</b>的泥浆。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=6|RACE=NONE
}
public class REV_012t:MinionBase{
//NAME=泥浆
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class REV_013:MinionBase{
//NAME=石裔指控者
//TEXT=<b>注能（5）：</b>获得“<b>战吼：</b>造成5点伤害。”
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class REV_013t:MinionBase{
//NAME=石裔指控者
//TEXT=<b>已注能</b> <b>战吼：</b>造成5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class REV_014:MinionBase{
//NAME=红鲱鱼
//TEXT=<b>嘲讽</b>。你的非红鲱鱼随从拥有<b>潜行</b>。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=12|RACE=BEAST
}
public class REV_015:MinionBase{
//NAME=假面狂欢者
//TEXT=<b>突袭</b>，<b>亡语：</b>召唤你牌库中另一个随从的2/2的复制。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class REV_015t:Ability{
//NAME=变装
//TEXT=2/2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_016:MinionBase{
//NAME=邪恶的厨师
//TEXT=在你的回合结束时，如果你已对敌方英雄造成3点或更多伤害，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class REV_016e:Ability{
//NAME=可疑的汤
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_017:MinionBase{
//NAME=贪食的吞噬者
//TEXT=<b>战吼：</b>吞食一个敌方随从并获得其属性值。<b>注能（5）：</b>还会吞食相邻随从。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=4|RACE=NONE
}
public class REV_017e:Ability{
//NAME=酒足饭饱
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_017t:MinionBase{
//NAME=贪食的吞噬者
//TEXT=<b>已注能</b> <b>战吼：</b>吞食一个敌方随从及其相邻随从并获得它们的属性值。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=4|RACE=NONE
}
public class REV_018:MinionBase{
//NAME=雷纳索尔王子
//TEXT=你的套牌容量和初始生命值为40。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		TaskBuffMyHero(hp:10);
		this.UnRegisterEventEffect();
	}
}
public class REV_019:MinionBase{
//NAME=饥饿的愚人
//TEXT=<b>战吼：</b>抽一张牌。<b>注能（4）：</b>改为抽三张牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=NONE
}
public class REV_019t:MinionBase{
//NAME=饥饿的愚人
//TEXT=<b>已注能</b> <b>战吼：</b>抽三张牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=NONE
}
public class REV_020:MinionBase{
//NAME=晚宴表演者
//TEXT=<b>战吼：</b>随机从你的牌库中召唤一个你有足够的法力值使用的随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class REV_021:MinionBase{
//NAME=逐罪者凯尔萨斯
//TEXT=在每回合中，你每使用三张随从牌，第三张随从牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=7|RACE=NONE
}
public class REV_021e:Ability{
//NAME=逐罪者
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_022:MinionBase{
//NAME=摩洛克·福尔摩斯
//TEXT=<b>战吼：</b>破解你对手卡牌的3条线索，即可获取其复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MURLOC
}
public class REV_023:MinionBase{
//NAME=拆迁修理工
//TEXT=<b>可交易</b> <b>战吼：</b>摧毁一个敌方地标。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class REV_238:MinionBase{
//NAME=癫狂公爵西塔尔
//TEXT=<b>战吼：</b>从每个玩家的手牌中各<b>发现</b>一张牌并交换。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class REV_239:SpellBase{
//NAME=窒息暗影
//TEXT=当你使用或弃掉这张牌时，随机消灭一个敌方随从。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class REV_239e:Ability{
//NAME=窒息
//TEXT=法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_240:SpellBase{
//NAME=篡改卷宗
//TEXT=将你手牌的复制洗入你的牌库，其法力值消耗为（1）点。然后弃掉你的手牌。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=NONE
}
public class REV_240e:Ability{
//NAME=消耗诅咒
//TEXT=法力值消耗为（1）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_242:MinionBase{
//NAME=慌乱的图书管理员
//TEXT=你每控制一个小鬼，拥有+1攻击力。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=NONE
}
public class REV_244:MinionBase{
//NAME=调皮的小鬼
//TEXT=<b>战吼：</b>召唤一个本随从的复制。<b>注能（3）：</b>改为召唤两个复制。
//MAJ=WARLOCK|COST=4|ATK=3|HP=3|RACE=DEMON
}
public class REV_244t:MinionBase{
//NAME=调皮的小鬼
//TEXT=<b>已注能 战吼：</b>召唤本随从的两个复制。
//MAJ=WARLOCK|COST=4|ATK=3|HP=3|RACE=DEMON
}
public class REV_245:SpellBase{
//NAME=灾祸降临
//TEXT=抽一张牌。你每控制一个小鬼，重复一次。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class REV_246:MinionBase{
//NAME=神秘访客
//TEXT=<b>战吼：</b>使你从对手处复制的卡牌的法力值消耗减少（3）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class REV_246e2:Ability{
//NAME=读心
//TEXT=法力值消耗减少（3）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_247:MinionBase{
//NAME=共犯
//TEXT=<b>战吼：</b>在你的回合结束时，召唤一个本随从的复制。
//MAJ=PRIEST|COST=4|ATK=2|HP=5|RACE=NONE
}
public class REV_247e:Ability{
//NAME=不在场证明
//TEXT=在你的回合结束时，召唤一个本随从的复制。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_248:SpellBase{
//NAME=晋升者之赐
//TEXT=使一个随从获得+2生命值。召唤一个具有该随从属性值和<b>嘲讽</b>的格里恩。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class REV_248e:Ability{
//NAME=晋升者之赐
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_248t:MinionBase{
//NAME=晋升的格里恩
//TEXT=<b>嘲讽</b>
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=NONE
}
public class REV_249:SpellBase{
//NAME=炽燃圣光
//TEXT=对一个随从造成等同于其攻击力的伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class REV_250:MinionBase{
//NAME=裴拉戈斯
//TEXT=在你对一个友方随从施放法术后，将其生命值和攻击力变为两者中的高值。
//MAJ=PRIEST|COST=3|ATK=1|HP=6|RACE=NONE
}
public class REV_250e1:Ability{
//NAME=裴拉戈斯的祝福
//TEXT=属性值变为高值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_250e2:Ability{
//NAME=裴拉戈斯的祝福
//TEXT=属性值变为高值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_251:MinionBase{
//NAME=罪奔者
//TEXT=<b>亡语：</b>随机消灭一个敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=BEAST
}
public class REV_252:SpellBase{
//NAME=净场
//TEXT=消灭所有攻击力小于或等于3的随从。<b>注能（3）：</b>改为小于或等于6。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class REV_252t:SpellBase{
//NAME=净场
//TEXT=<b>已注能</b> 消灭所有攻击力小于或等于6的随从。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class REV_253:SpellBase{
//NAME=盗用身份
//TEXT=<b>发现</b>你对手的手牌和牌库中各一张牌的复制。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class REV_290:LocationBase{
//NAME=赎罪教堂
//TEXT=使一个随从获得+2/+1。抽一张牌。
//MAJ=PRIEST|COST=3|ATK=0|HP=3|RACE=NONE
}
public class REV_290e:Ability{
//NAME=宽赦
//TEXT=+2/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_307:SpellBase{
//NAME=自然死亡
//TEXT=造成$2点伤害。召唤一个2/2的树人。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class REV_308:MinionBase{
//NAME=迷宫向导
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
}
public class REV_310:MinionBase{
//NAME=死亡之花践踏者
//TEXT=<b>战吼：</b>抽一张<b>亡语</b>随从牌并获得其<b>亡语</b>。
//MAJ=DRUID|COST=5|ATK=6|HP=5|RACE=NONE
}
public class REV_310e:Ability{
//NAME=踩踏
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_311:SpellBase{
//NAME=夜影花蕾
//TEXT=<b>抉择：</b>从你的牌库中<b>发现</b>一张随从牌并召唤；或者一张法术牌并施放。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class REV_311t:SpellBase{
//NAME=日间绽放
//TEXT=从你的牌库中<b>发现</b>一张法术牌并施放。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class REV_311t2:SpellBase{
//NAME=月下绽放
//TEXT=从你的牌库中<b>发现</b>一张随从牌并召唤。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class REV_313:SpellBase{
//NAME=安插证据
//TEXT=<b>发现</b>一张法术牌。在本回合中，其法力值消耗减少（2）点。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class REV_313e:Ability{
//NAME=收获法术
//TEXT=在本回合中，法力值消耗减少（2）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_314:MinionBase{
//NAME=灌木巨龙托匹奥
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，在你施放一个自然法术后，召唤一条3/3并具有<b>突袭</b>的雏龙。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=DRAGON
}
public class REV_314e:Ability{
//NAME=寒冬女王的赐福
//TEXT=在本局对战的剩余时间内，在你使用一张自然法术牌后，召唤一条3/3的龙。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_314t:MinionBase{
//NAME=灌木雏龙
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class REV_316:MinionBase{
//NAME=活体利刃蕾茉妮雅
//TEXT=<b>突袭</b> 在本随从攻击后，装备它。
//MAJ=WARRIOR|COST=7|ATK=5|HP=10|RACE=NONE
}
public class REV_316e:Ability{
//NAME=Remornia's Will
//TEXT=Has the stats of Remornia.
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_316t:WeaponBase{
//NAME=活体利刃蕾茉妮雅
//TEXT=在你的英雄攻击后，将这把剑移回战场。
//MAJ=WARRIOR|COST=7|ATK=5|HP=10|RACE=NONE
}
public class REV_318:MinionBase{
//NAME=孀花播种者
//TEXT=<b>战吼：</b>抽一张自然法术牌。获得一个空的法力水晶。
//MAJ=DRUID|COST=4|ATK=3|HP=2|RACE=NONE
}
public class REV_318e:Ability{
//NAME=生命的循环
//TEXT=使用卡牌，获得一个空的法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_318e2:Ability{
//NAME=使用卡牌附加效果
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_319:MinionBase{
//NAME=法夜朝臣瑟赛莉
//TEXT=<b>嘲讽</b>，<b>亡语：</b>抽一张随从牌，并使其法力值消耗减少（8）点。
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		Card Drawn = TaskDrawType(CardType.Minion);
		new EffectChange(owner.myPlayer,owner,Drawn,manaChange:-8).Resolve();
	}
}
public class REV_319e:Ability{
//NAME=瑟赛莉的祝福
//TEXT=法力值消耗减少（8）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_332:MinionBase{
//NAME=心能提取者
//TEXT=每当一个友方随从受到伤害，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
}
public class REV_332e:Ability{
//NAME=已提取
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_333:LocationBase{
//NAME=树篱迷宫
//TEXT=触发一个友方随从的<b>亡语</b>。
//MAJ=DRUID|COST=3|ATK=0|HP=2|RACE=NONE
}
public class REV_334:SpellBase{
//NAME=骄傲罪责
//TEXT=召唤三个1/3并具有<b>嘲讽</b>的狱卒。如果你的生命值小于或等于20点，使其获得+1/+1。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class REV_334e:Ability{
//NAME=Empowered
//TEXT=+1/+1.
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_334t:MinionBase{
//NAME=赤红狱卒
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=2|ATK=1|HP=3|RACE=NONE
}
public class REV_336:SpellBase{
//NAME=罪恶谋划
//TEXT=召唤两个2/2的树人。<b>注能（5）：</b>改为两个5/5的古树。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class REV_336t2:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class REV_336t3:MinionBase{
//NAME=古树
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class REV_336t4:SpellBase{
//NAME=罪恶谋划
//TEXT=<b>已注能</b> 召唤两个5/5的古树。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class REV_337:SpellBase{
//NAME=动乱
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。使其分别随机攻击一个敌方随从。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_337e:Ability{
//NAME=动乱
//TEXT=在本回合中，生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_337e2:Ability{
//NAME=动乱
//TEXT=在本回合中，你的随从的生命值无法被降到1点以下。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_338:MinionBase{
//NAME=泥仆员工
//TEXT=<b>战吼：</b>使你手牌中的随从牌获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class REV_338e:Ability{
//NAME=削磨时间
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_350:SpellBase{
//NAME=狂暴利齿
//TEXT=召唤两只2/1的蝙蝠。<b>注能（3）：</b>使其获得+1/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_350e:Ability{
//NAME=嗜血渴望
//TEXT=+1/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_350t:MinionBase{
//NAME=饥渴的蝙蝠
//TEXT=
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class REV_350t2:SpellBase{
//NAME=狂暴利齿
//TEXT=<b>已注能</b> 召唤两只2/1的蝙蝠。使其获得+1/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_351:MinionBase{
//NAME=栖巢石像鬼
//TEXT=<b>战吼：</b>使一只友方野兽获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class REV_351e:Ability{
//NAME=精力充沛
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_352:MinionBase{
//NAME=石缚加尔贡
//TEXT=<b>突袭</b>，<b>注能（3）：</b>同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class REV_352t:MinionBase{
//NAME=石缚加尔贡
//TEXT=<b>已注能</b> <b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class REV_353:MinionBase{
//NAME=猎手阿尔迪莫
//TEXT=<b>战吼：</b>召唤一个加尔贡伙伴。<b>注能（{0}）：</b>再召唤一个。<b>注能（{1}）：</b>再召唤一个！
//MAJ=HUNTER|COST=7|ATK=5|HP=4|RACE=NONE
}
public class REV_353t:MinionBase{
//NAME=猎手阿尔迪莫
//TEXT=<b>已注能</b> <b>战吼：</b>召唤2个加尔贡伙伴。<b>注能（4）：</b>召唤全部3个。
//MAJ=HUNTER|COST=7|ATK=5|HP=4|RACE=NONE
}
public class REV_353t2:MinionBase{
//NAME=猎手阿尔迪莫
//TEXT=<b>已注能</b> <b>战吼：</b>召唤全部3个加尔贡伙伴。
//MAJ=HUNTER|COST=7|ATK=5|HP=4|RACE=NONE
}
public class REV_353t3:MinionBase{
//NAME=赫库提斯
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=4|RACE=BEAST
}
public class REV_353t4:MinionBase{
//NAME=巴加斯特
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class REV_353t4e:Ability{
//NAME=石中之骨
//TEXT=巴加斯特使本随从获得+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_353t5:MinionBase{
//NAME=玛尔苟
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class REV_356:MinionBase{
//NAME=狂蝠来宾
//TEXT=<b>亡语：</b>召唤一只2/1的蝙蝠。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("REV_350t"),ZoneType.Board);
	}
}
public class REV_360:MinionBase{
//NAME=灵体偷猎者
//TEXT=<b>战吼：</b>随机召唤一个<b>休眠</b>的灵种。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class REV_360t:MinionBase{
//NAME=狐灵之种
//TEXT=<b>休眠</b>1回合。 <b>突袭</b>
//MAJ=HUNTER|COST=1|ATK=3|HP=1|RACE=BEAST
}
public class REV_360t1:MinionBase{
//NAME=熊灵之种
//TEXT=<b>休眠</b>2回合。<b>嘲讽</b>
//MAJ=HUNTER|COST=2|ATK=2|HP=5|RACE=BEAST
}
public class REV_360t1e:Ability{
//NAME=成年的灵种
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_360t2:MinionBase{
//NAME=鹿灵之种
//TEXT=<b>休眠</b>3回合。唤醒时，装备一把4/2的巨弓。
//MAJ=HUNTER|COST=3|ATK=5|HP=4|RACE=BEAST
}
public class REV_360t2e:Ability{
//NAME=年长的灵种
//TEXT=<b>休眠</b>。 3回合后唤醒。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_360t4:WeaponBase{
//NAME=鹿角灵弓
//TEXT=
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=NONE
}
public class REV_360te:Ability{
//NAME=年少的灵种
//TEXT=<b>休眠</b>。 1回合后唤醒。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_361:SpellBase{
//NAME=野性之魂
//TEXT=召唤两个不同的<b>休眠</b>灵种。使你的灵种提前1回合唤醒。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class REV_362:LocationBase{
//NAME=城堡狗舍
//TEXT=使一个友方随从获得+2攻击力。如果是野兽，还会使其获得<b>突袭</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=3|RACE=NONE
}
public class REV_362e:Ability{
//NAME=野兽模式
//TEXT=+2攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_362e2:Ability{
//NAME=抗性
//TEXT=在本回合中<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_363:MinionBase{
//NAME=艾拉隆
//TEXT=<b>战吼：</b>召唤每种<b>休眠</b>灵种各一个。
//MAJ=HUNTER|COST=5|ATK=4|HP=5|RACE=NONE
}
public class REV_364:SpellBase{
//NAME=雄鹿冲锋
//TEXT=造成$3点伤害。随机召唤一个<b>休眠</b>的灵种。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class REV_365:SpellBase{
//NAME=万灵之召
//TEXT=随机施放8个德鲁伊法术<i>（目标随机而定）</i>。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NATURE
}
public class REV_369:SpellBase{
//NAME=间接伤害
//TEXT=随机对三个敌方随从造成$6点伤害。超过目标生命值的伤害会命中敌方英雄。
//MAJ=HUNTER|COST=8|ATK=0|HP=0|RACE=NONE
}
public class REV_370:MinionBase{
//NAME=派对捣蛋鬼
//TEXT=<b>战吼：</b>选择一个敌方随从。随机将你手牌中的一个随从投向选中的随从。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=9|RACE=NONE
}
public class REV_371:LocationBase{
//NAME=邪恶图书馆
//TEXT=使一个友方随从获得+1/+1。你每控制一个小鬼，重复一次。
//MAJ=WARLOCK|COST=2|ATK=0|HP=2|RACE=NONE
}
public class REV_371e:Ability{
//NAME=小鬼之力
//TEXT=+1/+1。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_372:SpellBase{
//NAME=暗影华尔兹
//TEXT=召唤一个3/5并具有<b>嘲讽</b>的影子。如果在本回合中有随从死亡，再召唤一个。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class REV_372t:MinionBase{
//NAME=旋舞之影
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=5|ATK=3|HP=5|RACE=UNDEAD
}
public class REV_373:MinionBase{
//NAME=暗脉女勋爵
//TEXT=<b>战吼：</b>召唤两个2/1的阴影。每个阴影获得一个<b>亡语</b>以施放你的上一个暗影法术。
//MAJ=WARLOCK|COST=5|ATK=3|HP=6|RACE=NONE
}
public class REV_373e:Ability{
//NAME=黑暗常驻
//TEXT=含有法术{0}！
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_373t:MinionBase{
//NAME=具象暗影
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class REV_374:MinionBase{
//NAME=影裔魔
//TEXT=<b>亡语：</b>使你手牌中法力值消耗最高的暗影法术牌的法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class REV_374e:Ability{
//NAME=暗影环绕
//TEXT=法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_375:MinionBase{
//NAME=石裔干将
//TEXT=<b>突袭</b>，<b>亡语：</b>召唤一只8/8并具有<b>突袭</b>的墓翼蝠。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=NONE
}
public class REV_375t:MinionBase{
//NAME=墓翼蝠
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
}
public class REV_377:MinionBase{
//NAME=邀请函信使
//TEXT=在另一职业的卡牌被置入你的手牌后，复制置入的牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class REV_378:MinionBase{
//NAME=涂粉取证师
//TEXT=<b>战吼：</b>下个回合你的对手随从牌的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class REV_378e:Ability{
//NAME=扫粉
//TEXT=在本回合中，你的随从牌的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_378e2:Ability{
//NAME=发现！
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_504:SpellBase{
//NAME=脱罪力证
//TEXT=直到你的下个回合，你的英雄每次只会受到1点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class REV_504e:Ability{
//NAME=脱罪力证
//TEXT=直到你的下回合开始，你的英雄每次只会受到1点伤害。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_505:SpellBase{
//NAME=冰冷案例
//TEXT=召唤两个2/2的不稳定的骷髅。获得4点护甲值。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FROST
}
public class REV_506:SpellBase{
//NAME=罪孽烙印
//TEXT=标记一个敌方随从。每当该随从受到伤害，对敌方英雄造成1点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_506e:Ability{
//NAME=烙印
//TEXT=每当本随从受到伤害，对你的英雄造成1点伤害。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_506e2:Ability{
//NAME=烙印
//TEXT=法力值消耗增加（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_507:SpellBase{
//NAME=处理证据
//TEXT=在本回合中，使你的英雄获得+3攻击力。选择一张你的手牌洗入你的牌库。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_507e:Ability{
//NAME=处理证据
//TEXT=在本回合中+3攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_508:SpellBase{
//NAME=次元圣物
//TEXT=抽两张牌并使其法力值消耗降低（1）点。提升你此后的圣物效果。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class REV_508e:Ability{
//NAME=次元转换
//TEXT=法力值消耗减少。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_509:WeaponBase{
//NAME=放大战刃
//TEXT=在你的英雄攻击后，抽牌，直到你拥有三张牌。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class REV_510:MinionBase{
//NAME=贪食的克里克西斯
//TEXT=<b>战吼：</b>弃掉你的手牌。<b>亡语：</b>抽三张牌。
//MAJ=DEMONHUNTER|COST=4|ATK=7|HP=7|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero();
		List<Card> ToListDiscard = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			ToListDiscard.Add(c);
		}
		foreach(Card c in ToListDiscard)
		{
			new EffectMove(owner.myPlayer,c,ZoneType.Hand,ZoneType.Grave).Resolve();
		}
	}
	public override void Deathrattle()
	{
		TaskDraw();
		TaskDraw();
		TaskDraw();
	}
}
public class REV_511:MinionBase{
//NAME=案卷书虫
//TEXT=<b>战吼：</b>选择一张你的手牌洗入你的牌库。
//MAJ=DEMONHUNTER|COST=2|ATK=5|HP=4|RACE=NONE
}
public class REV_513:MinionBase{
//NAME=健谈的调酒师
//TEXT=在你的回合结束时，如果你控制一个<b>奥秘</b>，对所有敌人造成2点伤害。
//MAJ=MAGE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class REV_514:MinionBase{
//NAME=天定之灾克尔苏加德
//TEXT=<b>战吼：</b>复活你的不稳定的骷髅。战场上放不下的骷髅会立即爆炸。0<i>（复活0个）</i>
//MAJ=MAGE|COST=8|ATK=6|HP=8|RACE=UNDEAD
}
public class REV_515:MinionBase{
//NAME=豪宅管家俄里翁
//TEXT=在一个友方<b>奥秘</b>被揭示后，施放一个不同的法师<b>奥秘</b>并获得+2/+2。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class REV_515e:Ability{
//NAME=宇宙之力
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_516:SecretBase{
//NAME=复仇之像
//TEXT=<b>奥秘：</b>在一个敌方随从攻击你的英雄后，召唤一个它的复制并使其攻击敌方英雄。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class REV_517:SpellBase{
//NAME=罪犯列队
//TEXT=选择一个友方随从。召唤3个它的复制。<b>过载：</b>（2）
//MAJ=SHAMAN|COST=8|ATK=0|HP=0|RACE=NONE
}
public class REV_601:SpellBase{
//NAME=冰冻之触
//TEXT=造成$3点伤害。<b>注能（3）：</b>将一张冰冻之触置入你的手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class REV_601t:SpellBase{
//NAME=冰冻之触
//TEXT=<b>已注能</b> 造成$3点伤害。将一张冰冻之触置入你的手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class REV_602:LocationBase{
//NAME=夜隐者圣所
//TEXT=<b>冻结</b>一个随从。召唤一个2/2的不稳定的骷髅。
//MAJ=MAGE|COST=3|ATK=0|HP=3|RACE=NONE
}
public class REV_750:LocationBase{
//NAME=罪碑坟场
//TEXT=召唤一个1/1的幽灵。<i>（在本回合中每有一张其他牌被使用，拥有+1/+1！）</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=2|RACE=NONE
}
public class REV_750t2:MinionBase{
//NAME=不安之魂
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class REV_770:HeroBase{
//NAME=摩洛克·福尔摩斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=10|RACE=NONE
}
public class REV_770hp:HeroPowerBase{
//NAME=指控
//TEXT=<b>英雄技能</b> 发起一项指控！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_771:SpellBase{
//NAME=调查
//TEXT=寻找线索。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class REV_771b:SpellBase{
//NAME=调查地标
//TEXT=寻找线索。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class REV_777t00:SpellBase{
//NAME=？？？
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t01:SpellBase{
//NAME=沾泥的靴子
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t02:SpellBase{
//NAME=灰白的毛发
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t03:SpellBase{
//NAME=尖利的爪子
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t04:SpellBase{
//NAME=浓烈的香水
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t05:SpellBase{
//NAME=烧焦的衣物
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t06:SpellBase{
//NAME=铭文爱好
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t07:SpellBase{
//NAME=切到了手
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t08:SpellBase{
//NAME=频繁吸嗅
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t09:SpellBase{
//NAME=失踪的耳环
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t10:SpellBase{
//NAME=宠物鸟
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t11:SpellBase{
//NAME=切削小刀
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t12:SpellBase{
//NAME=破损的披风
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t13:SpellBase{
//NAME=带着蜡烛
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t14:SpellBase{
//NAME=吃着饼干
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t15:SpellBase{
//NAME=催人泪下的言情小说
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t16:SpellBase{
//NAME=干燥的皮肤
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t17:SpellBase{
//NAME=手指上的巧克力
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t18:SpellBase{
//NAME=头发里的花
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t19:SpellBase{
//NAME=喜爱辣味食物
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t20:SpellBase{
//NAME=娇小的手掌
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t21:SpellBase{
//NAME=地上的泥渍
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t22:SpellBase{
//NAME=灰色的毛发
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t23:SpellBase{
//NAME=爪子的痕迹
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t24:SpellBase{
//NAME=麝香气味
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t25:SpellBase{
//NAME=灼烧的痕迹
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t26:SpellBase{
//NAME=墨水渍
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t27:SpellBase{
//NAME=心能残渣
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t28:SpellBase{
//NAME=用过的手帕
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t29:SpellBase{
//NAME=艳俗的耳环
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t30:SpellBase{
//NAME=羽毛
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t31:SpellBase{
//NAME=木刨花
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t32:SpellBase{
//NAME=碎布片
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t33:SpellBase{
//NAME=蜡油滴
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t34:SpellBase{
//NAME=碎屑
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t35:SpellBase{
//NAME=失踪的花镜
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t36:SpellBase{
//NAME=白色薄片
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t37:SpellBase{
//NAME=糖纸
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t38:SpellBase{
//NAME=小巧的花瓣
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t39:SpellBase{
//NAME=辣酱液滴
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_777t40:SpellBase{
//NAME=小号的手套
//TEXT=？？？
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_780:MinionBase{
//NAME=艾拉隆
//TEXT={0} {1} {2} {3}
//MAJ=HUNTER|COST=5|ATK=4|HP=5|RACE=NONE
}
public class REV_781:MinionBase{
//NAME=裴拉戈斯
//TEXT={0} {1} {2} {3}
//MAJ=PRIEST|COST=3|ATK=1|HP=6|RACE=NONE
}
public class REV_782:MinionBase{
//NAME=法夜朝臣瑟赛莉
//TEXT={0} {1} {2} {3}
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=NONE
}
public class REV_783:MinionBase{
//NAME=屠戮者奥格拉
//TEXT={0} {1} {2} {3}
//MAJ=WARRIOR|COST=6|ATK=3|HP=7|RACE=NONE
}
public class REV_784:MinionBase{
//NAME=执事者斯图尔特
//TEXT={0} {1} {2} {3}
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class REV_785:MinionBase{
//NAME=通灵领主德拉卡
//TEXT={0} {1} {2} {3}
//MAJ=ROGUE|COST=4|ATK=3|HP=4|RACE=NONE
}
public class REV_786:MinionBase{
//NAME=天定之灾克尔苏加德
//TEXT={0} {1} {2} {3}
//MAJ=MAGE|COST=8|ATK=6|HP=8|RACE=NONE
}
public class REV_787:MinionBase{
//NAME=圣物匠赛·墨克斯
//TEXT={0} {1} {2} {3}
//MAJ=DEMONHUNTER|COST=8|ATK=8|HP=8|RACE=NONE
}
public class REV_788:MinionBase{
//NAME=瓦丝琪女男爵
//TEXT={0} {1} {2} {3}
//MAJ=SHAMAN|COST=4|ATK=3|HP=6|RACE=NAGA
}
public class REV_789:MinionBase{
//NAME=小鬼大王拉法姆
//TEXT={0} {1} {2} {3}
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=NONE
}
public class REV_790:LocationBase{
//NAME=城堡狗舍
//TEXT={0}{1}
//MAJ=HUNTER|COST=2|ATK=0|HP=3|RACE=NONE
}
public class REV_791:LocationBase{
//NAME=赎罪教堂
//TEXT={0}{1}
//MAJ=PRIEST|COST=3|ATK=0|HP=3|RACE=NONE
}
public class REV_792:LocationBase{
//NAME=树篱迷宫
//TEXT={0}{1}
//MAJ=DRUID|COST=3|ATK=0|HP=2|RACE=NONE
}
public class REV_793:LocationBase{
//NAME=赤红深渊
//TEXT={0}{1}
//MAJ=WARRIOR|COST=1|ATK=0|HP=3|RACE=NONE
}
public class REV_794:LocationBase{
//NAME=大厅
//TEXT={0}{1}
//MAJ=PALADIN|COST=2|ATK=0|HP=3|RACE=NONE
}
public class REV_795:LocationBase{
//NAME=罪碑坟场
//TEXT={0}{1}
//MAJ=ROGUE|COST=2|ATK=0|HP=2|RACE=NONE
}
public class REV_796:LocationBase{
//NAME=夜隐者圣所
//TEXT={0}{1}
//MAJ=MAGE|COST=3|ATK=0|HP=3|RACE=NONE
}
public class REV_797:LocationBase{
//NAME=圣物仓库
//TEXT={0}{1}
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=2|RACE=NONE
}
public class REV_798:LocationBase{
//NAME=淤泥之池
//TEXT={0}{1}
//MAJ=SHAMAN|COST=1|ATK=0|HP=3|RACE=NONE
}
public class REV_799:LocationBase{
//NAME=邪恶图书馆
//TEXT={0}{1}
//MAJ=WARLOCK|COST=2|ATK=0|HP=2|RACE=NONE
}
public class REV_825:SecretBase{
//NAME=双面生意
//TEXT=<b>奥秘：</b>当你的对手消耗了其所有法力值时，抽两张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_826:MinionBase{
//NAME=私家眼线
//TEXT=<b>战吼：</b>从你的牌库中施放一个<b>奥秘</b>。<b>连击：</b>改为施放2个。
//MAJ=ROGUE|COST=4|ATK=3|HP=4|RACE=NONE
}
public class REV_827:SecretBase{
//NAME=缠人处境
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，召唤一只3/4并具有<b>潜行</b>的蜘蛛。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_827t:MinionBase{
//NAME=墓穴爬蛛
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class REV_828:SecretBase{
//NAME=绑架
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，将其装入一个0/4的袋子。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_828e:Ability{
//NAME=绑架犯的袋子
//TEXT={0}在袋子里！
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_828t:MinionBase{
//NAME=绑架犯的袋子
//TEXT=<b>亡语：</b>将你对手被绑架的随从移回其手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=4|RACE=NONE
}
public class REV_829:MinionBase{
//NAME=哈尔吉亚斯
//TEXT=<b>潜行</b>。<b>亡语：</b>将哈尔吉亚斯的灵魂储存在一个友方<b>奥秘</b>中。当其被触发时，重新召唤哈尔吉亚斯。
//MAJ=ROGUE|COST=4|ATK=5|HP=4|RACE=ELEMENTAL
}
public class REV_829e:Ability{
//NAME=哈尔吉亚斯的碎片
//TEXT=盛放着哈尔吉亚斯的灵魂。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_834:SpellBase{
//NAME=灭绝圣物
//TEXT=随机对一个敌方随从造成$1点伤害，触发两次。提升你此后的圣物效果。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public static int CNT=1;
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomEnemyMinion(REV_834.CNT);
		TaskDamageRandomEnemyMinion(REV_834.CNT);
		REV_834.CNT+=1;
	}
}
public class REV_835:MinionBase{
//NAME=小鬼大王拉法姆
//TEXT=<b>战吼：</b>复活四个友方小鬼。<b>注能（5）：</b>使你的小鬼获得+2/+2。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=NONE
}
public class REV_835e:Ability{
//NAME=小鬼注能
//TEXT=+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_835t:MinionBase{
//NAME=小鬼大王拉法姆
//TEXT=<b>已注能</b> <b>战吼：</b>召唤四个在本局对战中死亡的友方小鬼。使你的小鬼获得+2/+2。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=NONE
}
public class REV_837:MinionBase{
//NAME=淤泥水管工
//TEXT=所有随从牌的法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class REV_837e:Ability{
//NAME=啐！
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_838:MinionBase{
//NAME=图腾巨像
//TEXT=在本局对战中，你每召唤一个图腾，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=10|ATK=8|HP=8|RACE=TOTEM
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
			{
				int Cnt=0;
				foreach(Card c in owner.myPlayer.grave.Merge(owner.myPlayer.board))
				{
					if(c.raceType.Contains(RaceType.Totem))
					{
						Cnt+=1;
					}
				}
				return -Cnt;
			}
		}
		return 0;
	}
}
public class REV_839:MinionBase{
//NAME=罪碑图腾
//TEXT=在你的回合结束时，获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=TOTEM
}
public class REV_839e:Ability{
//NAME=罪孽之石
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_840:SpellBase{
//NAME=死神之躯
//TEXT=对所有随从造成$2点伤害。每消灭一个随从，召唤一个2/2的不稳定的骷髅。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=FROST
}
public class REV_841:MinionBase{
//NAME=匿名线人
//TEXT=<b>战吼：</b>你使用的下一张<b>奥秘</b>牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class REV_841e:Ability{
//NAME=获得线报
//TEXT=你的下一个奥秘的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_841e2:Ability{
//NAME=获得线报
//TEXT=你的下一个奥秘的法力值消耗为（0）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_842:SpellBase{
//NAME=晋升
//TEXT=使一个白银之手新兵获得+3/+3和<b>嘲讽</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class REV_842e:Ability{
//NAME=提升
//TEXT=+3/+3和<b>嘲讽</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_842e2:Ability{
//NAME=新的领导
//TEXT=+2攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_843:MinionBase{
//NAME=罪能魔像
//TEXT=<b>注能（3）：</b>获得属性值，数值等同于为本随从<b>注能</b>的随从的攻击力。
//MAJ=NEUTRAL|COST=7|ATK=2|HP=2|RACE=NONE
}
public class REV_843e:Ability{
//NAME=注入心能
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_843t:MinionBase{
//NAME=罪能魔像
//TEXT=<b>已注能</b>
//MAJ=NEUTRAL|COST=7|ATK=2|HP=2|RACE=NONE
}
public class REV_845:MinionBase{
//NAME=不稳定的骷髅
//TEXT=<b>亡语：</b>随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class REV_900:MinionBase{
//NAME=谣言食尸鬼
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你控制一个<b>奥秘</b>，便召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class REV_901:MinionBase{
//NAME=离躯之魂
//TEXT=<b>战吼：</b>如果你控制一个地标，<b>发现</b>你牌库中一张牌的复制。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=UNDEAD
}
public class REV_906:MinionBase{
//NAME=德纳修斯大帝
//TEXT=<b>吸血</b>，<b>战吼：</b>对所有敌人造成总计5点伤害。<b>无限注能（2）：</b>伤害增加1点。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE、
	public override void Battlecry(Card target=null)
	{

		for(int i=0;i<30;i++)
		{
			new EffectEmote(owner.myPlayer,owner,"HAHAHA").Resolve();
			TaskDamageRandomEnemy(1);
		}
	}
}
public class REV_906t:MinionBase{
//NAME=德纳修斯大帝
//TEXT=<b>吸血</b>，<b>战吼：</b>对所有敌人造成总计{1}点伤害。<b>无限注能（{0}）：</b>伤害增加1点。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<30;i++)
		{
			TaskDamageRandomEnemy(1);
		}
	}
}
public class REV_916:MinionBase{
//NAME=诡异的画像
//TEXT=在另一个随从死亡后，成为它的复制。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=6|RACE=NONE
}
public class REV_917:WeaponBase{
//NAME=石雕凿刀
//TEXT=在你的英雄攻击后，随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class REV_920:SpellBase{
//NAME=可信的伪装
//TEXT=将一个友方随从变形成为法力值消耗增加（2）点的随从。<b>注能（4）：</b>改为变形所有友方随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class REV_920t:SpellBase{
//NAME=可信的伪装
//TEXT=<b>已注能</b> 随机将所有友方随从变形成为法力值消耗增加（2）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class REV_921:MinionBase{
//NAME=锻石师
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的图腾拥有+2攻击力。
//MAJ=SHAMAN|COST=4|ATK=5|HP=4|RACE=NONE
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
		if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Totem)))
		{
			new EffectChange(owner.myPlayer,sc,sc,0,2).Resolve();
		}
	}
}
public class REV_921e:Ability{
//NAME=活石
//TEXT=你的图腾拥有+2攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_921t:Ability{
//NAME=活石
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_923:LocationBase{
//NAME=淤泥之池
//TEXT=将一个友方随从变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=3|RACE=NONE
}
public class REV_924:SpellBase{
//NAME=始源之潮
//TEXT=将敌方随从变形成为法力值消耗减少（1）点的随从，将友方随从变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class REV_925:MinionBase{
//NAME=瓦丝琪女男爵
//TEXT=如果本随从即将变形成为某随从，改为召唤变形后的随从。
//MAJ=SHAMAN|COST=4|ATK=3|HP=6|RACE=NAGA
}
public class REV_930:MinionBase{
//NAME=疯狂的可怜鬼
//TEXT=受伤时拥有+2攻击力和<b>冲锋</b>。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
}
public class REV_930e:Ability{
//NAME=发怒
//TEXT=<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_931:SpellBase{
//NAME=征服者战旗
//TEXT=揭示每个玩家牌库中的一张牌，如果你的牌法力值消耗较大，抽取你的牌。揭示三次。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_933:WeaponBase{
//NAME=灌能战斧
//TEXT=在你的英雄攻击后，使你受伤的随从获得+1/+2。<b>注能（2）：</b>改为+2/+2。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class REV_933e:Ability{
//NAME=嗜血成性
//TEXT=+1/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_933e2:Ability{
//NAME=嗜血成性
//TEXT=+2/+2
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_933t:WeaponBase{
//NAME=灌能战斧
//TEXT=<b>已注能</b> 在你的英雄攻击后，使你受伤的随从获得+2/+2。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class REV_934:MinionBase{
//NAME=屠戮者奥格拉
//TEXT=<b>战吼：</b>每有一个受伤的随从，便获得+1/+1，然后攻击所有敌人。
//MAJ=WARRIOR|COST=6|ATK=3|HP=7|RACE=NONE
}
public class REV_934e:Ability{
//NAME=嗜血渴望
//TEXT=属性值提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_935:MinionBase{
//NAME=派对图腾
//TEXT=在你的回合结束时，随机召唤一个基础图腾。<b>注能（2）：</b>改为召唤两个。
//MAJ=SHAMAN|COST=3|ATK=0|HP=3|RACE=TOTEM
}
public class REV_935t:MinionBase{
//NAME=派对图腾
//TEXT=<b>已注能</b> 在你的回合结束时，随机召唤两个基础图腾。
//MAJ=SHAMAN|COST=3|ATK=0|HP=3|RACE=TOTEM
}
public class REV_936:MinionBase{
//NAME=粗暴的看管者
//TEXT=<b>战吼：</b>召唤一个3/5并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=4|ATK=1|HP=1|RACE=NONE
}
public class REV_936t:MinionBase{
//NAME=未处理的污物
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class REV_937:MinionBase{
//NAME=圣物匠赛·墨克斯
//TEXT=<b>战吼：</b><b>发现</b>并施放一个圣物。<b>注能（5）：</b>改为施放全部三个。
//MAJ=DEMONHUNTER|COST=8|ATK=8|HP=8|RACE=NONE
}
public class REV_937t:MinionBase{
//NAME=圣物匠赛·墨克斯
//TEXT=<b>已注能</b> <b>战吼：</b>施放全部三个圣物。
//MAJ=DEMONHUNTER|COST=8|ATK=8|HP=8|RACE=NONE
}
public class REV_938:SpellBase{
//NAME=暗影之门
//TEXT=抽一张法术牌。<b>注能（2）：</b>将它的一张<b>临时</b>复制置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class REV_938t:SpellBase{
//NAME=暗影之门
//TEXT=<b>已注能</b> 抽一张法术牌，并将它的一张<b>临时</b>复制置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class REV_938te:Ability{
//NAME=暗影追踪
//TEXT=在你的回合结束时摧毁这张牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_939:SpellBase{
//NAME=锯齿骨刺
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，在本回合中，你的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_939e:Ability{
//NAME=锯齿
//TEXT=在本回合中，你使用的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_939e2:Ability{
//NAME=锯齿
//TEXT=在本回合中，你的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_940:MinionBase{
//NAME=通灵领主德拉卡
//TEXT=<b>战吼：</b>装备一把1/3的匕首。<i>（在本回合中你每使用一张其他牌，+1攻击力！）</i>
//MAJ=ROGUE|COST=5|ATK=3|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("REV_940t"),ZoneType.Weapon);
	}
}
public class REV_940t:WeaponBase{
//NAME=玛卓克萨斯匕首
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class REV_942:LocationBase{
//NAME=圣物仓库
//TEXT=在本回合中你使用的下一个圣物将施放两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=2|RACE=NONE
}
public class REV_942e:Ability{
//NAME=圣物强化
//TEXT=你的圣物施放两次。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_942e2:Ability{
//NAME=古代圣物
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_943:SpellBase{
//NAME=幻灭心能圣物
//TEXT=召唤两个1/1的灵魂。提升你此后的圣物效果。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class REV_943t:MinionBase{
//NAME=转瞬即逝的灵魂
//TEXT=
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class REV_945:MinionBase{
//NAME=模糊的陌生人
//TEXT=<b>战吼：</b><b>发现</b>一张另一职业的<b>奥秘</b>牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class REV_946:MinionBase{
//NAME=蒸汽清洁器
//TEXT=<b>战吼：</b>摧毁双方玩家牌库中所有套牌之外的牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class REV_947:MinionBase{
//NAME=污泥仆从
//TEXT=<b>嘲讽</b>，<b>战吼：</b><b>发现</b>一张圣骑士牌。
//MAJ=PALADIN|COST=3|ATK=2|HP=4|RACE=NONE
}
public class REV_948:SpellBase{
//NAME=服务呼叫铃
//TEXT=从你的牌库中<b>发现</b>一张职业牌，抽取它的所有复制。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class REV_950:SpellBase{
//NAME=圣洁鸣钟
//TEXT=随机向随从发射5道射线。射线可使友方随从获得+2/+2，或对敌方随从造成$2点伤害。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class REV_950e:Ability{
//NAME=圣洁鸣钟
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_951:MinionBase{
//NAME=女伯爵
//TEXT=<b>战吼：</b>如果你的牌库中没有中立卡牌，将3张<b>传说</b>邀请函置入你的手牌。
//MAJ=PALADIN|COST=7|ATK=7|HP=7|RACE=NONE
}
public class REV_951e:Ability{
//NAME=贵宾
//TEXT=法力值消耗为（0）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_951t:SpellBase{
//NAME=传说邀请函
//TEXT=<b>发现</b>一张另一职业的<b>传说</b>随从牌。其法力值消耗为（0）点。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class REV_952:MinionBase{
//NAME=罪恶的副厨师长
//TEXT=<b>亡语：</b> 将2张“白银之手新兵”置入你的手牌。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=UNDEAD
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_101t");
		TaskCreate(ToSummon,ZoneType.Hand);
		TaskCreate(ToSummon,ZoneType.Hand);
	}
}
public class REV_955:MinionBase{
//NAME=执事者斯图尔特
//TEXT=<b>亡语：</b> 使你召唤的下一个白银之手新兵获得+3/+3以及此<b>亡语</b>。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
	private bool Used=false;
	public override void UnRegisterEventEffect()
	{
	}

	public override void Deathrattle()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(!Used)
		{
			if(sc.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
			{
				new EffectGiveAbility(owner.myPlayer,owner,sc,"REV_955").Resolve();
				new EffectChange(owner.myPlayer,owner,sc,atkChange:3,hpChange:3).Resolve();
				Used=true;
				//owner.myPlayer.RemoveCallBackOf(this);
			}
		}
	}

}
public class REV_955e:Ability{
//NAME=职位空缺
//TEXT=你的下一个白银之手新兵会继承斯图尔特的遗志。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_955e2:Ability{
//NAME=斯图尔特的遗志
//TEXT=+3/+3。<b>亡语：</b>你的下一个白银之手新兵拥有此效果。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_956:MinionBase{
//NAME=亡者牧师
//TEXT=<b>嘲讽</b>，<b>注能（3）：</b>获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class REV_956e:Ability{
//NAME=Infused
//TEXT=Increased Stats
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_956t:MinionBase{
//NAME=亡者牧师
//TEXT=<b>已注能<b>。</b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=5|RACE=NONE
}
public class REV_957:MinionBase{
//NAME=鱼人吸血鬼
//TEXT=<b>吸血</b>，<b>注能（4）：</b>法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=MURLOC
}
public class REV_957t:MinionBase{
//NAME=鱼人吸血鬼
//TEXT=<b>已注能。吸血</b>
//MAJ=NEUTRAL|COST=0|ATK=3|HP=4|RACE=MURLOC
}
public class REV_958:MinionBase{
//NAME=餐会巨仆
//TEXT=<b>战吼：</b>召唤两个白银之手新兵。<b>注能（3）：</b>使其获得+2攻击力和<b>圣盾</b>。
//MAJ=PALADIN|COST=4|ATK=2|HP=4|RACE=NONE
}
public class REV_958e:Ability{
//NAME=上菜！
//TEXT=+2攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_958t:MinionBase{
//NAME=餐会巨仆
//TEXT=<b>已注能</b> <b>战吼：</b>召唤两个白银之手新兵。使其获得+2攻击力和<b>圣盾</b>。
//MAJ=PALADIN|COST=4|ATK=2|HP=4|RACE=NONE
}
public class REV_959:MinionBase{
//NAME=恐怖的掘墓者
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，选择你的对手的一张手牌洗入其牌库。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class REV_960:MinionBase{
//NAME=灰烬元素
//TEXT=<b>战吼：</b>下个回合，每当你的对手抽牌时，对手会受到2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class REV_960e:Ability{
//NAME=灰烬
//TEXT=下个回合，每当你的对手抽牌时，对手会受到2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_961:MinionBase{
//NAME=势利精英
//TEXT=<b>战吼：</b>你手牌中每有一张圣骑士牌，便从<b>圣盾</b>，<b>吸血</b>，<b>突袭</b>或<b>嘲讽</b>中获得一项。
//MAJ=PALADIN|COST=5|ATK=3|HP=4|RACE=NONE
}
public class REV_983:LocationBase{
//NAME=大厅
//TEXT=将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=2|ATK=0|HP=3|RACE=NONE
}
public class REV_983e:Ability{
//NAME=上等佳肴
//TEXT=属性值变成3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_990:LocationBase{
//NAME=赤红深渊
//TEXT=对一个随从造成1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=1|ATK=0|HP=3|RACE=NONE
}
public class REV_990e:Ability{
//NAME=堕罪恩典
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class REV_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
