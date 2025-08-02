using System.Collections;
using System.Collections.Generic;

public class BOT_020:MinionBase{
//NAME=滑板机器人
//TEXT=<b>磁力</b> <b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BOT_020e:Ability{
//NAME=滑板机器人
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_021:MinionBase{
//NAME=青铜门卫
//TEXT=<b>磁力</b> <b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=MECHANICAL
}
public class BOT_021e:Ability{
//NAME=青铜门卫
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_031:MinionBase{
//NAME=地精炸弹
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=MECHANICAL
}
public class BOT_033:SpellBase{
//NAME=投掷炸弹
//TEXT=造成$2点伤害。召唤一个0/2的地精炸弹。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_034:MinionBase{
//NAME=爆破大师弗拉克
//TEXT=<b>战吼：</b>召唤四个0/2的地精炸弹。
//MAJ=HUNTER|COST=7|ATK=5|HP=5|RACE=NONE
}
public class BOT_035:MinionBase{
//NAME=毒箭机器人
//TEXT=<b>磁力</b> <b>剧毒</b>
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class BOT_035e:Ability{
//NAME=毒箭机器人
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_038:MinionBase{
//NAME=焰火技师
//TEXT=<b>战吼：</b>使一个友方机械获得+1/+1。如果它拥有<b>亡语</b>，则将其 触发。
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=NONE
}
public class BOT_038e:Ability{
//NAME=待发状态
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_039:MinionBase{
//NAME=死灵机械师
//TEXT=你的<b>亡语</b>会触发 两次。
//MAJ=HUNTER|COST=4|ATK=3|HP=6|RACE=NONE
}
public class BOT_039e:Ability{
//NAME=死灵机械
//TEXT=你的<b>亡语</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_042:SpellBase{
//NAME=武器计划
//TEXT=每个玩家装备一把2/3的武器，并获得6点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_042t:WeaponBase{
//NAME=电圆锯
//TEXT=
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BOT_050:MinionBase{
//NAME=生锈的回收机器人
//TEXT=<b>嘲讽，吸血</b>
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=MECHANICAL
}
public class BOT_054:SpellBase{
//NAME=生物计划
//TEXT=每个玩家获得两个法力水晶。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class BOT_059:MinionBase{
//NAME=恒金巡游者
//TEXT=每当本随从受到伤害，获得2点护甲值。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=MECHANICAL
}
public class BOT_066:MinionBase{
//NAME=机械雏龙
//TEXT=<b>亡语：</b>召唤一个7/7的机械巨龙。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=2|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BOT_066t"),ZoneType.Board);
	}
}
public class BOT_066t:MinionBase{
//NAME=机械巨龙
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=MECHANICAL
}
public class BOT_067:SpellBase{
//NAME=火箭靴
//TEXT=使一个随从获得<b>突袭</b>。抽 一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_067e:Ability{
//NAME=火箭靴
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_069:SpellBase{
//NAME=砰砰飞艇
//TEXT=随机从你的手牌中召唤三个随从，并使其获得<b>突袭</b>。
//MAJ=WARRIOR|COST=9|ATK=0|HP=0|RACE=NONE
}
public class BOT_069e:Ability{
//NAME=火箭奇兵
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_079:MinionBase{
//NAME=可靠的灯泡
//TEXT=<b>战吼：</b>使一个友方机械获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BOT_079e:Ability{
//NAME=启发
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_083:MinionBase{
//NAME=毒物学家
//TEXT=<b>战吼：</b>使你的武器获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BOT_083e:Ability{
//NAME=毒素
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_084:SpellBase{
//NAME=紫色烟雾
//TEXT=随机将两张<b>亡语</b>牌置入你的 手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_087:SpellBase{
//NAME=学术剽窃
//TEXT=将十张你对手职业的卡牌洗入你的牌库，其法力值消耗为（1）点。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BOT_087e:Ability{
//NAME=学术剽窃
//TEXT=法力值消耗为（1）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_093:SpellBase{
//NAME=元素反应
//TEXT=抽一张牌。如果你在上个回合使用过元素牌，则复制抽到的牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class BOT_098:MinionBase{
//NAME=没电的铁皮人
//TEXT=在本回合中，除非你施放过法术，否则无法进行攻击。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=MECHANICAL
}
public class BOT_099:SpellBase{
//NAME=我找到了
//TEXT=随机召唤你手牌中的一张随从牌的一个复制。
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class BOT_101:SpellBase{
//NAME=星界裂隙
//TEXT=随机将两张随从牌置入你的 手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class BOT_101e2:Ability{
//NAME=战嚎
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_102:MinionBase{
//NAME=火花钻机
//TEXT=<b>突袭，亡语：</b>将两张1/1并具有<b>突袭</b>的“火花”置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=1|RACE=MECHANICAL
}
public class BOT_102t:MinionBase{
//NAME=火花
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class BOT_103:MinionBase{
//NAME=观星者露娜
//TEXT=在你使用最右边的一张手牌后，抽 一张牌。
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=NONE
}
public class BOT_104:MinionBase{
//NAME=掷弹机器人
//TEXT=<b>战吼：</b>造成5点伤害，随机分配到所有非机械随从身上。
//MAJ=WARRIOR|COST=5|ATK=3|HP=4|RACE=MECHANICAL
}
public class BOT_107:MinionBase{
//NAME=飞弹机器人
//TEXT=<b>磁力</b> 在你的回合结束时，对所有其他角色造成1点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=MECHANICAL
}
public class BOT_107e:Ability{
//NAME=飞弹机器人
//TEXT=在你的回合结束时，对所有其他角色造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_216:MinionBase{
//NAME=欧米茄医护兵
//TEXT=<b>战吼：</b>如果你有十个法力水晶，为你的英雄恢复#10点生命值。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NONE
}
public class BOT_218:MinionBase{
//NAME=安保巡游者
//TEXT=每当本随从受到伤害，召唤一个2/3并具有<b>嘲讽</b>的机械。
//MAJ=WARRIOR|COST=6|ATK=2|HP=6|RACE=MECHANICAL
	public override void AfterTakeDamage(Card source,int amount)
	{
		if(amount>0)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("BOT_218t"),ZoneType.Board);
		}
	}
}
public class BOT_218t:MinionBase{
//NAME=警卫机器人
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BOT_218_G:MinionBase{
//NAME=安保巡游者
//TEXT=每当本随从受到伤害，召唤一个2/3并具有<b>嘲讽</b>的机械。
//MAJ=WARRIOR|COST=6|ATK=2|HP=6|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterTakeDamage(Card source,int amount)
	{
		if(amount>0)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("BOT_218t_G"),ZoneType.Board);
		}
	}
}
public class BOT_218t_G:MinionBase{
//NAME=警卫机器人
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BOT_219:SpellBase{
//NAME=增生手臂
//TEXT=使一个随从获得+2/+2。将一张可使一个随从获得+2/+2的“更多手臂”置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class BOT_219e:Ability{
//NAME=加装
//TEXT=+2/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_219t:SpellBase{
//NAME=更多手臂
//TEXT=使一个随从获得+2/+2。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class BOT_219te:Ability{
//NAME=更多手臂
//TEXT=+2/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_222:SpellBase{
//NAME=灵魂炸弹
//TEXT=对一个随从和你的英雄各造成$4点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_224:MinionBase{
//NAME=双生小鬼
//TEXT=<b>战吼：</b>召唤一个本随从的复制。
//MAJ=WARLOCK|COST=3|ATK=2|HP=2|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		Card Another = new Card(owner.cardDbf,owner.myPlayer);
		Another.SetTag(GameTag.Attack,owner.GetTag(GameTag.Attack));
		Another.SetTag(GameTag.Health,owner.GetTag(GameTag.Health));
		Another.SetTag(GameTag.Damage,owner.GetTag(GameTag.Damage));
		new EffectCreate(owner.myPlayer,Another,ZoneType.Board).Resolve();
	}
}
public class BOT_226:MinionBase{
//NAME=虚魂破坏者
//TEXT=<b>战吼：</b>在本回合中，你的英雄每受到一点伤害，便获得+1攻击力。
//MAJ=WARLOCK|COST=3|ATK=1|HP=5|RACE=DEMON
}
public class BOT_226e:Ability{
//NAME=虚魂充能
//TEXT=攻击力提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_234:SpellBase{
//NAME=萎缩射线
//TEXT=将所有随从的攻击力和生命值 变为1。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BOT_234e:Ability{
//NAME=萎缩射线
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_236:MinionBase{
//NAME=水晶工匠坎格尔
//TEXT=<b>圣盾，吸血</b> 你的治疗效果翻倍。
//MAJ=PALADIN|COST=2|ATK=1|HP=2|RACE=NONE
}
public class BOT_237:MinionBase{
//NAME=铍金毁灭者
//TEXT=<b>磁力</b>。<b>扰魔</b>
//MAJ=WARRIOR|COST=7|ATK=4|HP=8|RACE=MECHANICAL
}
public class BOT_237e:Ability{
//NAME=铍金毁灭者
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_238:HeroBase{
//NAME=“科学狂人”砰砰博士
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的所有机械拥有 <b>突袭</b>。
//MAJ=WARRIOR|COST=7|ATK=0|HP=30|RACE=NONE
}
public class BOT_238e:Ability{
//NAME=急速爆发
//TEXT=你的机械拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_238e2:Ability{
//NAME=急速爆发
//TEXT=砰砰博士使你的机械获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p:HeroPowerBase{
//NAME=红色按钮
//TEXT=每回合切换动力装置！
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p1:HeroPowerBase{
//NAME=电磁炮
//TEXT=造成$3点伤害。每回合切换。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p2:HeroPowerBase{
//NAME=防爆护盾
//TEXT=获得$d7点护甲值。每回合切换。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p3:HeroPowerBase{
//NAME=霰弹炮
//TEXT=对所有敌人造成$1点伤害。每回合 切换。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p4:HeroPowerBase{
//NAME=无人运输机
//TEXT=<b>发现</b>一张机械牌。每回合切换。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_238p6:HeroPowerBase{
//NAME=微型战队
//TEXT=召唤三个1/1的微型机器人。每回合 切换。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_242:SpellBase{
//NAME=迈拉的不稳定元素
//TEXT=抽取你牌库剩下的牌。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BOT_243:MinionBase{
//NAME=迈拉·腐泉
//TEXT=<b>战吼：</b> <b>发现</b>一张<b>亡语</b>随从牌，并获得其<b>亡语</b>。
//MAJ=ROGUE|COST=5|ATK=4|HP=2|RACE=UNDEAD
}
public class BOT_243e:Ability{
//NAME=死灵炼金术
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_245:SpellBase{
//NAME=风暴聚合器
//TEXT=随机将你的所有随从变形成为<b>传说</b>随从。
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class BOT_246:SpellBase{
//NAME=瓶装闪电
//TEXT=对所有随从造成$1点伤害。 <b>过载：</b>（2）
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class BOT_251:MinionBase{
//NAME=蜘蛛炸弹
//TEXT=<b>磁力</b> <b>亡语：</b>随机消灭一个敌方随从。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=MECHANICAL
}
public class BOT_251e:Ability{
//NAME=蜘蛛炸弹
//TEXT=<b>亡语：</b>随机消灭一个敌方随从。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_254:SpellBase{
//NAME=鲁莽试验
//TEXT=随机召唤两个法力值消耗为（$2）的随从<i>（受<b>法术伤害</b>加成影响）</i>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("TTN_429"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("TTN_429"),ZoneType.Board);
	}
}
public class BOT_256:MinionBase{
//NAME=星术师
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗等同于你手牌数量的随从。
//MAJ=MAGE|COST=7|ATK=5|HP=5|RACE=NONE
}
public class BOT_257:SpellBase{
//NAME=露娜的口袋银河
//TEXT=使你牌库中所有随从牌的法力值消耗变为（1）点。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class BOT_257e:Ability{
//NAME=星击
//TEXT=法力值消耗为（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_258:MinionBase{
//NAME=克隆大师泽里克
//TEXT=<b>亡语：</b>如果你对本随从施放过任意法术，再次召唤本随从。
//MAJ=PRIEST|COST=6|ATK=5|HP=5|RACE=NONE
}
public class BOT_258e:Ability{
//NAME=克隆载体
//TEXT=准备好召唤克隆大师泽里克
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_263:SpellBase{
//NAME=灵魂灌注
//TEXT=使你手牌中最左边的随从牌获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_263e:Ability{
//NAME=灌注
//TEXT=+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_267:MinionBase{
//NAME=载人毁灭机
//TEXT=<b>亡语：</b>随机从你的手牌中召唤一个法力值消耗小于或等于（2）点的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
}
public class BOT_270:MinionBase{
//NAME=欢乐的发明家
//TEXT=<b>战吼：</b>召唤两个1/2并具有<b>嘲讽</b>和<b>圣盾</b>的 机械。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=1|RACE=NONE
}
public class BOT_270t:MinionBase{
//NAME=吵吵机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class BOT_280:MinionBase{
//NAME=全息术士
//TEXT=在你的对手使用一张随从牌后，召唤一个它的1/1的复制。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BOT_280e:Ability{
//NAME=全息影像
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_283:MinionBase{
//NAME=蹦蹦兔
//TEXT=<b>战吼：</b>在本局对战中，你每使用过一张其他蹦蹦兔，便获得+2/+2。
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BOT_283e:Ability{
//NAME=动能
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_286:WeaponBase{
//NAME=死金匕首
//TEXT=<b>亡语：</b> 随机触发一个友方随从的<b>亡语</b>。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class BOT_288:MinionBase{
//NAME=实验室招募员
//TEXT=<b>战吼：</b>将一个友方随从的三张复制洗入你的牌库。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class BOT_291:MinionBase{
//NAME=风暴追逐者
//TEXT=<b>战吼：</b>从你的牌库中抽一张法力值消耗大于或等于（5）点的法术牌。
//MAJ=SHAMAN|COST=4|ATK=3|HP=4|RACE=ELEMENTAL
}
public class BOT_296:MinionBase{
//NAME=欧米茄防御者
//TEXT=<b>嘲讽，战吼：</b>如果你有十个法力水晶，获得+10攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class BOT_296e:Ability{
//NAME=欧米茄能量
//TEXT=+10攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_299:SpellBase{
//NAME=欧米茄装配
//TEXT=<b>发现</b>一张机械牌。如果你有十个法力水晶，保留全部三张牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BOT_308:MinionBase{
//NAME=弹簧火箭犬
//TEXT=<b>战吼：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=MECHANICAL
}
public class BOT_309:MinionBase{
//NAME=可升级机器人
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=1|HP=5|RACE=MECHANICAL
}
public class BOT_312:MinionBase{
//NAME=量产型恐吓机
//TEXT=<b>磁力</b> <b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
}
public class BOT_312e:Ability{
//NAME=量产型恐吓机
//TEXT=<b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_312t:MinionBase{
//NAME=微型机器人
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BOT_312Gt:MinionBase{
//NAME=微型机器人
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
}
public class BOT_401:MinionBase{
//NAME=武装皮纳塔
//TEXT=<b>亡语：</b> 随机将一张<b>传说</b>随从牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
}
public class BOT_402:SpellBase{
//NAME=奥秘图纸
//TEXT=<b>发现</b>一张<b>奥秘</b>牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BOT_404:SpellBase{
//NAME=香甜的灵力瓜
//TEXT=从你的牌库中抽取法力值消耗为（7），（8），（9）和（10）的随从牌各一张。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class BOT_406:WeaponBase{
//NAME=超级对撞器
//TEXT=在你攻击一个随从后，迫使其攻击相邻的一个 随从。
//MAJ=WARRIOR|COST=5|ATK=1|HP=3|RACE=NONE
}
public class BOT_407:MinionBase{
//NAME=雷云元素
//TEXT=在你使用一张<b>过载</b>牌后，召唤两个1/1并具有<b>突袭</b>的“火花”。
//MAJ=SHAMAN|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class BOT_411:MinionBase{
//NAME=伊莱克特拉·风潮
//TEXT=<b>战吼：</b>在本回合中，你的下一个法术将施放两次。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class BOT_411e:Ability{
//NAME=带电
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_411e2:Ability{
//NAME=放电
//TEXT=在本回合中，你的下一个法术将施放两次。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_413:MinionBase{
//NAME=脑力激荡者
//TEXT=<b>战吼：</b>你手牌中每有一张法术牌，便获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class BOT_413e:Ability{
//NAME=脑力激荡
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_414:MinionBase{
//NAME=隐鳞药剂师
//TEXT=<b>潜行</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class BOT_419:MinionBase{
//NAME=树木学家
//TEXT=<b>战吼：</b>如果你控制一个树人，<b>发现</b>一张法术牌。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BOT_420:SpellBase{
//NAME=植树造林
//TEXT=召唤两个2/2的树人。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class BOT_422:MinionBase{
//NAME=牛头人园丁
//TEXT=<b>抉择：</b> 使你的所有其他随从获得+1/+1；或者召唤两个2/2的树人。
//MAJ=DRUID|COST=6|ATK=3|HP=4|RACE=NONE
}
public class BOT_422a:SpellBase{
//NAME=施肥
//TEXT=使你的所有其他随从获得+1/+1。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class BOT_422ae:Ability{
//NAME=施肥
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_422b:SpellBase{
//NAME=新生幼苗
//TEXT=召唤两个2/2的树人。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class BOT_423:MinionBase{
//NAME=梦境花栽种师
//TEXT=在你的回合结束时，随机使你手牌中一张随从牌的法力值消耗减少（7）点。
//MAJ=DRUID|COST=7|ATK=4|HP=4|RACE=NONE
}
public class BOT_423e:Ability{
//NAME=插花艺术
//TEXT=法力值消耗减少（7）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_424:MinionBase{
//NAME=机械克苏恩
//TEXT=<b>亡语：</b> 如果你的牌库、手牌和战场没有任何牌，消灭敌方英雄。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=MECHANICAL
}
public class BOT_429:SpellBase{
//NAME=弗拉克的火箭炮
//TEXT=从你的牌库中召唤三个随从。他们会攻击敌方随从，然后死亡。
//MAJ=HUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class BOT_431:MinionBase{
//NAME=旋翼滑翔者
//TEXT=<b>战吼：</b>召唤一个0/2的地精炸弹。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class BOT_433:MinionBase{
//NAME=莫瑞甘博士
//TEXT=<b>亡语：</b> 将本随从与你牌库中的一个随从互换。
//MAJ=WARLOCK|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class BOT_434:MinionBase{
//NAME=软泥教授弗洛普
//TEXT=此牌在你的手牌中时，会变成你使用的上一张随从牌的3/4复制。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=NONE
}
public class BOT_434e:Ability{
//NAME=软绵绵
//TEXT=变成最近使用过的随从牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_434e2:Ability{
//NAME=软绵绵
//TEXT=3/4。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_435:SpellBase{
//NAME=克隆装置
//TEXT=从你对手的牌库中<b>发现</b>一张随从牌的复制。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BOT_436:SpellBase{
//NAME=棱彩透镜
//TEXT=从你的牌库中抽一张随从牌和一张法术牌，交换其法力值消耗。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BOT_436e:Ability{
//NAME=互换法力值消耗
//TEXT=法力值消耗互换。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_437:SpellBase{
//NAME=地精的把戏
//TEXT=使一个友方随从获得+3/+3和<b>突袭</b>，该随从会在回合结束时死亡。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_437e:Ability{
//NAME=黏呼呼的
//TEXT=获得+3/+3和<b>突袭</b>。在回合结束时黏呼呼地死去。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_438:SpellBase{
//NAME=机核芯片
//TEXT=使你的所有随从获得 “<b>亡语：</b>随机将一张机械牌置入你的手牌”。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_438e:Ability{
//NAME=芯片植入
//TEXT=<b>亡语：</b>随机将一张机械牌置入你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_443:MinionBase{
//NAME=虚空分析师
//TEXT=<b>亡语：</b>使你手牌中的所有恶魔牌获得+1/+1。
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class BOT_443e:Ability{
//NAME=分析强化
//TEXT=虚空分析师使其获得+1/+1。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_444:SpellBase{
//NAME=弗洛普的神奇黏液
//TEXT=在本回合中，每当一个随从死亡，复原一个法力水晶。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
	private bool Act = false;
	public override void Battlecry(Card target=null)
	{
		new EffectEmote(owner.myPlayer,null,"法力恢复！",owner.cardDbf).Resolve();
		Act=true;
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sz==ZoneType.Board && tz==ZoneType.Grave)
		{
			owner.myPlayer.ChangeTag(GameTag.ManaLeft,1);
			TaskBuffMyHero();
		}
	}
}
public class BOT_444e:Ability{
//NAME=黏呼呼
//TEXT=在本回合中，每当一个随从死亡，复原一个法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_445:MinionBase{
//NAME=机械袋鼠
//TEXT=<b>亡语：</b>召唤一个1/1的机械袋鼠宝宝。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BOT_445t"),ZoneType.Board);
	}
}
public class BOT_445t:MinionBase{
//NAME=机械袋鼠宝宝
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BOT_445_G:MinionBase{
//NAME=机械袋鼠
//TEXT=<b>亡语：</b>召唤一个1/1的机械袋鼠宝宝。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BOT_445t_G"),ZoneType.Board);
	}
}
public class BOT_445t_G:MinionBase{
//NAME=机械袋鼠宝宝
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BOT_447:MinionBase{
//NAME=晶化师
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。获得5点护甲值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class BOT_448:MinionBase{
//NAME=受损的机械剑龙
//TEXT=<b>嘲讽</b>。<b>战吼：</b>对本随从造成6点伤害。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=12|RACE=MECHANICAL
}
public class BOT_451:SpellBase{
//NAME=流电爆裂
//TEXT=召唤两个1/1并具有<b>突袭</b>的“火花”。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        TaskCreate(CardDbf.GetCardDbfByGuid("BOT_102t"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("BOT_102t"),ZoneType.Board);
    }
}
public class BOT_453:SpellBase{
//NAME=迸射流星
//TEXT=对一个随从及其相邻的随从造成$1点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        Card Left=null;
        Card Right=null;
        int Index = target.myPlayer.board.IndexOf(target);
        if(Index-1>=0)
        {
            Left=target.myPlayer.board[Index-1];
        }
        if(Index+1<=target.myPlayer.board.Count-1)
        {
            Right=target.myPlayer.board[Index+1];
        }
        List<Card> ToListDamage=new List<Card>();
        if(Left!=null)
        {
            ToListDamage.Add(Left);
        }
        ToListDamage.Add(target);
        if(Right!=null)
        {
            ToListDamage.Add(Right);
        }
        TaskDamageTargets(ToListDamage,1);
    }
}
public class BOT_507:MinionBase{
//NAME=黏液喷射者
//TEXT=<b>战吼：</b> 为相邻的随从各召唤一个复制。
//MAJ=DRUID|COST=7|ATK=4|HP=4|RACE=NONE
}
public class BOT_508:SpellBase{
//NAME=死金药剂
//TEXT=触发一个友方随从的<b>亡语</b>两次。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_509:MinionBase{
//NAME=丧钟机器人
//TEXT=<b>亡语：</b>从你的牌库中抽一张具有<b>亡语</b>的随从牌。
//MAJ=PRIEST|COST=2|ATK=2|HP=1|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskDrawKey("Deathrattle");
	}
}
public class BOT_511:MinionBase{
//NAME=爆盐投弹手
//TEXT=<b>战吼：</b>将一张“炸弹” 牌洗入你对手的牌库。当抽到“炸弹”时，便会受到5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class BOT_511t:SpellBase{
//NAME=炸弹
//TEXT=<b>抽到时施放</b> 你受到5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BOT_517:SpellBase{
//NAME=引力翻转
//TEXT=使一个随从的攻击力和生命值 互换。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_517e:Ability{
//NAME=上下颠倒
//TEXT=引力翻转使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_521:SpellBase{
//NAME=炼魂术
//TEXT=召唤你控制的所有恶魔的复制。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_523:MinionBase{
//NAME=植被破碎机
//TEXT=<b>突袭</b> 在本局对战中，每有一个友方树人死亡，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=9|ATK=8|HP=8|RACE=MECHANICAL
}
public class BOT_529:SpellBase{
//NAME=真言术：仿
//TEXT=选择一个友方随从，召唤一个该随从的5/5复制。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BOT_529e:Ability{
//NAME=仿制
//TEXT=5/5。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_531:MinionBase{
//NAME=星界密使
//TEXT=<b>战吼：</b>在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class BOT_531e:Ability{
//NAME=星界之力
//TEXT=在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_531e2:Ability{
//NAME=星界之力
//TEXT=在本回合中，你的下一个法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_532:MinionBase{
//NAME=投弹机器人
//TEXT=<b>战吼：</b>召唤两个0/2的地精炸弹。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
}
public class BOT_533:MinionBase{
//NAME=凶恶的雨云
//TEXT=<b>战吼：</b>随机将一张元素牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class BOT_534:MinionBase{
//NAME=机械推土牛
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=9|ATK=9|HP=7|RACE=MECHANICAL
}
public class BOT_535:MinionBase{
//NAME=微机操控者
//TEXT=<b>战吼：</b>召唤两个1/1的微型机器人。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=NONE
}
public class BOT_536:MinionBase{
//NAME=欧米茄探员
//TEXT=<b>战吼：</b>如果你有十个法力水晶，召唤本随从的两个复制。
//MAJ=WARLOCK|COST=5|ATK=4|HP=5|RACE=NONE
}
public class BOT_537:MinionBase{
//NAME=机械蛋
//TEXT=<b>亡语：</b>召唤一个8/8的机械暴龙。
//MAJ=PALADIN|COST=5|ATK=0|HP=5|RACE=MECHANICAL
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BOT_537t"),ZoneType.Board);
	}
}
public class BOT_537t:MinionBase{
//NAME=机械暴龙
//TEXT=
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=MECHANICAL
}
public class BOT_537_G:MinionBase{
//NAME=机械蛋
//TEXT=<b>亡语：</b>召唤一个8/8的机械暴龙。
//MAJ=PALADIN|COST=5|ATK=0|HP=5|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BOT_537t_G"),ZoneType.Board);
	}
}
public class BOT_537t_G:MinionBase{
//NAME=机械暴龙
//TEXT=
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BOT_538:MinionBase{
//NAME=火花引擎
//TEXT=<b>战吼：</b>将一张1/1并具有<b>突袭</b>的“火花”置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MECHANICAL
}
public class BOT_539:MinionBase{
//NAME=奥能水母
//TEXT=<b>战吼：</b><b>发现</b>一张法力值消耗大于或等于（5）点的法术牌。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=4|RACE=NONE
}
public class BOT_540:MinionBase{
//NAME=电磁脉冲特工
//TEXT=<b>战吼：</b> 消灭一个机械。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BOT_543:MinionBase{
//NAME=欧米茄灵能者
//TEXT=<b>战吼：</b>如果你有十个法力水晶，在本回合中你的所有法术拥有 <b>吸血</b>。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class BOT_543e:Ability{
//NAME=心智融合
//TEXT=在本回合中，你的法术拥有<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_544:MinionBase{
//NAME=脱逃的样本
//TEXT=<b>战吼：</b>造成6点伤害，随机分配到所有其他友方随从身上。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=BEAST
}
public class BOT_548:MinionBase{
//NAME=奇利亚斯
//TEXT=<b>磁力，圣盾，嘲讽，吸血，突袭</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Magnetic");
		TaskInitAbility("DivineShield");
		TaskInitAbility("Taunt");
		TaskInitAbility("LifeSteal");
		TaskInitAbility("Rush");
	}
}
public class BOT_548e:Ability{
//NAME=奇利亚斯
//TEXT=<b>圣盾，嘲讽，吸血，突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_550:MinionBase{
//NAME=电能工匠
//TEXT=<b>战吼：</b> 如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class BOT_550e:Ability{
//NAME=电化
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_552:MinionBase{
//NAME=群星罗列者
//TEXT=<b>战吼：</b>如果你控制三个生命值为7的随从，对所有敌人造成7点 伤害。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class BOT_555:MinionBase{
//NAME=星界使者塞雷西亚
//TEXT=<b>潜行</b> 在你的对手使用一张随从牌后，变成它的复制。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=NONE
}
public class BOT_558:MinionBase{
//NAME=实验体
//TEXT=<b>亡语：</b>将你施放在本随从身上的所有法术洗入你的牌库。
//MAJ=PRIEST|COST=1|ATK=0|HP=2|RACE=NONE
}
public class BOT_558_puzzle:MinionBase{
//NAME=实验体
//TEXT=<b>亡语：</b>将你施放在本随从身上的所有法术移回你的手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=2|RACE=NONE
}
public class BOT_558e:Ability{
//NAME=存储的数据
//TEXT=存放法术。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_558e_puzzle:Ability{
//NAME=存储的数据
//TEXT=存放法术。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_559:MinionBase{
//NAME=强能雷象
//TEXT=每当你将一张牌洗入牌库，额外洗入一张相同的牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class BOT_559e:Ability{
//NAME=Dealing
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_562:MinionBase{
//NAME=铜尾仿冒鼠
//TEXT=<b>战吼：</b>获得<b>潜行</b>直到你的下个回合。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class BOT_562e:Ability{
//NAME=伪装
//TEXT=获得<b>潜行</b>直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_563:MinionBase{
//NAME=战争机兵
//TEXT=<b>磁力</b>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=MECHANICAL
}
public class BOT_563e:Ability{
//NAME=战争机兵
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_565:MinionBase{
//NAME=荒疫爬行者
//TEXT=<b>亡语：</b>召唤一个1/1并具有<b>剧毒</b>和<b>突袭</b>的软泥怪。
//MAJ=ROGUE|COST=4|ATK=2|HP=4|RACE=MECHANICAL
}
public class BOT_565t:MinionBase{
//NAME=辐射软泥怪
//TEXT=<b>剧毒</b> <b>突袭</b>
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BOT_566:MinionBase{
//NAME=鲁莽的实验者
//TEXT=你使用的<b>亡语</b>随从牌的法力值消耗减少（3）点，但会在回合结束时死亡。
//MAJ=PRIEST|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class BOT_566e:Ability{
//NAME=鲁莽的实验
//TEXT=本随从将在回合结束时死于非命。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_566e2:Ability{
//NAME=鲁莽的实验
//TEXT=法力值消耗减少（3）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_567:SpellBase{
//NAME=泽里克的克隆展
//TEXT=召唤你的牌库中每一个随从的1/1复制。
//MAJ=PRIEST|COST=9|ATK=0|HP=0|RACE=NONE
}
public class BOT_567e:Ability{
//NAME=克隆
//TEXT=1/1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_568:SpellBase{
//NAME=莫瑞甘的灵界
//TEXT=抽三张牌。这些牌为<b>临时</b>牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<3;i++)
		{
			Card Drawn = TaskDraw();
			if(Drawn!=null)
			{
				new EffectGiveAbility(owner.myPlayer,owner,Drawn,"DiscardOnTurnEnd").Resolve();
			}
		}
	}
}
public class BOT_568e:Ability{
//NAME=稍纵即逝的灵魂
//TEXT=在你的回合结束时弃掉。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_573:MinionBase{
//NAME=实验体9号
//TEXT=<b>战吼：</b> 从你的牌库中抽五张不同的<b>奥秘</b>牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class BOT_576:MinionBase{
//NAME=疯狂的药剂师
//TEXT=<b>连击：</b>使一个友方随从获得+4攻击力。
//MAJ=ROGUE|COST=5|ATK=4|HP=4|RACE=NONE
}
public class BOT_576e:Ability{
//NAME=用药过量
//TEXT=+4攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_600:SpellBase{
//NAME=研发计划
//TEXT=每个玩家抽两张牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BOT_601:MinionBase{
//NAME=气象学家
//TEXT=<b>战吼：</b>你每有一张手牌，便随机对一个敌人造成1点伤害。
//MAJ=MAGE|COST=6|ATK=3|HP=3|RACE=NONE
}
public class BOT_603:MinionBase{
//NAME=钢铁暴怒者
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=1|RACE=MECHANICAL
}
public class BOT_604:MinionBase{
//NAME=宇宙异象
//TEXT=<b>法术伤害+2</b>
//MAJ=MAGE|COST=4|ATK=4|HP=3|RACE=ELEMENTAL
}
public class BOT_606:MinionBase{
//NAME=爆爆机器人
//TEXT=<b>亡语：</b>随机对一个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MECHANICAL
}
public class BOT_700:MinionBase{
//NAME=大铡蟹
//TEXT=<b>磁力，回响，亡语：</b>召唤两个1/1的微型机器人。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class BOT_700e:Ability{
//NAME=大铡蟹
//TEXT=<b>亡语：</b>召唤两个1/1的微型机器人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_906:MinionBase{
//NAME=格洛顿
//TEXT=<b>磁力</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=MECHANICAL
}
public class BOT_906e:Ability{
//NAME=格洛顿
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_907:MinionBase{
//NAME=通电机器人
//TEXT=<b>战吼：</b>使你手牌中所有机械牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class BOT_907e:Ability{
//NAME=通电
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_908:SecretBase{
//NAME=自动防御矩阵
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BOT_909:SpellBase{
//NAME=水晶学
//TEXT=从你的牌库中抽两张攻击力为1的随从牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListDraw = new List<Card>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardType==CardType.Minion)
			{
				if(c.GetTag(GameTag.Attack)==1)
				{
					ToListDraw.Add(c);
				}
			}
		}
		Card ToDraw1 = ToListDraw.Choice(owner.myPlayer.randomGen);
		if(ToDraw1!=null)
		{
			TaskDraw(ToDraw1);
			ToListDraw.Remove(ToDraw1);
			Card ToDraw2 = ToListDraw.Choice(owner.myPlayer.randomGen);
			if(ToDraw2!=null)
			{
				TaskDraw(ToDraw2);
			}
		}
	}
}
public class BOT_910:MinionBase{
//NAME=亮石技师
//TEXT=<b>战吼：</b>使你手牌中的所有随从牌获得+2/+2。
//MAJ=PALADIN|COST=5|ATK=3|HP=4|RACE=NONE
}
public class BOT_910e:Ability{
//NAME=圣光灌注
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_911:MinionBase{
//NAME=吵吵模组
//TEXT=<b>磁力</b> <b>圣盾</b> <b>嘲讽</b>
//MAJ=PALADIN|COST=4|ATK=2|HP=4|RACE=MECHANICAL
}
public class BOT_911e:Ability{
//NAME=吵吵模组
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BOT_912:SpellBase{
//NAME=坎格尔的无尽大军
//TEXT=复活三个友方机械，它们会保留所有<b>磁力</b>升级。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("TOY_330t12"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("TOY_330t12"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("TOY_330t12"),ZoneType.Board);
	}
}
public class BOT_913:SpellBase{
//NAME=恶魔计划
//TEXT=随机将每个玩家手牌中的一张随从牌变形成为一张 恶魔牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class BOT_914:MinionBase{
//NAME=神奇的威兹班
//TEXT=你改用威兹班的一副梦幻套牌来开始 对战！
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class BOT_914h:HeroBase{
//NAME=神奇的威兹班
//TEXT=
//MAJ=WHIZBANG|COST=0|ATK=0|HP=30|RACE=NONE
}
