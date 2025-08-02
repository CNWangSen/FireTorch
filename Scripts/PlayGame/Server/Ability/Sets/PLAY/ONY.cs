using System.Collections;
using System.Collections.Generic;

public class ONY_001:MinionBase{
//NAME=奥妮克希亚守卫
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便召唤两条2/1并具有<b>突袭</b>的雏龙。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=DRAGON
}
public class ONY_001t:MinionBase{
//NAME=奥妮克希亚雏龙
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class ONY_002:MinionBase{
//NAME=全需勇士
//TEXT=<b>嘲讽</b> 如果你在有未使用的法力水晶的情况下结束回合，该牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class ONY_002e:Ability{
//NAME=更多战利品！
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_003:MinionBase{
//NAME=雏龙狂魔
//TEXT=<b>暴怒，荣誉消灭：</b>抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class ONY_004:MinionBase{
//NAME=团本首领奥妮克希亚
//TEXT=<b>突袭</b>。当你控制着雏龙时<b>免疫</b>。<b>战吼：</b>召唤六条2/1并具有<b>突袭</b>的雏龙。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=DRAGON
}
public class ONY_005:MinionBase{
//NAME=卡扎库杉
//TEXT=<b>战吼：</b>在本局对战中，如果你使用过4张其他龙牌，则将你的牌库变为自定义宝藏牌库。@<i>（还剩{0}张！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class ONY_005ta1:SpellBase{
//NAME=死灵毒药
//TEXT=消灭一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ONY_005ta10:SpellBase{
//NAME=望远镜
//TEXT=随机复制对手手牌中的一张牌，将其置入你的手牌。该牌的法力值消耗减少 （3）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_005ta11:MinionBase{
//NAME=发条助手
//TEXT=在本局对战中，你每施放一个法术，便拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=MECHANICAL
}
public class ONY_005ta12:MinionBase{
//NAME=残暴的奴隶主
//TEXT=在你的回合结束时，召唤一个本随从的 复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ONY_005ta13:SpellBase{
//NAME=谜之匣
//TEXT=随机将所有随从变形成为法力值消耗增加（3）点的其他 随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class ONY_005ta2:SpellBase{
//NAME=变异注射
//TEXT=使一个随从获得+4/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class ONY_005ta2e:Ability{
//NAME=变异注射
//TEXT=+4/+4并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005ta3:WeaponBase{
//NAME=驱魔者
//TEXT=<b>沉默</b>此武器攻击的任何随从。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=NONE
}
public class ONY_005ta4:SpellBase{
//NAME=极寒之击
//TEXT=对敌方英雄造成$8点伤害，并使其<b>冻结</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=FROST
}
public class ONY_005ta5:MinionBase{
//NAME=布巴
//TEXT=<b>战吼：</b>召唤六只1/1并具有<b>突袭</b>的血猎犬并使其攻击一个敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class ONY_005ta5t:MinionBase{
//NAME=血猎犬
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ONY_005ta6:SpellBase{
//NAME=神圣典籍
//TEXT=<b>沉默</b>并消灭一个随从。召唤一个它的10/10复制。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=HOLY
}
public class ONY_005ta7:MinionBase{
//NAME=硬壳横行蟹
//TEXT=<b>战吼：</b>消灭一个随从。获得其攻击力和生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class ONY_005ta7e:Ability{
//NAME=嚼啊嚼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005ta8:SpellBase{
//NAME=浮光掠影
//TEXT=抽两张牌。 获得4点护甲值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ONY_005ta9:MinionBase{
//NAME=野兽美女
//TEXT=<b>突袭</b> 在本随从攻击一个随从并存活下来后，变形成为8/8的随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class ONY_005ta9t:MinionBase{
//NAME=美女野兽
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=NONE
}
public class ONY_005tb1:WeaponBase{
//NAME=超级能量枪
//TEXT=<b>剧毒</b> 你的英雄在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class ONY_005tb12:SpellBase{
//NAME=砰砰博士的砰砰箱
//TEXT=召唤七个“砰砰机器人”。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb13:MinionBase{
//NAME=蜡油暴怒者
//TEXT=<b>亡语：</b> 再次召唤本随从。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=ELEMENTAL
}
public class ONY_005tb14:SpellBase{
//NAME=吸血鬼之牙
//TEXT=消灭一个随从。为你的英雄恢复生命值，数值相当于该随从的生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class ONY_005tb1e:Ability{
//NAME=超级能量枪附加效果
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb2:SpellBase{
//NAME=侏儒军刀
//TEXT=使一个随从获得<b>突袭</b>，<b>风怒</b>，<b>圣盾</b>，<b>吸血</b>，<b>剧毒</b>，<b>嘲讽</b>以及<b>潜行</b>。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb2e:Ability{
//NAME=武装到牙齿！
//TEXT=获得<b>突袭</b>，<b>风怒</b>，<b>圣盾</b>，<b>吸血</b>，<b>剧毒</b>，<b>嘲讽</b>以及<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb3:SpellBase{
//NAME=飞蝗来袭
//TEXT=<b>双生法术</b> 选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class ONY_005tb3t:SpellBase{
//NAME=飞蝗来袭
//TEXT=选择一个敌人。用2/2的蝗虫填满你的面板来攻击该敌人。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class ONY_005tb3t2:MinionBase{
//NAME=巨型蝗虫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class ONY_005tb4:SpellBase{
//NAME=裂解魔杖
//TEXT=<b>沉默</b>并消灭所有敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class ONY_005tb5:SpellBase{
//NAME=异鳞之杖
//TEXT=召唤三条1/1并具有<b>突袭，剧毒</b>和<b>复生</b>的蛇。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb5t:MinionBase{
//NAME=远古毒蛇
//TEXT=<b>突袭，剧毒</b> <b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ONY_005tb6:WeaponBase{
//NAME=法奥瑞斯之刃
//TEXT=<b>风怒</b> 在你的英雄攻击并消灭一个随从后，该武器获得+2/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class ONY_005tb610:SpellBase{
//NAME=杰弗里斯的神灯
//TEXT=许愿获得一张完美的卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb6e:Ability{
//NAME=法奥瑞斯之怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb7:SpellBase{
//NAME=坎努匹克陶罐
//TEXT=使你的所有随从获得“<b>亡语：</b>随机召唤一个<b>传说</b>随从。”
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb7e:Ability{
//NAME=坎努匹克陶罐
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb8:SpellBase{
//NAME=远古映像
//TEXT=选择一个随从。用它的1/1的复制填满你的面板。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class ONY_005tb8e:Ability{
//NAME=泰坦全息影像
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tb9:SpellBase{
//NAME=香蕉分裂
//TEXT=使一个友方随从获得+2/+2，并召唤两个它的复制。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class ONY_005tb9e:Ability{
//NAME=青光莹莹
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tc1:SpellBase{
//NAME=拉格纳罗斯的余烬
//TEXT=随机向敌人射出三个火球，每个造成$8点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=FIRE
}
public class ONY_005tc2:SpellBase{
//NAME=亡者之书
//TEXT=对所有敌人造成$7点伤害。在本局对战中，每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=14|ATK=0|HP=0|RACE=SHADOW
}
public class ONY_005tc3:SpellBase{
//NAME=吵吵号角
//TEXT=用吵闹的随从填满你的面板
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tc4:SpellBase{
//NAME=机动炸药
//TEXT=炸掉你对手的一半物资。
//MAJ=NEUTRAL|COST=8|ATK=0|HP=0|RACE=FIRE
}
public class ONY_005tc5:WeaponBase{
//NAME=奎尔德拉的剑刃
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class ONY_005tc6:SpellBase{
//NAME=奎尔德拉的剑柄
//TEXT=使一个随从获得+3/+3。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_005tc6e:Ability{
//NAME=武装？
//TEXT=+3/+3
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=NONE
}
public class ONY_005tc7:WeaponBase{
//NAME=奎尔德拉
//TEXT=在你的英雄攻击后，对所有敌人造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class ONY_005tc7t:SpellBase{
//NAME=铸造奎尔德拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_006:SpellBase{
//NAME=深呼吸
//TEXT=对一个随从及相邻随从造成$1点伤害。<i>（随你手牌中其他法术牌的数量提升。）</i>
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class ONY_007:MinionBase{
//NAME=监护者哈尔琳
//TEXT=在你施放一个法术后，造成4点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class ONY_008:SpellBase{
//NAME=狂怒之嚎
//TEXT=抽一张牌。重复，直到你拥有至少三张牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_009:MinionBase{
//NAME=宠物收集者
//TEXT=<b>战吼：</b>从你的牌库中召唤一只法力值消耗小于或等于（5）点的野兽。
//MAJ=HUNTER|COST=5|ATK=4|HP=4|RACE=NONE
}
public class ONY_010:SpellBase{
//NAME=灭龙射击
//TEXT=造成$2点伤害。<b>荣誉消灭：</b>将一张灭龙射击置入你的手牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_010e:Ability{
//NAME=屠龙射击
//TEXT=法力值消耗减少（1）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_011:SpellBase{
//NAME=别站在火里！
//TEXT=造成$10点伤害，随机分配到所有敌方随从身上。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class ONY_012:SpellBase{
//NAME=灵魂坐骑
//TEXT=使一个随从获得+1/+2和<b>法术伤害+1</b>。当该随从死亡时，召唤一只灵魂迅猛龙。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_012e:Ability{
//NAME=灵魂随身
//TEXT=+1/+2和<b>法术伤害+1</b>。<b>亡语：</b>召唤一只灵魂迅猛龙。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_012t:MinionBase{
//NAME=布鲁坎的迅猛龙
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=2|ATK=1|HP=2|RACE=UNDEAD
}
public class ONY_013:SpellBase{
//NAME=提神冰冷
//TEXT=为你的英雄恢复#5点生命值。随机使你手牌中一张法术牌的法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class ONY_013e:Ability{
//NAME=颤栗
//TEXT=法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_014:SpellBase{
//NAME=敏锐反应
//TEXT=对所有随从造成$1点伤害。<b>荣誉消灭：</b>在本回合中获得+1攻击力。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_014e:Ability{
//NAME=敏锐反应
//TEXT=本回合获得+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_016:SpellBase{
//NAME=憎恨之翼（等级1）
//TEXT=召唤两只1/1的邪翼蝠。<i>（当你有5点法力值时升级。）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_016t:SpellBase{
//NAME=憎恨之翼（等级2）
//TEXT=召唤三只1/1的邪翼蝠。<i>（当你有10点法力值时升级。）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_016t2:SpellBase{
//NAME=憎恨之翼（等级3）
//TEXT=召唤四只1/1的邪翼蝠。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_017:SpellBase{
//NAME=拉希奥的角
//TEXT=抽一张随从牌。如果是龙牌，则召唤两条2/1并具有<b>突袭</b>的雏龙。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		Card Drawn = TaskDrawType(CardType.Minion);
		if(Drawn.raceType.Contains(RaceType.Dragon))
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("ONY_001t"),ZoneType.Board);
			TaskCreate(CardDbf.GetCardDbfByGuid("ONY_001t"),ZoneType.Board);
		}
	}
}
public class ONY_018:MinionBase{
//NAME=暴烈枭兽
//TEXT=<b>抉择：</b>为你的英雄恢复8点生命值；或者造成4点伤害。
//MAJ=DRUID|COST=5|ATK=4|HP=5|RACE=NONE
}
public class ONY_018t:SpellBase{
//NAME=明月之眼
//TEXT=为你的英雄恢复8点生命值。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ONY_018t2:SpellBase{
//NAME=太阳之心
//TEXT=造成4点伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ONY_019:MinionBase{
//NAME=团队协调员
//TEXT=<b>战吼：</b><b>发现</b>一张<b>抉择</b>牌，并使其同时拥有两种效果。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=NONE
}
public class ONY_019e:Ability{
//NAME=团队决策
//TEXT=你的下一张<b>抉择</b>牌会同时拥有两种效果。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_020:MinionBase{
//NAME=暴风城复仇者
//TEXT=在你对本随从施放一个法术后，本随从获得+2攻击力。
//MAJ=PALADIN|COST=3|ATK=1|HP=5|RACE=NONE
}
public class ONY_020e:Ability{
//NAME=戒备
//TEXT=+2攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_021:SpellBase{
//NAME=奥妮克希亚鳞片
//TEXT=用2/1并具有<b>突袭</b>的雏龙填满你的面板
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class ONY_022:MinionBase{
//NAME=武装教士
//TEXT=<b>战吼：</b><b>发现</b>一张神圣法术牌。
//MAJ=PALADIN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class ONY_023:SpellBase{
//NAME=猛力进攻
//TEXT=在本回合中获得+10攻击力和“无法攻击英雄”。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_023e:Ability{
//NAME=好强力
//TEXT=在本回合中+10攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_024:MinionBase{
//NAME=奥妮克希亚幼龙
//TEXT=<b>嘲讽</b>，<b>战吼：</b>对一个敌方随从造成等同于你的护甲值的伤害。
//MAJ=WARRIOR|COST=4|ATK=4|HP=5|RACE=DRAGON
}
public class ONY_025:SpellBase{
//NAME=铁肩冲撞
//TEXT=<b>可交易</b> 使一个随从获得+2/+1和<b>突袭</b>。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ONY_025e:Ability{
//NAME=怒火升起
//TEXT=+2/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_026:MinionBase{
//NAME=光腹虚空幼龙
//TEXT=<b>战吼：</b>如果你的手牌中有神圣法术牌和暗影法术牌，则对所有其他随从造成3点伤害。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class ONY_027:SpellBase{
//NAME=勇气之戒
//TEXT=<b>可交易</b> 使一个随从获得+1/+1。每有一个敌方随从，重复一次。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_027e:Ability{
//NAME=英勇
//TEXT=+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ONY_028:MinionBase{
//NAME=米达，纯净圣光
//TEXT=<b>圣盾</b>，<b>吸血</b>，<b>亡语：</b>将一块碎片洗入你的牌库。抽到碎片时，重新召唤米达。
//MAJ=PRIEST|COST=6|ATK=4|HP=6|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("DivineShield");
		TaskInitAbility("LifeSteal");
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("ONY_028t"),ZoneType.Deck,randpos:true);
	}
}
public class ONY_028t:SpellBase{
//NAME=米达的碎片
//TEXT=<b>抽到时施放</b> 召唤米达，纯净圣光。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==owner)
		{
			if(sz==ZoneType.Deck)
			{
				if(tz==ZoneType.Hand)
				{
					new EffectMove(owner.myPlayer,owner,ZoneType.Hand,ZoneType.Grave).Resolve();
					TaskCreate(CardDbf.GetCardDbfByGuid("ONY_028"),ZoneType.Board);
					TaskDraw();
				}
			}
		}
	}
}
public class ONY_029:SpellBase{
//NAME=龙火护符
//TEXT=<b>可交易</b> <b>发现</b>并召唤两条龙。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=FIRE
}
public class ONY_030:MinionBase{
//NAME=军情七处走私贩
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（1）的随从。<i>（在本局对战中你每使用一张军情七处牌都会升级。）</i>
//MAJ=ROGUE|COST=3|ATK=1|HP=3|RACE=NONE
}
public class ONY_031:SpellBase{
//NAME=烟幕
//TEXT=抽五张牌。触发抽到的牌的<b>亡语</b>。
//MAJ=ROGUE|COST=8|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<5;i++)
		{
			Card Drawn = TaskDraw();
			if(Drawn!=null)
			{
				for(int j = Drawn.abilityList.Count-1;j>=0;j--)
				{
					Drawn.abilityList[j].Deathrattle();
				}
			}
		}
	}
}
public class ONY_032:SpellBase{
//NAME=奈法利安的牙
//TEXT=造成$3点伤害。<b>荣誉消灭：</b><b>发现</b>一张另一职业的法术牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ONY_033:SpellBase{
//NAME=小鬼侵染
//TEXT=每有一个敌方随从，便召唤一个3/3的恐惧小鬼并使其攻击对应敌方随从。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=FEL
}
public class ONY_034:SpellBase{
//NAME=痛苦诅咒
//TEXT=将三张痛苦洗入你对手的牌库。抽到痛苦时会造成疲劳伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class ONY_034t:SpellBase{
//NAME=痛苦
//TEXT=<b>抽到时施放</b> 受到1点疲劳伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class ONY_035:MinionBase{
//NAME=死亡之翼的子嗣
//TEXT=<b>战吼：</b>随机消灭一个敌方随从。随机弃一张牌。
//MAJ=WARLOCK|COST=5|ATK=6|HP=6|RACE=DRAGON
}
public class ONY_036:MinionBase{
//NAME=爪刃哨兵
//TEXT=在你使用最左或最右边的一张手牌后，抽一张牌。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=4|RACE=NONE
}
